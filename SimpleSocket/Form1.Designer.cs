namespace SimpleSocket
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.chk_Remort_AutoConnect = new System.Windows.Forms.CheckBox();
            this.txt_Self_IpAddress = new System.Windows.Forms.TextBox();
            this.txt_Remort_IpAddress = new System.Windows.Forms.TextBox();
            this.txt_Remort_PortNo = new System.Windows.Forms.TextBox();
            this.chk_Self_AutoConnect = new System.Windows.Forms.CheckBox();
            this.txt_Self_PortNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Remote_Status = new System.Windows.Forms.Label();
            this.lbl_Self_Status = new System.Windows.Forms.Label();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chk_Remort_AutoConnect
            // 
            this.chk_Remort_AutoConnect.AutoSize = true;
            this.chk_Remort_AutoConnect.Font = new System.Drawing.Font("MS UI Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.chk_Remort_AutoConnect.Location = new System.Drawing.Point(230, 77);
            this.chk_Remort_AutoConnect.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.chk_Remort_AutoConnect.Name = "chk_Remort_AutoConnect";
            this.chk_Remort_AutoConnect.Size = new System.Drawing.Size(46, 15);
            this.chk_Remort_AutoConnect.TabIndex = 26;
            this.chk_Remort_AutoConnect.Text = "接続";
            this.chk_Remort_AutoConnect.UseVisualStyleBackColor = true;
            this.chk_Remort_AutoConnect.CheckedChanged += new System.EventHandler(this.chk_Remote_AutoConnect_CheckedChanged);
            // 
            // txt_Self_IpAddress
            // 
            this.txt_Self_IpAddress.Location = new System.Drawing.Point(9, 31);
            this.txt_Self_IpAddress.Name = "txt_Self_IpAddress";
            this.txt_Self_IpAddress.Size = new System.Drawing.Size(100, 19);
            this.txt_Self_IpAddress.TabIndex = 22;
            // 
            // txt_Remort_IpAddress
            // 
            this.txt_Remort_IpAddress.Location = new System.Drawing.Point(9, 77);
            this.txt_Remort_IpAddress.Name = "txt_Remort_IpAddress";
            this.txt_Remort_IpAddress.Size = new System.Drawing.Size(100, 19);
            this.txt_Remort_IpAddress.TabIndex = 24;
            // 
            // txt_Remort_PortNo
            // 
            this.txt_Remort_PortNo.Location = new System.Drawing.Point(113, 77);
            this.txt_Remort_PortNo.Name = "txt_Remort_PortNo";
            this.txt_Remort_PortNo.Size = new System.Drawing.Size(62, 19);
            this.txt_Remort_PortNo.TabIndex = 23;
            // 
            // chk_Self_AutoConnect
            // 
            this.chk_Self_AutoConnect.AutoSize = true;
            this.chk_Self_AutoConnect.Font = new System.Drawing.Font("ＭＳ ゴシック", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.chk_Self_AutoConnect.Location = new System.Drawing.Point(230, 31);
            this.chk_Self_AutoConnect.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.chk_Self_AutoConnect.Name = "chk_Self_AutoConnect";
            this.chk_Self_AutoConnect.Size = new System.Drawing.Size(48, 15);
            this.chk_Self_AutoConnect.TabIndex = 25;
            this.chk_Self_AutoConnect.Text = "接続";
            this.chk_Self_AutoConnect.UseVisualStyleBackColor = true;
            this.chk_Self_AutoConnect.CheckedChanged += new System.EventHandler(this.chk_Self_AutoConnect_CheckedChanged);
            // 
            // txt_Self_PortNo
            // 
            this.txt_Self_PortNo.Location = new System.Drawing.Point(113, 31);
            this.txt_Self_PortNo.Name = "txt_Self_PortNo";
            this.txt_Self_PortNo.Size = new System.Drawing.Size(62, 19);
            this.txt_Self_PortNo.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(10, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 11);
            this.label4.TabIndex = 33;
            this.label4.Text = "受信側";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(10, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 11);
            this.label3.TabIndex = 32;
            this.label3.Text = "送信側";
            // 
            // lbl_Remote_Status
            // 
            this.lbl_Remote_Status.AutoSize = true;
            this.lbl_Remote_Status.Font = new System.Drawing.Font("MS UI Gothic", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_Remote_Status.Location = new System.Drawing.Point(179, 81);
            this.lbl_Remote_Status.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_Remote_Status.Name = "lbl_Remote_Status";
            this.lbl_Remote_Status.Size = new System.Drawing.Size(27, 11);
            this.lbl_Remote_Status.TabIndex = 31;
            this.lbl_Remote_Status.Text = "切断";
            // 
            // lbl_Self_Status
            // 
            this.lbl_Self_Status.AutoSize = true;
            this.lbl_Self_Status.Font = new System.Drawing.Font("MS UI Gothic", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_Self_Status.Location = new System.Drawing.Point(179, 35);
            this.lbl_Self_Status.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbl_Self_Status.Name = "lbl_Self_Status";
            this.lbl_Self_Status.Size = new System.Drawing.Size(27, 11);
            this.lbl_Self_Status.TabIndex = 30;
            this.lbl_Self_Status.Text = "切断";
            // 
            // richTextBox
            // 
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.Location = new System.Drawing.Point(0, 107);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(306, 100);
            this.richTextBox.TabIndex = 34;
            this.richTextBox.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 107);
            this.panel1.TabIndex = 35;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(306, 207);
            this.panel2.TabIndex = 36;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 21);
            this.button1.TabIndex = 0;
            this.button1.Text = "send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 207);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_Remote_Status);
            this.Controls.Add(this.lbl_Self_Status);
            this.Controls.Add(this.chk_Remort_AutoConnect);
            this.Controls.Add(this.txt_Self_IpAddress);
            this.Controls.Add(this.txt_Remort_IpAddress);
            this.Controls.Add(this.txt_Remort_PortNo);
            this.Controls.Add(this.chk_Self_AutoConnect);
            this.Controls.Add(this.txt_Self_PortNo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chk_Remort_AutoConnect;
        private System.Windows.Forms.TextBox txt_Self_IpAddress;
        private System.Windows.Forms.TextBox txt_Remort_IpAddress;
        private System.Windows.Forms.TextBox txt_Remort_PortNo;
        private System.Windows.Forms.CheckBox chk_Self_AutoConnect;
        private System.Windows.Forms.TextBox txt_Self_PortNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Remote_Status;
        private System.Windows.Forms.Label lbl_Self_Status;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
    }
}

