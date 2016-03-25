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
            this.bHelloWorld = new System.Windows.Forms.Button();
            this.lbMessages = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // bHelloWorld
            // 
            this.bHelloWorld.Location = new System.Drawing.Point(431, 210);
            this.bHelloWorld.Name = "bHelloWorld";
            this.bHelloWorld.Size = new System.Drawing.Size(147, 39);
            this.bHelloWorld.TabIndex = 0;
            this.bHelloWorld.Text = "Hello, world!";
            this.bHelloWorld.UseVisualStyleBackColor = true;
            this.bHelloWorld.Click += new System.EventHandler(this.bHelloWorld_Click);
            // 
            // lbMessages
            // 
            this.lbMessages.FormattingEnabled = true;
            this.lbMessages.Location = new System.Drawing.Point(12, 12);
            this.lbMessages.Name = "lbMessages";
            this.lbMessages.Size = new System.Drawing.Size(566, 186);
            this.lbMessages.TabIndex = 1;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 261);
            this.Controls.Add(this.lbMessages);
            this.Controls.Add(this.bHelloWorld);
            this.Name = "fMain";
            this.ShowIcon = false;
            this.Text = "CSTwosomeMessager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bHelloWorld;
        private System.Windows.Forms.ListBox lbMessages;
    }
}

