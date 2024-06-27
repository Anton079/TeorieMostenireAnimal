using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorie_mostenire2.Sporturi
{
    public class Inot : Sporturi
    {
        public Inot(string mingeFotbal, string crampoane, string rachetaTenis, string fileuTenis, string cosDeBaschet, string mingeBaschet, string liniiDeInot, string costumDeBaie) : base(mingeFotbal, crampoane, rachetaTenis, fileuTenis, cosDeBaschet, mingeBaschet, liniiDeInot, costumDeBaie)
        {
            base.CostumDeBaie = costumDeBaie;
            base.LiniiDeInot = liniiDeInot;
        }

        public string LiniiDeInot
        {
            get { return LiniiDeInot; }
            set { LiniiDeInot = value; }
        }

        public string CostumDeBaie
        {
            get { return CostumDeBaie; }
            set { CostumDeBaie = value; }
        }

        public string SportInfo()
        {
            string text = "Inot:\n";
            text += $"Linii de Inot: {LiniiDeInot}\n";
            text += $"Costum de Baie: {CostumDeBaie}\n";
            return text;
        }
    }
}

