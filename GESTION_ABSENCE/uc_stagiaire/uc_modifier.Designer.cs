
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
            this.txttelephone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtprenom = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtnom = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtcin = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnmodifier = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnrechercher = new Bunifu.Framework.UI.BunifuThinButton2();
            this.gunaDataGridView1 = new Guna.UI.WinForms.GunaDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnvider = new Bunifu.Framework.UI.BunifuThinButton2();
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
            // txttelephone
            // 
            this.txttelephone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttelephone.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelephone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txttelephone.HintForeColor = System.Drawing.Color.Empty;
            this.txttelephone.HintText = "";
            this.txttelephone.isPassword = false;
            this.txttelephone.LineFocusedColor = System.Drawing.Color.Blue;
            this.txttelephone.LineIdleColor = System.Drawing.Color.ForestGreen;
            this.txttelephone.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txttelephone.LineThickness = 3;
            this.txttelephone.Location = new System.Drawing.Point(15, 211);
            this.txttelephone.Margin = new System.Windows.Forms.Padding(5);
            this.txttelephone.Name = "txttelephone";
            this.txttelephone.Size = new System.Drawing.Size(200, 29);
            this.txttelephone.TabIndex = 17;
            this.txttelephone.Text = "TELEPHONE";
            this.txttelephone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtprenom
            // 
            this.txtprenom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtprenom.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprenom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtprenom.HintForeColor = System.Drawing.Color.Empty;
            this.txtprenom.HintText = "";
            this.txtprenom.isPassword = false;
            this.txtprenom.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtprenom.LineIdleColor = System.Drawing.Color.ForestGreen;
            this.txtprenom.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtprenom.LineThickness = 3;
            this.txtprenom.Location = new System.Drawing.Point(15, 165);
            this.txtprenom.Margin = new System.Windows.Forms.Padding(5);
            this.txtprenom.Name = "txtprenom";
            this.txtprenom.Size = new System.Drawing.Size(200, 29);
            this.txtprenom.TabIndex = 16;
            this.txtprenom.Text = "PRENOM";
            this.txtprenom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtnom
            // 
            this.txtnom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnom.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtnom.HintForeColor = System.Drawing.Color.Empty;
            this.txtnom.HintText = "";
            this.txtnom.isPassword = false;
            this.txtnom.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtnom.LineIdleColor = System.Drawing.Color.ForestGreen;
            this.txtnom.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtnom.LineThickness = 3;
            this.txtnom.Location = new System.Drawing.Point(15, 119);
            this.txtnom.Margin = new System.Windows.Forms.Padding(5);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(200, 29);
            this.txtnom.TabIndex = 15;
            this.txtnom.Text = "NOM";
            this.txtnom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtcin
            // 
            this.txtcin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcin.Font = new System.Drawing.Font("Lucida Bright", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtcin.HintForeColor = System.Drawing.Color.Empty;
            this.txtcin.HintText = "";
            this.txtcin.isPassword = false;
            this.txtcin.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtcin.LineIdleColor = System.Drawing.Color.ForestGreen;
            this.txtcin.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtcin.LineThickness = 3;
            this.txtcin.Location = new System.Drawing.Point(15, 63);
            this.txtcin.Margin = new System.Windows.Forms.Padding(5);
            this.txtcin.Name = "txtcin";
            this.txtcin.Size = new System.Drawing.Size(200, 39);
            this.txtcin.TabIndex = 14;
            this.txtcin.Text = "CIN";
            this.txtcin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnmodifier
            // 
            this.btnmodifier.ActiveBorderThickness = 1;
            this.btnmodifier.ActiveCornerRadius = 20;
            this.btnmodifier.ActiveFillColor = System.Drawing.Color.White;
            this.btnmodifier.ActiveForecolor = System.Drawing.Color.Gray;
            this.btnmodifier.ActiveLineColor = System.Drawing.Color.Gray;
            this.btnmodifier.BackColor = System.Drawing.Color.Silver;
            this.btnmodifier.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnmodifier.BackgroundImage")));
            this.btnmodifier.ButtonText = "MODIFIER";
            this.btnmodifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmodifier.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodifier.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnmodifier.IdleBorderThickness = 1;
            this.btnmodifier.IdleCornerRadius = 20;
            this.btnmodifier.IdleFillColor = System.Drawing.Color.Silver;
            this.btnmodifier.IdleForecolor = System.Drawing.Color.Honeydew;
            this.btnmodifier.IdleLineColor = System.Drawing.Color.Silver;
            this.btnmodifier.Location = new System.Drawing.Point(340, 361);
            this.btnmodifier.Margin = new System.Windows.Forms.Padding(5);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(127, 37);
            this.btnmodifier.TabIndex = 20;
            this.btnmodifier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnrechercher
            // 
            this.btnrechercher.ActiveBorderThickness = 1;
            this.btnrechercher.ActiveCornerRadius = 20;
            this.btnrechercher.ActiveFillColor = System.Drawing.Color.White;
            this.btnrechercher.ActiveForecolor = System.Drawing.Color.Gray;
            this.btnrechercher.ActiveLineColor = System.Drawing.Color.Gray;
            this.btnrechercher.BackColor = System.Drawing.Color.Silver;
            this.btnrechercher.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnrechercher.BackgroundImage")));
            this.btnrechercher.ButtonText = "RECHERCHER";
            this.btnrechercher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrechercher.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrechercher.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnrechercher.IdleBorderThickness = 1;
            this.btnrechercher.IdleCornerRadius = 20;
            this.btnrechercher.IdleFillColor = System.Drawing.Color.Silver;
            this.btnrechercher.IdleForecolor = System.Drawing.Color.Honeydew;
            this.btnrechercher.IdleLineColor = System.Drawing.Color.Silver;
            this.btnrechercher.Location = new System.Drawing.Point(477, 361);
            this.btnrechercher.Margin = new System.Windows.Forms.Padding(5);
            this.btnrechercher.Name = "btnrechercher";
            this.btnrechercher.Size = new System.Drawing.Size(178, 37);
            this.btnrechercher.TabIndex = 21;
            this.btnrechercher.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // btnvider
            // 
            this.btnvider.ActiveBorderThickness = 1;
            this.btnvider.ActiveCornerRadius = 20;
            this.btnvider.ActiveFillColor = System.Drawing.Color.White;
            this.btnvider.ActiveForecolor = System.Drawing.Color.Gray;
            this.btnvider.ActiveLineColor = System.Drawing.Color.Gray;
            this.btnvider.BackColor = System.Drawing.Color.Silver;
            this.btnvider.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnvider.BackgroundImage")));
            this.btnvider.ButtonText = "VIDER";
            this.btnvider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnvider.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvider.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnvider.IdleBorderThickness = 1;
            this.btnvider.IdleCornerRadius = 20;
            this.btnvider.IdleFillColor = System.Drawing.Color.Silver;
            this.btnvider.IdleForecolor = System.Drawing.Color.Honeydew;
            this.btnvider.IdleLineColor = System.Drawing.Color.Silver;
            this.btnvider.Location = new System.Drawing.Point(793, 361);
            this.btnvider.Margin = new System.Windows.Forms.Padding(5);
            this.btnvider.Name = "btnvider";
            this.btnvider.Size = new System.Drawing.Size(148, 38);
            this.btnvider.TabIndex = 23;
            this.btnvider.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uc_modifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.btnvider);
            this.Controls.Add(this.gunaDataGridView1);
            this.Controls.Add(this.btnrechercher);
            this.Controls.Add(this.btnmodifier);
            this.Controls.Add(this.lbltitre);
            this.Controls.Add(this.cmbannee);
            this.Controls.Add(this.cmbgroupe);
            this.Controls.Add(this.txttelephone);
            this.Controls.Add(this.txtprenom);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.txtcin);
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
        private Bunifu.Framework.UI.BunifuMaterialTextbox txttelephone;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtprenom;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtnom;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtcin;
        private Bunifu.Framework.UI.BunifuThinButton2 btnmodifier;
        private Bunifu.Framework.UI.BunifuThinButton2 btnrechercher;
        private Guna.UI.WinForms.GunaDataGridView gunaDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private Bunifu.Framework.UI.BunifuThinButton2 btnvider;
    }
}
