using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercices
{
    public interface Decorateur
    {
        public void Affiche();
    }
    abstract public class ComposantGraphiqueVehicule : Decorateur
    {
        protected Decorateur composant;

        public ComposantGraphiqueVehicule(Decorateur composant)
        {
            this.composant = composant;
        }

        abstract public void Affiche();
    }
    public class VueVehiculeDecorateur : Decorateur
    {
        public void Affiche()
        {
            Console.WriteLine("Voici les infos de votre véhicule");
        }
    }
    public class ModeleDecorateur : ComposantGraphiqueVehicule
    {
        protected string modele;

        public ModeleDecorateur(Decorateur composant, string modele) : base(composant)
        {
            this.modele = modele;
        }

        public override void Affiche()
        {
            this.composant.Affiche();
            AfficheInfosTechniques();
        }

        protected void AfficheInfosTechniques()
        {
            Console.WriteLine("Modèle du véhicule : " + modele);
        }
    }
    public class MarqueDecorateur : ComposantGraphiqueVehicule
    {
        protected string marque;

        public MarqueDecorateur(Decorateur composant, string marque) : base(composant)
        {
            this.marque = marque;
        }

        public void AfficheLogo()
        {
            Console.WriteLine("Marque de véhicule : " + marque);
        }

        public override void Affiche()
        {
            this.composant.Affiche();
            this.AfficheLogo();
        }
    }
}