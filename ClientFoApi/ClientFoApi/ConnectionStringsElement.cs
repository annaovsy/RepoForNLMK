using System.Configuration;

namespace ClientForApi
{
    public class ConnectionStringsElement : ConfigurationElement
    {
        [ConfigurationProperty("type", DefaultValue = "", IsKey = true, IsRequired = true)]
        public string Type
        {
            get { return (string)base["type"]; }
            set { base["type"] = value; }
        }

        [ConfigurationProperty("path", DefaultValue = "", IsKey = false, IsRequired = false)]
        public string Path
        {
            get { return (string)base["path"]; }
            set { base["path"] = value; }
        }
    }
}