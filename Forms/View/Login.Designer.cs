namespace QuanLyShipper
{
	partial class fLogin
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
			this.label3 = new System.Windows.Forms.Label();
			this.login_tk = new System.Windows.Forms.TextBox();
			this.login_mk = new System.Windows.Forms.TextBox();
			this.login_btn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(323, 73);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(169, 34);
			this.label1.TabIndex = 0;
			this.label1.Text = "Đăng Nhập";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(103, 186);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(121, 27);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tài Khoản";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(103, 253);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(115, 27);
			this.label3.TabIndex = 2;
			this.label3.Text = "Mật Khẩu";
			// 
			// login_tk
			// 
			this.login_tk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.login_tk.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.login_tk.Location = new System.Drawing.Point(282, 186);
			this.login_tk.Multiline = true;
			this.login_tk.Name = "login_tk";
			this.login_tk.Size = new System.Drawing.Size(332, 30);
			this.login_tk.TabIndex = 3;
			// 
			// login_mk
			// 
			this.login_mk.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.login_mk.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.login_mk.Location = new System.Drawing.Point(282, 253);
			this.login_mk.Multiline = true;
			this.login_mk.Name = "login_mk";
			this.login_mk.PasswordChar = '*';
			this.login_mk.Size = new System.Drawing.Size(332, 33);
			this.login_mk.TabIndex = 4;
			this.login_mk.UseSystemPasswordChar = true;
			// 
			// login_btn
			// 
			this.login_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.login_btn.Location = new System.Drawing.Point(506, 322);
			this.login_btn.Name = "login_btn";
			this.login_btn.Size = new System.Drawing.Size(108, 42);
			this.login_btn.TabIndex = 5;
			this.login_btn.Text = "Đăng Nhập";
			this.login_btn.UseVisualStyleBackColor = true;
			this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
			// 
			// fLogin
			// 
			this.AcceptButton = this.login_btn;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(781, 470);
			this.Controls.Add(this.login_btn);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.login_tk);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.login_mk);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "fLogin";
			this.Text = "Login";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox login_tk;
		private System.Windows.Forms.TextBox login_mk;
		private System.Windows.Forms.Button login_btn;
	}
}

