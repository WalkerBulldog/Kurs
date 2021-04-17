namespace GuiForEnterprice
{
    partial class EntryForm
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
            this.LoginText = new System.Windows.Forms.TextBox();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.EntryButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ErrorMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ВХОД";
            // 
            // LoginText
            // 
            this.LoginText.Location = new System.Drawing.Point(257, 118);
            this.LoginText.Name = "LoginText";
            this.LoginText.Size = new System.Drawing.Size(193, 22);
            this.LoginText.TabIndex = 1;
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(257, 209);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(193, 22);
            this.PasswordText.TabIndex = 2;
            // 
            // EntryButton
            // 
            this.EntryButton.Location = new System.Drawing.Point(302, 349);
            this.EntryButton.Name = "EntryButton";
            this.EntryButton.Size = new System.Drawing.Size(75, 23);
            this.EntryButton.TabIndex = 3;
            this.EntryButton.Text = "войти";
            this.EntryButton.UseVisualStyleBackColor = true;
            this.EntryButton.Click += new System.EventHandler(this.EntryButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Логин:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Пароль:";
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.AutoSize = true;
            this.ErrorMessage.Location = new System.Drawing.Point(189, 287);
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.Size = new System.Drawing.Size(355, 17);
            this.ErrorMessage.TabIndex = 6;
            this.ErrorMessage.Text = "Ошибка входа! Введите правильный логин и пароль!";
            this.ErrorMessage.Visible = false;
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ErrorMessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EntryButton);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.LoginText);
            this.Controls.Add(this.label1);
            this.Name = "EntryForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LoginText;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.Button EntryButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ErrorMessage;
    }
}

