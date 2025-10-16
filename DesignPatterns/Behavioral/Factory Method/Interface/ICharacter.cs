namespace DesignPatterns.Behavioral.Factory_Method.Interface;

public interface ICharacter
{
    void Attack();
    //Those 3 implementations of the same method, but different logic each... THAT'S polymorphism..... : Same interface, different in implementation
    void Defend();
    void ShowStats();
    
    //So each character will be able to attack and defend but the way a wizard attacks and defends is different from an archer
}