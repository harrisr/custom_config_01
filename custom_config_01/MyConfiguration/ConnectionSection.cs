using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConfiguration
{
    public class ConnectionSection : ConfigurationSection
    {
        [ConfigurationProperty("Servers")]
        public ServerAppearanceCollection Servers
        {
            get { return ((ServerAppearanceCollection)(base["Servers"])); }
            set { base["Servers"] = value; }
        }
    }
}
