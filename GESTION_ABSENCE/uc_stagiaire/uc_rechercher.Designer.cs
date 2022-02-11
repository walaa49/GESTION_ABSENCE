
namespace GESTION_ABSENCE.uc_stagiaire
{
    partial class uc_rechercher
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uc_rechercher));
            this.lbltitre = new System.Windows.Forms.Label();
            this.grpbrecherche = new System.Windows.Forms.GroupBox();
            this.cmbgroupe = new System.Windows.Forms.ComboBox();
            this.btxtcin = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bbtnrechercher = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bbtnvider = new Bunifu.Framework.UI.BunifuThinButton2();
            this.grpbrecherche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitre
            // 
            this.lbltitre.AutoSize = true;
            this.lbltitre.Font = new System.Drawing.Font("Elephant", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitre.Location = new System.Drawing.Point(302, 10);
            this.lbltitre.Name = "lbltitre";
            this.lbltitre.Size = new System.Drawing.Size(369, 26);
            this.lbltitre.TabIndex = 2;
            this.lbltitre.Text = "RECHERCHER UN STAGIAIRE";
            // 
            // grpbrecherche
            // 
            this.grpbrecherche.Controls.Add(this.cmbgroupe);
            this.grpbrecherche.Controls.Add(this.btxtcin);
            this.grpbrecherche.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbrecherche.ForeColor = System.Drawing.Color.DimGray;
            this.grpbrecherche.Location = new System.Drawing.Point(0, 54);
            this.grpbrecherche.Name = "grpbrecherche";
            this.grpbrecherche.Size = new System.Drawing.Size(943, 80);
            this.grpbrecherche.TabIndex = 24;
            this.grpbrecherche.TabStop = false;
            this.grpbrecherche.Text = "RECHERCHE";
            // 
            // cmbgroupe
            // 
            this.cmbgroupe.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbgroupe.ForeColor = System.Drawing.Color.Gray;
            this.cmbgroupe.FormattingEnabled = true;
            this.cmbgroupe.Location = new System.Drawing.Point(538, 36);
            this.cmbgroupe.Name = "cmbgroupe";
            this.cmbgroupe.Size = new System.Drawing.Size(200, 31);
            this.cmbgroupe.TabIndex = 12;
            this.cmbgroupe.Text = "     --GROUPE--";
            // 
            // btxtcin
            // 
            this.btxtcin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btxtcin.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxtcin.ForeColor = System.Drawing.Color.DimGray;
            this.btxtcin.HintForeColor = System.Drawing.Color.Empty;
            this.btxtcin.HintText = "";
            this.btxtcin.isPassword = false;
            this.btxtcin.LineFocusedColor = System.Drawing.Color.Blue;
            this.btxtcin.LineIdleColor = System.Drawing.Color.Gray;
            this.btxtcin.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.btxtcin.LineThickness = 3;
            this.btxtcin.Location = new System.Drawing.Point(205, 28);
            this.btxtcin.Margin = new System.Windows.Forms.Padding(5);
            this.btxtcin.Name = "btxtcin";
            this.btxtcin.Size = new System.Drawing.Size(200, 39);
            this.btxtcin.TabIndex = 8;
            this.btxtcin.Text = "CIN";
            this.btxtcin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaDataGridView1
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.gunaDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gunaDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.gunaDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gunaDataGridView1.ColumnHeadersHeight = 32;
            this.gunaDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.gunaDataGridView1.EnableHeadersVisualStyles = false;
            this.gunaDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gunaDataGridView1.Location = new System.Drawing.Point(-1, 140);
            this.gunaDataGridView1.Name = "gunaDataGridView1";
            this.gunaDataGridView1.RowHeadersVisible = false;
            this.gunaDataGridView1.RowHeadersWidth = 62;
            this.gunaDataGridView1.RowTemplate.Height = 28;
            this.gunaDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDataGridView1.Size = new System.Drawing.Size(944, 283);
            this.gunaDataGridView1.TabIndex = 23;
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
            // bbtnrechercher
            // 
            this.bbtnrechercher.ActiveBorderThickness = 1;
            this.bbtnrechercher.ActiveCornerRadius = 20;
            this.bbtnrechercher.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bbtnrechercher.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bbtnrechercher.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bbtnrechercher.BackColor = System.Drawing.Color.DarkSlateGray;
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
            this.bbtnrechercher.Location = new System.Drawing.Point(383, 431);
            this.bbtnrechercher.Margin = new System.Windows.Forms.Padding(5);
            this.bbtnrechercher.Name = "bbtnrechercher";
            this.bbtnrechercher.Size = new System.Drawing.Size(178, 30);
            this.bbtnrechercher.TabIndex = 27;
            this.bbtnrechercher.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.bbtnvider.Location = new System.Drawing.Point(790, 431);
            this.bbtnvider.Margin = new System.Windows.Forms.Padding(5);
            this.bbtnvider.Name = "bbtnvider";
            this.bbtnvider.Size = new System.Drawing.Size(148, 30);
            this.bbtnvider.TabIndex = 26;
            this.bbtnvider.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uc_rechercher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Controls.Add(this.bbtnrechercher);
            this.Controls.Add(this.bbtnvider);
            this.Controls.Add(this.grpbrecherche);
            this.Controls.Add(this.gunaDataGridView1);
            this.Controls.Add(this.lbltitre);
            this.Name = "uc_rechercher";
            this.Size = new System.Drawing.Size(944, 467);
            this.grpbrecherche.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitre;
        private Bunifu.Framework.UI.BunifuThinButton2 bbtnrechercher;
        private Bunifu.Framework.UI.BunifuThinButton2 bbtnvider;
        private System.Windows.Forms.GroupBox grpbrecherche;
        private System.Windows.Forms.ComboBox cmbgroupe;
        private Bunifu.Framework.UI.BunifuMaterialTextbox btxtcin;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
