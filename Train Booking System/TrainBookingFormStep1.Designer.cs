namespace Train_Booking_System
{
    partial class TrainBookingFormStep1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrainBookingFormStep1));
            this.TimerSidebar = new System.Windows.Forms.Timer(this.components);
            this.LabelDepatureDate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.LabelDepature = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.LabelReturn = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ButtonLogin = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.ComboBoxReturn = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.ComboBoxDeparture = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.LabelAccountInfo = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.combobox_date = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxDeparture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.combobox_date)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelDepatureDate
            // 
            this.LabelDepatureDate.Location = new System.Drawing.Point(245, 417);
            this.LabelDepatureDate.Margin = new System.Windows.Forms.Padding(4);
            this.LabelDepatureDate.Name = "LabelDepatureDate";
            this.LabelDepatureDate.Size = new System.Drawing.Size(93, 28);
            this.LabelDepatureDate.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDepatureDate.StateCommon.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.LabelDepatureDate.TabIndex = 10;
            this.LabelDepatureDate.Values.Text = "SELECT";
            this.LabelDepatureDate.Paint += new System.Windows.Forms.PaintEventHandler(this.LabelDepatureDate_Paint);
            // 
            // LabelDepature
            // 
            this.LabelDepature.Location = new System.Drawing.Point(232, 234);
            this.LabelDepature.Margin = new System.Windows.Forms.Padding(4);
            this.LabelDepature.Name = "LabelDepature";
            this.LabelDepature.Size = new System.Drawing.Size(85, 28);
            this.LabelDepature.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDepature.StateCommon.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.LabelDepature.TabIndex = 9;
            this.LabelDepature.Values.Text = "Original";
            // 
            // LabelReturn
            // 
            this.LabelReturn.Location = new System.Drawing.Point(232, 285);
            this.LabelReturn.Margin = new System.Windows.Forms.Padding(4);
            this.LabelReturn.Name = "LabelReturn";
            this.LabelReturn.Size = new System.Drawing.Size(116, 28);
            this.LabelReturn.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelReturn.StateCommon.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.LabelReturn.TabIndex = 13;
            this.LabelReturn.Values.Text = "Destination";
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Location = new System.Drawing.Point(485, 360);
            this.ButtonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ButtonLogin.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ButtonLogin.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.ButtonLogin.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ButtonLogin.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ButtonLogin.OverrideFocus.Back.ColorAngle = 45F;
            this.ButtonLogin.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.ButtonLogin.Size = new System.Drawing.Size(164, 46);
            this.ButtonLogin.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ButtonLogin.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ButtonLogin.StateCommon.Back.ColorAngle = 135F;
            this.ButtonLogin.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.ButtonLogin.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ButtonLogin.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ButtonLogin.StateCommon.Border.ColorAngle = 45F;
            this.ButtonLogin.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ButtonLogin.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.ButtonLogin.StateCommon.Border.Rounding = 10;
            this.ButtonLogin.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.ButtonLogin.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.ButtonLogin.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLogin.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ButtonLogin.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ButtonLogin.StatePressed.Back.ColorAngle = 135F;
            this.ButtonLogin.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.ButtonLogin.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ButtonLogin.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ButtonLogin.StateTracking.Back.ColorAngle = 135F;
            this.ButtonLogin.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.ButtonLogin.TabIndex = 17;
            this.ButtonLogin.Values.Text = "Find";
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // ComboBoxReturn
            // 
            this.ComboBoxReturn.DropDownWidth = 165;
            this.ComboBoxReturn.Location = new System.Drawing.Point(416, 285);
            this.ComboBoxReturn.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxReturn.Name = "ComboBoxReturn";
            this.ComboBoxReturn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.ComboBoxReturn.Size = new System.Drawing.Size(274, 22);
            this.ComboBoxReturn.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxReturn.TabIndex = 21;
            this.ComboBoxReturn.SelectedIndexChanged += new System.EventHandler(this.ComboBoxReturn_SelectedIndexChanged);
            // 
            // ComboBoxDeparture
            // 
            this.ComboBoxDeparture.DropDownWidth = 165;
            this.ComboBoxDeparture.Location = new System.Drawing.Point(416, 234);
            this.ComboBoxDeparture.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxDeparture.Name = "ComboBoxDeparture";
            this.ComboBoxDeparture.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.ComboBoxDeparture.Size = new System.Drawing.Size(274, 22);
            this.ComboBoxDeparture.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxDeparture.TabIndex = 22;
            this.ComboBoxDeparture.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDeparture_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(764, 193);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 174);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Location = new System.Drawing.Point(963, 671);
            this.kryptonButton2.Margin = new System.Windows.Forms.Padding(4);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.kryptonButton2.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.kryptonButton2.OverrideFocus.Back.ColorAngle = 45F;
            this.kryptonButton2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonButton2.Size = new System.Drawing.Size(164, 46);
            this.kryptonButton2.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonButton2.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonButton2.StateCommon.Back.ColorAngle = 135F;
            this.kryptonButton2.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton2.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.kryptonButton2.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.kryptonButton2.StateCommon.Border.ColorAngle = 45F;
            this.kryptonButton2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.kryptonButton2.StateCommon.Border.Rounding = 10;
            this.kryptonButton2.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.kryptonButton2.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.kryptonButton2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton2.TabIndex = 25;
            this.kryptonButton2.Values.Text = "Next";
            this.kryptonButton2.Click += new System.EventHandler(this.ButtonNext);
            // 
            // LabelAccountInfo
            // 
            this.LabelAccountInfo.Location = new System.Drawing.Point(492, 15);
            this.LabelAccountInfo.Margin = new System.Windows.Forms.Padding(4);
            this.LabelAccountInfo.Name = "LabelAccountInfo";
            this.LabelAccountInfo.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.LabelAccountInfo.Size = new System.Drawing.Size(171, 34);
            this.LabelAccountInfo.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LabelAccountInfo.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.LabelAccountInfo.StateCommon.ShortText.ColorAngle = 45F;
            this.LabelAccountInfo.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAccountInfo.StateCommon.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.LabelAccountInfo.TabIndex = 26;
            this.LabelAccountInfo.Values.Text = "Train Booking";
            // 
            // combobox_date
            // 
            this.combobox_date.DropDownWidth = 165;
            this.combobox_date.Location = new System.Drawing.Point(429, 423);
            this.combobox_date.Margin = new System.Windows.Forms.Padding(4);
            this.combobox_date.Name = "combobox_date";
            this.combobox_date.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.combobox_date.Size = new System.Drawing.Size(433, 22);
            this.combobox_date.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combobox_date.TabIndex = 29;
            // 
            // TrainBookingFormStep1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 752);
            this.Controls.Add(this.combobox_date);
            this.Controls.Add(this.LabelAccountInfo);
            this.Controls.Add(this.kryptonButton2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ButtonLogin);
            this.Controls.Add(this.LabelReturn);
            this.Controls.Add(this.LabelDepatureDate);
            this.Controls.Add(this.LabelDepature);
            this.Controls.Add(this.ComboBoxReturn);
            this.Controls.Add(this.ComboBoxDeparture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TrainBookingFormStep1";
            this.Text = "BookingForm";
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxDeparture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.combobox_date)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer TimerSidebar;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel LabelDepatureDate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel LabelDepature;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel LabelReturn;
        private ComponentFactory.Krypton.Toolkit.KryptonButton ButtonLogin;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox ComboBoxReturn;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox ComboBoxDeparture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel LabelAccountInfo;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox combobox_date;
    }
}