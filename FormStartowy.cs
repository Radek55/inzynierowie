using AplikacjaInzynierka.Badanie.Zapisywanie;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacjaInzynierka.Wprowadzenie
{
    public partial class FormStartowy : Form
    {
        public FormStartowy()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void WprowadzeniePrzycisk_Click(object sender, EventArgs e)
        {
            ZapisDanych zd = new ZapisDanych();
            zd.ZapisLokalnie();
            UserControl control = new UserControl();
            control.Dock = DockStyle.Fill;
            this.Controls.Add(control);
        }

    }
}
