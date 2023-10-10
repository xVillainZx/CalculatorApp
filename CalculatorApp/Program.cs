using CalculatorApp;

class Program
{
    static void Main(String[] args)
    {
        bool endApp = false;

        Console.WriteLine("Console Calculator in C#\r");
        Console.WriteLine("--------------------------");

        while (!endApp)
        {
            string numInput1 = "";
            string numInput2 = "";
            double result = 0;

            Console.WriteLine("Type a number, and then press Enter.");
            numInput1 = Console.ReadLine();

            double cleanNum1 = 0;
            while (!double.TryParse(numInput1, out cleanNum1))
            {
                Console.WriteLine("This is not a valid input. Please enter an integer.");
                numInput1 = Console.ReadLine();
            }
            Console.WriteLine("Type another number, and then press Enter.");
            numInput2 = Console.ReadLine();

            double cleanNum2 = 0;
            while (!double.TryParse(numInput2, out cleanNum2))
            {
                Console.WriteLine("This is not a valid input. Please enter an integer.");
                numInput2 = Console.ReadLine();
            }

            Console.WriteLine("Choose an operator from the list below:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your Option? ");

            string op = Console.ReadLine();

            try
            {
                result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
                if (double.IsNaN(result))
                {
                    Console.WriteLine("This operation will result in a mathmatical error.\n");
                }
                else Console.WriteLine("Your result: {0:0.##}\n", result);
            }
            catch (Exception e)
            {
                Console.WriteLine("An exception occorred tyring to do the math.\n - Details: " + e.Message);
            }
            Console.WriteLine("------------------------\n");

            Console.WriteLine("Press 'n' and Enter to close the app, or any other key and Enter to continue. ");
            if (Console.ReadLine() == "n") endApp = true;

            Console.WriteLine("\n");
        }
        return;
    }
}