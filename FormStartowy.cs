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
            podziekowanie.Hide();
            dalej.Hide();
            dalej2.Hide();
            dalej3.Hide();
            dalej4.Hide();
            dalej5.Hide();
            dalej6.Hide();
            dalej7.Hide();
            dalej8.Hide();
            dalej9.Hide();
            dalej10.Hide();
            dalej11.Hide();
            dalej12.Hide();
            zakoncz.Hide();
            odtworz1.Hide();
            odtworz2.Hide();
            checkBox1.Hide();
            checkBox2.Hide();
            nagranie1.Hide();
            nagranie2.Hide();
            badanie1.Hide();
            badanie2.Hide();
            badanie3.Hide();
            badanie4.Hide();
            badanie5.Hide();
            badanie6.Hide();
            badanie7.Hide();
            badanie8.Hide();
            badanie9.Hide();
            badanie10.Hide();  
            test.Hide();
            glosowanie();
           
        }


        private void WprowadzeniePrzycisk_Click(object sender, EventArgs e)
        {
             a = int.Parse(kod.Text);
            wynik[0] = a;
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
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            wynik_zadania = 0;
            dalej.Hide();
            dalej2.Show();
            
        }

        private void dalej2_Click(object sender, EventArgs e)
        {
            instrukcja1.Show();
            test.Hide();
            odtworz1.Hide();
            odtworz2.Hide();
            checkBox1.Hide();
            checkBox2.Hide();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            wynik_zadania = 0;
            nagranie1.Hide();
            nagranie2.Hide();
            MessageBox.Show(string.Join(" ", wynik));
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
            MessageBox.Show(wynik_zadania.ToString());
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
            wynik[1] = wynik_zadania;
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
            wynik[2] = wynik_zadania;
            MessageBox.Show(string.Join(" ", wynik));
            dalej5.Hide();
            dalej6.Show();
        }

        private void dalej6_Click(object sender, EventArgs e)
        {
            badanie3.Hide();
            badanie4.Show();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            wynik[3] = wynik_zadania;
            MessageBox.Show(string.Join(" ", wynik));
            dalej6.Hide();
            dalej7.Show();
        }

        private void dalej7_Click(object sender, EventArgs e)
        {
            badanie4.Hide();
            badanie5.Show();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            wynik[4] = wynik_zadania;
            MessageBox.Show(string.Join(" ", wynik));
            dalej7.Hide();
            dalej8.Show();
        }

        private void dalej8_Click(object sender, EventArgs e)
        {
            badanie5.Hide();
            badanie6.Show();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            wynik[5] = wynik_zadania;
            MessageBox.Show(string.Join(" ", wynik));
            dalej8.Hide();
            dalej9.Show();
        }
        private void dalej9_Click(object sender, EventArgs e)
        {
            badanie6.Hide();
            badanie7.Show();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            wynik[6] = wynik_zadania;
            MessageBox.Show(string.Join(" ", wynik));
            dalej9.Hide();
            dalej10.Show();
        }

        private void dalej10_Click(object sender, EventArgs e)
        {
            badanie7.Hide();
            badanie8.Show();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            wynik[7] = wynik_zadania;
            MessageBox.Show(string.Join(" ", wynik));
            dalej10.Hide();
            dalej11.Show();
        }

        private void dalej11_Click(object sender, EventArgs e)
        {
            badanie8.Hide();
            badanie9.Show();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            wynik[8] = wynik_zadania;
            MessageBox.Show(string.Join(" ", wynik));
            dalej11.Hide();
            dalej12.Show();
        }

        private void dalej12_Click(object sender, EventArgs e)
        {
            badanie9.Hide();
            badanie10.Show();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            wynik[9] = wynik_zadania;
            MessageBox.Show(string.Join(" ", wynik));
            dalej12.Hide();
            zakoncz.Show();
        }

        private void zakoncz_Click(object sender, EventArgs e)
        {
            wynik[10] = wynik_zadania;
            zakoncz.Hide();
            badanie10.Hide();
            odtworz1.Hide();
            odtworz2.Hide();
            checkBox1.Hide();
            checkBox2.Hide();
            nagranie1.Hide();
            nagranie2.Hide();
            podziekowanie.Show();
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
        
    }
}
