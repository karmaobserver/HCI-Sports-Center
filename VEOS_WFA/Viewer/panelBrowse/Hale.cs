using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VEOS_WFA.model.entity;
using VEOS_WFA.model.collection;

namespace VEOS_WFA.Viewer.panelBrowse
{
    public partial class Hale : UserControl
    {

        private bool panelDisable = true;

        private bool[] panelToBeShowBySearch = new bool[4];

        public bool[] PanelToBeShowBySearch
        {
            get { return panelToBeShowBySearch; }
            set { panelToBeShowBySearch = value; }
        }

        private void setDefaultBool()
        {
            for (int i = 0; i < panelToBeShowBySearch.Length; i++)
            {
                panelToBeShowBySearch[i] = false;
            }
        }


        private string[] imenaHale = new string[4];

        public string[] ImenaHale
        {
            get { return imenaHale; }
            set { imenaHale = value; }
        }

        private void setDefaultImenaTerena()
        {
            for (int i = 0; i < imenaHale.Length; i++)
            {
                imenaHale[i] = "";
            }
        }

        private int brHale;

        public int BrHale
        {
            get { return brHale; }
            set { brHale = value; }
        }

        private string imeHale;

        public string ImeHale
        {
            get { return imeHale; }
            set { imeHale = value; }
        }

        public Hale()
        {
            InitializeComponent();
            setDefaultBool();
            setDefaultImenaTerena();
        }

        public void setHaleText(List<string> paramHale, List<int> brTerenaParam)
        {
            int i = 1;
            foreach (string ime in paramHale)
            {
                switch (i)
                {
                    case 1: lblValueOfName1.Text = ime; imenaHale[0] = ime; panelHale1.Tag = 1; break;
                    case 2: lblValueOfName2.Text = ime; imenaHale[1] = ime; panelHale2.Tag = 2; break;
                    case 3: lblValueOfName3.Text = ime; imenaHale[2] = ime; panelHale3.Tag = 3; break;
                    case 4: lblValueOfName4.Text = ime; imenaHale[3] = ime; panelHale4.Tag = 4; break;
                }
                i++;
            }

            int j = 1;
            foreach (int broj in brTerenaParam)
            {
                switch (j)
                {
                    case 1: lblValueBrTerena1.Text = broj.ToString(); break;
                    case 2: lblValueBrTerena2.Text = broj.ToString(); break;
                    case 3: lblValueBrTerena3.Text = broj.ToString(); break;
                    case 4: lblValueBrTerena4.Text = broj.ToString(); break;
                }
                j++;
            }
        }

        private void Hale_Load(object sender, EventArgs e)
        {
            
            for (int i = 1; i <= brHale; i++)
            {
                switch (i)
                {
                    case 1: panelHale1.Visible = true; break;
                    case 2: panelHale2.Visible = true; break;
                    case 3: panelHale3.Visible = true; break;
                    case 4: panelHale4.Visible = true; break;
                }
            }
        }

        public void searchHale()
        {
            for (int i = 0; i < panelToBeShowBySearch.Length; i++)
            {
                switch (i)
                {
                    case 0: panelHale1.Visible = panelToBeShowBySearch[i]; break;
                    case 1: panelHale2.Visible = panelToBeShowBySearch[i]; break;
                    case 2: panelHale3.Visible = panelToBeShowBySearch[i]; break;
                    case 3: panelHale4.Visible = panelToBeShowBySearch[i]; break;
                }
            }
        }

        //******************IZCRTAVANJE DUGMICA KAD SE KLIKNE I KAD SE HOVERUJE*****************************/////
        private void panelHale1_MouseEnter(object sender, EventArgs e)
        {
            panelHale1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelHale_hover));
            Form1.getInstance.setLblStatusBar(lblValueOfName1.Text);
        }

        private void panelHale1_MouseLeave(object sender, EventArgs e)
        {
            panelHale1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelHale));
            Form1.getInstance.setLblStatusBar("");
        }

        private void panelHale2_MouseEnter(object sender, EventArgs e)
        {
            panelHale2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelHale_hover));
            Form1.getInstance.setLblStatusBar(lblValueOfName2.Text);
        }

        private void panelHale2_MouseLeave(object sender, EventArgs e)
        {
            panelHale2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelHale));
            Form1.getInstance.setLblStatusBar("");
        }

        private void panelHale3_MouseEnter(object sender, EventArgs e)
        {
            panelHale3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelHale_hover));
            Form1.getInstance.setLblStatusBar(lblValueOfName3.Text);
        }

        private void panelHale3_MouseLeave(object sender, EventArgs e)
        {
            panelHale3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelHale));
            Form1.getInstance.setLblStatusBar("");
        }

        private void panelHale4_MouseEnter(object sender, EventArgs e)
        {
            panelHale4.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelHale_hover));
            Form1.getInstance.setLblStatusBar(lblValueOfName4.Text);
        }

        private void panelHale4_MouseLeave(object sender, EventArgs e)
        {
            panelHale4.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.panelHale));
            Form1.getInstance.setLblStatusBar("");
        }
        //******************IZCRTAVANJE DUGMICA KAD SE KLIKNE I KAD SE HOVERUJE*****************************/////

        private void panelHale1_MouseClick(object sender, MouseEventArgs e)
        {
            ImeHale = lblValueOfName1.Text.ToString();
            Control activeForm = this.FindForm();
            ((Form1)activeForm).CurrentHala = 0;
            ((Form1)activeForm).paintTereni();
        }

        private void panelHale2_MouseClick(object sender, MouseEventArgs e)
        {
            ImeHale = lblValueOfName2.Text.ToString();
            Control activeForm = this.FindForm();
            ((Form1)activeForm).CurrentHala = 1;
            ((Form1)activeForm).paintTereni();
        }

        private void panelHale3_MouseClick(object sender, MouseEventArgs e)
        {
            ImeHale = lblValueOfName3.Text.ToString();
            Control activeForm = this.FindForm();
            ((Form1)activeForm).CurrentHala = 2;
            ((Form1)activeForm).paintTereni();
        }

        private void panelHale4_MouseClick(object sender, MouseEventArgs e)
        {
            ImeHale = lblValueOfName4.Text.ToString();
            Control activeForm = this.FindForm();
            ((Form1)activeForm).CurrentHala = 3;
            ((Form1)activeForm).paintTereni();
        }

        private void panelHale2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
