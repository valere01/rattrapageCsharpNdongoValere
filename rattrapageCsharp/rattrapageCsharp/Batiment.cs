using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rattrapageCsharp
{
    class Batiment
    {
        private string adresse;

        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }

        // constructeur 1
        public Batiment()
        {
        }

        // constructeur 2
        public Batiment(string adresse)
        {
            this.adresse = adresse;
        }

        // Methode ToString
        public override string ToString()
        {
            return "Adresse du batiment : " + adresse;
        }
    }
}
