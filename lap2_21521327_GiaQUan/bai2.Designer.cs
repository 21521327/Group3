namespace lap2_21521327_GiaQUan
{
    partial class bai2
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
            this.bt_read = new System.Windows.Forms.Button();
            this.rtb_mess = new System.Windows.Forms.RichTextBox();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.txt_dong = new System.Windows.Forms.TextBox();
            this.txt_tu = new System.Windows.Forms.TextBox();
            this.txt_word = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_read
            // 
            this.bt_read.Location = new System.Drawing.Point(82, 68);
            this.bt_read.Name = "bt_read";
            this.bt_read.Size = new System.Drawing.Size(126, 45);
            this.bt_read.TabIndex = 1;
            this.bt_read.Text = "Read File";
            this.bt_read.UseVisualStyleBackColor = true;
            this.bt_read.Click += new System.EventHandler(this.bt_read_Click);
            // 
            // rtb_mess
            // 
            this.rtb_mess.Location = new System.Drawing.Point(338, 119);
            this.rtb_mess.Name = "rtb_mess";
            this.rtb_mess.Size = new System.Drawing.Size(368, 283);
            this.rtb_mess.TabIndex = 8;
            this.rtb_mess.Text = "";
            // 
            // txt_url
            // 
            this.txt_url.Location = new System.Drawing.Point(87, 205);
            this.txt_url.Multiline = true;
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(121, 36);
            this.txt_url.TabIndex = 13;
            this.txt_url.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_dong
            // 
            this.txt_dong.Location = new System.Drawing.Point(87, 267);
            this.txt_dong.Multiline = true;
            this.txt_dong.Name = "txt_dong";
            this.txt_dong.Size = new System.Drawing.Size(121, 36);
            this.txt_dong.TabIndex = 12;
            this.txt_dong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_tu
            // 
            this.txt_tu.Location = new System.Drawing.Point(87, 329);
            this.txt_tu.Multiline = true;
            this.txt_tu.Name = "txt_tu";
            this.txt_tu.Size = new System.Drawing.Size(121, 36);
            this.txt_tu.TabIndex = 11;
            this.txt_tu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_word
            // 
            this.txt_word.Location = new System.Drawing.Point(87, 389);
            this.txt_word.Multiline = true;
            this.txt_word.Name = "txt_word";
            this.txt_word.Size = new System.Drawing.Size(121, 36);
            this.txt_word.TabIndex = 10;
            this.txt_word.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(87, 140);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(121, 36);
            this.txt_name.TabIndex = 9;
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_url);
            this.Controls.Add(this.txt_dong);
            this.Controls.Add(this.txt_tu);
            this.Controls.Add(this.txt_word);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.rtb_mess);
            this.Controls.Add(this.bt_read);
            this.Name = "bai2";
            this.Text = "bai2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_read;
        private System.Windows.Forms.RichTextBox rtb_mess;
        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.TextBox txt_dong;
        private System.Windows.Forms.TextBox txt_tu;
        private System.Windows.Forms.TextBox txt_word;
        private System.Windows.Forms.TextBox txt_name;
    }
}