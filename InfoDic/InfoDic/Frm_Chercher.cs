using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoDic
{
    public partial class Frm_Chercher : Form
    {
        public string chercher;
        public Frm_Chercher()
        {
            InitializeComponent();
        }

        private void btn_fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chercher = textBox1.Text;
            this.Close();
        }

        private void Frm_Localizar_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 950;
        }
    }
}
