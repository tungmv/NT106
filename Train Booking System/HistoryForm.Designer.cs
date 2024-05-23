namespace Train_Booking_System
{
    partial class HistoryForm
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
            this.ButtonRefresh = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.LabelAccountInfo = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.DataGridViewTrainList = new ComponentFactory.Krypton.Toolkit.KryptonDataGridView();
            this.Ticket_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Train_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Depature_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Depature_Station = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Route = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paid_Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTrainList)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonRefresh
            // 
            this.ButtonRefresh.Location = new System.Drawing.Point(379, 518);
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ButtonRefresh.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ButtonRefresh.OverrideDefault.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.ButtonRefresh.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ButtonRefresh.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ButtonRefresh.OverrideFocus.Back.ColorAngle = 45F;
            this.ButtonRefresh.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.ButtonRefresh.Size = new System.Drawing.Size(123, 37);
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
            this.ButtonRefresh.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRefresh.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ButtonRefresh.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ButtonRefresh.StatePressed.Back.ColorAngle = 135F;
            this.ButtonRefresh.StatePressed.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.ButtonRefresh.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ButtonRefresh.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ButtonRefresh.StateTracking.Back.ColorAngle = 135F;
            this.ButtonRefresh.StateTracking.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.ButtonRefresh.TabIndex = 32;
            this.ButtonRefresh.Values.Text = "Refresh";
            this.ButtonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // LabelAccountInfo
            // 
            this.LabelAccountInfo.Location = new System.Drawing.Point(405, 23);
            this.LabelAccountInfo.Name = "LabelAccountInfo";
            this.LabelAccountInfo.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.LabelAccountInfo.Size = new System.Drawing.Size(83, 33);
            this.LabelAccountInfo.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LabelAccountInfo.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.LabelAccountInfo.StateCommon.ShortText.ColorAngle = 45F;
            this.LabelAccountInfo.StateCommon.ShortText.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAccountInfo.StateCommon.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.LabelAccountInfo.TabIndex = 31;
            this.LabelAccountInfo.Values.Text = "History";
            // 
            // DataGridViewTrainList
            // 
            this.DataGridViewTrainList.AllowUserToDeleteRows = false;
            this.DataGridViewTrainList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewTrainList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ticket_ID,
            this.Train_ID,
            this.Depature_Date,
            this.Depature_Station,
            this.Route,
            this.Paid_Amount});
            this.DataGridViewTrainList.Location = new System.Drawing.Point(74, 75);
            this.DataGridViewTrainList.Name = "DataGridViewTrainList";
            this.DataGridViewTrainList.ReadOnly = true;
            this.DataGridViewTrainList.Size = new System.Drawing.Size(761, 411);
            this.DataGridViewTrainList.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.DataGridViewTrainList.StateCommon.Background.ColorAngle = 45F;
            this.DataGridViewTrainList.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.DataGridViewTrainList.TabIndex = 30;
            // 
            // Ticket_ID
            // 
            this.Ticket_ID.HeaderText = "Ticket ID";
            this.Ticket_ID.Name = "Ticket_ID";
            this.Ticket_ID.ReadOnly = true;
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
            // Paid_Amount
            // 
            this.Paid_Amount.HeaderText = "Paid Amount";
            this.Paid_Amount.Name = "Paid_Amount";
            this.Paid_Amount.ReadOnly = true;
            this.Paid_Amount.Width = 130;
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 611);
            this.Controls.Add(this.ButtonRefresh);
            this.Controls.Add(this.LabelAccountInfo);
            this.Controls.Add(this.DataGridViewTrainList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HistoryForm";
            this.Text = "HistoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewTrainList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonButton ButtonRefresh;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel LabelAccountInfo;
        private ComponentFactory.Krypton.Toolkit.KryptonDataGridView DataGridViewTrainList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ticket_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Train_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Depature_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Depature_Station;
        private System.Windows.Forms.DataGridViewTextBoxColumn Route;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paid_Amount;
    }
}