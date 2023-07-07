namespace ADMIN.GUI
{
    partial class Addrecord
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_computer = new System.Windows.Forms.TextBox();
            this.dateTime_start = new System.Windows.Forms.DateTimePicker();
            this.dateTime_end = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.but_OK = new System.Windows.Forms.Button();
            this.txt_customer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(94, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CUSTOMER_ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(94, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "COMPUTER_ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(94, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "START_TIME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(94, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "END_TIME";
            // 
            // txt_computer
            // 
            this.txt_computer.Location = new System.Drawing.Point(307, 97);
            this.txt_computer.Name = "txt_computer";
            this.txt_computer.Size = new System.Drawing.Size(286, 26);
            this.txt_computer.TabIndex = 1;
            // 
            // dateTime_start
            // 
            this.dateTime_start.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTime_start.Location = new System.Drawing.Point(307, 149);
            this.dateTime_start.Name = "dateTime_start";
            this.dateTime_start.Size = new System.Drawing.Size(286, 26);
            this.dateTime_start.TabIndex = 2;
            // 
            // dateTime_end
            // 
            this.dateTime_end.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTime_end.Location = new System.Drawing.Point(307, 194);
            this.dateTime_end.Name = "dateTime_end";
            this.dateTime_end.Size = new System.Drawing.Size(286, 26);
            this.dateTime_end.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(94, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "ID";
            this.label5.Visible = false;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(307, 12);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(286, 26);
            this.txt_id.TabIndex = 1;
            this.txt_id.Visible = false;
            // 
            // but_OK
            // 
            this.but_OK.Location = new System.Drawing.Point(266, 256);
            this.but_OK.Name = "but_OK";
            this.but_OK.Size = new System.Drawing.Size(96, 31);
            this.but_OK.TabIndex = 3;
            this.but_OK.Text = "OK";
            this.but_OK.UseVisualStyleBackColor = true;
            this.but_OK.Click += new System.EventHandler(this.but_OK_Click);
            // 
            // txt_customer
            // 
            this.txt_customer.Location = new System.Drawing.Point(307, 47);
            this.txt_customer.Name = "txt_customer";
            this.txt_customer.Size = new System.Drawing.Size(286, 26);
            this.txt_customer.TabIndex = 1;
            // 
            // Addrecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(616, 307);
            this.Controls.Add(this.but_OK);
            this.Controls.Add(this.dateTime_end);
            this.Controls.Add(this.dateTime_start);
            this.Controls.Add(this.txt_customer);
            this.Controls.Add(this.txt_computer);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Addrecord";
            this.Text = "Addrecord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
   //     private System.Windows.Forms.TextBox Convert.ToInt32;
        private System.Windows.Forms.TextBox txt_computer;
        private System.Windows.Forms.DateTimePicker dateTime_start;
        private System.Windows.Forms.DateTimePicker dateTime_end;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button but_OK;
        private System.Windows.Forms.TextBox txt_customer;
    }
}