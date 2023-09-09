public static class LoopStatements {
    public static void Run() {
        // for
        // for (int i = 0; i < 10; i++)
        // {
        //     Console.WriteLine("Value of i is " + (i+1));
        // }

        // int[] numbers = {1, 2, 3, 4, 5, 6,7, 8, 9, 10} ;
        // for (int i = 0; i < numbers.Length; i++)
        // {
        //     Console.WriteLine($"numbers[{i}] => {numbers[i]}");
        // }

        // string[] names = {"Siva", "Amose", "Kumaresh", "Ram", "Koki" } ;
        // for (int i = 0; i < names.Length; i++)
        // {
        //     names[i] = names[i].ToUpper();
        //     Console.WriteLine($"names[{i}] => {names[i]}");
        // }

        
        // Console.Write("Please enter a value btwn 10 = 100: ");
        // int input = Convert.ToInt32(Console.ReadLine());
        // while (input > 50) {
        //     Console.WriteLine($"While Loop; user input is ${input}");
        //     input--;
        // }

        // do-while
        bool isPositiveNumber;
        do {
            Console.Write("Please enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            isPositiveNumber = number > 0;

        } while (isPositiveNumber);

    // foreach

    
    // Control statements
        // string[] names = {"Siva", "Amose", "Kumaresh", "Ram", "Koki" } ;
        // int i = 0;
        // foreach (string name in names )
        // {
        //     if ( name == "Kumaresh" ) continue; 
        //     names[0] = name.ToUpper();
        //     Console.WriteLine($"name => {names[0]}");
        //     i++ ;

        //     if (name == "Ram") break;
        // }

    }  
}