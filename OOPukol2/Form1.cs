using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPukol2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NakladniAuto auto = new NakladniAuto(maskedTextBox1.Text, (short)numericUpDown1.Value);
            auto.NalozNaklad((short)numericUpDown2.Value);
            auto.VylozNaklad((short)(numericUpDown3.Value));
            label5.Text= auto.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vytvořte třídu NakladniAuto, která bude obsahovat:\r\nSoukromý atribut spz\r\nSoukromý atribut nosnost (v tunách),\r\nVlastnost Hmotnost nákladu (v tunách) – pouze pro čtení inicializovaný na 0\r\nTřída bude obsahovat jediný konstruktor\r\nNastaví spz a nosnost na požadované hodnoty\r\nTřída bude obsahovat metody:\r\nNalozNaklad – která naloží požadovaný náklad a nedovolí přesáhnout nosnost.\r\nPokud při naložení celého nákladu je překročena nosnost, metoda umožní naložit\r\nnáklad částečně, do výše nosnosti a navíc vypíše zprávu, kolik tun nákladu nebylo\r\nnaloženo.\r\nVylozNaklad – vyloží požadovanou hmotnost nákladu a nedovolí vyložit více, než\r\nje naloženo. Pokud je požadováno více, metoda vyloží veškerý náklad a vypíše,\r\nkolik tun požadovaného písku chybí.\r\nPřepsanou metodu ToString – vrátí text ve tvaru „Nákladní auto ABC123 má\r\nnosnost 3 t a má naloženo 1,5 t “.");
        }
    }
}
