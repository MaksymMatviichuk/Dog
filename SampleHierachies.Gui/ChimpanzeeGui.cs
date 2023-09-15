using SampleHierarchies.Data.Entities;
using SampleHierarchies.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using SampleHierachies.Helpers;

namespace SampleHierarchies.Gui
{
    public class ChimpanzeeGui
    {
        public static void ShowChimpanzeesMenu(AnimalService animalService)
        {
            while (true)
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. List Chimpanzees");
                Console.WriteLine("2. Add a Chimpanzee");
                Console.WriteLine("3. Delete a Chimpanzee");
                Console.WriteLine("4. Modify a Chimpanzee");
                Console.WriteLine("Please enter your choice:");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "0":
                        return; 
                    case "1":
                        ListChimpanzees(animalService);
                        break;
                    case "2":
                        AddChimpanzee(animalService);
                        break;
                    case "3":
                        DeleteChimpanzee(animalService);
                        break;
                    case "4":
                        ModifyChimpanzee(animalService);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        public static void DeleteChimpanzee(AnimalService animalService)
        {
            Console.Write("Enter the ID of the Chimpanzee to delete: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                animalService.DeleteAnimal(id);
            }
            else
            {
                Console.WriteLine("Invalid ID. Please enter a valid integer.");
            }
        }

        public static void ListChimpanzees(AnimalService animalService)
        {
            var chimpanzees = animalService.GetAnimals().OfType<Chimpanzee>().ToList();
            if (chimpanzees.Any())
            {
                Console.WriteLine("List of Chimpanzees:");
                foreach (var chimpanzee in chimpanzees)
                {
                    Console.WriteLine($"ID: {chimpanzee.Id}, Age: {chimpanzee.Age}, High Intelligence: {chimpanzee.HighIntelligence}");
                }
            }
            else
            {
                Console.WriteLine("No Chimpanzees found.");
            }
        }

        public static void ModifyChimpanzee(AnimalService animalService)
        {
            Console.Write("Enter the ID of the Chimpanzee to modify: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var existingChimpanzee = animalService.GetAnimals().OfType<Chimpanzee>().FirstOrDefault(c => c.Id == id);
                if (existingChimpanzee != null)
                {
                    Console.Write("Enter the new age of the Chimpanzee: ");
                    int newAge = int.Parse(Console.ReadLine());
                    Console.Write("Enter the new high intelligence description of the Chimpanzee: ");
                    string newHighIntelligence = Console.ReadLine();
                    existingChimpanzee.Age = newAge;
                    existingChimpanzee.HighIntelligence = Convert.ToInt32(newHighIntelligence);

                    Console.WriteLine("Chimpanzee modified successfully.");
                }
                else
                {
                    Console.WriteLine("Chimpanzee not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid ID. Please enter a valid integer.");
            }
        }


        public static void AddChimpanzee(AnimalService animalService)
        {
            Console.Write("Enter the age of the Chimpanzee: ");
            string age = Console.ReadLine();
            Console.Write("Enter the high intelligence description of the Chimpanzee: ");
            string highIntelligence = Console.ReadLine();
            var newChimpanzee = new Chimpanzee(HelpMethods.GetNextAnimalId(), 0, "Chimpanzee", "", "", 0, 0, 2, true, true, "", true, Convert.ToInt32(highIntelligence), "");
            newChimpanzee.Age = Convert.ToInt32(age);
            animalService.AddAnimal(newChimpanzee);

            Console.WriteLine("Chimpanzee added successfully.");
        }
    }
}
