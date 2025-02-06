using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_BLL
{
    public class Categorie
    {
        private string codeCategorie;
        private string libelleCC;

        public Categorie(string codeCategorie, string libelleCC)
        {
            this.codeCategorie = codeCategorie;
            this.libelleCC = libelleCC;
        }

        public string getCodeCategorie()
        {
            return codeCategorie;
        }

        public void setCodeCategorie(string codeCategorie)
        {
            this.codeCategorie = codeCategorie;
        }

        public string getLibelleCC()
        {
            return libelleCC;
        }

        public void setLibelleCC(string libelleCC)
        {
            this.libelleCC = libelleCC;
        }
    }
}
