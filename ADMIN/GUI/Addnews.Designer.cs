namespace ADMIN.GUI
{
    partial class Addnews
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_type = new System.Windows.Forms.TextBox();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.txt_content = new System.Windows.Forms.TextBox();
            this.but_save = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_lab = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.Location = new System.Drawing.Point(295, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(120, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "TYPE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(120, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "TITLE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(120, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "CONTENT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(120, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "DATE";
            // 
            // txt_type
            // 
            this.txt_type.Location = new System.Drawing.Point(280, 170);
            this.txt_type.Name = "txt_type";
            this.txt_type.Size = new System.Drawing.Size(309, 26);
            this.txt_type.TabIndex = 2;
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(280, 224);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(309, 26);
            this.txt_title.TabIndex = 2;
            // 
            // txt_content
            // 
            this.txt_content.Location = new System.Drawing.Point(280, 285);
            this.txt_content.Name = "txt_content";
            this.txt_content.Size = new System.Drawing.Size(309, 26);
            this.txt_content.TabIndex = 2;
            // 
            // but_save
            // 
            this.but_save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.but_save.Location = new System.Drawing.Point(346, 403);
            this.but_save.Name = "but_save";
            this.but_save.Size = new System.Drawing.Size(157, 35);
            this.but_save.TabIndex = 3;
            this.but_save.Text = "SAVE";
            this.but_save.UseVisualStyleBackColor = true;
            this.but_save.Click += new System.EventHandler(this.but_save_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(280, 331);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(309, 26);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // txt_lab
            // 
            this.txt_lab.Location = new System.Drawing.Point(381, 371);
            this.txt_lab.Name = "txt_lab";
            this.txt_lab.Size = new System.Drawing.Size(100, 26);
            this.txt_lab.TabIndex = 5;
            this.txt_lab.Visible = false;
            // 
            // Addnews
            // 
            this.AcceptButton = this.but_save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_lab);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.but_save);
            this.Controls.Add(this.txt_content);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.txt_type);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Addnews";
            this.Text = "Addnews";
            this.Load += new System.EventHandler(this.Addnews_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_type;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.TextBox txt_content;
        private System.Windows.Forms.Button but_save;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txt_lab;
    }
}