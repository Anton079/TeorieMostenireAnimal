using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorie_mostenire2.Sucuri.Sucuri
{
    public class Sprite : Sucuri
    {
        private string _ambalajVerde;

        public Sprite(string ambalajVerde, string acidulat, string incolora, string culoareNegru, string culoareGalben) : base(acidulat, incolora, culoareNegru, culoareGalben)
        {
            _ambalajVerde = ambalajVerde;
        }

        public Sprite(string proprietati) : base(proprietati)
        {
            string[] token = proprietati.Split(',');

            _ambalajVerde += token[4];
            Acidulat = token[5];
        }

        public string AmbalajVerde
        {
            get { return _ambalajVerde; }
            set { _ambalajVerde = value; }
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

        public string SpiteInfo()
        {
            string text = " ";
            text += "Ambalaj verde " + _ambalajVerde + "\n";
            text += "Acidulat " + base.Acidulat + "\n";
            text += "Incolora " + base.Incolora + "\n";
            text += "CuloareNegru " + base.CuloareNegru + "\n";
            text += "CuloareGalbena " + base.CuloareGalbena + "\n";
            return text;
        }

        public string ToSave()
        {
            return _ambalajVerde + "," + base.Incolora + "," + base.Acidulat + "," + base.CuloareNegru + "," + base.CuloareGalbena;
        }
    }
}
