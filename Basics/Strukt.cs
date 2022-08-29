namespace Basics;

public struct PairOfInts
{
    public int A;
    public int B;
}

public class PairOfIntsKl
{
    public int A;
    public int B;
}

public class PairOfPairs
{
    public PairOfInts _one;
    public PairOfInts _two;
    public PairOfIntsKl _three;
    public PairOfIntsKl _four;

    public void DisplayStruct()
    {
        Console.WriteLine($"{_one.A} {_one.B} and {_two.A} {_two.B}");
    }

    public void DisplayClass()
    {
        Console.WriteLine($"{_three.A} {_three.B} and {_four.A} {_four.B}");
    }
}

public struct SirkelStruct
{
    public double X { get; }
    public double Y { get; }
    // public double Radius { get; }
    public double Radius { get; set; }

    public SirkelStruct(double x, double y, double radius)
    {
        X = x;
        Y = y;
        Radius = radius;
    }
}

public class SirkelClass
{
    public double X { get; }
    public double Y { get; }
    // public double Radius { get; }
    public double Radius { get; set; }

    public SirkelClass(double x, double y, double radius)
    {
        X = x;
        Y = y;
        Radius = radius;
    }
}

class Mainer
{
    public static void Main()
    {
        //lecture 1
        Console.WriteLine("lecture 1 *********");
        PairOfInts pairOfInts = new();
        PairOfPairs pairOfPairs = new();

        //we can use these structs without calling a constructor.!!!! (like a value type variable)
        //In this case, the structs are initialized to default values by
        //zeroing out their memory, meaning A and B of both _one and _two
        //will be 0 until somebody changes it.
        //No matter what constructors you give a struct,
        //they may simply not be called!
        pairOfPairs.DisplayStruct(); //0 0 and 0 0
        // pairOfPairs.DisplayClass();
        // //Error: JetBrains Launcher could not run.
        ////Object reference not set to an instance of an object.
        ////(the referenced object is not initiated/instanced!!!)


        // lecture 2
        Console.WriteLine("lecture 2 ********");
        for (int number = 0; number < 2; number++)
        { 
        //there is one variable designed to hold a single CircleStruct,
        //and because it is a local variable, it lives on the stack.(***look self check below)
        //That variable is big enough to contain an entire CircleStruct,
        //with 8 bytes for X, Y, and Radius for a total of 24 bytes.
        //Every time we get to that new CircleStruct(...) part,
        //we re-initialize that memory location with new data.
        //But we reuse the memory location.
        SirkelStruct sirkelStrukt = new SirkelStruct(0, 0, 10);
          Console.WriteLine($"X={sirkelStrukt.X} Y = {sirkelStrukt.Y} Radius={sirkelStrukt.Radius}");
          //Process finished with exit code 0.
        }

        for (int number = 0; number < 2; number++)
        { 
        //we still have a single variable on the stack,
        //but that variable is a reference type and will only hold references.
        //This variable will be only 8 bytes (on a 64-bit computer). However,
        //each time we run new CircleClass(...),
        //a new CircleClass object is allocated on the heap.
        //By the time we finish, we will have done that 2  times and used 48 bytes,
        //(original exercise was 10000 times and 240000bytes)
        //and the garbage collector will need to clean them all up.
        SirkelClass sirkelKlass = new SirkelClass(0, 0, 10);

          Console.WriteLine($"X={sirkelKlass.X} Y = {sirkelKlass.Y} Radius={sirkelKlass.Radius}");
          //Process finished with exit code 0.
        }
        
        //self check

        // SirkelClass sirkelClass = new SirkelClass(0,0,0);
        // sirkelClass.Radius = 1;
        // Console.WriteLine(sirkelClass.Radius);
        // SirkelClass sirkelClass = new SirkelClass(0,0,2);//is already defined error
        // Console.WriteLine(sirkelClass.Radius);

        // SirkelStruct sirkelStruct = new SirkelStruct();
        // sirkelStruct.Radius = 3;
        // Console.WriteLine(sirkelStruct.Radius);
        // SirkelStruct sirkelStruct = new SirkelStruct();//is already defined error
        // sirkelStruct.Radius = 4;
        // Console.WriteLine(sirkelStruct.Radius);


    }
}