using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionnaireDeFichier
{
    public class GestionnaireDeFichier
    {
        public Dossier DossierCourant { get; set; }
        /// <summary>
        /// Constructeur du Gestionnaire De Fichier
        /// </summary>
        /// <param name="dossierCourant"></param>
        public GestionnaireDeFichier(Dossier dossierCourant)
        {
            this.DossierCourant = dossierCourant;
        }
        /// <summary>
        /// Obtenir le dossier courant
        /// </summary>
        /// <returns></returns>
        public Dossier getDossierCourant()
        {
            return this.DossierCourant;
        }
        /// <summary>
        /// Obtenir le contenu du dossier courant
        /// </summary>
        /// <returns></returns>
        public List<Element> getContenuDossier()
        {
            return DossierCourant.getContenu();
        }
        /// <summary>
        /// Pour monter vers le dossier parent
        /// </summary>
        public void monterVersDossierParent()
        {

        }
        /// <summary>
        /// Pour descendre vers le dossier cible enfant
        /// </summary>
        /// <param name="dossierEnfant"></param>
        public void descdendreDansDossierEnfant(Dossier dossierEnfant)
        {
            this.DossierCourant = dossierEnfant;
        }
        /// <summary>
        /// Supprime un element du dossier courant
        /// </summary>
        /// <param name="element"></param>
        public void supprimerElement(Element element)
        {
            getContenuDossier().Remove(element);
        }
        public Fichier creerNouveauFichier()
        {
            Fichier nouveauFichier = new Fichier();
            DossierCourant.getContenu().Add(nouveauFichier);
            return nouveauFichier;
        }
        /// <summary>
        /// Creer un element dans le dossier courant
        /// </summary>
        /// <returns></returns>
        public Dossier creerNouveauDossier()
        {
            Dossier nouveauDossier = new Dossier();
            DossierCourant.getContenu().Add(nouveauDossier);
            return nouveauDossier;
        }
        /// <summary>
        /// Creer un lien dans le dossier courant
        /// </summary>
        /// <param name="referencable"></param>
        /// <returns></returns>
        public Lien creerNouveauLien(IReferencable referencable)
        {
            Lien nouveauLien = new Lien(referencable);
            DossierCourant.getContenu().Add(nouveauLien);
            return nouveauLien;
        }
        /// <summary>
        /// Deplace un element cible vers un dossier cible
        /// </summary>
        /// <param name="element"></param>
        /// <param name="dossierDestination"></param>
        public void deplacerElement(Element element,Dossier dossierDestination) 
        {
            
            dossierDestination.getContenu().Add(element);
        }
    }
}
