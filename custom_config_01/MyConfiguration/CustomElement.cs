using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConfiguration
{
    public class CustomElement : ConfigurationElement
    {
        [ConfigurationProperty("id", IsRequired = true, IsKey = true)]
        public int Id
        {
            get { return (int)base["id"]; }
        }

        [ConfigurationProperty("value1", IsRequired = false)]
        public string Value1
        {
            get { return (string)base["value1"]; }
        }

        [ConfigurationProperty("value2", IsRequired = false)]
        public string Value2
        {
            get { return (string)base["value2"]; }
        }

        [ConfigurationProperty("value3", IsRequired = false)]
        public string Value3
        {
            get { return (string)base["value3"]; }
        }

        [ConfigurationProperty("value4", IsRequired = false)]
        public string Value4
        {
            get { return (string)base["value4"]; }
        }
    }

}

