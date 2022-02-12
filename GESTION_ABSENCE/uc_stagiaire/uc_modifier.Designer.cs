
namespace GESTION_ABSENCE.uc_stagiaire
{
    partial class uc_modifier
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_modifier));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbltitre = new System.Windows.Forms.Label();
            this.cmbannee = new System.Windows.Forms.ComboBox();
            this.cmbgroupe = new System.Windows.Forms.ComboBox();
            this.btxttelephone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btxtprenom = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btxtnom = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btxtcin = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bbtnmodifier = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bbtnrechercher = new Bunifu.Framework.UI.BunifuThinButton2();
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bbtnvider = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitre
            // 
            this.lbltitre.AutoSize = true;
            this.lbltitre.Font = new System.Drawing.Font("Elephant", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitre.Location = new System.Drawing.Point(319, 14);
            this.lbltitre.Name = "lbltitre";
            this.lbltitre.Size = new System.Drawing.Size(329, 26);
            this.lbltitre.TabIndex = 1;
            this.lbltitre.Text = "MODIFIER UN  STAGIAIRE";
            // 
            // cmbannee
            // 
            this.cmbannee.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbannee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cmbannee.FormattingEnabled = true;
            this.cmbannee.Location = new System.Drawing.Point(15, 308);
            this.cmbannee.Name = "cmbannee";
            this.cmbannee.Size = new System.Drawing.Size(200, 31);
            this.cmbannee.TabIndex = 19;
            this.cmbannee.Text = "       --ANNEE--";
            // 
            // cmbgroupe
            // 
            this.cmbgroupe.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbgroupe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cmbgroupe.FormattingEnabled = true;
            this.cmbgroupe.Location = new System.Drawing.Point(15, 262);
            this.cmbgroupe.Name = "cmbgroupe";
            this.cmbgroupe.Size = new System.Drawing.Size(200, 31);
            this.cmbgroupe.TabIndex = 18;
            this.cmbgroupe.Text = "     --GROUPE--";
            // 
            // btxttelephone
            // 
            this.btxttelephone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btxttelephone.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxttelephone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btxttelephone.HintForeColor = System.Drawing.Color.Empty;
            this.btxttelephone.HintText = "";
            this.btxttelephone.isPassword = false;
            this.btxttelephone.LineFocusedColor = System.Drawing.Color.Blue;
            this.btxttelephone.LineIdleColor = System.Drawing.Color.ForestGreen;
            this.btxttelephone.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.btxttelephone.LineThickness = 3;
            this.btxttelephone.Location = new System.Drawing.Point(15, 211);
            this.btxttelephone.Margin = new System.Windows.Forms.Padding(5);
            this.btxttelephone.Name = "btxttelephone";
            this.btxttelephone.Size = new System.Drawing.Size(200, 29);
            this.btxttelephone.TabIndex = 17;
            this.btxttelephone.Text = "TELEPHONE";
            this.btxttelephone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btxtprenom
            // 
            this.btxtprenom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btxtprenom.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxtprenom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btxtprenom.HintForeColor = System.Drawing.Color.Empty;
            this.btxtprenom.HintText = "";
            this.btxtprenom.isPassword = false;
            this.btxtprenom.LineFocusedColor = System.Drawing.Color.Blue;
            this.btxtprenom.LineIdleColor = System.Drawing.Color.ForestGreen;
            this.btxtprenom.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.btxtprenom.LineThickness = 3;
            this.btxtprenom.Location = new System.Drawing.Point(15, 165);
            this.btxtprenom.Margin = new System.Windows.Forms.Padding(5);
            this.btxtprenom.Name = "btxtprenom";
            this.btxtprenom.Size = new System.Drawing.Size(200, 29);
            this.btxtprenom.TabIndex = 16;
            this.btxtprenom.Text = "PRENOM";
            this.btxtprenom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btxtnom
            // 
            this.btxtnom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btxtnom.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxtnom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btxtnom.HintForeColor = System.Drawing.Color.Empty;
            this.btxtnom.HintText = "";
            this.btxtnom.isPassword = false;
            this.btxtnom.LineFocusedColor = System.Drawing.Color.Blue;
            this.btxtnom.LineIdleColor = System.Drawing.Color.ForestGreen;
            this.btxtnom.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.btxtnom.LineThickness = 3;
            this.btxtnom.Location = new System.Drawing.Point(15, 119);
            this.btxtnom.Margin = new System.Windows.Forms.Padding(5);
            this.btxtnom.Name = "btxtnom";
            this.btxtnom.Size = new System.Drawing.Size(200, 29);
            this.btxtnom.TabIndex = 15;
            this.btxtnom.Text = "NOM";
            this.btxtnom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btxtcin
            // 
            this.btxtcin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btxtcin.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxtcin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btxtcin.HintForeColor = System.Drawing.Color.Empty;
            this.btxtcin.HintText = "";
            this.btxtcin.isPassword = false;
            this.btxtcin.LineFocusedColor = System.Drawing.Color.Blue;
            this.btxtcin.LineIdleColor = System.Drawing.Color.ForestGreen;
            this.btxtcin.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.btxtcin.LineThickness = 3;
            this.btxtcin.Location = new System.Drawing.Point(15, 63);
            this.btxtcin.Margin = new System.Windows.Forms.Padding(5);
            this.btxtcin.Name = "btxtcin";
            this.btxtcin.Size = new System.Drawing.Size(200, 39);
            this.btxtcin.TabIndex = 14;
            this.btxtcin.Text = "CIN";
            this.btxtcin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bbtnmodifier
            // 
            this.bbtnmodifier.ActiveBorderThickness = 1;
            this.bbtnmodifier.ActiveCornerRadius = 20;
            this.bbtnmodifier.ActiveFillColor = System.Drawing.Color.White;
            this.bbtnmodifier.ActiveForecolor = System.Drawing.Color.Gray;
            this.bbtnmodifier.ActiveLineColor = System.Drawing.Color.Gray;
            this.bbtnmodifier.BackColor = System.Drawing.Color.Silver;
            this.bbtnmodifier.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bbtnmodifier.BackgroundImage")));
            this.bbtnmodifier.ButtonText = "MODIFIER";
            this.bbtnmodifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bbtnmodifier.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbtnmodifier.ForeColor = System.Drawing.Color.SeaGreen;
            this.bbtnmodifier.IdleBorderThickness = 1;
            this.bbtnmodifier.IdleCornerRadius = 20;
            this.bbtnmodifier.IdleFillColor = System.Drawing.Color.Silver;
            this.bbtnmodifier.IdleForecolor = System.Drawing.Color.Honeydew;
            this.bbtnmodifier.IdleLineColor = System.Drawing.Color.Silver;
            this.bbtnmodifier.Location = new System.Drawing.Point(340, 361);
            this.bbtnmodifier.Margin = new System.Windows.Forms.Padding(5);
            this.bbtnmodifier.Name = "bbtnmodifier";
            this.bbtnmodifier.Size = new System.Drawing.Size(127, 37);
            this.bbtnmodifier.TabIndex = 20;
            this.bbtnmodifier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bbtnrechercher
            // 
            this.bbtnrechercher.ActiveBorderThickness = 1;
            this.bbtnrechercher.ActiveCornerRadius = 20;
            this.bbtnrechercher.ActiveFillColor = System.Drawing.Color.White;
            this.bbtnrechercher.ActiveForecolor = System.Drawing.Color.Gray;
            this.bbtnrechercher.ActiveLineColor = System.Drawing.Color.Gray;
            this.bbtnrechercher.BackColor = System.Drawing.Color.Silver;
            this.bbtnrechercher.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bbtnrechercher.BackgroundImage")));
            this.bbtnrechercher.ButtonText = "RECHERCHER";
            this.bbtnrechercher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bbtnrechercher.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbtnrechercher.ForeColor = System.Drawing.Color.SeaGreen;
            this.bbtnrechercher.IdleBorderThickness = 1;
            this.bbtnrechercher.IdleCornerRadius = 20;
            this.bbtnrechercher.IdleFillColor = System.Drawing.Color.Silver;
            this.bbtnrechercher.IdleForecolor = System.Drawing.Color.Honeydew;
            this.bbtnrechercher.IdleLineColor = System.Drawing.Color.Silver;
            this.bbtnrechercher.Location = new System.Drawing.Point(477, 361);
            this.bbtnrechercher.Margin = new System.Windows.Forms.Padding(5);
            this.bbtnrechercher.Name = "bbtnrechercher";
            this.bbtnrechercher.Size = new System.Drawing.Size(178, 37);
            this.bbtnrechercher.TabIndex = 21;
            this.bbtnrechercher.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaDataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.gunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gunaDataGridView1.ColumnHeadersHeight = 32;
            this.gunaDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.gunaDataGridView1.EnableHeadersVisualStyles = false;
            this.gunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gunaDataGridView1.Location = new System.Drawing.Point(282, 84);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.RowHeadersWidth = 62;
            this.gunaDataGridView1.RowTemplate.Height = 28;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(605, 234);
            this.gunaDataGridView1.TabIndex = 22;
            this.gunaDataGridView1.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDataGridView1.ThemeStyle.HeaderStyle.Height = 32;
            this.gunaDataGridView1.ThemeStyle.ReadOnly = false;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.Height = 28;
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // bbtnvider
            // 
            this.bbtnvider.ActiveBorderThickness = 1;
            this.bbtnvider.ActiveCornerRadius = 20;
            this.bbtnvider.ActiveFillColor = System.Drawing.Color.White;
            this.bbtnvider.ActiveForecolor = System.Drawing.Color.Gray;
            this.bbtnvider.ActiveLineColor = System.Drawing.Color.Gray;
            this.bbtnvider.BackColor = System.Drawing.Color.Silver;
            this.bbtnvider.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bbtnvider.BackgroundImage")));
            this.bbtnvider.ButtonText = "VIDER";
            this.bbtnvider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bbtnvider.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbtnvider.ForeColor = System.Drawing.Color.SeaGreen;
            this.bbtnvider.IdleBorderThickness = 1;
            this.bbtnvider.IdleCornerRadius = 20;
            this.bbtnvider.IdleFillColor = System.Drawing.Color.Silver;
            this.bbtnvider.IdleForecolor = System.Drawing.Color.Honeydew;
            this.bbtnvider.IdleLineColor = System.Drawing.Color.Silver;
            this.bbtnvider.Location = new System.Drawing.Point(793, 361);
            this.bbtnvider.Margin = new System.Windows.Forms.Padding(5);
            this.bbtnvider.Name = "bbtnvider";
            this.bbtnvider.Size = new System.Drawing.Size(148, 38);
            this.bbtnvider.TabIndex = 23;
            this.bbtnvider.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uc_modifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.bbtnvider);
            this.Controls.Add(this.gunaDataGridView1);
            this.Controls.Add(this.bbtnrechercher);
            this.Controls.Add(this.bbtnmodifier);
            this.Controls.Add(this.lbltitre);
            this.Controls.Add(this.cmbannee);
            this.Controls.Add(this.cmbgroupe);
            this.Controls.Add(this.btxttelephone);
            this.Controls.Add(this.btxtprenom);
            this.Controls.Add(this.btxtnom);
            this.Controls.Add(this.btxtcin);
            this.Name = "uc_modifier";
            this.Size = new System.Drawing.Size(944, 403);
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitre;
        private System.Windows.Forms.ComboBox cmbannee;
        private System.Windows.Forms.ComboBox cmbgroupe;
        private Bunifu.Framework.UI.BunifuMaterialTextbox btxttelephone;
        private Bunifu.Framework.UI.BunifuMaterialTextbox btxtprenom;
        private Bunifu.Framework.UI.BunifuMaterialTextbox btxtnom;
        private Bunifu.Framework.UI.BunifuMaterialTextbox btxtcin;
        private Bunifu.Framework.UI.BunifuThinButton2 bbtnmodifier;
        private Bunifu.Framework.UI.BunifuThinButton2 bbtnrechercher;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private Bunifu.Framework.UI.BunifuThinButton2 bbtnvider;
    }
}
