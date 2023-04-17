namespace lap2_21521327_GiaQUan
{
    partial class bai5
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
            this.bt_file = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_file
            // 
            this.bt_file.Location = new System.Drawing.Point(300, 158);
            this.bt_file.Name = "bt_file";
            this.bt_file.Size = new System.Drawing.Size(143, 45);
            this.bt_file.TabIndex = 6;
            this.bt_file.Text = "Chọn tệp để nén";
            this.bt_file.UseVisualStyleBackColor = true;
            this.bt_file.Click += new System.EventHandler(this.bt_bai6_Click);
            // 
            // bai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_file);
            this.Name = "bai5";
            this.Text = "bai5";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_file;
    }
}