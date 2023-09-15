using SampleHierarchies.Services;
using SampleHierarchies.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using SampleHierachies.Helpers;
using System.ComponentModel;

namespace SampleHierarchies.Gui
{
    public class BengalTigerGui
    {
        public static void ShowBengalTigersMenu(AnimalService animalService)
        {
            while (true)
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. List Bengal Tigers");
                Console.WriteLine("2. Add a Bengal Tiger");
                Console.WriteLine("3. Delete a Bengal Tiger");
                Console.WriteLine("4. Modify a Bengal Tiger");
                Console.WriteLine("Please enter your choice:");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "0":
                        return; // Exit to the previous menu
                    case "1":
                        ListBengalTigers(animalService);
                        break;
                    case "2":
                        AddBengalTiger(animalService);
                        break;
                    case "3":
                        DeleteBengalTiger(animalService);
                        break;
                    case "4":
                        ModifyBengalTiger(animalService);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        public static void DeleteBengalTiger(AnimalService animalService)
        {
            Console.Write("Enter the ID of the Bengal Tiger to delete: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                animalService.DeleteAnimal(id);
            }
            else
            {
                Console.WriteLine("Invalid ID. Please enter a valid integer.");
            }
        }

        public static void ListBengalTigers(AnimalService animalService)
        {
            var bengalTigers = animalService.GetAnimals().OfType<BengalTiger>().ToList();
            if (bengalTigers.Any())
            {
                Console.WriteLine("List of Bengal Tigers:");
                foreach (var tiger in bengalTigers)
                {
                    Console.WriteLine($"ID: {tiger.Id}, Age: {tiger.Age}, Size: {tiger.LargeSize}");
                }
            }
            else
            {
                Console.WriteLine("No Bengal Tigers found.");
            }
        }

        public static void ModifyBengalTiger(AnimalService animalService)
        {
            Console.Write("Enter the ID of the Bengal Tiger to modify: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var existingTiger = animalService.GetAnimals().OfType<BengalTiger>().FirstOrDefault(t => t.Id == id);
                if (existingTiger != null)
                {
                    Console.Write("Enter the new age of the Bengal Tiger: ");
                    int newAge = int.Parse(Console.ReadLine());
                    Console.Write("Enter the new size of the Bengal Tiger: ");
                    float newSize = float.Parse(Console.ReadLine());
                    Console.Write("Enter whether the Bengal Tiger has solitary behavior (true/false): ");
                    bool newSolitaryBehavior = bool.Parse(Console.ReadLine());
                    existingTiger.Age = newAge;
                    existingTiger.LargeSize = newSize;
                    existingTiger.SolitaryBehavior = newSolitaryBehavior;

                    Console.WriteLine("Bengal Tiger modified successfully.");
                }
                else
                {
                    Console.WriteLine("Bengal Tiger not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid ID. Please enter a valid integer.");
            }
        }

        public static void AddBengalTiger(AnimalService animalService)
        {
            Console.Write("Enter the age of the Bengal Tiger: ");
            string age = Console.ReadLine();
            Console.Write("Enter the size of the Bengal Tiger: ");
            string size = Console.ReadLine();
            Console.Write("Enter whether the Bengal Tiger has solitary behavior (true/false): ");
            bool solitaryBehavior = bool.Parse(Console.ReadLine());
            var newTiger = new BengalTiger(
                HelpMethods.GetNextAnimalId(),
                0,
                "Bengal Tiger",
                "",
                "",
                0,
                0,
                0,
                false,
                true,
                Convert.ToSingle(size),
                "",
                false,
                solitaryBehavior 
            );
            newTiger.Age = Convert.ToInt32(age);
            animalService.AddAnimal(newTiger);

            Console.WriteLine("Bengal Tiger added successfully.");
        }

    }
}
