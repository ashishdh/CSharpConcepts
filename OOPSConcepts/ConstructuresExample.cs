namespace OOPSConcepts
{
    internal class ConstructuresExample
    {

        public static int Count;
        public string Name;
        public int Age;


        // Static Constructor      
        static ConstructuresExample()
        {
            Console.WriteLine("STATIC CONSTRUCTOR CALLED");
            Count = 0;
        }

        // Default Constructor       
        public ConstructuresExample()
        {
            Console.WriteLine("DEFAULT CONSTRUCTOR CALLED");
            Name = "Default User";
            Age = 0;
            Count++;
        }

        // Parameterized Constructor       
        public ConstructuresExample(string name, int age)
        {
            Console.WriteLine("PARAMETERIZED CONSTRUCTOR CALLED");
            Name = name;
            Age = age;
            Count++;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }    

           public void Run()
        {
            Console.WriteLine("Creating first object with DEFAULT constructor...");
            ConstructuresExample obj1 = new ConstructuresExample();
            obj1.Display();

            Console.WriteLine("Creating second object with PARAMETERIZED constructor...");
            ConstructuresExample obj2 = new ConstructuresExample("Ashish", 30);
            obj2.Display();

            Console.WriteLine($"Total objects created: {ConstructuresExample.Count}");

            Console.ReadLine();
        }
    }

}