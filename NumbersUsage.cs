public class NumbersUsage {
    public static void Run(){
        Console.WriteLine("Working with Numbers");

        // Numbers - int, double, decimal, float

        int a = 10;
        int b = 3;
        Console.WriteLine($"a={a} b={b}");  

        // Arichmetic Operators=> + - * / %
        int c = a + b;
        Console.WriteLine($"a + b =  {c}");

        c = a - b;
        Console.WriteLine($"a - b =  {c}");

        c = a * b;
        Console.WriteLine($"a * b =  {c}");

        c = a / b;
        Console.WriteLine($"a / b =  {c}");

            c = a % b;
        Console.WriteLine($"a % b =  {c}");

        // Increment / Decrement Operator
        a++;
        Console.WriteLine(a);

        a--;
        Console.WriteLine(a);

        int a1 = 10;
        int b1 = 3;
        double c1 = (double)a1 / (double)b1;
        Console.WriteLine(c1);

        decimal decValue = 1000.00M;
        Console.WriteLine(decValue);

    }
}   