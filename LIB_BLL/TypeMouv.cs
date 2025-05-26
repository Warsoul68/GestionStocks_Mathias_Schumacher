using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIB_BLL
{
    public class TypeMouv
    {
        private int codeType;
        private string libelleCT;

        public TypeMouv(int codeType, string libelleCT)
        {
            this.codeType = codeType;
            this.libelleCT = libelleCT;
        }

        public int getCodeType()
        {
            return codeType;
        }

        public void setCodeType(int codeType)
        {
            this.codeType = codeType;
        }

        public string getLibelleCT()
        {
            return libelleCT;
        }

        public void setLibelleCT(string libelleCT)
        {
            this.libelleCT = libelleCT;
        }
    }
}
