namespace Train_Booking_System
{
    partial class TicketForm
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
            this.DataGridViewTrainList = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.LabelAccountInfo = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.ButtonRefresh = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.Ticket_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Train_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GheGiuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XuatPhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiemDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arrival_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTrainList)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridViewTrainList
            // 
            this.DataGridViewTrainList.AllowUserToDeleteRows = false;
            this.DataGridViewTrainList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewTrainList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ticket_ID,
            this.Train_ID,
            this.ToaPhong,
            this.GheGiuong,
            this.XuatPhat,
            this.DiemDen,
            this.Arrival_Date,
            this.DonGia});
            this.DataGridViewTrainList.Location = new System.Drawing.Point(110, 95);
            this.DataGridViewTrainList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataGridViewTrainList.Name = "DataGridViewTrainList";
            this.DataGridViewTrainList.ReadOnly = true;
            this.DataGridViewTrainList.RowHeadersWidth = 51;
            this.DataGridViewTrainList.Size = new System.Drawing.Size(1142, 632);
            this.DataGridViewTrainList.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.DataGridViewTrainList.StateCommon.Background.ColorAngle = 45F;
            this.DataGridViewTrainList.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.DataGridViewTrainList.TabIndex = 20;
            this.DataGridViewTrainList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewTrainList_CellContentClick);
            // 
            // LabelAccountInfo
            // 
            this.LabelAccountInfo.Location = new System.Drawing.Point(609, 19);
            this.LabelAccountInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LabelAccountInfo.Name = "LabelAccountInfo";
            this.LabelAccountInfo.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.LabelAccountInfo.Size = new System.Drawing.Size(113, 40);
            this.LabelAccountInfo.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LabelAccountInfo.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.LabelAccountInfo.StateCommon.ShortText.ColorAngle = 45F;
            this.LabelAccountInfo.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAccountInfo.StateCommon.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.LabelAccountInfo.TabIndex = 27;
            this.LabelAccountInfo.Values.Text = "Tickets";
            // 
            // ButtonRefresh
            // 
            this.ButtonRefresh.Location = new System.Drawing.Point(594, 772);
            this.ButtonRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ButtonRefresh.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ButtonRefresh.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.ButtonRefresh.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ButtonRefresh.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ButtonRefresh.OverrideFocus.Back.ColorAngle = 45F;
            this.ButtonRefresh.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.ButtonRefresh.Size = new System.Drawing.Size(184, 58);
            this.ButtonRefresh.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ButtonRefresh.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ButtonRefresh.StateCommon.Back.ColorAngle = 135F;
            this.ButtonRefresh.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.ButtonRefresh.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ButtonRefresh.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ButtonRefresh.StateCommon.Border.ColorAngle = 45F;
            this.ButtonRefresh.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ButtonRefresh.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.ButtonRefresh.StateCommon.Border.Rounding = 10;
            this.ButtonRefresh.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.ButtonRefresh.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.ButtonRefresh.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRefresh.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ButtonRefresh.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ButtonRefresh.StatePressed.Back.ColorAngle = 135F;
            this.ButtonRefresh.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.ButtonRefresh.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ButtonRefresh.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ButtonRefresh.StateTracking.Back.ColorAngle = 135F;
            this.ButtonRefresh.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.ButtonRefresh.TabIndex = 28;
            this.ButtonRefresh.Values.Text = "Refresh";
            this.ButtonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // Ticket_ID
            // 
            this.Ticket_ID.HeaderText = "Ticket ID";
            this.Ticket_ID.MinimumWidth = 6;
            this.Ticket_ID.Name = "Ticket_ID";
            this.Ticket_ID.ReadOnly = true;
            this.Ticket_ID.Width = 125;
            // 
            // Train_ID
            // 
            this.Train_ID.HeaderText = "Train ID";
            this.Train_ID.MinimumWidth = 6;
            this.Train_ID.Name = "Train_ID";
            this.Train_ID.ReadOnly = true;
            this.Train_ID.Width = 125;
            // 
            // ToaPhong
            // 
            this.ToaPhong.HeaderText = "ToaPhong";
            this.ToaPhong.MinimumWidth = 8;
            this.ToaPhong.Name = "ToaPhong";
            this.ToaPhong.ReadOnly = true;
            this.ToaPhong.Width = 150;
            // 
            // GheGiuong
            // 
            this.GheGiuong.HeaderText = "GheGiuong";
            this.GheGiuong.MinimumWidth = 8;
            this.GheGiuong.Name = "GheGiuong";
            this.GheGiuong.ReadOnly = true;
            this.GheGiuong.Width = 150;
            // 
            // XuatPhat
            // 
            this.XuatPhat.HeaderText = "XuatPhat";
            this.XuatPhat.MinimumWidth = 6;
            this.XuatPhat.Name = "XuatPhat";
            this.XuatPhat.ReadOnly = true;
            this.XuatPhat.Width = 130;
            // 
            // DiemDen
            // 
            this.DiemDen.HeaderText = "DiemDen";
            this.DiemDen.MinimumWidth = 6;
            this.DiemDen.Name = "DiemDen";
            this.DiemDen.ReadOnly = true;
            this.DiemDen.Width = 130;
            // 
            // Arrival_Date
            // 
            this.Arrival_Date.HeaderText = "Date";
            this.Arrival_Date.MinimumWidth = 6;
            this.Arrival_Date.Name = "Arrival_Date";
            this.Arrival_Date.ReadOnly = true;
            this.Arrival_Date.Width = 130;
            // 
            // DonGia
            // 
            this.DonGia.HeaderText = "DonGia";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            this.DonGia.Width = 125;
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 940);
            this.Controls.Add(this.ButtonRefresh);
            this.Controls.Add(this.LabelAccountInfo);
            this.Controls.Add(this.DataGridViewTrainList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TicketForm";
            this.Text = "TicketForm";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTrainList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView DataGridViewTrainList;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel LabelAccountInfo;
        private ComponentFactory.Krypton.Toolkit.KryptonButton ButtonRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ticket_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Train_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ToaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GheGiuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn XuatPhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiemDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arrival_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
    }
}