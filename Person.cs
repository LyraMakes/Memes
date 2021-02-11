using System;
using System.Collections.Generic;
using System.Text;

namespace Memes
{
    class Person
    {
        private String name;
        private Gender gender;
        private Sexuality sexuality;

        private bool hasMasc;
        private bool hasFem;
        private bool hasEnby;

        public Person()
        {
            this.name = null;
            this.gender = new Gender();
            this.sexuality = new Sexuality();

            this.hasMasc = false;
            this.hasFem = false;
            this.hasEnby = true;
        }

        public Person(String n, Gender g, Sexuality s)
        {
            this.name = n;
            this.gender = g;
            this.sexuality = s;

            this.hasMasc = gender.getMale_ness() > 0;
            this.hasFem = gender.getFemale_ness() > 0;
            this.hasEnby = !(this.hasMasc || this.hasFem);
        }

        public bool getCompatibility(Person match)
        {
            if (sexuality.getAttraction().Equals("AroAce"))
            {
                return false;
            }
            bool result = false;
            if (match.hasMasc && (sexuality.getSex_male() > 0f || sexuality.getRom_male() > 0f))
            {
                result = true;
            }
            if (match.hasFem && (sexuality.getSex_female() > 0f || sexuality.getRom_female() > 0f))
            {
                result = true;
            }
            if (match.hasEnby && (sexuality.getSex_enby() > 0f || sexuality.getRom_enby() > 0f))
            {
                result = true;
            }
            return result;
        }

        public override String ToString()
        {
            return name + "\n" + gender + sexuality;
        }
    }
}
