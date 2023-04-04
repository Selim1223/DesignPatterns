using System;
using System.Collections.Generic;
using DesignPatterns.Exercices;

namespace DesignPatterns
{
    internal class Program
    {
        public static int nbAutos = 3;
        public static int nbScooters = 2;

        static void Main(string[] args)
        {
            //// Pattern Singleton
            //LiasseVierge doc1 = LiasseVierge.getInstance();
            //LiasseVierge doc2 = LiasseVierge.getInstance();
            //if (doc1 == doc2)
            //{
            //    Console.WriteLine("singleton works, both variables contain the same instance.");
            //}
            //else
            //{
            //    Console.WriteLine("singleton failed, variables contain different instances.");
            //}

            //// Pattern Strategy
            //var dessin = new Dessin(new DessinUnVehiculeLigne());
            //dessin = new Dessin(new DessinTroisVehiculesLigne());


            //// Pattern Adapter
            //Document doc = new DocumentHtml();
            //doc.setContenu("test");
            //doc.dessine();
            //doc.imprime();
            //ComposantPdf composantpdf = new ComposantPdf();
            //Document doc2 = new DocumentPdf(composantpdf);
            //doc2.setContenu("test");
            //doc2.dessine();
            //doc2.imprime();

            //// Pattern Decorator
            //VueVehiculeDecorateur vueVehicule = new VueVehiculeDecorateur();
            //MarqueDecorateur marqueDecorateur = new MarqueDecorateur(vueVehicule, "Peugeot");
            //ModeleDecorateur modeleDecorateur = new ModeleDecorateur(marqueDecorateur, "208");
            //Decorateur vueVehiculeDecorateur = modeleDecorateur;
            //vueVehiculeDecorateur.Affiche();

            //// Pattern State
            //StateCommande commande = new StateCommande();
            //commande.AjouteProduit(new Produit("véhicule 1"));
            //commande.AjouteProduit(new Produit("Accessoire 2"));
            //commande.Affiche();
            //commande.EtatSuivant();
            //commande.AjouteProduit(new Produit("Accessoire 3"));
            //commande.Efface();
            //commande.Affiche();

            //StateCommande commande2 = new StateCommande();
            //commande2.AjouteProduit(new Produit("véhicule 11"));
            //commande2.AjouteProduit(new Produit("Accessoire 21"));
            //commande2.Affiche();
            //commande2.EtatSuivant();
            //commande2.Affiche();
            //commande2.EtatSuivant();
            //commande2.Efface();
            //commande2.Affiche();

            /// Pattern Proxy
            //Console.WriteLine("Film pas encore lancer : affichage de la photo ");
            //AnimationProxy animation = new AnimationProxy();
            //animation.Dessine();
            //Console.WriteLine("Clique sur le modèle");
            //animation.Clique();
            //animation.Dessine();
            //Console.WriteLine("Autre clique sur le modèle");
            //animation.Clique();

            //// Pattern Observer
            //Vehicule vehicule = new Vehicule();
            //VueVehiculeObservateur vueVehiculeObservateur = new VueVehiculeObservateur(vehicule);
            //Console.WriteLine("le prix du véhicule passe à prix 1500 euros");
            //vehicule.setPrix(1500);
            //Console.WriteLine("ajout de l'observateur");
            //vehicule.Ajoute(vueVehiculeObservateur);
            //Console.WriteLine("changement du prix à 5000 euros");
            //vehicule.setPrix(5000);
            //Console.WriteLine("changement de la description");
            //vehicule.setDescription("Belle voiture");

            /// Pattern Bridge


            /// Pattern TemplateMethod
            //var commande = new CommandeFrance();
            //Console.WriteLine("Commande en France pour un montant de 12 euros");
            //commande.setMontantHt(12);
            //commande.calculeMontantTtc();
            //commande.affiche();
            //var commande2 = new CommandeLuxembourg();
            //Console.WriteLine("Commande en Luxembourg pour un montant de 12 euros");
            //commande2.setMontantHt(12);
            //commande2.calculeMontantTtc();
            //commande2.affiche();
        }
    }
}