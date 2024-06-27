using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorie_mostenire2.Sporturi
{
    public class Sporturi
    {
        private string _mingeFotbal;
        private string _crampoane;
        private string _rachetaTenis;
        private string _fileuTenis;
        private string _cosDeBaschet;
        private string _mingeBaschet;
        private string _liniiDeInot;
        private string _costumDeBaie;

        public Sporturi(string mingeFotbal, string crampoane, string rachetaTenis, string fileuTenis, string cosDeBaschet, string mingeBaschet, string liniiDeInot, string costumDeBaie)
        {
            _mingeFotbal = mingeFotbal;
            _crampoane = crampoane;
            _rachetaTenis = rachetaTenis;
            _fileuTenis = fileuTenis;
            _cosDeBaschet = cosDeBaschet;
            _mingeBaschet = mingeBaschet;
            _liniiDeInot = liniiDeInot;
            _costumDeBaie = costumDeBaie;
        }

        public string MingeFotbal
        {
            get { return _mingeFotbal; }
            set { _mingeFotbal = value; }
        }

        public string Crampoane
        {
            get { return _crampoane; }
            set { _crampoane = value; }
        }

        public string RachetaTenis
        {
            get { return _rachetaTenis; }
            set { _rachetaTenis = value; }
        }

        public string FileuTenis
        {
            get { return _fileuTenis; }
            set { _fileuTenis = value; }
        }

        public string CosDeBaschet
        {
            get { return _cosDeBaschet; }
            set { _cosDeBaschet = value; }
        }

        public string MingeBaschet
        {
            get { return _mingeBaschet; }
            set { _mingeBaschet = value; }
        }

        public string LiniiDeInot
        {
            get { return _liniiDeInot; }
            set { _liniiDeInot = value; }
        }

        public string CostumDeBaie
        {
            get { return _costumDeBaie; }
            set { _costumDeBaie = value; }
        }

        public string SportInfo()
        {
            string text = "";
            text += "Minge Fotbal: " + _mingeFotbal + "\n";
            text += "Crampoane: " + _crampoane + "\n";
            text += "Racheta Tenis: " + _rachetaTenis + "\n";
            text += "Fileu Tenis: " + _fileuTenis + "\n";
            text += "Cos de Baschet: " + _cosDeBaschet + "\n";
            text += "Minge Baschet: " + _mingeBaschet + "\n";
            text += "Linii de Inot: " + _liniiDeInot + "\n";
            text += "Costum de Baie: " + _costumDeBaie + "\n";
            return text;
        }
    }
}
