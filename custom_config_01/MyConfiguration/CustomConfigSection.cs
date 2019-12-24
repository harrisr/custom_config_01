using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConfiguration
{
    public class CustomConfigSection : ConfigurationSection
    {
        [ConfigurationProperty("customElements")]
        public CustomElementCollection CustomElements
        {
            get { return ((CustomElementCollection)(base["customElements"])); }
            set { base["customElements"] = value; }
        }
    }
}
