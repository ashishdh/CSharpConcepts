using System;

namespace OOPSConcepts
{
    internal class RunnerClass
    {
        public static void Main(string[] args)
        {
            // Existing demos (keep original order)
            new ConstructuresExample().Run();

            // This Keyword Example
            ThisKeyword obj = new ThisKeyword();
            obj.SetName("Ashish");
            string name = obj.GetName();
            Console.WriteLine("Name using THIS keyword: " + name);

            PolymorphismDemo.Run(); 
            InheritanceDemo.Run();

            ExceptionHandling.Run();

            Listexample.Run();
            DictExample.Run();

            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }   
}