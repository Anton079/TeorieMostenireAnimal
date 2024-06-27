using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorie_mostenire2.Sucuri
{
    public class Sucuri
    {
        private string _acidulat;
        private string _incolora;
        private string _culoareNegru;
        private string _culoareGalbena;

        public Sucuri(string acidulat, string incolora, string culoareNegru, string culoareGalben)
        {
            _acidulat = acidulat;
            _incolora = incolora;
            _culoareGalbena = culoareGalben;
            _culoareNegru = culoareNegru;
        }

        public Sucuri(string proprietati)
        {
            string[] token = proprietati.Split(',');

            _acidulat = token[0];
            _incolora = token[1];
            _culoareNegru = token[2];
            _culoareGalbena = token[3];
        }

        public string Acidulat
        {
            get { return _acidulat; }
            set { _acidulat = value; }
        }

        public string Incolora
        {
            get { return _incolora; }
            set { _incolora = value; }
        }

        public string CuloareNegru
        {
            get { return _culoareNegru; }
            set { _culoareNegru = value; }
        }

        public string CuloareGalbena
        {
            get { return _culoareGalbena; }
            set { _culoareGalbena = value; }
        }

        public string SucuriInfo()
        {
            string text = " ";
            text += "Acidulat " + _acidulat + "\n";
            text += "Incolora " + _incolora + "\n";
            text += "CuloareNegru " + _culoareNegru + "\n";
            text += "CuloareGalbena " + _culoareGalbena + "\n";
            return text;
        }

        public string ToSave()
        {
            return _acidulat + "," + _incolora + "," + _culoareGalbena + "," + _culoareNegru;
        }
    }
}
