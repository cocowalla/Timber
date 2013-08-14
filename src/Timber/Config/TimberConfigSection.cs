using System.Configuration;

namespace Timber.Config
{
    public class TimberSection : ConfigurationSection
    {
        [ConfigurationProperty("factory", IsRequired = true, IsKey = false)]
        public FactoryElement Factory
        {
            get { return (FactoryElement)base["factory"]; }
        }
    }
}
