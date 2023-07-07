namespace ADMIN
{
    partial class RECORD
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
            this.but_search = new System.Windows.Forms.Button();
            this.but_add = new System.Windows.Forms.Button();
            this.but_edit = new System.Windows.Forms.Button();
            this.but_delete = new System.Windows.Forms.Button();
            this.txt_record = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.computer_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // but_search
            // 
            this.but_search.Location = new System.Drawing.Point(222, 27);
            this.but_search.Name = "but_search";
            this.but_search.Size = new System.Drawing.Size(134, 37);
            this.but_search.TabIndex = 0;
            this.but_search.Text = "SEARCH";
            this.but_search.UseVisualStyleBackColor = true;
            this.but_search.Click += new System.EventHandler(this.but_search_Click);
            // 
            // but_add
            // 
            this.but_add.Location = new System.Drawing.Point(651, 27);
            this.but_add.Name = "but_add";
            this.but_add.Size = new System.Drawing.Size(82, 37);
            this.but_add.TabIndex = 0;
            this.but_add.Text = "ADD";
            this.but_add.UseVisualStyleBackColor = true;
            this.but_add.Click += new System.EventHandler(this.but_add_Click);
            // 
            // but_edit
            // 
            this.but_edit.Location = new System.Drawing.Point(788, 27);
            this.but_edit.Name = "but_edit";
            this.but_edit.Size = new System.Drawing.Size(82, 37);
            this.but_edit.TabIndex = 0;
            this.but_edit.Text = "EDIT";
            this.but_edit.UseVisualStyleBackColor = true;
            this.but_edit.Click += new System.EventHandler(this.but_edit_Click);
            // 
            // but_delete
            // 
            this.but_delete.Location = new System.Drawing.Point(925, 27);
            this.but_delete.Name = "but_delete";
            this.but_delete.Size = new System.Drawing.Size(82, 37);
            this.but_delete.TabIndex = 0;
            this.but_delete.Text = "DELETE";
            this.but_delete.UseVisualStyleBackColor = true;
            this.but_delete.Click += new System.EventHandler(this.but_delete_Click);
            // 
            // txt_record
            // 
            this.txt_record.Location = new System.Drawing.Point(12, 32);
            this.txt_record.Name = "txt_record";
            this.txt_record.Size = new System.Drawing.Size(204, 26);
            this.txt_record.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.customer_id,
            this.computer_id,
            this.start_time,
            this.end_time});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1047, 409);
            this.dataGridView1.TabIndex = 2;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            // 
            // customer_id
            // 
            this.customer_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customer_id.DataPropertyName = "customer_id";
            this.customer_id.HeaderText = "CUSTOMER_ID";
            this.customer_id.MinimumWidth = 8;
            this.customer_id.Name = "customer_id";
            // 
            // computer_id
            // 
            this.computer_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.computer_id.DataPropertyName = "computer_id";
            this.computer_id.HeaderText = "COMPUTER_ID";
            this.computer_id.MinimumWidth = 8;
            this.computer_id.Name = "computer_id";
            // 
            // start_time
            // 
            this.start_time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.start_time.DataPropertyName = "start_time";
            this.start_time.HeaderText = "START_TIME";
            this.start_time.MinimumWidth = 8;
            this.start_time.Name = "start_time";
            // 
            // end_time
            // 
            this.end_time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.end_time.DataPropertyName = "end_time";
            this.end_time.HeaderText = "END_TIME";
            this.end_time.MinimumWidth = 8;
            this.end_time.Name = "end_time";
            // 
            // RECORD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(49)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(1047, 516);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_record);
            this.Controls.Add(this.but_delete);
            this.Controls.Add(this.but_edit);
            this.Controls.Add(this.but_add);
            this.Controls.Add(this.but_search);
            this.Name = "RECORD";
            this.Text = "RECORD";
            this.Load += new System.EventHandler(this.RECORD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_search;
        private System.Windows.Forms.Button but_add;
        private System.Windows.Forms.Button but_edit;
        private System.Windows.Forms.Button but_delete;
        private System.Windows.Forms.TextBox txt_record;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn computer_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn start_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn end_time;
    }
}