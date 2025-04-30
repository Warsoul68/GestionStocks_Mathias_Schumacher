using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_BLL
{
    public class Unite
    {
        private string codeUnite;
        private string libelleCU;

        public Unite(string codeUnite, string libelleCU)
        {
            this.codeUnite = codeUnite;
            this.libelleCU = libelleCU;
        }

        public string getCodeUnite()
        {
            return codeUnite;
        }

        public void setCodeUnite(string codeUnite)
        {
            this.codeUnite = codeUnite;
        }

        public string getlibelleCU()
        {
            return libelleCU;
        }

        public void setLibelleCU(string libelleCU)
        {
            this.libelleCU = libelleCU;
        }

        public override string ToString()
        {
            return libelleCU; // ou getlibelleCU()
        }
    }
}
