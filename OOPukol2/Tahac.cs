using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPukol2
{
    internal class Tahac : NakladniAuto
    {
        short nosnostVlečky;

        public Tahac(string spz, short nosnost,short nosnostVlečky) : base (spz,nosnost)
        {
            this.nosnostVlečky = nosnostVlečky;
            base.nosnost += nosnostVlečky;
        }
    }
}