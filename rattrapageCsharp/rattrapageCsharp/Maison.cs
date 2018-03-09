using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rattrapageCsharp
{
    class Maison : Batiment
    {
        private int nbPieces;

        public int NbPiece
        {
            get { return nbPieces; }
            set { nbPieces = value; }
        }

        // constructeur 1
        public Maison() : base()
        {
        }

        // constructeur 2
        public Maison(string adresse, int nb)
            : base(adresse)
        {
            nbPieces = nb;
        }

        // Methode ToString
        public override string ToString()
        {
            return base.ToString() + " nombre de piéces : " + nbPieces;
        }
    }
}
