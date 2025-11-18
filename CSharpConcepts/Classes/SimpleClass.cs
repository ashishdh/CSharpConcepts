using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts.Classes
{
    internal class SimpleClass
    {
        int a = 1;
        double b = 2.0;
        public void Calculate()
        {
            int sum = (int)(a + b);
            Console.WriteLine(sum);
        }       
    }
}
