
namespace BAI10_CLIENT_TCP_QL_CHUC_VU
{
    partial class frmKetNoi
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
            this.btn_batdau = new System.Windows.Forms.Button();
            this.txt_IP_Client = new System.Windows.Forms.TextBox();
            this.txt_IP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_batdau
            // 
            this.btn_batdau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_batdau.Location = new System.Drawing.Point(91, 93);
            this.btn_batdau.Name = "btn_batdau";
            this.btn_batdau.Size = new System.Drawing.Size(75, 32);
            this.btn_batdau.TabIndex = 22;
            this.btn_batdau.Text = "Bắt đầu";
            this.btn_batdau.UseVisualStyleBackColor = true;
            this.btn_batdau.Click += new System.EventHandler(this.btn_batdau_Click);
            // 
            // txt_IP_Client
            // 
            this.txt_IP_Client.Enabled = false;
            this.txt_IP_Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IP_Client.Location = new System.Drawing.Point(91, 12);
            this.txt_IP_Client.Name = "txt_IP_Client";
            this.txt_IP_Client.Size = new System.Drawing.Size(155, 23);
            this.txt_IP_Client.TabIndex = 20;
            // 
            // txt_IP
            // 
            this.txt_IP.Enabled = false;
            this.txt_IP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IP.Location = new System.Drawing.Point(91, 50);
            this.txt_IP.Name = "txt_IP";
            this.txt_IP.Size = new System.Drawing.Size(155, 23);
            this.txt_IP.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "IP Client:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(7, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "IP server:";
            // 
            // frmKetNoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 145);
            this.Controls.Add(this.btn_batdau);
            this.Controls.Add(this.txt_IP_Client);
            this.Controls.Add(this.txt_IP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frmKetNoi";
            this.Text = "frmKetNoi";
            this.Load += new System.EventHandler(this.frmKetNoi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_batdau;
        private System.Windows.Forms.TextBox txt_IP_Client;
        private System.Windows.Forms.TextBox txt_IP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}