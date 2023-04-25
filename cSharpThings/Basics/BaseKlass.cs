using System.Globalization;

namespace Basics;

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
    public DerivedKlass():base()
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

public class Main
{
    public static void Mainer()
    {
        // inheritance for constructors

        // DerivedKlass derivedKlass = new BaseKlass();//error
        DerivedKlass derivedKlass = new DerivedKlass();
        Console.WriteLine("derivedKlass_name from baseKlass-> " + derivedKlass.Name);
        Console.WriteLine("derivedKlass_number from derivedKlass-> "+derivedKlass.Number);

        BaseKlass baseKlass = new();

        //ref1
        Console.WriteLine(derivedKlass.InteNum()+" og "+baseKlass.InteNum());//7 og 0
        
        //ref2
        Console.WriteLine(derivedKlass.InteNum2()+" og "+baseKlass.InteNum2());//88 og 11
        
    }
}