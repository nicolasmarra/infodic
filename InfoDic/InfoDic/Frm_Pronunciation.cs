using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;

namespace InfoDic
{
    public partial class Frm_Pronunciation : Form
    {
        SpeechSynthesizer speak = new SpeechSynthesizer();
        public string mot;
        public string definition;
        public int t = 0;
        public Frm_Pronunciation()
        {
            InitializeComponent();
        }

        private void prononcermot()
        {
            speak.Dispose();
            speak = new SpeechSynthesizer();
            speak.SpeakAsync(mot);
        }

        private void prononcerdefinition()
        {
            speak.Dispose();
            speak = new SpeechSynthesizer();
            speak.SpeakAsync(definition);
        }

        private void btn_fermer_Click(object sender, EventArgs e)
        {
            if (speak != null)
            {
                speak.Dispose();
            }
            t = 0;
            this.Close();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            prononcermot();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            prononcermot();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            prononcerdefinition();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            prononcerdefinition();
        }

        private void Frm_Pronuncia_Load(object sender, EventArgs e)
        {
            t = 1;
            this.Top = 0;
            this.Left = 950;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (speak != null)
            {
                if (speak.State == SynthesizerState.Speaking)
                {
                    speak.Pause();
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (speak != null)
            {
                if (speak.State == SynthesizerState.Paused)
                {
                    speak.Resume();
                }
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (speak != null)
            {
                speak.Dispose();
            }
        }
    }
}
