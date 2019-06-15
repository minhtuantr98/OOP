namespace QuanLyShipper
{
	partial class ThongKeDoanhThu
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
			this.cbx_maShipper = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.date_End = new System.Windows.Forms.DateTimePicker();
			this.date_Start = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.txtDoanhthu = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// cbx_maShipper
			// 
			this.cbx_maShipper.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbx_maShipper.FormattingEnabled = true;
			this.cbx_maShipper.Location = new System.Drawing.Point(159, 100);
			this.cbx_maShipper.Name = "cbx_maShipper";
			this.cbx_maShipper.Size = new System.Drawing.Size(124, 21);
			this.cbx_maShipper.TabIndex = 13;
			this.cbx_maShipper.SelectedIndexChanged += new System.EventHandler(this.cbx_maShipper_SelectedIndexChanged);
			this.cbx_maShipper.SelectionChangeCommitted += new System.EventHandler(this.cbx_maShipper_SelectionChangeCommitted);
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(59, 100);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 17);
			this.label3.TabIndex = 12;
			this.label3.Text = "Mã Shipper";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// date_End
			// 
			this.date_End.CustomFormat = "dd/MM/yyyy";
			this.date_End.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.date_End.Location = new System.Drawing.Point(432, 138);
			this.date_End.Name = "date_End";
			this.date_End.Size = new System.Drawing.Size(297, 20);
			this.date_End.TabIndex = 36;
			this.date_End.ValueChanged += new System.EventHandler(this.date_End_ValueChanged);
			// 
			// date_Start
			// 
			this.date_Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.date_Start.CustomFormat = "dd/MM/yyyy";
			this.date_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.date_Start.Location = new System.Drawing.Point(432, 97);
			this.date_Start.Name = "date_Start";
			this.date_Start.Size = new System.Drawing.Size(297, 20);
			this.date_Start.TabIndex = 35;
			this.date_Start.ValueChanged += new System.EventHandler(this.date_Start_ValueChanged);
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(323, 137);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 17);
			this.label4.TabIndex = 34;
			this.label4.Text = "Đến Ngày";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(323, 97);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 17);
			this.label2.TabIndex = 33;
			this.label2.Text = "Từ Ngày";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(62, 189);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(667, 168);
			this.dataGridView1.TabIndex = 37;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(230, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(311, 34);
			this.label1.TabIndex = 39;
			this.label1.Text = "Thống Kê Doanh Thu";
			// 
			// txtDoanhthu
			// 
			this.txtDoanhthu.Location = new System.Drawing.Point(167, 368);
			this.txtDoanhthu.Name = "txtDoanhthu";
			this.txtDoanhthu.Size = new System.Drawing.Size(168, 20);
			this.txtDoanhthu.TabIndex = 55;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(647, 361);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(82, 39);
			this.button1.TabIndex = 56;
			this.button1.Text = "Quay Lại";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(57, 371);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(83, 13);
			this.label5.TabIndex = 57;
			this.label5.Text = "Tổng doanh thu";
			// 
			// ThongKeDoanhThu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(781, 403);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtDoanhthu);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.cbx_maShipper);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.date_Start);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.date_End);
			this.Controls.Add(this.label4);
			this.MinimumSize = new System.Drawing.Size(797, 442);
			this.Name = "ThongKeDoanhThu";
			this.Text = "ThongKeDoanhThu";
			this.Load += new System.EventHandler(this.ThongKeDoanhThu_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ComboBox cbx_maShipper;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DateTimePicker date_End;
		private System.Windows.Forms.DateTimePicker date_Start;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtDoanhthu;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label5;
	}
}