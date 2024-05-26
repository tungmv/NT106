namespace RemoteFileManagement
{
    partial class Client
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
            this.TextBoxPath = new System.Windows.Forms.TextBox();
            this.ButtonConnect = new System.Windows.Forms.Button();
            this.RichTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.ButtonSendRequest = new System.Windows.Forms.Button();
            this.TextBoxIPAddress = new System.Windows.Forms.TextBox();
            this.TextBoxPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBoxPath
            // 
            this.TextBoxPath.Location = new System.Drawing.Point(83, 286);
            this.TextBoxPath.Name = "TextBoxPath";
            this.TextBoxPath.Size = new System.Drawing.Size(294, 20);
            this.TextBoxPath.TabIndex = 0;
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.Location = new System.Drawing.Point(356, 39);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Size = new System.Drawing.Size(75, 23);
            this.ButtonConnect.TabIndex = 1;
            this.ButtonConnect.Text = "Connect";
            this.ButtonConnect.UseVisualStyleBackColor = true;
            this.ButtonConnect.Click += new System.EventHandler(this.ButtonConnect_Click);
            // 
            // RichTextBoxOutput
            // 
            this.RichTextBoxOutput.Location = new System.Drawing.Point(37, 85);
            this.RichTextBoxOutput.Name = "RichTextBoxOutput";
            this.RichTextBoxOutput.Size = new System.Drawing.Size(394, 170);
            this.RichTextBoxOutput.TabIndex = 2;
            this.RichTextBoxOutput.Text = "";
            // 
            // ButtonSendRequest
            // 
            this.ButtonSendRequest.Enabled = false;
            this.ButtonSendRequest.Location = new System.Drawing.Point(176, 319);
            this.ButtonSendRequest.Name = "ButtonSendRequest";
            this.ButtonSendRequest.Size = new System.Drawing.Size(108, 23);
            this.ButtonSendRequest.TabIndex = 3;
            this.ButtonSendRequest.Text = "Send Request";
            this.ButtonSendRequest.UseVisualStyleBackColor = true;
            this.ButtonSendRequest.Click += new System.EventHandler(this.ButtonSendRequest_Click);
            // 
            // TextBoxIPAddress
            // 
            this.TextBoxIPAddress.Location = new System.Drawing.Point(37, 42);
            this.TextBoxIPAddress.Name = "TextBoxIPAddress";
            this.TextBoxIPAddress.Size = new System.Drawing.Size(201, 20);
            this.TextBoxIPAddress.TabIndex = 4;
            this.TextBoxIPAddress.Text = "127.0.0.1";
            // 
            // TextBoxPort
            // 
            this.TextBoxPort.Location = new System.Drawing.Point(244, 42);
            this.TextBoxPort.Name = "TextBoxPort";
            this.TextBoxPort.Size = new System.Drawing.Size(106, 20);
            this.TextBoxPort.TabIndex = 5;
            this.TextBoxPort.Text = "2024";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "IP Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(283, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(182, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Remote File Path";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 362);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxPort);
            this.Controls.Add(this.TextBoxIPAddress);
            this.Controls.Add(this.ButtonSendRequest);
            this.Controls.Add(this.RichTextBoxOutput);
            this.Controls.Add(this.ButtonConnect);
            this.Controls.Add(this.TextBoxPath);
            this.Name = "Client";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxPath;
        private System.Windows.Forms.Button ButtonConnect;
        private System.Windows.Forms.RichTextBox RichTextBoxOutput;
        private System.Windows.Forms.Button ButtonSendRequest;
        private System.Windows.Forms.TextBox TextBoxIPAddress;
        private System.Windows.Forms.TextBox TextBoxPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}