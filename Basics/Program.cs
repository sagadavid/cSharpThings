// See https://aka.ms/new-console-template for more information

using Basics;

Console.WriteLine("--praks -10 random ");
// RandomSpeech.RandomizeMethod();

Console.WriteLine("--praks -9 conversions");
// Konvert.ConversionMethod();

Console.WriteLine("--praks -8 class property");
// Person.PersonProperty();

Console.WriteLine("--praks -7");
// Console.WriteLine("{0}:{1}", byte.MaxValue, byte.MinValue); //255:0
// Console.WriteLine("{0}--{1}", float.MinValue, float.MaxValue); //-3,4028235E+38:3,4028235E+38

Console.WriteLine("--praks -6 ");
// var first = @"erikson i bathsaga\downloads ";
// var last = "vinning i bathsaga\\downloads ";
// var proclamation = string.Format("his name is {0}{1}", first, last);
// Console.WriteLine(proclamation); //his name is erikson vinning

Console.WriteLine("--praks -5 ");
// var joe = string.Join(" is a member of the family ", first, last);
// Console.WriteLine(joe);
// int[] numbs = { 1, 45, 56, 23, 78, 45 };
// Console.WriteLine(string.Join(" # ",numbs));

Console.WriteLine("--praks -4 ");
// Console.WriteLine("hexadecimal a : "+"\u0061");//a

Console.WriteLine("--praks -3 math.clamp weather in range?");
// int inrange =3;
// inrange = Math.Clamp(inrange, 0,2);
// Console.WriteLine("Math.Clamp results : "+inrange);//2


Console.WriteLine("--praks -2 constant");
// const float Pi = 3.14f;
// Console.WriteLine(Pi);//3,14

Console.WriteLine("--praksis -1 INCREMENT");
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

Console.WriteLine("-- praksis 1 ");
// Console.Write("hva kalles du : ");
// string kalles = Console.ReadLine();
// Console.Write("da... \n kalles du "+ kalles);

Console.WriteLine("-- praksis 2 console.readkey ");
// Console.WriteLine(
//                   "trykk noe knappe for å kvitte seg");
// Console.ReadKey();

Console.WriteLine("--praks 3");
// Console.BackgroundColor = ConsoleColor.Black;
// Console.ForegroundColor = ConsoleColor.DarkYellow;

// Console.Clear();
Console.WriteLine("--praks 4 console.clear");

Console.WriteLine("--praksis 5 console.title");
// Console.Title = "console.title";

Console.WriteLine("--praksis 6 console.beep");
// Console.Beep(440,1000);//Operation is not supported on this platform.

Console.WriteLine("--praks 7 string interpolation");
// var strpol = "\"string interpolation\"";
// var strpol2 = "\"strpol2\"";
// Console.WriteLine($"{strpol} is shown now and now by {strpol2}");

Console.WriteLine("--praks 8 verbatim");
// Console.WriteLine(@"you\we or this\that.. choose one\two :) ");

Console.WriteLine("--praks 9 strIntrPol med alignment");
// var ham = "olav";
// var henne = "siri";
// Console.WriteLine($"{ham,20}:hit");
// Console.WriteLine($"{henne, -20}:hit");

Console.WriteLine("--praks 10 strIntrPol formatting");
// Console.WriteLine($"{Math.PI:0.000} :only 3 digits shown");
// Console.WriteLine($"{42.1234:#.#}");//42.1
// Console.WriteLine($"{42.1234:#.}");//42
// Console.WriteLine($"{42.1234:####.#}");//42.12
// // Console.WriteLine($"{42.1234:000.000000}");//042,122400
// Console.WriteLine($"{42.123456:%0.0}");//??
// Console.WriteLine($"{42.123456:0.0%}");//??
// float a = 7;
// float b = 3;
// Console.WriteLine($"{a/b:0.0%}");//???

Console.WriteLine("--praks 11 ternary/conditional operator");
// Console.WriteLine("guess a number .. ");
// // string input = Console.ReadLine();
// // int score = Convert.ToInt32(input);
// int score = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(score >= 75 ? "you pass" : "you fail");

Console.WriteLine("--praks 12 switch");
// Console.Write("choose 1-3 ");
// int valg = Convert.ToByte(Console.ReadLine());
// switch (valg)
// {
//     case 1 :
//         Console.WriteLine("yey 1");
//         break;
//     case 2 :
//         Console.WriteLine("hurra 2");
//         break;
//     case 3:
//         Console.WriteLine("yippy 3");
//         break;
//     default:
//         Console.WriteLine("nah..press 1,2 or 3");
//         break;
// }