using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorie_mostenire2.Vehicule
{
    public class Masina : Vehicule
    {
        private string _roti;
        private string _oglinzi;
        private string _portbagaj;

        public Masina(string volan, string roti, string motor, string combustibil, string scaune, string usi, string Roti, string Oglinzi, string Portbagaj) : base(volan, roti, motor, combustibil, scaune, usi)
        {
            _roti = Roti;
            _oglinzi = Oglinzi;
            _portbagaj = Portbagaj;
        }

        public Masina(string atribute) : base(atribute)
        {
            string[] token = atribute.Split(' ');

            _roti = token[6];
            _oglinzi = token[7];
            _portbagaj = token[8];
        }

        public string Roti
        {
            get { return _roti; }
            set { _roti = value; }
        }

        public string Oglinzi
        {
            get { return _oglinzi; }
            set { _oglinzi = value; }
        }

        public string Portbagaj
        {
            get { return _portbagaj; }
            set { _portbagaj = value; }
        }

        public string MasinInfo()
        {
            string text = " ";
            text += "Roti " + _roti + "\n";
            text += "Oglinzi " + _oglinzi + "\n";
            text += "Portbagaj " + _portbagaj + "\n";
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
            return _roti + "," + _oglinzi + "," + _portbagaj + "," + Volan + "," + Roti + "," + Motor + "," + Combustibil + "," + Scaune + "," + Usi;
        }
    }
}
