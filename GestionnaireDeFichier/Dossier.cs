using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireDeFichier
{
    public class Dossier : Element, IReferencable
    {
        List<Element> Contenu = new List<Element>();
        public Dossier()
        {
        }
        public List<Element> getContenu()
        {
            return Contenu;
        }
        public void ajouterElement(Element element)
        {
            Contenu.Add(element);
        }
        public void retirerElement(Element element)
        {
            Contenu.Remove(element);
        }
        public override int getTaille()
        {
            int Taille = 0;
            foreach (Element element in Contenu)
            {               
                Taille = Taille + element.getTaille();
            }
            return Taille;
        }
    }
}
