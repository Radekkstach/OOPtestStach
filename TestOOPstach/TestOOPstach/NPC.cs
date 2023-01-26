using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOPstach
{
    class NPC : Herni_postava
    {
        public enum Prace
        {
            obchodnik,nepritel,obyvatel
        }
        string praces;
        string silas;
        public bool sila = false; // True = je Boss , false = neni

        public NPC(string jmeno,int prace, bool sila) : base(jmeno)
        {
            if(prace == 0) { praces = Prace.obchodnik.ToString(); }
            if (prace == 1) { praces = Prace.nepritel.ToString(); }
            if (prace == 2) { praces = Prace.obyvatel.ToString(); }

            if(sila == true) { silas = "Je Boss"; } else { silas = "Neni Boss"; }

        }

        public NPC(string jmeno, int prace) : base(jmeno)
        {
            if (prace == 0) { praces = Prace.obchodnik.ToString(); }
            if (prace == 1) { praces = Prace.nepritel.ToString(); }
            if (prace == 2) { praces = Prace.obyvatel.ToString(); }

            silas = "Neni Boss";

        }

        public override string ToString()
        {
            return "NPC: " + jmeno + " jeho prace: " + praces + " jeho sila " + silas;

        }
    }
}
