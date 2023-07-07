namespace ADMIN
{
    partial class UserControlItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlItem));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lab_type = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lab_time = new System.Windows.Forms.Label();
            this.lab_Content = new System.Windows.Forms.Label();
            this.lab_title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.but_delete = new System.Windows.Forms.Button();
            this.lbID = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lab_type);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lab_time);
            this.panel1.Controls.Add(this.lab_Content);
            this.panel1.Controls.Add(this.lab_title);
            this.panel1.Location = new System.Drawing.Point(368, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 218);
            this.panel1.TabIndex = 1;
            // 
            // lab_type
            // 
            this.lab_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_type.ForeColor = System.Drawing.Color.Blue;
            this.lab_type.Location = new System.Drawing.Point(13, 9);
            this.lab_type.Name = "lab_type";
            this.lab_type.Size = new System.Drawing.Size(206, 26);
            this.lab_type.TabIndex = 9;
            this.lab_type.Text = "type";
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(43, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(578, 10);
            this.panel3.TabIndex = 8;
            // 
            // lab_time
            // 
            this.lab_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lab_time.Location = new System.Drawing.Point(504, 9);
            this.lab_time.Name = "lab_time";
            this.lab_time.Size = new System.Drawing.Size(167, 26);
            this.lab_time.TabIndex = 6;
            this.lab_time.Text = "time";
            // 
            // lab_Content
            // 
            this.lab_Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Content.Location = new System.Drawing.Point(13, 101);
            this.lab_Content.Name = "lab_Content";
            this.lab_Content.Size = new System.Drawing.Size(658, 65);
            this.lab_Content.TabIndex = 3;
            this.lab_Content.Text = "Content";
            // 
            // lab_title
            // 
            this.lab_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_title.ForeColor = System.Drawing.Color.Firebrick;
            this.lab_title.Location = new System.Drawing.Point(12, 53);
            this.lab_title.Name = "lab_title";
            this.lab_title.Size = new System.Drawing.Size(659, 33);
            this.lab_title.TabIndex = 4;
            this.lab_title.Text = "title\r\n";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(19, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 214);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // but_delete
            // 
            this.but_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_delete.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.but_delete.Location = new System.Drawing.Point(966, 3);
            this.but_delete.Name = "but_delete";
            this.but_delete.Size = new System.Drawing.Size(87, 35);
            this.but_delete.TabIndex = 3;
            this.but_delete.Text = "DELETE";
            this.but_delete.UseVisualStyleBackColor = true;
            this.but_delete.Click += new System.EventHandler(this.but_delete_Click);
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(552, 10);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(51, 20);
            this.lbID.TabIndex = 4;
            this.lbID.Text = "label1";
            this.lbID.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(867, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserControlItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.but_delete);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserControlItem";
            this.Size = new System.Drawing.Size(1071, 279);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button but_delete;
        private System.Windows.Forms.Label lbID;
        public System.Windows.Forms.Label lab_Content;
        public System.Windows.Forms.Label lab_title;
        public System.Windows.Forms.Label lab_time;
        public System.Windows.Forms.Label lab_type;
        private System.Windows.Forms.Button button1;
    }
}
