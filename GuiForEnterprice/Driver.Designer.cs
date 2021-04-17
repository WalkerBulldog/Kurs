namespace GuiForEnterprice
{
    partial class FormDriver
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.FullInfoLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.WBgridView = new System.Windows.Forms.DataGridView();
            this.enterpriceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.WaybillsDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.WBgridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterpriceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Статус: ";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(79, 26);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 17);
            this.StatusLabel.TabIndex = 1;
            // 
            // FullInfoLabel
            // 
            this.FullInfoLabel.AutoSize = true;
            this.FullInfoLabel.Location = new System.Drawing.Point(40, 67);
            this.FullInfoLabel.Name = "FullInfoLabel";
            this.FullInfoLabel.Size = new System.Drawing.Size(0, 17);
            this.FullInfoLabel.TabIndex = 2;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(43, 406);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Выйти";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(224, 406);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(82, 23);
            this.UpdateButton.TabIndex = 5;
            this.UpdateButton.Text = "Обновить";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // WBgridView
            // 
            this.WBgridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WBgridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.WaybillsDG});
            this.WBgridView.Enabled = false;
            this.WBgridView.Location = new System.Drawing.Point(330, 46);
            this.WBgridView.Name = "WBgridView";
            this.WBgridView.RowHeadersWidth = 51;
            this.WBgridView.RowTemplate.Height = 24;
            this.WBgridView.Size = new System.Drawing.Size(457, 350);
            this.WBgridView.TabIndex = 6;
            // 
            // enterpriceBindingSource
            // 
            this.enterpriceBindingSource.DataSource = typeof(AllAccounting.Enterprice);
            // 
            // WaybillsDG
            // 
            this.WaybillsDG.HeaderText = "Путевые листы";
            this.WaybillsDG.MinimumWidth = 6;
            this.WaybillsDG.Name = "WaybillsDG";
            this.WaybillsDG.Width = 400;
            // 
            // FormDriver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.WBgridView);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.FullInfoLabel);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.label1);
            this.Name = "FormDriver";
            this.Text = "Driver";
            ((System.ComponentModel.ISupportInitialize)(this.WBgridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enterpriceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label FullInfoLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.DataGridView WBgridView;
        private System.Windows.Forms.BindingSource enterpriceBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn WaybillsDG;
    }
}