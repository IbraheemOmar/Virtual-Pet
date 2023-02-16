using pet;
using template_csharp_virtual_pet;


//Default pets
OrganicPet pet1 = new OrganicPet("Clifford", "Dog", "red", 60, 60, 60);
RoboticPet pet2 = new RoboticPet("Tom", "Cat", "blue", 60, 60, 60);


//List for PetHouse
List<Pet> petHouse = new List<Pet>();
List<Pet> selectedPets = new List<Pet>();
//Shelter class referencing myShelter which is PetHouse
Shelter petShelter = new Shelter(petHouse);
bool keepThinking = true;
string input;

petHouse.Add(pet1);
petHouse.Add(pet2);

//petShelter.AddPet();
petSelector();


while (keepThinking)
{
    Console.Clear();
    Console.WriteLine("*****  Welcome to Virtual Pet MIO  *****");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("               MAIN MENU                ");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("Select an option: ");
    petShelter.DelayString("\n1. Create a new pet");
    petShelter.DelayString("2. Check the Pethouse");
    petShelter.DelayString("3. select a pet");
    petShelter.DelayString("4. Feed your pet");
    petShelter.DelayString("5. See doctor");
    petShelter.DelayString("6. Play with pet(s)");
    petShelter.DelayString("7. Remove your pet");

    petShelter.DelayString("\nPress Q to quit");

    Console.Write("\nSelected Pet(s): ");

    foreach (Pet pet in selectedPets)
    {
        Console.Write($"{pet.Name}; ");
    }

    Console.WriteLine("\n\n");



    input = Console.ReadLine();

    switch (input)
    {
        case "1":
            petShelter.AddPet();
            break;

        case "2":
            petShelter.ListPets();

            break;

        case "3":

            petSelector();

            break;

        case "4":

            foreach (Pet pet in selectedPets)
            {
                pet.Feed();
            }
            break;

        case "5":

            foreach (Pet pet in selectedPets)
            {
                pet.SeeDoctor();
            }

            break;

        case "6":

            foreach (Pet pet in selectedPets)
            {
                pet.Play();
            }

            break;

        case "7":
            petShelter.RemovePet();
            break;



        case "Q":
            keepThinking = false;
            break;

        default:
            Console.WriteLine("Please choose one of the options available above.");
            Console.ReadLine();
            break;
    }

    petShelter.Tick();


}


void petSelector()
{
    //petShelter.DelayString("How many pet(s) would you like to select?");
    Console.WriteLine("How many pet(s) would you like to select?");
    int numberOfPets = Convert.ToInt32(Console.ReadLine());


    selectedPets.Clear();

    for (int i = 0; i < numberOfPets; i++)
    {
        petShelter.ListPets();
        Console.WriteLine("Enter the index of the pet you would like to select:\n");
        int indexOfPet = Convert.ToInt32(Console.ReadLine());
        Pet selectedPet = petHouse.ElementAt(indexOfPet - 1);
        Console.Clear();
        Console.WriteLine("\n");
        Console.WriteLine($"you selected: {selectedPet.Name}\n");
        selectedPets.Add(selectedPet);
        Console.WriteLine("Press Enter to Continue...");
        Console.ReadLine();
    }
    Console.Clear();
    Console.Write("\nSelected Pet(s): ");

    foreach (Pet pet in selectedPets)
    {
        Console.Write($"{pet.Name}; ");
    }
    Console.WriteLine("\n\nPress Enter to Continue...");
    Console.ReadLine();
}




