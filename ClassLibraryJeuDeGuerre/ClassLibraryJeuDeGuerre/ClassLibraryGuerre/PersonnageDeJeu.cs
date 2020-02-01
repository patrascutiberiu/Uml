using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryGuerre
{
    public abstract class PersonnageDeJeu
    {
        private string pseudo;

        protected PersonnageDeJeu()
        {
        }

        public PersonnageDeJeu(string _pseudo)
        {
            pseudo = _pseudo;
        }



        public abstract void SeDeplacer();
    }
}
