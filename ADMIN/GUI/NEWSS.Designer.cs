namespace ADMIN.GUI
{
    partial class NEWSS
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
            this.but_add = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // but_add
            // 
            this.but_add.ForeColor = System.Drawing.Color.Crimson;
            this.but_add.Location = new System.Drawing.Point(924, 19);
            this.but_add.Name = "but_add";
            this.but_add.Size = new System.Drawing.Size(75, 36);
            this.but_add.TabIndex = 0;
            this.but_add.Text = "ADD";
            this.but_add.UseVisualStyleBackColor = true;
            this.but_add.Click += new System.EventHandler(this.but_add_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(34, 92);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1166, 482);
            this.flowLayoutPanel1.TabIndex = 1;
        
            // 
            // NEWSS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.but_add);
            this.Name = "NEWSS";
            this.Size = new System.Drawing.Size(1232, 594);
            this.Load += new System.EventHandler(this.NEWSS_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_add;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
