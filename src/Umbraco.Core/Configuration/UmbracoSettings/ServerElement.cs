﻿namespace Umbraco.Core.Configuration.UmbracoSettings
{
    internal class ServerElement : InnerTextConfigurationElement<string>, IServerElement
    {
        public string ForcePortnumber
        {
            get
            {
                return RawXml.Attribute("forcePortnumber") == null
                           ? null
                           : RawXml.Attribute("forcePortnumber").Value;
            }
        }

        public string ForceProtocol
        {
            get
            {
                return RawXml.Attribute("forceProtocol") == null
                           ? null
                           : RawXml.Attribute("forceProtocol").Value;
            }
        }  

        string IServerElement.ServerAddress
        {
            get { return Value; }
        }
    }
}