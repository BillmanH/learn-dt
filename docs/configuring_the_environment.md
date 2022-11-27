# Azure digital twin pipe and tanks simulation:

![Alt text](img\pipes_n_tanks.png?raw=true "pipes and tanks")

This is meant to be both a tutorial on digital twins, as well as a starter template for your own digital twin. The focus is on simulation and 

# Building the Azure Resources:

In the `infra` folder you will find `build_az.ps1`. I generally copy and paste it line by line into the terminal to make sure I'm configured correctly. Normally this part would be part of a build pipeline in ADO but I built this to run on my local machine out of simplicity. 
* You'll need to add yourself (and anyone else) data owner IAM roles to all of the resources. 

[Setting up the 3d Scenes](https://learn.microsoft.com/en-us/azure/digital-twins/quickstart-3d-scenes-studio). This should be automated, but the automation always seems to break for one reason or another. Eventually I end up running through the startup scripts here. 

**NOTE** You still need to add permissions to all of the things..
I would recommend adding them at the resource group level, that way you can do them all at once. However, you may not want to do that in your production environment. 

Add these to yourself in the portal:
* `Azure Digital Twins Data Owner` <- so that you can query and edit the digital twin
* `Storage Blob Data Owner` <- So that you can edit and access the blob storage.

Credit:
* [Steve Snow](https://www.thingiverse.com/snowman77/designs) for the pipe and tank objects on thingaverse. 
