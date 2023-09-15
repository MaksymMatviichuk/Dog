using System;
using System.Linq;
using SampleHierarchies.Services;
using SampleHierarchies.Data.Entities;
using SampleHierachies.Helpers;

namespace SampleHierarchies.Gui
{
    public class DogGui
    {
        public static void ShowDogsMenu(AnimalService animalService)
        {
            while (true)
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. List Dogs");
                Console.WriteLine("2. Add a Dog");
                Console.WriteLine("3. Delete a Dog");
                Console.WriteLine("4. Modify a Dog");
                Console.WriteLine("Please enter your choice:");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "0":
                        return; 
                    case "1":
                        ListDogs(animalService);
                        break;
                    case "2":
                        AddDog(animalService);
                        break;
                    case "3":
                        DeleteAnimal(animalService);
                        break;
                    case "4":
                        ModifyDog(animalService);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        public static void DeleteAnimal(AnimalService animalService)
        {
            Console.Write("Enter the ID of the Dog to delete: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                animalService.DeleteAnimal(id);
            }
            else
            {
                Console.WriteLine("Invalid ID. Please enter a valid integer.");
            }
        }

        public static void ListDogs(AnimalService animalService)
        {
            var dogs = animalService.GetAnimals().OfType<Dog>().ToList();
            if (dogs.Any())
            {
                Console.WriteLine("List of Dogs:");
                foreach (var dog in dogs)
                {
                    Console.WriteLine($"ID: {dog.Id}, Age: {dog.Age}, Breed: {dog.Breed}");
                }
            }
            else
            {
                Console.WriteLine("No Dogs found.");
            }
        }

        public static void ModifyDog(AnimalService animalService)
        {
            Console.Write("Enter the ID of the Dog to modify: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var existingDog = animalService.GetAnimals().OfType<Dog>().FirstOrDefault(d => d.Id == id);
                if (existingDog != null)
                {
                    Console.Write("Enter the new age of the Dog: ");
                    int newAge = int.Parse(Console.ReadLine());
                    Console.Write("Enter the new breed of the Dog: ");
                    string newBreed = Console.ReadLine();
                    existingDog.Age = newAge;
                    existingDog.Breed = newBreed;

                    Console.WriteLine("Dog modified successfully.");
                }
                else
                {
                    Console.WriteLine("Dog not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid ID. Please enter a valid integer.");
            }
        }

        public static void AddDog(AnimalService animalService)
        {
            Console.Write("Enter the age of the Dog: ");
            string age = Console.ReadLine();
            Console.Write("Enter the breed of the Dog: ");
            string breed = Console.ReadLine();
            var newDog = new Dog(HelpMethods.GetNextAnimalId(), 0, "Dog", "", "", 0, 0, 4, true, breed, true);
            newDog.Age = Convert.ToInt32(age);
            animalService.AddAnimal(newDog);

            Console.WriteLine("Dog added successfully.");
        }
    }
}
