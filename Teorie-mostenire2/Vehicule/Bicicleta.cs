using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorie_mostenire2.Vehicule
{
    public class Bicicleta : Vehicule
    {
        private string _ghidon;

        public Bicicleta(string volan, string roti, string motor, string combustibil, string scaune, string usi, string ghidon) : base(volan, roti, motor, combustibil, scaune, usi)
        {
            _ghidon = ghidon;
        }

        public Bicicleta(string atribute) : base(atribute)
        {
            string[] token = atribute.Split(' ');

            _ghidon = token[6];
        }

        public string Ghidon
        {
            get { return _ghidon; }
            set { _ghidon = value; }
        }

        public string BicicletaInfo()
        {
            string text = " ";
            text += "Ghidon " + _ghidon + "\n";
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
            return _ghidon + "," + Volan + "," + Roti + "," + Motor + "," + Combustibil + "," + Scaune + "," + Usi;
        }
    }
}
