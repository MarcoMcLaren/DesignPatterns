using DesignPatterns.Behavioral.Factory_Method.Classes;
using DesignPatterns.Behavioral.Factory_Method.Interface;

namespace DesignPatterns.Behavioral.Factory_Method;

public class KnightCreator : CharacterCreator
{
    public override ICharacter CreateCharacter(string name)
    {
        return new Knight(name);
    }
}