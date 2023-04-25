using System.Reflection;
using System.Resources;
using System.Security.Cryptography;
using System.Text.Json;

namespace Basics;

public class TupleStuff
{
    //tuple declare, access osv;
    public static void Maintain()
    {
        //declaration
        var joiner = ("kerem", 2003, "kristiansand");

        //item callling
        Console.WriteLine("joiner.item1: " + joiner.Item1);
        Console.WriteLine("joiner detaljer: " + $"\nName:{joiner.Item1}, " +
                          $"BirthYear:{joiner.Item2}, " +
                          $"Origin:{joiner.Item3}");
        //printing
        Console.WriteLine("joiner: " + joiner.ToString());

        //assign one another after separate declaration
        (string, int, string) blander = new("", 0, "");
        blander = joiner;

        //assign one antother while declaration
        (string, int, string) skaffer = joiner;
        Console.WriteLine("blander: " + blander.ToString());
        Console.WriteLine("skaffer: " + skaffer.ToString());

        //naming tuple items (at declaration), naming with var !!
        (string Name, int Age, string) påtrå1 = new("kristofer", 0, "");
        (string Name, int Age, string) påtrå2 = ("", 0, "fredrikstad");
        var pårtå3 = (homeland: "", plateNo: 0, destination: "trondheim");

        //printing tuples
        Console.WriteLine("påtrå1: " + påtrå1.ToString());
        Console.WriteLine("påtrå2: " + påtrå2.ToString());
        Console.WriteLine("påtrå3: " + pårtå3.ToString());

        //printing tuple items with name
        Console.WriteLine("påtrå3.item1: " + pårtå3.Item1);
        Console.WriteLine(påtrå2.Age +
                          " <age/name> "
                          + påtrå1.Name +
                          " \npåtrå3.destination: " + pårtå3.destination);

        //tuple as parameter to a method
        IdentifyACandidate(("Smithson", 34, 2)); 
        
        // // tuple as a return type
        var level = GetScore().Level;
        Console.WriteLine("getscore.level "+level);
        //or...
        Console.WriteLine(GetScore().Name);
        Console.WriteLine(GetScore().Points);
        
        // deconstruct tuple- (getting all items per labels)
        var elbil = ("tesla", "black", "norge");
        Console.WriteLine(elbil.ToString());
        string brand;
        string color;
        string register;
        (brand, color, register) = elbil;
        Console.WriteLine(brand+"\n"+color+"\n"+register);
        
        //deconstruct- swap change
        Console.WriteLine("color: "+color);
        (color, brand, register) = (brand, color, register);
        Console.WriteLine("color: "+color);
        
        //deconstruct with discarded variable
        (string marka, string renk, _) = elbil;
        Console.WriteLine(marka+"\n"+renk);
        
        //equality
        (int, int) a = (1, 2);
        (int, int) b = (1, 2);
        Console.WriteLine(a == b); //true
        Console.WriteLine(a != b); //false
        
        var aa = (X: 2, Y: 4);
        var bb = (U: 2, V: 4);
        Console.WriteLine(aa == bb); //true
    }

    //tuple as a method
    public static void IdentifyACandidate((string name, int score, byte category) qualification)
    {
        // qualification.name = "tomas";
        // qualification.score = 98;
        // qualification.category = 5;
        Console.WriteLine(qualification.name +
                          "\n" + qualification.score +
                          "\n" + qualification.category);
    }

    //tuple as return type (of the book)
    public static (string Name, int Points, int Level) GetScore() => ("R2-D2", 12420, 15);
    
}