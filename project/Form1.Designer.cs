namespace Video_Chat_application
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axVideoChatReceiver1 = new AxVideoChatReceiverLib.AxVideoChatReceiver();
            this.axVideoChatSender1 = new AxVideoChatSenderLib.AxVideoChatSender();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axVideoChatReceiver1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axVideoChatSender1)).BeginInit();
            this.SuspendLayout();
            // 
            // axVideoChatReceiver1
            // 
            this.axVideoChatReceiver1.Enabled = true;
            this.axVideoChatReceiver1.Location = new System.Drawing.Point(27, 12);
            this.axVideoChatReceiver1.Name = "axVideoChatReceiver1";
            this.axVideoChatReceiver1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVideoChatReceiver1.OcxState")));
            this.axVideoChatReceiver1.Size = new System.Drawing.Size(488, 455);
            this.axVideoChatReceiver1.TabIndex = 0;
            // 
            // axVideoChatSender1
            // 
            this.axVideoChatSender1.Enabled = true;
            this.axVideoChatSender1.Location = new System.Drawing.Point(337, 316);
            this.axVideoChatSender1.Name = "axVideoChatSender1";
            this.axVideoChatSender1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVideoChatSender1.OcxState")));
            this.axVideoChatSender1.Size = new System.Drawing.Size(178, 151);
            this.axVideoChatSender1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(204, 473);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 529);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.axVideoChatSender1);
            this.Controls.Add(this.axVideoChatReceiver1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Leave += new System.EventHandler(this.Form1_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.axVideoChatReceiver1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axVideoChatSender1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxVideoChatReceiverLib.AxVideoChatReceiver axVideoChatReceiver1;
        private AxVideoChatSenderLib.AxVideoChatSender axVideoChatSender1;
        private System.Windows.Forms.Button button1;
    }
}

