namespace lap2_21521327_GiaQUan
{
    partial class bai3
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
            this.bt_chon = new System.Windows.Forms.Button();
            this.rtb_keuqua = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // bt_chon
            // 
            this.bt_chon.Location = new System.Drawing.Point(72, 217);
            this.bt_chon.Name = "bt_chon";
            this.bt_chon.Size = new System.Drawing.Size(126, 45);
            this.bt_chon.TabIndex = 5;
            this.bt_chon.Text = "Chọn File ";
            this.bt_chon.UseVisualStyleBackColor = true;
            this.bt_chon.Click += new System.EventHandler(this.bt_chon_Click);
            // 
            // rtb_keuqua
            // 
            this.rtb_keuqua.Location = new System.Drawing.Point(305, 105);
            this.rtb_keuqua.Name = "rtb_keuqua";
            this.rtb_keuqua.Size = new System.Drawing.Size(452, 306);
            this.rtb_keuqua.TabIndex = 6;
            this.rtb_keuqua.Text = "";
            // 
            // bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtb_keuqua);
            this.Controls.Add(this.bt_chon);
            this.Name = "bai3";
            this.Text = "bai3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_chon;
        private System.Windows.Forms.RichTextBox rtb_keuqua;
    }
}