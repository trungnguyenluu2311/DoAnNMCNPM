namespace QuanLiNhaSach
{
	partial class frmTracuu
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
			this.label1 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel8 = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.button3 = new System.Windows.Forms.Button();
			this.panel3 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel8.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel7.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(920, 64);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(313, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(273, 49);
			this.label1.TabIndex = 0;
			this.label1.Text = "TRA CỨU SÁCH";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.Window;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.panel4);
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 64);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(920, 504);
			this.panel2.TabIndex = 1;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.panel8);
			this.panel4.Controls.Add(this.panel6);
			this.panel4.Controls.Add(this.panel5);
			this.panel4.Controls.Add(this.panel7);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(0, 193);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(918, 309);
			this.panel4.TabIndex = 5;
			// 
			// panel8
			// 
			this.panel8.Controls.Add(this.dataGridView1);
			this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel8.ForeColor = System.Drawing.SystemColors.ControlText;
			this.panel8.Location = new System.Drawing.Point(80, 0);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(758, 229);
			this.panel8.TabIndex = 5;
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(758, 229);
			this.dataGridView1.TabIndex = 2;
			// 
			// Column1
			// 
			this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column1.HeaderText = "Tên sách";
			this.Column1.MinimumWidth = 6;
			this.Column1.Name = "Column1";
			// 
			// Column2
			// 
			this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column2.HeaderText = "Thể loại";
			this.Column2.MinimumWidth = 6;
			this.Column2.Name = "Column2";
			// 
			// Column3
			// 
			this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column3.HeaderText = "Tác giả";
			this.Column3.MinimumWidth = 6;
			this.Column3.Name = "Column3";
			// 
			// Column4
			// 
			this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column4.HeaderText = "Số lượng";
			this.Column4.MinimumWidth = 6;
			this.Column4.Name = "Column4";
			// 
			// Column5
			// 
			this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Column5.HeaderText = "Đơn giá";
			this.Column5.MinimumWidth = 6;
			this.Column5.Name = "Column5";
			// 
			// panel6
			// 
			this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel6.Location = new System.Drawing.Point(838, 0);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(80, 229);
			this.panel6.TabIndex = 3;
			// 
			// panel5
			// 
			this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel5.Location = new System.Drawing.Point(0, 0);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(80, 229);
			this.panel5.TabIndex = 2;
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.button3);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel7.Location = new System.Drawing.Point(0, 229);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(918, 80);
			this.panel7.TabIndex = 4;
			// 
			// button3
			// 
			this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.button3.BackColor = System.Drawing.Color.Firebrick;
			this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.button3.ForeColor = System.Drawing.SystemColors.Window;
			this.button3.Location = new System.Drawing.Point(720, 17);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(106, 46);
			this.button3.TabIndex = 0;
			this.button3.Text = "OK";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.button1);
			this.panel3.Controls.Add(this.textBox2);
			this.panel3.Controls.Add(this.button2);
			this.panel3.Controls.Add(this.textBox4);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.textBox3);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.textBox1);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(918, 193);
			this.panel3.TabIndex = 4;
			// 
			// button1
			// 
			this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.button1.BackColor = System.Drawing.Color.Firebrick;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.button1.ForeColor = System.Drawing.SystemColors.Window;
			this.button1.Location = new System.Drawing.Point(732, 123);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(106, 46);
			this.button1.TabIndex = 0;
			this.button1.Text = "Clear";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// textBox2
			// 
			this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textBox2.Location = new System.Drawing.Point(181, 75);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(250, 24);
			this.textBox2.TabIndex = 3;
			// 
			// button2
			// 
			this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.button2.BackColor = System.Drawing.Color.Firebrick;
			this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.button2.ForeColor = System.Drawing.SystemColors.Window;
			this.button2.Location = new System.Drawing.Point(620, 123);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(106, 46);
			this.button2.TabIndex = 0;
			this.button2.Text = "Tra";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2_Click);
			// 
			// textBox4
			// 
			this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textBox4.Location = new System.Drawing.Point(583, 76);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(255, 24);
			this.textBox4.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label2.Location = new System.Drawing.Point(80, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(97, 29);
			this.label2.TabIndex = 2;
			this.label2.Text = "Tên sách";
			// 
			// textBox3
			// 
			this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textBox3.Location = new System.Drawing.Point(583, 21);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(255, 24);
			this.textBox3.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label3.Location = new System.Drawing.Point(485, 70);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(79, 29);
			this.label3.TabIndex = 2;
			this.label3.Text = "Tác giả";
			// 
			// textBox1
			// 
			this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.textBox1.Location = new System.Drawing.Point(181, 21);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(250, 24);
			this.textBox1.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label4.Location = new System.Drawing.Point(485, 15);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(92, 29);
			this.label4.TabIndex = 2;
			this.label4.Text = "Thể loại";
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.label5.Location = new System.Drawing.Point(80, 15);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(95, 29);
			this.label5.TabIndex = 2;
			this.label5.Text = "Mã sách";
			// 
			// frmTracuu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(920, 568);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "frmTracuu";
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel7.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
	}
}