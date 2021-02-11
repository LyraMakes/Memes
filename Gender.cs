using System;

namespace Memes
{
    class Gender
    {
        private float female_ness;
        private float male_ness;
        private string pronouns;

        public Gender()
        {
            this.female_ness = 0f;
            this.male_ness = 0f;
            this.pronouns = "None";
        }
        
        public Gender(float fem, float masc, string pro)
        {
            this.female_ness = fem;
            this.male_ness = masc;
            this.pronouns = pro;
        }

        public float getFemale_ness() { return female_ness; }
        public float getMale_ness() { return male_ness; }
        public string getPronouns() { return pronouns; }

        public string GetGenSimp()
        {
            if (female_ness == 0f && male_ness == 1f)
            {
                return "Male";
            }
            else if (female_ness == 1f && male_ness == 0f)
            {
                return "Female";
            }
            else
            {
                return "Non-Binary";
            }
        }

        public override string ToString()
        {
            return "  Female-ness: " + female_ness + ",\n" +
                   "    Male-ness: " + male_ness + ",\n" +
                   "     Pronouns: " + pronouns + "\n" +
                   "Gender(Simp.): " + GetGenSimp() + "\n";
        }
    }
}
