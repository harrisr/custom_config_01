using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyConfiguration;

namespace custom_config_01
{
    public class Program
    {
        public static void Main(string[] args)
        {

            /*
            try
            {
                var zzz1 = (BlogSettings)ConfigurationSettings.GetConfig("BlogSettings");
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0}", ex);
            }
            try
            {
                var zzz2 = (BlogSettings)ConfigurationManager.GetSection("BlogSettings");
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0}", ex);
            }


            string title = BlogSettings.Settings.Title;
            int count = BlogSettings.Settings.FrontPagePostCount;
            Console.WriteLine(count + "   -   " + title);



            MyStuff ms = (MyStuff)ConfigurationSettings.GetConfig("MyStuff");
            ms = (MyStuff)System.Configuration.ConfigurationManager.GetSection("MyStuff");

            var section = ConfigurationManager.GetSection("jobSection");
            if (section != null)
            {
                var jobs = ((JobSection)section).Jobs;
                Console.WriteLine(jobs.Count);
                for (int i = 0; i < jobs.Count; i++)
                {
                    Console.WriteLine("{0} - {1}", jobs[i].Id, jobs[i].Name);
                }
            }
            */
            
            var serverSection = ConfigurationManager.GetSection("serverSection");
            if (serverSection != null)
            {
                var servers = ((ConnectionSection)serverSection).Servers;
                Console.WriteLine(servers.Count);
                for (int i = 0; i < servers.Count; i++)
                {
                    Console.WriteLine("{0} - {1} - {2} - {3} - {4}", servers[i].name, servers[i].servername, servers[i].userid, servers[i].password, servers[i].isactive);
                }
            }



            var configSection = ConfigurationManager.GetSection("customConfigSection");
            if (configSection != null)
            {
                var elements = ((CustomConfigSection)configSection).CustomElements;
                Console.WriteLine(elements.Count);
                for (int i = 0; i < elements.Count; i++)
                {
                    Console.WriteLine("{0} - {1} - {2} - {3} - {4}", elements[i].Id, elements[i].Value1, elements[i].Value2, elements[i].Value3, elements[i].Value4);
                }
            }

            System.Console.ReadLine();
        }
    }
}
