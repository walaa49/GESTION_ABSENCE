using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTION_ABSENCE.uc.accueil
{
    public partial class uc_stagiaires : UserControl
    {
        public uc_stagiaires()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGestionStagiaires fg = new frmGestionStagiaires();
            fg.Show();
        }
    }
}
