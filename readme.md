# Making sense of Azure Digital Twins. 

Most of the docs around ADT focus on building applications, which makes sense. As a data analyst, I think more about using ADT for modeling. For that reason, my approach to using the API is very different. 

Here are the docs:
* [this is the python repo](https://github.com/Azure/azure-sdk-for-python/tree/4559e19e2f3146a49f1eba1706bb798071f4a1f5/sdk/digitaltwins/azure-digitaltwins-core)

# Going through the [MSFT documentation on the Python Library for Digital Twin](https://docs.microsoft.com/en-us/python/api/overview/azure/digitaltwins-core-readme-pre?view=azure-python&source=docs)

Here are the things I have noticed so far:
* MSFT is [aware of a typo in the code](https://github.com/Azure/azure-sdk-for-python/issues/14918) and is apparently considering potential fixes. 
* You do not have to load the client secret into your environment variables. Skip all that and use the `AzureCliCredential`. 
* There are no `import` statements in the code examples. You will have to figure out where those methods are on your own. 
* `serviceClient` and `service_client` are used interchangably as well as some other naming issues. 

There are open issues for all these issues, I am sure that MSFT will fix them in a future release. 


