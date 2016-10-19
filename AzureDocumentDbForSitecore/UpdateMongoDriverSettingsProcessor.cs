using Sitecore.Analytics.Pipelines.UpdateMongoDriverSettings;
using System.Security.Authentication;

namespace AzureDocumentDBForSitecore
{
    public class UpdateMongoDriverSettingsProcessor : global::Sitecore.Analytics.Pipelines.UpdateMongoDriverSettings.UpdateMongoDriverSettingsProcessor
    {
        public override void UpdateSettings(UpdateMongoDriverSettingsArgs args)
        {
            if (args.MongoSettings.Server != null
                && !string.IsNullOrEmpty(args.MongoSettings.Server.Host)
                && args.MongoSettings.Server.Host.EndsWith(".documents.azure.com"))
            {
                args.MongoSettings.SslSettings = new MongoDB.Driver.SslSettings();
                args.MongoSettings.SslSettings.EnabledSslProtocols = SslProtocols.Tls12;
            }
        }
    }
}