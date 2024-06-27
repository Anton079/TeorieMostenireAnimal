using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorie_mostenire2.Animale
{
    public class Vulpea : Animale
    {
        private string _tipBlana;
        private string _lungimeCoada;

        public Vulpea(string tipBlana, string lungimeCoada, string picioare, string coada, string nas, string blana, string aripi) : base(picioare, coada, nas, blana, aripi)
        {
            _tipBlana = tipBlana;
            _lungimeCoada = lungimeCoada;
        }

        public Vulpea(string atribute) : base(atribute)
        {
            string[] token = atribute.Split(' ');

            _tipBlana = token[5];
            _lungimeCoada = token[6];
        }

        public string TipBlana
        {
            get { return _tipBlana; }
            set { _tipBlana = value; }
        }

        public string LungimeCoada
        {
            get { return _lungimeCoada; }
            set { _lungimeCoada = value; }
        }

        public string VulpeaInfo()
        {
            string text = " ";
            text += "Tip blană: " + _tipBlana + "\n";
            text += "Lungime coadă: " + _lungimeCoada + "\n";
            return text;
        }

        public string ToSave()
        {
            return _tipBlana + "," + _lungimeCoada;
        }
    }
}
