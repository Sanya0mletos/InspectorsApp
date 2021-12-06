
namespace InspectorsApp.Forms
{
    partial class LoginForm
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
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Enter_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(65, 79);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(171, 20);
            this.PasswordBox.TabIndex = 14;
            // 
            // LoginBox
            // 
            this.LoginBox.Location = new System.Drawing.Point(65, 21);
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(171, 20);
            this.LoginBox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Пароль";
            // 
            // Enter_Button
            // 
            this.Enter_Button.Location = new System.Drawing.Point(91, 160);
            this.Enter_Button.Name = "Enter_Button";
            this.Enter_Button.Size = new System.Drawing.Size(75, 23);
            this.Enter_Button.TabIndex = 11;
            this.Enter_Button.Text = "Войти";
            this.Enter_Button.UseVisualStyleBackColor = true;
            this.Enter_Button.Click += new System.EventHandler(this.Enter_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Логин";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(213)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(261, 205);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.LoginBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Enter_Button);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(277, 244);
            this.MinimumSize = new System.Drawing.Size(277, 244);
            this.Name = "LoginForm";
            this.Text = "Окно авторизации";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Enter_Button;
        private System.Windows.Forms.Label label1;
    }
}

