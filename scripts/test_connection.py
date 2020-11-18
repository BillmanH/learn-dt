# %%
from azure.identity import DefaultAzureCredential
from azure.identity import AzureCliCredential
from azure.digitaltwins.core import DigitalTwinsClient

from azure.identity import AzureCliCredential
azure_cli = AzureCliCredential()

serviceClient = DigitalTwinsClient(
    "home-test-twin.api.wcus.digitaltwins.azure.net", azure_cli)

print([i for i in serviceClient.list_models()])
# %%
