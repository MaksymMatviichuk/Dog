using SampleHierarchies.Interfaces.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleHierarchies.Data.Entities
{
    public class Animal : IAnimal
    {
        public Animal(int id, int age, string species, string description, string behaviorDescription, float height, float weight)
        {
            Id = id;
            Age = age;
            Species = species;
            Description = description;
            BehaviorDescription = behaviorDescription;
            Height = height;
            Weight = weight;
        }
        public int Id { get; set; }
        public int Age { get; set; }
        public string Species { get; set; }
        public string Description { get; set; }
        public string BehaviorDescription { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }

    }
}
