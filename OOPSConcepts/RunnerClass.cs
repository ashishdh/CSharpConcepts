using System;

namespace OOPSConcepts
{
    internal class RunnerClass
    {
        static void Main(string[] args)
        {
            new ConstructuresExample().Run();

            // This Keyword Example
            ThisKeyword obj = new ThisKeyword();
            obj.SetName("Ashish");      
            string name = obj.GetName();         
            Console.WriteLine("Name using THIS keyword: " + name);
        }
    }
}