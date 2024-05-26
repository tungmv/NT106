namespace RemoteFileManagement
{
    partial class Server
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
            this.ButtonListen = new System.Windows.Forms.Button();
            this.RichTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ButtonListen
            // 
            this.ButtonListen.Location = new System.Drawing.Point(168, 225);
            this.ButtonListen.Name = "ButtonListen";
            this.ButtonListen.Size = new System.Drawing.Size(108, 23);
            this.ButtonListen.TabIndex = 5;
            this.ButtonListen.Text = "Listen";
            this.ButtonListen.UseVisualStyleBackColor = true;
            this.ButtonListen.Click += new System.EventHandler(this.ButtonListen_Click);
            // 
            // RichTextBoxOutput
            // 
            this.RichTextBoxOutput.Location = new System.Drawing.Point(27, 32);
            this.RichTextBoxOutput.Name = "RichTextBoxOutput";
            this.RichTextBoxOutput.Size = new System.Drawing.Size(394, 170);
            this.RichTextBoxOutput.TabIndex = 4;
            this.RichTextBoxOutput.Text = "";
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 309);
            this.Controls.Add(this.ButtonListen);
            this.Controls.Add(this.RichTextBoxOutput);
            this.Name = "Server";
            this.Text = "Server";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonListen;
        private System.Windows.Forms.RichTextBox RichTextBoxOutput;
    }
}