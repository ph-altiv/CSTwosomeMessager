namespace CSTwosomeMessager
{
    partial class fMain
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
            this.lbMessages = new System.Windows.Forms.ListBox();
            this.tbInputMessage = new System.Windows.Forms.TextBox();
            this.bSend = new System.Windows.Forms.Button();
            this.tGettingMessages = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbMessages
            // 
            this.lbMessages.FormattingEnabled = true;
            this.lbMessages.Location = new System.Drawing.Point(12, 12);
            this.lbMessages.Name = "lbMessages";
            this.lbMessages.Size = new System.Drawing.Size(566, 186);
            this.lbMessages.TabIndex = 1;
            // 
            // tbInputMessage
            // 
            this.tbInputMessage.Location = new System.Drawing.Point(12, 204);
            this.tbInputMessage.Multiline = true;
            this.tbInputMessage.Name = "tbInputMessage";
            this.tbInputMessage.Size = new System.Drawing.Size(413, 37);
            this.tbInputMessage.TabIndex = 2;
            // 
            // bSend
            // 
            this.bSend.Location = new System.Drawing.Point(431, 204);
            this.bSend.Name = "bSend";
            this.bSend.Size = new System.Drawing.Size(147, 37);
            this.bSend.TabIndex = 3;
            this.bSend.Text = "Отправить";
            this.bSend.UseVisualStyleBackColor = true;
            this.bSend.Click += new System.EventHandler(this.bSend_Click);
            // 
            // tGettingMessages
            // 
            this.tGettingMessages.Tick += new System.EventHandler(this.tGettingMessages_Tick);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 253);
            this.Controls.Add(this.bSend);
            this.Controls.Add(this.tbInputMessage);
            this.Controls.Add(this.lbMessages);
            this.Name = "fMain";
            this.ShowIcon = false;
            this.Text = "CSTwosomeMessager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fMain_FormClosing);
            this.Load += new System.EventHandler(this.fMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbMessages;
        private System.Windows.Forms.TextBox tbInputMessage;
        private System.Windows.Forms.Button bSend;
        private System.Windows.Forms.Timer tGettingMessages;
    }
}

