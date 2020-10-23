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
    public partial class FormMain : Form
    {
        private int myopacity = 0;
        public FormMain()
        {
            InitializeComponent();
        }

        
        private void FormMain_Shown(object sender, EventArgs e)
        {
            FormLoader formLoader = new FormLoader();
            formLoader.Show();
            myopacity = formLoader.Chargement();
            //myopacity = 100;
            
        }
    }
}
