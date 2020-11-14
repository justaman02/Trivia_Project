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
    public partial class menu : Form
    {
        
        private Form login_form;
        private statistics statistics_form;
        private top top_form;
        private createRoom create_form;
        private joinRoom join_form;

        public Form Parent
        {

            set
            {

                login_form = value;

            }

        }
        public menu()
        {
            InitializeComponent();
            this.FormClosing += Menu_FormClosing1;
        }

        private void Menu_FormClosing1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            this.stats_pic.Visible = false;
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("../../Resources/Abraham-Regular.ttf");
            foreach (Control c in this.Controls)
            {
                c.Font = new Font(pfc.Families[0], 40, FontStyle.Regular);
            }
        }
        private void stats_MouseHover(object sender, EventArgs e)
        {
            this.stats_pic.Visible = true;
        }
        private void join_MouseHover(object sender, EventArgs e)
        {
            join_pic.Visible = true;
        }
        private void create_MouseHover(object sender, EventArgs e)
        {
            create_pic.Visible = true;
        }
        private void top_MouseHover(object sender, EventArgs e)
        {
            top_pic.Visible = true;
        }
        private void stats_MouseLeave(object sender, EventArgs e)
        {
            this.stats_pic.Visible = false;
        } 
        private void out_MouseHover(object sender, EventArgs e)
        {
            this.logout_pic.Visible = true;
        }
        private void out_MouseLeave(object sender, EventArgs e)
        {
            this.logout_pic.Visible = false;
        }
        private void join_MouseLeave(object sender, EventArgs e)
        {
            this.join_pic.Visible = false;
        }
        private void create_MouseLeave(object sender, EventArgs e)
        {
            this.create_pic.Visible = false;
        }
        private void top_MouseLeave(object sender, EventArgs e)
        {
            this.top_pic.Visible = false;
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            byte[] response = new byte[200];
            byte[] request = serializer.buildMessage(9);
            LogoutResponse res = new LogoutResponse();
            Client.client_socket.Send(request);
            res = serializer.DeAssembleMessage<LogoutResponse>(response);

            if (int.Parse(res.status.ToString()) == 1)
            {
                if (login_form == null)
                {

                    login_form = new login();

                    login_form.Parent = this;

                }

                login_form.Show();

                this.Hide();
            }
            
        }
        private void create_button_Click(object sender, EventArgs e)
        {
            if (create_form == null)
            {

                create_form = new createRoom();

                create_form.Parent = this;

            }

            create_form.Show();

            this.Hide();
        }

        private void stats_button_Click(object sender, EventArgs e)
        {
            if (statistics_form == null)
            {

                statistics_form = new statistics();

                statistics_form.Parent = this;
            }

            statistics_form.Show();

            this.Hide();
        }

        private void join_button_Click(object sender, EventArgs e)
        {
            if (join_form == null)
            {

                join_form = new joinRoom();

                join_form.Parent = this;

            }

            join_form.Show();

            this.Hide();
        }

        private void top_button_Click(object sender, EventArgs e)
        {
            if (top_form == null)
            {

                top_form = new top();

                top_form.Parent = this;

            }

            top_form.Show();

            this.Hide();
        }
    }
}
