using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorie_mostenire2.Animale
{
    public class Pasare : Animale
    {
        private string _tipAripi;
        private string _dimensiuneCioc;

        public Pasare(string tipAripi, string dimensiuneCioc, string picioare, string coada, string nas, string blana, string aripi) : base(picioare, coada, nas, blana, aripi)
        {
            _tipAripi = tipAripi;
            _dimensiuneCioc = dimensiuneCioc;
        }



        public Pasare(string atribute) : base(atribute)
        {
            string[] token = atribute.Split(' ');

            TipAripi = token[5];
            DimensiuneCioc = token[6];
        }

        public string TipAripi
        {
            get { return _tipAripi; }
            set { _tipAripi = value; }
        }

        public string DimensiuneCioc
        {
            get { return _dimensiuneCioc; }
            set { _dimensiuneCioc = value; }
        }

        public string PasareInfo()
        {
            string text = " ";
            text += "Tip aripi: " + _tipAripi + "\n";
            text += "Dimensiune cioc: " + _dimensiuneCioc + "\n";
            return text;
        }

        public string ToSave()
        {
            return _tipAripi + "," + _dimensiuneCioc;
        }
    }
}
