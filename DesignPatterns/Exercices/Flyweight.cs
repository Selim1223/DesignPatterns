using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercices
{
    public class OptionVehicule
    {
        protected string nom;
        protected string description;
        protected float prixStandard;

        public OptionVehicule(string nom, float prixStandard)
        {
            this.nom = nom;
            this.prixStandard = prixStandard;
        }

        public void Affiche(float prixStandard)
        {
            float prixDeVente = this.prixStandard + prixStandard;
            Console.WriteLine("Nom : " + this.nom + " ; Prix de vente : " + prixDeVente);
        }

        public string GetNom()
        {
            return nom;
        }
    }

    public class FabriqueOption
    {
        Dictionary<string, OptionVehicule> options = new Dictionary<string,OptionVehicule>();

        public OptionVehicule GetOption(string nom, float prix)
        {
            if (options.ContainsKey(nom))
                return options[nom];

            OptionVehicule nouvelleOption = new OptionVehicule(nom, prix);
            options.Add(nom,nouvelleOption);
            return nouvelleOption;
        }
    }

    public class VehiculeCommande
    {
        protected float prixDeVenteOptions;
        Dictionary<string, OptionVehicule> options = new Dictionary<string, OptionVehicule>();

        public VehiculeCommande(float prix = 0)
        {
            this.prixDeVenteOptions = prix;
            Console.WriteLine("Nouveau véhicule ajouté, son prix est de "+prix+ " euros");

        }
        public void AddOption(string nom, float prix, FabriqueOption fabrique)
        {
            OptionVehicule option = fabrique.GetOption(nom, prix);
            options.Add(option.GetNom(), option);
            Console.WriteLine("Nouvelle option ajouté,son prix est de "+prix+ " euros");
        }

        public void AfficheOption()
        {
            foreach (OptionVehicule option in options.Values.ToList())
            {
                option.Affiche(this.prixDeVenteOptions);
            }
        }
    }


}
