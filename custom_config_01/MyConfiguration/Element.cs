using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConfiguration
{
    public class Element : ConfigurationElement
    {
        [ConfigurationProperty("name", DefaultValue = "", IsKey = true, IsRequired = true)]
        public string name
        {
            get { return (string)base["name"]; }
            set { base["name"] = value; }
        }

        [ConfigurationProperty("servername", DefaultValue = "", IsKey = false, IsRequired = true)]
        public string servername
        {
            get { return (string)base["servername"]; }
            set { base["servername"] = value; }
        }

        [ConfigurationProperty("isactive", DefaultValue = "true", IsKey = false, IsRequired = false)]
        public bool isactive
        {
            get { return (bool)base["isactive"]; }
            set { base["isactive"] = value; }
        }

        [ConfigurationProperty("userid", DefaultValue = "abhi", IsKey = false, IsRequired = false)]
        public string userid
        {
            get { return (string)base["userid"]; }
            set { base["userid"] = value; }
        }

        [ConfigurationProperty("password", DefaultValue = "password", IsKey = false, IsRequired = false)]
        public string password
        {
            get { return (string)base["password"]; }
            set { base["password"] = value; }
        }
    }
}
