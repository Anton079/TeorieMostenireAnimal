using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorie_mostenire2.Sucuri.Sucuri
{
    public class Cola : Sucuri
    {
        private string _ambalajNegru;

        public Cola(string ambalajNegru, string acidulat, string incolora, string culoareNegru, string culoareGalben) : base(acidulat, incolora, culoareNegru, culoareGalben)
        {
            _ambalajNegru = ambalajNegru;
        }

        public Cola(string proprietati) : base(proprietati)
        {
            string[] token = proprietati.Split(',');

            _ambalajNegru = token[4];
        }

        public string AmbalajNegru
        {
            get { return _ambalajNegru; }
            set { _ambalajNegru = value; }
        }

        public string Acidulat
        {
            get { return base.Acidulat; }
            set { base.Acidulat = value; }
        }

        public string Incolora
        {
            get { return base.Incolora; }
            set { base.Incolora = value; }
        }

        public string CuloareNegru
        {
            get { return base.CuloareNegru; }
            set { base.CuloareNegru = value; }
        }

        public string CuloareGalbena
        {
            get { return base.CuloareGalbena; }
            set { base.CuloareGalbena = value; }
        }

        public string ColaInfo()
        {
            string text = " ";
            text += "Ambalaj negru: " + _ambalajNegru + "\n";
            text += "Acidulat: " + Acidulat + "\n";
            text += "Incolora: " + Incolora + "\n";
            text += "Culoare Negru: " + CuloareNegru + "\n";
            text += "Culoare Galbena: " + CuloareGalbena + "\n";
            return text;
        }

        public string ToSave()
        {
            return _ambalajNegru + "," + Acidulat + "," + Incolora + "," + CuloareNegru + "," + CuloareGalbena;
        }
    }
}
