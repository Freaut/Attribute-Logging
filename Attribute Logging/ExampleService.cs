using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attribute_Logging
{
    public class ExampleService
    {
        [LogAttribute]
        public void PerformExampleOperation()
        {
            // Logic

            Console.WriteLine("Operation performed.");
        }
    }
}
