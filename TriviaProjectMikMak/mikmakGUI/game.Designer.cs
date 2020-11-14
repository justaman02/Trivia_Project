namespace mikmakGUI
{
    partial class game
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
            this.one = new System.Windows.Forms.Label();
            this.two = new System.Windows.Forms.Label();
            this.three = new System.Windows.Forms.Label();
            this.four = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.Color.SlateBlue;
            this.one.Location = new System.Drawing.Point(430, 242);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(422, 63);
            this.one.TabIndex = 1;
            this.one.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.Color.SlateBlue;
            this.two.Location = new System.Drawing.Point(427, 322);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(425, 62);
            this.two.TabIndex = 2;
            this.two.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.Color.SlateBlue;
            this.three.Location = new System.Drawing.Point(430, 396);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(425, 58);
            this.three.TabIndex = 3;
            this.three.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.three.Click += new System.EventHandler(this.label2_Click);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.Color.SlateBlue;
            this.four.Location = new System.Drawing.Point(427, 471);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(425, 63);
            this.four.TabIndex = 4;
            this.four.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.SlateBlue;
            this.label4.Location = new System.Drawing.Point(379, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(514, 115);
            this.label4.TabIndex = 5;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::mikmakGUI.Properties.Resources.pyramid;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1265, 791);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.four);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.HelpButton = true;
            this.MaximumSize = new System.Drawing.Size(1281, 900);
            this.MinimumSize = new System.Drawing.Size(1281, 720);
            this.Name = "game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "game";
            this.Load += new System.EventHandler(this.game_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label one;
        private System.Windows.Forms.Label two;
        private System.Windows.Forms.Label three;
        private System.Windows.Forms.Label four;
        private System.Windows.Forms.Label label4;
    }
}