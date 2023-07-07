namespace Net4
{
    partial class ChatForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.txbMessage = new System.Windows.Forms.TextBox();
            this.lsvMessage = new System.Windows.Forms.ListView();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 38);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown_1);
            this.panel1.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove_1);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Net4.Properties.Resources.icons8_send_50;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(740, 112);
            this.panel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(39, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "SERVER";
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSend.Location = new System.Drawing.Point(656, 721);
            this.btnSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(70, 33);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txbMessage
            // 
            this.txbMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txbMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbMessage.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMessage.ForeColor = System.Drawing.SystemColors.Window;
            this.txbMessage.Location = new System.Drawing.Point(17, 721);
            this.txbMessage.Multiline = true;
            this.txbMessage.Name = "txbMessage";
            this.txbMessage.Size = new System.Drawing.Size(625, 33);
            this.txbMessage.TabIndex = 7;
            // 
            // lsvMessage
            // 
            this.lsvMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lsvMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsvMessage.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvMessage.ForeColor = System.Drawing.SystemColors.Window;
            this.lsvMessage.HideSelection = false;
            this.lsvMessage.Location = new System.Drawing.Point(17, 166);
            this.lsvMessage.Name = "lsvMessage";
            this.lsvMessage.Size = new System.Drawing.Size(709, 530);
            this.lsvMessage.TabIndex = 6;
            this.lsvMessage.UseCompatibleStateImageBehavior = false;
            this.lsvMessage.View = System.Windows.Forms.View.List;
            // 
            // button7
            // 
            this.button7.BackgroundImage = global::Net4.Properties.Resources.icons8_minimize_32;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(706, 8);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(23, 22);
            this.button7.TabIndex = 9;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(42, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "CHAT";
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(740, 771);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txbMessage);
            this.Controls.Add(this.lsvMessage);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ChatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChatForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button btnSend;
        public System.Windows.Forms.TextBox txbMessage;
        public System.Windows.Forms.ListView lsvMessage;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button7;
    }
}