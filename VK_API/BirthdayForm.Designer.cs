
namespace VK_API
{
    partial class BirthdayForm
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
            this.users_listbox = new System.Windows.Forms.ListBox();
            this.photo = new System.Windows.Forms.PictureBox();
            this.copy_link = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.send = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).BeginInit();
            this.SuspendLayout();
            // 
            // users_listbox
            // 
            this.users_listbox.FormattingEnabled = true;
            this.users_listbox.Location = new System.Drawing.Point(12, 21);
            this.users_listbox.Name = "users_listbox";
            this.users_listbox.Size = new System.Drawing.Size(120, 225);
            this.users_listbox.TabIndex = 0;
            this.users_listbox.SelectedIndexChanged += new System.EventHandler(this.users_listbox_SelectedIndexChanged);
            // 
            // photo
            // 
            this.photo.Location = new System.Drawing.Point(159, 46);
            this.photo.Name = "photo";
            this.photo.Size = new System.Drawing.Size(200, 200);
            this.photo.TabIndex = 1;
            this.photo.TabStop = false;
            // 
            // copy_link
            // 
            this.copy_link.Location = new System.Drawing.Point(188, 17);
            this.copy_link.Name = "copy_link";
            this.copy_link.Size = new System.Drawing.Size(147, 23);
            this.copy_link.TabIndex = 2;
            this.copy_link.Text = "Копировать ссылку";
            this.copy_link.UseVisualStyleBackColor = true;
            this.copy_link.Click += new System.EventHandler(this.copy_link_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(383, 21);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 90);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Привет. Я не знаю кто ты, но с днём рождения :D";
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(468, 136);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(90, 35);
            this.send.TabIndex = 4;
            this.send.Text = "Отправить";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // BirthdayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(675, 267);
            this.Controls.Add(this.send);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.copy_link);
            this.Controls.Add(this.photo);
            this.Controls.Add(this.users_listbox);
            this.Name = "BirthdayForm";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox users_listbox;
        private System.Windows.Forms.PictureBox photo;
        private System.Windows.Forms.Button copy_link;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button send;
    }
}