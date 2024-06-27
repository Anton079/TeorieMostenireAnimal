using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorie_mostenire2.Sporturi
{
    public class Bashet : Sporturi
    {
        public Bashet(string mingeFotbal, string crampoane, string rachetaTenis, string fileuTenis, string cosDeBaschet, string mingeBaschet, string liniiDeInot, string costumDeBaie) : base(mingeFotbal, crampoane, rachetaTenis, fileuTenis, cosDeBaschet, mingeBaschet, liniiDeInot, costumDeBaie)
        {
            base.MingeBaschet = mingeBaschet;
            base.CosDeBaschet = cosDeBaschet;
        }

        public string MingeBaschet
        {
            get { return MingeBaschet; }
            set { MingeBaschet = value; }
        }

        public string CosDeBaschet
        {
            get { return CosDeBaschet; }
            set { CosDeBaschet = value; }
        }

        public string SportInfo()
        {
            string text = " ";
            text += $"Minge Baschet: {base.MingeBaschet}\n";
            text += $"Cos de Baschet: {base.CosDeBaschet}\n";
            return text;
        }
    }
}
