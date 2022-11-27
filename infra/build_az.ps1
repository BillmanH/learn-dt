# I generally run this one section at a time, not all at once. 

# Script variables:
$resourceGroupName = "personalstack"
$location = "West US 2"
# swithc to the env that has the local variables
conda activate personalstack

# start the interactive login
az login
az account set --subscription $Env:subscription
cd $Env:abspath

# # Only need to do this when creating the new resource group:
# az group create -l $location -n $resourceGroupName
# az group delete --name $resourceGroupName

# *_parameters are in the .gitignore 
# Single turnkey resources from template. 
az deployment group create --resource-group $resourceGroupName --template-file "infra/ARM/template.json" --parameters "infra/ARM/parameters.json"


# Create a CORS 
# This should be in the ARM Template.
# az storage cors add --services b --methods GET OPTIONS POST PUT --origins https://explorer.digitaltwins.azure.net --allowed-headers Authorization x-ms-version x-ms-blob-type --account-name atdstoragebillmanh

