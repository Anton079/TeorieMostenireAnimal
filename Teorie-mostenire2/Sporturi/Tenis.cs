using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorie_mostenire2.Sporturi
{
    internal class Tenis : Sporturi
    {
        public Tenis(string mingeFotbal, string crampoane, string rachetaTenis, string fileuTenis, string cosDeBaschet, string mingeBaschet, string liniiDeInot, string costumDeBaie) : base(mingeFotbal, crampoane, rachetaTenis, fileuTenis, cosDeBaschet, mingeBaschet, liniiDeInot, costumDeBaie)
        {
            base.RachetaTenis = rachetaTenis;
            base.FileuTenis = fileuTenis;
        }

        public string RachetaTenis
        {
            get { return RachetaTenis; }
            set { RachetaTenis = value; }
        }

        public string FileuTenis
        {
            get { return FileuTenis; }
            set { FileuTenis = value; }
        }

        public string SportInfo()
        {
            string text = "Tenis:\n";
            text += $"Racheta Tenis: {base.RachetaTenis}\n";
            text += $"Fileu Tenis: {base.FileuTenis}\n";
            return text;
        }
    }
}
