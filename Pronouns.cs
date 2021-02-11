using System;
using System.Collections.Generic;
using System.Text;

namespace Memes
{
    class Pronouns
    {
        private PronounSet[] sets;

        public Pronouns()
        {
            this.sets = new PronounSet[] { new PronounSet("None", "None", "None", "None", "None") };
        }

        public Pronouns(params PronounSet[] sets)
        {
            this.sets = sets;
        }

        public void AddSet(PronounSet Set)
        {
            PronounSet[] arr = new PronounSet[sets.Length + 1];
            Array.Copy(sets, 0, arr, 0, sets.Length);
            arr[arr.Length - 1] = Set;
            sets = arr;
        }

        public override string ToString()
        {
            string result = "";

            for (int i = 0; i < sets.Length; i++)
            {
                result = result + "Set" + (i + 1) + ": " + sets[i] + ";\n";
            }

            return result.Substring(0, result.Length - 2);
        }
    }
}
