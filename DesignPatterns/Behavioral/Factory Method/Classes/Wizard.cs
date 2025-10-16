using DesignPatterns.Behavioral.Factory_Method.Interface;

namespace DesignPatterns.Behavioral.Factory_Method.Classes;

public class Wizard : ICharacter
{
    public string Name { get; }
    public int Health { get; }
    public int Mana { get; }
    public int Intelligence { get; }
    public string Spell { get; }
    
    public Wizard(string name)
    {
        Name = name;
    }
    
    public void Attack()
    {
        Console.WriteLine($"{Name} casts {Spell}, dealing {Intelligence * 2} magic damage!");
    }
    
    public void Defend()
    {
        Console.WriteLine($"{Name} conjures a magical barrier, reducing damage by {Mana / 2}!");
    }
    
    public void ShowStats()
    {
        Console.WriteLine($"Character: {Name}");
        Console.WriteLine($"Class: Wizard");
        Console.WriteLine($"Health: {Health}");
        Console.WriteLine($"Mana: {Mana}");
        Console.WriteLine($"Intelligence: {Intelligence}");
        Console.WriteLine($"Spell: {Spell}");
    }
}