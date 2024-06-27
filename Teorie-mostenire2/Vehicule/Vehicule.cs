using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorie_mostenire2.Vehicule
{
    public class Vehicule
    {
        private string _volan;
        private string _roti;
        private string _motor;
        private string _combustibil;
        private string _scaune;
        private string _usi;

        public Vehicule(string proprietati)
        {
            string[] token = proprietati.Split(',');

            _volan = token[0];
            _roti = token[1];
            _motor = token[2];
            _combustibil = token[3];
            _scaune = token[4];
            _usi = token[5];
        }

        public Vehicule(string volan, string roti, string motor, string combustibil, string scaune, string usi)
        {
            _volan = volan;
            _roti = roti;
            _motor = motor;
            _combustibil = combustibil;
            _scaune = scaune;
            _usi = usi;
        }

        public string Volan
        {
            get { return _volan; }
            set { _volan = value; }
        }

        public string Roti
        {
            get { return _roti; }
            set { _roti = value; }
        }

        public string Motor
        {
            get { return _motor; }
            set { _motor = value; }
        }

        public string Combustibil
        {
            get { return _combustibil; }
            set { _combustibil = value; }
        }

        public string Scaune
        {
            get { return _scaune; }
            set { _scaune = value; }
        }

        public string Usi
        {
            get { return _usi; }
            set { _usi = value; }
        }

        public string VehiculInfo()
        {
            string text = " ";
            text += "Volan " + _volan + "\n";
            text += "Roti " + _roti + "\n";
            text += "Motor " + _motor + "\n";
            text += "Combustibil " + _combustibil + "\n";
            text += "Scaune " + _scaune + "\n";
            text += "Usi " + _usi + "\n";
            return text;
        }

        public string ToSave()
        {
            return _volan + "," + _roti + "," + _motor + "," + _combustibil + "," + _scaune + "," + _usi;
        }
    }
}
