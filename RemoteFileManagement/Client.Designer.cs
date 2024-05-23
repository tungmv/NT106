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
            this.SuspendLayout();
            // 
            // TextBoxPath
            // 
            this.TextBoxPath.Location = new System.Drawing.Point(36, 15);
            this.TextBoxPath.Name = "TextBoxPath";
            this.TextBoxPath.Size = new System.Drawing.Size(294, 20);
            this.TextBoxPath.TabIndex = 0;
            // 
            // ButtonConnect
            // 
            this.ButtonConnect.Location = new System.Drawing.Point(355, 12);
            this.ButtonConnect.Name = "ButtonConnect";
            this.ButtonConnect.Size = new System.Drawing.Size(75, 23);
            this.ButtonConnect.TabIndex = 1;
            this.ButtonConnect.Text = "Connect";
            this.ButtonConnect.UseVisualStyleBackColor = true;
            // 
            // RichTextBoxOutput
            // 
            this.RichTextBoxOutput.Location = new System.Drawing.Point(36, 58);
            this.RichTextBoxOutput.Name = "RichTextBoxOutput";
            this.RichTextBoxOutput.Size = new System.Drawing.Size(394, 170);
            this.RichTextBoxOutput.TabIndex = 2;
            this.RichTextBoxOutput.Text = "";
            // 
            // ButtonSendRequest
            // 
            this.ButtonSendRequest.Enabled = false;
            this.ButtonSendRequest.Location = new System.Drawing.Point(177, 251);
            this.ButtonSendRequest.Name = "ButtonSendRequest";
            this.ButtonSendRequest.Size = new System.Drawing.Size(108, 23);
            this.ButtonSendRequest.TabIndex = 3;
            this.ButtonSendRequest.Text = "Send Request";
            this.ButtonSendRequest.UseVisualStyleBackColor = true;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 309);
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
    }
}