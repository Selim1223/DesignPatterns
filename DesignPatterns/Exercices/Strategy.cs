using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercices
{
    public interface DessinCatalogue
    {
        public abstract void Dessine();
    }

    public class DessinUnVehiculeLigne : DessinCatalogue 
    {
        public void Dessine()
        {
            Console.WriteLine("****");
        }
    }

    public class DessinTroisVehiculesLigne : DessinCatalogue
    {
        public void Dessine()
        {
            Console.WriteLine("/////");
        }
    }
    public class VueCatalogue
    {
        private readonly DessinCatalogue dessin;

        public VueCatalogue(DessinCatalogue dessin)
        {
            this.dessin = dessin;
        }

        public void Dessine()
        {
            dessin.Dessine();
        }
    }
}

