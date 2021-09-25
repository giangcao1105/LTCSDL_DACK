
namespace GUI_demo
{
    partial class FChamCongNV
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
            this.btChamCong = new System.Windows.Forms.Button();
            this.btKtCa = new System.Windows.Forms.Button();
            this.lbChamCong = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btChamCong
            // 
            this.btChamCong.Location = new System.Drawing.Point(75, 44);
            this.btChamCong.Name = "btChamCong";
            this.btChamCong.Size = new System.Drawing.Size(157, 68);
            this.btChamCong.TabIndex = 0;
            this.btChamCong.Text = "Chấm công";
            this.btChamCong.UseVisualStyleBackColor = true;
            this.btChamCong.Click += new System.EventHandler(this.btChamCong_Click);
            // 
            // btKtCa
            // 
            this.btKtCa.Location = new System.Drawing.Point(361, 44);
            this.btKtCa.Name = "btKtCa";
            this.btKtCa.Size = new System.Drawing.Size(157, 68);
            this.btKtCa.TabIndex = 1;
            this.btKtCa.Text = "Kết thúc ca làm";
            this.btKtCa.UseVisualStyleBackColor = true;
            this.btKtCa.Click += new System.EventHandler(this.btKtCa_Click);
            // 
            // lbChamCong
            // 
            this.lbChamCong.AutoSize = true;
            this.lbChamCong.Location = new System.Drawing.Point(175, 146);
            this.lbChamCong.Name = "lbChamCong";
            this.lbChamCong.Size = new System.Drawing.Size(0, 17);
            this.lbChamCong.TabIndex = 2;
            // 
            // FChamCongNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 245);
            this.Controls.Add(this.lbChamCong);
            this.Controls.Add(this.btKtCa);
            this.Controls.Add(this.btChamCong);
            this.Name = "FChamCongNV";
            this.Text = "FChamCongNV";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btChamCong;
        private System.Windows.Forms.Button btKtCa;
        private System.Windows.Forms.Label lbChamCong;
    }
}