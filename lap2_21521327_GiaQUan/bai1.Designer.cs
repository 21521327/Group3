namespace lap2_21521327_GiaQUan
{
    partial class bai1
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
            this.rtb_mess = new System.Windows.Forms.RichTextBox();
            this.bt_read = new System.Windows.Forms.Button();
            this.bt_write = new System.Windows.Forms.Button();
            this.bt_chuyen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtb_mess
            // 
            this.rtb_mess.Location = new System.Drawing.Point(189, 47);
            this.rtb_mess.Name = "rtb_mess";
            this.rtb_mess.Size = new System.Drawing.Size(362, 207);
            this.rtb_mess.TabIndex = 3;
            this.rtb_mess.Text = "";
            // 
            // bt_read
            // 
            this.bt_read.Location = new System.Drawing.Point(96, 318);
            this.bt_read.Name = "bt_read";
            this.bt_read.Size = new System.Drawing.Size(126, 45);
            this.bt_read.TabIndex = 4;
            this.bt_read.Text = "Read File";
            this.bt_read.UseVisualStyleBackColor = true;
            this.bt_read.Click += new System.EventHandler(this.bt_read_Click);
            // 
            // bt_write
            // 
            this.bt_write.Location = new System.Drawing.Point(506, 318);
            this.bt_write.Name = "bt_write";
            this.bt_write.Size = new System.Drawing.Size(126, 45);
            this.bt_write.TabIndex = 5;
            this.bt_write.Text = "Write File";
            this.bt_write.UseVisualStyleBackColor = true;
            this.bt_write.Click += new System.EventHandler(this.bt_write_Click);
            // 
            // bt_chuyen
            // 
            this.bt_chuyen.Location = new System.Drawing.Point(303, 318);
            this.bt_chuyen.Name = "bt_chuyen";
            this.bt_chuyen.Size = new System.Drawing.Size(126, 45);
            this.bt_chuyen.TabIndex = 6;
            this.bt_chuyen.Text = "Change";
            this.bt_chuyen.UseVisualStyleBackColor = true;
            this.bt_chuyen.Click += new System.EventHandler(this.bt_chuyen_Click);
            // 
            // bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_chuyen);
            this.Controls.Add(this.bt_write);
            this.Controls.Add(this.bt_read);
            this.Controls.Add(this.rtb_mess);
            this.Name = "bai1";
            this.Text = "bai1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_mess;
        private System.Windows.Forms.Button bt_read;
        private System.Windows.Forms.Button bt_write;
        private System.Windows.Forms.Button bt_chuyen;
    }
}