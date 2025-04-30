using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_BLL
{
    public class Article
    {
        private string referenceA;
        private string libelleA;
        private string codeUnite;
        private string codeCategorie;
        public int idFabricant;

        public Article(string referenceA, string libelleA, string codeUnite, string codeCategorie, int idFabricant)
        {

            this.referenceA = referenceA;
            this.libelleA = libelleA;
            this.codeUnite = codeUnite;
            this.codeCategorie = codeCategorie;
            this.idFabricant = idFabricant;
        }

        public string getReferenceA()
        {
            return referenceA;
        }

        public void setReferenceA(string referenceA)
        {
            this.referenceA = referenceA;
        }

        public string getLibelleA()
        {
            return libelleA;
        }

        public void setLibelleA(string libelleA)
        {
            this.libelleA = libelleA;
        }

        public string getCodeUnite()
        {
            return codeUnite;
        }

        public void setCodeUnite(string codeUnite)
        {
            this.codeUnite = codeUnite;
        }

        public string getCodeCategorie()
        {
            return codeCategorie;
        }

        public void setCodeCategorie(string codeCategorie)
        {
            this.codeCategorie = codeCategorie;
        }

        public int getIdFabricant()
        {
            return idFabricant;
        }

        public void setIdFabricant(int idFabricant)
        {
            this.idFabricant = idFabricant;
        }
    }
}
