using SampleHierarchies.Services;
using SampleHierarchies.Data.Entities;
using System;
using System.Linq;
using System.Collections.Generic;
using SampleHierachies.Helpers;

namespace SampleHierarchies.Gui
{
    public class PolarBearGui
    {
        public static void ShowPolarBearsMenu(AnimalService animalService)
        {
            while (true)
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. List Polar Bears");
                Console.WriteLine("2. Add a Polar Bear");
                Console.WriteLine("3. Delete a Polar Bear");
                Console.WriteLine("4. Modify a Polar Bear");
                Console.WriteLine("Please enter your choice:");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "0":
                        return;
                    case "1":
                        ListPolarBears(animalService);
                        break;
                    case "2":
                        AddPolarBear(animalService);
                        break;
                    case "3":
                        DeletePolarBear(animalService);
                        break;
                    case "4":
                        ModifyPolarBear(animalService);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        public static void DeletePolarBear(AnimalService animalService)
        {
            Console.Write("Enter the ID of the Polar Bear to delete: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                animalService.DeleteAnimal(id);
            }
            else
            {
                Console.WriteLine("Invalid ID. Please enter a valid integer.");
            }
        }

        public static void ListPolarBears(AnimalService animalService)
        {
            var polarBears = animalService.GetAnimals().OfType<PolarBear>().ToList();
            if (polarBears.Any())
            {
                Console.WriteLine("List of Polar Bears:");
                foreach (var polarBear in polarBears)
                {
                    Console.WriteLine($"ID: {polarBear.Id}, Age: {polarBear.Age}, Fur Coat: {polarBear.FurCoat}");
                }
            }
            else
            {
                Console.WriteLine("No Polar Bears found.");
            }
        }

        public static void ModifyPolarBear(AnimalService animalService)
        {
            Console.Write("Enter the ID of the Polar Bear to modify: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var existingPolarBear = animalService.GetAnimals().OfType<PolarBear>().FirstOrDefault(p => p.Id == id);
                if (existingPolarBear != null)
                {
                    Console.Write("Enter the new age of the Polar Bear: ");
                    int newAge = int.Parse(Console.ReadLine());
                    Console.Write("Enter the new fur coat description of the Polar Bear: ");
                    string newFurCoat = Console.ReadLine();
                    existingPolarBear.Age = newAge;
                    existingPolarBear.FurCoat = newFurCoat;

                    Console.WriteLine("Polar Bear modified successfully.");
                }
                else
                {
                    Console.WriteLine("Polar Bear not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid ID. Please enter a valid integer.");
            }
        }


        public static void AddPolarBear(AnimalService animalService)
        {
            Console.Write("Enter the age of the Polar Bear: ");
            string age = Console.ReadLine();
            Console.Write("Enter the fur coat description of the Polar Bear: ");
            string furCoat = Console.ReadLine();
            var newPolarBear = new PolarBear(HelpMethods.GetNextAnimalId(), 0, "Polar Bear", "", "", 0, 0, 4, true, "", "", "", false, "");
            newPolarBear.Age = Convert.ToInt32(age);
            newPolarBear.FurCoat = furCoat;
            animalService.AddAnimal(newPolarBear);

            Console.WriteLine("Polar Bear added successfully.");
        }



        private static int animalIdCounter = 1;
    }
}
