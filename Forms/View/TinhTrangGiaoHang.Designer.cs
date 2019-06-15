namespace QuanLyShipper
{
	partial class TinhTrangGiaoHang
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
			this.cbx_maShipper = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.date_Start = new System.Windows.Forms.DateTimePicker();
			this.date_End = new System.Windows.Forms.DateTimePicker();
			this.btn_lapDH = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(235, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(318, 34);
			this.label1.TabIndex = 3;
			this.label1.Text = "Tình Trạng Giao Hàng";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(28, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 17);
			this.label2.TabIndex = 10;
			this.label2.Text = "Mã Shipper";
			// 
			// cbx_maShipper
			// 
			this.cbx_maShipper.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbx_maShipper.FormattingEnabled = true;
			this.cbx_maShipper.Location = new System.Drawing.Point(143, 93);
			this.cbx_maShipper.Name = "cbx_maShipper";
			this.cbx_maShipper.Size = new System.Drawing.Size(224, 21);
			this.cbx_maShipper.TabIndex = 23;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(436, 97);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 17);
			this.label3.TabIndex = 24;
			this.label3.Text = "Từ Ngày";
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(436, 137);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 17);
			this.label4.TabIndex = 26;
			this.label4.Text = "Đến Ngày";
			// 
			// comboBox1
			// 
			this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(143, 137);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(224, 21);
			this.comboBox1.TabIndex = 29;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(28, 137);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(98, 17);
			this.label5.TabIndex = 28;
			this.label5.Text = "Mã Đơn Hàng";
			this.label5.Click += new System.EventHandler(this.label5_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(31, 190);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(735, 208);
			this.dataGridView1.TabIndex = 30;
			// 
			// date_Start
			// 
			this.date_Start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.date_Start.CustomFormat = "dd/MM/yyyy";
			this.date_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.date_Start.Location = new System.Drawing.Point(566, 97);
			this.date_Start.Name = "date_Start";
			this.date_Start.Size = new System.Drawing.Size(200, 20);
			this.date_Start.TabIndex = 31;
			// 
			// date_End
			// 
			this.date_End.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.date_End.CustomFormat = "dd/MM/yyyy";
			this.date_End.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.date_End.Location = new System.Drawing.Point(566, 138);
			this.date_End.Name = "date_End";
			this.date_End.Size = new System.Drawing.Size(200, 20);
			this.date_End.TabIndex = 32;
			// 
			// btn_lapDH
			// 
			this.btn_lapDH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_lapDH.Location = new System.Drawing.Point(566, 404);
			this.btn_lapDH.Name = "btn_lapDH";
			this.btn_lapDH.Size = new System.Drawing.Size(98, 54);
			this.btn_lapDH.TabIndex = 33;
			this.btn_lapDH.Text = "Gán Shipper Giao Lại";
			this.btn_lapDH.UseVisualStyleBackColor = true;
			this.btn_lapDH.Click += new System.EventHandler(this.btn_lapDH_Click);
			// 
			// button2
			// 
			this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button2.Location = new System.Drawing.Point(679, 404);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(98, 54);
			this.button2.TabIndex = 35;
			this.button2.Text = "Quay lại";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// TinhTrangGiaoHang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(781, 470);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.btn_lapDH);
			this.Controls.Add(this.date_End);
			this.Controls.Add(this.date_Start);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cbx_maShipper);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MinimumSize = new System.Drawing.Size(797, 509);
			this.Name = "TinhTrangGiaoHang";
			this.Text = "TinhTrangGiaoHang";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbx_maShipper;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DateTimePicker date_Start;
		private System.Windows.Forms.DateTimePicker date_End;
		private System.Windows.Forms.Button btn_lapDH;
		private System.Windows.Forms.Button button2;
	}
}