namespace DesignPatterns.Behavioral.Factory_Method;

public static class FactoryDemo
{
    public static void Run()
    {
        // Here we test or demonstrate the pattern itself.
        CharacterCreator creator;

        creator = new KnightCreator();
        creator.TrainCharacter("Arthur");

        creator = new WizardCreator();
        creator.TrainCharacter("Merlin");

        creator = new ArcherCreator();
        creator.TrainCharacter("Robin");
    }
}