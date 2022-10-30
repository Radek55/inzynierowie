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
        public int[] wynik = new int[11];
        public int wynik_zadania = 0;
        public int a = -1;
        public FormStartowy()
        {
            InitializeComponent();
            instrukcja.Hide();
            instrukcja1.Hide();
            dalej.Hide();
            dalej2.Hide();
            dalej3.Hide();
            dalej4.Hide();
            odtworz1.Hide();
            odtworz2.Hide();
            checkBox1.Hide();
            checkBox2.Hide();
            nagranie1.Hide();
            nagranie2.Hide();
            badanie1.Hide();
            badanie2.Hide();
            test.Hide();
            glosowanie();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void WprowadzeniePrzycisk_Click(object sender, EventArgs e)
        {
             a = int.Parse(kod.Text);
            wynik[0] = a;
            MessageBox.Show(wynik[0].ToString());
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
            MessageBox.Show(wynik_zadania.ToString());
            dalej.Hide();
            dalej2.Show();
            
        }

        private void dalej2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(wynik_zadania.ToString());
            instrukcja1.Show();
            test.Hide();
            odtworz1.Hide();
            odtworz2.Hide();
            checkBox1.Hide();
            checkBox2.Hide();
            nagranie1.Hide();
            nagranie2.Hide();
            dalej2.Hide();
            dalej3.Show();
        }

        private void dalej3_Click(object sender, EventArgs e)
        {
            instrukcja1.Hide();
            badanie1.Show();
            odtworz1.Show();
            odtworz2.Show();
            checkBox1.Show();
            checkBox2.Show();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            nagranie1.Show();
            nagranie2.Show();
            wynik[1] = wynik_zadania;
            MessageBox.Show(string.Join(" ", wynik));
            dalej3.Hide();
            dalej4.Show();
        }

        private void dalej4_Click(object sender, EventArgs e)
        {
            badanie1.Hide();
            badanie2.Show();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            wynik[2] = wynik_zadania;
            MessageBox.Show(string.Join(" ", wynik));
            dalej4.Hide();
            dalej5.Show();
        }

        private void dalej5_Click(object sender, EventArgs e)
        {
            badanie2.Hide();
            badanie3.Show();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            wynik[3] = wynik_zadania;
            MessageBox.Show(string.Join(" ", wynik));
        }

        private void odtworz1_Click(object sender, EventArgs e)
        {
            playSimpleSound("sinus_1.7s.wav");
        }

        private void odtworz2_Click(object sender, EventArgs e)
        {
            playSimpleSound("sinus_1.5s.wav");
        }

        private void playSimpleSound(string plik)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\frane\Desktop\praca inżynierska 28.10.22\baza nagrań 2\(stopień 1) prosty sinus\" + plik);
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
                wynik_zadania = 2;
            }
        }
        private void CheckBox2_CheckedChanged(object? sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
                wynik_zadania = 1;

            }
        }

        private void Badanie1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
