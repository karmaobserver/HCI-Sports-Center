using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VEOS_WFA.Viewer.messageBoxes
{
    public partial class MaxTerenWarning : Form
    {
        public MaxTerenWarning(string message)
        {
            InitializeComponent();
            lblWarningText.Text = message;
            lblWarningText.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void btnOk_MouseEnter(object sender, EventArgs e)
        {
            btnOk.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.button_hover));
        }

        private void btnOk_MouseLeave(object sender, EventArgs e)
        {
            btnOk.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.button));
        }
    }
}
