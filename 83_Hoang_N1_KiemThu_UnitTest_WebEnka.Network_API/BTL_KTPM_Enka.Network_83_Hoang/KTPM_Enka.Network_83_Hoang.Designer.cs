namespace BTL_KTPM_Enka.Network_83_Hoang
{
    partial class KTPM_Enka_83_Hoang
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
            this.btn_Test_TimKiem_83_Hoang = new System.Windows.Forms.Button();
            this.btn_Test_DangNhap_83_Hoang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Test_TimKiem_83_Hoang
            // 
            this.btn_Test_TimKiem_83_Hoang.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Test_TimKiem_83_Hoang.Location = new System.Drawing.Point(39, 40);
            this.btn_Test_TimKiem_83_Hoang.Name = "btn_Test_TimKiem_83_Hoang";
            this.btn_Test_TimKiem_83_Hoang.Size = new System.Drawing.Size(544, 46);
            this.btn_Test_TimKiem_83_Hoang.TabIndex = 0;
            this.btn_Test_TimKiem_83_Hoang.Text = "Kiểm thử chức năng tìm kiếm (83_Hoang)";
            this.btn_Test_TimKiem_83_Hoang.UseVisualStyleBackColor = true;
            this.btn_Test_TimKiem_83_Hoang.Click += new System.EventHandler(this.btn_Test_TimKiem_83_Hoang_Click);
            // 
            // btn_Test_DangNhap_83_Hoang
            // 
            this.btn_Test_DangNhap_83_Hoang.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Test_DangNhap_83_Hoang.Location = new System.Drawing.Point(39, 136);
            this.btn_Test_DangNhap_83_Hoang.Name = "btn_Test_DangNhap_83_Hoang";
            this.btn_Test_DangNhap_83_Hoang.Size = new System.Drawing.Size(544, 46);
            this.btn_Test_DangNhap_83_Hoang.TabIndex = 1;
            this.btn_Test_DangNhap_83_Hoang.Text = "Kiểm thử chức năng đăng nhập (83_Hoang)";
            this.btn_Test_DangNhap_83_Hoang.UseVisualStyleBackColor = true;
            this.btn_Test_DangNhap_83_Hoang.Click += new System.EventHandler(this.btn_Test_DangNhap_83_Hoang_Click);
            // 
            // KTPM_Enka_83_Hoang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 229);
            this.Controls.Add(this.btn_Test_DangNhap_83_Hoang);
            this.Controls.Add(this.btn_Test_TimKiem_83_Hoang);
            this.Name = "KTPM_Enka_83_Hoang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Test_TimKiem_83_Hoang;
        private System.Windows.Forms.Button btn_Test_DangNhap_83_Hoang;
    }
}

