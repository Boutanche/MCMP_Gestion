namespace MCMP_Gestion
{
    partial class FormLoader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoader));
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.progressBar_Loader = new System.Windows.Forms.ProgressBar();
            this.label_Chargement = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.AccessibleName = "Logo";
            this.pictureBox_Logo.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.pictureBox_Logo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Logo.BackgroundImage = global::MCMP_Gestion.Properties.Resources.logo;
            this.pictureBox_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox_Logo.Location = new System.Drawing.Point(13, 13);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(242, 235);
            this.pictureBox_Logo.TabIndex = 0;
            this.pictureBox_Logo.TabStop = false;
            this.pictureBox_Logo.UseWaitCursor = true;
            // 
            // progressBar_Loader
            // 
            this.progressBar_Loader.ForeColor = System.Drawing.Color.Red;
            this.progressBar_Loader.Location = new System.Drawing.Point(13, 443);
            this.progressBar_Loader.Name = "progressBar_Loader";
            this.progressBar_Loader.Size = new System.Drawing.Size(475, 10);
            this.progressBar_Loader.Step = 1;
            this.progressBar_Loader.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar_Loader.TabIndex = 10;
            // 
            // label_Chargement
            // 
            this.label_Chargement.AutoSize = true;
            this.label_Chargement.BackColor = System.Drawing.Color.Transparent;
            this.label_Chargement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Chargement.ForeColor = System.Drawing.Color.White;
            this.label_Chargement.Location = new System.Drawing.Point(13, 255);
            this.label_Chargement.Name = "label_Chargement";
            this.label_Chargement.Size = new System.Drawing.Size(82, 16);
            this.label_Chargement.TabIndex = 2;
            this.label_Chargement.Text = "Chargment : ";
            // 
            // FormLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MCMP_Gestion.Properties.Resources.contact_form_500x470;
            this.ClientSize = new System.Drawing.Size(500, 470);
            this.ControlBox = false;
            this.Controls.Add(this.label_Chargement);
            this.Controls.Add(this.progressBar_Loader);
            this.Controls.Add(this.pictureBox_Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(500, 470);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 470);
            this.Name = "FormLoader";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MCMP Loader";
            this.UseWaitCursor = true;
            this.Shown += new System.EventHandler(this.FormLoader_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Logo;
        private System.Windows.Forms.ProgressBar progressBar_Loader;
        private System.Windows.Forms.Label label_Chargement;
    }
}