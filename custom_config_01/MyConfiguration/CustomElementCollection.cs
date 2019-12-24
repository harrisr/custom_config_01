using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyConfiguration;

namespace MyConfiguration
{
    [ConfigurationCollection(typeof(CustomElement))]
    public class CustomElementCollection : ConfigurationElementCollection
    {
        internal const string PropertyName = "customElement";

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
            return new CustomElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((CustomElement)(element)).Id;
        }

        public CustomElement this[int idx]
        {
            get { return (CustomElement)BaseGet(idx); }
        }
    }

}
