using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GESTION_ABSENCE.uc_stagiaire
{
    public partial class uc_supprimer : UserControl
    {
        public uc_supprimer()
        {
            InitializeComponent();
        }

        private void txtcin_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void txtcin_Click(object sender, EventArgs e)
        {
            txtcin.Text = null;
        }
    }
}
