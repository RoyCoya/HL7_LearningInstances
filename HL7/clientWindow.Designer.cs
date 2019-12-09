namespace HL7
{
    partial class clientWindow
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.client = new System.Windows.Forms.GroupBox();
            this.client_button_send = new System.Windows.Forms.Button();
            this.client_button_connect = new System.Windows.Forms.Button();
            this.client_port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.client_ip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.client_message = new System.Windows.Forms.RichTextBox();
            this.client_button_disconnect = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.client.SuspendLayout();
            this.SuspendLayout();
            // 
            // client
            // 
            this.client.Controls.Add(this.button1);
            this.client.Controls.Add(this.client_button_disconnect);
            this.client.Controls.Add(this.client_message);
            this.client.Controls.Add(this.client_button_send);
            this.client.Controls.Add(this.client_button_connect);
            this.client.Controls.Add(this.client_port);
            this.client.Controls.Add(this.label2);
            this.client.Controls.Add(this.client_ip);
            this.client.Controls.Add(this.label1);
            this.client.Location = new System.Drawing.Point(12, 12);
            this.client.Name = "client";
            this.client.Size = new System.Drawing.Size(436, 544);
            this.client.TabIndex = 0;
            this.client.TabStop = false;
            this.client.Text = "Client";
            this.client.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // client_button_send
            // 
            this.client_button_send.Location = new System.Drawing.Point(87, 41);
            this.client_button_send.Name = "client_button_send";
            this.client_button_send.Size = new System.Drawing.Size(75, 23);
            this.client_button_send.TabIndex = 6;
            this.client_button_send.Text = "Send";
            this.client_button_send.UseVisualStyleBackColor = true;
            this.client_button_send.Click += new System.EventHandler(this.Client_button_send_Click);
            // 
            // client_button_connect
            // 
            this.client_button_connect.Location = new System.Drawing.Point(6, 41);
            this.client_button_connect.Name = "client_button_connect";
            this.client_button_connect.Size = new System.Drawing.Size(75, 23);
            this.client_button_connect.TabIndex = 5;
            this.client_button_connect.Text = "Connect";
            this.client_button_connect.UseVisualStyleBackColor = true;
            this.client_button_connect.Click += new System.EventHandler(this.Client_button_connect_Click);
            // 
            // client_port
            // 
            this.client_port.Location = new System.Drawing.Point(346, 14);
            this.client_port.Name = "client_port";
            this.client_port.Size = new System.Drawing.Size(84, 21);
            this.client_port.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // client_ip
            // 
            this.client_ip.Location = new System.Drawing.Point(40, 14);
            this.client_ip.Name = "client_ip";
            this.client_ip.Size = new System.Drawing.Size(265, 21);
            this.client_ip.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(454, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(424, 544);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // client_message
            // 
            this.client_message.Location = new System.Drawing.Point(0, 70);
            this.client_message.Name = "client_message";
            this.client_message.Size = new System.Drawing.Size(430, 474);
            this.client_message.TabIndex = 7;
            this.client_message.Text = "";
            // 
            // client_button_disconnect
            // 
            this.client_button_disconnect.Location = new System.Drawing.Point(168, 41);
            this.client_button_disconnect.Name = "client_button_disconnect";
            this.client_button_disconnect.Size = new System.Drawing.Size(75, 23);
            this.client_button_disconnect.TabIndex = 8;
            this.client_button_disconnect.Text = "Disconnect";
            this.client_button_disconnect.UseVisualStyleBackColor = true;
            this.client_button_disconnect.Click += new System.EventHandler(this.Client_button_disconnect_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // clientWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 568);
            this.Controls.Add(this.client);
            this.Controls.Add(this.richTextBox1);
            this.Name = "clientWindow";
            this.Text = "client";
            this.client.ResumeLayout(false);
            this.client.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox client;
        private System.Windows.Forms.Button client_button_send;
        private System.Windows.Forms.Button client_button_connect;
        private System.Windows.Forms.TextBox client_port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox client_ip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox client_message;
        private System.Windows.Forms.Button client_button_disconnect;
        private System.Windows.Forms.Button button1;
    }
}

