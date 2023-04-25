using System;
namespace Basics
{

    public class Student
    {
        string _name;
        int _age;

        public Student(string name, int age)
        {
            _name = name;
            _age = age;
        }
    }

    public struct aStruct
    {
        public int fieldA;
        public int fieldB;
    }

    public class aClass
    {
        public int fieldA;
        public int fieldB;
    }

    public class ConstructorDisplayer
    {
        public aStruct _one;
        public aStruct _two;
        public aClass _three;
        public aClass _four;

        public void DisplayStructConstructors()
        {
            Console.WriteLine($"{_one.fieldA} {_one.fieldB} and {_two.fieldA} {_two.fieldB}");
        }

        public void DisplayClassConstructors()
        {
            Console.WriteLine($"{_three.fieldA} {_three.fieldB} and {_four.fieldA} {_four.fieldB}");
        }
    }

    public struct SirkelStruct
    {
        public double X { get; }
        public double Y { get; }
        // public double Radius { get; }
        public double Radius { get; set; }

        public SirkelStruct(double x, double y, double radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }
    }

    public class SirkelClass
    {
        public double X { get; }
        public double Y { get; }
        // public double Radius { get; }
        public double Radius { get; set; }

        public SirkelClass(double x, double y, double radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }
    }
    public class Stringer
    {
        private static string Him;

        private static void getHim()
        {
            // The Null Coalescing Operator: ??

            string? Him = "real Him";

            // Him ??= "not real Him";

            Console.WriteLine(Him ?? "not found");
        }

    }

    public class Score
    {
        public string _name;
        public int _points;
        public int _level;
        public static readonly int FinalScore = 100;

        //immutable field
        public readonly string _color;

        public Score(string name, int points, int level, string color)
        {
            _name = name;
            _points = points;
            _level = level;
            _color = color;
        }

        // calling other constructor by using this ! ????
        public Score() : this("eba", 99, 11, "white")
        {
        }

        //(1)
        //     //set-get by property
        //     public string GetName
        //     {
        //         get => _name;
        //     }
        //

        //(2)
        // //property like set
        //     public string SetName
        //     {
        //         set => _name = value;
        //     }

        //(3)
        //auto implemented property
        public string Naming
        {
            get;
            set;
        }

        //(4)
        // init of property
        // public string Naming
        // {
        //     get;
        //     init;
        // } = "initName";


        //static methods  for some service needs
        public static void Report(Score scoreObject)
        {
            Console.WriteLine("Score static method --> Reports: ");
            Console.WriteLine(scoreObject._color);
            Console.WriteLine(scoreObject._level);
            Console.WriteLine(scoreObject._name);
            Console.WriteLine(scoreObject._points);
            Console.WriteLine("FinalScore: " + Score.FinalScore);
        }

        //static method for factory needs
        public static Score MakeAScore() => new Score("a", 0, 0, "off-color");


    }


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

    }

    public class Pen
    {
        public ColorEnum ColorEnum { get; set; }

        public Pen(ColorEnum colorEnum)
        {
            this.ColorEnum = colorEnum;
        }
    }

    public enum ColorEnum
    {
        Red,
        Green,
        Blue,
        Yellow
    }

    public sealed class DerivedKlass : BaseKlass
    {
        public int Number;

        //ref1:
        //a method with same name in derived class,
        //not overriden ! will be created by new in Main


        // public int InteNum() => 7;
        public new int InteNum() => 7;

        //ref2
        public override int InteNum2()
        {
            return 88;
        }


        // A)
        public DerivedKlass() : base()
        { }

        // B)
        // public DerivedKlass()
        // {
        //     this.Name = Name;
        // }

        // C)
        //addressing the baseclass constructor(as a parametered constructor)
        // public DerivedKlass():base("string here", 0){}
    }

    public class BaseKlass
    {
        public string Name = "base Name accessed";


        //if baseclass has a parametered constructor, derived class must explicitly address it

        // public BaseKlass(string className, int classPopulation)
        // {
        //     Name = className;
        //     classPopulation = 0;
        // }

        public int InteNum() => 0;
        public virtual int InteNum2() => 11;
    }

    public class AllClasses
	{
		public AllClasses()
		{
		}
	}

    public class NonGenericButaMethod
    {
        public static List<T> Repeat<T>(T value, int times)
        {
            List<T> collection = new List<T>();

            for (int index = 0; index < times; index++)
            {
                collection.Add(value);
                Console.WriteLine(collection.GetItemAt(0));
            }

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


    public class Writer
    {
        public string FileName { get; set; }
        public Writer(string fileName)
        {
            FileName = fileName;
        }
        public void Write()
        {
            Console.WriteLine("Writing to a file");
            Console.ReadLine();
        }
    }

    public class XMLWriter : Writer
    {
        public XMLWriter(string fileName)
            : base(fileName)
        {
        }
        public void FormatXMLFile()
        {
            Console.WriteLine("Formating XML file");
            Console.ReadLine();
        }
    }

    public class JSONWriter : Writer
    {
        public JSONWriter(string fileName)
            : base(fileName)
        {
        }
        public void FormatJSONFile()
        {
            Console.WriteLine("Formating JSON file");
            Console.ReadLine();

        }
    }


}

