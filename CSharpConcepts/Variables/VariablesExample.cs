using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts.Variables
{
    internal class VariablesExample
    {
        static void Main()
        {         
            int age = 30;
            long bigNumber = 1234567890L;
            short smallNumber = 32000;
            byte oneByte = 255;

            //Decimal values
            float price = 99.99f;      
            double temperature = 36.67; 
            decimal salary = 55000.75m; 

           
            char grade = 'A';
            string name = "John Doe";  
        

            DateTime today = DateTime.Today;
            DateTime now = DateTime.Now;
         
            object obj = "This is an object";
            dynamic dyn = 123; 
            dyn = "Now I am a string";

            
            int[] numbers = { 1, 2, 3, 4, 5 };
            string[] fruits = new string[] { "Apple", "Banana", "Mango" };
         
         
            DayOfWeek todayEnum = DayOfWeek.Monday;
         
            var person = (Id: 1, FirstName: "Ashish", Age: 30);

            
            var list = new List<string> { "One", "Two", "Three" };

            Console.WriteLine($"Big Number: {bigNumber}, Small Number: {smallNumber}, One Byte: {oneByte}");
            Console.WriteLine($"Name: {name}, Age: {age}, Grade: {grade}");
            Console.WriteLine($"Today: {today}, Now: {now}");
            Console.WriteLine($"Person Tuple → {person.FirstName}, {person.Age}");
            Console.WriteLine("Fruits: " + string.Join(", ", fruits));  
            Console.WriteLine("List: " + string.Join(", ", list));  
            Console.WriteLine( "Dynamic Value: " + dyn );   
            Console.WriteLine("Enum Today: " + todayEnum );
        }
    }
}

