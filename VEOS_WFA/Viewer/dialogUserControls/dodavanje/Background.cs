using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VEOS_WFA.Viewer.dialogUserControls.dodavanje
{
    public partial class Background : Form
    {
        public Background()
        {
            InitializeComponent();
        }

        private static Background instance;

        public static Background getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Background();
                }
                return instance;
            }
        }

        private void Background_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1.getInstance.Activate();
        }
    }
}
