namespace BasicPractices;

public class Primitives
{
    public static void PrimitivMethod ()
    {
        Console.WriteLine("**PRIMITIV-CLASS-METHOD\n");
        //PRIMITIVES IN C#
        byte numara = 2;
        int numero = 23;
        float nummer = 23.45f;
        char @char = 'b';
        char karakter = 'c';
        string kelime = "word";
        bool isOnMission = false;

// VAR INSTEAD OF TYPE MODIFIER
        var nmara = 2;
        var nmero = 23;
        var nmmer = 23.45f;
        var krakter = 'c';
        var klime = "word";
        var isOnMissn = false;

        Console.WriteLine("karakter: " + karakter);//karakter: c
        Console.WriteLine("kelime " + kelime);//kelime word

//CONSTANTS
        const float Pi = 3.14f;
        Console.WriteLine(Pi);//3,14
    }
}