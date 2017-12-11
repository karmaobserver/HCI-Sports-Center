using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VEOS_WFA.model.collection;
using VEOS_WFA.model.entity;

namespace VEOS_WFA.Viewer
{
    public partial class TimMembers : Form
    {
        public TimMembers()
        {
            InitializeComponent();
        }

        private static TimMembers instance;

        public static TimMembers getInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TimMembers();
                }
                return instance;
            }
        }

        List<Label> listOfLabel = new List<Label>();

        public void createLabel(string param)
        {
            Label newLabel = new Label();
            newLabel.Text = param;
            listOfLabel.Add(newLabel);
        }

        public void makeItVisible()
        {
            foreach (Label temp in listOfLabel)
            {
                temp.Parent = panel1;
                temp.Show();
            }
        }

        public void deleteAllLabel()
        {
            for (int i = 0; i < listOfLabel.Count; i++)
            {
                listOfLabel.RemoveAt(i);
            }
        }
    }
}
