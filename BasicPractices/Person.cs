using System.Threading.Channels;

namespace BasicPractices;
public class Person
{
    public String firstName;
    public String lastName;


    public static void IntroducePersonMethod()
    {
        Console.WriteLine("***** Person.IntroducePersonMethod *****\n");
        var aMan = new Person();
        aMan.firstName = "aMan called Jonatan";
        aMan.lastName = "med etternavnet Smith";
            
        Console.WriteLine(aMan.firstName + " is a member of The Family " + aMan.lastName);
    }
    
}