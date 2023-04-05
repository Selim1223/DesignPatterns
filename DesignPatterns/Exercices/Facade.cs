using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercices
{
    public class RepriseVehicule
    {
        public int GenerateRandomPrice()
        {
            Random random = new Random();
            int price = random.Next(100, 10000); 
            price = (int)(Math.Round((double)price / 1000) * 1000); 
            return price;
        }
    }

    public class GestionDocument
    {
        public string display(string name, float price)
        {
            return name + " " + price + " euros";
        }
    }

    public class Catalogue
    {
        public List<string> getCarNames()
        {
            return new List<string>() {
                "Opel Corsa",
                "Peugot 208",
                "Dacia Sandero 3",
                "rodius ssangyong",
                "Ford T",
                "Toyota Camry",
                "Honda Accord",
                "Citroen C3",
                "Volkswagen Coccinelle",
                "Honda Civic",
                "Volkswagen Passat",
                "Volkswagen Golf",
                "Renault Clio V",
                "Fiat 500",
                "Renault Megane IV",
                "Kia Niro",
                "BMW X1",
                "Audi A3",
                "Volvo Xc40"

            };
        }
    }
    public class WebServiceAuto
    {
        public void showCarPrice()
        {
            List<string> cars = new Catalogue().getCarNames();
            Console.WriteLine("Ecrivez la marque et le modèle du véhicule : ");
            string name = Console.ReadLine();
            if (!cars.Contains(name))
            {
                Console.WriteLine("La voiture " + name + " n'est pas disponible");
                return;
            }
            int price = new RepriseVehicule().GenerateRandomPrice();
            string view = new GestionDocument().display(name, price);
            Console.WriteLine(view);
        }
    }


}
