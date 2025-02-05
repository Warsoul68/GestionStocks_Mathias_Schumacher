using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_BLL
{
    public class Fabricant
    {
        private int idF;
        private string referenceF;
        private string nomEntreprise;
        private string marque;

        public Fabricant(int idF, string referenceF, string nomEntreprise, string marque)
        {
            this.idF = idF;
            this.referenceF = referenceF;
            this.nomEntreprise = nomEntreprise;
            this.marque = marque;
        }

        public int getIdF()
        {
            return idF;
        }

        public void setIdF(int idF)
        {
            this.idF = idF;
        }

        public string getReferenceF()
        {
            return referenceF;
        }

        public void setReferenceF(string referenceF)
        {
            this.referenceF = referenceF;
        }

        public string getNomEntreprise()
        {
            return nomEntreprise;
        }

        public void setNomEntreprise(string nomEntreprise)
        {
            this.nomEntreprise = nomEntreprise;
        }

        public string getMarque()
        {
            return marque;
        }

        public void setMarque(string marque)
        {
            this.marque = marque;
        }
    }
}

