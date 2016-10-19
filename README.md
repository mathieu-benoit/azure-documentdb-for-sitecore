This sample allows to configure Sitecore to have its MongoDB databases hosting via the Azure DocmentDB service [like explained in my blog](https://alwaysupalwayson.blogspot.com/2016/05/azure-documentdb-protocol-support-for.html).

**_Warning: Azure DocumentDb support for MongoDb is in Preview version for the moment, so you canno't use this for Production purposes (here is the Sitecore Community thread to have more [details about current errors](https://community.sitecore.net/developers/f/9/t/3045)._**

This sample consists on 3 files you need to adapt and embed into your project:
- AzureDocumentDbForSitecore\UpdateMongoDriverSettingsProcessor.cs
- App_Config\Include\UpdateMongoDriverSettingsProcessor.config
- Example of the MongoDB connection strings with App_Config\ConnectionStrings.DocumentDb.config

Current versions used:
- Sitecore 8.2.160729
- MongoDB driver 1.10.0.62

