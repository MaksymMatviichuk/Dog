using Newtonsoft.Json;
using SampleHierarchies.Data.Entities;
using SampleHierarchies.Interfaces.Data;
using SampleHierarchies.Interfaces.Services;
using System.Collections.Generic;

namespace SampleHierarchies.Services
{
    public class AnimalService 
    {
        private IDataService<IAnimal> _animalDataService;
        private List<IAnimal> _animals;
        public AnimalService(IDataService<IAnimal> animalDataService)
        {
            _animalDataService = animalDataService;
            _animals = new List<IAnimal>();
        }

        public void SaveAnimalData(List<IAnimal> animals, string filePath)
        {
            _animalDataService.SaveData(animals, filePath);
        }

        public List<IAnimal> LoadAnimalData(string filePath)
        {
            if (File.Exists(filePath))
            {
                string jsonData = File.ReadAllText(filePath);
                var animals = JsonConvert.DeserializeObject<List<Animal>>(jsonData);

                // Тут ви перетворюєте об'єкти Animal у відповідні типи, які реалізують IAnimal
                var mappedAnimals = animals.Cast<IAnimal>().ToList();

                Console.WriteLine("Data loaded from " + filePath);
                return mappedAnimals;
            }
            else
            {
                return new List<IAnimal>();
            }
        }




        public void AddAnimal(IAnimal animal)
        {
            _animals.Add(animal);
        }

        public List<IAnimal> GetAnimals()
        {
            return _animals;
        }
        public void DeleteAnimal(int id)
        {
            // Implement deleting an animal from the collection based on the provided ID
            var animalToDelete = _animals.FirstOrDefault(a => a.Id == id);
            if (animalToDelete != null)
            {
                _animals.Remove(animalToDelete);
                Console.WriteLine($"Animal with ID {id} has been deleted.");
            }
            else
            {
                Console.WriteLine($"Animal with ID {id} not found.");
            }
        }
    }
}
