public static class ControlStatements {
    public static void Run()
    {
        // PerformCalculationwithIf();
        PerformCalculationwithSwitch();
        // ComparisonOperations();
    }

    private static void PerformCalculationwithIf()
    {
        Console.WriteLine("Please follow the steps to Calculate two values");
        Console.WriteLine(@"Arithmetic Operation:
        1. Addition
        2. Subtraction
        3. Multiplication
        4. Division
        5. Modulus (Reminder)
        6. Lesserthan");

        Console.WriteLine("-----------------------------------------------------------------");

        Console.Write("Please enter the first number: ");
        double value1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Please choose an Arithmetic Operation from above: ");
        string operation = Console.ReadLine();

        Console.Write("Please enter the second number: ");
        double value2 = Convert.ToDouble(Console.ReadLine());

        if ((operation == "1") || (operation.ToLower() == "add") || operation.ToLower() == "addition" )
        {
            Console.WriteLine($"Result of {value1} + {value2} = {value1 + value2}");
        }
        else if (operation == "2")
        {
            Console.WriteLine($"Result of {value1} - {value2} = {value1 - value2}");
        }
        else if (operation == "3")
        {
            Console.WriteLine($"Result of {value1} * {value2} = {value1 * value2}");
        }
        else if (operation == "4")
        {
            Console.WriteLine($"Result of {value1} / {value2} = {value1 / value2}");
        }
        else if (operation == "5")
        {
            Console.WriteLine($"Result of {value1} % {value2} = {value1 % value2}");
        }
        else
        {
            Console.WriteLine("This Operator calcuation is under development!");
        }

        Console.Write("Do you want to calculate again? (y/n): ");
        string userInput = Console.ReadLine();

        // bool canClose;

        // if (userInput == "y") 
        //     canClose = false;
        // else
        //     canClose = true;

        // bool canClose = (userInput != "y") ? false : true;

        bool canClose = (userInput == "n");

        Console.WriteLine(canClose ? "User wants to close the screen" : "User wants to continue!...");

        // bool canClose = (userInput == "y")

        // Console.WriteLine(operation);
    }

    private static void PerformCalculationwithSwitch()
    {
        Console.WriteLine("Please follow the steps to Calculate two values");
        Console.WriteLine(@"Arithmetic Operation:
        1. Addition
        2. Subtraction
        3. Multiplication
        4. Division
        5. Modulus (Reminder)");

        Console.WriteLine("-----------------------------------------------------------------");

        Console.Write("Please enter the first number: ");
        double value1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Please choose an Arithmetic Operation from above: ");
        string operation = Console.ReadLine();

        Console.Write("Please enter the second number: ");
        double value2 = Convert.ToDouble(Console.ReadLine());

        switch (operation)
        {
            case "1":
                Console.WriteLine($"Result of {value1} + {value2} = {value1 + value2}");
                break;
            
            case "2":
                Console.WriteLine($"Result of {value1} - {value2} = {value1 - value2}");
                break;
            
            case "3":
                Console.WriteLine($"Result of {value1} * {value2} = {value1 * value2}");
                break;
            
            case "4":
                Console.WriteLine($"Result of {value1} / {value2} = {value1 / value2}");
                break;

            case "5":
                Console.WriteLine($"Result of {value1} % {value2} = {value1 % value2}");
                break;

            default:
                Console.WriteLine("This Operator calcuation is under development!");
                break;
        }


        Console.Write("Do you want to calculate again? (y/n): ");
        string userInput = Console.ReadLine();

        // bool canClose;

        // if (userInput == "y") 
        //     canClose = false;
        // else
        //     canClose = true;

        // bool canClose = (userInput != "y") ? false : true;

        // bool canClose = (userInput == "n");

        bool canClose = !(userInput == "y");


        Console.WriteLine(canClose ? "User wants to close the screen" : "User wants to continue!...");

        // bool canClose = (userInput == "y")

        // Console.WriteLine(operation);
    }

    private static void ComparisonOperations(){
        // ==, !=, <, >, <=, >=
        Console.WriteLine("Less than Operator <");
        Console.WriteLine(7.0 < 5.1);
        Console.WriteLine(5.1 < 5.1);
        Console.WriteLine(0.0 < 5.1);

        // if (7.0 > 5.1) {

        // }

        Console.WriteLine("Greater than Operator >");
        Console.WriteLine(7.0 > 5.1);
        Console.WriteLine(5.1 > 5.1);
        Console.WriteLine(0.0 > 5.1);

        Console.WriteLine("Less than or equal Operator <=");
        Console.WriteLine(7.0 <= 5.1);
        Console.WriteLine(5.1 <= 5.1);
        Console.WriteLine(0.0 <= 5.1);     

        Console.WriteLine("Greater than or equal Operator >=");
        Console.WriteLine(7.0 >= 5.1);
        Console.WriteLine(5.1 >= 5.1);
        Console.WriteLine(0.0 >= 5.1);  

    }
}