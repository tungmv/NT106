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
            this.DateTimePickerDepatureDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.LabelReturnDate = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.LabelReturn = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.DateTimePickerReturnDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.CheckBoxRoundTrip = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.ButtonLogin = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.DataGridViewTrainList = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.Train_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Depature_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Depature_Station = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Route = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arrival_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Available_Seats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComboBoxReturn = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.ComboBoxDeparture = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kryptonButton2 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.LabelAccountInfo = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTrainList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxDeparture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelDepatureDate
            // 
            this.LabelDepatureDate.Location = new System.Drawing.Point(83, 139);
            this.LabelDepatureDate.Margin = new System.Windows.Forms.Padding(4);
            this.LabelDepatureDate.Name = "LabelDepatureDate";
            this.LabelDepatureDate.Size = new System.Drawing.Size(119, 23);
            this.LabelDepatureDate.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDepatureDate.StateCommon.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.LabelDepatureDate.TabIndex = 10;
            this.LabelDepatureDate.Values.Text = "Depature Date";
            // 
            // LabelDepature
            // 
            this.LabelDepature.Location = new System.Drawing.Point(83, 98);
            this.LabelDepature.Margin = new System.Windows.Forms.Padding(4);
            this.LabelDepature.Name = "LabelDepature";
            this.LabelDepature.Size = new System.Drawing.Size(80, 23);
            this.LabelDepature.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDepature.StateCommon.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.LabelDepature.TabIndex = 9;
            this.LabelDepature.Values.Text = "Depature";
            // 
            // DateTimePickerDepatureDate
            // 
            this.DateTimePickerDepatureDate.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.DateTimePickerDepatureDate.Location = new System.Drawing.Point(267, 139);
            this.DateTimePickerDepatureDate.Margin = new System.Windows.Forms.Padding(4);
            this.DateTimePickerDepatureDate.Name = "DateTimePickerDepatureDate";
            this.DateTimePickerDepatureDate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.DateTimePickerDepatureDate.Size = new System.Drawing.Size(220, 20);
            this.DateTimePickerDepatureDate.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePickerDepatureDate.TabIndex = 8;
            // 
            // LabelReturnDate
            // 
            this.LabelReturnDate.Location = new System.Drawing.Point(83, 241);
            this.LabelReturnDate.Margin = new System.Windows.Forms.Padding(4);
            this.LabelReturnDate.Name = "LabelReturnDate";
            this.LabelReturnDate.Size = new System.Drawing.Size(100, 23);
            this.LabelReturnDate.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelReturnDate.StateCommon.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.LabelReturnDate.TabIndex = 14;
            this.LabelReturnDate.Values.Text = "Return Date";
            // 
            // LabelReturn
            // 
            this.LabelReturn.Location = new System.Drawing.Point(83, 201);
            this.LabelReturn.Margin = new System.Windows.Forms.Padding(4);
            this.LabelReturn.Name = "LabelReturn";
            this.LabelReturn.Size = new System.Drawing.Size(61, 23);
            this.LabelReturn.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelReturn.StateCommon.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.LabelReturn.TabIndex = 13;
            this.LabelReturn.Values.Text = "Return";
            // 
            // DateTimePickerReturnDate
            // 
            this.DateTimePickerReturnDate.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.DateTimePickerReturnDate.Location = new System.Drawing.Point(267, 241);
            this.DateTimePickerReturnDate.Margin = new System.Windows.Forms.Padding(4);
            this.DateTimePickerReturnDate.Name = "DateTimePickerReturnDate";
            this.DateTimePickerReturnDate.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.DateTimePickerReturnDate.Size = new System.Drawing.Size(220, 20);
            this.DateTimePickerReturnDate.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePickerReturnDate.TabIndex = 12;
            // 
            // CheckBoxRoundTrip
            // 
            this.CheckBoxRoundTrip.Checked = true;
            this.CheckBoxRoundTrip.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxRoundTrip.Location = new System.Drawing.Point(95, 66);
            this.CheckBoxRoundTrip.Margin = new System.Windows.Forms.Padding(4);
            this.CheckBoxRoundTrip.Name = "CheckBoxRoundTrip";
            this.CheckBoxRoundTrip.Size = new System.Drawing.Size(79, 16);
            this.CheckBoxRoundTrip.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxRoundTrip.TabIndex = 16;
            this.CheckBoxRoundTrip.Values.Text = "Round Trip";
            this.CheckBoxRoundTrip.CheckedChanged += new System.EventHandler(this.CheckBoxRoundTrip_CheckedChanged);
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Location = new System.Drawing.Point(511, 306);
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
            // DataGridViewTrainList
            // 
            this.DataGridViewTrainList.AllowUserToDeleteRows = false;
            this.DataGridViewTrainList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewTrainList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Train_ID,
            this.Depature_Date,
            this.Depature_Station,
            this.Route,
            this.Arrival_Date,
            this.Available_Seats});
            this.DataGridViewTrainList.Location = new System.Drawing.Point(96, 375);
            this.DataGridViewTrainList.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridViewTrainList.Name = "DataGridViewTrainList";
            this.DataGridViewTrainList.ReadOnly = true;
            this.DataGridViewTrainList.Size = new System.Drawing.Size(1015, 235);
            this.DataGridViewTrainList.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.DataGridViewTrainList.StateCommon.Background.ColorAngle = 45F;
            this.DataGridViewTrainList.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.DataGridViewTrainList.TabIndex = 19;
            // 
            // Train_ID
            // 
            this.Train_ID.HeaderText = "Train ID";
            this.Train_ID.Name = "Train_ID";
            this.Train_ID.ReadOnly = true;
            // 
            // Depature_Date
            // 
            this.Depature_Date.HeaderText = "Depature Date";
            this.Depature_Date.Name = "Depature_Date";
            this.Depature_Date.ReadOnly = true;
            this.Depature_Date.Width = 130;
            // 
            // Depature_Station
            // 
            this.Depature_Station.HeaderText = "Depature Station";
            this.Depature_Station.Name = "Depature_Station";
            this.Depature_Station.ReadOnly = true;
            this.Depature_Station.Width = 130;
            // 
            // Route
            // 
            this.Route.HeaderText = "Destination Station";
            this.Route.Name = "Route";
            this.Route.ReadOnly = true;
            this.Route.Width = 130;
            // 
            // Arrival_Date
            // 
            this.Arrival_Date.HeaderText = "Arrival Date";
            this.Arrival_Date.Name = "Arrival_Date";
            this.Arrival_Date.ReadOnly = true;
            this.Arrival_Date.Width = 130;
            // 
            // Available_Seats
            // 
            this.Available_Seats.HeaderText = "Available Seats";
            this.Available_Seats.Name = "Available_Seats";
            this.Available_Seats.ReadOnly = true;
            // 
            // ComboBoxReturn
            // 
            this.ComboBoxReturn.DropDownWidth = 165;
            this.ComboBoxReturn.Location = new System.Drawing.Point(267, 205);
            this.ComboBoxReturn.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxReturn.Name = "ComboBoxReturn";
            this.ComboBoxReturn.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.ComboBoxReturn.Size = new System.Drawing.Size(220, 19);
            this.ComboBoxReturn.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxReturn.TabIndex = 21;
            this.ComboBoxReturn.SelectedIndexChanged += new System.EventHandler(this.ComboBoxReturn_SelectedIndexChanged);
            // 
            // ComboBoxDeparture
            // 
            this.ComboBoxDeparture.DropDownWidth = 165;
            this.ComboBoxDeparture.Location = new System.Drawing.Point(267, 103);
            this.ComboBoxDeparture.Margin = new System.Windows.Forms.Padding(4);
            this.ComboBoxDeparture.Name = "ComboBoxDeparture";
            this.ComboBoxDeparture.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.ComboBoxDeparture.Size = new System.Drawing.Size(220, 19);
            this.ComboBoxDeparture.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxDeparture.TabIndex = 22;
            this.ComboBoxDeparture.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDeparture_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(793, 91);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 183);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Location = new System.Drawing.Point(511, 631);
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
            this.LabelAccountInfo.Size = new System.Drawing.Size(138, 28);
            this.LabelAccountInfo.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LabelAccountInfo.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.LabelAccountInfo.StateCommon.ShortText.ColorAngle = 45F;
            this.LabelAccountInfo.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAccountInfo.StateCommon.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.LabelAccountInfo.TabIndex = 26;
            this.LabelAccountInfo.Values.Text = "Train Booking";
            // 
            // TrainBookingFormStep1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 752);
            this.Controls.Add(this.LabelAccountInfo);
            this.Controls.Add(this.kryptonButton2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DataGridViewTrainList);
            this.Controls.Add(this.ButtonLogin);
            this.Controls.Add(this.CheckBoxRoundTrip);
            this.Controls.Add(this.LabelReturnDate);
            this.Controls.Add(this.LabelReturn);
            this.Controls.Add(this.DateTimePickerReturnDate);
            this.Controls.Add(this.LabelDepatureDate);
            this.Controls.Add(this.LabelDepature);
            this.Controls.Add(this.DateTimePickerDepatureDate);
            this.Controls.Add(this.ComboBoxReturn);
            this.Controls.Add(this.ComboBoxDeparture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TrainBookingFormStep1";
            this.Text = "BookingForm";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTrainList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxDeparture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer TimerSidebar;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel LabelDepatureDate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel LabelDepature;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker DateTimePickerDepatureDate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel LabelReturnDate;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel LabelReturn;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker DateTimePickerReturnDate;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox CheckBoxRoundTrip;
        private ComponentFactory.Krypton.Toolkit.KryptonButton ButtonLogin;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView DataGridViewTrainList;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox ComboBoxReturn;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox ComboBoxDeparture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Train_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Depature_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Depature_Station;
        private System.Windows.Forms.DataGridViewTextBoxColumn Route;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arrival_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Available_Seats;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel LabelAccountInfo;
    }
}