using SampleHierarchies.Services;
using SampleHierarchies.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using SampleHierachies.Helpers;

namespace SampleHierarchies.Gui
{
    public class CommonBottlenoseWhaleGui
    {
        public static void ShowCommonBottlenoseWhalesMenu(AnimalService animalService)
        {
            while (true)
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. List Common Bottlenose Whales");
                Console.WriteLine("2. Add a Common Bottlenose Whale");
                Console.WriteLine("3. Delete a Common Bottlenose Whale");
                Console.WriteLine("4. Modify a Common Bottlenose Whale");
                Console.WriteLine("Please enter your choice:");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "0":
                        return;
                    case "1":
                        ListCommonBottlenoseWhales(animalService);
                        break;
                    case "2":
                        AddCommonBottlenoseWhale(animalService);
                        break;
                    case "3":
                        DeleteCommonBottlenoseWhale(animalService);
                        break;
                    case "4":
                        ModifyCommonBottlenoseWhale(animalService);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        public static void DeleteCommonBottlenoseWhale(AnimalService animalService)
        {
            Console.Write("Enter the ID of the Common Bottlenose Whale to delete: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                animalService.DeleteAnimal(id);
            }
            else
            {
                Console.WriteLine("Invalid ID. Please enter a valid integer.");
            }
        }

        public static void ListCommonBottlenoseWhales(AnimalService animalService)
        {
            var commonBottlenoseWhales = animalService.GetAnimals().OfType<CommonBottlenoseWhale>().ToList();
            if (commonBottlenoseWhales.Any())
            {
                Console.WriteLine("List of Common Bottlenose Whales:");
                foreach (var whale in commonBottlenoseWhales)
                {
                    Console.WriteLine($"ID: {whale.Id}, Age: {whale.Age}, Lifespan: {whale.LongLifespan}");
                }
            }
            else
            {
                Console.WriteLine("No Common Bottlenose Whales found.");
            }
        }

        public static void ModifyCommonBottlenoseWhale(AnimalService animalService)
        {
            Console.Write("Enter the ID of the Common Bottlenose Whale to modify: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var existingWhale = animalService.GetAnimals().OfType<CommonBottlenoseWhale>().FirstOrDefault(w => w.Id == id);
                if (existingWhale != null)
                {
                    Console.Write("Enter the new age of the Common Bottlenose Whale: ");
                    int newAge = int.Parse(Console.ReadLine());
                    Console.Write("Enter the new lifespan of the Common Bottlenose Whale: ");
                    int newLifespan = int.Parse(Console.ReadLine());
                    existingWhale.Age = newAge;
                    existingWhale.LongLifespan = newLifespan;

                    Console.WriteLine("Common Bottlenose Whale modified successfully.");
                }
                else
                {
                    Console.WriteLine("Common Bottlenose Whale not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid ID. Please enter a valid integer.");
            }
        }

        public static void AddCommonBottlenoseWhale(AnimalService animalService)
        {
            Console.Write("Enter the age of the Common Bottlenose Whale: ");
            string age = Console.ReadLine();
            Console.Write("Enter the lifespan of the Common Bottlenose Whale: ");
            string lifespan = Console.ReadLine();
            var newWhale = new CommonBottlenoseWhale(HelpMethods.GetNextAnimalId(), 0, "Common Bottlenose Whale", "", "", 0, 0, 0, false, true, true, Convert.ToInt32(lifespan), true, "");
            newWhale.Age = Convert.ToInt32(age);
            animalService.AddAnimal(newWhale);

            Console.WriteLine("Common Bottlenose Whale added successfully.");
        }
    }
}
