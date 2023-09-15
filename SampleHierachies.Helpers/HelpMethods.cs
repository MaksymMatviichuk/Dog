namespace SampleHierachies.Helpers
{
    public class HelpMethods
    {
        public static int animalIdCounter = 0;
        public static int GetNextAnimalId()
        {
            return animalIdCounter++;
        }
    }
}