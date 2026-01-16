namespace OOPSConcepts
{
    internal class Listexample
    {
        public static void Run()
        {

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            numbers.Add(6);
            numbers.Add(7);

            System.Console.WriteLine("Numbers in the list:");
            foreach (int number in numbers)
            {
                System.Console.WriteLine(number);
            }

            numbers.Remove(3);
            System.Console.WriteLine("\nAfter removing 3, numbers in the list:");
            foreach (int number in numbers)
            {
                System.Console.WriteLine(number);
            }

            System.Console.WriteLine($"Element at index 2: {numbers[2]}");

            System.Console.WriteLine($"Total numbers in the list: {numbers.Count}");
        }
    }
}
