namespace BasicPractices;

public class Increment
{
    public static void IncrementMethod ()
    {
        Console.WriteLine("** INCREMENT-CLASS-METHOD ****\n");
        //POSTFIX, PREFIX
        int a = 1;
        Console.WriteLine(a);//1
        int c = a++;
        Console.WriteLine(c);//1
// a assigned to c, and later incremented. not assigned again
        Console.WriteLine(a);//2
        Console.WriteLine(c);//1

//a incremented, and then assigned to d
        int d = ++a;
        Console.WriteLine("d" + d);//d3

    }
}