using System.Configuration;

namespace ClientForApi
{
    [ConfigurationCollection(typeof(ConnectionStringsElement))]
    public class ConnectionStringsCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new ConnectionStringsElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((ConnectionStringsElement)element).Type;
        }

        public ConnectionStringsElement this[int idx]
        {
            get { return (ConnectionStringsElement)BaseGet(idx); }
        }
    }
}