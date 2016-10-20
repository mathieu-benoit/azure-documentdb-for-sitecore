This sample allows to configure Sitecore to have its MongoDB databases hosting via the [Azure DocmentDB - mongodb protocol support](https://azure.microsoft.com/en-us/documentation/articles/documentdb-protocol-mongodb) service [like explained in my blog](https://alwaysupalwayson.blogspot.com/2016/05/azure-documentdb-protocol-support-for.html).

**_Warning: Azure DocumentDb support for MongoDb is in Preview version for the moment, so you canno't use this for Production purposes (here is the Sitecore Community thread to have more [details about current errors](https://community.sitecore.net/developers/f/9/t/3045)._**

The first project/folder "AzureDocumentDbForSitecore" consists on 3 files you need to adapt and embed into your project:
- AzureDocumentDbForSitecore\UpdateMongoDriverSettingsProcessor.cs
- App_Config\Include\UpdateMongoDriverSettingsProcessor.config
- Example of the MongoDB connection strings with App_Config\ConnectionStrings.DocumentDb.config

The second project/folder "AzureDocumentDbForSitecoreAzureResourceGroup" consists on 2 files:
- CreateAzureDocumentDbAndAssociatedResourceGroup.ps1 - the powershell script to run to create the Azure DocumentDB service with its associated Azure Resource Group.
- DocumentDbTemplateFile.json - the template as input for the above powershell script.

Current versions used:
- Sitecore 8.2.160729
- MongoDB driver 1.10.0.62

