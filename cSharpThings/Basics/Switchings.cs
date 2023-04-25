namespace Basics;

public class Switchings
{
    public static void Maintain()
    {
        Console.WriteLine("--praks 12 switch as regular form");
        Console.Write("choose 1-3 ");
        int valget = Convert.ToByte(Console.ReadLine());
        switch (valget)
        {
            case 1:
                Console.WriteLine("yey for 1");
                break;
            case 2:
            //Console.WriteLine("hurra 2");
            //break;
            case 3:
                Console.WriteLine("case 2and3 will have same outcome");
                break;
            default:
                Console.WriteLine("nah..press 1,2 or 3");
                break;
// If there is no match on a switch statement, the default behavior is to do nothing. No problem there.
        }


        Console.WriteLine("--praks 13 switch as expression " +
                          "output string");
        Console.WriteLine("choose 1,2 or 3");
        //With a switch expression, the overall expression has to evaluate to something,
        //and if it can’t find an expression to evaluate, the program will crash. 
        string outComing;
        int inComing = Convert.ToByte(Console.ReadLine());
        outComing = inComing switch
        {
            1 => "one",
            2 => "two",
            3 => "three",
            _ => "not one of them"
        };
        Console.WriteLine(outComing);
        

        Console.WriteLine("--praks 14 switch as expression " +
                          "output int");
        int expressionOutput;
        int expressionInput = Convert.ToByte(Console.ReadLine());
        expressionOutput = expressionInput switch
        {
            1 => 1,
            2 => 2,
            3 => 3,
            _ => 0
        };
        Console.WriteLine(expressionOutput);
    }
}