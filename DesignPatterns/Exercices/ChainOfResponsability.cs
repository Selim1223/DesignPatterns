using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercices
{
    abstract public class ObjetBase
    {
        protected ObjetBase suivant;

        public ObjetBase(ObjetBase suivant = null)
        {
            this.suivant = suivant;
        }
        abstract protected string? getDescription();

        private string DescriptionParDefaut()
        {
            return "Description par defaut";
        }

        public string DonneDescription()
        {
            string resultat = this.getDescription();
            if (resultat != null)
                return resultat;
            if (suivant != null)
                return suivant.DonneDescription();
            else
                return this.DescriptionParDefaut();
        }
    }

    public class VehiculeChainOfRes : ObjetBase
    {
        private string nom;
        public VehiculeChainOfRes(string? nom, ObjetBase suivant = null) : base(suivant)
        {
            this.nom = nom;
        }

        protected override string? getDescription()
        {
            if (this.nom == null)
                return null;
            return "Vehicule : " + this.nom;
        }
    }

    public class ModeleChainOfRes : ObjetBase
    {
        private string modele;
        public ModeleChainOfRes(string? modele, ObjetBase suivant = null) : base(suivant)
        {
            this.modele = modele;
        }

        protected override string? getDescription()
        {
            if (this.modele == null)
                return null;
            return "Modele : " + this.modele;
        }
    }
    public class MarqueChainOfRes : ObjetBase
    {
        private string marque;
        public MarqueChainOfRes(string? marque, ObjetBase suivant = null) : base(suivant)
        {
            this.marque = marque;
        }

        protected override string? getDescription()
        {
            if (this.marque == null)
                return null;
            return "Marque : " + this.marque;
        }
    }

}
