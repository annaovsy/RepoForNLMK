using System.Configuration;

namespace ClientForApi
{
    public class ConnectionApiConfigSection : ConfigurationSection
    {
        [ConfigurationProperty("ConnectionStrings")]
        public ConnectionStringsCollection CStringItems
        {
            get { return (ConnectionStringsCollection)base["ConnectionStrings"]; }
        }
    }

}
