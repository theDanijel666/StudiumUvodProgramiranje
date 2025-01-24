using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prozor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gumb_Click(object sender, EventArgs e)
        {
            labela.Text = "Hvala na kliku :)";
        }

        private void gumb_MouseEnter(object sender, EventArgs e)
        {
            gumb.Text = "Sad klikni ;)";
        }

        private void gumb_MouseLeave(object sender, EventArgs e)
        {
            gumb.Text = "Vrati se...";
        }

        private void milanovic_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hvala na glasanju :)");
        }

        private void primorac_MouseEnter(object sender, EventArgs e)
        {
            primorac.Left += 105;
            if (primorac.Left > 400) primorac.Left = 10;
        }
    }
}
