namespace Net4
{
    partial class GAMES
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tools = new System.Windows.Forms.PictureBox();
            this.offlinegame = new System.Windows.Forms.PictureBox();
            this.onlinegame = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tools)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offlinegame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlinegame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 134);
            this.button1.TabIndex = 0;
            this.button1.Text = "Liên minh huyền thoại";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 2;
            this.label1.Visible = false;
            // 
            // tools
            // 
            this.tools.BackColor = System.Drawing.Color.Transparent;
            this.tools.Image = global::Net4.Properties.Resources.tools;
            this.tools.Location = new System.Drawing.Point(21, 12);
            this.tools.Name = "tools";
            this.tools.Size = new System.Drawing.Size(73, 71);
            this.tools.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tools.TabIndex = 5;
            this.tools.TabStop = false;
            this.tools.Visible = false;
            // 
            // offlinegame
            // 
            this.offlinegame.BackColor = System.Drawing.Color.Transparent;
            this.offlinegame.Image = global::Net4.Properties.Resources.offlinegame_removebg_preview;
            this.offlinegame.Location = new System.Drawing.Point(21, 12);
            this.offlinegame.Name = "offlinegame";
            this.offlinegame.Size = new System.Drawing.Size(73, 71);
            this.offlinegame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.offlinegame.TabIndex = 4;
            this.offlinegame.TabStop = false;
            this.offlinegame.Visible = false;
            // 
            // onlinegame
            // 
            this.onlinegame.BackColor = System.Drawing.Color.Transparent;
            this.onlinegame.Image = global::Net4.Properties.Resources._4330504;
            this.onlinegame.Location = new System.Drawing.Point(21, 12);
            this.onlinegame.Name = "onlinegame";
            this.onlinegame.Size = new System.Drawing.Size(73, 71);
            this.onlinegame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.onlinegame.TabIndex = 3;
            this.onlinegame.TabStop = false;
            this.onlinegame.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Net4.Properties.Resources.LoL_icon_svg;
            this.pictureBox1.Location = new System.Drawing.Point(21, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // GAMES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.Controls.Add(this.tools);
            this.Controls.Add(this.offlinegame);
            this.Controls.Add(this.onlinegame);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GAMES";
            this.Size = new System.Drawing.Size(113, 134);
            this.Load += new System.EventHandler(this.GAME_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tools)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offlinegame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlinegame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox onlinegame;
        public System.Windows.Forms.PictureBox offlinegame;
        public System.Windows.Forms.PictureBox tools;
    }
}
