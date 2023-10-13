using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireDeFichier
{
    public class Lien : Element
    {
        private IReferencable referencable { get; set; }
        public Lien(IReferencable referencable)
        {
            this.referencable = referencable;
        }
        public override int getTaille()
        {
            return 0;
        }
    }
}
