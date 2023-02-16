
using template_csharp_virtual_pet;

namespace pet

{
    public class Shelter
    {
        public List<Pet> PetHouse
        {
            get; set;
        }

        public Shelter(List<Pet> aPetHouse)
        {
            PetHouse = aPetHouse;
        }



        public void AddPet()
        {
            Console.Clear();
            DelayString("Pick a pet type:");
            DelayString("1. Organic pet");
            DelayString("2. Robotic pet\n");

            string input1 = Console.ReadLine();


            Console.Clear();
            DelayString("Please enter your pet's species:\n");

            string species = Console.ReadLine();

            Console.Clear();
            DelayString("Enter your pets name:\n");
            string name = Console.ReadLine();

            Console.Clear();
            DelayString("Give your pet a color:\n");
            string color = Console.ReadLine();



            switch (input1)
            {

                case "1":
                    PetHouse.Add(new OrganicPet(name, species, color, 60, 60, 60));
                    break;

                case "2":
                    PetHouse.Add(new RoboticPet(name, species, color, 60, 60, 60));
                    break;
            }
        }

        public void Tick()
        {

            foreach (Pet pet in PetHouse)
            {
                pet.Hunger = pet.Hunger + 5;
                if (pet.Hunger > 60)
                {
                    pet.Hunger = 60;
                }
                pet.Boredom = pet.Boredom + 5;
                if (pet.Boredom > 60)
                {
                    pet.Boredom = 60;
                }
                pet.Health = pet.Health - 5;
                if (pet.Health < 10)
                {
                    pet.Health = 0;
                }
            }

        }

        public void RemovePet()
        {
            ListPets();
            Console.WriteLine("Which pet number would you like to remove (select the number)?");

            int petHouse = Convert.ToInt32(Console.ReadLine());
            if (PetHouse.Count >= petHouse)
            {
                PetHouse.RemoveAt(petHouse - 1);
                ListPets();
                Console.WriteLine("Press 'Enter' to return to main menu");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"Pet number {petHouse} not found");
            }
            Console.ReadKey();
        }

        public void ListPets()
        {
            int listNumber = 1;
            Console.Clear();
            Console.WriteLine();
            foreach (Pet pet in PetHouse)
            {

                if (pet is OrganicPet)
                {
                    Console.WriteLine($"{listNumber++}. [Organic] {pet.Name}\n");
                }
                if (pet is RoboticPet)
                {
                    Console.WriteLine($"{listNumber++}. [Robotic] {pet.Name}\n");
                }
            }

        }

        public void DelayString(string aMessage)
        {
            for (int i = 0; i < aMessage.Length; i++)
            {
                Console.Write(aMessage[i]);
                Thread.Sleep(2);
            }
            Console.WriteLine();
        }

    }
}


//useless code for now
/*
 * 
 if (pet is OrganicPet)
                {
                    Console.WriteLine($" {listNumber++}.{pet.Name}:  Species:{pet.Species};  Color:{pet.Color}; " +
                    $" Hunger:{pet.Hunger}; Boredom: {pet.Boredom};  Health: {pet.Health}");
                }
                if (pet is RoboticPet)
                {
                    Console.WriteLine($" {listNumber++}.{pet.Name}:  Species:{pet.Species};  Color:{pet.Color}; " +
                    $" Battery:{pet.Hunger}; Boredom: {pet.Boredom};  Armor: {pet.Health}");
                }
*/