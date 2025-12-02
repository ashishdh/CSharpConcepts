namespace CSharpConcepts.Loops
{
    internal class SwitchCase
    {
        public static void SimpleSwitchCase()
        {
            int day = 3;

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                default:
                    Console.WriteLine("Invalid day");
                    break;
            }
        }

        public static void SwitchcaseWithString()
        {
            string role = "Admin";

            switch (role)
            {
                case "Admin":
                    Console.WriteLine("You have full access.");
                    break;

                case "User":
                    Console.WriteLine("You have limited access.");
                    break;

                default:
                    Console.WriteLine("Unknown role.");
                    break;
            }
        }

        public static void MultipleSwitchCases()
        {
            {
                string fruit = "apple";

                switch (fruit)
                {
                    case "apple":
                    case "mango":
                    case "banana":
                        Console.WriteLine("This is a sweet fruit.");
                        break;

                    default:
                        Console.WriteLine("Not in list.");
                        break;
                }
            }
        }
    }
}