namespace QuanLyShipper
{
	partial class AddShipper
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
			this.txt_maShipper = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_tenShipper = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.Phái = new System.Windows.Forms.Label();
			this.txt_sdt = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_birthday = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txt_mail = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.cbx_City = new System.Windows.Forms.ComboBox();
			this.btn_add = new System.Windows.Forms.Button();
			this.btn_reset = new System.Windows.Forms.Button();
			this.cbx_Quan = new System.Windows.Forms.ComboBox();
			this.rNam = new System.Windows.Forms.RadioButton();
			this.rNu = new System.Windows.Forms.RadioButton();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnSua = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// txt_maShipper
			// 
			this.txt_maShipper.Location = new System.Drawing.Point(153, 30);
			this.txt_maShipper.Name = "txt_maShipper";
			this.txt_maShipper.Size = new System.Drawing.Size(121, 20);
			this.txt_maShipper.TabIndex = 9;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(36, 30);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 17);
			this.label2.TabIndex = 8;
			this.label2.Text = "Mã Shipper";
			// 
			// txt_tenShipper
			// 
			this.txt_tenShipper.Location = new System.Drawing.Point(153, 80);
			this.txt_tenShipper.Name = "txt_tenShipper";
			this.txt_tenShipper.Size = new System.Drawing.Size(121, 20);
			this.txt_tenShipper.TabIndex = 11;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(36, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 17);
			this.label3.TabIndex = 10;
			this.label3.Text = "Họ Tên";
			// 
			// Phái
			// 
			this.Phái.AutoSize = true;
			this.Phái.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Phái.Location = new System.Drawing.Point(36, 128);
			this.Phái.Name = "Phái";
			this.Phái.Size = new System.Drawing.Size(67, 17);
			this.Phái.TabIndex = 13;
			this.Phái.Text = "Giới Tính";
			// 
			// txt_sdt
			// 
			this.txt_sdt.Location = new System.Drawing.Point(153, 211);
			this.txt_sdt.Name = "txt_sdt";
			this.txt_sdt.Size = new System.Drawing.Size(121, 20);
			this.txt_sdt.TabIndex = 15;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(36, 211);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 17);
			this.label4.TabIndex = 14;
			this.label4.Text = "SĐT";
			// 
			// txt_birthday
			// 
			this.txt_birthday.Location = new System.Drawing.Point(153, 173);
			this.txt_birthday.Name = "txt_birthday";
			this.txt_birthday.Size = new System.Drawing.Size(121, 20);
			this.txt_birthday.TabIndex = 17;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(36, 173);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(74, 17);
			this.label5.TabIndex = 16;
			this.label5.Text = "Ngày Sinh";
			// 
			// txt_mail
			// 
			this.txt_mail.Location = new System.Drawing.Point(153, 261);
			this.txt_mail.Name = "txt_mail";
			this.txt_mail.Size = new System.Drawing.Size(121, 20);
			this.txt_mail.TabIndex = 19;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(36, 261);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(45, 17);
			this.label6.TabIndex = 18;
			this.label6.Text = "Email";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(36, 301);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(65, 17);
			this.label7.TabIndex = 20;
			this.label7.Text = "Khu Vực";
			// 
			// cbx_City
			// 
			this.cbx_City.FormattingEnabled = true;
			this.cbx_City.Location = new System.Drawing.Point(153, 301);
			this.cbx_City.Name = "cbx_City";
			this.cbx_City.Size = new System.Drawing.Size(121, 21);
			this.cbx_City.TabIndex = 22;
			this.cbx_City.SelectedIndexChanged += new System.EventHandler(this.cbx_City_SelectedIndexChanged);
			// 
			// btn_add
			// 
			this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_add.Location = new System.Drawing.Point(334, 419);
			this.btn_add.Name = "btn_add";
			this.btn_add.Size = new System.Drawing.Size(82, 39);
			this.btn_add.TabIndex = 25;
			this.btn_add.Text = "Thêm";
			this.btn_add.UseVisualStyleBackColor = true;
			this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
			// 
			// btn_reset
			// 
			this.btn_reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_reset.Location = new System.Drawing.Point(568, 419);
			this.btn_reset.Name = "btn_reset";
			this.btn_reset.Size = new System.Drawing.Size(82, 39);
			this.btn_reset.TabIndex = 26;
			this.btn_reset.Text = "Xóa";
			this.btn_reset.UseVisualStyleBackColor = true;
			this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
			// 
			// cbx_Quan
			// 
			this.cbx_Quan.FormattingEnabled = true;
			this.cbx_Quan.Location = new System.Drawing.Point(153, 344);
			this.cbx_Quan.Name = "cbx_Quan";
			this.cbx_Quan.Size = new System.Drawing.Size(121, 21);
			this.cbx_Quan.TabIndex = 27;
			// 
			// rNam
			// 
			this.rNam.AutoSize = true;
			this.rNam.Location = new System.Drawing.Point(153, 128);
			this.rNam.Name = "rNam";
			this.rNam.Size = new System.Drawing.Size(47, 17);
			this.rNam.TabIndex = 28;
			this.rNam.TabStop = true;
			this.rNam.Text = "Nam";
			this.rNam.UseVisualStyleBackColor = true;
			// 
			// rNu
			// 
			this.rNu.AutoSize = true;
			this.rNu.Location = new System.Drawing.Point(217, 128);
			this.rNu.Name = "rNu";
			this.rNu.Size = new System.Drawing.Size(39, 17);
			this.rNu.TabIndex = 29;
			this.rNu.TabStop = true;
			this.rNu.Text = "Nữ";
			this.rNu.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(336, 30);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(424, 355);
			this.dataGridView1.TabIndex = 30;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick_2);
			// 
			// btnSua
			// 
			this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSua.Location = new System.Drawing.Point(451, 419);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(82, 39);
			this.btnSua.TabIndex = 31;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = true;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(678, 419);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(82, 39);
			this.button1.TabIndex = 32;
			this.button1.Text = "Quay Lại";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// AddShipper
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(781, 470);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnSua);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.rNu);
			this.Controls.Add(this.rNam);
			this.Controls.Add(this.cbx_Quan);
			this.Controls.Add(this.btn_reset);
			this.Controls.Add(this.btn_add);
			this.Controls.Add(this.cbx_City);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txt_mail);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txt_birthday);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txt_sdt);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.Phái);
			this.Controls.Add(this.txt_tenShipper);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txt_maShipper);
			this.Controls.Add(this.label2);
			this.MinimumSize = new System.Drawing.Size(797, 509);
			this.Name = "AddShipper";
			this.Text = "AddShipper";
			this.Load += new System.EventHandler(this.AddShipper_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox txt_maShipper;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_tenShipper;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label Phái;
		private System.Windows.Forms.TextBox txt_sdt;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txt_birthday;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txt_mail;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cbx_City;
		private System.Windows.Forms.Button btn_add;
		private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.ComboBox cbx_Quan;
		private System.Windows.Forms.RadioButton rNam;
		private System.Windows.Forms.RadioButton rNu;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button button1;
	}
}