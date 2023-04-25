using System.Runtime.CompilerServices;

//CLASS EXERCISES
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
         Console.WriteLine("FinalScore: "+Score.FinalScore);
     }
     
     //static method for factory needs
     public static Score MakeAScore() => new Score("a",0,0,"off-color");

     public static void Maintain()
    {
        //this.constructor.
        //name by constuctor
        Score eva = new Score("eva", 23, 12,"green");
        Console.WriteLine("name by constructor/object: "+eva._name);
        var nyScore = new Score();
        Console.WriteLine("name by constructor/object: "+nyScore._name);

        // //set-get by property (not method)
        // nyScore.SetName = "theodore";
        // Console.WriteLine("nyScore.GetName: " + nyScore.GetName);
        
        //(3)
        //property according to auto implementation
        nyScore.Naming = "auto setted name";
        Console.WriteLine("nyscore.naming: "+nyScore.Naming);
        //could set a name !

        //(4)
        // Score initScore = new Score("initNamePropertyWhileObjectInitiated", 23, 1, "colorful");
        // Console.WriteLine("******* "+initScore.Naming);
        // //couldnt set a name ! but it should while object initialization !
        
        
        //new alone constructor (if compiler can infer the class)
        //like var !!!
        Score scoreObject = new();
        
        Console.WriteLine("name by new alone constructor: " + scoreObject._name);
        
        Score scorObject2 = new("eli", 2, 3,"readOnlyColor");
        Console.WriteLine("name by constructor/object creation: "+scorObject2._name);

        // scorObject2._color = "yellow";//read only error

        Console.WriteLine(Score.FinalScore);
        
        Score.Report(scorObject2);

        Score factorizedScore = Score.MakeAScore();
        Score.Report(factorizedScore);
    }
}