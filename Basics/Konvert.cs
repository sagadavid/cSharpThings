namespace Basics;

public class Conversion
{
    public static void ConversionMethod ()
    {
        Console.WriteLine("**  CONVERSION-CLASS-METHOD **** \n");
        //CONVERSION, COMPILABLE, COMPATIBLE TYPES
byte tall = 1;
int antall = tall;
Console.WriteLine(antall);//1
//byte is 4 bites, int is 8 bites.
//convertable,compilable. no data loss. //vice-versa will not compile.
//byte vantall= antall;//cant compile !! //Error CS0266: Cannot implicitly convert type 'int' to 'byte'.
//An explicit conversion exists (are you missing a cast?) (CS0266) (Salute)


//EXPLICIT CONVERT, CASTING
int flertall = 3456;
byte vantall = (byte)flertall;//this means i dont care data loss.
                              //just convert as it is.
Console.WriteLine(flertall.GetType().FullName);//System.Int32
Console.WriteLine(flertall);//3456
Console.WriteLine(vantall.GetType().FullName);//System.Byte
Console.WriteLine(vantall);//128

//CONVERT NON-COMPATIBLE TYPE, CONVERT. OR .PARSE
string s = "3";
string r = "34";
//int w = (int)s;//cannot convert string to type
int w = Convert.ToInt32(s);//int
int q = int.Parse(r);
//int w = Convert.ToByte(s);//byte
//int w = Convert.ToInt16(s);//short
//int w = Convert.ToInt64(s);//long
Console.WriteLine(w);//3
Console.WriteLine(r);//34

//LOST BITS
int n = 1000;
byte b = (byte)n;
Console.WriteLine(b);//232
//for byte takes 232 at max.couldnt take 1000 despite casting/forcing/explicitely converting

//CRASH PGA OVERFLOW
//use convert class when explicit casting is not possible
var stNum = "1234";
var conNum = Convert.ToInt32(stNum);
Console.WriteLine(conNum);//1234

var bye = (byte)conNum;
Console.WriteLine(bye);//210

// var by = Convert.ToByte(conNum);
// Console.WriteLine(by);
// Unhandled exception. System.OverflowException: Value was either too large or too small for an unsigned byte.
//     at System.Convert.ThrowByteOverflowException()
// at System.Convert.ToByte(Int32 value)
// at Program.<Main>$(String[] args) in /Users/bethsaga/RiderProjects/Basics/Basics/Program.cs:line 91

//TO AVOID OVERFLOWING USE CHECKED
// checked {
// 	byte number = 255;
// 	number = (byte)(number + 1);
//     Console.WriteLine(number);//Unhandled exception. System.OverflowException: Arithmetic operation resulted in an overflow.
// }

//HINDER CRASH BY TRY BLOCK

try
{
    var mm = "1234";
    byte bb = Convert.ToByte(mm);
    Console.WriteLine("convert/compile succeeded " + bb);
}
catch (Exception ex)
{
    Console.WriteLine("myException message: could not convert to byte");//myException message: could not convert to byte
}

//convert to boolean

try
{
    var vool = "true";
    bool buul = Convert.ToBoolean(vool);
    Console.WriteLine("convert/compile succeeded " + buul);//convert/compile succeeded True
}
catch (Exception ex)
{
    Console.WriteLine("myException message: couldnt be converted to byte");
}

    }
}