using System.Collections;
using Basics;

//int klass = 1;

//void PrC(string topic)
//{
//    Console.WriteLine("-- practice " + klass + " is about-> " + topic);
//    klass++;
//}

////////////////////////////////////////////////////////////////////////////////////

//STRUCTS lecture 1
Console.WriteLine("lecture 01 *********");
aStruct comeOnStruckt = new aStruct { };
comeOnStruckt.fieldA = 8;
comeOnStruckt.fieldB = 78;

aClass comeOnClass = new aClass { };
comeOnClass.fieldA = 234;
comeOnClass.fieldB = 45;

ConstructorDisplayer constDisp = new();

//we can use these structs without calling a constructor.!!!! (like a value type variable)

//In this case, the structs are initialized to default values by
//zeroing out their memory, meaning A and B of both _one and _two
//will be 0 until somebody changes it.

//No matter what constructors you give a struct,
//they may simply not be called!
constDisp.DisplayStructConstructors(); //0 0 and 0 


// STRUCTS lecture 2
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

SirkelClass sirkelA = new SirkelClass(0, 0, 0);
sirkelA.Radius = 1;
Console.WriteLine(sirkelA.Radius);
SirkelClass sirkelB = new SirkelClass(0, 0, 2);//is already defined error
Console.WriteLine(sirkelB.Radius);

SirkelStruct sirkelC = new SirkelStruct();
sirkelC.Radius = 3;
Console.WriteLine(sirkelC.Radius);
SirkelStruct sirkelD = new SirkelStruct();//is already defined error
sirkelD.Radius = 4;
Console.WriteLine(sirkelD.Radius);


////////////////////////////////////////////////////////////////////////////////////
//////CLASS EXERCISES
////this.constructor.
////name by constuctor
//Score eva = new Score("eva", 23, 12, "green");
//Console.WriteLine("name by constructor/object: " + eva._name);
//var nyScore = new Score();
//Console.WriteLine("name by constructor/object: " + nyScore._name);

//// //set-get by property (not method)
//// nyScore.SetName = "theodore";
//// Console.WriteLine("nyScore.GetName: " + nyScore.GetName);

////(3)
////property according to auto implementation
//nyScore.Naming = "auto setted name";
//Console.WriteLine("nyscore.naming: " + nyScore.Naming);
////could set a name !

////(4)
//// Score initScore = new Score("initNamePropertyWhileObjectInitiated", 23, 1, "colorful");
//// Console.WriteLine("******* "+initScore.Naming);
//// //couldnt set a name ! but it should while object initialization !


////new alone constructor (if compiler can infer the class)
////like var !!!
//Score scoreObject = new();

//Console.WriteLine("name by new alone constructor: " + scoreObject._name);

//Score scorObject2 = new("eli", 2, 3, "readOnlyColor");
//Console.WriteLine("name by constructor/object creation: " + scorObject2._name);

//// scorObject2._color = "yellow";//read only error

//Console.WriteLine(Score.FinalScore);

//Score.Report(scorObject2);

//Score factorizedScore = Score.MakeAScore();
//Score.Report(factorizedScore);

////////////////////////////////////////////////////////////////////////////////////

//var aPerson = new Person();
//aPerson.FirstName = "Jonatan";
//aPerson.LastName = "Smith";

//Console.WriteLine(aPerson.FirstName +
//                  "\n is a member of The Family \n"
//                  + aPerson.LastName);

////////////////////////////////////////////////////////////////////////////////////
/////
//// inheritance for constructors

//// DerivedKlass derivedKlass = new BaseKlass();//error
//DerivedKlass derivedKlass = new DerivedKlass();
//Console.WriteLine("derivedKlass_name from baseKlass-> " + derivedKlass.Name);
//Console.WriteLine("derivedKlass_number from derivedKlass-> " + derivedKlass.Number);

//BaseKlass baseKlass = new();

////ref1
//Console.WriteLine(derivedKlass.InteNum() + " og " + baseKlass.InteNum());//7 og 0

////ref2
//Console.WriteLine(derivedKlass.InteNum2() + " og " + baseKlass.InteNum2());//88 og 11



////////////////////////////////////////////////////////////////////////////////////

////PrC("************* random_ness");

////Console.WriteLine("** RANDOMIZE-CLASS-METHOD ****\n");
//////RANDOM PHRASE-MATIC FROM JAVA
////String[] subjects = { "i", "you", "he", "she", "we", "they" };
////String[] verbs = { "like", "dislike", "go", "drink", "read", "run", "quit" };
////String[] objects = { "tree", "school", "book", "table", "garden", "house", "room" };
////Random rand = new Random();

////int subjLength = subjects.Length;
////int verLength = verbs.Length;
////int objLength = objects.Length;

////var subRand = rand.Next(subjLength);
////var verbRand = rand.Next(verLength);
////var objRand = rand.Next(objLength);

////Console.WriteLine("A RANDOM PHRASE: \n"
////                  + subRand + " " + verbRand + " " + objRand);

////Console.WriteLine("A RANDOM PHRASE: \n"
////                  + subjects[subRand] + " " + verbs[verbRand] + " " + objects[objRand]);

////////////////////////////////////////////////////////////////////////////////////

//PrC("********************* conversion");

//Console.WriteLine("**  CONVERSION-CLASS-METHOD **** \n");
////CONVERSION, COMPILABLE, COMPATIBLE TYPES
//byte tall = 1;
//int antall = tall;
//Console.WriteLine(antall);//1
////byte is 4 bites, int is 8 bites.
////convertable,compilable. no data loss. //vice-versa will not compile.
////byte vantall= antall;//cant compile !! //Error CS0266: Cannot implicitly convert type 'int' to 'byte'.
////An explicit conversion exists (are you missing a cast?) (CS0266) (Salute)


////EXPLICIT CONVERT, CASTING
//int flertall = 3456;
//byte vantall = (byte)flertall;//this means i dont care data loss.
//                              //just convert as it is.
//Console.WriteLine(flertall.GetType().FullName);//System.Int32
//Console.WriteLine(flertall);//3456
//Console.WriteLine(vantall.GetType().FullName);//System.Byte
//Console.WriteLine(vantall);//128

////CONVERT NON-COMPATIBLE TYPE, CONVERT. OR .PARSE
//string s = "3";
//string r = "34";
////int w = (int)s;//cannot convert string to type
//int w = Convert.ToInt32(s);//int
//int q = int.Parse(r);
////int w = Convert.ToByte(s);//byte
////int w = Convert.ToInt16(s);//short
////int w = Convert.ToInt64(s);//long
//Console.WriteLine(w);//3
//Console.WriteLine(r);//34

////LOST BITS
//int n = 1000;
//byte b = (byte)n;
//Console.WriteLine(b);//232
////for byte takes 232 at max.couldnt take 1000 despite casting/forcing/explicitely converting

////CRASH PGA OVERFLOW
////use convert class when explicit casting is not possible
//var stNum = "1234";
//var conNum = Convert.ToInt32(stNum);
//Console.WriteLine(conNum);//1234

//var bye = (byte)conNum;
//Console.WriteLine(bye);//210

//// var by = Convert.ToByte(conNum);
//// Console.WriteLine(by);
//// Unhandled exception. System.OverflowException: Value was either too large or too small for an unsigned byte.
////     at System.Convert.ThrowByteOverflowException()
//// at System.Convert.ToByte(Int32 value)
//// at Program.<Main>$(String[] args) in /Users/bethsaga/RiderProjects/Basics/Basics/Program.cs:line 91

////TO AVOID OVERFLOWING USE CHECKED
//// checked {
//// 	byte number = 255;
//// 	number = (byte)(number + 1);
////     Console.WriteLine(number);//Unhandled exception. System.OverflowException: Arithmetic operation resulted in an overflow.
//// }

////HINDER CRASH BY TRY BLOCK

////try
////{
////    var mm = "1234";
////    byte bb = Convert.ToByte(mm);
////    Console.WriteLine("convert/compile succeeded " + bb);
////}
////catch (Exception ex)
////{
////    Console.WriteLine("myException message: could not convert to byte");//myException message: could not convert to byte
////}

//////convert to boolean

////try
////{
////    var vool = "true";
////    bool buul = Convert.ToBoolean(vool);
////    Console.WriteLine("convert/compile succeeded " + buul);//convert/compile succeeded True
////}
////catch (Exception ex)
////{
////    Console.WriteLine("myException message: couldnt be converted to byte");
////}

////////////////////////////////////////////////////////////////////////////////////

//PrC("**************** class property");

/////////////////////////////////////////////////////////////////////////////////
//PrC("********************************************formatting");
//// Console.WriteLine("{0}:{1}", byte.MaxValue, byte.MinValue); //255:0
//// Console.WriteLine("{0}--{1}", float.MinValue, float.MaxValue); //-3,4028235E+38:3,4028235E+38

/////////////////////////////////////////////////////////////////////////////////
//PrC("********************************************formatting 2");
//// var first = @"erikson i bathsaga\downloads ";
//// var last = "vinning i bathsaga\\downloads ";
//// var proclamation = string.Format("his name is {0}{1}", first, last);
//// Console.WriteLine(proclamation); //his name is erikson vinning

/////////////////////////////////////////////////////////////////////////////////
//PrC("********************************************formatting and arrays");
//// var joe = string.Join(" is a member of the family ", first, last);
//// Console.WriteLine(joe);
//// int[] numbs = { 1, 45, 56, 23, 78, 45 };
//// Console.WriteLine(string.Join(" # ",numbs));

/////////////////////////////////////////////////////////////////////////////////
//PrC("********************************************hexadecimal");
//// Console.WriteLine("hexadecimal a : "+"\u0061");//a

/////////////////////////////////////////////////////////////////////////////////
//PrC("********************************************math.clamp weather in range?");
//// int inrange =3;
//// inrange = Math.Clamp(inrange, 0,2);
//// Console.WriteLine("Math.Clamp results : "+inrange);//2


/////////////////////////////////////////////////////////////////////////////////
//PrC("********************************************constantin:)");
//// const float Pi = 3.14f;
//// Console.WriteLine(Pi);//3,14

/////////////////////////////////////////////////////////////////////////////////
//PrC("********************************************incremention");
////         //POSTFIX, PREFIX
////         int a = 1;
////         Console.WriteLine(a);//1
////         int c = a++;
////         Console.WriteLine(c);//1
//// // a assigned to c, and later incremented. not assigned again
////         Console.WriteLine(a);//2
////         Console.WriteLine(c);//1
//// // //a incremented, and then assigned to d
//// //         int d = ++a;
//// //         Console.WriteLine("d" + d);//d3

/////////////////////////////////////////////////////////////////////////////////
//PrC("********************************************console readline");
//// Console.Write("hva kalles du : ");
//// string kalles = Console.ReadLine();
//// Console.Write("da... \n kalles du "+ kalles);

/////////////////////////////////////////////////////////////////////////////////
//PrC("********************************************console readkey");
//// Console.WriteLine(
////                   "trykk noe knappe for å kvitte seg");
//// Console.ReadKey();

/////////////////////////////////////////////////////////////////////////////////
//PrC("********************************************console backgroundcolor");
//// Console.BackgroundColor = ConsoleColor.Black;
//// Console.ForegroundColor = ConsoleColor.DarkYellow;

/////////////////////////////////////////////////////////////////////////////////
//PrC("********************************************console clear");
//// Console.Clear();

/////////////////////////////////////////////////////////////////////////////////
//PrC("********************************************console title");
//// Console.Title = "console.title";

/////////////////////////////////////////////////////////////////////////////////
//PrC("********************************************console beep");
//// Console.Beep(440,1000);//Operation is not supported on this platform.

/////////////////////////////////////////////////////////////////////////////////
/////
//PrC("********************************************string interpolation");
//PrC("********************************************verbatim");
//PrC("********************************************string interpolation with alignment");
//PrC("********************************************string interpolation with formatting");

//Console.WriteLine("--praks 7 string interpolation");
//var strpol = "\"string interpolation\"";
//var strpol2 = "\"strpol2\"";
//Console.WriteLine($"{strpol} is shown now and now by {strpol2}");

//Console.WriteLine("--praks 8 verbatim");
//Console.WriteLine(@"you\we or this\that.. choose one\two :) ");

//Console.WriteLine("--praks 9 string interpolation med alignment");
//var ham = "olav";
//var henne = "siri";
//Console.WriteLine($"{ham,20}:hit");
//Console.WriteLine($"{henne,-20}:hit");

//Console.WriteLine("--praks 10 string interpolation formatting");
//Console.WriteLine($"{Math.PI:0.000} :only 3 digits shown");
//Console.WriteLine($"{42.1234:#.#}"); //42.1
//Console.WriteLine($"{42.1234:#.}"); //42
//Console.WriteLine($"{42.1234:####.#}"); //42.12
//Console.WriteLine($"{42.1234:000.000000}"); //042,122400
//Console.WriteLine($"{42.123456:%0.0}"); //??
//Console.WriteLine($"{42.123456:0.0%}"); //??
//float a = 7;
//float b = 3;
//Console.WriteLine($"{a / b:0.0%}"); //???

//string? possibleNullInput = Console.ReadLine();
//Console.WriteLine(possibleNullInput);

//Stringer.getHim();

/////////////////////////////////////////////////////////////////////////////////

//PrC("********************************************ternary/conditional operator");
//// Console.WriteLine("guess a number .. ");
//// // string input = Console.ReadLine();
//// // int score = Convert.ToInt32(input);
//// int score = Convert.ToInt32(Console.ReadLine());
//// Console.WriteLine(score >= 75 ? "you pass" : "you fail");

//////////////////////////////////////////////////////////////////////////////////
//PrC("********************************************switch as regular form");
//PrC("********************************************switch as expression + output string");
//PrC("********************************************switch expression + output int");

//Console.WriteLine("--praks 12 switch as regular form");
//Console.Write("choose 1-3 ");
//int valget = Convert.ToByte(Console.ReadLine());
//switch (valget)
//{
//    case 1:
//        Console.WriteLine("yey for 1");
//        break;
//    case 2:
//    //Console.WriteLine("hurra 2");
//    //break;
//    case 3:
//        Console.WriteLine("case 2and3 will have same outcome");
//        break;
//    default:
//        Console.WriteLine("nah..press 1,2 or 3");
//        break;
//        // If there is no match on a switch statement, the default behavior is to do nothing. No problem there.
//}


//Console.WriteLine("--praks 13 switch as expression " +
//                  "output string");
//Console.WriteLine("choose 1,2 or 3");
////With a switch expression, the overall expression has to evaluate to something,
////and if it can’t find an expression to evaluate, the program will crash. 
//string outComing;
//int inComing = Convert.ToByte(Console.ReadLine());
//outComing = inComing switch
//{
//    1 => "one",
//    2 => "two",
//    3 => "three",
//    _ => "not one of them"
//};
//Console.WriteLine(outComing);


//Console.WriteLine("--praks 14 switch as expression " +
//                  "output int");
//int expressionOutput;
//int expressionInput = Convert.ToByte(Console.ReadLine());
//expressionOutput = expressionInput switch
//{
//    1 => 1,
//    2 => 2,
//    3 => 3,
//    _ => 0
//};
//Console.WriteLine(expressionOutput);


///////////////////////////////////////////////////////////////////////////////
//PrC("********************************************while");
//// int looper = 1;
//// while (looper <= 5)
//// {
////     string loopy = "loop";
////     if (looper >= 2)
////     {
////         loopy = "loops";
////     }
////
////     Console.WriteLine(looper + loopy);
////     looper++;
//// }

//PrC("********************************************while -false initiated");
//// byte entry = 0;
//// while (entry <= 2 || entry >= 4)
//// {
////     Console.WriteLine("find the limit btw 0-255 : ");
////     entry=Convert.ToByte(Console.ReadLine());
//// }
//// Console.Write("yes.. the limit is "+entry);

//PrC("********************************************do while");
//// byte entri;
//// do
//// {
////     Console.WriteLine("find the limit btw 0-255 : ");
////     entri=Convert.ToByte(Console.ReadLine());  
//// }
//// while(entri <= 2 || entri >= 4);
//// Console.Write("yes.. the limit is "+entri);

//PrC("********************************************for loop");
//// for (int loopi = 1; loopi <= 5; loopi++)
//// {
////     Console.WriteLine("attempt "+loopi);
//// }

//PrC("********************************************while loop, break/continue");
//// //from the book players guide
//// while (true) //notice bool!
//// {
////     Console.Write("exit/quit or a number 0-10: "); 
////     string input = Console.ReadLine();
////     if (input == "quit" || input == "exit")
////         break;//if we dont break it will go forever, fordi condition is always true !
////     byte number = Convert.ToByte(input);
////     if (number == 8)
////     {
////         Console.WriteLine("Pick another one.");
////         continue;//skip and loop again !
////     }
////     Console.WriteLine($"I like {number}. It's the one before {number + 1}!"); }

/////////////////////////////////////////////////////////////////////////////////
//PrC("********************************************nested loop/grid");
//// //from the book players guide
//// int totalRows = 5;
//// int totalColumns = 10;
//// for (int currentRow = 1; currentRow <= totalRows; currentRow++)
//// {
////     for (int currentColumn = 1; currentColumn <= totalColumns; currentColumn++)
////         Console.Write(currentRow);
////     Console.WriteLine();
//// }

/////////////////////////////////////////////////////////////////////////////////

//PrC("******************************************** array, print, access");
//int[] skoret = new int[5] { 1, 2, 3, 4, 5 };//skoret array !
//Console.Write("foreach skoret[] er: ");
//Array.ForEach(skoret, Console.Write);
//Console.WriteLine("\nskoret[1]= " + skoret[1]);
//skoret[1] = 5 + 1;
////acccess before or behind
//Console.WriteLine(skoret[0]);
//Console.WriteLine(skoret[1]);
//Console.WriteLine(skoret[^4]);
//Console.WriteLine(skoret[^1]);

//int[] skoret2 = skoret;
//Console.Write("\n naa skoret2[] er: ");
//Array.ForEach(skoret2, Console.Write);
//skoret2[1] = 3 * 3;
//Console.Write("\n skoret etter forandring i skoret2: ");
//Array.ForEach(skoret, Console.Write);
//Console.Write("\n skoret2 etter forandring i skoret2: ");
//Array.ForEach(skoret2, Console.Write);

////acces index range
//Console.WriteLine("index 1 and beyond");
//Array.ForEach(skoret[1..], Console.Write);
//Console.WriteLine("\nindex 0 to 2");
//Array.ForEach(skoret[0..2], Console.Write);

//Console.WriteLine("\ncustom range");
//int[] customRange = skoret[0..2];
//Array.ForEach(customRange, Console.Write);
//Console.WriteLine();

////array id
//Console.WriteLine("\nskoret's length " + skoret.Length);
//Console.WriteLine("\nskoret's hashcode " + skoret.GetHashCode());
//Console.WriteLine("skoret array ");
//Array.ForEach(skoret, Console.Write);

//skoret = new int[8];// is it the same skoret array??
//Console.WriteLine("\nskoret's length after manipulation " + skoret.Length);
//Console.WriteLine("\nskoret's hash after manipulation " + skoret.GetHashCode());
//Console.WriteLine("skoret array now ");
//Array.ForEach(skoret, Console.Write);
//Console.WriteLine();

//// double[] myDoubles = {2.4, 3.5, 2.9, 1.0};//java
//double[] doubles = new[] { 2.4, 3.5, 2.9, 1.0 };//c#
//Console.WriteLine("improper outprint of double array ");
//Array.ForEach(doubles, Console.Write);//not correct printout
//Console.WriteLine("proper outprint array");
//int[] intArr = new[] { 3, 4, 5 };
//Array.ForEach(intArr, Console.Write);

/////////////////////////////////////////////////////////////////////////////////
//PrC("********************************************xml doc");
//// /// visual studio xml entry

/////////////////////////////////////////////////////////////////////////////////
//PrC("********************************************tuples");

////tuple declare, access osv;
////declaration
//var joiner = ("kerem", 2003, "kristiansand");

////item callling
//Console.WriteLine("joiner.item1: " + joiner.Item1);
//Console.WriteLine("joiner detaljer: " + $"\nName:{joiner.Item1}, " +
//                  $"BirthYear:{joiner.Item2}, " +
//                  $"Origin:{joiner.Item3}");
////printing
//Console.WriteLine("joiner: " + joiner.ToString());

////assign one another after separate declaration
//(string, int, string) blander = new("", 0, "");
//blander = joiner;

////assign one antother while declaration
//(string, int, string) skaffer = joiner;
//Console.WriteLine("blander: " + blander.ToString());
//Console.WriteLine("skaffer: " + skaffer.ToString());

////naming tuple items (at declaration), naming with var !!
//(string Name, int Age, string) påtrå1 = new("kristofer", 0, "");
//(string Name, int Age, string) påtrå2 = ("", 0, "fredrikstad");
//var pårtå3 = (homeland: "", plateNo: 0, destination: "trondheim");

////printing tuples
//Console.WriteLine("påtrå1: " + påtrå1.ToString());
//Console.WriteLine("påtrå2: " + påtrå2.ToString());
//Console.WriteLine("påtrå3: " + pårtå3.ToString());

////printing tuple items with name
//Console.WriteLine("påtrå3.item1: " + pårtå3.Item1);
//Console.WriteLine(påtrå2.Age +
//                  " <age/name> "
//                  + påtrå1.Name +
//                  " \npåtrå3.destination: " + pårtå3.destination);

////tuple as parameter to a method
//IdentifyACandidate(("Smithson", 34, 2));

//// // tuple as a return type
//var level = GetScore().Level;
//Console.WriteLine("getscore.level " + level);
////or...
//Console.WriteLine(GetScore().Name);
//Console.WriteLine(GetScore().Points);

//// deconstruct tuple- (getting all items per labels)
//var elbil = ("tesla", "black", "norge");
//Console.WriteLine(elbil.ToString());
//string brand;
//string color;
//string register;
//(brand, color, register) = elbil;
//Console.WriteLine(brand + "\n" + color + "\n" + register);

////deconstruct- swap change
//Console.WriteLine("color: " + color);
//(color, brand, register) = (brand, color, register);
//Console.WriteLine("color: " + color);

////deconstruct with discarded variable
//(string marka, string renk, _) = elbil;
//Console.WriteLine(marka + "\n" + renk);

////equality
//(int, int) a = (1, 2);
//(int, int) b = (1, 2);
//Console.WriteLine(a == b); //true
//Console.WriteLine(a != b); //false

//var aa = (X: 2, Y: 4);
//var bb = (U: 2, V: 4);
//Console.WriteLine(aa == bb); //true

////tuple as a method
// static void IdentifyACandidate((string name, int score, byte category) qualification)
//{
//    // qualification.name = "tomas";
//    // qualification.score = 98;
//    // qualification.category = 5;
//    Console.WriteLine(qualification.name +
//                      "\n" + qualification.score +
//                      "\n" + qualification.category);
//}

////tuple as return type (of the book)
// static (string Name, int Points, int Level) GetScore() => ("R2-D2", 12420, 15);

/////////////////////////////////////////////////////////////////////////////////
//PrC("********************************************class works, this.constructor, new alone constructor and others");
//// Score.Main();

/////////////////////////////////////////////////////////////////////////////////
//PrC("******************************************** class object");
//// object thing = new object();
//// Console.WriteLine("the thing is: " + thing);
//// Console.WriteLine(thing.ToString());

/////////////////////////////////////////////////////////////////////////////////
//PrC("******************************************** generics");
//// Generik<string, string> origins = new Generik<string, string>("olav", "trondheim");
//// Console.WriteLine($"{origins.Value} is coming from {origins.Explain}");

////using generik with multiple types
//Generik<string, int> generikMultiple = new Generik<string, int>("erik", 197);
//Console.WriteLine($"{generikMultiple.Value} is {generikMultiple.Explain} cm high.");

//var generikFlerTypig = new Generik<string, bool>("am i late?", false);
//Console.WriteLine(generikFlerTypig.Value + " hmm i guess " + generikFlerTypig.Explain);

//// //using  generik List<T> (((before inheritance)))
//var experimental = new List<string>();
//experimental.Add("what");

//var experimental2 = new List<int>();
//experimental2.Add(23);
//Console.WriteLine(experimental2.GetItemAt(0));

////using generik List (((after inheritance)))
////cant instantiate with two different type ???
//// var experimental3 = new List<int>(23, 78);
//// Console.WriteLine(experimental3.Explain+" -and- "+experimental3.Value);
////

////generic method in a regular class
//NonGenericButaMethod.Repeat("nonGenericClass but aMethod", 7);
/////////////////////////////////////////////////////////////////////////////////

//Console.WriteLine();

/////* HASH TABLE */
//////The Hashtable represents a collection of a key-value pair
//////that is organized based on the hash code of the key.

////Hashtable hashTable = new Hashtable();
////hashTable.Add("first", 174);
////hashTable.Add(45, "Sixty");
////hashTable.Add(6.9, 124.24);

//////hashTable.Add(Element.Second, "Sixty");
//////hashTable.Add(Element.Third, 124.24);

////foreach (var key in hashTable.Keys)
////{
////    Console.WriteLine($"Key: {key}, value: {hashTable[key]}");
////}

////hashTable.Remove(45);

////foreach (var key in hashTable.Keys)
////{
////    Console.WriteLine($"Key: {key}, value: {hashTable[key]}");
////}


////if (hashTable.ContainsKey(6.9))
////{
////    Console.WriteLine($"Collection contains key: {6.9} " +
////        $"and its value is {hashTable[6.9]}");
////}


////var keys = hashTable.Keys;
////foreach (var key in keys)
////{
////    Console.WriteLine("key " + key);
////}
////Console.WriteLine();
////var values = hashTable.Values;
////foreach (var value in values)
////{
////    Console.WriteLine("value " + value);
////}

////hashTable.Clear();

/////////////////////////////////////////////////////////////////////////////////
/////
/////* STACK COLLECTION **********************************/
//////A stack collection represents a simple last-in, first-out collection.
/////It means that an element that enters first in a collection will exit last.

////Stack stack = new Stack();
//////OR
////Stack<int> stackInt = new Stack<int>();

////stack.Push(328);//inserts an object at the top of the collection:
////stack.Push("Fifty Five");
////stack.Push(124.87);

////double number1 = Convert.ToDouble(stack.Peek());//Peek returns an object ready to exit the collection, but it doesn’t remove it:
////Console.WriteLine($"Element returned/peeked from a collection is: {number1}");

////double number = Convert.ToDouble(stack.Pop());//removes the element which was included last in a collection and returns it:
////Console.WriteLine($"Element removed/popped from a collection is: {number}");


////Console.WriteLine("items on the stack:\n");
////foreach (var item in stack)
////{
////    Console.WriteLine(item);
////}

////stack.Clear();//To remove all objects from a collection
////Console.WriteLine("items on the stack now: "+stack.Count);

/////* QUEUE COLLECTION, enqueo, dequeue, peek, clear, count **********************************/
/////*The queue collection represents a first-in, first-out collection of objects.
////This means that we can place our objects in a queue collection in a
////certain order and remove those objects in the same order. So, the first object
////which goes in is the first object to go out.*/

////Queue<int> intCollection = new Queue<int>();
//////OR
////Queue queueCollection = new Queue();

////Queue queueCollection1 = new Queue();
////queueCollection1.Enqueue(54);//adds an element inside a collection:
////queueCollection1.Enqueue("John");
////queueCollection1.Enqueue(54.10);

//////int number = Convert.ToInt32(queueCollection1.Dequeue());//remove an element at the beginning of the collection and return it
////var rItem = queueCollection1.Dequeue();
////Console.WriteLine($"Removed/dequeued item is: {rItem}");

////var peek = queueCollection1.Peek();//returns the element at the beginning of the collection but does not remove it:
////Console.WriteLine($"current beginning item is : {peek}");
////Console.WriteLine();

////foreach (var item in queueCollection1)
////{
////    Console.WriteLine(item);
////}

////queueCollection1.Clear();
////Console.WriteLine("current total items after clear :"+queueCollection1.Count);


/////* Calling Constructors from the Base Class ************************************/

////XMLWriter xmlWriter = new XMLWriter("xmlFileName");
////xmlWriter.FormatXMLFile();
////xmlWriter.Write();
////Console.WriteLine(xmlWriter.FileName);
////JSONWriter jsonWriter = new JSONWriter("jsonFileName");
////jsonWriter.FormatJSONFile();
////jsonWriter.Write();
////Console.WriteLine(jsonWriter.FileName);

/////////////////////////////////////////////////////////////////////////////////
/////*  MULTI DIMENTIONAL ARRAY *************************************/

////int[,] numbersMultiDim = new int[3, 2] { { 1, 5 }, { 3, 8 }, { 6, 1 } };
////int number = numbersMultiDim[2, 1]; // third row on index 2 and second column on index 1.. value = 1


//////two loops to iterate through a two-dimensional array.
//////First one is iterating through all the rows and the second
//////one through all the columns in the current row.

////for (int i = 0; i < numbersMultiDim.GetLength(0); i++)
////{
////    for (int j = 0; j < numbersMultiDim.GetLength(1); j++)
////    {
////        Console.WriteLine(numbersMultiDim[i, j]);
////    }
////}

/////////////////////////////////////////////////////////////////////////////////
/////* PARAMETER ARRAY ***************************************/

//////Create an application that prints out the minimum
//////of all the numbers sent to the PrintMin method:
////static void PrintMin(params int[] numbers)
////{
////    int min = numbers[0];
////    for (int i = 1; i < numbers.Length; i++)
////    {
////        //if (min < numbers[i])//whynot? because assigning happens right to left..
////        //vi minsker minimum egentlig og finner minimum
////          if (min > numbers[i])
////        {
////            min = numbers[i];
////        }
////    }
////    Console.WriteLine(min);
////}
////PrintMin(49, 58, 12, 98, 47, 13);
////Console.ReadKey();

/////////////////////////////////////////////////////////////////////////////////
/////* REF AND OUT WITH REFERENCE TYPES *****************************************/

/////*the reference type doesn’t store its value inside its own memory location. It stores the address towards the memory location where the value is stored. Therefore when we send an argument as a reference type to the method and change that parameter, the original value is changed.

////This is because we are not sending the copy of the value but the copy of the address that points to the original value. This is the same thing as when we use the ref keyword with the value types.

////Still, we can use the ref keyword with the reference types if we want to create a new object with the same address:*/

////static void ChangeColor(Pen pen)
////{
////    pen.ColorEnum = ColorEnum.Green;
////    Console.WriteLine($"Inside the ChangeColor method the color is {pen.ColorEnum}");
////}

//// static void CreateNewObjectWithoutRef(Pen pen)
////{
////    pen = new Pen(ColorEnum.Red);
////    Console.WriteLine($"Inside the CreateNewObjectWithoutRef method the color of new pen object is {pen.ColorEnum}");
////}

//// static void CreateNewObjectWithRef(ref Pen pen)
////{
////    pen = new Pen(ColorEnum.Yellow);
////    Console.WriteLine($"Inside the CreateNewObjectWithRef method the color of new pen object is {pen.ColorEnum}");
////}

////    Pen pen = new Pen(ColorEnum.Blue);

////    Console.WriteLine($"Before ChangeColor method: {pen.ColorEnum}");
////    ChangeColor(pen);
////    Console.WriteLine($"After the ChangeColor method: {pen.ColorEnum}");

////    Console.WriteLine();

////    Console.WriteLine($"Before CreateNewObjectWithoutRef method: {pen.ColorEnum}");
////    CreateNewObjectWithoutRef(pen);
////    Console.WriteLine($"After CreateNewObjectWithoutRef method: {pen.ColorEnum}");

////    Console.WriteLine();

////    Console.WriteLine($"Before CreateNewObjectWithRef method: {pen.ColorEnum}");
////    CreateNewObjectWithRef(ref pen);
////    Console.WriteLine($"After CreateNewObjectWithRef method: {pen.ColorEnum}");
//////In the third method, we are using the ref keyword, and the original value changes. Why?
//////Because with the ref keyword we are copying the same address to a new object.

////Console.ReadKey();

/////////////////////////////////////////////////////////////////////////////////
/////* REF AND OUT -- METHODS *************************************************/
//////https://code-maze.com/cshrap-ref-out-keywords/
////static void ChangeAndWrite(int number)
////{
////    number = 10;
////    Console.WriteLine($"Inside ChangeAndWrite method, number value is: {number}");
////}

////int number = 5;
////Console.WriteLine($"Value of the number prior to ChangeAndWrite call is: {number}");
////ChangeAndWrite(number);
////Console.WriteLine($"Value of the number after the ChangeAndWrite call is: {number}");
////Console.ReadKey();

////static void ChangeRef(ref int numberRef)
////{
////    numberRef = 25;
////    Console.WriteLine($"Inside the ChangeRef method the numberRef is {numberRef}");
////}
////static void ChangeOut(out int numberOut)
////{
////    numberOut = 60;
////    Console.WriteLine($"Inside the ChangeOut method the numberOut is {numberOut}");
////}

////int numberRef = 15;
////Console.WriteLine($"Before calling the ChangeRef method the numberRef is {numberRef}");
////ChangeRef(ref numberRef);
////Console.WriteLine($"After calling the ChangeRef method the numberRef is {numberRef}");
////Console.WriteLine();

////int numberOut;
////Console.WriteLine("Before calling the ChangeOut method the numberOut is unassigned");
////ChangeOut(out numberOut);
////Console.WriteLine($"After calling the ChangeOut method the numberOut is {numberOut}");
////Console.ReadKey();

/////////////////////////////////////////////////////////////////////////////////
/////* METHODS /optional parameters*****************************************/

////static void MethodWithOptParams(int first, int second = 10)
////{
////    Console.WriteLine(first + second);
////    Console.ReadLine();
////}
////MethodWithOptParams(1); //result is 11
////MethodWithOptParams(1,2); //result is 3

/////////////////////////////////////////////////////////////////////////////////
/////* EXCEPTION HANDLING ********************************************/

////try
////{
////    Console.WriteLine("input a number");
////    int input = Convert.ToInt16(Console.ReadLine());
////    Console.WriteLine(Math.Sqrt(2));
////    Console.ReadLine();
////}
////catch (DivideByZeroException ex) {
////    Console.WriteLine(ex.Message);
////    Console.ReadLine();
////}
////catch (InvalidOperationException ex)
////{
////    Console.WriteLine(ex.Message);
////    Console.ReadLine();
////}
////catch (FormatException ex)
////{
////    Console.WriteLine(ex.Message);
////    Console.ReadLine();
////}
////catch (Exception ex)
////{
////    Console.WriteLine($"youve got error message: {ex.Message}");
////    Console.ReadLine();
////}

/////////////////////////////////////////////////////////////////////////////////
/////*  STRINGS ********************************************/

////string testString = "this is some string to use it for our example.";

////Substring ********************************************/
////string partWithoutLength = testString.Substring(13);
////Console.WriteLine(partWithoutLength);

////string partWithLength = testString.Substring(5, 14);
////Console.WriteLine(partWithLength);

////IndexOf ********************************************/
////int charPosition = testString.IndexOf('i');
////Console.WriteLine(charPosition);

////int stringPosition = testString.IndexOf("some");
////Console.WriteLine(stringPosition);

////int charPosWithStartIndex = testString.IndexOf('s', 10);//start seacrch after index
////Console.WriteLine(charPosWithStartIndex);

////int stringPosWithStartIndex = testString.IndexOf("some", 10);//-1
////Console.WriteLine(stringPosWithStartIndex);

//////LastIndexOf ********************************************/
////int lastPosition = testString.LastIndexOf('o');//returns the position of the last appearance
////Console.WriteLine(lastPosition);

////int stringLastPosition = testString.LastIndexOf("is");
////Console.WriteLine(stringLastPosition);

//////Contains ********************************************/
////bool containsResult = testString.Contains("for");
////Console.WriteLine("contains 'for'" +containsResult);

//////StartsWith and EndsWith ********************************************/
////bool startsWithResult = testString.StartsWith("bad");
////Console.WriteLine(startsWithResult);

////bool endsWithResult = testString.EndsWith("example");
////Console.WriteLine(endsWithResult);

//////Remove ********************************************/
////string klippedString = testString.Remove(5);
////Console.WriteLine(klippedString);

////string klippedStringWithCount = testString.Remove(7, 26);//removes a speciNed number of
////                                                         //characters from the string from the
////                                                         //starting index position. With the count
////                                                         //parameter we decide how many characters
////                                                         //we want to delete.
////Console.WriteLine(klippedStringWithCount);

////string stringWithInsert = testString.Insert(13, "UPDATED ");
////Console.WriteLine(stringWithInsert);

////string lowerCaseString = testString.ToLower();
////Console.WriteLine(lowerCaseString);

////string upperCaseString = testString.ToUpper();
////Console.WriteLine(upperCaseString);

/////* index position ********************************************/

////Console.WriteLine(testString);

////int charPosition = testString.IndexOf('i');
////Console.WriteLine("i is at "+charPosition);

////int stringPosition = testString.IndexOf("some");
////Console.WriteLine("some is at "+stringPosition);

////int charPosWithStartIndex = testString.IndexOf('s', 10);
////Console.WriteLine("s after index 10 is at "+charPosWithStartIndex);

////int stringPosWithStartIndex = testString.IndexOf("some", 10);
////Console.WriteLine("some after index 10 is at "+stringPosWithStartIndex);

////int lastPosition = testString.LastIndexOf('o');
////Console.WriteLine("last appearance of o is at "+lastPosition);

////int stringLastPosition = testString.LastIndexOf("is");
////Console.WriteLine("last appearance of is is at "+stringLastPosition);

/////////////////////////////////////////////////////////////////////////////////
/////* SUBSTRINGS ********************************************/
/////accepts the name and last name, space-separated, as input, and then prints out the name in one row and last name in another row:

////Console.WriteLine("Enter your full name, blank space separated");
////string fullName = Console.ReadLine();

////int blankPosition = fullName.IndexOf(' ');
////string name = fullName.Substring(0, blankPosition);
////Console.WriteLine("name: "+name);

////string lastName = fullName.Substring(blankPosition + 1);//returns part of the string with a
////                                                        //defined length from the startIndex.
////Console.WriteLine("lastname: "+lastName);

////Console.ReadKey();

/////SUBSTRINGS 2 ********************************************/
/////accepts as input a sentence and removes the first and last word of that sentence:

////Console.WriteLine("Enter your sentence: ");
////string sentence = Console.ReadLine();
////int firstBlankPosition = sentence.IndexOf(' ');

////string withoutFirstWord = sentence.Remove(0, firstBlankPosition + 1);
////int lastBlankPosition = withoutFirstWord.LastIndexOf(' ');
////string withoutFirstAndLast = withoutFirstWord.Remove(lastBlankPosition);
////Console.WriteLine(withoutFirstAndLast);
////Console.ReadKey();

/////*  OPERATORS  ********************************************/

////int a = 15;
////int b = 15;

////string s1 = "This is a string";
////string s2 = "This is a string";

////Console.WriteLine(a == b); // true 'cause two are identical
////Console.WriteLine(s1 == s2); // true'cause two are identical

////var student1 = new Student("John", 25);
////var student2 = new Student("John", 25);

////Console.WriteLine(student1 == student2); // false 'cause reference types not sharing same memory location

////var student3 = student1;
////Console.WriteLine(student1 == student3); // true 'cause reference types sharing same memory location

/////////////////////////////////////////////////////////////////////////////////
/////* LOGICAL OPERATORS ********************************************/

////int a = 14;
////int b = 30;
////int c = 20;

////if (a < b && a < c)
////{
////    Console.WriteLine($"a = smaller than b AND c");
////}
////if (a < b || a < c)
////{
////    Console.WriteLine("a = smaller than b OR c");
////}
////if (!(a > b))
////{
////    Console.WriteLine("a is NOT bigger than b");
////}

/////////////////////////////////////////////////////////////////////////////////
/////* INCREMENT -- DECREMENT -- PREFIX -- SUFFIX ********************************************/

////int a = 15;
////int b = --a;

////Console.WriteLine(a); // 14 'cause prefix decremented a and later assigned to b
////Console.WriteLine(b); // 14 'cause prefix decremented a and later assigned to b

////int c = 20;
////int d = c--;

////Console.WriteLine(c); // 19 'cause suffix assingned c to d first and later decremented c
////Console.WriteLine(d); // 20 'cause suffix assingned c to d first and later decremented c

////int a = 15;
////int b = ++a;

////Console.WriteLine(a); // 16 'cause prefix decremented a and later assigned to b
////Console.WriteLine(b); // 16

////int c = 20;
////int d = c++;

////Console.WriteLine(c); // 21 'cause suffix assingned c to d first and later decremented c
////Console.WriteLine(d); // 20

/////////////////////////////////////////////////////////////////////////////////
/////*  IMPLICIT CONVERSION ********************************************/

////double b = 12.45;
////int x = 10;
////b = b + x; //implicit conversion when we calculate an expression.

////Console.WriteLine(b);//22.45

////int yy = 21;
////int xx = 10;
////double bb;
////bb = yy / xx;//conversion is when the compiler stores the result to a variable

////Console.WriteLine(bb);//2

/////////////////////////////////////////////////////////////////////////////////
/////* EXPLLICIT CONVERSION ********************************************/

////int x = 21;
////int y = 5;
////double b = (double) x / y;// explicitly converted to double and
////                          // then divided.. conversion has high priority

////Console.WriteLine(b);

////int a;
////double bx = 10.7;
////a = (int)bx;

////Console.WriteLine(a);

/////* EXLPLICIT CONVERSION WITH CONVERTION CLASS ********************************************/

//////int a = 15;
//////string s = a; // this is not allowed

////int c = 15;
////string s1 = Convert.ToString(c);
//////or
////string s2 = c.ToString();

////Console.WriteLine("a string "+s1);
////Console.WriteLine("a string "+s2);

/////////////////////////////////////////////////////////////////////////////////
////* LINEAR STRUCTURES INTEGER PRINTING ********************************************/

////Console.WriteLine("Write the first integer:");
////int first = Convert.ToInt32(Console.ReadLine());

////Console.WriteLine("Write the second integer:");
////int second = Convert.ToInt32(Console.ReadLine());

////int result = first + second;
////Console.WriteLine($"The result is {result}");

////Console.ReadKey();

///////* LINEAR STRUCTURES STRING PRINTING ********************************************/

////Console.WriteLine("What is your first name:");
////string name = Console.ReadLine();

////Console.WriteLine("What is your last name:");
////string lastName = Console.ReadLine();

////string fullName = name + " " + lastName;
////Console.WriteLine($"Your full name is: {fullName}");

///* WHILE ********************************************/

////Console.WriteLine("Enter the integer n number:");
////int n = Convert.ToInt32(Console.ReadLine());
////Console.WriteLine("Enter the integer m number");
////int m = Convert.ToInt32(Console.ReadLine());
////int sum = 0;
////while (n <= m)
////{
////    sum += n;
////    n++;
////}
////Console.WriteLine($"Sum from n to m is {sum}");
////Console.ReadKey();

/////* FOR LOOP ********************************************/

////Console.WriteLine("Enter the integer n number:");
////int n = Convert.ToInt32(Console.ReadLine());
////Console.WriteLine("Enter the integer m number");
////int m = Convert.ToInt32(Console.ReadLine());
////int sum = 0;

////for (int i = n; i <= m; i++)
////{
////    sum += i;
////}
////Console.WriteLine($"Sum from n to m is {sum}");
////Console.ReadKey();

///////2
/////
////Console.WriteLine("Enter number n that is greater than 1: ");
////int n = Convert.ToInt32(Console.ReadLine());
////for (int i = n; i >= 1; i--)
////{
////    Console.WriteLine(i);
////}
////Console.ReadKey();

///////************ codemaze basics
//////keywords as variables
////int @int = 9;
////string @return = "this is a return";
//////bool bool = false;//invalid

////contextual keywords
////the ones that we can use for the variable names but without using the @ sign in front:


////All relational operators return either a true or false result.
//// These operators have lower priority than arithmetic ones

////the prefix notation decrements a 
////and then assigns to b .

////int a = 15;
////int b = --a;
////int c = 15;
////int d = c--;
////Console.WriteLine(a); // 14
////Console.WriteLine(b); // 14

//////the suffix notation assigns c to d
//////and then decremented by 1.
////Console.WriteLine(c); // 14
////Console.WriteLine(d); // 15

//////implicit conversion
////int x = 21;
////int y = 5;
////double doubleResult = x / y;
//////The result is 4.2” is not correct.
////the right side expression x/yconsist of integer numbers,
////thus the result is an integer number. and then converts to double

////explicit convcersion
////two different ways; by using a cast operator or
////by using the Convert class.

////double 10.7 becomes int 10 --> It is very important to understand that the cast operator can shrink
////data when we convert the type with the larger value scope to
////a type with the smaller value scope.

//////explicit Convert class usage
////int penger = 15;
////string s1 = Convert.ToString(penger);
//////or
////string s2 = penger.ToString();


////While loop is a loop with a precondition. 
////For loop is another loop with a precondition. 
////The do-while loop is a loop with postcondition.

////exception: unhandled exceptions.

//////2d arrays-a two-dimensional array with three rows and two columns. 
////int[,] numbersMultiDim = new int[3, 2] { { 1, 5 }, { 3, 8 }, { 6, 1 } };
////int number = numbersMultiDim[2, 1]; // value 1    => third row on index 2 and second column on index 1
////for (int i = 0; i < numbersMultiDim.GetLength(0); i++)
////{
////    for (int j = 0; j < numbersMultiDim.GetLength(1); j++)
////    {
////        Console.WriteLine(numbersMultiDim[i, j]);
////    }
////}

