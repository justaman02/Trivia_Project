using System;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace mikmakGUI
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.create_button = new System.Windows.Forms.Button();
            this.top_button = new System.Windows.Forms.Button();
            this.join_button = new System.Windows.Forms.Button();
            this.stats_button = new System.Windows.Forms.Button();
            this.stats_pic = new System.Windows.Forms.PictureBox();
            this.join_pic = new System.Windows.Forms.PictureBox();
            this.create_pic = new System.Windows.Forms.PictureBox();
            this.top_pic = new System.Windows.Forms.PictureBox();
            this.logout_button = new System.Windows.Forms.Button();
            this.logout_pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.stats_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.join_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.create_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.top_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logout_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // create_button
            // 
            this.create_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.create_button.BackColor = System.Drawing.Color.Transparent;
            this.create_button.BackgroundImage = global::mikmakGUI.Properties.Resources.base_botton__1_;
            this.create_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.create_button.CausesValidation = false;
            this.create_button.FlatAppearance.BorderSize = 0;
            this.create_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.create_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.create_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.create_button.Font = new System.Drawing.Font("Lucida Console", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(52)))), ((int)(((byte)(153)))));
            this.create_button.Location = new System.Drawing.Point(588, 106);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(328, 107);
            this.create_button.TabIndex = 4;
            this.create_button.Text = "צור חדר";
            this.create_button.UseVisualStyleBackColor = false;
            this.create_button.Click += new System.EventHandler(this.create_button_Click);
            this.create_button.MouseEnter += new System.EventHandler(this.create_MouseHover);
            this.create_button.MouseLeave += new System.EventHandler(this.create_MouseLeave);
            // 
            // top_button
            // 
            this.top_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.top_button.BackColor = System.Drawing.Color.Transparent;
            this.top_button.BackgroundImage = global::mikmakGUI.Properties.Resources.base_botton__1_;
            this.top_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.top_button.CausesValidation = false;
            this.top_button.FlatAppearance.BorderSize = 0;
            this.top_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.top_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.top_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.top_button.Font = new System.Drawing.Font("Lucida Console", 40F, System.Drawing.FontStyle.Bold);
            this.top_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(52)))), ((int)(((byte)(153)))));
            this.top_button.Location = new System.Drawing.Point(588, 373);
            this.top_button.Name = "top_button";
            this.top_button.Size = new System.Drawing.Size(328, 118);
            this.top_button.TabIndex = 5;
            this.top_button.Text = "מובילים";
            this.top_button.UseVisualStyleBackColor = false;
            this.top_button.Click += new System.EventHandler(this.top_button_Click);
            this.top_button.MouseEnter += new System.EventHandler(this.top_MouseHover);
            this.top_button.MouseLeave += new System.EventHandler(this.top_MouseLeave);
            // 
            // join_button
            // 
            this.join_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.join_button.BackColor = System.Drawing.Color.Transparent;
            this.join_button.BackgroundImage = global::mikmakGUI.Properties.Resources.base_botton__1_;
            this.join_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.join_button.CausesValidation = false;
            this.join_button.FlatAppearance.BorderSize = 0;
            this.join_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.join_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.join_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.join_button.Font = new System.Drawing.Font("Lucida Console", 40F, System.Drawing.FontStyle.Bold);
            this.join_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(52)))), ((int)(((byte)(153)))));
            this.join_button.Location = new System.Drawing.Point(588, 235);
            this.join_button.Name = "join_button";
            this.join_button.Size = new System.Drawing.Size(328, 115);
            this.join_button.TabIndex = 6;
            this.join_button.Text = "הכנס לחדר";
            this.join_button.UseVisualStyleBackColor = false;
            this.join_button.Click += new System.EventHandler(this.join_button_Click);
            this.join_button.MouseEnter += new System.EventHandler(this.join_MouseHover);
            this.join_button.MouseLeave += new System.EventHandler(this.join_MouseLeave);
            // 
            // stats_button
            // 
            this.stats_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.stats_button.BackColor = System.Drawing.Color.Transparent;
            this.stats_button.BackgroundImage = global::mikmakGUI.Properties.Resources.base_botton__1_;
            this.stats_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stats_button.CausesValidation = false;
            this.stats_button.FlatAppearance.BorderSize = 0;
            this.stats_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.stats_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.stats_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stats_button.Font = new System.Drawing.Font("Lucida Console", 33F, System.Drawing.FontStyle.Bold);
            this.stats_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(52)))), ((int)(((byte)(153)))));
            this.stats_button.Location = new System.Drawing.Point(110, 408);
            this.stats_button.Name = "stats_button";
            this.stats_button.Size = new System.Drawing.Size(328, 149);
            this.stats_button.TabIndex = 7;
            this.stats_button.Text = "סטטיסטיקות";
            this.stats_button.UseVisualStyleBackColor = false;
            this.stats_button.Click += new System.EventHandler(this.stats_button_Click);
            this.stats_button.MouseEnter += new System.EventHandler(this.stats_MouseHover);
            this.stats_button.MouseLeave += new System.EventHandler(this.stats_MouseLeave);
            // 
            // stats_pic
            // 
            this.stats_pic.BackColor = System.Drawing.Color.Transparent;
            this.stats_pic.Image = global::mikmakGUI.Properties.Resources.mikmak_removebg_preview;
            this.stats_pic.Location = new System.Drawing.Point(188, 235);
            this.stats_pic.Name = "stats_pic";
            this.stats_pic.Size = new System.Drawing.Size(174, 194);
            this.stats_pic.TabIndex = 8;
            this.stats_pic.TabStop = false;
            this.stats_pic.Visible = false;
            // 
            // join_pic
            // 
            this.join_pic.BackColor = System.Drawing.Color.Transparent;
            this.join_pic.Image = global::mikmakGUI.Properties.Resources.smaller_mikmak;
            this.join_pic.Location = new System.Drawing.Point(547, 245);
            this.join_pic.Name = "join_pic";
            this.join_pic.Size = new System.Drawing.Size(66, 90);
            this.join_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.join_pic.TabIndex = 9;
            this.join_pic.TabStop = false;
            this.join_pic.Visible = false;
            // 
            // create_pic
            // 
            this.create_pic.BackColor = System.Drawing.Color.Transparent;
            this.create_pic.Image = global::mikmakGUI.Properties.Resources.smaller_mikmak;
            this.create_pic.Location = new System.Drawing.Point(547, 106);
            this.create_pic.Name = "create_pic";
            this.create_pic.Size = new System.Drawing.Size(66, 90);
            this.create_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.create_pic.TabIndex = 10;
            this.create_pic.TabStop = false;
            this.create_pic.Visible = false;
            // 
            // top_pic
            // 
            this.top_pic.BackColor = System.Drawing.Color.Transparent;
            this.top_pic.Image = global::mikmakGUI.Properties.Resources.smaller_mikmak;
            this.top_pic.Location = new System.Drawing.Point(547, 385);
            this.top_pic.Name = "top_pic";
            this.top_pic.Size = new System.Drawing.Size(66, 90);
            this.top_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.top_pic.TabIndex = 11;
            this.top_pic.TabStop = false;
            this.top_pic.Visible = false;
            // 
            // logout_button
            // 
            this.logout_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.logout_button.BackColor = System.Drawing.Color.Transparent;
            this.logout_button.BackgroundImage = global::mikmakGUI.Properties.Resources.base_botton__1_;
            this.logout_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logout_button.CausesValidation = false;
            this.logout_button.FlatAppearance.BorderSize = 0;
            this.logout_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.logout_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.logout_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_button.Font = new System.Drawing.Font("Lucida Console", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(52)))), ((int)(((byte)(153)))));
            this.logout_button.Location = new System.Drawing.Point(12, 12);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(266, 105);
            this.logout_button.TabIndex = 12;
            this.logout_button.Text = "יציאה";
            this.logout_button.UseVisualStyleBackColor = false;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            this.logout_button.MouseEnter += new System.EventHandler(this.out_MouseHover);
            this.logout_button.MouseLeave += new System.EventHandler(this.out_MouseLeave);
            // 
            // logout_pic
            // 
            this.logout_pic.BackColor = System.Drawing.Color.Transparent;
            this.logout_pic.Image = global::mikmakGUI.Properties.Resources.logout_pic;
            this.logout_pic.Location = new System.Drawing.Point(255, 29);
            this.logout_pic.Name = "logout_pic";
            this.logout_pic.Size = new System.Drawing.Size(65, 63);
            this.logout_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logout_pic.TabIndex = 13;
            this.logout_pic.TabStop = false;
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(897, 540);
            this.Controls.Add(this.logout_pic);
            this.Controls.Add(this.logout_button);
            this.Controls.Add(this.top_pic);
            this.Controls.Add(this.create_pic);
            this.Controls.Add(this.join_pic);
            this.Controls.Add(this.stats_pic);
            this.Controls.Add(this.stats_button);
            this.Controls.Add(this.join_button);
            this.Controls.Add(this.top_button);
            this.Controls.Add(this.create_button);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(913, 579);
            this.MinimumSize = new System.Drawing.Size(913, 579);
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menu";
            this.Load += new System.EventHandler(this.menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stats_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.join_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.create_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.top_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logout_pic)).EndInit();
            this.ResumeLayout(false);

        }

        private void Menu_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            Application.Exit();
        }



        #endregion
        private System.Windows.Forms.Button create_button;
        private System.Windows.Forms.Button top_button;
        private System.Windows.Forms.Button join_button;
        private System.Windows.Forms.Button stats_button;
        private System.Windows.Forms.PictureBox stats_pic;
        private System.Windows.Forms.PictureBox join_pic;
        private System.Windows.Forms.PictureBox create_pic;
        private System.Windows.Forms.PictureBox top_pic;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.PictureBox logout_pic;
    }
}