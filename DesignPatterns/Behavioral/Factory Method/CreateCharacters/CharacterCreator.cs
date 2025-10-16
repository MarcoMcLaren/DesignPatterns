using DesignPatterns.Behavioral.Factory_Method.Interface;

namespace DesignPatterns.Behavioral.Factory_Method;


/*The Factory (CharacterCreator) — “How characters are created”

This is the part that confused you a bit — and it’s fair, because it’s subtle.

The use case here is not “gameplay” — it’s object creation.

The Factory Method pattern exists for how we instantiate these objects, not for how they act.

In plain terms:

“When the game needs a new character, we don’t want to say new Knight() everywhere.”

Why? Because:

    That ties the code to a specific class.

It makes adding a new class (say, Assassin) painful.

It violates the Open/Closed Principle — your code should be open to extension, but closed to modification. */
    
public abstract class CharacterCreator
{
    //Method 1
    public abstract ICharacter CreateCharacter(string name);

    //Method 2
    public void TrainCharacter(string name)
    {
        var character = CreateCharacter(name);
        Console.WriteLine($"\nTraining new character: {name}");
        character.ShowStats();
        character.Attack();
        character.Defend();
        Console.WriteLine($"{name} is ready for adventure!\n");
    }
}