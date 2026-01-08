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

            // Run separated demos — single console session
            PolymorphismDemo.Run(); 
            InheritanceDemo.Run();

            // Central pause so console stays open once for all demos
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }   
}