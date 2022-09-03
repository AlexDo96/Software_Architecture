namespace MSMQ_Sender
{
    partial class F_MessageSender
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.SendObjectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(591, 303);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "This is a sample message content";
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(12, 337);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(127, 39);
            this.SendButton.TabIndex = 1;
            this.SendButton.Text = "Send Text";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // SendObjectButton
            // 
            this.SendObjectButton.Location = new System.Drawing.Point(208, 338);
            this.SendObjectButton.Name = "SendObjectButton";
            this.SendObjectButton.Size = new System.Drawing.Size(131, 38);
            this.SendObjectButton.TabIndex = 2;
            this.SendObjectButton.Text = "Send Object";
            this.SendObjectButton.UseVisualStyleBackColor = true;
            this.SendObjectButton.Click += new System.EventHandler(this.SendObjectButton_Click);
            // 
            // F_MessageSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 428);
            this.Controls.Add(this.SendObjectButton);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.richTextBox1);
            this.Name = "F_MessageSender";
            this.Text = "F_MessageSender";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Button SendObjectButton;
    }
}

