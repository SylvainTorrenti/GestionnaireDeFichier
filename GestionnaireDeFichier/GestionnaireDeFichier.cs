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
        /// <returns>le dossier courant</returns>
        public Dossier getDossierCourant()
        {
            return this.DossierCourant;
        }
        /// <summary>
        /// Obtenir le contenu du dossier courant
        /// </summary>
        /// <returns>La liste des element contenu dans le dossier courant</returns>
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
        /// <param name="dossierEnfant">Le dossier cible enfant du dossier courant</param>
        public void descdendreDansDossierEnfant(Dossier dossierEnfant)
        {
            this.DossierCourant = dossierEnfant;
        }
        /// <summary>
        /// Supprime un element du dossier courant
        /// </summary>
        /// <param name="element">element à supprimer</param>
        public void supprimerElement(Element element)
        {
            getContenuDossier().Remove(element);
        }
        /// <summary>
        /// Creer un nouveau fichier
        /// </summary>
        /// <returns>Le fichier creer</returns>
        public Fichier creerNouveauFichier()
        {
            Fichier nouveauFichier = new Fichier();
            DossierCourant.getContenu().Add(nouveauFichier);
            return nouveauFichier;
        }
        /// <summary>
        /// Creer un element dans le dossier courant
        /// </summary>
        /// <returns>dossier créé</returns>
        public Dossier creerNouveauDossier()
        {
            Dossier nouveauDossier = new Dossier();
            DossierCourant.getContenu().Add(nouveauDossier);
            return nouveauDossier;
        }
        /// <summary>
        /// Creer un lien dans le dossier courant
        /// </summary>
        /// <param name="referencable">element qui est refrençable</param>
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
        /// <param name="element">element à depalcer</param>
        /// <param name="dossierDestination">dossier de destination</param>
        public void deplacerElement(Element element,Dossier dossierDestination) 
        {
            
            dossierDestination.getContenu().Add(element);
        }
    }
}
