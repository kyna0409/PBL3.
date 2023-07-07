namespace ADMIN
{
    partial class TTKH
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.but_Search = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remaining_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.but_Delete = new System.Windows.Forms.Button();
            this.but_edit = new System.Windows.Forms.Button();
            this.but_Add = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(415, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(46, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(341, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "QUẢN LÍ KHÁCH HÀNG >";
            // 
            // but_Search
            // 
            this.but_Search.Location = new System.Drawing.Point(52, 157);
            this.but_Search.Name = "but_Search";
            this.but_Search.Size = new System.Drawing.Size(104, 38);
            this.but_Search.TabIndex = 5;
            this.but_Search.Text = "SEARCH";
            this.but_Search.UseVisualStyleBackColor = true;
            this.but_Search.Click += new System.EventHandler(this.but_Search_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(193, 157);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(215, 38);
            this.textBox1.TabIndex = 6;
           
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv);
            this.panel1.Location = new System.Drawing.Point(3, 249);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1127, 407);
            this.panel1.TabIndex = 7;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.user_name,
            this.remaining_time});
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 28;
            this.dgv.Size = new System.Drawing.Size(1127, 407);
            this.dgv.TabIndex = 0;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            // 
            // user_name
            // 
            this.user_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.user_name.DataPropertyName = "user_name";
            this.user_name.HeaderText = "Tên tài khoản";
            this.user_name.MinimumWidth = 8;
            this.user_name.Name = "user_name";
            // 
            // remaining_time
            // 
            this.remaining_time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.remaining_time.DataPropertyName = "remaining_time";
            this.remaining_time.HeaderText = "Thời gian";
            this.remaining_time.MinimumWidth = 8;
            this.remaining_time.Name = "remaining_time";
            // 
            // but_Delete
            // 
            this.but_Delete.Location = new System.Drawing.Point(677, 699);
            this.but_Delete.Name = "but_Delete";
            this.but_Delete.Size = new System.Drawing.Size(104, 38);
            this.but_Delete.TabIndex = 8;
            this.but_Delete.Text = "DELETE";
            this.but_Delete.UseVisualStyleBackColor = true;
            this.but_Delete.Click += new System.EventHandler(this.but_Delete_Click);
            // 
            // but_edit
            // 
            this.but_edit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.but_edit.Location = new System.Drawing.Point(480, 699);
            this.but_edit.Name = "but_edit";
            this.but_edit.Size = new System.Drawing.Size(104, 38);
            this.but_edit.TabIndex = 9;
            this.but_edit.Text = "EDIT";
            this.but_edit.UseVisualStyleBackColor = true;
            this.but_edit.Click += new System.EventHandler(this.but_edit_Click);
            // 
            // but_Add
            // 
            this.but_Add.Location = new System.Drawing.Point(265, 699);
            this.but_Add.Name = "but_Add";
            this.but_Add.Size = new System.Drawing.Size(104, 38);
            this.but_Add.TabIndex = 10;
            this.but_Add.Text = "ADD";
            this.but_Add.UseVisualStyleBackColor = true;
            this.but_Add.Click += new System.EventHandler(this.but_Add_Click);
            // 
            // TTKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.Controls.Add(this.but_Delete);
            this.Controls.Add(this.but_edit);
            this.Controls.Add(this.but_Add);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.but_Search);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Name = "TTKH";
            this.Size = new System.Drawing.Size(1084, 783);
            this.Load += new System.EventHandler(this.TTKH_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button but_Search;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button but_Delete;
        private System.Windows.Forms.Button but_edit;
        private System.Windows.Forms.Button but_Add;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn remaining_time;
    }
}
