
namespace GESTION_ABSENCE
{
    partial class frmGestionStagiaires
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation27 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionStagiaires));
            BunifuAnimatorNS.Animation animation28 = new BunifuAnimatorNS.Animation();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuTransition2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.uc_supprimer1 = new GESTION_ABSENCE.uc_stagiaire.uc_supprimer();
            this.uc_rechercher1 = new GESTION_ABSENCE.uc_stagiaire.uc_rechercher();
            this.uc_modifier1 = new GESTION_ABSENCE.uc_stagiaire.uc_modifier();
            this.uc_ajouter1 = new GESTION_ABSENCE.uc_stagiaire.uc_ajouter();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbldate = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button1);
            this.bunifuTransition2.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1108, 85);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(407, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gestion Stagiaires";
            // 
            // pictureBox1
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.bunifuTransition1.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.button1, BunifuAnimatorNS.DecorationType.None);
            this.button1.Location = new System.Drawing.Point(1027, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.bunifuTransition2.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 85);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(181, 623);
            this.panel2.TabIndex = 2;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.button5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.button5, BunifuAnimatorNS.DecorationType.None);
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Image = global::GESTION_ABSENCE.Properties.Resources.stg_rechercher;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 465);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(181, 157);
            this.button5.TabIndex = 3;
            this.button5.Text = "Rechercher";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.button4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.button4, BunifuAnimatorNS.DecorationType.None);
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::GESTION_ABSENCE.Properties.Resources.stg_supprimer;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 308);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(181, 157);
            this.button4.TabIndex = 2;
            this.button4.Text = "Supprimer";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bunifuTransition1.SetDecoration(this.button3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.button3, BunifuAnimatorNS.DecorationType.None);
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::GESTION_ABSENCE.Properties.Resources.stg_modifier;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 157);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(181, 151);
            this.button3.TabIndex = 1;
            this.button3.Text = "Modifier";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bunifuTransition1.SetDecoration(this.button2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.button2, BunifuAnimatorNS.DecorationType.None);
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::GESTION_ABSENCE.Properties.Resources.stg_ajouter;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 157);
            this.button2.TabIndex = 0;
            this.button2.Text = "Ajouter";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbltime);
            this.panel3.Controls.Add(this.lbldate);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.uc_supprimer1);
            this.panel3.Controls.Add(this.uc_rechercher1);
            this.panel3.Controls.Add(this.uc_modifier1);
            this.panel3.Controls.Add(this.uc_ajouter1);
            this.bunifuTransition2.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(181, 85);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(927, 623);
            this.panel3.TabIndex = 3;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndRotate;
            this.bunifuTransition1.Cursor = null;
            animation27.AnimateOnlyDifferences = true;
            animation27.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation27.BlindCoeff")));
            animation27.LeafCoeff = 0F;
            animation27.MaxTime = 1F;
            animation27.MinTime = 0F;
            animation27.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation27.MosaicCoeff")));
            animation27.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation27.MosaicShift")));
            animation27.MosaicSize = 0;
            animation27.Padding = new System.Windows.Forms.Padding(30);
            animation27.RotateCoeff = 0.5F;
            animation27.RotateLimit = 0.2F;
            animation27.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation27.ScaleCoeff")));
            animation27.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation27.SlideCoeff")));
            animation27.TimeCoeff = 0F;
            animation27.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation27;
            this.bunifuTransition1.Interval = 2;
            // 
            // bunifuTransition2
            // 
            this.bunifuTransition2.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.bunifuTransition2.Cursor = null;
            animation28.AnimateOnlyDifferences = true;
            animation28.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation28.BlindCoeff")));
            animation28.LeafCoeff = 0F;
            animation28.MaxTime = 1F;
            animation28.MinTime = 0F;
            animation28.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation28.MosaicCoeff")));
            animation28.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation28.MosaicShift")));
            animation28.MosaicSize = 0;
            animation28.Padding = new System.Windows.Forms.Padding(0);
            animation28.RotateCoeff = 0F;
            animation28.RotateLimit = 0F;
            animation28.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation28.ScaleCoeff")));
            animation28.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation28.SlideCoeff")));
            animation28.TimeCoeff = 0F;
            animation28.TransparencyCoeff = 1F;
            this.bunifuTransition2.DefaultAnimation = animation28;
            this.bunifuTransition2.Interval = 2;
            // 
            // uc_supprimer1
            // 
            this.uc_supprimer1.BackColor = System.Drawing.Color.Silver;
            this.bunifuTransition1.SetDecoration(this.uc_supprimer1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.uc_supprimer1, BunifuAnimatorNS.DecorationType.None);
            this.uc_supprimer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_supprimer1.Location = new System.Drawing.Point(0, 0);
            this.uc_supprimer1.Name = "uc_supprimer1";
            this.uc_supprimer1.Size = new System.Drawing.Size(927, 623);
            this.uc_supprimer1.TabIndex = 7;
            this.uc_supprimer1.Visible = false;
            // 
            // uc_rechercher1
            // 
            this.uc_rechercher1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuTransition1.SetDecoration(this.uc_rechercher1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.uc_rechercher1, BunifuAnimatorNS.DecorationType.None);
            this.uc_rechercher1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_rechercher1.Location = new System.Drawing.Point(0, 0);
            this.uc_rechercher1.Name = "uc_rechercher1";
            this.uc_rechercher1.Size = new System.Drawing.Size(927, 623);
            this.uc_rechercher1.TabIndex = 6;
            this.uc_rechercher1.Visible = false;
            // 
            // uc_modifier1
            // 
            this.uc_modifier1.BackColor = System.Drawing.Color.Silver;
            this.bunifuTransition1.SetDecoration(this.uc_modifier1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.uc_modifier1, BunifuAnimatorNS.DecorationType.None);
            this.uc_modifier1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_modifier1.Location = new System.Drawing.Point(0, 0);
            this.uc_modifier1.Name = "uc_modifier1";
            this.uc_modifier1.Size = new System.Drawing.Size(927, 623);
            this.uc_modifier1.TabIndex = 5;
            this.uc_modifier1.Visible = false;
            // 
            // uc_ajouter1
            // 
            this.uc_ajouter1.BackColor = System.Drawing.Color.Silver;
            this.bunifuTransition1.SetDecoration(this.uc_ajouter1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.uc_ajouter1, BunifuAnimatorNS.DecorationType.None);
            this.uc_ajouter1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uc_ajouter1.Location = new System.Drawing.Point(0, 0);
            this.uc_ajouter1.Name = "uc_ajouter1";
            this.uc_ajouter1.Size = new System.Drawing.Size(927, 623);
            this.uc_ajouter1.TabIndex = 4;
            this.uc_ajouter1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuTransition1.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(414, 194);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(162, 125);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lbldate, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.lbldate, BunifuAnimatorNS.DecorationType.None);
            this.lbldate.Font = new System.Drawing.Font("Lucida Console", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(363, 331);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(66, 22);
            this.lbldate.TabIndex = 9;
            this.lbldate.Text = "Date";
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lbltime, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.lbltime, BunifuAnimatorNS.DecorationType.None);
            this.lbltime.Font = new System.Drawing.Font("Lucida Bright", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbltime.Location = new System.Drawing.Point(437, 367);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(72, 27);
            this.lbltime.TabIndex = 10;
            this.lbltime.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmGestionStagiaires
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 708);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.bunifuTransition2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmGestionStagiaires";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGestionStagiaires";
            this.Load += new System.EventHandler(this.frmGestionStagiaires_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel3;
        private uc_stagiaire.uc_supprimer uc_supprimer1;
        private uc_stagiaire.uc_rechercher uc_rechercher1;
        private uc_stagiaire.uc_modifier uc_modifier1;
        private uc_stagiaire.uc_ajouter uc_ajouter1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition2;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
    }
}