namespace Basics;

public class Person
{
    string firstName;
    string lastName;

    public string FirstName
    {
        get => firstName;
        set => firstName = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string LastName
    {
        get => lastName;
        set => lastName = value ?? throw new ArgumentNullException(nameof(value));
    }
    public static void Maintain()
    {
        var aPerson = new Person();
        aPerson.firstName = "Jonatan";
        aPerson.lastName = "Smith";

        Console.WriteLine(aPerson.firstName +
                          "\n is a member of The Family \n"
                          + aPerson.lastName);
    }
}