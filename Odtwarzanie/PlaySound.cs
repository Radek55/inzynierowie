using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaInzynierka.Badanie.Odtwarzanie
{
    internal class PlaySound
    {
        private SoundPlayer player;
        public PlaySound(string path)
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            player = new SoundPlayer(projectDirectory + @"\Sounds\" + path);
        }
        public void Play()
        {
            player.Play();
        }
        public void Stop()
        {
            player.Stop();
            player.Dispose();
        }
    }
}
