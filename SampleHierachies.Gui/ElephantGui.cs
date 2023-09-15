using SampleHierachies.Helpers;
using SampleHierarchies.Data.Entities;
using SampleHierarchies.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleHierachies.Gui
{
    public class ElephantGui
    {

        public static void ShowElephantsMenu(AnimalService animalService)
        {
            while (true)
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. List Elephants");
                Console.WriteLine("2. Add an Elephant");
                Console.WriteLine("3. Delete an Elephant");
                Console.WriteLine("4. Modify an Elephant");
                Console.WriteLine("Please enter your choice:");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "0":
                        return; 
                    case "1":
                        ListElephants(animalService);
                        break;
                    case "2":
                        AddElephant(animalService);
                        break;
                    case "3":
                        DeleteElephant(animalService);
                        break;
                    case "4":
                        ModifyElephant(animalService);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        public static void DeleteElephant(AnimalService animalService)
        {
            Console.Write("Enter the ID of the Elephant to delete: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                animalService.DeleteAnimal(id);
            }
            else
            {
                Console.WriteLine("Invalid ID. Please enter a valid integer.");
            }
        }

        public static void ListElephants(AnimalService animalService)
        {
            var elephants = animalService.GetAnimals().OfType<Elephant>().ToList();
            if (elephants.Any())
            {
                Console.WriteLine("List of Elephants:");
                foreach (var elephant in elephants)
                {
                    Console.WriteLine($"ID: {elephant.Id}, Age: {elephant.Age}, Tusk Length: {elephant.TuskLength}");
                }
            }
            else
            {
                Console.WriteLine("No Elephants found.");
            }
        }

        public static void ModifyElephant(AnimalService animalService)
        {
            Console.Write("Enter the ID of the Elephant to modify: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var existingElephant = animalService.GetAnimals().OfType<Elephant>().FirstOrDefault(e => e.Id == id);
                if (existingElephant != null)
                {
                    Console.Write("Enter the new age of the Elephant: ");
                    int newAge = int.Parse(Console.ReadLine());
                    Console.Write("Enter the new tusk length of the Elephant: ");
                    int newTuskLength = int.Parse(Console.ReadLine());

                    existingElephant.Age = newAge;
                    existingElephant.TuskLength = newTuskLength;

                    Console.WriteLine("Elephant modified successfully.");
                }
                else
                {
                    Console.WriteLine("Elephant not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid ID. Please enter a valid integer.");
            }
        }


        public static void AddElephant(AnimalService animalService)
        {
            Console.Write("Enter the age of the Elephant: ");
            string age = Console.ReadLine();
            Console.Write("Enter the tusk length of the Elephant: ");
            string tuskLength = Console.ReadLine();
            var newElephant = new Elephant(HelpMethods.GetNextAnimalId(), 0, "Elephant", "", "", 0, 0, 4, Convert.ToInt32(tuskLength), "", false);
            newElephant.Age = Convert.ToInt32(age);
            animalService.AddAnimal(newElephant);

            Console.WriteLine("Elephant added successfully.");
        }
    }
}
