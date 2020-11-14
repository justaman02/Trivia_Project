using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mikmakGUI
{
    public partial class statistics : Form
    {
        private Form menu;
        public Form Parent
        {

            set
            {

                menu = value;

            }

        }
        public statistics()
        {
            InitializeComponent();
            this.FormClosing += Statistics_FormClosing;
        }

        private void Statistics_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void statistics_Load(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("../../Resources/Abraham-Regular.ttf");
            foreach (Control c in this.Controls)
            {
                c.Font = new Font(pfc.Families[0], 37, FontStyle.Regular);
            }
            
            byte[] response = new byte[300];
            GetStatisticsResponse res = new GetStatisticsResponse();
            byte[] request = serializer.buildMessage(8);
            Client.client_socket.Send(request);
            res = serializer.DeAssembleMessage<GetStatisticsResponse>(response);

        }

        private void name_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void players_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void time_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
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
    }
}
