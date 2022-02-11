using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTION_ABSENCE
{
    public partial class frmGestionStagiaires : Form
    {
        public frmGestionStagiaires()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bunifuTransition2.HideSync(uc_modifier1);
            bunifuTransition2.HideSync(uc_rechercher1);
            bunifuTransition2.HideSync(uc_supprimer1);
            pictureBox2.Hide();
            lbldate.Hide();
            lbltime.Hide();
            bunifuTransition1.ShowSync(uc_ajouter1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox2.Hide();
            lbldate.Hide();
            lbltime.Hide();
            bunifuTransition2.HideSync(uc_ajouter1);
            bunifuTransition2.HideSync(uc_rechercher1);
            bunifuTransition2.HideSync(uc_supprimer1);
            bunifuTransition1.ShowSync(uc_modifier1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox2.Hide();
            lbldate.Hide();
            lbltime.Hide();
            bunifuTransition2.HideSync(uc_ajouter1);
            bunifuTransition2.HideSync(uc_rechercher1);
            bunifuTransition2.HideSync(uc_modifier1);
            bunifuTransition1.ShowSync(uc_supprimer1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox2.Hide();
            lbldate.Hide();
            lbltime.Hide();
            bunifuTransition2.HideSync(uc_ajouter1);
            bunifuTransition2.HideSync(uc_supprimer1);
            bunifuTransition2.HideSync(uc_modifier1);
            bunifuTransition1.ShowSync(uc_rechercher1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmGestionStagiaires_Load(object sender, EventArgs e)
        {
            
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToString("T");
            lbldate.Text = DateTime.Now.ToString("D");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox2.Show();
            lbldate.Show();
            lbltime.Show();
            bunifuTransition2.HideSync(uc_ajouter1);
            bunifuTransition2.HideSync(uc_supprimer1);
            bunifuTransition2.HideSync(uc_modifier1);
            bunifuTransition2.HideSync(uc_rechercher1);

        }
    }
}
