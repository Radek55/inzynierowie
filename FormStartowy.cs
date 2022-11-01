using AplikacjaInzynierka.Badanie.Zapisywanie;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
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
        ZapisDanych zapis = new();
        public int[] wynik = new int[11];
        public int wynik_zadania = 0;
        public int a = -1;
        public int numer;
        public Dictionary<int, string> numery_nagran = new(); // słownik gdzie klucze to numery nagrań a wartości stopień i nagranie na stopniu (1 do 3)
        public Dictionary<string, int> slownik_koncowy = new();
        public int[] indeksy = new int[11]; // numery wykorzystanych nagrań, indeksy[0] to badanie testowe (nagranie nr 3)
        public int[] nagrania = Enumerable.Range(4,27).ToArray(); // lista numerów nagrań, może się zmienić bo nie wiem czy porównywać zawsze z sinusem tej samej długości, narazie lista bez prostych sinusów



        public FormStartowy()
        {
            StworzSlownik();
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
            OdtworzBadanie.Hide(); 
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
            Glosowanie();
           
        }


        private void WprowadzeniePrzycisk_Click(object sender, EventArgs e)
        {

            a = int.Parse(kod.Text);
            wynik[0] = a;
            indeksy[0] = 3;
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

        private void Dalej_Click(object sender, EventArgs e)
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

        private void Dalej2_Click(object sender, EventArgs e)
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
            //MessageBox.Show(string.Join(" ", wynik));
            dalej2.Hide();
            dalej3.Show();
        }

        private void Dalej3_Click(object sender, EventArgs e)
        {
            numer = NumerNagrania();
            indeksy[1] = numer;
            instrukcja1.Hide();
            badanie1.Show();
            odtworz1.Show();
            OdtworzBadanie.Show();
            checkBox1.Show();
            checkBox2.Show();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            nagranie1.Show();
            nagranie2.Show();
            //MessageBox.Show(wynik_zadania.ToString());
            //MessageBox.Show(string.Join(" ", wynik));
            //MessageBox.Show(numer.ToString());
            dalej3.Hide();
            dalej4.Show();
        }

        private void Dalej4_Click(object sender, EventArgs e)
        {
            numer = NumerNagrania();
            indeksy[2] = numer;
            badanie1.Hide();
            badanie2.Show();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            wynik[1] = wynik_zadania;
            //MessageBox.Show(string.Join(" ", wynik));
            //MessageBox.Show(numer.ToString());
            dalej4.Hide();
            dalej5.Show();
        }

        private void Dalej5_Click(object sender, EventArgs e)
        {
            numer = NumerNagrania();
            indeksy[3] = numer;
            badanie2.Hide();
            badanie3.Show();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            wynik[2] = wynik_zadania;
            //MessageBox.Show(string.Join(" ", wynik));
            //MessageBox.Show(numer.ToString());
            dalej5.Hide();
            dalej6.Show();
        }

        private void Dalej6_Click(object sender, EventArgs e)
        {
            numer = NumerNagrania();
            indeksy[4] = numer;
            badanie3.Hide();
            badanie4.Show();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            wynik[3] = wynik_zadania;
            //MessageBox.Show(string.Join(" ", wynik));
            //MessageBox.Show(numer.ToString());
            dalej6.Hide();
            dalej7.Show();
        }

        private void Dalej7_Click(object sender, EventArgs e)
        {
            numer = NumerNagrania();
            indeksy[5] = numer;
            badanie4.Hide();
            badanie5.Show();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            wynik[4] = wynik_zadania;
            //MessageBox.Show(string.Join(" ", wynik));
            //MessageBox.Show(numer.ToString());
            dalej7.Hide();
            dalej8.Show();
        }

        private void Dalej8_Click(object sender, EventArgs e)
        {
            numer = NumerNagrania();
            indeksy[6] = numer;
            badanie5.Hide();
            badanie6.Show();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            wynik[5] = wynik_zadania;
            //MessageBox.Show(string.Join(" ", wynik));
            //MessageBox.Show(numer.ToString());
            dalej8.Hide();
            dalej9.Show();
        }
        private void Dalej9_Click(object sender, EventArgs e)
        {
            numer = NumerNagrania();
            indeksy[7] = numer;
            badanie6.Hide();
            badanie7.Show();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            wynik[6] = wynik_zadania;
            //MessageBox.Show(string.Join(" ", wynik));
            //MessageBox.Show(numer.ToString());
            dalej9.Hide();
            dalej10.Show();
        }

        private void Dalej10_Click(object sender, EventArgs e)
        {
            numer = NumerNagrania();
            indeksy[8] = numer;
            badanie7.Hide();
            badanie8.Show();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            wynik[7] = wynik_zadania;
            //MessageBox.Show(string.Join(" ", wynik));
            //MessageBox.Show(numer.ToString());
            dalej10.Hide();
            dalej11.Show();
        }

        private void Dalej11_Click(object sender, EventArgs e)
        {
            numer = NumerNagrania();
            indeksy[9] = numer;
            badanie8.Hide();
            badanie9.Show();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            wynik[8] = wynik_zadania;
            //MessageBox.Show(string.Join(" ", wynik));
            //MessageBox.Show(numer.ToString());
            dalej11.Hide();
            dalej12.Show();
        }

        private void Dalej12_Click(object sender, EventArgs e)
        {
            numer = NumerNagrania();
            indeksy[10] = numer;
            badanie9.Hide();
            badanie10.Show();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            wynik[9] = wynik_zadania;
            //MessageBox.Show(string.Join(" ", wynik));
            dalej12.Hide();
            zakoncz.Show();
        }

        private void Zakoncz_Click(object sender, EventArgs e)
        {
            wynik[10] = wynik_zadania;
            zakoncz.Hide();
            badanie10.Hide();
            odtworz1.Hide();
            OdtworzBadanie.Hide();
            checkBox1.Hide();
            checkBox2.Hide();
            nagranie1.Hide();
            nagranie2.Hide();
            podziekowanie.Show();
            SlownikKoncow();
            zapis.ZapisLokalnie(@"C:\Users\frane\Desktop\praca inżynierska 28.10.22\", wynik[0].ToString(),slownik_koncowy);
        }
        private int NumerNagrania()
        {
            Random random = new();
            int numer = random.Next(4, 30);
            if(nagrania.Contains(numer)){
                nagrania = nagrania.Where(val => val != numer).ToArray();
                return numer;
            }
            else
            {
                return NumerNagrania();
            }
        }

        private void StworzSlownik()
        {
            int[] klucze = Enumerable.Range(1, 30).ToArray();
            var lista = new List<string>();
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 3; j++)
                {
                    lista.Add("s" + i.ToString() + "_n" + j.ToString());
                }
            }
            string[] wartosci = lista.ToArray();
            for (int index = 0; index < klucze.Length; index++)
            {
               numery_nagran.Add(klucze[index], wartosci[index]);
            }
        }

        private void SlownikKoncow()
        {
            for(int i = 0; i < 11; i++)
            {
                slownik_koncowy.Add(numery_nagran[indeksy[i]], wynik[i]);
            }
        }

        private void Odtworz1_Click(object sender, EventArgs e)
        {
            PlaySimpleSound("sinus_1.5s.wav");
        }

        private void Odtworz2_Click(object sender, EventArgs e)
        {
            PlaySimpleSound("sinus_1.7s.wav");
        }

        private void OdtworzBadanie_Click(object sender, EventArgs e)
        {
            PlaySimpleSoundBadanie(numer);
        }

        private static void PlaySimpleSound(string plik)
        {
            SoundPlayer simpleSound = new(@"C:\Users\frane\Desktop\praca inżynierska 28.10.22\baza nagrań 2\(stopień 1) prosty sinus\" + plik);
            simpleSound.Play();
        }

        private static void PlaySimpleSoundBadanie(int numer)
        {
            SoundPlayer simpleSound = new(@"C:\Users\frane\Desktop\praca inżynierska 28.10.22\badanie\" + numer.ToString() + ".wav");
            simpleSound.Play();
        }

        private void Glosowanie()
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
