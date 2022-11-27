# Making sense of Azure Digital Twins. 

Most of the docs around ADT focus on building applications, which makes sense. As a data analyst, I think more about using ADT for modeling. For that reason, my approach to using the API is very different. 

## Getting started
_from the project root directory_

This document assumes that you have an Azure account, Digital Twin Resource and necessary active directory login information. 
Assuming you already have Anaconda installed and activated, build the environment:
```
conda env create -f env.yaml
```
Then you need to test your connection to digital twin:
```
python scripts/test_connection.py
```
If it returns anything similar to `[<azure.digitaltwins.core._generated.models._models_py3.DigitalTwinsModelData object at 0x00000251B4FB3400>, <azure.digitaltwins.core._generated.models._models_py3.DigitalTwinsModelData object at 0x00000251B4FB3730>]` You are connected and ready to begin. 

# Case Studies
Examples of using a digital twin for various purposes. Each one has its own readme and models. 

| name      | description |
| ----------- | ----------- |
| Basic Tickets and Lines   | Basic walkthrough of creating model objects, twins and queries. |
| Pipes and Tanks   | Tank and pipes diagram for simulaiton and monitoring.  |

## Scripts
| name      | description |
| ----------- | ----------- |
| test connection      | confirms that you can connect to the ADT API.      |


Here are the docs (the good ones):
* [this is the python repo](https://github.com/Azure/azure-sdk-for-python/tree/4559e19e2f3146a49f1eba1706bb798071f4a1f5/sdk/digitaltwins/azure-digitaltwins-core). That's what I'm going through here (usually the `main`) branch.

### Models
* [Digital Twins Definition Language](https://github.com/Azure/opendigitaltwins-dtdl/blob/master/DTDL/v2/dtdlv2.md)

### Querying:
* [A good overview of the syntax](https://docs.microsoft.com/en-us/azure/digital-twins/concepts-query-language) 
* [Some great examples](https://docs.microsoft.com/en-us/azure/digital-twins/how-to-query-graph)

### Hardware:
* [Device catalogue](https://devicecatalog.azure.com/). This is useful because it is a list of devices that are already vetted to work well with ADT, **and** come included with a json model snippet that you can use for that application. Less discovery work for your team. 



## Building the Azure Resources:

In the `infra` folder you will find `build_az.ps1`. I generally copy and paste it line by line into the terminal to make sure I'm configured correctly. Normally this part would be part of a build pipeline in ADO but I built this to run on my local machine out of simplicity. It should include the blob storage and CORs that you will need to use the 3dScenes.
* You'll need to add yourself (and anyone else) data owner IAM roles to all of the resources. 

[Setting up the 3d Scenes](https://learn.microsoft.com/en-us/azure/digital-twins/quickstart-3d-scenes-studio). This should be automated, but the automation always seems to break for one reason or another. Eventually I end up running through the startup scripts here. 

**NOTE** You still need to add permissions to all of the things..
I would recommend adding them at the resource group level, that way you can do them all at once. However, you may not want to do that in your production environment. 

Add these to yourself in the portal:
* `Azure Digital Twins Data Owner` <- so that you can query and edit the digital twin
* `Storage Blob Data Owner` <- So that you can edit and access the blob storage.

Credit:
* [Steve Snow](https://www.thingiverse.com/snowman77/designs) for the pipe and tank objects on thingaverse. 
