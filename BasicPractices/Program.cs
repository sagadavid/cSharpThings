// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

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

Console.WriteLine("karakter: " + karakter);
Console.WriteLine("kelime " + kelime);

//TO AVOID OVERFLOWING USE CHECKED

//checked {
//	byte number = 255;
//	number = (byte)number + 1);
//	Console.WriteLine(number);
//}


//A FORMAT STRING USAGE
Console.WriteLine("{0}{1}", byte.MaxValue, byte.MinValue);
Console.WriteLine("{0}{1}", float.MinValue, float.MaxValue);

//CONSTANTS
const float Pi = 3.14f;
Console.WriteLine(Pi);

//CONVERSION, COMPILABLE, COMPATIPLE TYPES
byte tall = 1;
int antall = tall;//byte is 4 bites, int is 8 bites.
                  //convertable,compilable. no data loss.
                  //viceversa will not compile.
                  //byte vantall= antall;//cant compile !!
                  //Error CS0266: Cannot implicitly convert type 'int' to 'byte'.
                  //An explicit conversion exists (are you missing a cast?) (CS0266) (Salute)

//EXPLICIT CONVERT, CASTING

byte vantall = (byte)antall;//this means i dont care data loss.
                            //just convert as it is.
Console.WriteLine(antall.GetType().FullName);
Console.WriteLine(vantall.GetType().FullName);

//CONVERT NONCOMPATIBLE TYPE, CONVERT. OR .PARSE
string s = "3";
string r = "34";
//int w = (int)s;//cannot convert string to type
int w = Convert.ToInt32(s);//int
                           //int w = Convert.ToByte(s);//byte
                           //int w = Convert.ToInt16(s);//short
                           //int w = Convert.ToInt64(s);//long
int q = int.Parse(r);
Console.WriteLine(w);
Console.WriteLine(r);

//LOST BITS
int n = 1000;
byte b = (byte)n;
Console.WriteLine(b);//for byte takes 232 at max.
                     //couldnt take 1000 despite casting/forcing/explicitely converting

//CRASH PGA OVERFLOW
//use convert class when explicit casting is not possible

//var m = "1234";
//byte by = Convert.ToByte(m);//you receive overflowexeption warning and app crash
//Console.WriteLine(by);

//HINDER CRASH BY TRY BLOCK

try
{
    var mm = "1234";
    byte bb = Convert.ToByte(mm);
    Console.WriteLine("convert/compile succeeded " + bb);
}
catch (Exception ex)
{
    Console.WriteLine("myException message: couldnt be converted to byte");
}

//convert to boolean

try
{
    var vool = "true";
    bool buul = Convert.ToBoolean(vool);
    Console.WriteLine("convert/compile succeeded " + buul);
}
catch (Exception ex)
{
    Console.WriteLine("myException message: couldnt be converted to byte");
}

//POSTFIX, PREFIX

int a = 1;
int c = a++;
Console.WriteLine("a assigned to c, and later incremented. not assigned again");
Console.WriteLine(a + "a,c" + c);
Console.WriteLine("a incremented, and then assigned to d");
int d = ++a;
Console.WriteLine("d" + d);

//RANDOM PHRASER MATIC

String[] subjects = { "i", "you", "he", "she", "we", "they" };
String[] verbs = { "like", "dislike", "go", "drink", "read", "run", "quit" };
String[] objects = { "tree", "school", "book", "table", "garden", "house", "room" };
Random random = new Random();

//int gib1len = subjects.length;
//int gib2len = verbs.length;
//int gib3len = objects.length;

int subRand = random.Next(subjects.Length);
int verbRand = random.Next(verbs.Length);
int objRand = random.Next(objects.Length);

Console.WriteLine(subjects[subRand] + " " + verbs[verbRand] + " " + objects[objRand]);