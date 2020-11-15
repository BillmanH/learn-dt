# Making sense of Azure Digital Twins. 


Here are the docs:
* [this is the python repo](https://github.com/Azure/azure-sdk-for-python/tree/4559e19e2f3146a49f1eba1706bb798071f4a1f5/sdk/digitaltwins/azure-digitaltwins-core)


# Going through the [MSFT documentation on the Python Library for Digital Twin](https://docs.microsoft.com/en-us/python/api/overview/azure/digitaltwins-core-readme-pre?view=azure-python&source=docs)

Here are the things I've noticed so far:
* MSFT is [aware of a typo in the code](https://github.com/Azure/azure-sdk-for-python/issues/14918) and is apparently considering potential fixes. 
* You don't have to load the client secret into your environment variables. Skip all that and use the `DefaultAzureCredential` like a modern engineer. 
* There are no `import` statements in the code examples. You'll have to figure out where those methods are on your own. 