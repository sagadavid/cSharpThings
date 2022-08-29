namespace Basics;

public class ArrayWorks
{
    public static void Main()
    {
        int [] skoret = new int[5] {1,2,3,4,5};//skoret array !
        skoret[1] = 5+1;
//acccess before or behind
        Console.WriteLine(skoret[1]);
        Console.WriteLine(skoret[^4]);
        Console.Write("skoret[] er: ");
        Array.ForEach(skoret,Console.Write);
        
        
        int[] skoret2 = skoret;
        Console.Write("\n skoret2 er: ");
        Array.ForEach(skoret2,Console.Write);
        skoret2[1] = 3 * 3;
        Console.Write("\n skoret etter forandring i skoret2: ");
        Array.ForEach(skoret,Console.Write);
        Console.Write("\n skoret2 etter forandring i skoret2: ");
        Array.ForEach(skoret2,Console.Write);
        Console.WriteLine();
        
//acces index range
        Array.ForEach(skoret[1..],Console.Write);
        Console.WriteLine();
        Array.ForEach(skoret[0..2],Console.Write);
        int[] rangeSkoret = skoret[0..2];
        Array.ForEach(rangeSkoret,Console.Write);

//array id
        Console.WriteLine("\n"+skoret.Length);
        Console.WriteLine(skoret.GetHashCode());
        Array.ForEach(skoret,Console.Write);

        skoret = new int[8];// is it the same skoret array??
        Console.WriteLine("\n"+skoret.Length);
        Console.WriteLine(skoret.GetHashCode());
        Array.ForEach(skoret,Console.Write);
        Console.WriteLine();
        
// double[] myDoubles = {2.4, 3.5, 2.9, 1.0};//java
        double[] doubles = new[] { 2.4, 3.5, 2.9, 1.0 };//c#
        Array.ForEach(doubles,Console.Write);//not correct printout
        int[] intArr = new[] { 3,4,5};
        Array.ForEach(intArr,Console.Write);
    }
}