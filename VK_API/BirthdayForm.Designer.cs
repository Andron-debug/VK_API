
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
            this.Message_checkBox = new System.Windows.Forms.CheckBox();
            this.Post_checkBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).BeginInit();
            this.SuspendLayout();
            // 
            // users_listbox
            // 
            this.users_listbox.FormattingEnabled = true;
            this.users_listbox.ItemHeight = 16;
            this.users_listbox.Location = new System.Drawing.Point(16, 26);
            this.users_listbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.users_listbox.Name = "users_listbox";
            this.users_listbox.Size = new System.Drawing.Size(159, 276);
            this.users_listbox.TabIndex = 0;
            this.users_listbox.SelectedIndexChanged += new System.EventHandler(this.users_listbox_SelectedIndexChanged);
            // 
            // photo
            // 
            this.photo.Location = new System.Drawing.Point(212, 57);
            this.photo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.photo.Name = "photo";
            this.photo.Size = new System.Drawing.Size(267, 246);
            this.photo.TabIndex = 1;
            this.photo.TabStop = false;
            // 
            // copy_link
            // 
            this.copy_link.Location = new System.Drawing.Point(251, 21);
            this.copy_link.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.copy_link.Name = "copy_link";
            this.copy_link.Size = new System.Drawing.Size(196, 28);
            this.copy_link.TabIndex = 2;
            this.copy_link.Text = "Копировать ссылку";
            this.copy_link.UseVisualStyleBackColor = true;
            this.copy_link.Click += new System.EventHandler(this.copy_link_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(511, 26);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(344, 110);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Выберете пользователя";
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(624, 161);
            this.send.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(120, 43);
            this.send.TabIndex = 4;
            this.send.Text = "Отправить";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // Message_checkBox
            // 
            this.Message_checkBox.AutoSize = true;
            this.Message_checkBox.ForeColor = System.Drawing.Color.White;
            this.Message_checkBox.Location = new System.Drawing.Point(522, 220);
            this.Message_checkBox.Name = "Message_checkBox";
            this.Message_checkBox.Size = new System.Drawing.Size(179, 21);
            this.Message_checkBox.TabIndex = 5;
            this.Message_checkBox.Text = "Отправить сообщение";
            this.Message_checkBox.UseVisualStyleBackColor = true;
            // 
            // Post_checkBox
            // 
            this.Post_checkBox.AutoSize = true;
            this.Post_checkBox.ForeColor = System.Drawing.Color.White;
            this.Post_checkBox.Location = new System.Drawing.Point(522, 247);
            this.Post_checkBox.Name = "Post_checkBox";
            this.Post_checkBox.Size = new System.Drawing.Size(127, 21);
            this.Post_checkBox.TabIndex = 6;
            this.Post_checkBox.Text = "Написать пост";
            this.Post_checkBox.UseVisualStyleBackColor = true;
            // 
            // BirthdayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(900, 329);
            this.Controls.Add(this.Post_checkBox);
            this.Controls.Add(this.Message_checkBox);
            this.Controls.Add(this.send);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.copy_link);
            this.Controls.Add(this.photo);
            this.Controls.Add(this.users_listbox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.CheckBox Message_checkBox;
        private System.Windows.Forms.CheckBox Post_checkBox;
    }
}