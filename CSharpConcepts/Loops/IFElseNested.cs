namespace CSharpConcepts.Loops
{
    public class IFElseNested
    {
        public static void main()
        {
            int age = 25;
            bool hasLicense = true;

            if (age >= 18)
            {
                if (hasLicense)
                {
                    Console.WriteLine("You can drive.");
                }
                else
                {
                    Console.WriteLine("You must get a license.");
                }
            }
        }
    }
}
