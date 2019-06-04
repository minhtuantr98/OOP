namespace QuanLyShipper
{
	partial class GanShipper
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
			this.cbx_maDH = new System.Windows.Forms.ComboBox();
			this.cbx_maShipper = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txt_khuVuc = new System.Windows.Forms.TextBox();
			this.btn_xacNhan = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(319, 69);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(221, 34);
			this.label1.TabIndex = 2;
			this.label1.Text = "Gán Đơn Hàng";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(287, 178);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(98, 17);
			this.label2.TabIndex = 8;
			this.label2.Text = "Mã Đơn Hàng";
			// 
			// cbx_maDH
			// 
			this.cbx_maDH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbx_maDH.FormattingEnabled = true;
			this.cbx_maDH.Location = new System.Drawing.Point(434, 178);
			this.cbx_maDH.Name = "cbx_maDH";
			this.cbx_maDH.Size = new System.Drawing.Size(121, 21);
			this.cbx_maDH.TabIndex = 9;
			// 
			// cbx_maShipper
			// 
			this.cbx_maShipper.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbx_maShipper.FormattingEnabled = true;
			this.cbx_maShipper.Location = new System.Drawing.Point(434, 269);
			this.cbx_maShipper.Name = "cbx_maShipper";
			this.cbx_maShipper.Size = new System.Drawing.Size(121, 21);
			this.cbx_maShipper.TabIndex = 11;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(287, 269);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(81, 17);
			this.label3.TabIndex = 10;
			this.label3.Text = "Mã Shipper";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(287, 225);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(65, 17);
			this.label5.TabIndex = 27;
			this.label5.Text = "Khu Vực";
			// 
			// txt_khuVuc
			// 
			this.txt_khuVuc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txt_khuVuc.Location = new System.Drawing.Point(434, 225);
			this.txt_khuVuc.Name = "txt_khuVuc";
			this.txt_khuVuc.Size = new System.Drawing.Size(121, 20);
			this.txt_khuVuc.TabIndex = 28;
			// 
			// btn_xacNhan
			// 
			this.btn_xacNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_xacNhan.Location = new System.Drawing.Point(473, 334);
			this.btn_xacNhan.Name = "btn_xacNhan";
			this.btn_xacNhan.Size = new System.Drawing.Size(82, 39);
			this.btn_xacNhan.TabIndex = 29;
			this.btn_xacNhan.Text = "Xác Nhận";
			this.btn_xacNhan.UseVisualStyleBackColor = true;
			// 
			// GanShipper
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(781, 470);
			this.Controls.Add(this.btn_xacNhan);
			this.Controls.Add(this.txt_khuVuc);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.cbx_maShipper);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cbx_maDH);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MinimumSize = new System.Drawing.Size(797, 509);
			this.Name = "GanShipper";
			this.Text = "GanShipper";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbx_maDH;
		private System.Windows.Forms.ComboBox cbx_maShipper;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txt_khuVuc;
		private System.Windows.Forms.Button btn_xacNhan;
	}
}