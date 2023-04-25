namespace Basics;

public class ArrayWorks
{
    public static void Main()
    {
int[] skoret = new int[5] { 1, 2, 3, 4, 5 };//skoret array !
Console.Write("foreach skoret[] er: ");
Array.ForEach(skoret, Console.Write);
Console.WriteLine("\nskoret[1]= " + skoret[1]);
skoret[1] = 5 + 1;
//acccess before or behind
Console.WriteLine(skoret[0]);
Console.WriteLine(skoret[1]);
Console.WriteLine(skoret[^4]);
Console.WriteLine(skoret[^1]);

int[] skoret2 = skoret;
Console.Write("\n naa skoret2[] er: ");
Array.ForEach(skoret2, Console.Write);
skoret2[1] = 3 * 3;
Console.Write("\n skoret etter forandring i skoret2: ");
Array.ForEach(skoret, Console.Write);
Console.Write("\n skoret2 etter forandring i skoret2: ");
Array.ForEach(skoret2, Console.Write);

//acces index range
Console.WriteLine("index 1 and beyond");
Array.ForEach(skoret[1..], Console.Write);
Console.WriteLine("\nindex 0 to 2");
Array.ForEach(skoret[0..2], Console.Write);

Console.WriteLine("\ncustom range");
int[] customRange = skoret[0..2];
Array.ForEach(customRange, Console.Write);
Console.WriteLine();

//array id
Console.WriteLine("\nskoret's length " + skoret.Length);
Console.WriteLine("\nskoret's hashcode " + skoret.GetHashCode());
Console.WriteLine("skoret array ");
Array.ForEach(skoret, Console.Write);

skoret = new int[8];// is it the same skoret array??
Console.WriteLine("\nskoret's length after manipulation " + skoret.Length);
Console.WriteLine("\nskoret's hash after manipulation " + skoret.GetHashCode());
Console.WriteLine("skoret array now ");
Array.ForEach(skoret, Console.Write);
Console.WriteLine();

// double[] myDoubles = {2.4, 3.5, 2.9, 1.0};//java
double[] doubles = new[] { 2.4, 3.5, 2.9, 1.0 };//c#
Console.WriteLine("improper outprint of double array ");
Array.ForEach(doubles, Console.Write);//not correct printout
Console.WriteLine("proper outprint array");
int[] intArr = new[] { 3, 4, 5 };
Array.ForEach(intArr, Console.Write);
    }
}
