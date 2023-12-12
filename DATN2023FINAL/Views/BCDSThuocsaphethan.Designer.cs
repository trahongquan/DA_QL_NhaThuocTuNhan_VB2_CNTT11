namespace DATN2023FINAL.Views
{
    partial class BCDSThuocsaphethan
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTong = new System.Windows.Forms.Label();
            this.ckb30 = new System.Windows.Forms.CheckBox();
            this.ckb60 = new System.Windows.Forms.CheckBox();
            this.ckb90 = new System.Windows.Forms.CheckBox();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnXemBC = new DevExpress.XtraEditors.SimpleButton();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(465, 20);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "BÁO CÁO DANH SÁCH THUỐC SẮP HẾT HẠN SỬ DỤNG";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lbTong);
            this.panel2.Controls.Add(this.ckb30);
            this.panel2.Controls.Add(this.ckb60);
            this.panel2.Controls.Add(this.ckb90);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnXemBC);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(767, 248);
            this.panel2.TabIndex = 7;
            // 
            // lbTong
            // 
            this.lbTong.AutoSize = true;
            this.lbTong.Location = new System.Drawing.Point(700, 221);
            this.lbTong.Name = "lbTong";
            this.lbTong.Size = new System.Drawing.Size(0, 13);
            this.lbTong.TabIndex = 5;
            // 
            // ckb30
            // 
            this.ckb30.AutoSize = true;
            this.ckb30.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb30.Location = new System.Drawing.Point(538, 34);
            this.ckb30.Name = "ckb30";
            this.ckb30.Size = new System.Drawing.Size(70, 19);
            this.ckb30.TabIndex = 4;
            this.ckb30.Text = "30 Ngày";
            this.ckb30.UseVisualStyleBackColor = true;
            this.ckb30.CheckedChanged += new System.EventHandler(this.ckb30_CheckedChanged);
            // 
            // ckb60
            // 
            this.ckb60.AutoSize = true;
            this.ckb60.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb60.Location = new System.Drawing.Point(380, 34);
            this.ckb60.Name = "ckb60";
            this.ckb60.Size = new System.Drawing.Size(70, 19);
            this.ckb60.TabIndex = 4;
            this.ckb60.Text = "60 Ngày";
            this.ckb60.UseVisualStyleBackColor = true;
            this.ckb60.CheckedChanged += new System.EventHandler(this.ckb60_CheckedChanged);
            // 
            // ckb90
            // 
            this.ckb90.AutoSize = true;
            this.ckb90.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckb90.Location = new System.Drawing.Point(199, 34);
            this.ckb90.Name = "ckb90";
            this.ckb90.Size = new System.Drawing.Size(70, 19);
            this.ckb90.TabIndex = 4;
            this.ckb90.Text = "90 Ngày";
            this.ckb90.UseVisualStyleBackColor = true;
            this.ckb90.CheckedChanged += new System.EventHandler(this.ckb90_CheckedChanged);
            // 
            // btnExit
            // 
            this.btnExit.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.ImageOptions.Image = global::DATN2023FINAL.Properties.Resources.Exit;
            this.btnExit.Location = new System.Drawing.Point(465, 89);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnXemBC
            // 
            this.btnXemBC.Appearance.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemBC.Appearance.Options.UseFont = true;
            this.btnXemBC.ImageOptions.Image = global::DATN2023FINAL.Properties.Resources.Report;
            this.btnXemBC.Location = new System.Drawing.Point(246, 89);
            this.btnXemBC.Name = "btnXemBC";
            this.btnXemBC.Size = new System.Drawing.Size(131, 23);
            this.btnXemBC.TabIndex = 1;
            this.btnXemBC.Text = "Xem báo cáo";
            this.btnXemBC.Click += new System.EventHandler(this.btnXemBC_Click);
            // 
            // BCDSThuocsaphethan
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 268);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BCDSThuocsaphethan";
            this.Text = "BC DS THUỐC SẮP HH";
            this.Load += new System.EventHandler(this.BCDSThuocsaphethan_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnXemBC;
        private System.Windows.Forms.CheckBox ckb30;
        private System.Windows.Forms.CheckBox ckb60;
        private System.Windows.Forms.CheckBox ckb90;
        public System.Windows.Forms.Label lbTong;
    }
}