namespace Net4
{
    partial class BTDRINK
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbID = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.foodimage = new System.Windows.Forms.PictureBox();
            this.drinkimage = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rechargeimage = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drinkimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rechargeimage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lbID);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 155);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 62);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbID.Location = new System.Drawing.Point(105, 8);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(0, 12);
            this.lbID.TabIndex = 3;
            this.lbID.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(91, 25);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "ORDER";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(2, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "15000đ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cocacola";
            // 
            // foodimage
            // 
            this.foodimage.Image = global::Net4.Properties.Resources.foodimage;
            this.foodimage.Location = new System.Drawing.Point(0, 0);
            this.foodimage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.foodimage.Name = "foodimage";
            this.foodimage.Size = new System.Drawing.Size(183, 155);
            this.foodimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foodimage.TabIndex = 3;
            this.foodimage.TabStop = false;
            this.foodimage.Visible = false;
            // 
            // drinkimage
            // 
            this.drinkimage.Image = global::Net4.Properties.Resources.drinkimage;
            this.drinkimage.Location = new System.Drawing.Point(0, 0);
            this.drinkimage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.drinkimage.Name = "drinkimage";
            this.drinkimage.Size = new System.Drawing.Size(183, 155);
            this.drinkimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.drinkimage.TabIndex = 2;
            this.drinkimage.TabStop = false;
            this.drinkimage.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Net4.Properties.Resources._00293;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // rechargeimage
            // 
            this.rechargeimage.Image = global::Net4.Properties.Resources.moneyimage;
            this.rechargeimage.Location = new System.Drawing.Point(-1, -1);
            this.rechargeimage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rechargeimage.Name = "rechargeimage";
            this.rechargeimage.Size = new System.Drawing.Size(183, 155);
            this.rechargeimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rechargeimage.TabIndex = 4;
            this.rechargeimage.TabStop = false;
            this.rechargeimage.Visible = false;
            // 
            // BTDRINK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rechargeimage);
            this.Controls.Add(this.foodimage);
            this.Controls.Add(this.drinkimage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BTDRINK";
            this.Size = new System.Drawing.Size(183, 217);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drinkimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rechargeimage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label lbID;
        public System.Windows.Forms.PictureBox drinkimage;
        public System.Windows.Forms.PictureBox foodimage;
        public System.Windows.Forms.PictureBox rechargeimage;
    }
}
