public static class FloatingTypesUsage {
    public static void Run() {
        
        // Console.WriteLine($"Size of float is {sizeof(float)} bytes");
        // Console.WriteLine($"Min Value of float is {float.MinValue}");
        // Console.WriteLine($"Max Value of float is {float.MaxValue}");

        // Console.WriteLine($"Size of double is {sizeof(double)} bytes");
        // Console.WriteLine($"Min Value of double is {double.MinValue}");
        // Console.WriteLine($"Max Value of double is {double.MaxValue}");
        
        // Console.WriteLine($"Size of decimal is {sizeof(decimal)} bytes");
        // Console.WriteLine($"Min Value of decimal is {decimal.MinValue}");
        // Console.WriteLine($"Max Value of decimal is {decimal.MaxValue}");

        float floatNum = 1f;
        double doubleNum = 1;
        decimal decimalNum = 1m;

        Console.WriteLine(floatNum/3);
        Console.WriteLine(doubleNum/3);
        Console.WriteLine(decimalNum/3);

        Console.ReadKey();
    }
}