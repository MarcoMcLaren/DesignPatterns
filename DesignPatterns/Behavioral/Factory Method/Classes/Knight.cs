using DesignPatterns.Behavioral.Factory_Method.Interface;

namespace DesignPatterns.Behavioral.Factory_Method.Classes;

public class Knight : ICharacter
{
    
    public string Name { get; }
    public int Health { get; }
    public int Strength { get; }
    public int Defense { get; }
    public string Weapon { get; }
    
    public Knight(string name)
    {
        Name = name;
    }
    public void Attack()
    {
        Console.WriteLine($"{Name} attacks with {Weapon}, dealing {Strength} damage!");
    }
    
    public void Defend()
    {
        Console.WriteLine($"{Name} raises shield, reducing damage by {Defense}!");
    }
    
    public void ShowStats()
    {
        Console.WriteLine($"Character: {Name}");
        Console.WriteLine($"Class: Knight");
        Console.WriteLine($"Health: {Health}");
        Console.WriteLine($"Strength: {Strength}");
        Console.WriteLine($"Defense: {Defense}");
        Console.WriteLine($"Weapon: {Weapon}");
    }
}