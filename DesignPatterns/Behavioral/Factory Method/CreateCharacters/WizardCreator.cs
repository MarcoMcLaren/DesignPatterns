using DesignPatterns.Behavioral.Factory_Method.Classes;
using DesignPatterns.Behavioral.Factory_Method.Interface;

namespace DesignPatterns.Behavioral.Factory_Method;

public class WizardCreator : CharacterCreator
{
    public override ICharacter CreateCharacter(string name)
    {
        return new Wizard(name);
    }
}
