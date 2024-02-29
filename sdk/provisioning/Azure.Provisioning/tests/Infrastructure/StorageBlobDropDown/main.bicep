targetScope = 'subscription'


resource resourceGroup_HhtrsKYM5 'Microsoft.Resources/resourceGroups@2023-07-01' = {
  name: 'rg-TEST'
  location: 'westus'
  tags: {
    'azd-env-name': 'TEST'
  }
}

module rg_TEST_module './resources/rg_TEST_module/rg_TEST_module.bicep' = {
  name: 'rg_TEST_module'
  scope: resourceGroup_HhtrsKYM5
}
