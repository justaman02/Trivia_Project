using mikmakGUI.Properties;
using System.Drawing;
using System.Windows.Forms;

namespace mikmakGUI
{
    partial class joinRoom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.controls = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.t_num = new System.Windows.Forms.Label();
            this.q_num = new System.Windows.Forms.Label();
            this.p_num = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.join_button = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.Label();
            this.controls.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(1)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(167, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(426, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "בחר חדר";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // controls
            // 
            this.controls.AutoScroll = true;
            this.controls.AutoScrollMinSize = new System.Drawing.Size(0, 100);
            this.controls.BackColor = System.Drawing.Color.Transparent;
            this.controls.Controls.Add(this.label3);
            this.controls.Location = new System.Drawing.Point(234, 80);
            this.controls.Name = "controls";
            this.controls.Size = new System.Drawing.Size(548, 424);
            this.controls.TabIndex = 7;
            this.controls.Paint += new System.Windows.Forms.PaintEventHandler(this.controls_Paint);
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(123, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 198);
            this.label3.TabIndex = 0;
            this.label3.Text = "אין חדרים תרקדו";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.id);
            this.panel1.Controls.Add(this.join_button);
            this.panel1.Controls.Add(this.t_num);
            this.panel1.Controls.Add(this.q_num);
            this.panel1.Controls.Add(this.p_num);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 184);
            this.panel1.TabIndex = 8;
            this.panel1.Visible = false;
            // 
            // t_num
            // 
            this.t_num.Location = new System.Drawing.Point(3, 64);
            this.t_num.Name = "t_num";
            this.t_num.Size = new System.Drawing.Size(89, 54);
            this.t_num.TabIndex = 5;
            this.t_num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.t_num.Click += new System.EventHandler(this.t_num_Click);
            // 
            // q_num
            // 
            this.q_num.Location = new System.Drawing.Point(3, 58);
            this.q_num.Name = "q_num";
            this.q_num.Size = new System.Drawing.Size(86, 58);
            this.q_num.TabIndex = 4;
            this.q_num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p_num
            // 
            this.p_num.Location = new System.Drawing.Point(6, 1);
            this.p_num.Name = "p_num";
            this.p_num.Size = new System.Drawing.Size(86, 54);
            this.p_num.TabIndex = 3;
            this.p_num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.p_num.Click += new System.EventHandler(this.p_num_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(98, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 58);
            this.label4.TabIndex = 2;
            this.label4.Text = "זמן לשאלה";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(99, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 57);
            this.label2.TabIndex = 0;
            this.label2.Text = "מספר שחקנים";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(4, 198);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 190);
            this.panel2.TabIndex = 9;
            this.panel2.Visible = false;
            // 
            // join_button
            // 
            this.join_button.BackColor = System.Drawing.Color.Transparent;
            this.join_button.BackgroundImage = global::mikmakGUI.Properties.Resources.base_botton__1_;
            this.join_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.join_button.FlatAppearance.BorderSize = 0;
            this.join_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.join_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.join_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.join_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.join_button.Location = new System.Drawing.Point(-3, 98);
            this.join_button.Name = "join_button";
            this.join_button.Size = new System.Drawing.Size(235, 99);
            this.join_button.TabIndex = 30;
            this.join_button.Text = "הכנס לחדר";
            this.join_button.UseVisualStyleBackColor = false;
            this.join_button.Click += new System.EventHandler(this.join_button_Click);
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(96, 48);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(0, 13);
            this.id.TabIndex = 31;
            this.id.Visible = false;
            // 
            // joinRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImage = global::mikmakGUI.Properties.Resources.pyramidBack_jpg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1027, 551);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.controls);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1043, 590);
            this.MinimumSize = new System.Drawing.Size(1043, 590);
            this.Name = "joinRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "joinRoom";
            this.Load += new System.EventHandler(this.joinRoom_Load);
            this.controls.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }





        private void JoinRoom_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            Application.Exit();
        }

        #endregion
        private Label label1;
        private Panel controls;
        private Panel panel1;
        private Label t_num;
        private Label q_num;
        private Label p_num;
        private Label label4;
        private Label label2;
        private Label label3;
        private Panel panel2;
        private Button join_button;
        private Label id;
    }
}