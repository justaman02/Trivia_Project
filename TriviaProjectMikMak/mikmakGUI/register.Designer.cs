using System.Windows.Forms;

namespace mikmakGUI
{
    partial class register
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
            this.pass_text = new System.Windows.Forms.TextBox();
            this.name_text = new System.Windows.Forms.TextBox();
            this.email_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.reg_button = new WindowsFormsApplication1.RoundButton();
            this.reg_pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.reg_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // pass_text
            // 
            this.pass_text.BackColor = System.Drawing.Color.AliceBlue;
            this.pass_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass_text.Location = new System.Drawing.Point(443, 248);
            this.pass_text.Multiline = true;
            this.pass_text.Name = "pass_text";
            this.pass_text.Size = new System.Drawing.Size(314, 63);
            this.pass_text.TabIndex = 3;
            this.pass_text.UseSystemPasswordChar = true;
            // 
            // name_text
            // 
            this.name_text.BackColor = System.Drawing.Color.AliceBlue;
            this.name_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_text.Location = new System.Drawing.Point(443, 34);
            this.name_text.Multiline = true;
            this.name_text.Name = "name_text";
            this.name_text.Size = new System.Drawing.Size(314, 63);
            this.name_text.TabIndex = 4;
            this.name_text.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // email_text
            // 
            this.email_text.BackColor = System.Drawing.Color.AliceBlue;
            this.email_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_text.Location = new System.Drawing.Point(443, 137);
            this.email_text.Multiline = true;
            this.email_text.Name = "email_text";
            this.email_text.Size = new System.Drawing.Size(314, 63);
            this.email_text.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(778, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 45);
            this.label1.TabIndex = 6;
            this.label1.Text = "שם משתמש";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(794, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 45);
            this.label2.TabIndex = 7;
            this.label2.Text = "סיסמה";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(794, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 45);
            this.label3.TabIndex = 8;
            this.label3.Text = "אימייל";
            // 
            // reg_button
            // 
            this.reg_button.BackColor = System.Drawing.Color.Yellow;
            this.reg_button.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.reg_button.FlatAppearance.BorderSize = 10;
            this.reg_button.Font = new System.Drawing.Font("Arial Black", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.reg_button.ForeColor = System.Drawing.Color.RoyalBlue;
            this.reg_button.Location = new System.Drawing.Point(443, 368);
            this.reg_button.Name = "reg_button";
            this.reg_button.Size = new System.Drawing.Size(321, 92);
            this.reg_button.TabIndex = 9;
            this.reg_button.Text = "הירשם";
            this.reg_button.UseVisualStyleBackColor = false;
            this.reg_button.Click += new System.EventHandler(this.reg_button_Click);
            this.reg_button.MouseEnter += new System.EventHandler(this.reg_button_hover);
            this.reg_button.MouseLeave += new System.EventHandler(this.reg_button_leave);
            // 
            // reg_pic
            // 
            this.reg_pic.BackColor = System.Drawing.Color.Transparent;
            this.reg_pic.Image = global::mikmakGUI.Properties.Resources.smaller_mikmak;
            this.reg_pic.Location = new System.Drawing.Point(340, 344);
            this.reg_pic.Name = "reg_pic";
            this.reg_pic.Size = new System.Drawing.Size(97, 142);
            this.reg_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.reg_pic.TabIndex = 10;
            this.reg_pic.TabStop = false;
            this.reg_pic.Visible = false;
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(991, 540);
            this.Controls.Add(this.reg_pic);
            this.Controls.Add(this.reg_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.email_text);
            this.Controls.Add(this.name_text);
            this.Controls.Add(this.pass_text);
            this.DoubleBuffered = true;
            this.Name = "register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainmenu";
            this.Load += new System.EventHandler(this.register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reg_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Register_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            Application.Exit();
        }

        #endregion
        private System.Windows.Forms.TextBox pass_text;
        private System.Windows.Forms.TextBox name_text;
        private System.Windows.Forms.TextBox email_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private WindowsFormsApplication1.RoundButton reg_button;
        private System.Windows.Forms.PictureBox reg_pic;
    }
}