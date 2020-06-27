namespace QuanLiNhaSach
{
    partial class frmMain
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
			this.menupanel = new System.Windows.Forms.Panel();
			this.quydinhbutton = new System.Windows.Forms.Button();
			this.lapbaocaobutton = new System.Windows.Forms.Button();
			this.quanlibutton = new System.Windows.Forms.Button();
			this.lapphieubutton = new System.Windows.Forms.Button();
			this.tracuubutton = new System.Windows.Forms.Button();
			this.toppanel = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.childformpanel = new System.Windows.Forms.Panel();
			this.menupanel.SuspendLayout();
			this.toppanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// menupanel
			// 
			this.menupanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.menupanel.Controls.Add(this.quydinhbutton);
			this.menupanel.Controls.Add(this.lapbaocaobutton);
			this.menupanel.Controls.Add(this.quanlibutton);
			this.menupanel.Controls.Add(this.lapphieubutton);
			this.menupanel.Controls.Add(this.tracuubutton);
			this.menupanel.Cursor = System.Windows.Forms.Cursors.Default;
			this.menupanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.menupanel.Location = new System.Drawing.Point(0, 100);
			this.menupanel.Name = "menupanel";
			this.menupanel.Size = new System.Drawing.Size(160, 465);
			this.menupanel.TabIndex = 0;
			// 
			// quydinhbutton
			// 
			this.quydinhbutton.Dock = System.Windows.Forms.DockStyle.Top;
			this.quydinhbutton.FlatAppearance.BorderSize = 0;
			this.quydinhbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.quydinhbutton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.quydinhbutton.Location = new System.Drawing.Point(0, 225);
			this.quydinhbutton.Name = "quydinhbutton";
			this.quydinhbutton.Size = new System.Drawing.Size(158, 77);
			this.quydinhbutton.TabIndex = 5;
			this.quydinhbutton.Text = "Quy định";
			this.quydinhbutton.UseVisualStyleBackColor = true;
			this.quydinhbutton.Click += new System.EventHandler(this.quydinhbutton_Click);
			// 
			// lapbaocaobutton
			// 
			this.lapbaocaobutton.Dock = System.Windows.Forms.DockStyle.Top;
			this.lapbaocaobutton.FlatAppearance.BorderSize = 0;
			this.lapbaocaobutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lapbaocaobutton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lapbaocaobutton.Location = new System.Drawing.Point(0, 148);
			this.lapbaocaobutton.Name = "lapbaocaobutton";
			this.lapbaocaobutton.Size = new System.Drawing.Size(158, 77);
			this.lapbaocaobutton.TabIndex = 4;
			this.lapbaocaobutton.Text = "Lập báo cáo";
			this.lapbaocaobutton.UseVisualStyleBackColor = true;
			this.lapbaocaobutton.Click += new System.EventHandler(this.lapbaocaobutton_Click);
			// 
			// quanlibutton
			// 
			this.quanlibutton.Dock = System.Windows.Forms.DockStyle.Top;
			this.quanlibutton.FlatAppearance.BorderSize = 0;
			this.quanlibutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.quanlibutton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.quanlibutton.Location = new System.Drawing.Point(0, 71);
			this.quanlibutton.Name = "quanlibutton";
			this.quanlibutton.Size = new System.Drawing.Size(158, 77);
			this.quanlibutton.TabIndex = 3;
			this.quanlibutton.Text = "Quản lí nhân viên";
			this.quanlibutton.UseVisualStyleBackColor = true;
			this.quanlibutton.Click += new System.EventHandler(this.quanlibutton_Click);
			// 
			// lapphieubutton
			// 
			this.lapphieubutton.Dock = System.Windows.Forms.DockStyle.Top;
			this.lapphieubutton.FlatAppearance.BorderSize = 0;
			this.lapphieubutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lapphieubutton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lapphieubutton.Location = new System.Drawing.Point(0, 0);
			this.lapphieubutton.Name = "lapphieubutton";
			this.lapphieubutton.Size = new System.Drawing.Size(158, 71);
			this.lapphieubutton.TabIndex = 2;
			this.lapphieubutton.Text = "Lập phiếu";
			this.lapphieubutton.UseVisualStyleBackColor = true;
			this.lapphieubutton.Click += new System.EventHandler(this.lapphieubutton_Click);
			// 
			// tracuubutton
			// 
			this.tracuubutton.BackColor = System.Drawing.SystemColors.Control;
			this.tracuubutton.FlatAppearance.BorderSize = 0;
			this.tracuubutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.tracuubutton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tracuubutton.Location = new System.Drawing.Point(0, 0);
			this.tracuubutton.Name = "tracuubutton";
			this.tracuubutton.Size = new System.Drawing.Size(158, 77);
			this.tracuubutton.TabIndex = 1;
			this.tracuubutton.Text = "Tra cứu";
			this.tracuubutton.UseVisualStyleBackColor = false;
			this.tracuubutton.Click += new System.EventHandler(this.tracuubutton_Click);
			// 
			// toppanel
			// 
			this.toppanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.toppanel.Controls.Add(this.label1);
			this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.toppanel.Location = new System.Drawing.Point(0, 0);
			this.toppanel.Name = "toppanel";
			this.toppanel.Size = new System.Drawing.Size(833, 100);
			this.toppanel.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(178, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(515, 73);
			this.label1.TabIndex = 0;
			this.label1.Text = "QUẢN LÍ NHÀ SÁCH";
			// 
			// childformpanel
			// 
			this.childformpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.childformpanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.childformpanel.Location = new System.Drawing.Point(160, 100);
			this.childformpanel.Name = "childformpanel";
			this.childformpanel.Size = new System.Drawing.Size(673, 465);
			this.childformpanel.TabIndex = 2;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(833, 565);
			this.Controls.Add(this.childformpanel);
			this.Controls.Add(this.menupanel);
			this.Controls.Add(this.toppanel);
			this.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MinimumSize = new System.Drawing.Size(833, 565);
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.menupanel.ResumeLayout(false);
			this.toppanel.ResumeLayout(false);
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Panel menupanel;
		private System.Windows.Forms.Button lapbaocaobutton;
		private System.Windows.Forms.Button quanlibutton;
		private System.Windows.Forms.Button lapphieubutton;
		private System.Windows.Forms.Button tracuubutton;
		private System.Windows.Forms.Panel toppanel;
		private System.Windows.Forms.Panel childformpanel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button quydinhbutton;
	}
}