using System.Configuration;

namespace Timber.Config
{
    public class FactoryElement : ConfigurationElement
    {
        [ConfigurationProperty("type", IsRequired = true)]
        public string Type
        {
            get { return (string)base["type"]; }
        }
    }
}
