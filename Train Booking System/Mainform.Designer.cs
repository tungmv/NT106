﻿namespace Train_Booking_System
{
    partial class Mainform
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.FlowLayoutSidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.FlowLayoutMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.PictureBoxMenu = new System.Windows.Forms.PictureBox();
            this.ButtonMyAccount = new System.Windows.Forms.Button();
            this.ButtonBooking = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TimerSidebar = new System.Windows.Forms.Timer(this.components);
            this.FlowLayoutSidebar.SuspendLayout();
            this.FlowLayoutMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // FlowLayoutSidebar
            // 
            this.FlowLayoutSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.FlowLayoutSidebar.Controls.Add(this.FlowLayoutMenu);
            this.FlowLayoutSidebar.Controls.Add(this.ButtonMyAccount);
            this.FlowLayoutSidebar.Controls.Add(this.ButtonBooking);
            this.FlowLayoutSidebar.Controls.Add(this.button4);
            this.FlowLayoutSidebar.Controls.Add(this.button1);
            this.FlowLayoutSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.FlowLayoutSidebar.Location = new System.Drawing.Point(0, 0);
            this.FlowLayoutSidebar.MaximumSize = new System.Drawing.Size(228, 611);
            this.FlowLayoutSidebar.MinimumSize = new System.Drawing.Size(76, 611);
            this.FlowLayoutSidebar.Name = "FlowLayoutSidebar";
            this.FlowLayoutSidebar.Size = new System.Drawing.Size(228, 611);
            this.FlowLayoutSidebar.TabIndex = 0;
            // 
            // FlowLayoutMenu
            // 
            this.FlowLayoutMenu.Controls.Add(this.label1);
            this.FlowLayoutMenu.Controls.Add(this.PictureBoxMenu);
            this.FlowLayoutMenu.Location = new System.Drawing.Point(3, 3);
            this.FlowLayoutMenu.MinimumSize = new System.Drawing.Size(224, 100);
            this.FlowLayoutMenu.Name = "FlowLayoutMenu";
            this.FlowLayoutMenu.Size = new System.Drawing.Size(224, 100);
            this.FlowLayoutMenu.TabIndex = 1;
            this.FlowLayoutMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // PictureBoxMenu
            // 
            this.PictureBoxMenu.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxMenu.Image")));
            this.PictureBoxMenu.Location = new System.Drawing.Point(18, 29);
            this.PictureBoxMenu.Name = "PictureBoxMenu";
            this.PictureBoxMenu.Size = new System.Drawing.Size(43, 44);
            this.PictureBoxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxMenu.TabIndex = 0;
            this.PictureBoxMenu.TabStop = false;
            this.PictureBoxMenu.Click += new System.EventHandler(this.PictureBoxMenu_Click);
            // 
            // ButtonMyAccount
            // 
            this.ButtonMyAccount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ButtonMyAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMyAccount.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonMyAccount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonMyAccount.Image = ((System.Drawing.Image)(resources.GetObject("ButtonMyAccount.Image")));
            this.ButtonMyAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonMyAccount.Location = new System.Drawing.Point(3, 109);
            this.ButtonMyAccount.Name = "ButtonMyAccount";
            this.ButtonMyAccount.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ButtonMyAccount.Size = new System.Drawing.Size(224, 55);
            this.ButtonMyAccount.TabIndex = 1;
            this.ButtonMyAccount.Text = "My Account";
            this.ButtonMyAccount.UseVisualStyleBackColor = true;
            this.ButtonMyAccount.Click += new System.EventHandler(this.ButtonMyAccount_Click);
            // 
            // ButtonBooking
            // 
            this.ButtonBooking.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ButtonBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBooking.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBooking.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonBooking.Image = ((System.Drawing.Image)(resources.GetObject("ButtonBooking.Image")));
            this.ButtonBooking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonBooking.Location = new System.Drawing.Point(3, 170);
            this.ButtonBooking.Name = "ButtonBooking";
            this.ButtonBooking.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.ButtonBooking.Size = new System.Drawing.Size(224, 55);
            this.ButtonBooking.TabIndex = 2;
            this.ButtonBooking.Text = "Booking";
            this.ButtonBooking.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(3, 231);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(224, 55);
            this.button4.TabIndex = 3;
            this.button4.Text = "Tickets";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 292);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(224, 55);
            this.button1.TabIndex = 4;
            this.button1.Text = "History";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TimerSidebar
            // 
            this.TimerSidebar.Tick += new System.EventHandler(this.TimerSidebar_Tick);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 611);
            this.Controls.Add(this.FlowLayoutSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Mainform";
            this.Text = "BookingForm";
            this.FlowLayoutSidebar.ResumeLayout(false);
            this.FlowLayoutMenu.ResumeLayout(false);
            this.FlowLayoutMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlowLayoutSidebar;
        private System.Windows.Forms.Panel FlowLayoutMenu;
        private System.Windows.Forms.Button ButtonMyAccount;
        private System.Windows.Forms.Button ButtonBooking;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer TimerSidebar;
        private System.Windows.Forms.PictureBox PictureBoxMenu;
    }
}