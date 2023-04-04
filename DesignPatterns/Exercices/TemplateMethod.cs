using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercices
{
    public abstract class TemplateMethodCommande
    {
        protected double montantHt;
        protected double montantTva;
        protected double montantTtc;

        public void calculeMontantTtc()
        {
            calculeTva();
            montantTtc = montantHt + montantTva;
        }

        protected abstract void calculeTva();

        public void affiche()
        {
            Console.WriteLine("montantHt : " + montantHt + " euros");
            Console.WriteLine("montantTtc : " + montantTtc + " euros");

        }

        public void setMontantHt(double montant)
        {
            montantHt = montant;
        }
    }

    public class CommandeFrance : TemplateMethodCommande
    {
        protected override void calculeTva()
        {
            montantTva = montantHt * 0.196;
        }
    }

    public class CommandeLuxembourg : TemplateMethodCommande
    {
        protected override void calculeTva()
        {
            montantTva = montantHt * 0.15;
        }
    }
}

