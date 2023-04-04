using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercices
{
    public class StateCommande
    {
        protected IList<Produit> produits = new List<Produit>();
        public IList<Produit> Produits
        {
            get
            {
                return produits;
            }
        }
        protected EtatCommande etatCommande;

        public StateCommande()
        {
            etatCommande = new CommandeEnCours(this);
        }

        public void AjouteProduit(Produit produit)
        {
            etatCommande.AjouteProduit(produit);
        }

        public void RetireProduit(Produit produit)
        {
            etatCommande.RetireProduit(produit);
        }

        public void Efface()
        {
            etatCommande.Efface();
        }

        public void EtatSuivant()
        {
            etatCommande = etatCommande.EtatSuivant();
        }

        public void Affiche()
        {
            Console.WriteLine("Contenu de la commande");
            foreach (Produit produit in produits)
                produit.Affiche();
            Console.WriteLine();
        }
    }

    public abstract class EtatCommande
    {
        protected StateCommande commande;

        public EtatCommande(StateCommande commande)
        {
            this.commande = commande;
        }

        public abstract void AjouteProduit(Produit produit);
        public abstract void Efface();
        public abstract void RetireProduit(Produit produit);
        public abstract EtatCommande EtatSuivant();
    }

    public class CommandeEnCours : EtatCommande
    {
        public CommandeEnCours(StateCommande commande) : base(commande) { }

        public override void AjouteProduit(Produit produit)
        {
            commande.Produits.Add(produit);
        }

        public override void Efface()
        {
            commande.Produits.Clear();
        }

        public override void RetireProduit(Produit produit)
        {
            commande.Produits.Remove(produit);
        }

        public override EtatCommande EtatSuivant()
        {
            Console.WriteLine("Etate Validée");
            return new CommandeValidee(commande);
        }
    }

    public class CommandeValidee : EtatCommande
    {
        public CommandeValidee(StateCommande commande) : base(commande) { }

        public override void AjouteProduit(Produit produit) { }

        public override void Efface()
        {
            commande.Produits.Clear();
        }

        public override void RetireProduit(Produit produit) { }

        public override EtatCommande EtatSuivant()
        {
            Console.WriteLine("Etate Livrée");
            return new CommandeLivree(commande);
        }
    }

    public class CommandeLivree : EtatCommande
    {
        public CommandeLivree(StateCommande commande) : base(commande) { }

        public override void AjouteProduit(Produit produit) { }

        public override void Efface() { }

        public override void RetireProduit(Produit produit) { }

        public override EtatCommande EtatSuivant()
        {
            Console.WriteLine("No Change");
            return this;
        }
    }

    public class Produit
    {
        protected string nom;

        public Produit(string nom)
        {
            this.nom = nom;
        }

        public void Affiche()
        {
            Console.WriteLine("Produit : {0}", nom);
        }
    }
}
