using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attribute
{
    [My("22/07/2023", Number = 5)]
    public class MyClass
    {
        [My("21/07/2023", Number = 10)]
        public static void Method()
        {
            Console.WriteLine("MyClass.Method()");
        }
    }
}
