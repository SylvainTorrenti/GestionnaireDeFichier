using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireDeFichier
{
    public class Fichier : Element , IReferencable
    {
        private int Taille {  get; set; }

        public Fichier()
        {

        }
        public override int getTaille()
        {
            return Taille;
        }
    }
}
