using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mikmakGUI
{ 
    
    public partial class lobbyRoom : Form
    {
        private Form menu;
        private game game_form;
        private List<Label> players_;
        private Thread t;
        private int originalTimeout;
        private bool isAdmin;
        public Form Parent
        {

            set
            {

                menu = value;

            }
        }
        public lobbyRoom(bool admin)
        {
            InitializeComponent();
            if(admin)
            {
                this.button1.Visible = true;
            }
            isAdmin = admin;
            this.FormClosing += LobbyRoom_FormClosing;
            players_ = new List<Label>();
            this.t = new Thread(new ThreadStart(this.listen));
            this.originalTimeout = Client.client_socket.ReceiveTimeout;
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("../../Resources/Abraham-Regular.ttf");
            foreach (Control c in this.Controls)
            {
                c.Font = new Font(pfc.Families[0], 20, FontStyle.Regular);
            }
            this.Shown += LobbyRoom_Shown;

        }

        private void LobbyRoom_Shown(object sender, EventArgs e)
        {
            if(!isAdmin)
            {
                this.t.Join();
                this.t.Abort();
                Client.client_socket.ReceiveTimeout = this.originalTimeout;
                loadMember();
            }
        }

        private void lobbyRoom_Load(object sender, EventArgs e)
        {
            players_.Add(this.admin);
            players_.Add(this.label3);
            players_.Add(this.label2);
            players_.Add(this.label4);
            players_.Add(this.label1);
            players_.Add(this.label0);
            players_.Add(this.label5);
            this.loadState();

            this.t.Start();
   
        }
        private void loadMember()
        {
            if (game_form == null)
            {

                game_form = new game();

                game_form.Parent = this;

            }

            game_form.Show();

            this.Hide();
        }
        public void loadState()
        {
            byte[] response = new byte[500];
            GetRoomStateReponse res = new GetRoomStateReponse();
            byte[] request = serializer.buildMessage(19);
            Client.client_socket.Send(request);
            res = serializer.DeAssembleMessage<GetRoomStateReponse>(response);
            if (res.status == 1)
            {
                for(int i = 0;i<res.players.Count;i++)
                {
                    if(players_[i].Text == "")
                    {
                        players_[i].Text = res.players[i];
                    }
                }
                for (int i = players_.Count; i > res.players.Count; i--)
                {

                    players_[i-1].Text = "";
                   
                }
                this.time.Text = res.answerTimeout.ToString();
                this.questions.Text = res.questionCount.ToString();
                this.players.Text = res.players.Count.ToString();

            }
        }
        private void LobbyRoom_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.t.Abort();
            Client.client_socket.ReceiveTimeout = this.originalTimeout;
            byte[] response = new byte[200];
            GameStartResponse res = new GameStartResponse();
            byte[] request = serializer.buildMessage(17);
            Client.client_socket.Send(request);

            lock(Client.locker)
            {
                res = serializer.DeAssembleMessage<GameStartResponse>(response);

            }
            
            if(res.status == 1)
            {
                if (game_form == null)
                {

                    game_form = new game();

                    game_form.Parent = this;

                }

                game_form.Show();

                this.Hide();

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void admin_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            loadState();
        }

        private void time_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            byte[] response = new byte[200];
            LeaveRoomResponse res = new LeaveRoomResponse();
            byte[] request = serializer.buildMessage(18);
            Client.client_socket.Send(request);
            res = serializer.DeAssembleMessage<LeaveRoomResponse>(response);
            if(res.status == 1)
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
        private void listen()
        {
            
            while (true)
            {
                Client.client_socket.ReceiveTimeout = 1;
                GameStartResponse resS = new GameStartResponse();
                GetRoomStateReponse res = new GetRoomStateReponse();
                byte[] response = new byte[200];
                byte[] code = new byte[1];
                int  bytes= -1;
                try
                {
                    lock(Client.locker)
                        {
                        bytes = Client.client_socket.Receive(code, 1, 0);
                    }
                     
                }
                catch
                {
                    Console.Write("Hello World");
                }
                if(bytes == 0 || bytes == -1)
                {
                    Client.client_socket.ReceiveTimeout = originalTimeout;
                    byte[] request = serializer.buildMessage(19);
                    lock (Client.locker)
                    {
                        Client.client_socket.Send(request);
                        Client.client_socket.Receive(code, 1, 0);
                    }
                }
                if(bytes == 1)
                {
                    Console.Write("Hello World");
                }
                
                if (code[0] == 17)
                {
                    resS = serializer.DeAssembleMessageForThread<GameStartResponse>(response);
                    if (resS.status == 1)
                    {
                        return;
                    }
                }
                else
                {
                    res = serializer.DeAssembleMessageForThread<GetRoomStateReponse>(response);
                    if (res.status == 1)
                    {
                        for (int i = 0; i < res.players.Count; i++)
                        {
                            if (players_[i].Text == "")
                            {
                                players_[i].Text = res.players[i];
                            }
                        }
                        for (int i = players_.Count; i > res.players.Count; i--)
                        {

                            players_[i - 1].Text = "";

                        }
                    }
                }
                Thread.Sleep(3000);
            }
        }
    }
    class threads
    {
        public static void listenToUpdate()
        {
           
            
        }
    }
}
