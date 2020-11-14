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
    public partial class createRoom : Form
    {
        private Form menu;
        private lobbyRoom lobby;
        public Form Parent
        {

            set
            {

                menu = value;

            }

        }
        public createRoom()
        {
            InitializeComponent();
            this.FormClosing += CreateRoom_FormClosing1;
        }

        private void CreateRoom_FormClosing1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void createRoom_Load(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("../../Resources/Abraham-Regular.ttf");
            foreach (Control c in this.Controls)
            {
                c.Font = new Font(pfc.Families[0], 37, FontStyle.Regular);
            }
        }

        private void cueTextBox1_TextChanged(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] response = new byte[200];
            CreateRoomRequest req = new CreateRoomRequest();
            CreateRoomResponse res = new CreateRoomResponse();
            req.maxPlayers = int.Parse(players_text.Text);
            req.questionCount = int.Parse(q_text.Text);
            req.roomName = name_text.Text;
            req.answerTimeout = int.Parse(time_text.Text);
            byte[] request = serializer.buildMessage<CreateRoomRequest>(ref req, 4);
            Client.client_socket.Send(request);
            res = serializer.DeAssembleMessage<CreateRoomResponse>(response);
            if(res.status == 1)
            {
                if (lobby == null)
                {

                   lobby = new lobbyRoom(true);

                    lobby.Parent = this;

                }

                lobby.Show();

                this.Hide();
            }

        }

        private void q_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void players_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void time_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
