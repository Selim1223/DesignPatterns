using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DesignPatterns.Exercices
{
    public class LiasseVierge
    {
        private LiasseVierge() { }

        private static LiasseVierge instance = null;
        private List<string> liasseDocuments = new List<string>();

        public static LiasseVierge getInstance()
        {
            if (instance == null)
            {
                instance = new LiasseVierge();
            }

            return instance;
        }

        public void Ajoute(string document)
        {
            liasseDocuments.Add(document);
        }

        public void Retire(string document)
        {
            liasseDocuments.Remove(document);
        }
    }
}
