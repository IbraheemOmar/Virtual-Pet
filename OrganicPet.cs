using template_csharp_virtual_pet;

namespace pet
{
    public class OrganicPet : Pet
    {
        
        //public override string Name { get; set; }
        //public override string Species { get; set; }
        //public override string Color { get; set; }
        //public override int Hunger { get; set; }
        //public override int Boredom { get; set; }
        //public override int Health { get; set; }


        public OrganicPet(string aName, string aSpecies, string aColor, int aHunger, int aBoredom, int aHealth)
        {
            Name = aName;
            Species = aSpecies;
            Color = aColor;
            Hunger = aHunger;
            Boredom = aBoredom;
            Health = aHealth;

        }


        public override void Feed()
        {
            Console.Clear();
            
            Hunger = Hunger - 10;
            if (Hunger < 10)
            {
                Hunger = 0;
            }
            Console.WriteLine($"you fed {Name}!!!\nHunger level:{Hunger}");
            Console.WriteLine("\nPress 'Enter' to continue...");
            Console.ReadLine();

        }
        public override void SeeDoctor()
        {
            Console.Clear();
            Health = Health + 30;
            if (Health > 60)
            {
                Health = 60;
            }
            Console.WriteLine($"You healed {Name}'s health!!!\nHealth level:{Health}");
            Console.WriteLine("\nPress 'Enter' to continue...");
            Console.ReadLine();
        }
        public override void Play()
        {
            Console.Clear();
            Hunger = Hunger + 10;
            if (Hunger > 60)
            {
                Hunger = 60;
            }
            Boredom = Boredom - 20;
            if (Boredom < 10)
            {
                Boredom = 0;
            }
            Health = Health + 10;
            if (Health > 60)
            {
                Health = 60;
            }
            Console.WriteLine($"{Name} is now happier!!");
            Console.WriteLine($"Boredom level:{Boredom}");
            Console.WriteLine($"{Name} is now hungry. ");
            Console.WriteLine($"Hunger Level:{Hunger}");
            Console.WriteLine($"{Name}'s health has increased.");
            Console.WriteLine($"Health level:{Health}");
            Console.WriteLine("\nPress 'Enter' to continue...");
            Console.ReadLine();
        }
    }
}