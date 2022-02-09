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
    public partial class frm_accueil : Form
    {
        public frm_accueil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); 

        }

      
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           
            bunifuTransition2.HideSync(uc_ulisateur1);
            bunifuTransition2.HideSync(uc_saisie1);
            bunifuTransition2.HideSync(uc_stagiaires1);
            bunifuTransition1.ShowSync(uc_consulter1);

        }

        private void bunifuThinButton24_Click_1(object sender, EventArgs e)
        {
            bunifuTransition2.HideSync(uc_consulter1);
            bunifuTransition2.HideSync(uc_saisie1);
            bunifuTransition2.HideSync(uc_ulisateur1);
            bunifuTransition1.ShowSync(uc_stagiaires1);

        }


        private void bunifuThinButton23_Click_1(object sender, EventArgs e)
        {
            bunifuTransition2.HideSync(uc_stagiaires1);
            bunifuTransition2.HideSync(uc_ulisateur1);
            bunifuTransition2.HideSync(uc_saisie1);
            bunifuTransition1.ShowSync(uc_consulter1);
        }

        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {

            bunifuTransition2.HideSync(uc_saisie1);
            bunifuTransition2.HideSync(uc_stagiaires1);
            bunifuTransition2.HideSync(uc_consulter1);
            bunifuTransition1.ShowSync(uc_ulisateur1);

        }
        private void uc_saisie1_Load(object sender, EventArgs e)
        {

        }

    }
}
