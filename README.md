This sample allows to configure Sitecore to have its MongoDB databases hosting via the Azure DocmentDB service [like explained in my blog](https://alwaysupalwayson.blogspot.com/2016/05/azure-documentdb-protocol-support-for.html).

**_Warning: Azure DocumentDb support for MongoDb is in Preview version for the moment, so you canno't use this for Production purposes._**

This sample consists on 3 files you need to adapt and embed into your project:
- SitecoreProcessor\UpdateMongoDriverSettingsProcessor.cs
- App_Config\UpdateMongoDriverSettingsProcessor.config
- Example of the MongoDB connection strings with App_Config\ConnectionStrings.config