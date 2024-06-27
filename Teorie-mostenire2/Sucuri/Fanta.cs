using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorie_mostenire2.Sucuri.Sucuri
{
    public class Fanta : Sucuri
    {
        private string _ambalajPortocaliu;

        public Fanta(string ambalajPortocaliu, string acidulat, string incolora, string culoareNegru, string culoareGalben) : base(acidulat, incolora, culoareNegru, culoareGalben)
        {
            _ambalajPortocaliu = ambalajPortocaliu;
        }

        public Fanta(string proprietati) : base(proprietati)
        {
            string[] token = proprietati.Split(',');

            _ambalajPortocaliu = token[4];
        }

        public string AmbalajPortocaliu
        {
            get { return _ambalajPortocaliu; }
            set { _ambalajPortocaliu = value; }
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

        public string FantaInfo()
        {
            string text = " ";
            text += "Ambalaj portocaliu: " + _ambalajPortocaliu + "\n";
            text += "Acidulat: " + Acidulat + "\n";
            text += "Incolora: " + Incolora + "\n";
            text += "Culoare Negru: " + CuloareNegru + "\n";
            text += "Culoare Galbena: " + CuloareGalbena + "\n";
            return text;
        }

        public string ToSave()
        {
            return _ambalajPortocaliu + "," + Acidulat + "," + Incolora + "," + CuloareNegru + "," + CuloareGalbena;
        }
    }
}
