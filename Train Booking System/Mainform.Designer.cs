namespace Train_Booking_System
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
            this.TimerSidebar = new System.Windows.Forms.Timer(this.components);
            this.PictureBoxMenu = new System.Windows.Forms.PictureBox();
            this.ButtonMyAccount = new System.Windows.Forms.Button();
            this.ButtonBooking = new System.Windows.Forms.Button();
            this.ButtonTickets = new System.Windows.Forms.Button();
            this.Exitbtn = new System.Windows.Forms.Button();
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
            this.FlowLayoutSidebar.Controls.Add(this.ButtonTickets);
            this.FlowLayoutSidebar.Controls.Add(this.Exitbtn);
            this.FlowLayoutSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.FlowLayoutSidebar.Location = new System.Drawing.Point(0, 0);
            this.FlowLayoutSidebar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FlowLayoutSidebar.MaximumSize = new System.Drawing.Size(342, 940);
            this.FlowLayoutSidebar.MinimumSize = new System.Drawing.Size(114, 940);
            this.FlowLayoutSidebar.Name = "FlowLayoutSidebar";
            this.FlowLayoutSidebar.Size = new System.Drawing.Size(342, 940);
            this.FlowLayoutSidebar.TabIndex = 0;
            // 
            // FlowLayoutMenu
            // 
            this.FlowLayoutMenu.Controls.Add(this.label1);
            this.FlowLayoutMenu.Controls.Add(this.PictureBoxMenu);
            this.FlowLayoutMenu.Location = new System.Drawing.Point(4, 5);
            this.FlowLayoutMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FlowLayoutMenu.MinimumSize = new System.Drawing.Size(336, 154);
            this.FlowLayoutMenu.Name = "FlowLayoutMenu";
            this.FlowLayoutMenu.Size = new System.Drawing.Size(336, 154);
            this.FlowLayoutMenu.TabIndex = 1;
            this.FlowLayoutMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // TimerSidebar
            // 
            this.TimerSidebar.Tick += new System.EventHandler(this.TimerSidebar_Tick);
            // 
            // PictureBoxMenu
            // 
            this.PictureBoxMenu.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxMenu.Image")));
            this.PictureBoxMenu.Location = new System.Drawing.Point(27, 45);
            this.PictureBoxMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PictureBoxMenu.Name = "PictureBoxMenu";
            this.PictureBoxMenu.Size = new System.Drawing.Size(64, 68);
            this.PictureBoxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxMenu.TabIndex = 0;
            this.PictureBoxMenu.TabStop = false;
            this.PictureBoxMenu.Click += new System.EventHandler(this.PictureBoxMenu_Click);
            // 
            // ButtonMyAccount
            // 
            this.ButtonMyAccount.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ButtonMyAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMyAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonMyAccount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonMyAccount.Image = ((System.Drawing.Image)(resources.GetObject("ButtonMyAccount.Image")));
            this.ButtonMyAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonMyAccount.Location = new System.Drawing.Point(4, 169);
            this.ButtonMyAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonMyAccount.Name = "ButtonMyAccount";
            this.ButtonMyAccount.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.ButtonMyAccount.Size = new System.Drawing.Size(336, 85);
            this.ButtonMyAccount.TabIndex = 1;
            this.ButtonMyAccount.Text = "My Account";
            this.ButtonMyAccount.UseVisualStyleBackColor = true;
            this.ButtonMyAccount.Click += new System.EventHandler(this.ButtonMyAccount_Click);
            // 
            // ButtonBooking
            // 
            this.ButtonBooking.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ButtonBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBooking.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonBooking.Image = ((System.Drawing.Image)(resources.GetObject("ButtonBooking.Image")));
            this.ButtonBooking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonBooking.Location = new System.Drawing.Point(4, 264);
            this.ButtonBooking.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonBooking.Name = "ButtonBooking";
            this.ButtonBooking.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.ButtonBooking.Size = new System.Drawing.Size(336, 85);
            this.ButtonBooking.TabIndex = 2;
            this.ButtonBooking.Text = "Booking";
            this.ButtonBooking.UseVisualStyleBackColor = true;
            this.ButtonBooking.Click += new System.EventHandler(this.ButtonBooking_Click);
            // 
            // ButtonTickets
            // 
            this.ButtonTickets.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ButtonTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonTickets.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonTickets.Image = ((System.Drawing.Image)(resources.GetObject("ButtonTickets.Image")));
            this.ButtonTickets.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonTickets.Location = new System.Drawing.Point(4, 359);
            this.ButtonTickets.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonTickets.Name = "ButtonTickets";
            this.ButtonTickets.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.ButtonTickets.Size = new System.Drawing.Size(336, 85);
            this.ButtonTickets.TabIndex = 3;
            this.ButtonTickets.Text = "Tickets";
            this.ButtonTickets.UseVisualStyleBackColor = true;
            this.ButtonTickets.Click += new System.EventHandler(this.ButtonTicketClick);
            // 
            // Exitbtn
            // 
            this.Exitbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Exitbtn.Image = ((System.Drawing.Image)(resources.GetObject("Exitbtn.Image")));
            this.Exitbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exitbtn.Location = new System.Drawing.Point(4, 454);
            this.Exitbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.Exitbtn.Size = new System.Drawing.Size(336, 85);
            this.Exitbtn.TabIndex = 4;
            this.Exitbtn.Text = "Exit";
            this.Exitbtn.UseVisualStyleBackColor = true;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1665, 940);
            this.Controls.Add(this.FlowLayoutSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Mainform";
            this.Text = "BookingForm";
            this.Load += new System.EventHandler(this.Mainform_Load);
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
        private System.Windows.Forms.Button ButtonTickets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer TimerSidebar;
        private System.Windows.Forms.PictureBox PictureBoxMenu;
        private System.Windows.Forms.Button Exitbtn;
    }
}