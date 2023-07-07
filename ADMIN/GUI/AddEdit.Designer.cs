namespace ADMIN.GUI
{
    partial class AddEdit
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
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_remainingtime = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(69, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "USER NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(69, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "REMAINING TIME";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(335, 72);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(356, 26);
            this.txt_username.TabIndex = 2;
            // 
            // txt_remainingtime
            // 
            this.txt_remainingtime.Location = new System.Drawing.Point(335, 139);
            this.txt_remainingtime.Name = "txt_remainingtime";
            this.txt_remainingtime.Size = new System.Drawing.Size(356, 26);
            this.txt_remainingtime.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(335, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(335, 200);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(356, 26);
            this.txt_id.TabIndex = 4;
            this.txt_id.Visible = false;
            // 
            // AddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_remainingtime);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddEdit";
            this.Text = "AddEdit";
            this.Load += new System.EventHandler(this.AddEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_remainingtime;
        private object but_ok;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_id;
    }
}