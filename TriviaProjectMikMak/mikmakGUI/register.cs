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

    public partial class register : Form
    {
        private Form login;
        private Form next;

        public Form Parent
        {

            set
            {

                login = value;

            }

        }
        public register()
        {
            InitializeComponent();
            this.FormClosing += Register_FormClosing1;
        }

        private void Register_FormClosing1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void reg_button_Click(object sender, EventArgs e)
        {
            byte[] response = new byte[200];
            SignupRequest req = new SignupRequest();
            SignupResponse res = new SignupResponse();
            req.username = name_text.Text;
            req.password = pass_text.Text;
            req.mail = email_text.Text;
            byte[] request = serializer.buildMessage<SignupRequest>(ref req, 2);
            Client.client_socket.Send(request);
            res = serializer.DeAssembleMessage<SignupResponse>(response);
            if(int.Parse(res.status.ToString()) == 1)
            {
                if (login == null)
                {

                    login = new login();

                    login.Parent = this;

                }
                next = new login();

                next.Show();

                this.Hide();
            }
            
        }
        private void reg_button_hover(object sender, EventArgs e)
        {
            this.reg_pic.Visible = true;
        }
        private void reg_button_leave(object sender, EventArgs e)
        {
            this.reg_pic.Visible = false;
        }

        private void register_Load(object sender, EventArgs e)
        {

        }
    }
}
