using SampleHierarchies.Data.Entities;
using SampleHierarchies.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using SampleHierachies.Helpers;

namespace SampleHierarchies.Gui
{
    public class LionGui
    {
        public static void ShowLionsMenu(AnimalService animalService)
        {
            while (true)
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. List Lions");
                Console.WriteLine("2. Add a Lion");
                Console.WriteLine("3. Delete a Lion");
                Console.WriteLine("4. Modify a Lion");
                Console.WriteLine("Please enter your choice:");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "0":
                        return; // Exit to the previous menu
                    case "1":
                        ListLions(animalService);
                        break;
                    case "2":
                        AddLion(animalService);
                        break;
                    case "3":
                        DeleteLion(animalService);
                        break;
                    case "4":
                        ModifyLion(animalService);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        public static void DeleteLion(AnimalService animalService)
        {
            Console.Write("Enter the ID of the Lion to delete: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                animalService.DeleteAnimal(id);
            }
            else
            {
                Console.WriteLine("Invalid ID. Please enter a valid integer.");
            }
        }

        public static void ListLions(AnimalService animalService)
        {
            var lions = animalService.GetAnimals().OfType<Lion>().ToList();
            if (lions.Any())
            {
                Console.WriteLine("List of Lions:");
                foreach (var lion in lions)
                {
                    Console.WriteLine($"ID: {lion.Id}, Age: {lion.Age}, Mane: {lion.Mane}");
                }
            }
            else
            {
                Console.WriteLine("No Lions found.");
            }
        }

        public static void ModifyLion(AnimalService animalService)
        {
            Console.Write("Enter the ID of the Lion to modify: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var existingLion = animalService.GetAnimals().OfType<Lion>().FirstOrDefault(lion => lion.Id == id);
                if (existingLion != null)
                {
                    Console.Write("Enter the new age of the Lion: ");
                    int newAge = int.Parse(Console.ReadLine());
                    Console.Write("Enter the new mane description of the Lion: ");
                    string newMane = Console.ReadLine();
                    existingLion.Age = newAge;
                    existingLion.Mane = newMane;

                    Console.WriteLine("Lion modified successfully.");
                }
                else
                {
                    Console.WriteLine("Lion not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid ID. Please enter a valid integer.");
            }
        }


        public static void AddLion(AnimalService animalService)
        {
            Console.Write("Enter the age of the Lion: ");
            string age = Console.ReadLine();
            Console.Write("Enter the mane description of the Lion: ");
            string mane = Console.ReadLine();
            var newLion = new Lion(HelpMethods.GetNextAnimalId(), 0, "Lion", "", "", 0, 0, 4, true, true, true, mane, true, true);
            newLion.Age = Convert.ToInt32(age);
            animalService.AddAnimal(newLion);

            Console.WriteLine("Lion added successfully.");
        }
    }
}
