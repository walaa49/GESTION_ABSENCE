
namespace GESTION_ABSENCE.uc_stagiaire
{
    partial class uc_ajouter
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_ajouter));
            this.label1 = new System.Windows.Forms.Label();
            this.btxtcin = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btxtnom = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btxttelephone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btxtprenom = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cmbgroupe = new System.Windows.Forms.ComboBox();
            this.cmbannee = new System.Windows.Forms.ComboBox();
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bbtnvider = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bbtnsupprimer = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bbtnajouter = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Elephant", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "AJOUTER UN STAGIAIRE";
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
            this.btxtcin.Location = new System.Drawing.Point(16, 150);
            this.btxtcin.Margin = new System.Windows.Forms.Padding(5);
            this.btxtcin.Name = "btxtcin";
            this.btxtcin.Size = new System.Drawing.Size(200, 39);
            this.btxtcin.TabIndex = 7;
            this.btxtcin.Text = "CIN";
            this.btxtcin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btxtnom.Location = new System.Drawing.Point(16, 206);
            this.btxtnom.Margin = new System.Windows.Forms.Padding(5);
            this.btxtnom.Name = "btxtnom";
            this.btxtnom.Size = new System.Drawing.Size(200, 29);
            this.btxtnom.TabIndex = 8;
            this.btxtnom.Text = "NOM";
            this.btxtnom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btxttelephone.Location = new System.Drawing.Point(16, 298);
            this.btxttelephone.Margin = new System.Windows.Forms.Padding(5);
            this.btxttelephone.Name = "btxttelephone";
            this.btxttelephone.Size = new System.Drawing.Size(200, 29);
            this.btxttelephone.TabIndex = 10;
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
            this.btxtprenom.Location = new System.Drawing.Point(16, 252);
            this.btxtprenom.Margin = new System.Windows.Forms.Padding(5);
            this.btxtprenom.Name = "btxtprenom";
            this.btxtprenom.Size = new System.Drawing.Size(200, 29);
            this.btxtprenom.TabIndex = 9;
            this.btxtprenom.Text = "PRENOM";
            this.btxtprenom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbgroupe
            // 
            this.cmbgroupe.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbgroupe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cmbgroupe.FormattingEnabled = true;
            this.cmbgroupe.Location = new System.Drawing.Point(16, 349);
            this.cmbgroupe.Name = "cmbgroupe";
            this.cmbgroupe.Size = new System.Drawing.Size(200, 31);
            this.cmbgroupe.TabIndex = 11;
            this.cmbgroupe.Text = "     --GROUPE--";
            // 
            // cmbannee
            // 
            this.cmbannee.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbannee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cmbannee.FormattingEnabled = true;
            this.cmbannee.Location = new System.Drawing.Point(16, 395);
            this.cmbannee.Name = "cmbannee";
            this.cmbannee.Size = new System.Drawing.Size(200, 31);
            this.cmbannee.TabIndex = 13;
            this.cmbannee.Text = "       --ANNEE--";
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
            this.gunaDataGridView1.Location = new System.Drawing.Point(288, 196);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.RowHeadersWidth = 62;
            this.gunaDataGridView1.RowTemplate.Height = 28;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(605, 214);
            this.gunaDataGridView1.TabIndex = 14;
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
            this.gunaDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDataGridView1_CellContentClick);
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
            this.bbtnvider.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bbtnvider.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bbtnvider.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
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
            this.bbtnvider.Location = new System.Drawing.Point(776, 463);
            this.bbtnvider.Margin = new System.Windows.Forms.Padding(5);
            this.bbtnvider.Name = "bbtnvider";
            this.bbtnvider.Size = new System.Drawing.Size(148, 38);
            this.bbtnvider.TabIndex = 18;
            this.bbtnvider.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bbtnsupprimer
            // 
            this.bbtnsupprimer.ActiveBorderThickness = 1;
            this.bbtnsupprimer.ActiveCornerRadius = 20;
            this.bbtnsupprimer.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bbtnsupprimer.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bbtnsupprimer.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bbtnsupprimer.BackColor = System.Drawing.Color.Silver;
            this.bbtnsupprimer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bbtnsupprimer.BackgroundImage")));
            this.bbtnsupprimer.ButtonText = "SUPPRIMER";
            this.bbtnsupprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bbtnsupprimer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbtnsupprimer.ForeColor = System.Drawing.Color.SeaGreen;
            this.bbtnsupprimer.IdleBorderThickness = 1;
            this.bbtnsupprimer.IdleCornerRadius = 20;
            this.bbtnsupprimer.IdleFillColor = System.Drawing.Color.Silver;
            this.bbtnsupprimer.IdleForecolor = System.Drawing.Color.Honeydew;
            this.bbtnsupprimer.IdleLineColor = System.Drawing.Color.Silver;
            this.bbtnsupprimer.Location = new System.Drawing.Point(453, 465);
            this.bbtnsupprimer.Margin = new System.Windows.Forms.Padding(5);
            this.bbtnsupprimer.Name = "bbtnsupprimer";
            this.bbtnsupprimer.Size = new System.Drawing.Size(148, 37);
            this.bbtnsupprimer.TabIndex = 16;
            this.bbtnsupprimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bbtnajouter
            // 
            this.bbtnajouter.ActiveBorderThickness = 1;
            this.bbtnajouter.ActiveCornerRadius = 20;
            this.bbtnajouter.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bbtnajouter.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bbtnajouter.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bbtnajouter.BackColor = System.Drawing.Color.Silver;
            this.bbtnajouter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bbtnajouter.BackgroundImage")));
            this.bbtnajouter.ButtonText = "AJOUTER";
            this.bbtnajouter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bbtnajouter.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbtnajouter.ForeColor = System.Drawing.Color.SeaGreen;
            this.bbtnajouter.IdleBorderThickness = 1;
            this.bbtnajouter.IdleCornerRadius = 20;
            this.bbtnajouter.IdleFillColor = System.Drawing.Color.Silver;
            this.bbtnajouter.IdleForecolor = System.Drawing.Color.Honeydew;
            this.bbtnajouter.IdleLineColor = System.Drawing.Color.Silver;
            this.bbtnajouter.Location = new System.Drawing.Point(326, 464);
            this.bbtnajouter.Margin = new System.Windows.Forms.Padding(5);
            this.bbtnajouter.Name = "bbtnajouter";
            this.bbtnajouter.Size = new System.Drawing.Size(127, 37);
            this.bbtnajouter.TabIndex = 12;
            this.bbtnajouter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uc_ajouter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.bbtnvider);
            this.Controls.Add(this.bbtnsupprimer);
            this.Controls.Add(this.gunaDataGridView1);
            this.Controls.Add(this.cmbannee);
            this.Controls.Add(this.bbtnajouter);
            this.Controls.Add(this.cmbgroupe);
            this.Controls.Add(this.btxttelephone);
            this.Controls.Add(this.btxtprenom);
            this.Controls.Add(this.btxtnom);
            this.Controls.Add(this.btxtcin);
            this.Controls.Add(this.label1);
            this.Name = "uc_ajouter";
            this.Size = new System.Drawing.Size(927, 623);
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox btxtcin;
        private Bunifu.Framework.UI.BunifuMaterialTextbox btxtnom;
        private Bunifu.Framework.UI.BunifuMaterialTextbox btxttelephone;
        private Bunifu.Framework.UI.BunifuMaterialTextbox btxtprenom;
        private System.Windows.Forms.ComboBox cmbgroupe;
        private Bunifu.Framework.UI.BunifuThinButton2 bbtnajouter;
        private System.Windows.Forms.ComboBox cmbannee;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private Bunifu.Framework.UI.BunifuThinButton2 bbtnsupprimer;
        private Bunifu.Framework.UI.BunifuThinButton2 bbtnvider;
    }
}
