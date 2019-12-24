using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConfiguration
{
    public class JobElement : ConfigurationElement
    {
        [ConfigurationProperty("id", IsRequired = true, IsKey = true)]
        public int Id
        {
            get { return (int)base["id"]; }
        }

        [ConfigurationProperty("name", IsRequired = false)]
        public string Name
        {
            get { return (string)base["name"]; }
        }
    }

}

