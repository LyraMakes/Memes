using System;
using System.Collections.Generic;
using System.Text;

namespace Memes
{
    class main
    {
        static void Main(string[] args)
        {
            PronounSet femSet = new PronounSet("She", "Her", "Her", "Hers", "Herself");
            PronounSet neutSet = new PronounSet("They", "Them", "Their", "Theirs", "Themself");

            Pronouns pronouns = new Pronouns(femSet, neutSet);
            Console.WriteLine(pronouns);
            pronouns.AddSet(neutSet);
            Console.WriteLine(pronouns);



            Gender enby = new Gender();
            Console.WriteLine(enby);

            Gender woman = new Gender(1f, 0f, "She/Her");
            Console.WriteLine(woman);

            Gender man = new Gender(0f, 1f, "He/Him");
            Console.WriteLine(man);

            Gender demiGirl = new Gender(0.8f, 0f, "She/Her/They/Them");
            Console.WriteLine(demiGirl);

            Sexuality panRomDemSex = new Sexuality(0.8f, 0.9f, 0.8f, 0.5f, 0.8f, 0.9f, 0.8f, 1f);

            Gender agender = new Gender(0f, 0f, "They/Them");
            Sexuality aroace = new Sexuality();

            Sexuality gyne = new Sexuality(0f, 1f, 0.7f, 0.8f, 0f, 1f, 0.7f, 0.8f);



            Person lyra = new Person("Lyra", demiGirl, panRomDemSex);
            Person sho = new Person("Sho", agender, gyne);


            Console.WriteLine(lyra);
            Console.WriteLine(sho);

            Console.WriteLine(lyra.getCompatibility(sho));
            Console.WriteLine(sho.getCompatibility(lyra));
        }
    }
}
