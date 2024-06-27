using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorie_mostenire2.Animale
{
    public class Peste : Animale
    {
        private string _inotatoare;
        private string _branhii;

        public Peste(string picioare, string coada, string aripi, string nas, string blana, string inotatoare, string branhii) : base(picioare, coada, nas, blana, aripi)
        {
            _inotatoare = inotatoare;
            _branhii = branhii;
        }

        public Peste(string atribute) : base(atribute)
        {
            string[] token = atribute.Split(' ');

            _inotatoare = token[5];
            _branhii = token[6];
        }

        public string Inotatoare
        {
            get { return _inotatoare; }
            set { _inotatoare = value; }
        }

        public string Branhii
        {
            get { return _branhii; }
            set { _branhii = value; }
        }

        public string PesteInfo()
        {
            string text = " ";
            text += "Inotatoare: " + _inotatoare + "\n";
            text += "Branhii: " + _branhii + "\n";
            return text;
        }

        public string ToSave()
        {
            return _inotatoare + "," + _branhii;
        }
    }
}
