using SampleHierarchies.Data.Entities;
using SampleHierarchies.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using SampleHierachies.Helpers;
using SampleHierarchies.Data.Mammals;

namespace SampleHierarchies.Gui
{
    public class OrangutanGui
    {
        public static void ShowOrangutansMenu(AnimalService animalService)
        {
            while (true)
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. List Orangutans");
                Console.WriteLine("2. Add an Orangutan");
                Console.WriteLine("3. Delete an Orangutan");
                Console.WriteLine("4. Modify an Orangutan");
                Console.WriteLine("Please enter your choice:");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "0":
                        return; 
                    case "1":
                        ListOrangutans(animalService);
                        break;
                    case "2":
                        AddOrangutan(animalService);
                        break;
                    case "3":
                        DeleteOrangutan(animalService);
                        break;
                    case "4":
                        ModifyOrangutan(animalService);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        public static void DeleteOrangutan(AnimalService animalService)
        {
            Console.Write("Enter the ID of the Orangutan to delete: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                animalService.DeleteAnimal(id);
            }
            else
            {
                Console.WriteLine("Invalid ID. Please enter a valid integer.");
            }
        }

        public static void ListOrangutans(AnimalService animalService)
        {
            var orangutans = animalService.GetAnimals().OfType<Orangutan>().ToList();
            if (orangutans.Any())
            {
                Console.WriteLine("List of Orangutans:");
                foreach (var orangutan in orangutans)
                {
                    Console.WriteLine($"ID: {orangutan.Id}, Age: {orangutan.Age}, Intelligence Level: {orangutan.IntelligenceLevel}");
                }
            }
            else
            {
                Console.WriteLine("No Orangutans found.");
            }
        }

        public static void ModifyOrangutan(AnimalService animalService)
        {
            Console.Write("Enter the ID of the Orangutan to modify: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var existingOrangutan = animalService.GetAnimals().OfType<Orangutan>().FirstOrDefault(o => o.Id == id);
                if (existingOrangutan != null)
                {
                    Console.Write("Enter the new age of the Orangutan: ");
                    int newAge = int.Parse(Console.ReadLine());
                    Console.Write("Enter the new intelligence level description of the Orangutan: ");
                    string newIntelligenceLevel = Console.ReadLine();

                    // Оновіть властивості існуючого Orangutan на нові значення
                    existingOrangutan.Age = newAge;
                    existingOrangutan.IntelligenceLevel = Convert.ToInt32(newIntelligenceLevel);

                    Console.WriteLine("Orangutan modified successfully.");
                }
                else
                {
                    Console.WriteLine("Orangutan not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid ID. Please enter a valid integer.");
            }
        }


        public static void AddOrangutan(AnimalService animalService)
        {
            Console.Write("Enter the age of the Orangutan: ");
            string age = Console.ReadLine();
            Console.Write("Enter the intelligence level description of the Orangutan: ");
            string intelligenceLevel = Console.ReadLine();
            var newOrangutan = new Orangutan(HelpMethods.GetNextAnimalId(), 0, "Orangutan", "", "", 0, 0, 2, true, true, true, true, Convert.ToInt32(intelligenceLevel), true, true);
            newOrangutan.Age = Convert.ToInt32(age);
            animalService.AddAnimal(newOrangutan);

            Console.WriteLine("Orangutan added successfully.");
        }
    }
}
