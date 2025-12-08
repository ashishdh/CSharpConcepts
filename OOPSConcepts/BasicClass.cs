using System;

namespace OOPSConcepts
{
    public class BMICalculator
    {
        private float height;  
        private float weight;

        public void GetHeight()
        {
            Console.Write("Enter your height in meters: ");
            height = float.Parse(Console.ReadLine());
        }
        public void GetWeight()
        {
            Console.Write("Enter your weight in kg: ");
            weight = float.Parse(Console.ReadLine());
        }
        public void CalculateBMI() 
        {
            float bmi = weight / (height * height);
            Console.WriteLine($"Your BMI is: {bmi}");
        }
    }
  
}