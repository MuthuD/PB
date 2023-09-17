public class StringUsage
{
    public static void Examples(){
        Run();
    }

    internal static void Run()
    {
        // See https://aka.ms/new-console-template for more information
        //  Console.Write("Please enter your Full  Name: ");
        //  string name = Console.ReadLine();
        //  Console.WriteLine("Hello " +  name + "!");
        //  Console.WriteLine("Welcome to Programing Basics Course!");

        Console.WriteLine("Working with Strings!");

        string firstFriend = "Vijay";
        string secondFriend = "Mahesh";

        // String Interpolation
        Console.WriteLine($"My friends are {firstFriend} and {secondFriend}!");
        Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
        Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");


        // Trim
        string greeting = "     Hello World!          ";
        Console.WriteLine("[" + greeting + "]");
        Console.WriteLine("This is my " + greeting);
        Console.WriteLine($"This is my {greeting}");

        Console.WriteLine($"[{greeting}]");

        string trimmedGreeting = greeting.TrimStart();
        Console.WriteLine($"[{trimmedGreeting}]");

        trimmedGreeting = greeting.TrimEnd();
        Console.WriteLine($"[{trimmedGreeting}]");

        trimmedGreeting = greeting.Trim();
        Console.WriteLine($"[{trimmedGreeting}]");


        // Replace
        string sayHello = "Hello World!";
        Console.WriteLine(sayHello);
        sayHello = sayHello.Replace("Hello", "Greetings");
        Console.WriteLine(sayHello);
        Console.WriteLine();
        Console.WriteLine();

        // Character Casing
        Console.WriteLine(sayHello.ToLower());
        Console.WriteLine(sayHello.ToUpper());
        Console.WriteLine(sayHello);
        Console.WriteLine();
        Console.WriteLine();
        // String Search
        string songLyrics = "You say goodbye, and I say hello";
        Console.WriteLine(songLyrics);
        Console.WriteLine(songLyrics.Contains("goodbye"));
        Console.WriteLine(songLyrics.Contains("greetings"));

        // Multi-line string
        string multiLine1 = """
                        you say goodbye
                        and I sayhellow
                        asljflkajskl a;lkjas
                        alkjsfa; aslkja sk
                        """;
        Console.WriteLine(multiLine1);

        string multiLine2 = @"you say goodbye 
and I say hello";
        Console.WriteLine(multiLine2);
        Console.WriteLine();
        Console.WriteLine();
        // Extract from string
        string dateNow = "26-08-2023";
        Console.WriteLine(dateNow);
        Console.WriteLine($"Day {dateNow.Substring(0, 2)}");
        Console.WriteLine($"Month {dateNow.Substring(3, 2)}");
        Console.WriteLine($"Year {dateNow.Substring(6, 4)}");

        //  1 - 100;  3 length 
        string field1 = "11";

        Console.WriteLine(field1.PadLeft(3, '0'));
        Console.WriteLine(field1.PadRight(3, '0'));

        string path = "I:\\Classes\\";
        string textwithDoubleQuotes = "I like \t \"Weekends\"";

        Console.WriteLine(path);
        Console.WriteLine(textwithDoubleQuotes);

    }
}