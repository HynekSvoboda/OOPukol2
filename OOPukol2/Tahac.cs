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
        public override string ToString()
        {
            return "Nákladní auto " + spz + " má nosnost " + nosnost.ToString() + " t a má naloženo " + hmotnostnakladu.ToString() + " t písku";
        }
    }
}