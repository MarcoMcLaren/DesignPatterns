using DesignPatterns.Behavioral.Factory_Method.Interface;

namespace DesignPatterns.Behavioral.Factory_Method.Classes;

public class Archer : ICharacter
{
    public string Name { get; }
    public int Health { get; }
    public int Agility { get; }
    public int Range { get; }
    public string Bow { get; }
    
    public Archer(string name)
    {
        Name = name;
    }
    
    public void Attack()
    {
        Console.WriteLine($"{Name} shoots an arrow with {Bow}, dealing {Agility * 1.5} damage!");
    }
    
    public void Defend()
    {
        Console.WriteLine($"{Name} dodges the attack, reducing damage by {Range / 2}!");
    }
    
    public void ShowStats()
    {
        Console.WriteLine($"Character: {Name}");
        Console.WriteLine($"Class: Archer");
        Console.WriteLine($"Health: {Health}");
        Console.WriteLine($"Agility: {Agility}");
        Console.WriteLine($"Range: {Range}");
        Console.WriteLine($"Bow: {Bow}");
    }
}