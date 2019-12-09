namespace HL7
{
    partial class serverWindow
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
            this.ServerGroup = new System.Windows.Forms.GroupBox();
            this.server_button_listen = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.server_port = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.server_ip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ServerGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // ServerGroup
            // 
            this.ServerGroup.Controls.Add(this.server_button_listen);
            this.ServerGroup.Controls.Add(this.richTextBox2);
            this.ServerGroup.Controls.Add(this.server_port);
            this.ServerGroup.Controls.Add(this.label4);
            this.ServerGroup.Controls.Add(this.server_ip);
            this.ServerGroup.Controls.Add(this.label3);
            this.ServerGroup.Location = new System.Drawing.Point(12, 12);
            this.ServerGroup.Name = "ServerGroup";
            this.ServerGroup.Size = new System.Drawing.Size(436, 544);
            this.ServerGroup.TabIndex = 2;
            this.ServerGroup.TabStop = false;
            this.ServerGroup.Text = "Server";
            // 
            // server_button_listen
            // 
            this.server_button_listen.Location = new System.Drawing.Point(6, 41);
            this.server_button_listen.Name = "server_button_listen";
            this.server_button_listen.Size = new System.Drawing.Size(75, 23);
            this.server_button_listen.TabIndex = 7;
            this.server_button_listen.Text = "Listen";
            this.server_button_listen.UseVisualStyleBackColor = true;
            this.server_button_listen.Click += new System.EventHandler(this.Server_button_listen_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(6, 70);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(424, 468);
            this.richTextBox2.TabIndex = 7;
            this.richTextBox2.Text = "";
            // 
            // server_port
            // 
            this.server_port.Location = new System.Drawing.Point(345, 14);
            this.server_port.Name = "server_port";
            this.server_port.Size = new System.Drawing.Size(84, 21);
            this.server_port.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Port";
            // 
            // server_ip
            // 
            this.server_ip.Location = new System.Drawing.Point(39, 14);
            this.server_ip.Name = "server_ip";
            this.server_ip.Size = new System.Drawing.Size(265, 21);
            this.server_ip.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "IP";
            // 
            // serverWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 563);
            this.Controls.Add(this.ServerGroup);
            this.Name = "serverWindow";
            this.Text = "server";
            this.ServerGroup.ResumeLayout(false);
            this.ServerGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ServerGroup;
        private System.Windows.Forms.Button server_button_listen;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TextBox server_port;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox server_ip;
        private System.Windows.Forms.Label label3;
    }
}