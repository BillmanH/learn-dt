# %%

from azure.identity import AzureCliCredential
from azure.digitaltwins.core import DigitalTwinsClient

import os, yaml

# %%
your_digital_twin_url = os.getenv("AZURE_DIGITAL_TWIN_NAME")

azure_cli = AzureCliCredential()
service_client = DigitalTwinsClient(your_digital_twin_url, azure_cli)
service_client


# %%

modelspath = "../models/commandcenter"
service_client.create_models(
    [
        yaml.safe_load(open(f"{modelspath}/{f}"))
        for f in os.listdir(modelspath)
    ]
)


# %%
