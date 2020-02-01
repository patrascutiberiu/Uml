using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryGuerre
{
    public class Guerrier : PersonnageDeJeu
    {
        private int nbVieRestante;
        private List<Arme> arme;
        

        public Guerrier(int _nbVieRestante):base()
        {
            nbVieRestante = _nbVieRestante;
        }

        public override void SeDeplacer()
        {
            throw new NotImplementedException();
        }

        public void AddArme(Arme _arme)
        {

        }

        public bool Combattre(List<Guerrier> _ennemis)
        {

            return false;
        }

        public override string ToString()
        {
            return "Le nombre des vies restantes est de :" + nbVieRestante;
        }
    }
}
