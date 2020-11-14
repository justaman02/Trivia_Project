using mikmakGUI.Requests;
using mikmakGUI.responses;
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
    public partial class game : Form
    {
        private int questions;
        private Form menu;
        public Form Parent
        {

            set
            {

                menu = value;

            }
        }
        public game()
        {
            this.questions = 0;
            InitializeComponent();
            this.FormClosing += Game_FormClosing;
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile("../../Resources/Abraham-Regular.ttf");
            foreach (Control c in this.Controls)
            {
                c.Font = new Font(pfc.Families[0], 20, FontStyle.Regular);
            }
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.submitAnswer(2);
        }

        private void game_Load(object sender, EventArgs e)
        {
            getQuestion();
        }
        private void getQuestion()
        {
            byte[] response = new byte[500];
            GetQuestionResponse res = new GetQuestionResponse();
            byte[] request = serializer.buildMessage(21);
            Client.client_socket.Send(request);
            res = serializer.DeDictionary<GetQuestionResponse>(response);

            if (res.status == 1)
            {
                this.label4.Text = res.question;
                this.one.Text = res.answers["0"];
                this.two.Text = res.answers["1"];
                this.three.Text = res.answers["2"];
                this.four.Text = res.answers["3"];
            }
        }
        private void one_Click(object sender, EventArgs e)
        {
            this.submitAnswer(0);
        }
        private void submitAnswer(int ans)
        {
            this.questions++;
            byte[] response = new byte[500];
            SubmitAnswerRequest req = new SubmitAnswerRequest();
            req.answerId = ans;
            SubmitAnswerResponse res = new SubmitAnswerResponse();
            byte[] request = serializer.buildMessage<SubmitAnswerRequest>(ref req,22);
            Client.client_socket.Send(request);
            res = serializer.DeAssembleMessage<SubmitAnswerResponse>(response);
            if(res.status == 1)
            {
                getQuestion();
            }
        }
       

        private void two_Click(object sender, EventArgs e)
        {
            this.submitAnswer(1);
        }

        private void four_Click(object sender, EventArgs e)
        {
            this.submitAnswer(3);
        }
    }
}
