using SampleHierarchies.Data.Entities;
using SampleHierarchies.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleHierachies.Helpers
{
    public class AnimalInitializer
    {
        public static void Initialize(AnimalService animalService)
        {
            animalService.AddAnimal(new Dog(HelpMethods.GetNextAnimalId(), 5, "Dog", "A loyal companion", "Friendly and playful", 0.6f, 15, 4, true, "Golden Retriever", true));
            animalService.AddAnimal(new BottlenoseDolphin(HelpMethods.GetNextAnimalId(), 10, "Dolphin", "A highly intelligent marine mammal", "Social and communicative", 2, 300, 0, false, true, "Pods", true, 4, true));
            animalService.AddAnimal(new Elephant(HelpMethods.GetNextAnimalId(), 20, "African Elephant", "The largest land mammal", "Lives in herds and exhibits complex social behaviors", 3, 6000, 4, 2.5f, "Herds", false));
            animalService.AddAnimal(new Elephant(HelpMethods.GetNextAnimalId(), 15, "Indian Elephant", "A smaller elephant species with distinctive ears", "Known for its close relationship with humans", 2.7f, 5000, 4, 1.8f, "Family groups", false));
            animalService.AddAnimal(new Lion(HelpMethods.GetNextAnimalId(), 6, "African Lion", "The king of the savanna", "Lives in prides and hunts cooperatively", 4.2f, 250, 4, true, true, true, "Mane with dark fur", true, true));
            animalService.AddAnimal(new Lion(HelpMethods.GetNextAnimalId(), 7, "Asian Lion", "A smaller lion species with a distinctive mane", "Found in the Gir Forest of India", 3.5f, 200, 4, true, true, true, "Mane with light fur", true, true));
            animalService.AddAnimal(new PolarBear(HelpMethods.GetNextAnimalId(), 12, "Polar Bear", "A mighty bear adapted to cold climates", "Excellent swimmers and hunters on sea ice", 1.8f, 800, 4, true, "Thick fur coat", "Large paws for swimming", "Carnivorous diet", true, "Keen sense of smell"));
            animalService.AddAnimal(new GrizzlyBear(HelpMethods.GetNextAnimalId(), 10, "Grizzly Bear", "A powerful bear found in North America", "Hunts salmon and forages for plants", 1.5f, 600, 4, true, true, "", 2, true, ""));
            animalService.AddAnimal(new Chimpanzee(HelpMethods.GetNextAnimalId(), 0, "Chimpanzee", "", "", 0, 0, 2, true, true, "", true, 99, ""));
            animalService.AddAnimal(new BengalTiger(HelpMethods.GetNextAnimalId(), 0, "Bengal Tiger", "", "", 0, 0, 0, false, true, 20, "", false, true));
            animalService.AddAnimal(new GrayWolf(HelpMethods.GetNextAnimalId(), 7, "Gray Wolf", "A highly social and intelligent predator", "Hunts in packs and communicates through howling", 0.8f, 60, 4, true, true, true, "", true, "Sharp sense of smell"));
            animalService.AddAnimal(new CommonBottlenoseWhale(HelpMethods.GetNextAnimalId(), 30, "Common Bottlenose Whale", "A highly intelligent marine mammal", "Uses echolocation and travels in pods", 4.5f, 1500, 0, false, true, true, 40, true, "Feeds on squid"));
        }
    }
}
