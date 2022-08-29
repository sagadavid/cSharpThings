namespace Basics;

public class NonGenericButaMethod
{
    public static List<T> Repeat<T>(T value, int times)
    {
        List<T> collection = new List<T>();

        for (int index = 0; index < times; index++)
        { collection.Add(value);
          Console.WriteLine(collection.GetItemAt(0)); }

        return collection;
    }
}

//multiple generic types in use
public class Generik<TValue, TExplain>
{
    public TValue Value { get; set; }
    public TExplain Explain { get; set; }

    public Generik(TValue value, TExplain explain)
    {
        Value = value;
        Explain = explain;
    }
}

//manually build a generic type List
//inheritance in generics

// public class List<T>:Generik<T,T>
public class List<T>
{
    private T[] _items = new T[0];
    public T GetItemAt(int index) => _items[index];
    public void SetItemAt(int index, T value) => _items[index] = value;

    public void Add(T newValue)
    {
        T[] updated = new T[_items.Length + 1];
        for (int index = 0; index < _items.Length; index++)
            updated[index] = _items[index];

        updated[^1] = newValue;
        _items = updated;
    }
//because base Generic class (Generik<T,T>) has two parameter,
//the derived Generic class (List T) gets an accordingly constructor !!!

    // public List(T value, T explain) : base(value, explain) { }
}

public class GenerikMain
{
    public static void Main()
    {
        //using generik with multiple types
        Generik<string, int> generikMultiple = new Generik<string, int>("erik", 197);
        Console.WriteLine($"{generikMultiple.Value} is {generikMultiple.Explain} cm high.");

        var generikFlerTypig = new Generik<string, bool>("am i late?", false);
        Console.WriteLine(generikFlerTypig.Value + " hmm i guess " + generikFlerTypig.Explain);

        // //using  generik List<T> (((before inheritance)))
        var experimental = new List<string>();
        experimental.Add("what");

        var experimental2 = new List<int>();
        experimental2.Add(23);
        Console.WriteLine(experimental2.GetItemAt(0));

        //using generik List (((after inheritance)))
        //cant instantiate with two different type ???
        // var experimental3 = new List<int>(23, 78);
        // Console.WriteLine(experimental3.Explain+" -and- "+experimental3.Value);
        //

        //generic method in a regular class
        NonGenericButaMethod.Repeat("nonGenericClass but aMethod", 7);
    }
}