using AplikacjaInzynierka.Badanie.Zapisywanie;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacjaInzynierka.Wprowadzenie
{
    public partial class FormStartowy : Form
    {
        public char[] wynik;
        public char wynikt;
        public int a = -1;
        public FormStartowy()
        {
            InitializeComponent();
            instrukcja.Hide();
            dalej.Hide();
            odtworz1.Hide();
            odtworz2.Hide();
            checkBox1.Hide();
            checkBox2.Hide();
            nagranie1.Hide();
            nagranie2.Hide();
            test.Hide();
            glosowanie();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void WprowadzeniePrzycisk_Click(object sender, EventArgs e)
        {
             a = int.Parse(kod.Text);
             if (a > 0)
             {
                 WprowadzenieTekst.Text = a.ToString();
             }
             else
             {
                MessageBox.Show("Wprowadź kod");
             }
            WprowadzenieTekst.Hide();
            kod.Hide();
            WprowadzeniePrzycisk.Hide();
            instrukcja.Show();
            dalej.Show();
        }

        private void dalej_Click(object sender, EventArgs e)
        {
            instrukcja.Hide();
            test.Show();
            odtworz1.Show();
            odtworz2.Show();
            checkBox1.Show();
            checkBox2.Show();
            nagranie1.Show();
            nagranie2.Show();
            //playSimpleSound("sinus_2s.wav");
        }
        private void odtworz1_Click(object sender, EventArgs e)
        {
            playSimpleSound("sinus_2s.wav");
        }

        private void odtworz2_Click(object sender, EventArgs e)
        {
            playSimpleSound("sinus_1s.wav");
        }

        private void playSimpleSound(string plik)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\frane\Desktop\praca inżynierska 19.10.22\baza nagrań\prosty sinus\"+ plik);
            simpleSound.Play();
        }

        private void glosowanie()
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            
            checkBox1.CheckedChanged += CheckBox1_CheckedChanged;
            checkBox2.CheckedChanged += CheckBox2_CheckedChanged;
        }

        private void CheckBox1_CheckedChanged(object? sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
                wynikt = '0';
                wynikt = '1';
            }
        }
        private void CheckBox2_CheckedChanged(object? sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;

            }
        }

      

       
    }
}
