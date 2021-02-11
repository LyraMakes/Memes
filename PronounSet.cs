using System;
using System.Collections.Generic;
using System.Text;

namespace Memes
{
    class PronounSet
    {
        public string subject;
        public string dirObject;
        public string posAdj;
        public string possessive;
        public string reflexive;

        public PronounSet()
        {
            this.subject = "None";
            this.dirObject = "None";
            this.posAdj = "None";
            this.possessive = "None";
            this.reflexive = "None";
        }
        public PronounSet(string s, string o, string a, string p, string r)
        {
            this.subject = s;
            this.dirObject = o;
            this.posAdj = a;
            this.possessive = p;
            this.reflexive = r;
        }

        public override string ToString()
        {
            return subject + " / " + dirObject + " / " + posAdj + " / " + possessive + " / " + reflexive;
        }
    }
}
