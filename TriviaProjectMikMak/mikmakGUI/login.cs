using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace mikmakGUI
{
    public partial class login : Form
    {
        private register register_form;
        private menu menu_form;
        public login()
        {
            InitializeComponent();
            this.FormClosed += Login_FormClosing;
        }

        private void Login_FormClosing(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if(register_form== null) {

                register_form = new register();

                register_form.Parent = this;

            }

            register_form.Show();

            this.Hide();
        }

        private void start_button_Click(object sender, EventArgs e)
        {
            byte[] response = new byte[200];
            LoginRequest req = new LoginRequest();
            LoginResponse res = new LoginResponse();
            req.username = name_text.Text;
            req.password = pass_text.Text;
            byte [] request = serializer.buildMessage<LoginRequest>(ref req, 1);
            Client.client_socket.Send(request);
            res = serializer.DeAssembleMessage<LoginResponse>(response);
            
            if(int.Parse(res.status.ToString()) == 1)
            {
                if (menu_form == null)
                {

                    menu_form = new menu();

                    menu_form.Parent = this;

                }

                menu_form.Show();

                this.Hide();
            }
            else
            {
                label3.Visible = true;
            }
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void name_text_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
