using System;
using System.Linq;
using SampleHierarchies.Services;
using SampleHierarchies.Data.Entities;
using SampleHierachies.Helpers;

namespace SampleHierarchies.Gui
{
    public class GrizzlyBearGui
    {
        public static void ShowGrizzlyBearsMenu(AnimalService animalService)
        {
            while (true)
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. List Grizzly Bears");
                Console.WriteLine("2. Add a Grizzly Bear");
                Console.WriteLine("3. Delete a Grizzly Bear");
                Console.WriteLine("4. Modify a Grizzly Bear");
                Console.WriteLine("Please enter your choice:");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "0":
                        return;
                    case "1":
                        ListGrizzlyBears(animalService);
                        break;
                    case "2":
                        AddGrizzlyBear(animalService);
                        break;
                    case "3":
                        DeleteAnimal(animalService);
                        break;
                    case "4":
                        ModifyGrizzlyBear(animalService);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        public static void DeleteAnimal(AnimalService animalService)
        {
            Console.Write("Enter the ID of the Grizzly Bear to delete: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                animalService.DeleteAnimal(id);
            }
            else
            {
                Console.WriteLine("Invalid ID. Please enter a valid integer.");
            }
        }

        public static void ListGrizzlyBears(AnimalService animalService)
        {
            var grizzlyBears = animalService.GetAnimals().OfType<GrizzlyBear>().ToList();
            if (grizzlyBears.Any())
            {
                Console.WriteLine("List of Grizzly Bears:");
                foreach (var bear in grizzlyBears)
                {
                    Console.WriteLine($"ID: {bear.Id}, Age: {bear.Age}, Size: {bear.LargeSize}");
                }
            }
            else
            {
                Console.WriteLine("No Grizzly Bears found.");
            }
        }

        public static void ModifyGrizzlyBear(AnimalService animalService)
        {
            Console.Write("Enter the ID of the Grizzly Bear to modify: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var existingGrizzlyBear = animalService.GetAnimals().OfType<GrizzlyBear>().FirstOrDefault(bear => bear.Id == id);
                if (existingGrizzlyBear != null)
                {
                    Console.Write("Enter the new age of the Grizzly Bear: ");
                    int newAge = int.Parse(Console.ReadLine());
                    Console.Write("Enter the new size of the Grizzly Bear: ");
                    string newSize = Console.ReadLine();

                    existingGrizzlyBear.Age = newAge;
                    existingGrizzlyBear.LargeSize = Convert.ToSingle(newSize);

                    Console.WriteLine("Grizzly Bear modified successfully.");
                }
                else
                {
                    Console.WriteLine("Grizzly Bear not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid ID. Please enter a valid integer.");
            }
        }

        public static void AddGrizzlyBear(AnimalService animalService)
        {
            Console.Write("Enter the age of the Grizzly Bear: ");
            string age = Console.ReadLine();
            Console.Write("Enter the size of the Grizzly Bear: ");
            string size = Console.ReadLine();

            var newBear = new GrizzlyBear(
                HelpMethods.GetNextAnimalId(),
                0,
                "Grizzly Bear",
                "",
                "",
                0,
                0,
                4,
                true,
                false, 
                "",
                Convert.ToSingle(size),
                false, 
                ""
            );
            newBear.Age = Convert.ToInt32(age);
            animalService.AddAnimal(newBear);

            Console.WriteLine("Grizzly Bear added successfully.");
        }
    }
}
