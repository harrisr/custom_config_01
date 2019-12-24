using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConfiguration
{
    public class JobSection : ConfigurationSection
    {
        [ConfigurationProperty("jobs")]
        public JobElementCollection Jobs
        {
            get { return ((JobElementCollection)(base["jobs"])); }
            set { base["jobs"] = value; }
        }
    }
}
