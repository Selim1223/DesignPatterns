using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DesignPatterns.Exercices
{
    public interface Observateur
    {
        public void Actualise();
    }

    public class Sujet
    {
        protected List<Observateur> observateurs = new List<Observateur>();

        public void Ajoute(Observateur observateur)
        {
            this.observateurs.Add(observateur);
        }

        public void Retire(Observateur observateur)
        {
            this.observateurs.Remove(observateur);
        }

        protected void Notifie()
        {
            foreach (Observateur o in observateurs)
                o.Actualise();
        }
    }

    public class Vehicule : Sujet
    {
        private int prix = 1000;
        private string description = "Voiture pas terrible";

        public void setPrix(int prix)
        {
            this.prix = prix;
            this.Notifie();
        }

        public int getPrix()
        {
            return this.prix;
        }

        public void setDescription(string description)
        {
            this.description = description;
            this.Notifie();
        }

        public string getDescription()
        {
            return this.description;
        }
    }

    public class VueVehiculeObservateur : Observateur
    {
        protected Vehicule sujet;

        public VueVehiculeObservateur(Vehicule sujet)
        {
            this.sujet = sujet;

            Redessine();
        }

        public void Actualise()
        {
            Redessine();
        }

        public void Redessine()
        {
            Console.WriteLine("Prix du véhicule : " + sujet.getPrix() + " euros ;\nDescription du véhicule : " + sujet.getDescription());
        }
    }
}
