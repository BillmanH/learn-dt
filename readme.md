# Making sense of Azure Digital Twins. 

Most of the docs around ADT focus on building applications, which makes sense. As a data analyst, I think more about using ADT for modeling. For that reason, my approach to using the API is very different. 

## Case Studies
Examples of using a digital twin for various purposes. Each one has its own readme and models. 

| name      | description |
| ----------- | ----------- |
| Basic Tickets and Lines   | Basic walkthrough of creating model objects, twins and queries. Start here. |

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




