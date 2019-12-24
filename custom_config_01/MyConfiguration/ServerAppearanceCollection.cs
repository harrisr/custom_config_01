using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConfiguration
{
    [ConfigurationCollection(typeof(Element))]
    public class ServerAppearanceCollection : ConfigurationElementCollection
    {
        internal const string PropertyName = "Element";

        public override ConfigurationElementCollectionType CollectionType
        {
            get { return ConfigurationElementCollectionType.BasicMapAlternate; }
        }

        protected override string ElementName
        {
            get { return PropertyName; }
        }

        protected override bool IsElementName(string elementName)
        {
            return elementName.Equals(PropertyName, StringComparison.InvariantCultureIgnoreCase);
        }
        
        public override bool IsReadOnly()
        {
            return false;
        }
        
        protected override ConfigurationElement CreateNewElement()
        {
            return new Element();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((Element)(element)).name;
        }

        public Element this[int idx]
        {
            get { return (Element)BaseGet(idx); }
        }
    }
}
