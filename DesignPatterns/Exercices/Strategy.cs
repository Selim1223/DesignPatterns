using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercices
{
    public interface DessinCatalogue
    {
        public void dessine();
    }

    public class DessinUnVehiculeLigne : DessinCatalogue 
    {
        public void dessine()
        {
            Console.WriteLine("****");
        }
    }

    public class DessinTroisVehiculesLigne : DessinCatalogue
    {
        public void dessine()
        {
            Console.WriteLine("/////");
        }
    }
    class Dessin
    {
        private readonly DessinCatalogue mDessin;

        public Dessin(DessinCatalogue dessin)
        {
            mDessin = dessin;
        }

        public void Dessine()
        {
            mDessin.dessine();
        }
    }
}

