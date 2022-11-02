using AplikacjaInzynierka.Badanie.Odtwarzanie;
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

        PlaySound player;
        List<Panel> panelList = new List<Panel>();
        int index;
        public FormStartowy()
        {
            InitializeComponent();
        }

        private void FormStartowy_Load(object sender, EventArgs e)
        {
            panelList.Add(panelStart);
            panelList.Add(panelInstruction);
            panelList.Add(panelUserTest);
            panelList.Add(panelReady);
            panelList.Add(panelResearch1);
            panelList.Add(panelResearch2);
            panelList.Add(panelResearch3);
            foreach (Panel p in panelList)
            {
                p.Hide();
            }
            panelStart.Show();
            label1.Text = index.ToString();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (index < panelList.Count - 1)
            {
                //panelList[index].Hide();
                //index++;
                panelList[++index].Show();
            }
            label1.Text = index.ToString();
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                panelList[index].Hide();
                index--;
                panelList[index].Show();
            }
            label1.Text = index.ToString();
        }

        private void comboBoxResearch1FirstQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string r1FQresult = comboBoxResearch1FirstQuestion.SelectedItem.ToString();
            label1.Text=r1FQresult; //dziala!
        }

        private void buttonResearch1StartRecordingA_Click(object sender, EventArgs e)
        {
            player = new PlaySound("nagranie1.wav");
            player.Play();
        }

        private void buttonResearch1StopRecordingA_Click(object sender, EventArgs e)
        {
            player.Stop();
        }
    }
}
