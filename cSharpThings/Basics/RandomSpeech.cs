namespace Basics;

public class RandomSpeech
{
    public static void Maintain()
    {
        Console.WriteLine("** RANDOMIZE-CLASS-METHOD ****\n");
        //RANDOM PHRASE-MATIC FROM JAVA
        String[] subjects = { "i", "you", "he", "she", "we", "they" };
        String[] verbs = { "like", "dislike", "go", "drink", "read", "run", "quit" };
        String[] objects = { "tree", "school", "book", "table", "garden", "house", "room" };
        Random rand = new Random();

int subjLength = subjects.Length;
int verLength = verbs.Length;
int objLength = objects.Length;

        var subRand = rand.Next(subjLength);
        var verbRand = rand.Next(verLength);
        var objRand = rand.Next(objLength);

        Console.WriteLine("A RANDOM PHRASE: \n" 
                          + subRand + " " + verbRand + " " + objRand); 
        
        Console.WriteLine("A RANDOM PHRASE: \n" 
                          + subjects[subRand] + " " + verbs[verbRand] + " " + objects[objRand]);

    }
}