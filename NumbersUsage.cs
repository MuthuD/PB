public class NumbersUsage {

    public static void WriteError(string msg){
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(msg);
        Console.ForegroundColor = ConsoleColor.Black;
    }

    public static double Add(double a, double b, double c = 0, double d = 0) {
        if ( a < 1 || b < 1 /*|| c < 1 || d < 1 */) {
            WriteError("Invalid Numbers!...");
            return 0;   
        }

        double result = a + b + c + d;
        return result;
    }
    // public static double Add(double a, double b, double c) {
    //     if ( a < 1 || b < 1 || c < 1) {
    //         Console.WriteLine("Invalid Number!...");
    //         return 0;   
    //     }

    //     double result = a + b + c;
    //     return result;
    // }

    // public static double Add(int a, int b) {
    //     if ( a < 1 || b < 1) {
    //         Console.WriteLine("Invalid Number!...");
    //         return 0;   
    //     }

    //     double result = a + b;
    //         return result;
    // }

    // public static double Add(double value1, double value2) {
    //     if ( a < 1 || b < 1) {
    //         Console.WriteLine("Invalid Number!...");
    //         return 0;   
    //     }

    //     double result = a + b;
    //         return result;
    // }

    public static void MethodOverloadingExample() {
        double a = 10;
        double b = 5;
        double c = 20;
        double d = 3;

        Console.WriteLine(Add(a, b));
        Console.WriteLine(Add(a, b, c));
        Console.WriteLine(Add(a, b, c, d));
        Console.WriteLine(Add(a, 0));
    }

    public static void Run(){
        Console.WriteLine("Working with Numbers");

        // Numbers - int, double, decimal, float

        int a = 10;
        int b = 3;
        Console.WriteLine($"a={a} b={b}");  

        // Arichmetic Operators=> + - * / %
        double c = Add(a, b);
        

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