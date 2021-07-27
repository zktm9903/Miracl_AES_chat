
namespace aesClient
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSend = new System.Windows.Forms.Button();
            this.txtBoxChat = new System.Windows.Forms.TextBox();
            this.txtBoxEncChat = new System.Windows.Forms.TextBox();
            this.msg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(269, 406);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtBoxChat
            // 
            this.txtBoxChat.Location = new System.Drawing.Point(12, 38);
            this.txtBoxChat.Multiline = true;
            this.txtBoxChat.Name = "txtBoxChat";
            this.txtBoxChat.Size = new System.Drawing.Size(332, 362);
            this.txtBoxChat.TabIndex = 1;
            // 
            // txtBoxEncChat
            // 
            this.txtBoxEncChat.Location = new System.Drawing.Point(456, 38);
            this.txtBoxEncChat.Multiline = true;
            this.txtBoxEncChat.Name = "txtBoxEncChat";
            this.txtBoxEncChat.Size = new System.Drawing.Size(332, 362);
            this.txtBoxEncChat.TabIndex = 1;
            // 
            // msg
            // 
            this.msg.Location = new System.Drawing.Point(13, 406);
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(250, 23);
            this.msg.TabIndex = 2;
            this.msg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.msg_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msg);
            this.Controls.Add(this.txtBoxEncChat);
            this.Controls.Add(this.txtBoxChat);
            this.Controls.Add(this.btnSend);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtBoxChat;
        private System.Windows.Forms.TextBox txtBoxEncChat;
        private System.Windows.Forms.TextBox msg;
    }
}

