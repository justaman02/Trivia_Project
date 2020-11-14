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
    public partial class joinRoom : Form
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
        public joinRoom()
        {
            InitializeComponent();
            this.FormClosing += JoinRoom_FormClosing1;
            this.t_num.TextChanged += T_num_TextChanged;
            this.p_num.TextChanged += P_num_TextChanged;
        }

        private void P_num_TextChanged(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("../../Resources/ganclm_bold-webfont.ttf");

            while (label1.Width < System.Windows.Forms.TextRenderer.MeasureText(label1.Text,
        new Font(label1.Font.FontFamily, label1.Font.Size, label1.Font.Style)).Width)
            {
                p_num.Font = new Font(pfc.Families[0], label1.Font.Size - 0.5f, label1.Font.Style);
            }
        }

        private void T_num_TextChanged(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("../../Resources/ganclm_bold-webfont.ttf");

            while (label1.Width < System.Windows.Forms.TextRenderer.MeasureText(label1.Text,
      new Font(label1.Font.FontFamily, label1.Font.Size, label1.Font.Style)).Width)
            {
                t_num.Font = new Font(pfc.Families[0], label1.Font.Size - 0.5f, label1.Font.Style);
            }
        }

        private void JoinRoom_FormClosing1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void joinRoom_Load(object sender, EventArgs e)
        {

            this.Click += (object g, EventArgs lol) =>
            {
                panel1.Visible = false;
                panel2.Visible = false;
            };
            controls.Click += (object g, EventArgs lol) =>
            {
                panel1.Visible = false;
                panel2.Visible = false;
            };
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("../../Resources/ganclm_bold-webfont.ttf");
           

            byte[] response = new byte[300];
            GetRoomsResponse res = new GetRoomsResponse();
            byte[] request = serializer.buildMessage(5);
            Client.client_socket.Send(request);
            res = serializer.DeAssembleMessage<GetRoomsResponse>(response);

            int d = 1;

            if (res.rooms.Count == 0)
            {
                label3.Visible = true;

            }
            foreach(RoomData room in res.rooms)
            {
                Label temp = new Label();
                temp.Text = room.name;
                temp.BackColor = System.Drawing.Color.Transparent;
                temp.BackgroundImage = global::mikmakGUI.Properties.Resources.roomBack;
                temp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                temp.Location = new System.Drawing.Point(30, 100 * d - 80);
                temp.Name = d.ToString();
                temp.Size = new System.Drawing.Size(500, 80);
                temp.TabIndex = d;
                temp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
                temp.TextAlign = ContentAlignment.MiddleCenter;
                temp.Click += (object o, EventArgs b) =>
                {
                    panel1.Visible = true;
                    panel2.Visible = true;
                    t_num.Text = room.timePerQuestion.ToString();
                    p_num.Text = room.maxPlayers.ToString();
                    id.Text = room.id.ToString();
                };

                

                controls.Controls.Add(temp);
                d++;
            }
            foreach (Control c in this.Controls)
            {
                c.Font = new Font(pfc.Families[0], 37, FontStyle.Regular);
            }

            foreach (Control c in panel1.Controls)
            {
                c.Font = new Font(pfc.Families[0], 20, FontStyle.Regular);
            }
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_CellPainting(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void second_l_Click(object sender, EventArgs e)
        {

        }


        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        
        private void controls_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                string s = e.ToString();
            }
            catch
            {

            }
        }

       

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void p_num_Click(object sender, EventArgs e)
        {

        }

        private void join_button_Click(object sender, EventArgs e)
        {
            byte[] response = new byte[300];
            JoinRoomResponse res = new JoinRoomResponse();
            joinRoomRequest req = new joinRoomRequest();
            req.roomId = int.Parse(id.Text);
            byte[] request = serializer.buildMessage<joinRoomRequest>(ref req, 7);
            Client.client_socket.Send(request);
            res = serializer.DeAssembleMessage<JoinRoomResponse>(response);
            if (res.status == 1)
            {
                if (lobby == null)
                {

                    lobby = new lobbyRoom(false);

                    lobby.Parent = this;

                }

                lobby.Show();

                this.Hide();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void t_num_Click(object sender, EventArgs e)
        {

        }
    }
}
