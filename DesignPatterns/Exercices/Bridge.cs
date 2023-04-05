using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercices
{
    public interface FormulaireImpl
    {
        public void DessineTexte();

        public void GereZoneSaisie();
    }
    public class FormHtmlImpl : FormulaireImpl
    { 
        public void DessineTexte()
        {
            Console.WriteLine("Dessine texte HTML");
        }

        public void GereZoneSaisie()
        {
            Console.WriteLine("Zone saisie HTML");

        }
    }
    public class FormAppleImpl : FormulaireImpl
    {
        public void DessineTexte()
        {
            Console.WriteLine("Dessine texte Apple");
        }

        public void GereZoneSaisie()
        {
            Console.WriteLine("Zone saisie HTML");

        }
    }

    abstract public class FormulaireImmatriculation
    {
        protected string nom;
        protected string pays;
        protected FormulaireImpl form;

        protected FormulaireImmatriculation(FormulaireImpl form)
        {
            this.form = form;
        }

        public void Affiche()
        {
            form.DessineTexte();
            form.GereZoneSaisie();
        }

        public string GenereDocument()
        {
            if (this.ControleSaisie())
                return "Voici votre immatriculation : " + this.CreerRandomImmatriculation();
            return "formulaire non crée : une erreur est survenue ";
        }

        public void UtilisateurInfos(string nom, string pays)
        {
            this.nom = nom;
            this.pays = pays;
        }

        abstract public bool ControleSaisie();

        private string CreerRandomImmatriculation()
        {
            string immatriculation = "";

            // Générer 2 lettres aléatoires
            Random random = new Random();
            char c1 = (char)random.Next('A', 'Z' + 1);
            char c2 = (char)random.Next('A', 'Z' + 1);
            immatriculation += c1.ToString() + c2.ToString();

            // Générer 3 chiffres aléatoires
            int num1 = random.Next(0, 10);
            int num2 = random.Next(0, 10);
            int num3 = random.Next(0, 10);
            immatriculation += num1.ToString() + num2.ToString() + num3.ToString();

            // Générer 2 lettres aléatoires
            char c3 = (char)random.Next('A', 'Z' + 1);
            char c4 = (char)random.Next('A', 'Z' + 1);
            immatriculation += c3.ToString() + c4.ToString();

            return immatriculation;
        }
    }
    public class FormImmatriculationLuxembourg : FormulaireImmatriculation
    {
        public FormImmatriculationLuxembourg(FormulaireImpl form) : base(form)
        {

        }

        public override bool ControleSaisie()
        {
            return this.pays == "luxembourg";
        }
    }

    public class FormImmatriculationFrance : FormulaireImmatriculation
    {
        public FormImmatriculationFrance(FormulaireImpl form) : base(form)
        {

        }

        public override bool ControleSaisie()
        {
            return this.pays == "france";
        }
    }
}
