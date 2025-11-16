namespace calculator_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice = getmenu();
            float result = 0;

            Console.WriteLine("Enter number 1:");
            float number1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter number 2:");
            float number2 = float.Parse(Console.ReadLine());

            result = calculate(number1, number2, choice);

            Console.WriteLine("The answer is " + result.ToString());

        }

        static string getmenu()
        {
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Divide");
            Console.WriteLine("4. Multiply");
            Console.WriteLine("q. Quit");


            string choice = Console.ReadLine();
            return choice;
        }

        static float calculate(float number1, float number2, string choice)
        {
            float result = 0;

            switch (choice)
            {
                case "1":
                    result = addfunction(number1, number2);
                    break;
                case "2":
                    result = subfunction(number1, number2);
                    break;
                case "3":
                    result = divfunction(number1, number2);
                    break;
                case "4":
                    result = mulfunction(number1, number2);
                    break;


                    Console.WriteLine($"The answer is {result}");
            }

            return result;
        }

        static float addfunction(float number1, float number2)
        {
            return number1 + number2;
        }
        static float subfunction(float number1, float number2)
        {
            return number1 - number2;
        }
        static float divfunction(float number1, float number2)
        {
            return number1 / number2;
        }
        static float mulfunction(float number1, float number2)
        {
            return number1 * number2;
        }
    }
}