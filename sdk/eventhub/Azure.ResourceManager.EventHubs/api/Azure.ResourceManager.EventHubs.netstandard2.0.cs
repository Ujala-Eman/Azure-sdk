namespace Azure.ResourceManager.EventHubs
{
    public static partial class ArmClientExtensions
    {
        public static Azure.ResourceManager.EventHubs.ArmDisasterRecovery GetArmDisasterRecovery(this Azure.ResourceManager.ArmClient armClient, Azure.ResourceManager.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.EventHubs.AuthorizationRuleDisasterRecoveryConfig GetAuthorizationRuleDisasterRecoveryConfig(this Azure.ResourceManager.ArmClient armClient, Azure.ResourceManager.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.EventHubs.AuthorizationRuleEventHub GetAuthorizationRuleEventHub(this Azure.ResourceManager.ArmClient armClient, Azure.ResourceManager.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.EventHubs.AuthorizationRuleNamespace GetAuthorizationRuleNamespace(this Azure.ResourceManager.ArmClient armClient, Azure.ResourceManager.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.EventHubs.Cluster GetCluster(this Azure.ResourceManager.ArmClient armClient, Azure.ResourceManager.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.EventHubs.ClusterQuotaConfigurationProperties GetClusterQuotaConfigurationProperties(this Azure.ResourceManager.ArmClient armClient, Azure.ResourceManager.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.EventHubs.ConsumerGroup GetConsumerGroup(this Azure.ResourceManager.ArmClient armClient, Azure.ResourceManager.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.EventHubs.EHNamespace GetEHNamespace(this Azure.ResourceManager.ArmClient armClient, Azure.ResourceManager.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.EventHubs.Eventhub GetEventhub(this Azure.ResourceManager.ArmClient armClient, Azure.ResourceManager.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.EventHubs.IpFilterRule GetIpFilterRule(this Azure.ResourceManager.ArmClient armClient, Azure.ResourceManager.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.EventHubs.PrivateEndpointConnection GetPrivateEndpointConnection(this Azure.ResourceManager.ArmClient armClient, Azure.ResourceManager.ResourceIdentifier id) { throw null; }
    }
    public partial class ArmDisasterRecovery : Azure.ResourceManager.Core.ArmResource
    {
        public static readonly Azure.ResourceManager.ResourceType ResourceType;
        protected ArmDisasterRecovery() { }
        public virtual Azure.ResourceManager.EventHubs.ArmDisasterRecoveryData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        protected override Azure.ResourceManager.ResourceType ValidResourceType { get { throw null; } }
        public virtual Azure.Response BreakPairing(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> BreakPairingAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.EventHubs.Models.DisasterRecoveryConfigDeleteOperation Delete(bool waitForCompletion = true, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.EventHubs.Models.DisasterRecoveryConfigDeleteOperation> DeleteAsync(bool waitForCompletion = true, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response FailOver(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> FailOverAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.ArmDisasterRecovery> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.ArmDisasterRecovery>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public Azure.ResourceManager.EventHubs.AuthorizationRuleDisasterRecoveryConfigContainer GetAuthorizationRuleDisasterRecoveryConfigs() { throw null; }
        public virtual System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.Models.Location> GetAvailableLocations(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.Models.Location>> GetAvailableLocationsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ArmDisasterRecoveryContainer : Azure.ResourceManager.Core.ArmContainer
    {
        protected ArmDisasterRecoveryContainer() { }
        protected override Azure.ResourceManager.ResourceType ValidResourceType { get { throw null; } }
        public virtual Azure.Response<bool> CheckIfExists(string alias, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> CheckIfExistsAsync(string alias, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.EventHubs.Models.DisasterRecoveryConfigCreateOrUpdateOperation CreateOrUpdate(string alias, Azure.ResourceManager.EventHubs.ArmDisasterRecoveryData parameters, bool waitForCompletion = true, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.EventHubs.Models.DisasterRecoveryConfigCreateOrUpdateOperation> CreateOrUpdateAsync(string alias, Azure.ResourceManager.EventHubs.ArmDisasterRecoveryData parameters, bool waitForCompletion = true, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.ArmDisasterRecovery> Get(string alias, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.EventHubs.ArmDisasterRecovery> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.EventHubs.ArmDisasterRecovery> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.ArmDisasterRecovery>> GetAsync(string alias, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.ArmDisasterRecovery> GetIfExists(string alias, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.ArmDisasterRecovery>> GetIfExistsAsync(string alias, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ArmDisasterRecoveryData : Azure.ResourceManager.Models.Resource
    {
        public ArmDisasterRecoveryData() { }
        public string AlternateName { get { throw null; } set { } }
        public string PartnerNamespace { get { throw null; } set { } }
        public long? PendingReplicationOperationsCount { get { throw null; } }
        public Azure.ResourceManager.EventHubs.Models.ProvisioningStateDR? ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.EventHubs.Models.RoleDisasterRecovery? Role { get { throw null; } }
    }
    public partial class AuthorizationRuleData : Azure.ResourceManager.Models.Resource
    {
        public AuthorizationRuleData() { }
        public System.Collections.Generic.IList<Azure.ResourceManager.EventHubs.Models.AccessRights> Rights { get { throw null; } }
    }
    public partial class AuthorizationRuleDisasterRecoveryConfig : Azure.ResourceManager.Core.ArmResource
    {
        public static readonly Azure.ResourceManager.ResourceType ResourceType;
        protected AuthorizationRuleDisasterRecoveryConfig() { }
        public virtual Azure.ResourceManager.EventHubs.AuthorizationRuleData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        protected override Azure.ResourceManager.ResourceType ValidResourceType { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.AuthorizationRuleDisasterRecoveryConfig> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.AuthorizationRuleDisasterRecoveryConfig>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.Models.Location> GetAvailableLocations(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.Models.Location>> GetAvailableLocationsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.Models.AccessKeys> GetKeys(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.Models.AccessKeys>> GetKeysAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class AuthorizationRuleDisasterRecoveryConfigContainer : Azure.ResourceManager.Core.ArmContainer
    {
        protected AuthorizationRuleDisasterRecoveryConfigContainer() { }
        protected override Azure.ResourceManager.ResourceType ValidResourceType { get { throw null; } }
        public virtual Azure.Response<bool> CheckIfExists(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> CheckIfExistsAsync(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.AuthorizationRuleDisasterRecoveryConfig> Get(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.EventHubs.AuthorizationRuleDisasterRecoveryConfig> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.EventHubs.AuthorizationRuleDisasterRecoveryConfig> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.AuthorizationRuleDisasterRecoveryConfig>> GetAsync(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.AuthorizationRuleDisasterRecoveryConfig> GetIfExists(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.AuthorizationRuleDisasterRecoveryConfig>> GetIfExistsAsync(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class AuthorizationRuleEventHub : Azure.ResourceManager.Core.ArmResource
    {
        public static readonly Azure.ResourceManager.ResourceType ResourceType;
        protected AuthorizationRuleEventHub() { }
        public virtual Azure.ResourceManager.EventHubs.AuthorizationRuleData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        protected override Azure.ResourceManager.ResourceType ValidResourceType { get { throw null; } }
        public virtual Azure.ResourceManager.EventHubs.Models.EventHubAuthorizationRuleDeleteOperation Delete(bool waitForCompletion = true, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.EventHubs.Models.EventHubAuthorizationRuleDeleteOperation> DeleteAsync(bool waitForCompletion = true, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.AuthorizationRuleEventHub> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.AuthorizationRuleEventHub>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.Models.Location> GetAvailableLocations(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.Models.Location>> GetAvailableLocationsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.Models.AccessKeys> GetKeys(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.Models.AccessKeys>> GetKeysAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.Models.AccessKeys> RegenerateKeys(Azure.ResourceManager.EventHubs.Models.RegenerateAccessKeyParameters parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.Models.AccessKeys>> RegenerateKeysAsync(Azure.ResourceManager.EventHubs.Models.RegenerateAccessKeyParameters parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class AuthorizationRuleEventHubContainer : Azure.ResourceManager.Core.ArmContainer
    {
        protected AuthorizationRuleEventHubContainer() { }
        protected override Azure.ResourceManager.ResourceType ValidResourceType { get { throw null; } }
        public virtual Azure.Response<bool> CheckIfExists(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> CheckIfExistsAsync(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.EventHubs.Models.EventHubAuthorizationRuleCreateOrUpdateOperation CreateOrUpdate(string authorizationRuleName, Azure.ResourceManager.EventHubs.AuthorizationRuleData parameters, bool waitForCompletion = true, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.EventHubs.Models.EventHubAuthorizationRuleCreateOrUpdateOperation> CreateOrUpdateAsync(string authorizationRuleName, Azure.ResourceManager.EventHubs.AuthorizationRuleData parameters, bool waitForCompletion = true, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.AuthorizationRuleEventHub> Get(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.EventHubs.AuthorizationRuleEventHub> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.EventHubs.AuthorizationRuleEventHub> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.AuthorizationRuleEventHub>> GetAsync(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.AuthorizationRuleEventHub> GetIfExists(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.AuthorizationRuleEventHub>> GetIfExistsAsync(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class AuthorizationRuleNamespace : Azure.ResourceManager.Core.ArmResource
    {
        public static readonly Azure.ResourceManager.ResourceType ResourceType;
        protected AuthorizationRuleNamespace() { }
        public virtual Azure.ResourceManager.EventHubs.AuthorizationRuleData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        protected override Azure.ResourceManager.ResourceType ValidResourceType { get { throw null; } }
        public virtual Azure.ResourceManager.EventHubs.Models.NamespaceAuthorizationRuleDeleteOperation Delete(bool waitForCompletion = true, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.EventHubs.Models.NamespaceAuthorizationRuleDeleteOperation> DeleteAsync(bool waitForCompletion = true, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.AuthorizationRuleNamespace> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.AuthorizationRuleNamespace>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.Models.Location> GetAvailableLocations(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.Models.Location>> GetAvailableLocationsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.Models.AccessKeys> GetKeys(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.Models.AccessKeys>> GetKeysAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.Models.AccessKeys> RegenerateKeys(Azure.ResourceManager.EventHubs.Models.RegenerateAccessKeyParameters parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.Models.AccessKeys>> RegenerateKeysAsync(Azure.ResourceManager.EventHubs.Models.RegenerateAccessKeyParameters parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class AuthorizationRuleNamespaceContainer : Azure.ResourceManager.Core.ArmContainer
    {
        protected AuthorizationRuleNamespaceContainer() { }
        protected override Azure.ResourceManager.ResourceType ValidResourceType { get { throw null; } }
        public virtual Azure.Response<bool> CheckIfExists(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> CheckIfExistsAsync(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.EventHubs.Models.NamespaceAuthorizationRuleCreateOrUpdateOperation CreateOrUpdate(string authorizationRuleName, Azure.ResourceManager.EventHubs.AuthorizationRuleData parameters, bool waitForCompletion = true, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.EventHubs.Models.NamespaceAuthorizationRuleCreateOrUpdateOperation> CreateOrUpdateAsync(string authorizationRuleName, Azure.ResourceManager.EventHubs.AuthorizationRuleData parameters, bool waitForCompletion = true, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.AuthorizationRuleNamespace> Get(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.EventHubs.AuthorizationRuleNamespace> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.EventHubs.AuthorizationRuleNamespace> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.AuthorizationRuleNamespace>> GetAsync(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.AuthorizationRuleNamespace> GetIfExists(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.AuthorizationRuleNamespace>> GetIfExistsAsync(string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class Cluster : Azure.ResourceManager.Core.ArmResource
    {
        public static readonly Azure.ResourceManager.ResourceType ResourceType;
        protected Cluster() { }
        public virtual Azure.ResourceManager.EventHubs.ClusterData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        protected override Azure.ResourceManager.ResourceType ValidResourceType { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.Cluster> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.Cluster>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.EventHubs.Models.ClusterDeleteOperation Delete(bool waitForCompletion = true, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.EventHubs.Models.ClusterDeleteOperation> DeleteAsync(bool waitForCompletion = true, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.Cluster> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.Cluster>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.Models.Location> GetAvailableLocations(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.Models.Location>> GetAvailableLocationsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public Azure.ResourceManager.EventHubs.ClusterQuotaConfigurationProperties GetClusterQuotaConfigurationProperties() { throw null; }
        public virtual Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Resources.Models.SubResource>> GetNamespaces(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Resources.Models.SubResource>>> GetNamespacesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.Cluster> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.Cluster>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.Cluster> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.Cluster>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.EventHubs.Models.ClusterUpdateOperation Update(Azure.ResourceManager.EventHubs.ClusterData parameters, bool waitForCompletion = true, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.EventHubs.Models.ClusterUpdateOperation> UpdateAsync(Azure.ResourceManager.EventHubs.ClusterData parameters, bool waitForCompletion = true, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ClusterContainer : Azure.ResourceManager.Core.ArmContainer
    {
        protected ClusterContainer() { }
        protected override Azure.ResourceManager.ResourceType ValidResourceType { get { throw null; } }
        public virtual Azure.Response<bool> CheckIfExists(string clusterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> CheckIfExistsAsync(string clusterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.EventHubs.Models.ClusterCreateOrUpdateOperation CreateOrUpdate(string clusterName, Azure.ResourceManager.EventHubs.ClusterData parameters, bool waitForCompletion = true, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.EventHubs.Models.ClusterCreateOrUpdateOperation> CreateOrUpdateAsync(string clusterName, Azure.ResourceManager.EventHubs.ClusterData parameters, bool waitForCompletion = true, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.Cluster> Get(string clusterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.EventHubs.Cluster> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Resources.GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Resources.GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.EventHubs.Cluster> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.Cluster>> GetAsync(string clusterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.Cluster> GetIfExists(string clusterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.Cluster>> GetIfExistsAsync(string clusterName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ClusterData : Azure.ResourceManager.Models.TrackedResource
    {
        public ClusterData(Azure.ResourceManager.Resources.Models.Location location) : base (default(Azure.ResourceManager.Resources.Models.Location)) { }
        public string CreatedAt { get { throw null; } }
        public string MetricId { get { throw null; } }
        public Azure.ResourceManager.EventHubs.Models.ClusterSku Sku { get { throw null; } set { } }
        public string Status { get { throw null; } }
        public string UpdatedAt { get { throw null; } }
    }
    public partial class ClusterQuotaConfigurationProperties : Azure.ResourceManager.Core.ArmResource
    {
        public static readonly Azure.ResourceManager.ResourceType ResourceType;
        protected ClusterQuotaConfigurationProperties() { }
        public virtual Azure.ResourceManager.EventHubs.ClusterQuotaConfigurationPropertiesData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public Azure.ResourceManager.Core.ArmResource Parent { get { throw null; } }
        protected override Azure.ResourceManager.ResourceType ValidResourceType { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.ClusterQuotaConfigurationProperties> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.ClusterQuotaConfigurationProperties>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.Models.Location> GetAvailableLocations(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.Models.Location>> GetAvailableLocationsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.ClusterQuotaConfigurationProperties> Patch(Azure.ResourceManager.EventHubs.ClusterQuotaConfigurationPropertiesData parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.ClusterQuotaConfigurationProperties>> PatchAsync(Azure.ResourceManager.EventHubs.ClusterQuotaConfigurationPropertiesData parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ClusterQuotaConfigurationPropertiesData
    {
        public ClusterQuotaConfigurationPropertiesData() { }
        public System.Collections.Generic.IDictionary<string, string> Settings { get { throw null; } }
    }
    public partial class ConsumerGroup : Azure.ResourceManager.Core.ArmResource
    {
        public static readonly Azure.ResourceManager.ResourceType ResourceType;
        protected ConsumerGroup() { }
        public virtual Azure.ResourceManager.EventHubs.ConsumerGroupData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        protected override Azure.ResourceManager.ResourceType ValidResourceType { get { throw null; } }
        public virtual Azure.ResourceManager.EventHubs.Models.ConsumerGroupDeleteOperation Delete(bool waitForCompletion = true, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.EventHubs.Models.ConsumerGroupDeleteOperation> DeleteAsync(bool waitForCompletion = true, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.ConsumerGroup> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.ConsumerGroup>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.Models.Location> GetAvailableLocations(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.Models.Location>> GetAvailableLocationsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ConsumerGroupContainer : Azure.ResourceManager.Core.ArmContainer
    {
        protected ConsumerGroupContainer() { }
        protected override Azure.ResourceManager.ResourceType ValidResourceType { get { throw null; } }
        public virtual Azure.Response<bool> CheckIfExists(string consumerGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> CheckIfExistsAsync(string consumerGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.EventHubs.Models.ConsumerGroupCreateOrUpdateOperation CreateOrUpdate(string consumerGroupName, Azure.ResourceManager.EventHubs.ConsumerGroupData parameters, bool waitForCompletion = true, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.EventHubs.Models.ConsumerGroupCreateOrUpdateOperation> CreateOrUpdateAsync(string consumerGroupName, Azure.ResourceManager.EventHubs.ConsumerGroupData parameters, bool waitForCompletion = true, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.ConsumerGroup> Get(string consumerGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.EventHubs.ConsumerGroup> GetAll(int? skip = default(int?), int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.EventHubs.ConsumerGroup> GetAllAsync(int? skip = default(int?), int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.ConsumerGroup>> GetAsync(string consumerGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.ConsumerGroup> GetIfExists(string consumerGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.ConsumerGroup>> GetIfExistsAsync(string consumerGroupName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ConsumerGroupData : Azure.ResourceManager.Models.Resource
    {
        public ConsumerGroupData() { }
        public System.DateTimeOffset? CreatedAt { get { throw null; } }
        public System.DateTimeOffset? UpdatedAt { get { throw null; } }
        public string UserMetadata { get { throw null; } set { } }
    }
    public partial class EHNamespace : Azure.ResourceManager.Core.ArmResource
    {
        public static readonly Azure.ResourceManager.ResourceType ResourceType;
        protected EHNamespace() { }
        public virtual Azure.ResourceManager.EventHubs.EHNamespaceData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        protected override Azure.ResourceManager.ResourceType ValidResourceType { get { throw null; } }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.EHNamespace> AddTag(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.EHNamespace>> AddTagAsync(string key, string value, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.Models.CheckNameAvailabilityResult> CheckDisasterRecoveryConfigNameAvailability(Azure.ResourceManager.EventHubs.Models.CheckNameAvailabilityParameter parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.Models.CheckNameAvailabilityResult>> CheckDisasterRecoveryConfigNameAvailabilityAsync(Azure.ResourceManager.EventHubs.Models.CheckNameAvailabilityParameter parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.Models.NetworkRuleSet> CreateOrUpdateNetworkRuleSet(Azure.ResourceManager.EventHubs.Models.NetworkRuleSet parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.Models.NetworkRuleSet>> CreateOrUpdateNetworkRuleSetAsync(Azure.ResourceManager.EventHubs.Models.NetworkRuleSet parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.Models.VirtualNetworkRule> CreateOrUpdateVirtualNetworkRule(Azure.ResourceManager.EventHubs.Models.VirtualNetworkRule parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.Models.VirtualNetworkRule>> CreateOrUpdateVirtualNetworkRuleAsync(Azure.ResourceManager.EventHubs.Models.VirtualNetworkRule parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.EventHubs.Models.NamespaceDeleteOperation Delete(bool waitForCompletion = true, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.EventHubs.Models.NamespaceDeleteOperation> DeleteAsync(bool waitForCompletion = true, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response DeleteVirtualNetworkRule(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response> DeleteVirtualNetworkRuleAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.EHNamespace> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public Azure.ResourceManager.EventHubs.ArmDisasterRecoveryContainer GetArmDisasterRecoveries() { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.EHNamespace>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public Azure.ResourceManager.EventHubs.AuthorizationRuleNamespaceContainer GetAuthorizationRuleNamespaces() { throw null; }
        public virtual System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.Models.Location> GetAvailableLocations(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.Models.Location>> GetAvailableLocationsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public Azure.ResourceManager.EventHubs.EventhubContainer GetEventhubs() { throw null; }
        public Azure.ResourceManager.EventHubs.IpFilterRuleContainer GetIpFilterRules() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.Models.NetworkRuleSet> GetNetworkRuleSet(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.Models.NetworkRuleSet>> GetNetworkRuleSetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public Azure.ResourceManager.EventHubs.PrivateEndpointConnectionContainer GetPrivateEndpointConnections() { throw null; }
        public virtual Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.EventHubs.Models.PrivateLinkResource>> GetPrivateLinkResources(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.EventHubs.Models.PrivateLinkResource>>> GetPrivateLinkResourcesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.Models.VirtualNetworkRule> GetVirtualNetworkRule(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.Models.VirtualNetworkRule>> GetVirtualNetworkRuleAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.EventHubs.Models.VirtualNetworkRule> GetVirtualNetworkRules(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.EventHubs.Models.VirtualNetworkRule> GetVirtualNetworkRulesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.EHNamespace> RemoveTag(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.EHNamespace>> RemoveTagAsync(string key, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.EHNamespace> SetTags(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.EHNamespace>> SetTagsAsync(System.Collections.Generic.IDictionary<string, string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.EHNamespace> Update(Azure.ResourceManager.EventHubs.EHNamespaceData parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.EHNamespace>> UpdateAsync(Azure.ResourceManager.EventHubs.EHNamespaceData parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class EHNamespaceContainer : Azure.ResourceManager.Core.ArmContainer
    {
        protected EHNamespaceContainer() { }
        protected override Azure.ResourceManager.ResourceType ValidResourceType { get { throw null; } }
        public virtual Azure.Response<bool> CheckIfExists(string namespaceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> CheckIfExistsAsync(string namespaceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.EventHubs.Models.NamespaceCreateOrUpdateOperation CreateOrUpdate(string namespaceName, Azure.ResourceManager.EventHubs.EHNamespaceData parameters, bool waitForCompletion = true, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.EventHubs.Models.NamespaceCreateOrUpdateOperation> CreateOrUpdateAsync(string namespaceName, Azure.ResourceManager.EventHubs.EHNamespaceData parameters, bool waitForCompletion = true, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.EHNamespace> Get(string namespaceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.EventHubs.EHNamespace> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.Resources.GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.Resources.GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.EventHubs.EHNamespace> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.EHNamespace>> GetAsync(string namespaceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.EHNamespace> GetIfExists(string namespaceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.EHNamespace>> GetIfExistsAsync(string namespaceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class EHNamespaceData : Azure.ResourceManager.Models.TrackedResource
    {
        public EHNamespaceData(Azure.ResourceManager.Resources.Models.Location location) : base (default(Azure.ResourceManager.Resources.Models.Location)) { }
        public string ClusterArmId { get { throw null; } set { } }
        public System.DateTimeOffset? CreatedAt { get { throw null; } }
        public Azure.ResourceManager.EventHubs.Models.Encryption Encryption { get { throw null; } set { } }
        public Azure.ResourceManager.EventHubs.Models.Identity Identity { get { throw null; } set { } }
        public bool? IsAutoInflateEnabled { get { throw null; } set { } }
        public bool? KafkaEnabled { get { throw null; } set { } }
        public int? MaximumThroughputUnits { get { throw null; } set { } }
        public string MetricId { get { throw null; } }
        public string ProvisioningState { get { throw null; } }
        public string ServiceBusEndpoint { get { throw null; } }
        public Azure.ResourceManager.EventHubs.Models.Sku Sku { get { throw null; } set { } }
        public string Status { get { throw null; } }
        public System.DateTimeOffset? UpdatedAt { get { throw null; } }
        public bool? ZoneRedundant { get { throw null; } set { } }
    }
    public partial class Eventhub : Azure.ResourceManager.Core.ArmResource
    {
        public static readonly Azure.ResourceManager.ResourceType ResourceType;
        protected Eventhub() { }
        public virtual Azure.ResourceManager.EventHubs.EventhubData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        protected override Azure.ResourceManager.ResourceType ValidResourceType { get { throw null; } }
        public virtual Azure.ResourceManager.EventHubs.Models.EventHubDeleteOperation Delete(bool waitForCompletion = true, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.EventHubs.Models.EventHubDeleteOperation> DeleteAsync(bool waitForCompletion = true, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.Eventhub> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.Eventhub>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public Azure.ResourceManager.EventHubs.AuthorizationRuleEventHubContainer GetAuthorizationRuleEventHubs() { throw null; }
        public virtual System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.Models.Location> GetAvailableLocations(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.Models.Location>> GetAvailableLocationsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public Azure.ResourceManager.EventHubs.ConsumerGroupContainer GetConsumerGroups() { throw null; }
    }
    public partial class EventhubContainer : Azure.ResourceManager.Core.ArmContainer
    {
        protected EventhubContainer() { }
        protected override Azure.ResourceManager.ResourceType ValidResourceType { get { throw null; } }
        public virtual Azure.Response<bool> CheckIfExists(string eventHubName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> CheckIfExistsAsync(string eventHubName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.EventHubs.Models.EventHubCreateOrUpdateOperation CreateOrUpdate(string eventHubName, Azure.ResourceManager.EventHubs.EventhubData parameters, bool waitForCompletion = true, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.EventHubs.Models.EventHubCreateOrUpdateOperation> CreateOrUpdateAsync(string eventHubName, Azure.ResourceManager.EventHubs.EventhubData parameters, bool waitForCompletion = true, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.Eventhub> Get(string eventHubName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.EventHubs.Eventhub> GetAll(int? skip = default(int?), int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.EventHubs.Eventhub> GetAllAsync(int? skip = default(int?), int? top = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.Eventhub>> GetAsync(string eventHubName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.Eventhub> GetIfExists(string eventHubName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.Eventhub>> GetIfExistsAsync(string eventHubName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class EventhubData : Azure.ResourceManager.Models.Resource
    {
        public EventhubData() { }
        public Azure.ResourceManager.EventHubs.Models.CaptureDescription CaptureDescription { get { throw null; } set { } }
        public System.DateTimeOffset? CreatedAt { get { throw null; } }
        public long? MessageRetentionInDays { get { throw null; } set { } }
        public long? PartitionCount { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyList<string> PartitionIds { get { throw null; } }
        public Azure.ResourceManager.EventHubs.Models.EntityStatus? Status { get { throw null; } set { } }
        public System.DateTimeOffset? UpdatedAt { get { throw null; } }
    }
    public partial class IpFilterRule : Azure.ResourceManager.Core.ArmResource
    {
        public static readonly Azure.ResourceManager.ResourceType ResourceType;
        protected IpFilterRule() { }
        public virtual Azure.ResourceManager.EventHubs.IpFilterRuleData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        protected override Azure.ResourceManager.ResourceType ValidResourceType { get { throw null; } }
        public virtual Azure.ResourceManager.EventHubs.Models.IPFilterRuleDeleteOperation Delete(bool waitForCompletion = true, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.EventHubs.Models.IPFilterRuleDeleteOperation> DeleteAsync(bool waitForCompletion = true, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.IpFilterRule> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.IpFilterRule>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.Models.Location> GetAvailableLocations(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.Models.Location>> GetAvailableLocationsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class IpFilterRuleContainer : Azure.ResourceManager.Core.ArmContainer
    {
        protected IpFilterRuleContainer() { }
        protected override Azure.ResourceManager.ResourceType ValidResourceType { get { throw null; } }
        public virtual Azure.Response<bool> CheckIfExists(string ipFilterRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> CheckIfExistsAsync(string ipFilterRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.EventHubs.Models.IPFilterRuleCreateOrUpdateOperation CreateOrUpdate(string ipFilterRuleName, Azure.ResourceManager.EventHubs.IpFilterRuleData parameters, bool waitForCompletion = true, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.EventHubs.Models.IPFilterRuleCreateOrUpdateOperation> CreateOrUpdateAsync(string ipFilterRuleName, Azure.ResourceManager.EventHubs.IpFilterRuleData parameters, bool waitForCompletion = true, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.IpFilterRule> Get(string ipFilterRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.EventHubs.IpFilterRule> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.EventHubs.IpFilterRule> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.IpFilterRule>> GetAsync(string ipFilterRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.IpFilterRule> GetIfExists(string ipFilterRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.IpFilterRule>> GetIfExistsAsync(string ipFilterRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class IpFilterRuleData : Azure.ResourceManager.Models.Resource
    {
        public IpFilterRuleData() { }
        public Azure.ResourceManager.EventHubs.Models.IPAction? Action { get { throw null; } set { } }
        public string FilterName { get { throw null; } set { } }
        public string IpMask { get { throw null; } set { } }
    }
    public partial class PrivateEndpointConnection : Azure.ResourceManager.Core.ArmResource
    {
        public static readonly Azure.ResourceManager.ResourceType ResourceType;
        protected PrivateEndpointConnection() { }
        public virtual Azure.ResourceManager.EventHubs.PrivateEndpointConnectionData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        protected override Azure.ResourceManager.ResourceType ValidResourceType { get { throw null; } }
        public virtual Azure.ResourceManager.EventHubs.Models.PrivateEndpointConnectionDeleteOperation Delete(bool waitForCompletion = true, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.EventHubs.Models.PrivateEndpointConnectionDeleteOperation> DeleteAsync(bool waitForCompletion = true, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.PrivateEndpointConnection> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.PrivateEndpointConnection>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.Models.Location> GetAvailableLocations(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<Azure.ResourceManager.Resources.Models.Location>> GetAvailableLocationsAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class PrivateEndpointConnectionContainer : Azure.ResourceManager.Core.ArmContainer
    {
        protected PrivateEndpointConnectionContainer() { }
        protected override Azure.ResourceManager.ResourceType ValidResourceType { get { throw null; } }
        public virtual Azure.Response<bool> CheckIfExists(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> CheckIfExistsAsync(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.EventHubs.Models.PrivateEndpointConnectionCreateOrUpdateOperation CreateOrUpdate(string privateEndpointConnectionName, Azure.ResourceManager.EventHubs.PrivateEndpointConnectionData parameters, bool waitForCompletion = true, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.EventHubs.Models.PrivateEndpointConnectionCreateOrUpdateOperation> CreateOrUpdateAsync(string privateEndpointConnectionName, Azure.ResourceManager.EventHubs.PrivateEndpointConnectionData parameters, bool waitForCompletion = true, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.PrivateEndpointConnection> Get(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.EventHubs.PrivateEndpointConnection> GetAll(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.EventHubs.PrivateEndpointConnection> GetAllAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.PrivateEndpointConnection>> GetAsync(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.EventHubs.PrivateEndpointConnection> GetIfExists(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.PrivateEndpointConnection>> GetIfExistsAsync(string privateEndpointConnectionName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class PrivateEndpointConnectionData : Azure.ResourceManager.Models.Resource
    {
        public PrivateEndpointConnectionData() { }
        public Azure.ResourceManager.Resources.Models.WritableSubResource PrivateEndpoint { get { throw null; } set { } }
        public Azure.ResourceManager.EventHubs.Models.ConnectionState PrivateLinkServiceConnectionState { get { throw null; } set { } }
        public Azure.ResourceManager.EventHubs.Models.EndPointProvisioningState? ProvisioningState { get { throw null; } set { } }
    }
    public static partial class ResourceGroupExtensions
    {
        public static Azure.ResourceManager.EventHubs.ClusterContainer GetClusters(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup) { throw null; }
        public static Azure.ResourceManager.EventHubs.EHNamespaceContainer GetEHNamespaces(this Azure.ResourceManager.Resources.ResourceGroup resourceGroup) { throw null; }
    }
    public static partial class SubscriptionExtensions
    {
        public static Azure.Response<Azure.ResourceManager.EventHubs.Models.CheckNameAvailabilityResult> CheckNamespaceNameAvailability(this Azure.ResourceManager.Resources.Subscription subscription, Azure.ResourceManager.EventHubs.Models.CheckNameAvailabilityParameter parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.EventHubs.Models.CheckNameAvailabilityResult>> CheckNamespaceNameAvailabilityAsync(this Azure.ResourceManager.Resources.Subscription subscription, Azure.ResourceManager.EventHubs.Models.CheckNameAvailabilityParameter parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.EventHubs.Models.AvailableCluster>> GetAvailableClusterRegion(this Azure.ResourceManager.Resources.Subscription subscription, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.EventHubs.Models.AvailableCluster>>> GetAvailableClusterRegionAsync(this Azure.ResourceManager.Resources.Subscription subscription, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.Resources.GenericResource> GetEHNamespaceByName(this Azure.ResourceManager.Resources.Subscription subscription, string filter, string expand, int? top, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.Resources.GenericResource> GetEHNamespaceByNameAsync(this Azure.ResourceManager.Resources.Subscription subscription, string filter, string expand, int? top, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.EventHubs.EHNamespace> GetEHNamespaces(this Azure.ResourceManager.Resources.Subscription subscription, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.EventHubs.EHNamespace> GetEHNamespacesAsync(this Azure.ResourceManager.Resources.Subscription subscription, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Pageable<Azure.ResourceManager.EventHubs.Models.MessagingRegions> GetRegionsBySku(this Azure.ResourceManager.Resources.Subscription subscription, string sku, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.AsyncPageable<Azure.ResourceManager.EventHubs.Models.MessagingRegions> GetRegionsBySkuAsync(this Azure.ResourceManager.Resources.Subscription subscription, string sku, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace Azure.ResourceManager.EventHubs.Models
{
    public partial class AccessKeys
    {
        internal AccessKeys() { }
        public string AliasPrimaryConnectionString { get { throw null; } }
        public string AliasSecondaryConnectionString { get { throw null; } }
        public string KeyName { get { throw null; } }
        public string PrimaryConnectionString { get { throw null; } }
        public string PrimaryKey { get { throw null; } }
        public string SecondaryConnectionString { get { throw null; } }
        public string SecondaryKey { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct AccessRights : System.IEquatable<Azure.ResourceManager.EventHubs.Models.AccessRights>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public AccessRights(string value) { throw null; }
        public static Azure.ResourceManager.EventHubs.Models.AccessRights Listen { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.AccessRights Manage { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.AccessRights Send { get { throw null; } }
        public bool Equals(Azure.ResourceManager.EventHubs.Models.AccessRights other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.EventHubs.Models.AccessRights left, Azure.ResourceManager.EventHubs.Models.AccessRights right) { throw null; }
        public static implicit operator Azure.ResourceManager.EventHubs.Models.AccessRights (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.EventHubs.Models.AccessRights left, Azure.ResourceManager.EventHubs.Models.AccessRights right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class AvailableCluster
    {
        internal AvailableCluster() { }
        public string Location { get { throw null; } }
    }
    public partial class AvailableClustersList
    {
        internal AvailableClustersList() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.EventHubs.Models.AvailableCluster> Value { get { throw null; } }
    }
    public partial class CaptureDescription
    {
        public CaptureDescription() { }
        public Azure.ResourceManager.EventHubs.Models.Destination Destination { get { throw null; } set { } }
        public bool? Enabled { get { throw null; } set { } }
        public Azure.ResourceManager.EventHubs.Models.EncodingCaptureDescription? Encoding { get { throw null; } set { } }
        public int? IntervalInSeconds { get { throw null; } set { } }
        public int? SizeLimitInBytes { get { throw null; } set { } }
        public bool? SkipEmptyArchives { get { throw null; } set { } }
    }
    public partial class CheckNameAvailabilityParameter
    {
        public CheckNameAvailabilityParameter(string name) { }
        public string Name { get { throw null; } }
    }
    public partial class CheckNameAvailabilityResult
    {
        internal CheckNameAvailabilityResult() { }
        public string Message { get { throw null; } }
        public bool? NameAvailable { get { throw null; } }
        public Azure.ResourceManager.EventHubs.Models.UnavailableReason? Reason { get { throw null; } }
    }
    public partial class ClusterCreateOrUpdateOperation : Azure.Operation<Azure.ResourceManager.EventHubs.Cluster>
    {
        protected ClusterCreateOrUpdateOperation() { }
        public override bool HasCompleted { get { throw null; } }
        public override bool HasValue { get { throw null; } }
        public override string Id { get { throw null; } }
        public override Azure.ResourceManager.EventHubs.Cluster Value { get { throw null; } }
        public override Azure.Response GetRawResponse() { throw null; }
        public override Azure.Response UpdateStatus(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response> UpdateStatusAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response<Azure.ResourceManager.EventHubs.Cluster>> WaitForCompletionAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response<Azure.ResourceManager.EventHubs.Cluster>> WaitForCompletionAsync(System.TimeSpan pollingInterval, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ClusterDeleteOperation : Azure.Operation
    {
        protected ClusterDeleteOperation() { }
        public override bool HasCompleted { get { throw null; } }
        public override string Id { get { throw null; } }
        public override Azure.Response GetRawResponse() { throw null; }
        public override Azure.Response UpdateStatus(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response> UpdateStatusAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response> WaitForCompletionResponseAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response> WaitForCompletionResponseAsync(System.TimeSpan pollingInterval, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ClusterSku
    {
        public ClusterSku(Azure.ResourceManager.EventHubs.Models.ClusterSkuName name) { }
        public int? Capacity { get { throw null; } set { } }
        public Azure.ResourceManager.EventHubs.Models.ClusterSkuName Name { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ClusterSkuName : System.IEquatable<Azure.ResourceManager.EventHubs.Models.ClusterSkuName>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ClusterSkuName(string value) { throw null; }
        public static Azure.ResourceManager.EventHubs.Models.ClusterSkuName Dedicated { get { throw null; } }
        public bool Equals(Azure.ResourceManager.EventHubs.Models.ClusterSkuName other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.EventHubs.Models.ClusterSkuName left, Azure.ResourceManager.EventHubs.Models.ClusterSkuName right) { throw null; }
        public static implicit operator Azure.ResourceManager.EventHubs.Models.ClusterSkuName (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.EventHubs.Models.ClusterSkuName left, Azure.ResourceManager.EventHubs.Models.ClusterSkuName right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ClusterUpdateOperation : Azure.Operation<Azure.ResourceManager.EventHubs.Cluster>
    {
        protected ClusterUpdateOperation() { }
        public override bool HasCompleted { get { throw null; } }
        public override bool HasValue { get { throw null; } }
        public override string Id { get { throw null; } }
        public override Azure.ResourceManager.EventHubs.Cluster Value { get { throw null; } }
        public override Azure.Response GetRawResponse() { throw null; }
        public override Azure.Response UpdateStatus(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response> UpdateStatusAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response<Azure.ResourceManager.EventHubs.Cluster>> WaitForCompletionAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response<Azure.ResourceManager.EventHubs.Cluster>> WaitForCompletionAsync(System.TimeSpan pollingInterval, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ConfigurationPatchOperation : Azure.Operation<Azure.ResourceManager.EventHubs.ClusterQuotaConfigurationProperties>
    {
        protected ConfigurationPatchOperation() { }
        public override bool HasCompleted { get { throw null; } }
        public override bool HasValue { get { throw null; } }
        public override string Id { get { throw null; } }
        public override Azure.ResourceManager.EventHubs.ClusterQuotaConfigurationProperties Value { get { throw null; } }
        public override Azure.Response GetRawResponse() { throw null; }
        public override Azure.Response UpdateStatus(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response> UpdateStatusAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response<Azure.ResourceManager.EventHubs.ClusterQuotaConfigurationProperties>> WaitForCompletionAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response<Azure.ResourceManager.EventHubs.ClusterQuotaConfigurationProperties>> WaitForCompletionAsync(System.TimeSpan pollingInterval, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ConnectionState
    {
        public ConnectionState() { }
        public string Description { get { throw null; } set { } }
        public Azure.ResourceManager.EventHubs.Models.PrivateLinkConnectionStatus? Status { get { throw null; } set { } }
    }
    public partial class ConsumerGroupCreateOrUpdateOperation : Azure.Operation<Azure.ResourceManager.EventHubs.ConsumerGroup>
    {
        protected ConsumerGroupCreateOrUpdateOperation() { }
        public override bool HasCompleted { get { throw null; } }
        public override bool HasValue { get { throw null; } }
        public override string Id { get { throw null; } }
        public override Azure.ResourceManager.EventHubs.ConsumerGroup Value { get { throw null; } }
        public override Azure.Response GetRawResponse() { throw null; }
        public override Azure.Response UpdateStatus(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response> UpdateStatusAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response<Azure.ResourceManager.EventHubs.ConsumerGroup>> WaitForCompletionAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response<Azure.ResourceManager.EventHubs.ConsumerGroup>> WaitForCompletionAsync(System.TimeSpan pollingInterval, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ConsumerGroupDeleteOperation : Azure.Operation
    {
        protected ConsumerGroupDeleteOperation() { }
        public override bool HasCompleted { get { throw null; } }
        public override string Id { get { throw null; } }
        public override Azure.Response GetRawResponse() { throw null; }
        public override Azure.Response UpdateStatus(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response> UpdateStatusAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response> WaitForCompletionResponseAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response> WaitForCompletionResponseAsync(System.TimeSpan pollingInterval, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DefaultAction : System.IEquatable<Azure.ResourceManager.EventHubs.Models.DefaultAction>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DefaultAction(string value) { throw null; }
        public static Azure.ResourceManager.EventHubs.Models.DefaultAction Allow { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.DefaultAction Deny { get { throw null; } }
        public bool Equals(Azure.ResourceManager.EventHubs.Models.DefaultAction other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.EventHubs.Models.DefaultAction left, Azure.ResourceManager.EventHubs.Models.DefaultAction right) { throw null; }
        public static implicit operator Azure.ResourceManager.EventHubs.Models.DefaultAction (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.EventHubs.Models.DefaultAction left, Azure.ResourceManager.EventHubs.Models.DefaultAction right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class Destination
    {
        public Destination() { }
        public string ArchiveNameFormat { get { throw null; } set { } }
        public string BlobContainer { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public string StorageAccountResourceId { get { throw null; } set { } }
    }
    public partial class DisasterRecoveryConfigCreateOrUpdateOperation : Azure.Operation<Azure.ResourceManager.EventHubs.ArmDisasterRecovery>
    {
        protected DisasterRecoveryConfigCreateOrUpdateOperation() { }
        public override bool HasCompleted { get { throw null; } }
        public override bool HasValue { get { throw null; } }
        public override string Id { get { throw null; } }
        public override Azure.ResourceManager.EventHubs.ArmDisasterRecovery Value { get { throw null; } }
        public override Azure.Response GetRawResponse() { throw null; }
        public override Azure.Response UpdateStatus(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response> UpdateStatusAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response<Azure.ResourceManager.EventHubs.ArmDisasterRecovery>> WaitForCompletionAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response<Azure.ResourceManager.EventHubs.ArmDisasterRecovery>> WaitForCompletionAsync(System.TimeSpan pollingInterval, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class DisasterRecoveryConfigDeleteOperation : Azure.Operation
    {
        protected DisasterRecoveryConfigDeleteOperation() { }
        public override bool HasCompleted { get { throw null; } }
        public override string Id { get { throw null; } }
        public override Azure.Response GetRawResponse() { throw null; }
        public override Azure.Response UpdateStatus(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response> UpdateStatusAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response> WaitForCompletionResponseAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response> WaitForCompletionResponseAsync(System.TimeSpan pollingInterval, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class EHNamespaceIdListResult
    {
        internal EHNamespaceIdListResult() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.Resources.Models.SubResource> Value { get { throw null; } }
    }
    public enum EncodingCaptureDescription
    {
        Avro = 0,
        AvroDeflate = 1,
    }
    public partial class Encryption
    {
        public Encryption() { }
        public string KeySource { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.EventHubs.Models.KeyVaultProperties> KeyVaultProperties { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct EndPointProvisioningState : System.IEquatable<Azure.ResourceManager.EventHubs.Models.EndPointProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public EndPointProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.EventHubs.Models.EndPointProvisioningState Canceled { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.EndPointProvisioningState Creating { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.EndPointProvisioningState Deleting { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.EndPointProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.EndPointProvisioningState Succeeded { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.EndPointProvisioningState Updating { get { throw null; } }
        public bool Equals(Azure.ResourceManager.EventHubs.Models.EndPointProvisioningState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.EventHubs.Models.EndPointProvisioningState left, Azure.ResourceManager.EventHubs.Models.EndPointProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.EventHubs.Models.EndPointProvisioningState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.EventHubs.Models.EndPointProvisioningState left, Azure.ResourceManager.EventHubs.Models.EndPointProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public enum EntityStatus
    {
        Active = 0,
        Disabled = 1,
        Restoring = 2,
        SendDisabled = 3,
        ReceiveDisabled = 4,
        Creating = 5,
        Deleting = 6,
        Renaming = 7,
        Unknown = 8,
    }
    public partial class EventHubAuthorizationRuleCreateOrUpdateOperation : Azure.Operation<Azure.ResourceManager.EventHubs.AuthorizationRuleEventHub>
    {
        protected EventHubAuthorizationRuleCreateOrUpdateOperation() { }
        public override bool HasCompleted { get { throw null; } }
        public override bool HasValue { get { throw null; } }
        public override string Id { get { throw null; } }
        public override Azure.ResourceManager.EventHubs.AuthorizationRuleEventHub Value { get { throw null; } }
        public override Azure.Response GetRawResponse() { throw null; }
        public override Azure.Response UpdateStatus(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response> UpdateStatusAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response<Azure.ResourceManager.EventHubs.AuthorizationRuleEventHub>> WaitForCompletionAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response<Azure.ResourceManager.EventHubs.AuthorizationRuleEventHub>> WaitForCompletionAsync(System.TimeSpan pollingInterval, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class EventHubAuthorizationRuleDeleteOperation : Azure.Operation
    {
        protected EventHubAuthorizationRuleDeleteOperation() { }
        public override bool HasCompleted { get { throw null; } }
        public override string Id { get { throw null; } }
        public override Azure.Response GetRawResponse() { throw null; }
        public override Azure.Response UpdateStatus(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response> UpdateStatusAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response> WaitForCompletionResponseAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response> WaitForCompletionResponseAsync(System.TimeSpan pollingInterval, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class EventHubCreateOrUpdateOperation : Azure.Operation<Azure.ResourceManager.EventHubs.Eventhub>
    {
        protected EventHubCreateOrUpdateOperation() { }
        public override bool HasCompleted { get { throw null; } }
        public override bool HasValue { get { throw null; } }
        public override string Id { get { throw null; } }
        public override Azure.ResourceManager.EventHubs.Eventhub Value { get { throw null; } }
        public override Azure.Response GetRawResponse() { throw null; }
        public override Azure.Response UpdateStatus(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response> UpdateStatusAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response<Azure.ResourceManager.EventHubs.Eventhub>> WaitForCompletionAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response<Azure.ResourceManager.EventHubs.Eventhub>> WaitForCompletionAsync(System.TimeSpan pollingInterval, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class EventHubDeleteOperation : Azure.Operation
    {
        protected EventHubDeleteOperation() { }
        public override bool HasCompleted { get { throw null; } }
        public override string Id { get { throw null; } }
        public override Azure.Response GetRawResponse() { throw null; }
        public override Azure.Response UpdateStatus(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response> UpdateStatusAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response> WaitForCompletionResponseAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response> WaitForCompletionResponseAsync(System.TimeSpan pollingInterval, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class Identity
    {
        public Identity() { }
        public string PrincipalId { get { throw null; } set { } }
        public string TenantId { get { throw null; } set { } }
        public string Type { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct IPAction : System.IEquatable<Azure.ResourceManager.EventHubs.Models.IPAction>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public IPAction(string value) { throw null; }
        public static Azure.ResourceManager.EventHubs.Models.IPAction Accept { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.IPAction Reject { get { throw null; } }
        public bool Equals(Azure.ResourceManager.EventHubs.Models.IPAction other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.EventHubs.Models.IPAction left, Azure.ResourceManager.EventHubs.Models.IPAction right) { throw null; }
        public static implicit operator Azure.ResourceManager.EventHubs.Models.IPAction (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.EventHubs.Models.IPAction left, Azure.ResourceManager.EventHubs.Models.IPAction right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class IPFilterRuleCreateOrUpdateOperation : Azure.Operation<Azure.ResourceManager.EventHubs.IpFilterRule>
    {
        protected IPFilterRuleCreateOrUpdateOperation() { }
        public override bool HasCompleted { get { throw null; } }
        public override bool HasValue { get { throw null; } }
        public override string Id { get { throw null; } }
        public override Azure.ResourceManager.EventHubs.IpFilterRule Value { get { throw null; } }
        public override Azure.Response GetRawResponse() { throw null; }
        public override Azure.Response UpdateStatus(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response> UpdateStatusAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response<Azure.ResourceManager.EventHubs.IpFilterRule>> WaitForCompletionAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response<Azure.ResourceManager.EventHubs.IpFilterRule>> WaitForCompletionAsync(System.TimeSpan pollingInterval, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class IPFilterRuleDeleteOperation : Azure.Operation
    {
        protected IPFilterRuleDeleteOperation() { }
        public override bool HasCompleted { get { throw null; } }
        public override string Id { get { throw null; } }
        public override Azure.Response GetRawResponse() { throw null; }
        public override Azure.Response UpdateStatus(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response> UpdateStatusAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response> WaitForCompletionResponseAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response> WaitForCompletionResponseAsync(System.TimeSpan pollingInterval, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public enum KeyType
    {
        PrimaryKey = 0,
        SecondaryKey = 1,
    }
    public partial class KeyVaultProperties
    {
        public KeyVaultProperties() { }
        public string KeyName { get { throw null; } set { } }
        public string KeyVaultUri { get { throw null; } set { } }
        public string KeyVersion { get { throw null; } set { } }
    }
    public partial class MessagingRegions : Azure.ResourceManager.Models.TrackedResource
    {
        public MessagingRegions(Azure.ResourceManager.Resources.Models.Location location) : base (default(Azure.ResourceManager.Resources.Models.Location)) { }
        public Azure.ResourceManager.EventHubs.Models.MessagingRegionsProperties Properties { get { throw null; } set { } }
    }
    public partial class MessagingRegionsProperties
    {
        public MessagingRegionsProperties() { }
        public string Code { get { throw null; } }
        public string FullName { get { throw null; } }
    }
    public partial class NamespaceAuthorizationRuleCreateOrUpdateOperation : Azure.Operation<Azure.ResourceManager.EventHubs.AuthorizationRuleNamespace>
    {
        protected NamespaceAuthorizationRuleCreateOrUpdateOperation() { }
        public override bool HasCompleted { get { throw null; } }
        public override bool HasValue { get { throw null; } }
        public override string Id { get { throw null; } }
        public override Azure.ResourceManager.EventHubs.AuthorizationRuleNamespace Value { get { throw null; } }
        public override Azure.Response GetRawResponse() { throw null; }
        public override Azure.Response UpdateStatus(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response> UpdateStatusAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response<Azure.ResourceManager.EventHubs.AuthorizationRuleNamespace>> WaitForCompletionAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response<Azure.ResourceManager.EventHubs.AuthorizationRuleNamespace>> WaitForCompletionAsync(System.TimeSpan pollingInterval, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class NamespaceAuthorizationRuleDeleteOperation : Azure.Operation
    {
        protected NamespaceAuthorizationRuleDeleteOperation() { }
        public override bool HasCompleted { get { throw null; } }
        public override string Id { get { throw null; } }
        public override Azure.Response GetRawResponse() { throw null; }
        public override Azure.Response UpdateStatus(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response> UpdateStatusAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response> WaitForCompletionResponseAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response> WaitForCompletionResponseAsync(System.TimeSpan pollingInterval, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class NamespaceCreateOrUpdateNetworkRuleSetOperation : Azure.Operation<Azure.ResourceManager.EventHubs.Models.NetworkRuleSet>
    {
        protected NamespaceCreateOrUpdateNetworkRuleSetOperation() { }
        public override bool HasCompleted { get { throw null; } }
        public override bool HasValue { get { throw null; } }
        public override string Id { get { throw null; } }
        public override Azure.ResourceManager.EventHubs.Models.NetworkRuleSet Value { get { throw null; } }
        public override Azure.Response GetRawResponse() { throw null; }
        public override Azure.Response UpdateStatus(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response> UpdateStatusAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response<Azure.ResourceManager.EventHubs.Models.NetworkRuleSet>> WaitForCompletionAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response<Azure.ResourceManager.EventHubs.Models.NetworkRuleSet>> WaitForCompletionAsync(System.TimeSpan pollingInterval, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class NamespaceCreateOrUpdateOperation : Azure.Operation<Azure.ResourceManager.EventHubs.EHNamespace>
    {
        protected NamespaceCreateOrUpdateOperation() { }
        public override bool HasCompleted { get { throw null; } }
        public override bool HasValue { get { throw null; } }
        public override string Id { get { throw null; } }
        public override Azure.ResourceManager.EventHubs.EHNamespace Value { get { throw null; } }
        public override Azure.Response GetRawResponse() { throw null; }
        public override Azure.Response UpdateStatus(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response> UpdateStatusAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response<Azure.ResourceManager.EventHubs.EHNamespace>> WaitForCompletionAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response<Azure.ResourceManager.EventHubs.EHNamespace>> WaitForCompletionAsync(System.TimeSpan pollingInterval, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class NamespaceCreateOrUpdateVirtualNetworkRuleOperation : Azure.Operation<Azure.ResourceManager.EventHubs.Models.VirtualNetworkRule>
    {
        protected NamespaceCreateOrUpdateVirtualNetworkRuleOperation() { }
        public override bool HasCompleted { get { throw null; } }
        public override bool HasValue { get { throw null; } }
        public override string Id { get { throw null; } }
        public override Azure.ResourceManager.EventHubs.Models.VirtualNetworkRule Value { get { throw null; } }
        public override Azure.Response GetRawResponse() { throw null; }
        public override Azure.Response UpdateStatus(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response> UpdateStatusAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response<Azure.ResourceManager.EventHubs.Models.VirtualNetworkRule>> WaitForCompletionAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response<Azure.ResourceManager.EventHubs.Models.VirtualNetworkRule>> WaitForCompletionAsync(System.TimeSpan pollingInterval, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class NamespaceDeleteOperation : Azure.Operation
    {
        protected NamespaceDeleteOperation() { }
        public override bool HasCompleted { get { throw null; } }
        public override string Id { get { throw null; } }
        public override Azure.Response GetRawResponse() { throw null; }
        public override Azure.Response UpdateStatus(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response> UpdateStatusAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response> WaitForCompletionResponseAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response> WaitForCompletionResponseAsync(System.TimeSpan pollingInterval, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class NamespaceDeleteVirtualNetworkRuleOperation : Azure.Operation
    {
        protected NamespaceDeleteVirtualNetworkRuleOperation() { }
        public override bool HasCompleted { get { throw null; } }
        public override string Id { get { throw null; } }
        public override Azure.Response GetRawResponse() { throw null; }
        public override Azure.Response UpdateStatus(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response> UpdateStatusAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response> WaitForCompletionResponseAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response> WaitForCompletionResponseAsync(System.TimeSpan pollingInterval, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class NamespaceUpdateOperation : Azure.Operation<Azure.ResourceManager.EventHubs.EHNamespace>
    {
        protected NamespaceUpdateOperation() { }
        public override bool HasCompleted { get { throw null; } }
        public override bool HasValue { get { throw null; } }
        public override string Id { get { throw null; } }
        public override Azure.ResourceManager.EventHubs.EHNamespace Value { get { throw null; } }
        public override Azure.Response GetRawResponse() { throw null; }
        public override Azure.Response UpdateStatus(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response> UpdateStatusAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response<Azure.ResourceManager.EventHubs.EHNamespace>> WaitForCompletionAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response<Azure.ResourceManager.EventHubs.EHNamespace>> WaitForCompletionAsync(System.TimeSpan pollingInterval, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct NetworkRuleIPAction : System.IEquatable<Azure.ResourceManager.EventHubs.Models.NetworkRuleIPAction>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public NetworkRuleIPAction(string value) { throw null; }
        public static Azure.ResourceManager.EventHubs.Models.NetworkRuleIPAction Allow { get { throw null; } }
        public bool Equals(Azure.ResourceManager.EventHubs.Models.NetworkRuleIPAction other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.EventHubs.Models.NetworkRuleIPAction left, Azure.ResourceManager.EventHubs.Models.NetworkRuleIPAction right) { throw null; }
        public static implicit operator Azure.ResourceManager.EventHubs.Models.NetworkRuleIPAction (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.EventHubs.Models.NetworkRuleIPAction left, Azure.ResourceManager.EventHubs.Models.NetworkRuleIPAction right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class NetworkRuleSet : Azure.ResourceManager.Models.Resource
    {
        public NetworkRuleSet() { }
        public Azure.ResourceManager.EventHubs.Models.DefaultAction? DefaultAction { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.EventHubs.Models.NWRuleSetIpRules> IpRules { get { throw null; } }
        public bool? TrustedServiceAccessEnabled { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.EventHubs.Models.NWRuleSetVirtualNetworkRules> VirtualNetworkRules { get { throw null; } }
    }
    public partial class NWRuleSetIpRules
    {
        public NWRuleSetIpRules() { }
        public Azure.ResourceManager.EventHubs.Models.NetworkRuleIPAction? Action { get { throw null; } set { } }
        public string IpMask { get { throw null; } set { } }
    }
    public partial class NWRuleSetVirtualNetworkRules
    {
        public NWRuleSetVirtualNetworkRules() { }
        public bool? IgnoreMissingVnetServiceEndpoint { get { throw null; } set { } }
        public Azure.ResourceManager.Resources.Models.WritableSubResource Subnet { get { throw null; } set { } }
    }
    public partial class PrivateEndpointConnectionCreateOrUpdateOperation : Azure.Operation<Azure.ResourceManager.EventHubs.PrivateEndpointConnection>
    {
        protected PrivateEndpointConnectionCreateOrUpdateOperation() { }
        public override bool HasCompleted { get { throw null; } }
        public override bool HasValue { get { throw null; } }
        public override string Id { get { throw null; } }
        public override Azure.ResourceManager.EventHubs.PrivateEndpointConnection Value { get { throw null; } }
        public override Azure.Response GetRawResponse() { throw null; }
        public override Azure.Response UpdateStatus(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response> UpdateStatusAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response<Azure.ResourceManager.EventHubs.PrivateEndpointConnection>> WaitForCompletionAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response<Azure.ResourceManager.EventHubs.PrivateEndpointConnection>> WaitForCompletionAsync(System.TimeSpan pollingInterval, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class PrivateEndpointConnectionDeleteOperation : Azure.Operation
    {
        protected PrivateEndpointConnectionDeleteOperation() { }
        public override bool HasCompleted { get { throw null; } }
        public override string Id { get { throw null; } }
        public override Azure.Response GetRawResponse() { throw null; }
        public override Azure.Response UpdateStatus(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response> UpdateStatusAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response> WaitForCompletionResponseAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public override System.Threading.Tasks.ValueTask<Azure.Response> WaitForCompletionResponseAsync(System.TimeSpan pollingInterval, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct PrivateLinkConnectionStatus : System.IEquatable<Azure.ResourceManager.EventHubs.Models.PrivateLinkConnectionStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public PrivateLinkConnectionStatus(string value) { throw null; }
        public static Azure.ResourceManager.EventHubs.Models.PrivateLinkConnectionStatus Approved { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.PrivateLinkConnectionStatus Disconnected { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.PrivateLinkConnectionStatus Pending { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.PrivateLinkConnectionStatus Rejected { get { throw null; } }
        public bool Equals(Azure.ResourceManager.EventHubs.Models.PrivateLinkConnectionStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.EventHubs.Models.PrivateLinkConnectionStatus left, Azure.ResourceManager.EventHubs.Models.PrivateLinkConnectionStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.EventHubs.Models.PrivateLinkConnectionStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.EventHubs.Models.PrivateLinkConnectionStatus left, Azure.ResourceManager.EventHubs.Models.PrivateLinkConnectionStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class PrivateLinkResource : Azure.ResourceManager.Models.Resource
    {
        internal PrivateLinkResource() { }
        public string GroupId { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> RequiredMembers { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> RequiredZoneNames { get { throw null; } }
    }
    public partial class PrivateLinkResourcesListResult
    {
        internal PrivateLinkResourcesListResult() { }
        public string NextLink { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.EventHubs.Models.PrivateLinkResource> Value { get { throw null; } }
    }
    public enum ProvisioningStateDR
    {
        Accepted = 0,
        Succeeded = 1,
        Failed = 2,
    }
    public partial class RegenerateAccessKeyParameters
    {
        public RegenerateAccessKeyParameters(Azure.ResourceManager.EventHubs.Models.KeyType keyType) { }
        public string Key { get { throw null; } set { } }
        public Azure.ResourceManager.EventHubs.Models.KeyType KeyType { get { throw null; } }
    }
    public enum RoleDisasterRecovery
    {
        Primary = 0,
        PrimaryNotReplicating = 1,
        Secondary = 2,
    }
    public partial class Sku
    {
        public Sku(Azure.ResourceManager.EventHubs.Models.SkuName name) { }
        public int? Capacity { get { throw null; } set { } }
        public Azure.ResourceManager.EventHubs.Models.SkuName Name { get { throw null; } set { } }
        public Azure.ResourceManager.EventHubs.Models.SkuTier? Tier { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct SkuName : System.IEquatable<Azure.ResourceManager.EventHubs.Models.SkuName>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public SkuName(string value) { throw null; }
        public static Azure.ResourceManager.EventHubs.Models.SkuName Basic { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.SkuName Standard { get { throw null; } }
        public bool Equals(Azure.ResourceManager.EventHubs.Models.SkuName other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.EventHubs.Models.SkuName left, Azure.ResourceManager.EventHubs.Models.SkuName right) { throw null; }
        public static implicit operator Azure.ResourceManager.EventHubs.Models.SkuName (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.EventHubs.Models.SkuName left, Azure.ResourceManager.EventHubs.Models.SkuName right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct SkuTier : System.IEquatable<Azure.ResourceManager.EventHubs.Models.SkuTier>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public SkuTier(string value) { throw null; }
        public static Azure.ResourceManager.EventHubs.Models.SkuTier Basic { get { throw null; } }
        public static Azure.ResourceManager.EventHubs.Models.SkuTier Standard { get { throw null; } }
        public bool Equals(Azure.ResourceManager.EventHubs.Models.SkuTier other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.EventHubs.Models.SkuTier left, Azure.ResourceManager.EventHubs.Models.SkuTier right) { throw null; }
        public static implicit operator Azure.ResourceManager.EventHubs.Models.SkuTier (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.EventHubs.Models.SkuTier left, Azure.ResourceManager.EventHubs.Models.SkuTier right) { throw null; }
        public override string ToString() { throw null; }
    }
    public enum UnavailableReason
    {
        None = 0,
        InvalidName = 1,
        SubscriptionIsDisabled = 2,
        NameInUse = 3,
        NameInLockdown = 4,
        TooManyNamespaceInCurrentSubscription = 5,
    }
    public partial class VirtualNetworkRule : Azure.ResourceManager.Models.Resource
    {
        public VirtualNetworkRule() { }
        public string VirtualNetworkSubnetId { get { throw null; } set { } }
    }
}
