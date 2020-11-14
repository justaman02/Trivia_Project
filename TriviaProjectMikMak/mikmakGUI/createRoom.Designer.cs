using System.Windows.Forms;

namespace mikmakGUI
{
    partial class createRoom
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.name_text = new mikmakGUI.CueTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.players_text = new mikmakGUI.CueTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.time_text = new mikmakGUI.CueTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.q_text = new mikmakGUI.CueTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel1.Controls.Add(this.name_text);
            this.panel1.Location = new System.Drawing.Point(203, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 59);
            this.panel1.TabIndex = 23;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // name_text
            // 
            this.name_text.BackColor = System.Drawing.Color.SlateBlue;
            this.name_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_text.Cue = "שם החדר";
            this.name_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.name_text.ForeColor = System.Drawing.SystemColors.Control;
            this.name_text.Location = new System.Drawing.Point(3, 3);
            this.name_text.Multiline = true;
            this.name_text.Name = "name_text";
            this.name_text.Size = new System.Drawing.Size(358, 53);
            this.name_text.TabIndex = 19;
            this.name_text.TextChanged += new System.EventHandler(this.cueTextBox1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel2.Controls.Add(this.players_text);
            this.panel2.Location = new System.Drawing.Point(203, 175);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(364, 59);
            this.panel2.TabIndex = 24;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // players_text
            // 
            this.players_text.BackColor = System.Drawing.Color.SlateBlue;
            this.players_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.players_text.Cue = "שם החדר";
            this.players_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.players_text.ForeColor = System.Drawing.SystemColors.Control;
            this.players_text.Location = new System.Drawing.Point(3, 3);
            this.players_text.Multiline = true;
            this.players_text.Name = "players_text";
            this.players_text.Size = new System.Drawing.Size(358, 53);
            this.players_text.TabIndex = 20;
            this.players_text.TextChanged += new System.EventHandler(this.players_text_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel3.Controls.Add(this.time_text);
            this.panel3.Location = new System.Drawing.Point(203, 262);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(364, 59);
            this.panel3.TabIndex = 24;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // time_text
            // 
            this.time_text.BackColor = System.Drawing.Color.SlateBlue;
            this.time_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.time_text.Cue = "שם החדר";
            this.time_text.Cursor = System.Windows.Forms.Cursors.No;
            this.time_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.time_text.ForeColor = System.Drawing.SystemColors.Control;
            this.time_text.Location = new System.Drawing.Point(3, 3);
            this.time_text.Multiline = true;
            this.time_text.Name = "time_text";
            this.time_text.Size = new System.Drawing.Size(358, 53);
            this.time_text.TabIndex = 21;
            this.time_text.TextChanged += new System.EventHandler(this.time_text_TextChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel4.Controls.Add(this.q_text);
            this.panel4.Location = new System.Drawing.Point(203, 348);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(364, 59);
            this.panel4.TabIndex = 24;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // q_text
            // 
            this.q_text.BackColor = System.Drawing.Color.SlateBlue;
            this.q_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.q_text.Cue = "שם החדר";
            this.q_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.q_text.Location = new System.Drawing.Point(3, 3);
            this.q_text.Multiline = true;
            this.q_text.Name = "q_text";
            this.q_text.Size = new System.Drawing.Size(358, 53);
            this.q_text.TabIndex = 25;
            this.q_text.TextChanged += new System.EventHandler(this.q_text_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(1)))), ((int)(((byte)(85)))));
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 30F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(573, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 59);
            this.label1.TabIndex = 25;
            this.label1.Text = "שם החדר";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(1)))), ((int)(((byte)(85)))));
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 30F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(570, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 59);
            this.label2.TabIndex = 26;
            this.label2.Text = "מספר שאלות";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(1)))), ((int)(((byte)(85)))));
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 30F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(570, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(287, 59);
            this.label3.TabIndex = 27;
            this.label3.Text = "זמן לשאלה";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(1)))), ((int)(((byte)(85)))));
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 30F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(570, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(287, 70);
            this.label4.TabIndex = 28;
            this.label4.Text = "מספר שחקנים";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::mikmakGUI.Properties.Resources.base_botton__1_;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(237, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(287, 103);
            this.button1.TabIndex = 29;
            this.button1.Text = "צור חדר";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::mikmakGUI.Properties.Resources.back;
            this.pictureBox1.Location = new System.Drawing.Point(-7, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 137);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // createRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = global::mikmakGUI.Properties.Resources.pyramidBack_jpg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1027, 551);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1043, 590);
            this.MinimumSize = new System.Drawing.Size(1043, 590);
            this.Name = "createRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "createRoom";
            this.Load += new System.EventHandler(this.createRoom_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }


        private void CreateRoom_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            Application.Exit();
        }

        #endregion

        private CueTextBox name_text;
        private System.Windows.Forms.Panel panel1;
        private CueTextBox players_text;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private CueTextBox time_text;
        private System.Windows.Forms.Panel panel4;
        private CueTextBox q_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}