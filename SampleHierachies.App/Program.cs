using SampleHierarchies.Interfaces.Data;
using SampleHierarchies.Interfaces.Services;
using SampleHierarchies.Services;
using System;
using System.Linq;
using SampleHierarchies.Data.Entities;
using SampleHierachies.Helpers;
using SampleHierarchies.Gui;
using SampleHierachies.Enums;
using SampleHierachies.Gui;
using System.Drawing;

class Program
{
    static void Main()
    {
        // Main dependencies

        string exePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
        string directory = Path.GetDirectoryName(exePath);
        string settingsFilePath = Path.Combine(directory, "settings.json");
        var settingsService = new JsonSettingsService(settingsFilePath);
        ISettings appSettings = settingsService.LoadSettings();
        IDataService<IAnimal> animalDataService = new JsonDataService<IAnimal>();
        var animalService = new AnimalService(animalDataService);
        AnimalInitializer.Initialize(animalService);

        // Menu 

        while (true)
        {
            if (!string.IsNullOrEmpty(appSettings.MainScreenColor))
            {
                ConsoleColor consoleColor;
                if (Enum.TryParse(appSettings.MainScreenColor, true, out consoleColor))
                {
                    Console.BackgroundColor = consoleColor;
                }
                else
                {
                    Console.WriteLine("Invalid color specified in MainScreenColor setting.");
                }
            }
            Console.WriteLine("Your available choices are:");
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Animals");
            Console.WriteLine("2. Create a new settings");
            Console.WriteLine("Please enter your choice:");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    settingsService.SaveSettings(appSettings);
                    Environment.Exit(0);
                    break;
                case 1:
                    ShowAnimalsMenu(animalService);
                    break;
                case 2:
                    Console.Write("Enter the Main Screen Color: ");
                    appSettings.MainScreenColor = Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void ShowAnimalsMenu(AnimalService animalService)
    {
        while (true)
        {
            Console.WriteLine("Your available choices are:");
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Mammals");
            Console.WriteLine("2. Save to file");
            Console.WriteLine("3. Read from file");
            Console.WriteLine("Please enter your choice:");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "0":
                    return; 
                case "1":
                    ShowMammalsMenu(animalService);
                    break;
                case "2":
                    Console.Write("Enter the file path to save animals: ");
                    string saveFilePath = Console.ReadLine();
                    animalService.SaveAnimalData(animalService.GetAnimals(), saveFilePath);
                    break;
                case "3":
                    Console.Write("Enter the file path to load animals: ");
                    string loadFilePath = Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void ShowMammalsMenu(AnimalService animalService)
    {
        while (true) 
        {
            Console.WriteLine("0. Exit");
            Console.WriteLine($"1. {AnimalType.Dog}");
            Console.WriteLine($"2. {AnimalType.BottlenoseDolphin}");
            Console.WriteLine($"3. {AnimalType.Elephant}");
            Console.WriteLine($"4. {AnimalType.Lion}");
            Console.WriteLine($"5. {AnimalType.GrayWolf}");
            Console.WriteLine($"6. {AnimalType.Chimpanzee}");
            Console.WriteLine($"7. {AnimalType.Orangutan}");
            Console.WriteLine($"8. {AnimalType.CommonBottlenoseWhale}");
            Console.WriteLine($"9. {AnimalType.BengalTiger}");
            Console.WriteLine($"10. {AnimalType.GrizzlyBear}");
            Console.WriteLine($"11. {AnimalType.PolarBear}");
            Console.WriteLine("Please enter your choice:");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "0":
                    return; // Exit to the previous menu
                case "1":
                    DogGui.ShowDogsMenu(animalService);
                    break;
                case "2":
                    DolphinGui.ShowDolphinsMenu(animalService);
                    break;
                case "3":
                    ElephantGui.ShowElephantsMenu(animalService);
                    break;
                case "4":
                    LionGui.ShowLionsMenu(animalService);
                    break;  
                case "5":
                    GrayWolfGui.ShowGrayWolvesMenu(animalService);
                    break;
                case "6":
                    ChimpanzeeGui.ShowChimpanzeesMenu(animalService);
                    break;
                case "7":
                    OrangutanGui.ShowOrangutansMenu(animalService);
                    break;
                case "8":
                    CommonBottlenoseWhaleGui.ShowCommonBottlenoseWhalesMenu(animalService);
                    break;
                case "9":
                    BengalTigerGui.ShowBengalTigersMenu(animalService);
                    break;
                case "10":
                    GrizzlyBearGui.ShowGrizzlyBearsMenu(animalService);
                    break;
                case "11":
                    PolarBearGui.ShowPolarBearsMenu(animalService);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}

