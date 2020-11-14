using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mikmakGUI
{
    public partial class top : Form
    {
        private Form menu;
        public Form Parent
        {

            set
            {

                menu = value;

            }

        }
        public top()
        {
            InitializeComponent();
            this.FormClosed += Top_FormClosed;
        }

        private void Top_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void top_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (menu == null)
            {

                menu = new menu();

                menu.Parent = this;

            }

            menu.Show();

            this.Hide();
        }

        private void score_4_Click(object sender, EventArgs e)
        {

        }

        private void name_2_Click(object sender, EventArgs e)
        {

        }
    }
}
