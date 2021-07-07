
namespace VK_API
{
    partial class Start_form
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.token = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.group_ID = new System.Windows.Forms.TextBox();
            this.radioButton_user = new System.Windows.Forms.RadioButton();
            this.radioButton_group = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(153, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "VK API TOOL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(168, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Токен";
            // 
            // token
            // 
            this.token.Location = new System.Drawing.Point(172, 115);
            this.token.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.token.Name = "token";
            this.token.Size = new System.Drawing.Size(282, 20);
            this.token.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(170, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID группы";
            // 
            // group_ID
            // 
            this.group_ID.Location = new System.Drawing.Point(172, 167);
            this.group_ID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.group_ID.Name = "group_ID";
            this.group_ID.Size = new System.Drawing.Size(282, 20);
            this.group_ID.TabIndex = 4;
            // 
            // radioButton_user
            // 
            this.radioButton_user.AutoSize = true;
            this.radioButton_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioButton_user.ForeColor = System.Drawing.Color.White;
            this.radioButton_user.Location = new System.Drawing.Point(21, 132);
            this.radioButton_user.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton_user.Name = "radioButton_user";
            this.radioButton_user.Size = new System.Drawing.Size(139, 24);
            this.radioButton_user.TabIndex = 5;
            this.radioButton_user.TabStop = true;
            this.radioButton_user.Text = "Пользователь";
            this.radioButton_user.UseVisualStyleBackColor = true;
            this.radioButton_user.CheckedChanged += new System.EventHandler(this.Type_CheckedChanged);
            // 
            // radioButton_group
            // 
            this.radioButton_group.AutoSize = true;
            this.radioButton_group.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.radioButton_group.ForeColor = System.Drawing.Color.White;
            this.radioButton_group.Location = new System.Drawing.Point(21, 157);
            this.radioButton_group.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton_group.Name = "radioButton_group";
            this.radioButton_group.Size = new System.Drawing.Size(79, 24);
            this.radioButton_group.TabIndex = 6;
            this.radioButton_group.TabStop = true;
            this.radioButton_group.Text = "Группа";
            this.radioButton_group.UseVisualStyleBackColor = true;
            this.radioButton_group.CheckedChanged += new System.EventHandler(this.Type_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(172, 203);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(280, 34);
            this.button1.TabIndex = 7;
            this.button1.Text = "Поздравить подписчиков с днем рождения";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(172, 242);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(280, 35);
            this.button2.TabIndex = 8;
            this.button2.Text = "Узнать возраст";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(172, 282);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(280, 35);
            this.button3.TabIndex = 9;
            this.button3.Text = "Информация о друзьях";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Start_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton_group);
            this.Controls.Add(this.radioButton_user);
            this.Controls.Add(this.group_ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.token);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Start_form";
            this.Load += new System.EventHandler(this.Start_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox token;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox group_ID;
        private System.Windows.Forms.RadioButton radioButton_user;
        private System.Windows.Forms.RadioButton radioButton_group;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

