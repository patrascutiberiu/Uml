using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryGuerre
{
    public class Arme
    {
        private int puissance;

        public int GetPuissance
        {
            get
            {
                return puissance;
            }
        }

        public Arme(int _puissance)
        {
            puissance = _puissance;
        }

        public override string ToString()
        {
            return "La puissanc e de l'arme est de : " + puissance;
        }

    }
}
