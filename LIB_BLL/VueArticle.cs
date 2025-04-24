using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_BLL
{
    public class VueArticle
    {
        private string referenceVa;
        private string libelleVa;
        private string categorieVa;
        private string fabricantVa;
        private string uniteVa;

        public VueArticle(string referenceVa, string libelleVa, string categorieVa, string fabricantVa, string uniteVa)
        {
            this.referenceVa = referenceVa;
            this.libelleVa = libelleVa;
            this.categorieVa = categorieVa;
            this.fabricantVa = fabricantVa;
            this.uniteVa = uniteVa;
        }

        public string getReferenceVa()
        {
            return referenceVa;
        }

        public void setReferenceVa(string referenceVa)
        {
            this.referenceVa = referenceVa;
        }

        public string getLibelleVa()
        {
            return libelleVa;
        }

        public void setLibelleVa(string libelleVa)
        {
            this.libelleVa = libelleVa;
        }

        public string getCategorieVa()
        {
            return categorieVa;
        }

        public void setCategorieVa(string categorieVa)
        {
            this.categorieVa = categorieVa;
        }

        public string getFabricantVa()
        {
            return fabricantVa;
        }

        public void setFabricantVa(string fabricantVa)
        {
            this.fabricantVa = fabricantVa;
        }

        public string getUniteVa()
        {
            return uniteVa;
        }

        public void setUniteVa(string uniteVa)
        {
            this.uniteVa = uniteVa;
        }
    }
}
