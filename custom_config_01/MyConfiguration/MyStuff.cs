using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConfiguration
{
    public class MyStuff
    {
        private float foo;
        private string bar;
        
        public float Foo
        {
            get { return foo; }
            set { foo = value; }
        }
        
        public string Bar
        {
            get { return bar; }
            set { bar = value; }
        }
    }
}
