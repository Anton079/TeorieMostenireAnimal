using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorie_mostenire2.Vehicule
{
    public class Tren : Vehicule
    {
        private string _sine;
        private string _curent;

        public Tren(string volan, string roti, string motor, string combustibil, string scaune, string usi, string sine, string curent) : base(volan, roti, motor, combustibil, scaune, usi)
        {
            _sine = sine;
            _curent = curent;
        }

        public Tren(string atribute) : base(atribute)
        {
            string[] token = atribute.Split(' ');

            _sine = token[6];
            _curent = token[7];
        }

        public string Sine
        {
            get { return _sine; }
            set { _sine = value; }
        }

        public string Curent
        {
            get { return _curent; }
            set { _curent = value; }
        }

        public string TrenInfo()
        {
            string text = " ";
            text += "Sine " + _sine + "\n";
            text += "Curent " + _curent + "\n";
            text += "Volan " + Volan + "\n";
            text += "Roti " + Roti + "\n";
            text += "Motor " + Motor + "\n";
            text += "Combustibil " + Combustibil + "\n";
            text += "Scaune " + Scaune + "\n";
            text += "Usi " + Usi + "\n";
            return text;
        }

        public string ToSave()
        {
            return _sine + "," + _curent + "," + Volan + "," + Roti + "," + Motor + "," + Combustibil + "," + Scaune + "," + Usi;
        }


    }
}
