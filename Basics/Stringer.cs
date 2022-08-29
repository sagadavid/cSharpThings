namespace Basics;

public class Stringer
{
    private static string Him;
    
    private static void getHim()
    {
        // The Null Coalescing Operator: ??
        
        string? Him = "real Him";

       // Him ??= "not real Him";
       
       Console.WriteLine(Him ?? "not found");
    }
    
    public static void Maintain()
    {
        Console.WriteLine("--praks 7 string interpolation");
        var strpol = "\"string interpolation\"";
        var strpol2 = "\"strpol2\"";
        Console.WriteLine($"{strpol} is shown now and now by {strpol2}");
        
        Console.WriteLine("--praks 8 verbatim");
        Console.WriteLine(@"you\we or this\that.. choose one\two :) ");
        
        Console.WriteLine("--praks 9 string interpolation med alignment");
        var ham = "olav";
        var henne = "siri";
        Console.WriteLine($"{ham,20}:hit");
        Console.WriteLine($"{henne,-20}:hit");
        
        Console.WriteLine("--praks 10 string interpolation formatting");
        Console.WriteLine($"{Math.PI:0.000} :only 3 digits shown");
        Console.WriteLine($"{42.1234:#.#}"); //42.1
        Console.WriteLine($"{42.1234:#.}"); //42
        Console.WriteLine($"{42.1234:####.#}"); //42.12
        Console.WriteLine($"{42.1234:000.000000}"); //042,122400
        Console.WriteLine($"{42.123456:%0.0}"); //??
        Console.WriteLine($"{42.123456:0.0%}"); //??
        float a = 7;
        float b = 3;
        Console.WriteLine($"{a / b:0.0%}"); //???
        
        string? possibleNullInput = Console.ReadLine();
        Console.WriteLine(possibleNullInput);

        Stringer.getHim();

    }
}