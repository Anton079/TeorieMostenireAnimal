using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorie_mostenire2.Animale
{
    public class Animale
    {
        private string _picioare;
        private string _coada;
        private string _nas;
        private string _blana;
        private string _aripi;

        public Animale(string picioare, string coada, string nas, string blana, string aripi)
        {
            Console.WriteLine("Eu sunt constrcutorul din baza cu 5 parameterii");
            _picioare = picioare;
            _coada = coada;
            _nas = nas;
            _blana = blana;
            _aripi = aripi;
        }

        public Animale(string proprietati)
        {
            Console.WriteLine("Eu sunt constrcutorul din baza cu proprietati");
            string[] token = proprietati.Split(' ');

            _picioare = token[0];
            _coada = token[1];
            _nas = token[2];
            _blana = token[3];
            _aripi = token[4];
        }

        public string Picioare
        {
            get { return _picioare; }
            set { _picioare = value; }
        }

        public string Coada
        {
            get { return _coada; }
            set { _coada = value; }
        }

        public string Nas
        {
            get { return _nas; }
            set { _nas = value; }
        }

        public string Blana
        {
            get { return Blana; }
            set { Blana = value; }
        }

        public string Aripi
        {
            get { return Aripi; }
            set { _aripi = value; }
        }

        public string AnimaleInfo()
        {
            string text = " ";
            text += "Picioare" + _picioare + "\n";
            text += "Coada " + _coada + "\n";
            text += "Nas " + _nas + "\n";
            text += "Blana " + _blana + "\n";
            text += "Aripi " + _aripi + "\n";
            return text;
        }

        public string ToSave()
        {
            return _picioare + "," + _coada + "," + _nas + "," + _blana + "," + _aripi;
        }
    }
}
