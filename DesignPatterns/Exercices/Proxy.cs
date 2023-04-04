using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercices
{
    internal class VueVehicule
    {
    }

    public interface Animation
    {
        public void Clique();
        public void Dessine();
    }

    public class Film : Animation
    {
        public void Clique()
        {
            Console.WriteLine("Lancement du film");
        }

        public void Dessine()
        {
            Console.WriteLine("Dessin du film");
        }

        public void Charge()
        {
            Console.WriteLine("Chargement du film");
        }

        public void Joue()
        {
            Console.WriteLine("Le film tourne");
        }
    }

    public class AnimationProxy : Animation
    {
        protected Film? film;
        protected string photo = "Le film va bientot se lancer";

        public void Clique()
        {
            if (film == null)
            {
                film = new Film();
                film.Clique();
                film.Charge();
            }
            else
                film.Joue();
        }

        public void Dessine()
        {
            if (film != null)
                film.Dessine();
            else
                this.Dessine(this.photo);
        }
        public void Dessine(string photo)
        {
            Console.WriteLine("photo : "+this.photo);
        }
    }
}
