namespace CSTwosomeMessager
{
    partial class fConnect
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
            this.flpServerClientSwitch = new System.Windows.Forms.FlowLayoutPanel();
            this.rbClient = new System.Windows.Forms.RadioButton();
            this.rbServer = new System.Windows.Forms.RadioButton();
            this.tlpSocketData = new System.Windows.Forms.TableLayoutPanel();
            this.lHostName = new System.Windows.Forms.Label();
            this.lPort = new System.Windows.Forms.Label();
            this.tbHostName = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.flpServerClientSwitch.SuspendLayout();
            this.tlpSocketData.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpServerClientSwitch
            // 
            this.flpServerClientSwitch.AutoSize = true;
            this.flpServerClientSwitch.Controls.Add(this.rbServer);
            this.flpServerClientSwitch.Controls.Add(this.rbClient);
            this.flpServerClientSwitch.Location = new System.Drawing.Point(12, 12);
            this.flpServerClientSwitch.Name = "flpServerClientSwitch";
            this.flpServerClientSwitch.Size = new System.Drawing.Size(398, 24);
            this.flpServerClientSwitch.TabIndex = 2;
            // 
            // rbClient
            // 
            this.rbClient.AutoSize = true;
            this.rbClient.Location = new System.Drawing.Point(71, 3);
            this.rbClient.Name = "rbClient";
            this.rbClient.Size = new System.Drawing.Size(61, 17);
            this.rbClient.TabIndex = 3;
            this.rbClient.TabStop = true;
            this.rbClient.Text = "Клиент";
            this.rbClient.UseVisualStyleBackColor = true;
            // 
            // rbServer
            // 
            this.rbServer.AutoSize = true;
            this.rbServer.Location = new System.Drawing.Point(3, 3);
            this.rbServer.Name = "rbServer";
            this.rbServer.Size = new System.Drawing.Size(62, 17);
            this.rbServer.TabIndex = 2;
            this.rbServer.TabStop = true;
            this.rbServer.Text = "Сервер";
            this.rbServer.UseVisualStyleBackColor = true;
            // 
            // tlpSocketData
            // 
            this.tlpSocketData.ColumnCount = 2;
            this.tlpSocketData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.39196F));
            this.tlpSocketData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.60804F));
            this.tlpSocketData.Controls.Add(this.lHostName, 0, 0);
            this.tlpSocketData.Controls.Add(this.lPort, 1, 0);
            this.tlpSocketData.Controls.Add(this.tbHostName, 0, 1);
            this.tlpSocketData.Controls.Add(this.tbPort, 1, 1);
            this.tlpSocketData.Location = new System.Drawing.Point(12, 42);
            this.tlpSocketData.Name = "tlpSocketData";
            this.tlpSocketData.RowCount = 2;
            this.tlpSocketData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpSocketData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tlpSocketData.Size = new System.Drawing.Size(398, 40);
            this.tlpSocketData.TabIndex = 3;
            // 
            // lHostName
            // 
            this.lHostName.AutoSize = true;
            this.lHostName.Location = new System.Drawing.Point(3, 0);
            this.lHostName.Name = "lHostName";
            this.lHostName.Size = new System.Drawing.Size(31, 13);
            this.lHostName.TabIndex = 0;
            this.lHostName.Text = "Хост";
            // 
            // lPort
            // 
            this.lPort.AutoSize = true;
            this.lPort.Location = new System.Drawing.Point(315, 0);
            this.lPort.Name = "lPort";
            this.lPort.Size = new System.Drawing.Size(32, 13);
            this.lPort.TabIndex = 1;
            this.lPort.Text = "Порт";
            // 
            // tbHostName
            // 
            this.tbHostName.Location = new System.Drawing.Point(3, 17);
            this.tbHostName.Name = "tbHostName";
            this.tbHostName.Size = new System.Drawing.Size(306, 20);
            this.tbHostName.TabIndex = 2;
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(315, 17);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(80, 20);
            this.tbPort.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(304, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Подключиться";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // fConnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 118);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tlpSocketData);
            this.Controls.Add(this.flpServerClientSwitch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fConnect";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Connect";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fConnect_FormClosed);
            this.Load += new System.EventHandler(this.fConnect_Load);
            this.flpServerClientSwitch.ResumeLayout(false);
            this.flpServerClientSwitch.PerformLayout();
            this.tlpSocketData.ResumeLayout(false);
            this.tlpSocketData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpServerClientSwitch;
        private System.Windows.Forms.RadioButton rbServer;
        private System.Windows.Forms.RadioButton rbClient;
        private System.Windows.Forms.TableLayoutPanel tlpSocketData;
        private System.Windows.Forms.Label lHostName;
        private System.Windows.Forms.Label lPort;
        private System.Windows.Forms.TextBox tbHostName;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Button button1;
    }
}