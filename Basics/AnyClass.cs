using System.Threading.Channels;

namespace Basics;
public class Person
{
    public String firstName;
    public String lastName;


    public static void PersonProperty()
    {
        Console.WriteLine("***** PersonProperty *****\n");
        var aMan = new Person();
        aMan.firstName = "aMan called Jonatan";
        aMan.lastName = "med etternavnet Smith";
            
        Console.WriteLine(aMan.firstName + " is a member of The Family " + aMan.lastName);
    }
    
}