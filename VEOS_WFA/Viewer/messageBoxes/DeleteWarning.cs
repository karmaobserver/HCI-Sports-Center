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
    public partial class DeleteWarning : Form
    {
        public DeleteWarning(string message)
        {
            InitializeComponent();
            lblMessage.Text = message;
        }

        private void btnDa_MouseEnter(object sender, EventArgs e)
        {
            btnDa.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.button_hover));
        }

        private void btnDa_MouseLeave(object sender, EventArgs e)
        {
            btnDa.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.button));
        }

        private void btnNe_MouseEnter(object sender, EventArgs e)
        {
            btnNe.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.button_hover));
        }

        private void btnNe_MouseLeave(object sender, EventArgs e)
        {
            btnNe.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.button));
        }
    }
}
