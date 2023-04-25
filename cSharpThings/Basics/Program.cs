// See https://aka.ms/new-console-template for more information

using Basics;
int county =1;

void PrC(string topic)
{
    Console.WriteLine("-- practice " + county + " is about-> "+topic);
    county++;
}

PrC("randomness");
// RandomSpeech.Main();

PrC("conversion");
// Konvert.Main();

PrC("class property");

PrC("formatting");
// Console.WriteLine("{0}:{1}", byte.MaxValue, byte.MinValue); //255:0
// Console.WriteLine("{0}--{1}", float.MinValue, float.MaxValue); //-3,4028235E+38:3,4028235E+38

PrC("formatting 2");
// var first = @"erikson i bathsaga\downloads ";
// var last = "vinning i bathsaga\\downloads ";
// var proclamation = string.Format("his name is {0}{1}", first, last);
// Console.WriteLine(proclamation); //his name is erikson vinning

PrC("formatting and arrays");
// var joe = string.Join(" is a member of the family ", first, last);
// Console.WriteLine(joe);
// int[] numbs = { 1, 45, 56, 23, 78, 45 };
// Console.WriteLine(string.Join(" # ",numbs));

PrC("hexadecimal");
// Console.WriteLine("hexadecimal a : "+"\u0061");//a

PrC("math.clamp weather in range?");
// int inrange =3;
// inrange = Math.Clamp(inrange, 0,2);
// Console.WriteLine("Math.Clamp results : "+inrange);//2


PrC("constantin:)");
// const float Pi = 3.14f;
// Console.WriteLine(Pi);//3,14

PrC("incremention");
//         //POSTFIX, PREFIX
//         int a = 1;
//         Console.WriteLine(a);//1
//         int c = a++;
//         Console.WriteLine(c);//1
// // a assigned to c, and later incremented. not assigned again
//         Console.WriteLine(a);//2
//         Console.WriteLine(c);//1
// // //a incremented, and then assigned to d
// //         int d = ++a;
// //         Console.WriteLine("d" + d);//d3

PrC("console readline");
// Console.Write("hva kalles du : ");
// string kalles = Console.ReadLine();
// Console.Write("da... \n kalles du "+ kalles);

PrC("console readkey");
// Console.WriteLine(
//                   "trykk noe knappe for å kvitte seg");
// Console.ReadKey();

PrC("console backgroundcolor");
// Console.BackgroundColor = ConsoleColor.Black;
// Console.ForegroundColor = ConsoleColor.DarkYellow;

PrC("console clear");
// Console.Clear();

PrC("console title");
// Console.Title = "console.title";

PrC("console beep");
// Console.Beep(440,1000);//Operation is not supported on this platform.

PrC("string interpolation");
PrC("verbatim");
PrC("string interpolation with alignment");
PrC("string interpolation with formatting");
// Stringer.Main();

PrC("ternary/conditional operator");
// Console.WriteLine("guess a number .. ");
// // string input = Console.ReadLine();
// // int score = Convert.ToInt32(input);
// int score = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(score >= 75 ? "you pass" : "you fail");

PrC("switch as regular form");
PrC("switch as expression + output string");
PrC("switch expression + output int");
// Switchings.Main();

PrC("while");
// int looper = 1;
// while (looper <= 5)
// {
//     string loopy = "loop";
//     if (looper >= 2)
//     {
//         loopy = "loops";
//     }
//
//     Console.WriteLine(looper + loopy);
//     looper++;
// }

PrC("while -false initiated");
// byte entry = 0;
// while (entry <= 2 || entry >= 4)
// {
//     Console.WriteLine("find the limit btw 0-255 : ");
//     entry=Convert.ToByte(Console.ReadLine());
// }
// Console.Write("yes.. the limit is "+entry);

PrC("do while");
// byte entri;
// do
// {
//     Console.WriteLine("find the limit btw 0-255 : ");
//     entri=Convert.ToByte(Console.ReadLine());  
// }
// while(entri <= 2 || entri >= 4);
// Console.Write("yes.. the limit is "+entri);

PrC("for loop");
// for (int loopi = 1; loopi <= 5; loopi++)
// {
//     Console.WriteLine("attempt "+loopi);
// }

PrC("while loop, break/continue");
// //from the book players guide
// while (true) //notice bool!
// {
//     Console.Write("exit/quit or a number 0-10: "); 
//     string input = Console.ReadLine();
//     if (input == "quit" || input == "exit")
//         break;//if we dont break it will go forever, fordi condition is always true !
//     byte number = Convert.ToByte(input);
//     if (number == 8)
//     {
//         Console.WriteLine("Pick another one.");
//         continue;//skip and loop again !
//     }
//     Console.WriteLine($"I like {number}. It's the one before {number + 1}!"); }

PrC("nested loop/grid");
// //from the book players guide
// int totalRows = 5;
// int totalColumns = 10;
// for (int currentRow = 1; currentRow <= totalRows; currentRow++)
// {
//     for (int currentColumn = 1; currentColumn <= totalColumns; currentColumn++)
//         Console.Write(currentRow);
//     Console.WriteLine();
// }

PrC("array, print, access");
// ArrayWorks.Main();

PrC("xml doc");
// /// visual studio xml entry

PrC("tuples");
// TupleStuff.Main();

PrC("class works, this.constructor, new alone constructor and others");
// Score.Main();

PrC("object class object");
// object thing = new object();
// Console.WriteLine("the thing is: " + thing);
// Console.WriteLine(thing.ToString());

PrC("generics");
// Generik<string, string> origins = new Generik<string, string>("olav", "trondheim");
// Console.WriteLine($"{origins.Value} is coming from {origins.Explain}");


Console.WriteLine();