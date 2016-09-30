// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Fluent.Network
{

    using NetworkInterface.Update;
    using Management.Network.Models;
    using NetworkInterface.Definition;
    using System.Collections.Generic;
    using Resource.Core.ResourceActions;
    using Resource;
    using Resource.Core;
    using Management.Network;
    using System.Threading.Tasks;

    /// <summary>
    /// Implementation for NetworkInterface and its create and update interfaces.
    /// </summary>
    public partial class NetworkInterfaceImpl :
        GroupableParentResource<INetworkInterface,
                NetworkInterfaceInner,
                Rest.Azure.Resource,
                NetworkInterfaceImpl,
                NetworkManager,
                IWithGroup,
                IWithPrimaryNetwork,
                IWithCreate,
                IUpdate>,
            INetworkInterface,
            IDefinition,
            IUpdate

    {
        private INetworkInterfacesOperations innerCollection;
        private string nicName;
        protected ResourceNamer namer;
        private NicIpConfigurationImpl nicPrimaryIpConfiguration;
        private IDictionary<string, INicIpConfiguration> nicIpConfigurations;
        private string creatableNetworkSecurityGroupKey;
        private INetworkSecurityGroup existingNetworkSecurityGroupToAssociate;
        private INetworkSecurityGroup networkSecurityGroup;

        internal NetworkInterfaceImpl(
            string name,
            NetworkInterfaceInner innerModel,
            INetworkInterfacesOperations client,
            NetworkManager networkManager) : base(name, innerModel, networkManager)
        {
            this.innerCollection = client;
            this.nicName = name;
            this.namer = new ResourceNamer(this.nicName);
            InitializeChildrenFromInner();
        }

        public NetworkInterfaceImpl WithNewPrimaryNetwork(ICreatable<INetwork> creatable)
        {
            PrimaryIpConfiguration().WithNewNetwork(creatable);
            return this;
        }

        public NetworkInterfaceImpl WithNewPrimaryNetwork(string name, string addressSpaceCidr)
        {
            PrimaryIpConfiguration().WithNewNetwork(name, addressSpaceCidr);
            return this;
        }

        public override INetworkInterface Refresh()
        {
            var response = this.innerCollection.Get(ResourceGroupName, nicName);
            SetInner(response);
            return this;
        }

        public NetworkInterfaceImpl WithNewPrimaryNetwork(string addressSpaceCidr)
        {
            PrimaryIpConfiguration().WithNewNetwork(addressSpaceCidr);
            return this;
        }

        public NetworkInterfaceImpl WithExistingPrimaryNetwork(INetwork network)
        {
            PrimaryIpConfiguration().WithExistingNetwork(network);
            return this;
        }

        public NetworkInterfaceImpl WithNewPrimaryPublicIpAddress(ICreatable<IPublicIpAddress> creatable)
        {
            PrimaryIpConfiguration().WithNewPublicIpAddress(creatable);
            return this;
        }

        public NetworkInterfaceImpl WithNewPrimaryPublicIpAddress()
        {
            PrimaryIpConfiguration().WithNewPublicIpAddress();
            return this;
        }

        public NetworkInterfaceImpl WithNewPrimaryPublicIpAddress(string leafDnsLabel)
        {
            PrimaryIpConfiguration().WithNewPublicIpAddress(leafDnsLabel);
            return this;
        }

        public NetworkInterfaceImpl WithExistingLoadBalancerBackend(ILoadBalancer loadBalancer, string backendName)
        {
            PrimaryIpConfiguration().WithExistingLoadBalancerBackend(loadBalancer, backendName);
            return this;
        }

        public NetworkInterfaceImpl WithExistingLoadBalancerInboundNatRule(ILoadBalancer loadBalancer, string inboundNatRuleName)
        {
            PrimaryIpConfiguration().WithExistingLoadBalancerInboundNatRule(loadBalancer, inboundNatRuleName);
            return this;
        }

        public IUpdate WithoutLoadBalancerBackends()
        {
            foreach (var ipConfig in IpConfigurations().Values)
            {
                UpdateIpConfiguration(ipConfig.Name)
                   .WithoutLoadBalancerBackends();
            }

            return null;
        }

        public IUpdate WithoutLoadBalancerInboundNatRules()
        {
            foreach (var ipConfig in IpConfigurations().Values)
            {
                UpdateIpConfiguration(ipConfig.Name)
                    .WithoutLoadBalancerInboundNatRules();
            }

            return this;
        }

        public NetworkInterfaceImpl WithoutPrimaryPublicIpAddress()
        {
            this.PrimaryIpConfiguration().WithoutPublicIpAddress();
            return this;
        }

        public NetworkInterfaceImpl WithExistingPrimaryPublicIpAddress(IPublicIpAddress publicIpAddress)
        {
            this.PrimaryIpConfiguration().WithExistingPublicIpAddress(publicIpAddress);
            return this;
        }

        public NetworkInterfaceImpl WithPrimaryPrivateIpAddressDynamic()
        {
            this.PrimaryIpConfiguration().WithPrivateIpAddressDynamic();
            return this;
        }

        public NetworkInterfaceImpl WithPrimaryPrivateIpAddressStatic(string staticPrivateIpAddress)
        {
            this.PrimaryIpConfiguration().WithPrivateIpAddressStatic(staticPrivateIpAddress);
            return this;
        }

        public NetworkInterfaceImpl WithNewNetworkSecurityGroup(ICreatable<INetworkSecurityGroup> creatable)
        {
            if (this.creatableNetworkSecurityGroupKey == null)
            {
                this.creatableNetworkSecurityGroupKey = creatable.Key;
                this.AddCreatableDependency(creatable as IResourceCreator<Fluent.Resource.Core.IResource>);
            }

            return this;
        }

        public NetworkInterfaceImpl WithExistingNetworkSecurityGroup(INetworkSecurityGroup networkSecurityGroup)
        {
            this.existingNetworkSecurityGroupToAssociate = networkSecurityGroup;
            return this;
        }

        public NetworkInterfaceImpl WithoutNetworkSecurityGroup()
        {
            this.Inner.NetworkSecurityGroup = null;
            return this;
        }

        public NicIpConfigurationImpl DefineSecondaryIpConfiguration(string name)
        {
            return PrepareNewNicIpConfiguration(name);
        }

        public NicIpConfigurationImpl UpdateIpConfiguration(string name)
        {
            return (NicIpConfigurationImpl)this.nicIpConfigurations[name];
        }

        public NetworkInterfaceImpl WithIpForwarding()
        {
            Inner.EnableIPForwarding = true;
            return this;
        }

        public NetworkInterfaceImpl WithoutIpConfiguration(string name)
        {
            nicIpConfigurations.Remove(name);
            return this;
        }

        public NetworkInterfaceImpl WithoutIpForwarding()
        {
            Inner.EnableIPForwarding = false;
            return this;
        }

        public NetworkInterfaceImpl WithDnsServer(string ipAddress)
        {
            DnsServerIps.Add(ipAddress);
            return this;
        }

        public NetworkInterfaceImpl WithoutDnsServer(string ipAddress)
        {
            DnsServerIps.Remove(ipAddress);
            return this;
        }

        public NetworkInterfaceImpl WithAzureDnsServer()
        {
            DnsServerIps.Clear();
            return this;
        }

        public NetworkInterfaceImpl WithSubnet(string name)
        {
            PrimaryIpConfiguration().WithSubnet(name);
            return this;
        }

        public NetworkInterfaceImpl WithInternalDnsNameLabel(string dnsNameLabel)
        {
            Inner.DnsSettings.InternalDnsNameLabel = dnsNameLabel;
            return this;
        }

        public string VirtualMachineId
        {
            get
            {
                return (Inner.VirtualMachine != null) ? Inner.VirtualMachine.Id : null;
            }
        }

        public bool IsIpForwardingEnabled
        {
            get
            {
                return (Inner.EnableIPForwarding.HasValue) ? Inner.EnableIPForwarding.Value : false;
            }
        }

        public string MacAddress
        {
            get
            {
                return Inner.MacAddress;
            }
        }

        public string InternalDnsNameLabel
        {
            get
            {
                return (Inner.DnsSettings != null) ? Inner.DnsSettings.InternalDnsNameLabel : null;
            }
        }

        public string InternalDomainNameSuffix
        {
            get
            {
                return (Inner.DnsSettings != null) ? Inner.DnsSettings.InternalDomainNameSuffix : null;
            }
        }

        public IList<string> AppliedDnsServers
        {
            get
            {
                List<string> dnsServers = new List<string>();
                if (Inner.DnsSettings == null)
                    return dnsServers;
                else if (Inner.DnsSettings.AppliedDnsServers == null)
                    return dnsServers;
                else
                    return Inner.DnsSettings.AppliedDnsServers;
            }
        }

        public string InternalFqdn
        {
            get
            {
                return (Inner.DnsSettings != null) ? Inner.DnsSettings.InternalFqdn : null;
            }
        }

        public IList<string> DnsServers
        {
            get
            {
                return this.DnsServerIps;
            }
        }

        public string PrimaryPrivateIp
        {
            get
            {
                return PrimaryIpConfiguration().PrivateIpAddress;
            }
        }
        public string PrimaryPrivateIpAllocationMethod
        {
            get
            {
                return PrimaryIpConfiguration().PrivateIpAllocationMethod;
            }
        }

        public IDictionary<string, INicIpConfiguration> IpConfigurations()
        {
            return nicIpConfigurations;
        }

        public string NetworkSecurityGroupId
        {
            get
            {
                return (Inner.NetworkSecurityGroup != null) ? Inner.NetworkSecurityGroup.Id : null;
            }
        }

        public INetworkSecurityGroup GetNetworkSecurityGroup()
        {
            if (networkSecurityGroup == null && NetworkSecurityGroupId != null)
            {
                string id = NetworkSecurityGroupId;
                networkSecurityGroup = base.Manager
                    .NetworkSecurityGroups
                    .GetByGroup(ResourceUtils.GroupFromResourceId(id), ResourceUtils.NameFromResourceId(id));
            }
            return networkSecurityGroup;
        }

        /// <returns>the primary IP configuration of the network interface</returns>
        public NicIpConfigurationImpl PrimaryIpConfiguration()
        {
            if (nicPrimaryIpConfiguration != null)
            {
                return nicPrimaryIpConfiguration;
            }

            if (IsInCreateMode)
            {
                nicPrimaryIpConfiguration = PrepareNewNicIpConfiguration("primary");
                WithIpConfiguration(nicPrimaryIpConfiguration);
            }
            else
            {
                // TODO: Currently Azure supports only one IP configuration and that is the primary
                // hence we pick the first one here.
                // when Azure support multiple IP configurations then there will be a flag in
                // the IPConfiguration or a property in the network interface to identify the
                // primary so below logic will be changed.
                nicPrimaryIpConfiguration = (NicIpConfigurationImpl)new List<INicIpConfiguration>(
                    nicIpConfigurations.Values)[0];
            }
            return nicPrimaryIpConfiguration;
        }

        /// <returns>the list of DNS server IPs from the DNS settings</returns>
        private IList<string> DnsServerIps
        {
            get
            {
                List<string> dnsServers = new List<string>();
                if (Inner.DnsSettings == null)
                    return dnsServers;
                else if (Inner.DnsSettings.DnsServers == null)
                    return dnsServers;
                else
                    return Inner.DnsSettings.DnsServers;
            }
        }

        override protected void InitializeChildrenFromInner()
        {
            nicIpConfigurations = new Dictionary<string, INicIpConfiguration>();
            IList<NetworkInterfaceIPConfigurationInner> inners = Inner.IpConfigurations;
            if (inners != null)
            {
                foreach (NetworkInterfaceIPConfigurationInner inner in inners)
                {
                    NicIpConfigurationImpl nicIpConfiguration = new NicIpConfigurationImpl(inner, this, Manager, false);
                    nicIpConfigurations.Add(nicIpConfiguration.Name(), nicIpConfiguration);
                }
            }
        }

        /// <summary>
        /// Gets a new IP configuration child resource NicIpConfiguration wrapping NetworkInterfaceIPConfigurationInner.
        /// </summary>
        /// <param name="name">name the name for the new ip configuration</param>
        /// <returns>NicIpConfiguration</returns>
        private NicIpConfigurationImpl PrepareNewNicIpConfiguration(string name)
        {
            NicIpConfigurationImpl nicIpConfiguration = NicIpConfigurationImpl.PrepareNicIpConfiguration(name, this, Manager);
            return nicIpConfiguration;
        }

        private void ClearCachedRelatedResources()
        {
            networkSecurityGroup = null;
            nicPrimaryIpConfiguration = null;
        }

        internal NetworkInterfaceImpl WithIpConfiguration(NicIpConfigurationImpl nicIpConfiguration)
        {
            nicIpConfigurations.Add(nicIpConfiguration.Name(), nicIpConfiguration);
            return this;
        }

        internal void AddToCreatableDependencies(ICreatable<Fluent.Resource.Core.IResource> creatableResource)
        {
            AddCreatableDependency(creatableResource as IResourceCreator<Fluent.Resource.Core.IResource>);
        }

        internal Fluent.Resource.Core.IResource CreatedDependencyResource(string key)
        {
            return CreatedResource(key);
        }

        internal ICreatable<IResourceGroup> NewGroup()
        {
            return newGroup;
        }

        override protected Task<NetworkInterfaceInner> CreateInner()
        {
            return innerCollection.CreateOrUpdateAsync(ResourceGroupName, Name, Inner);
        }

        override protected void AfterCreating()
        {
            ClearCachedRelatedResources();
        }

        override protected void BeforeCreating()
        {
            INetworkSecurityGroup networkSecurityGroup = null;
            if (creatableNetworkSecurityGroupKey != null)
            {
                networkSecurityGroup = (INetworkSecurityGroup)this.CreatedResource(creatableNetworkSecurityGroupKey);
            }
            else if (existingNetworkSecurityGroupToAssociate != null)
            {
                networkSecurityGroup = existingNetworkSecurityGroupToAssociate;
            }

            // Associate an NSG if needed
            if (networkSecurityGroup != null)
            {
                Inner.NetworkSecurityGroup =
                    Manager.NetworkSecurityGroups.GetById(networkSecurityGroup.Id).Inner;
            }

            NicIpConfigurationImpl.EnsureConfigurations(new List<INicIpConfiguration>(nicIpConfigurations.Values));

            // Reset and update IP configs
            Inner.IpConfigurations =
                InnersFromWrappers<NetworkInterfaceIPConfigurationInner, INicIpConfiguration>(nicIpConfigurations.Values);
        }
    }
}