using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Collections;

namespace InfoDic
{
    public partial class Frm_Main : Form
    {

        OleDbConnection connexion = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+Application.StartupPath+@"\bd_dictionnaire.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter adaptateur = new OleDbDataAdapter();
        DataTable dt = new DataTable();
        int index,code;
        ArrayList collection = new ArrayList();
        Frm_Pronunciation pronunciation = new Frm_Pronunciation();
        int res = 0;
        
        
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void rechercher()
        {
           
            Frm_Chercher f = new Frm_Chercher();
            f.ShowDialog();
            string mot = f.chercher;

            try
            {


                if (rtb_definition.Text.Contains(mot))
                {
                    int index = 0;
                    string aux = rtb_definition.Text;
                    rtb_definition.Text = "";
                    rtb_definition.Text = aux;

                    while (index < rtb_definition.Text.LastIndexOf(mot))
                    {
                        rtb_definition.Find(mot, index, rtb_definition.TextLength, RichTextBoxFinds.None);
                        rtb_definition.SelectionBackColor = Color.Orange;
                        index = rtb_definition.Text.IndexOf(mot, index) + 1;
                    }

                }
                else
                {
                    MessageBox.Show("On n'a pas trouvé le mot: '" + mot + "'");
                }
            }
            catch (Exception)
            {

            }
        }

        private void lettres()
        {
            collection.Clear();
            collection.Add('a');
            collection.Add('b');
            collection.Add('c');
            collection.Add('d');
            collection.Add('e');
            collection.Add('f');
            collection.Add('g');
            collection.Add('h');
            collection.Add('i');
            collection.Add('j');
            collection.Add('k');
            collection.Add('l');
            collection.Add('m');
            collection.Add('n');
            collection.Add('o');
            collection.Add('p');
            collection.Add('q');
            collection.Add('r');
            collection.Add('s');
            collection.Add('t');
            collection.Add('u');
            collection.Add('v');
            collection.Add('w');
            collection.Add('x');
            collection.Add('y');
            collection.Add('z');

            ltb_lettres.Items.Clear();
            ltb_lettres.Items.Add("#");
            ltb_lettres.Items.Add("A");
            ltb_lettres.Items.Add("B");
            ltb_lettres.Items.Add("C");
            ltb_lettres.Items.Add("D");
            ltb_lettres.Items.Add("E");
            ltb_lettres.Items.Add("F");
            ltb_lettres.Items.Add("G");
            ltb_lettres.Items.Add("H");
            ltb_lettres.Items.Add("I");
            ltb_lettres.Items.Add("J");
            ltb_lettres.Items.Add("K");
            ltb_lettres.Items.Add("L");
            ltb_lettres.Items.Add("M");
            ltb_lettres.Items.Add("N");
            ltb_lettres.Items.Add("O");
            ltb_lettres.Items.Add("P");
            ltb_lettres.Items.Add("Q");
            ltb_lettres.Items.Add("R");
            ltb_lettres.Items.Add("S");
            ltb_lettres.Items.Add("T");
            ltb_lettres.Items.Add("U");
            ltb_lettres.Items.Add("V");
            ltb_lettres.Items.Add("W");
            ltb_lettres.Items.Add("X");
            ltb_lettres.Items.Add("Y");
            ltb_lettres.Items.Add("Z");

            ltb_lettresf.Items.Clear();
            ltb_lettresf.Items.Add("#");
            ltb_lettresf.Items.Add("A");
            ltb_lettresf.Items.Add("B");
            ltb_lettresf.Items.Add("C");
            ltb_lettresf.Items.Add("D");
            ltb_lettresf.Items.Add("E");
            ltb_lettresf.Items.Add("F");
            ltb_lettresf.Items.Add("G");
            ltb_lettresf.Items.Add("H");
            ltb_lettresf.Items.Add("I");
            ltb_lettresf.Items.Add("J");
            ltb_lettresf.Items.Add("K");
            ltb_lettresf.Items.Add("L");
            ltb_lettresf.Items.Add("M");
            ltb_lettresf.Items.Add("N");
            ltb_lettresf.Items.Add("O");
            ltb_lettresf.Items.Add("P");
            ltb_lettresf.Items.Add("Q");
            ltb_lettresf.Items.Add("R");
            ltb_lettresf.Items.Add("S");
            ltb_lettresf.Items.Add("T");
            ltb_lettresf.Items.Add("U");
            ltb_lettresf.Items.Add("V");
            ltb_lettresf.Items.Add("W");
            ltb_lettresf.Items.Add("X");
            ltb_lettresf.Items.Add("Y");
            ltb_lettresf.Items.Add("Z");
        }

        private void mots()
        {
            adaptateur.SelectCommand = new OleDbCommand("select * from tbl_definition order by mot",connexion);
            dt.Clear();
            adaptateur.Fill(dt);

            listBox1.Items.Clear();
            ltb_mots.Items.Clear();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ltb_mots.Items.Add(dt.Rows[i][1]);
                    listBox1.Items.Add(dt.Rows[i][0]);
                }
   
            }
            
        }

        private void motf()
        {
            DataTable dt1 = new DataTable();
            adaptateur.SelectCommand = new OleDbCommand("select * from tbl_favori order by mot", connexion);
            dt1.Clear();
            adaptateur.Fill(dt1);

            listBox1.Items.Clear();
            ltb_motsf.Items.Clear();
            if (dt1.Rows.Count > 0)
            {
                for (int i = 0; i < dt1.Rows.Count; i++)
                {

                    ltb_motsf.Items.Add(dt1.Rows[i][1]);
                    listBox1.Items.Add(dt1.Rows[i][0]);
                }

            }
            
            else
            {
                MessageBox.Show("Aucun mot a été ajouté aux favoris");
            }
            
        } 

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            ltb_mots.Focus();
            rtb_mot.BorderStyle = BorderStyle.None;
            rtb_definition.BorderStyle = BorderStyle.None;
            lettres();
            mots();
        }

        private void Frm_Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void activer()
        {
            pictureBox4.Enabled = true;
            ptb_rechercher.Enabled = true;
            ptb_pronunciation.Enabled = true;
        }

        private void desactiver()
        {
            pictureBox4.Enabled = false;
            ptb_rechercher.Enabled = false;
            ptb_pronunciation.Enabled = false;
        }

        private void ltb_lettres_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ltb_lettres.SelectedIndex == 0)
            {
                DataTable dt1 = new DataTable();

                adaptateur.SelectCommand = new OleDbCommand("select mot from tbl_definition order by mot", connexion);
                dt1.Clear();
                adaptateur.Fill(dt1);

                if (dt1.Rows.Count > 0)
                {

                    string mot = dt1.Rows[0][0].ToString();
                    ltb_mots.SelectedItem = mot;
                    activer();
                    
                    pronunciation.mot = rtb_mot.Text;
                    pronunciation.definition = rtb_definition.Text;
                }
            }
            else
            {
                DataTable dt1 = new DataTable();

                string lettre = ltb_lettres.SelectedItem.ToString();
                adaptateur.SelectCommand = new OleDbCommand("select mot from tbl_definition where mot like '" + lettre + "%' order by mot",connexion);
                dt1.Clear();
                adaptateur.Fill(dt1);

                if (dt1.Rows.Count > 0)
                {

                    string mot = dt1.Rows[0][0].ToString();
                    ltb_mots.SelectedItem = mot;
                    activer();
                    pronunciation.mot = rtb_mot.Text;
                    pronunciation.definition = rtb_definition.Text;
                    
                }
            }
            
        }

        private void definition()
        {
            if (res == 0)
            {

                DataTable dt1 = new DataTable();

                adaptateur.SelectCommand = new OleDbCommand("select definition from tbl_definition where mot = '" + rtb_mot.Text + "'", connexion);
                dt1.Clear();
                adaptateur.Fill(dt1);

                if (dt1.Rows.Count > 0)
                {

                    string mot = dt1.Rows[0]["definition"].ToString();

                    rtb_definition.Text = mot;
                    changer(mot);
                    activer();

                    pronunciation.mot = rtb_mot.Text;
                    pronunciation.definition = rtb_definition.Text;
                }
            }
            else
            {
                DataTable dt1 = new DataTable();

                adaptateur.SelectCommand = new OleDbCommand("select definition from tbl_favori where mot = '" + rtb_mot.Text + "'", connexion);
                dt1.Clear();
                adaptateur.Fill(dt1);

                if (dt1.Rows.Count > 0)
                {

                    string mot = dt1.Rows[0]["definition"].ToString();

                    rtb_definition.Text = mot;
                    changer(mot);
                    activer();

                    pronunciation.mot = rtb_mot.Text;
                    pronunciation.definition = rtb_definition.Text;
                }
            }
        }

        private void changer(string mot)
        {

            bool res = false;
            string lettre = mot.Substring(0, 1);
            
            if (lettre == " ")
            {
               mot = mot.Remove(0, 1);
               lettre = mot.Substring(0, 1);
  
            }
            for (int i = 0; i < collection.Count; i++)
            {
                if (lettre == collection[i].ToString())
                {
                    res = true;
                }
            }
            if (mot.EndsWith(".") == false)
            {
                mot += ".";
            }
            
            if (res)
            {
                rtb_definition.Text = "Traduction: " + lettre.ToUpper() + mot.Remove(0,1);
            }
            else
            {
                rtb_definition.Text = lettre.ToUpper() + mot.Remove(0, 1);
            }


        }

        private void rechercherMot()
        {
            if (res == 0)
            {

                DataTable dt1 = new DataTable();
                adaptateur.SelectCommand = new OleDbCommand("select mot from tbl_definition where mot like '%" + txt_recherche.Text + "%' order by mot", connexion);
                dt1.Clear();
                adaptateur.Fill(dt1);

                if (dt1.Rows.Count > 0)
                {

                    string mot = dt1.Rows[0][0].ToString();

                    ltb_mots.SelectedItem = mot;

                }
                else
                {
                    MessageBox.Show("Aucun résultat!");
                }

            }
            else
            {
                DataTable dt1 = new DataTable();
                adaptateur.SelectCommand = new OleDbCommand("select mot from tbl_favori where mot like '%" + txt_recherche.Text + "%' order by mot", connexion);
                dt1.Clear();
                adaptateur.Fill(dt1);

                if (dt1.Rows.Count > 0)
                {

                    string mot = dt1.Rows[0][0].ToString();

                    ltb_motsf.SelectedItem = mot;

                }
                else
                {
                    MessageBox.Show("Aucun résultat!");
                }


            }
        }

        private void txt_recherche_TextChanged(object sender, EventArgs e)
        {
            rechercherMot();
        }

        private void rtb_mot_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void voirfavori()
        {
            code = int.Parse(listBox1.SelectedItem.ToString());

            DataTable dt1 = new DataTable();
            adaptateur.SelectCommand = new OleDbCommand("select code from tbl_favori where code = " + code, connexion);
            dt1.Clear();
            adaptateur.Fill(dt1);

            if (dt1.Rows.Count > 0)
            {
                pictureBox2.BackgroundImage = global::InfoDic.Properties.Resources.favorito;
            }
            else
            {
                pictureBox2.BackgroundImage = global::InfoDic.Properties.Resources.favorito1;
            }
            
        } 

        private void ltb_mots_SelectedIndexChanged(object sender, EventArgs e)
        {

            pictureBox2.Visible = true;
            rtb_mot.Text = ltb_mots.SelectedItem.ToString();
            definition();
            index = ltb_mots.SelectedIndex;
            listBox1.SelectedIndex = index;

            voirfavori();

            
        }

        
        private void supprimer()
        {
            connexion.Open();
            cmd.Connection = connexion;
            cmd.CommandText = "delete from tbl_favori where code = " + code;
            cmd.ExecuteNonQuery();
            connexion.Close();
        }

        private void ajouter()
        {
            connexion.Open();
            cmd.Connection = connexion;
            cmd.CommandText = "insert into tbl_favori (code, mot, definition) values (@code, @mot, @definition)";
            cmd.Parameters.Add(new OleDbParameter("code",code));
            cmd.Parameters.Add(new OleDbParameter("mot", rtb_mot.Text));
            cmd.Parameters.Add(new OleDbParameter("definition", rtb_definition.Text));
            cmd.ExecuteNonQuery();
            connexion.Close();
        }
        private void verifier()
        {
            code = int.Parse(listBox1.SelectedItem.ToString());

            DataTable dt1 = new DataTable();
            adaptateur.SelectCommand = new OleDbCommand("select code from tbl_favori where code = " + code, connexion);
            dt1.Clear();
            adaptateur.Fill(dt1);

            if (dt1.Rows.Count > 0)
            {
                supprimer();
            }
            else
            {
                ajouter();
            }

            voirfavori();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            verifier();
            if (res == 1)
            {
                motf();
            }
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Frm_Help f = new Frm_Help();
            f.ShowDialog();
            
        }

        private void ptb_pronunciation_Click(object sender, EventArgs e)
        {
            if (pronunciation.t == 0)
            {
                pronunciation.mot = rtb_mot.Text;
                pronunciation.definition = rtb_definition.Text;
                pronunciation.Show();
            }
            else
            {
                pronunciation.mot = rtb_mot.Text;
                pronunciation.definition = rtb_definition.Text;
                pronunciation.Show();
                MessageBox.Show("La fenêtre de pronunciation est déjà ouverte !");
            }
        }

        private void ptb_rechercher_Click(object sender, EventArgs e)
        {
            rechercher();
            this.rtb_definition.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (rtb_definition.SelectionBackColor != rtb_definition.BackColor)
            {

                rtb_definition.SelectionStart = 0;
                rtb_definition.SelectAll();
                //this.rtb_explicacao.BackColor = System.Drawing.SystemColors.WindowFrame;

                rtb_definition.SelectionBackColor = rtb_definition.BackColor;
            }
        }

        private void ptb_inicio_Click(object sender, EventArgs e)
        {
            rtb_definition.Clear();
            rtb_mot.Clear();
            res = 0;

            lettres();
            mots();
            ltb_lettres.BringToFront();
            ltb_mots.BringToFront();
            ltb_lettres.Visible = true;
            ltb_lettresf.Visible = false;
            ltb_mots.Visible = true;
            ltb_motsf.Visible = false;
            ltb_mots.Focus();
            rtb_mot.BorderStyle = BorderStyle.None;
            rtb_definition.BorderStyle = BorderStyle.None;

            desactiver();
        }

        private void ptb_favoris_Click(object sender, EventArgs e)
        {
            res = 1;
            rtb_definition.Clear();
            rtb_mot.Clear();
            ltb_lettresf.Visible = true;
            ltb_lettres.Visible = false;
            ltb_motsf.Visible = true;
            ltb_mots.Visible = false;
            motf();
            lettres();

            ltb_lettresf.BringToFront();
            ltb_motsf.BringToFront();
            desactiver();
        }

        private void ltb_lettresf_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ltb_lettresf.SelectedIndex == 0)
            {
                DataTable dt1 = new DataTable();

                adaptateur.SelectCommand = new OleDbCommand("select mot from tbl_favori order by mot", connexion);
                dt1.Clear();
                adaptateur.Fill(dt1);

                if (dt1.Rows.Count > 0)
                {

                    string mot = dt1.Rows[0][0].ToString();
                    ltb_motsf.SelectedItem = mot;
                    activer();
                    pronunciation.mot = rtb_mot.Text;
                    pronunciation.definition = rtb_definition.Text;
                }
            }
            else
            {
                DataTable dt1 = new DataTable();

                string lettre = ltb_lettresf.SelectedItem.ToString();
                adaptateur.SelectCommand = new OleDbCommand("select mot from tbl_favori where mot like '" + lettre + "%' order by mot", connexion);
                dt1.Clear();
                adaptateur.Fill(dt1);

                if (dt1.Rows.Count > 0)
                {

                    string mot = dt1.Rows[0][0].ToString();
                    ltb_motsf.SelectedItem = mot;
                    activer();
                    pronunciation.mot = rtb_mot.Text;
                    pronunciation.definition = rtb_definition.Text;

                }
            }
            
        }

        private void ltb_motsf_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                pictureBox2.Visible = true;
                rtb_mot.Text = ltb_motsf.SelectedItem.ToString();
                definition();
                index = ltb_motsf.SelectedIndex;
                listBox1.SelectedIndex = index;

                voirfavori();
            
        }

        private void ptb_copy_Click(object sender, EventArgs e)
        {
            rtb_definition.ReadOnly = false;
            rtb_definition.Copy();
            MessageBox.Show("Le texte a été copié!");
            rtb_definition.ReadOnly = true;
        }

        private void ptb_print_Click(object sender, EventArgs e)
        {
            /*Frm_Rapport f = new Frm_Rapport();
            f.mot = rtb_mot.Text;
            f.definition = rtb_definition.Text;
            f.ShowDialog();
             * */
        }

        private void rtb_mot_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
