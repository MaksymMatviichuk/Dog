using SampleHierarchies.Data.Entities;
using SampleHierarchies.Interfaces.Data.Mammals;
using System.Xml.Linq;

namespace SampleHierarchies.Data.Mammals
{
    public class Orangutan : Mammal, IOrangutan
    {
        public Orangutan(int id, int age, string species, string description, string behaviorDescription, float height, float weight, int numberOfLegs, bool hasFur,
             bool carnivorous, bool arborealLifestyle, bool opposableThumbs, int intelligenceLevel, bool solitaryBehavior, bool slowReproductiveRate)
             : base(id, age, species, description, behaviorDescription, height, weight, numberOfLegs, hasFur)
        {
            Carnivorous = carnivorous;
            ArborealLifestyle = arborealLifestyle;
            OpposableThumbs = opposableThumbs;
            IntelligenceLevel = intelligenceLevel;
            SolitaryBehavior = solitaryBehavior;
            SlowReproductiveRate = slowReproductiveRate;
        }

        public bool Carnivorous { get; set; }
        public bool ArborealLifestyle { get; set; }
        public bool OpposableThumbs { get; set; }
        public int IntelligenceLevel { get; set; }
        public bool SolitaryBehavior { get; set; }
        public bool SlowReproductiveRate { get; set; }

        public void BuildNest()
        {
            Console.WriteLine("Orangutan is building a nest.");
        }

        public void UseTools()
        {
            Console.WriteLine("Orangutan is using tools.");
        }

        public void CommunicateWithGestures()
        {
            Console.WriteLine("Orangutan is communicating with gestures.");
        }
    }
}
