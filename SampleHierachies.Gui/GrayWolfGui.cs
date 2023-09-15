using SampleHierarchies.Data.Entities;
using SampleHierarchies.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using SampleHierachies.Helpers;

namespace SampleHierarchies.Gui
{
    public class GrayWolfGui
    {
        public static void ShowGrayWolvesMenu(AnimalService animalService)
        {
            while (true)
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. List Gray Wolves");
                Console.WriteLine("2. Add a Gray Wolf");
                Console.WriteLine("3. Delete a Gray Wolf");
                Console.WriteLine("4. Modify a Gray Wolf");
                Console.WriteLine("Please enter your choice:");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "0":
                        return;
                    case "1":
                        ListGrayWolves(animalService);
                        break;
                    case "2":
                        AddGrayWolf(animalService);
                        break;
                    case "3":
                        DeleteGrayWolf(animalService);
                        break;
                    case "4":
                        ModifyGrayWolf(animalService);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        public static void DeleteGrayWolf(AnimalService animalService)
        {
            Console.Write("Enter the ID of the Gray Wolf to delete: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                animalService.DeleteAnimal(id);
            }
            else
            {
                Console.WriteLine("Invalid ID. Please enter a valid integer.");
            }
        }

        public static void ListGrayWolves(AnimalService animalService)
        {
            var grayWolves = animalService.GetAnimals().OfType<GrayWolf>().ToList();
            if (grayWolves.Any())
            {
                Console.WriteLine("List of Gray Wolves:");
                foreach (var grayWolf in grayWolves)
                {
                    Console.WriteLine($"ID: {grayWolf.Id}, Age: {grayWolf.Age}, Carnivorous Diet: {grayWolf.CarnivorousDiet}");
                }
            }
            else
            {
                Console.WriteLine("No Gray Wolves found.");
            }
        }

        public static void ModifyGrayWolf(AnimalService animalService)
        {
            Console.Write("Enter the ID of the Gray Wolf to modify: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var existingGrayWolf = animalService.GetAnimals().OfType<GrayWolf>().FirstOrDefault(wolf => wolf.Id == id);
                if (existingGrayWolf != null)
                {
                    Console.Write("Enter the new age of the Gray Wolf: ");
                    int newAge = int.Parse(Console.ReadLine());
                    Console.Write("Enter the new description of the carnivorous diet of the Gray Wolf: ");
                    string newCarnivorousDiet = Console.ReadLine();

                    existingGrayWolf.Age = newAge;
                    existingGrayWolf.CarnivorousDiet = newCarnivorousDiet;

                    Console.WriteLine("Gray Wolf modified successfully.");
                }
                else
                {
                    Console.WriteLine("Gray Wolf not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid ID. Please enter a valid integer.");
            }
        }

        public static void AddGrayWolf(AnimalService animalService)
        {
            Console.Write("Enter the age of the Gray Wolf: ");
            string age = Console.ReadLine();
            Console.Write("Enter the carnivorous diet description of the Gray Wolf: ");
            string carnivorousDiet = Console.ReadLine();

            var newGrayWolf = new GrayWolf(HelpMethods.GetNextAnimalId(), 0, "Gray Wolf", "", "", 0, 0, 4, true, true, true, carnivorousDiet, true, "");
            newGrayWolf.Age = Convert.ToInt32(age);
            animalService.AddAnimal(newGrayWolf);

            Console.WriteLine("Gray Wolf added successfully.");
        }
    }
}
