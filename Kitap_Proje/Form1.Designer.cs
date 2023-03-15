namespace Kitap_Proje
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTittleBar = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ıconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.ıconButton5 = new FontAwesome.Sharp.IconButton();
            this.ıconButton4 = new FontAwesome.Sharp.IconButton();
            this.ıconButton3 = new FontAwesome.Sharp.IconButton();
            this.ıconButton2 = new FontAwesome.Sharp.IconButton();
            this.ıconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnhome = new FontAwesome.Sharp.IconPictureBox();
            this.gunaControlBox2 = new Guna.UI.WinForms.GunaControlBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTittleBar.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnhome)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.ıconButton5);
            this.panelMenu.Controls.Add(this.ıconButton4);
            this.panelMenu.Controls.Add(this.ıconButton3);
            this.panelMenu.Controls.Add(this.ıconButton2);
            this.panelMenu.Controls.Add(this.ıconButton1);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(261, 859);
            this.panelMenu.TabIndex = 1;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelLogo.Controls.Add(this.panel1);
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Controls.Add(this.btnhome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(261, 176);
            this.panelLogo.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(0, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 10);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(48, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "KİTAP_PROJE";
            // 
            // panelTittleBar
            // 
            this.panelTittleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            this.panelTittleBar.Controls.Add(this.gunaControlBox2);
            this.panelTittleBar.Controls.Add(this.ıconPictureBox1);
            this.panelTittleBar.Controls.Add(this.label2);
            this.panelTittleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTittleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTittleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTittleBar.Location = new System.Drawing.Point(261, 0);
            this.panelTittleBar.Name = "panelTittleBar";
            this.panelTittleBar.Size = new System.Drawing.Size(1250, 75);
            this.panelTittleBar.TabIndex = 2;
            this.panelTittleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTittleBar_MouseDown);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTitleChildForm.Location = new System.Drawing.Point(60, 21);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(121, 25);
            this.lblTitleChildForm.TabIndex = 2;
            this.lblTitleChildForm.Text = "Giriş ekranı";
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(261, 75);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1250, 784);
            this.panelDesktop.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(1033, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kullanıcı";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Kitap_Proje.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(309, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(623, 609);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ıconPictureBox1
            // 
            this.ıconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            this.ıconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ıconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.ıconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ıconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconPictureBox1.IconSize = 39;
            this.ıconPictureBox1.Location = new System.Drawing.Point(976, 19);
            this.ıconPictureBox1.Name = "ıconPictureBox1";
            this.ıconPictureBox1.Size = new System.Drawing.Size(42, 39);
            this.ıconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ıconPictureBox1.TabIndex = 4;
            this.ıconPictureBox1.TabStop = false;
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Tv;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 39;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(15, 17);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(42, 39);
            this.iconCurrentChildForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // ıconButton5
            // 
            this.ıconButton5.Dock = System.Windows.Forms.DockStyle.Top;
            this.ıconButton5.FlatAppearance.BorderSize = 0;
            this.ıconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ıconButton5.ForeColor = System.Drawing.Color.Gainsboro;
            this.ıconButton5.IconChar = FontAwesome.Sharp.IconChar.School;
            this.ıconButton5.IconColor = System.Drawing.SystemColors.ActiveCaption;
            this.ıconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton5.IconSize = 56;
            this.ıconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton5.Location = new System.Drawing.Point(0, 428);
            this.ıconButton5.Name = "ıconButton5";
            this.ıconButton5.Size = new System.Drawing.Size(261, 84);
            this.ıconButton5.TabIndex = 6;
            this.ıconButton5.Text = "SINIFLAR";
            this.ıconButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButton5.UseVisualStyleBackColor = true;
            this.ıconButton5.Click += new System.EventHandler(this.ıconButton5_Click);
            // 
            // ıconButton4
            // 
            this.ıconButton4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ıconButton4.FlatAppearance.BorderSize = 0;
            this.ıconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ıconButton4.ForeColor = System.Drawing.Color.Gainsboro;
            this.ıconButton4.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.ıconButton4.IconColor = System.Drawing.SystemColors.ActiveCaption;
            this.ıconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton4.IconSize = 56;
            this.ıconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton4.Location = new System.Drawing.Point(0, 775);
            this.ıconButton4.Name = "ıconButton4";
            this.ıconButton4.Size = new System.Drawing.Size(261, 84);
            this.ıconButton4.TabIndex = 5;
            this.ıconButton4.Text = "AYARLAR";
            this.ıconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButton4.UseVisualStyleBackColor = true;
            this.ıconButton4.Click += new System.EventHandler(this.ıconButton4_Click);
            // 
            // ıconButton3
            // 
            this.ıconButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.ıconButton3.FlatAppearance.BorderSize = 0;
            this.ıconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ıconButton3.ForeColor = System.Drawing.Color.Gainsboro;
            this.ıconButton3.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.ıconButton3.IconColor = System.Drawing.SystemColors.ActiveCaption;
            this.ıconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton3.IconSize = 56;
            this.ıconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton3.Location = new System.Drawing.Point(0, 344);
            this.ıconButton3.Name = "ıconButton3";
            this.ıconButton3.Size = new System.Drawing.Size(261, 84);
            this.ıconButton3.TabIndex = 4;
            this.ıconButton3.Text = "İSTATİSTİK";
            this.ıconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButton3.UseVisualStyleBackColor = true;
            this.ıconButton3.Click += new System.EventHandler(this.ıconButton3_Click);
            // 
            // ıconButton2
            // 
            this.ıconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.ıconButton2.FlatAppearance.BorderSize = 0;
            this.ıconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ıconButton2.ForeColor = System.Drawing.Color.Gainsboro;
            this.ıconButton2.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.ıconButton2.IconColor = System.Drawing.SystemColors.ActiveCaption;
            this.ıconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton2.IconSize = 56;
            this.ıconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton2.Location = new System.Drawing.Point(0, 260);
            this.ıconButton2.Name = "ıconButton2";
            this.ıconButton2.Size = new System.Drawing.Size(261, 84);
            this.ıconButton2.TabIndex = 3;
            this.ıconButton2.Text = "KİTAPLAR";
            this.ıconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButton2.UseVisualStyleBackColor = true;
            this.ıconButton2.Click += new System.EventHandler(this.ıconButton2_Click);
            // 
            // ıconButton1
            // 
            this.ıconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ıconButton1.FlatAppearance.BorderSize = 0;
            this.ıconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ıconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ıconButton1.ForeColor = System.Drawing.Color.Gainsboro;
            this.ıconButton1.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.ıconButton1.IconColor = System.Drawing.SystemColors.ActiveCaption;
            this.ıconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconButton1.IconSize = 56;
            this.ıconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton1.Location = new System.Drawing.Point(0, 176);
            this.ıconButton1.Name = "ıconButton1";
            this.ıconButton1.Size = new System.Drawing.Size(261, 84);
            this.ıconButton1.TabIndex = 2;
            this.ıconButton1.Text = "ANA SAYFA";
            this.ıconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ıconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ıconButton1.UseVisualStyleBackColor = true;
            this.ıconButton1.Click += new System.EventHandler(this.ıconButton1_Click);
            // 
            // btnhome
            // 
            this.btnhome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnhome.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btnhome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnhome.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.btnhome.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnhome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnhome.IconSize = 106;
            this.btnhome.Location = new System.Drawing.Point(41, 51);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(162, 106);
            this.btnhome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnhome.TabIndex = 0;
            this.btnhome.TabStop = false;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // gunaControlBox2
            // 
            this.gunaControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gunaControlBox2.AnimationHoverSpeed = 0.07F;
            this.gunaControlBox2.AnimationSpeed = 0.03F;
            this.gunaControlBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.gunaControlBox2.ControlBoxTheme = Guna.UI.WinForms.FormControlBoxTheme.Custom;
            this.gunaControlBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(62)))));
            this.gunaControlBox2.IconSize = 25F;
            this.gunaControlBox2.Location = new System.Drawing.Point(1183, 17);
            this.gunaControlBox2.Name = "gunaControlBox2";
            this.gunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.gunaControlBox2.OnHoverIconColor = System.Drawing.Color.White;
            this.gunaControlBox2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaControlBox2.Size = new System.Drawing.Size(45, 35);
            this.gunaControlBox2.TabIndex = 2;
            this.gunaControlBox2.Click += new System.EventHandler(this.gunaControlBox2_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1511, 859);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTittleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTittleBar.ResumeLayout(false);
            this.panelTittleBar.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnhome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton ıconButton4;
        private FontAwesome.Sharp.IconButton ıconButton3;
        private FontAwesome.Sharp.IconButton ıconButton2;
        private FontAwesome.Sharp.IconButton ıconButton1;
        private FontAwesome.Sharp.IconPictureBox btnhome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTittleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconButton ıconButton5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaControlBox gunaControlBox2;
    }
}

