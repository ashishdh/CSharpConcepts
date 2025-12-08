using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSConcepts
{
    internal class RunnerClass
    {
        public static void Main(string[] args)
        {
            BMICalculator bmi = new BMICalculator();

            bmi.GetHeight();
            bmi.GetWeight();
            bmi.CalculateBMI();
        }
    }
}
