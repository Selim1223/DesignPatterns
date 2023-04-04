using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Exercices
{
    public interface Document
    {
        public void setContenu(string contenu);

        public void dessine();

        public void imprime();
    }

    public class DocumentHtml : Document
    {
        protected void getContenu()
        {
            Console.WriteLine("getContenu");
        }
        public void setContenu(string contenu)
        {
            Console.WriteLine("setContenu" +" "+ contenu);
        }

        public void dessine()
        {
            Console.WriteLine("dessine");
        }

        public void imprime()
        {
            Console.WriteLine("imprime");
        }
    }

    public class DocumentPdf : Document
    {
        private readonly ComposantPdf outilPdf;

        public DocumentPdf(ComposantPdf composant)
        {
            this.outilPdf = composant;
        }

        public void setContenu(string contenu)
        {
            outilPdf.pdfFixeContenu(contenu);
        }

        public void dessine()
        {
            outilPdf.pdfPrépareAffichage();
            outilPdf.pdfRafraichi();
            outilPdf.pdfTermineAffichage();
        }

        public void imprime()
        {
            outilPdf.pdfEnvoieImprimante();
        }
    }

    public class ComposantPdf
    {
        public void pdfFixeContenu(string contenu)
        {
            Console.WriteLine("pdfFixeContenu" +" "+ contenu);
        }

        public void pdfPrépareAffichage()
        {
            Console.WriteLine("pdfPrépareAffichage");
        }

        public void pdfRafraichi()
        {
            Console.WriteLine("pdfRafraichi");
        }

        public void pdfTermineAffichage()
        {
            Console.WriteLine("pdfTermineAffichage");
        }

        public void pdfEnvoieImprimante()
        {
            Console.WriteLine("pdfEnvoieImprimante");
        }
    }
}
