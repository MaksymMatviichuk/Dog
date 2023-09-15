using System;
using System.Linq;
using SampleHierachies.Helpers;
using SampleHierarchies.Data.Entities;
using SampleHierarchies.Services;

namespace SampleHierarchies.Gui
{
    public class DolphinGui
    {
        public static void ShowDolphinsMenu(AnimalService animalService)
        {
            while (true)
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. List Dolphins");
                Console.WriteLine("2. Add a Dolphin");
                Console.WriteLine("3. Delete a Dolphin");
                Console.WriteLine("4. Modify a Dolphin");
                Console.WriteLine("Please enter your choice:");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "0":
                        return;
                    case "1":
                        ListDolphins(animalService);
                        break;
                    case "2":
                        AddDolphin(animalService);
                        break;
                    case "3":
                        DeleteDolphin(animalService);
                        break;
                    case "4":
                        ModifyDolphin(animalService);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        public static void DeleteDolphin(AnimalService animalService)
        {
            Console.Write("Enter the ID of the Dolphin to delete: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                animalService.DeleteAnimal(id);
            }
            else
            {
                Console.WriteLine("Invalid ID. Please enter a valid integer.");
            }
        }

        public static void ListDolphins(AnimalService animalService)
        {
            var dolphins = animalService.GetAnimals().OfType<BottlenoseDolphin>().ToList();
            if (dolphins.Any())
            {
                Console.WriteLine("List of Dolphins:");
                foreach (var dolphin in dolphins)
                {
                    Console.WriteLine($"ID: {dolphin.Id}, Age: {dolphin.Age}, Description: {dolphin.Description}");
                }
            }
            else
            {
                Console.WriteLine("No Dolphins found.");
            }
        }

        public static void ModifyDolphin(AnimalService animalService)
        {
            Console.Write("Enter the ID of the Dolphin to modify: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var existingDolphin = animalService.GetAnimals().OfType<BottlenoseDolphin>().FirstOrDefault(d => d.Id == id);
                if (existingDolphin != null)
                {
                    Console.Write("Enter the new age of the Dolphin: ");
                    int newAge = int.Parse(Console.ReadLine());
                    Console.Write("Enter the new description of the Dolphin: ");
                    string newDescription = Console.ReadLine();
                    existingDolphin.Age = newAge;
                    existingDolphin.Description = newDescription;

                    Console.WriteLine("Dolphin modified successfully.");
                }
                else
                {
                    Console.WriteLine("Dolphin not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid ID. Please enter a valid integer.");
            }
        }

        public static void AddDolphin(AnimalService animalService)
        {
            Console.Write("Enter the age of the Dolphin: ");
            string age = Console.ReadLine();
            Console.Write("Enter the description of the Dolphin: ");
            string description = Console.ReadLine();

            // Create a new Dolphin object and add it to the list
            var newDolphin = new BottlenoseDolphin(HelpMethods.GetNextAnimalId(), 0, "Dolphin", "", "", 0, 0, 0, false, false, description, false, 0, false);
            newDolphin.Age = Convert.ToInt32(age);
            newDolphin.Description = description;
            animalService.AddAnimal(newDolphin);

            Console.WriteLine("Dolphin added successfully.");
        }
    }
}