using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCMP_Gestion
{
    public partial class FormLoader : Form
    {
        public FormLoader()
        {
            InitializeComponent();
            //Chargement();
        }

        #region Chargement
        /// <summary>
        /// Launch Progress Bar on FormLoader
        /// </summary>
        public int Chargement()
        {
            int myOpacity = 0;
            progressBar_Loader.Step = 1;
            progressBar_Loader.Value = 0;
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(50);
                progressBar_Loader.PerformStep();
            }
            if (progressBar_Loader.Value == progressBar_Loader.Maximum)
            {
                Thread.Sleep(1000);
                myOpacity= 100;
            }
            return myOpacity;
        }
        #endregion

        private void FormLoader_Shown(object sender, EventArgs e)
        {
            if (this.pictureBox_Logo.Visible == true)
            {
                this.Opacity = 100;
            }
        }
    }
}
