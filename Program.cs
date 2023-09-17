

using C__.NET;

try
{
    var p1 = new Person();
    p1.Name = "Ram";
    p1.Age = 20;
    p1.SayHello();

    var p2 = new Person();
    p2.Name = "Kumar";
    p2.Age  = 130;
    p2.SayHello();    

    // byte age = p2.Age;
}
catch (System.Exception ex)
{
    NumbersUsage.WriteError(ex.Message);
    // throw;
}





// public partial class Program {
//     public static void Main(string[] args) {
        
//         // Console.ReadKey();

//         // StringUsage.Examples();

//         // NumbersUsage.Run();
//         NumbersUsage.MethodOverloadingExample();

//         // FloatingTypesUsage.Run();

//         // ControlStatements.Run();

//         // LoopStatements.Run();

//         // ControlStatements.Run();

//         Console.ReadKey();
//     }
// }

// Console.ReadKey();

// StringUsage.Examples();

// NumbersUsage.Run();
// NumbersUsage.MethodOverloadingExample();

// FloatingTypesUsage.Run();

// ControlStatements.Run();

// LoopStatements.Run();

// ControlStatements.Run();



Console.ReadKey();


