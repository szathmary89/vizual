using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace szamologep
{
    public partial class szamologep : Form
    {
        public szamologep()
        {
            InitializeComponent();
        }

        private void ellenorzes(object sender, CancelEventArgs e)
        {
            double szam;
            bool siker = double.TryParse((sender as TextBox).Text, out szam);
            if (siker == false)
            {
                e.Cancel = true;
                MessageBox.Show("Nem szám!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double szam11;
            double szam22;

            if (!double.TryParse(szam1.Text, out szam11) ||
                !double.TryParse(szam2.Text, out szam22))
                return;


            double eredm = 0;

            if (osztas.Checked)
            {
                if (szam22 == 0)
                {
                    MessageBox.Show("Nullával nem osztunk!");
                } 
                eredm = szam11 / szam22;
            }

            if (kivonas.Checked)
            {
                eredm = szam11 - szam22;
            }

            eredmeny.Text = eredm.ToString();
        }

    }
}
