using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPukol2
{
    internal class NakladniAuto
    {
       protected string spz;
       protected short nosnost;
       protected short hmotnostnakladu = 0;

        public short HmotnostNakladu
        {
            get
            {
                return hmotnostnakladu;
            }
        }
        public NakladniAuto(string spz, short nosnost)
        {
            this.spz = spz;
            this.nosnost = nosnost;
        }
        public void NalozNaklad(short nalozeni)
        {
            if (nalozeni + hmotnostnakladu > nosnost)
            {
                MessageBox.Show("Nenaložilo se " + (nalozeni + hmotnostnakladu - nosnost) + " tun.");
                hmotnostnakladu = nosnost;
            }
            else
                hmotnostnakladu += nalozeni;
        }
        public void VylozNaklad(short vylozeni)
        {
            if (vylozeni > hmotnostnakladu)
            {
                MessageBox.Show("Chybí " + (vylozeni - hmotnostnakladu).ToString() + " tun písku");
                hmotnostnakladu = 0;
            }
            else hmotnostnakladu -= vylozeni;
        }
        public override string ToString()
        {
            return "Nákladní auto "+spz+" má nosnost "+ nosnost.ToString()+" t a má naloženo "+hmotnostnakladu.ToString()+" t písku";
        }

    }
}
