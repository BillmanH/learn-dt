# Learning to build Azure Digital Twins. 

Most of the docs around ADT focus on building applications, which makes sense. As a data analyst, I think more about using ADT for modeling. For that reason, my approach to using the API is very different. 

This repo will, in addition to giving you an updated understanding of Azure Digital Twin's API, give you templates that you can use to build your own digital twin models. 
* While 

# Getting started
_from the project root directory_

## Building the azure resources
`docs` will have all of the instructuions to build the Azure resources.  


## Building the local environment
Assuming you already have Anaconda installed and activated, build the environment:
```
conda env create -f env.yml
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



