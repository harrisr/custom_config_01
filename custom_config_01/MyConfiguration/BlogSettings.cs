using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConfiguration
{
    public class BlogSettings : ConfigurationSection
    {
        private static BlogSettings settings = (BlogSettings)ConfigurationManager.GetSection("BlogSettings");

        public static BlogSettings Settings
        {
            get { return settings; }
        }
        
        /*
         *[ConfigurationProperty("jobs")]
        public JobElementCollection Jobs
        {
            get { return ((JobElementCollection)(base["jobs"])); }
            set { base["jobs"] = value; }
        }
        */
        [ConfigurationProperty("frontPagePostCount" , DefaultValue = 20 , IsRequired = false)]
        [IntegerValidator(MinValue=5, MaxValue=100)]
        public int FrontPagePostCount
        {
            get { return (int)this["frontPagePostCount"]; }
            set { this["frontPagePostCount"] = value; }
        }

        [ConfigurationProperty("title", IsRequired=true)]
        //[StringValidator(InvalidCharacters="~!@#$%^&*()[]{}/;\"|\\", MinLength=1, MaxLength=256)]
        public string Title
        {
            get { return (string)this["title"]; }
            set { this["title"] = value; }
        }
    }
}
