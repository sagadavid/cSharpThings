namespace BasicPractices;

public class Stringo
{
    public static void StringoMethod ()
    {
        Console.WriteLine("**STRINGO-CLASS-METHOD\n");
        //STRING FORMAT USAGE
        Console.WriteLine("{0}:{1}", byte.MaxValue, byte.MinValue); //255:0
        Console.WriteLine("{0}--{1}", float.MinValue, float.MaxValue); //-3,4028235E+38:3,4028235E+38
        
        var first = @"erikson i bathsaga\downloads ";
        var last = "vinning i bathsaga\\downloads ";
        
        var proclamation = string.Format("his name is {0}{1}", first, last);
        Console.WriteLine(proclamation); //his name is erikson vinning
        
        var joe = string.Join(" is a member of the family ", first, last);
        Console.WriteLine(joe);

        int[] numbs = { 1, 45, 56, 23, 78, 45 };
        Console.WriteLine(string.Join(" # ",numbs));


    }
}