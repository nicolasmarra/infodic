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
    public partial class Frm_Help : Form
    {
        public Frm_Help()
        {
            InitializeComponent();
        }

        private void btn_fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Help_Load(object sender, EventArgs e)
        {
            this.Left = 450;
            this.Top = 100;
        }
    }
}
