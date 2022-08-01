using System.Threading.Channels;

namespace Basics;
public class Person
{
     string firstName;
   string lastName;

    public static void PersonProperty()
    {
        Console.WriteLine("***** PersonProperty *****\n");
        var aPerson = new Person();
        aPerson.firstName = "aMan called Jonatan";
        aPerson.lastName = "med etternavnet Smith";
            
        Console.WriteLine(aPerson.firstName + " is a member of The Family " + aPerson.lastName);
    }
    
}