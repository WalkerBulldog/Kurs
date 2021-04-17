namespace GuiForEnterprice
{
    partial class AdminMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.UsersDG = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.AddUser = new System.Windows.Forms.Button();
            this.DeleteUser = new System.Windows.Forms.Button();
            this.UpdateUser = new System.Windows.Forms.Button();
            this.UpdateWaybill = new System.Windows.Forms.Button();
            this.DeleteWaybill = new System.Windows.Forms.Button();
            this.CreateWaybill = new System.Windows.Forms.Button();
            this.UpdateCar = new System.Windows.Forms.Button();
            this.DeleteCar = new System.Windows.Forms.Button();
            this.CreateCar = new System.Windows.Forms.Button();
            this.WaybillCost = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BestOnTruck = new System.Windows.Forms.Button();
            this.BestOnBus = new System.Windows.Forms.Button();
            this.BestOnVan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Статус:";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(98, 24);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 17);
            this.StatusLabel.TabIndex = 1;
            // 
            // UsersDG
            // 
            this.UsersDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersDG.Location = new System.Drawing.Point(231, 91);
            this.UsersDG.Name = "UsersDG";
            this.UsersDG.RowHeadersWidth = 51;
            this.UsersDG.RowTemplate.Height = 24;
            this.UsersDG.Size = new System.Drawing.Size(235, 342);
            this.UsersDG.TabIndex = 3;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(472, 91);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(235, 342);
            this.dataGridView3.TabIndex = 4;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(713, 91);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(235, 342);
            this.dataGridView4.TabIndex = 5;
            // 
            // AddUser
            // 
            this.AddUser.Location = new System.Drawing.Point(231, 440);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(235, 23);
            this.AddUser.TabIndex = 6;
            this.AddUser.Text = "Добавить Пользователя";
            this.AddUser.UseVisualStyleBackColor = true;
            // 
            // DeleteUser
            // 
            this.DeleteUser.Location = new System.Drawing.Point(231, 470);
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.Size = new System.Drawing.Size(235, 23);
            this.DeleteUser.TabIndex = 7;
            this.DeleteUser.Text = "Удалить Пользователя";
            this.DeleteUser.UseVisualStyleBackColor = true;
            // 
            // UpdateUser
            // 
            this.UpdateUser.Location = new System.Drawing.Point(231, 500);
            this.UpdateUser.Name = "UpdateUser";
            this.UpdateUser.Size = new System.Drawing.Size(235, 23);
            this.UpdateUser.TabIndex = 8;
            this.UpdateUser.Text = "Изменить пользователя";
            this.UpdateUser.UseVisualStyleBackColor = true;
            // 
            // UpdateWaybill
            // 
            this.UpdateWaybill.Location = new System.Drawing.Point(713, 500);
            this.UpdateWaybill.Name = "UpdateWaybill";
            this.UpdateWaybill.Size = new System.Drawing.Size(235, 23);
            this.UpdateWaybill.TabIndex = 11;
            this.UpdateWaybill.Text = "Изменить Путевой Лист";
            this.UpdateWaybill.UseVisualStyleBackColor = true;
            // 
            // DeleteWaybill
            // 
            this.DeleteWaybill.Location = new System.Drawing.Point(713, 470);
            this.DeleteWaybill.Name = "DeleteWaybill";
            this.DeleteWaybill.Size = new System.Drawing.Size(235, 23);
            this.DeleteWaybill.TabIndex = 10;
            this.DeleteWaybill.Text = "Удалить Путевой Лист";
            this.DeleteWaybill.UseVisualStyleBackColor = true;
            // 
            // CreateWaybill
            // 
            this.CreateWaybill.Location = new System.Drawing.Point(713, 440);
            this.CreateWaybill.Name = "CreateWaybill";
            this.CreateWaybill.Size = new System.Drawing.Size(235, 23);
            this.CreateWaybill.TabIndex = 9;
            this.CreateWaybill.Text = "Добавить Путевой Лист";
            this.CreateWaybill.UseVisualStyleBackColor = true;
            // 
            // UpdateCar
            // 
            this.UpdateCar.Location = new System.Drawing.Point(472, 500);
            this.UpdateCar.Name = "UpdateCar";
            this.UpdateCar.Size = new System.Drawing.Size(235, 23);
            this.UpdateCar.TabIndex = 14;
            this.UpdateCar.Text = "Изменить Автомобиль";
            this.UpdateCar.UseVisualStyleBackColor = true;
            // 
            // DeleteCar
            // 
            this.DeleteCar.Location = new System.Drawing.Point(472, 470);
            this.DeleteCar.Name = "DeleteCar";
            this.DeleteCar.Size = new System.Drawing.Size(235, 23);
            this.DeleteCar.TabIndex = 13;
            this.DeleteCar.Text = "Удалить Автомобиль";
            this.DeleteCar.UseVisualStyleBackColor = true;
            // 
            // CreateCar
            // 
            this.CreateCar.Location = new System.Drawing.Point(472, 440);
            this.CreateCar.Name = "CreateCar";
            this.CreateCar.Size = new System.Drawing.Size(235, 23);
            this.CreateCar.TabIndex = 12;
            this.CreateCar.Text = "Добавить Автомобиль";
            this.CreateCar.UseVisualStyleBackColor = true;
            // 
            // WaybillCost
            // 
            this.WaybillCost.Location = new System.Drawing.Point(38, 118);
            this.WaybillCost.Name = "WaybillCost";
            this.WaybillCost.Size = new System.Drawing.Size(135, 45);
            this.WaybillCost.TabIndex = 15;
            this.WaybillCost.Text = "Узнать стоимость рейса";
            this.WaybillCost.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 45);
            this.button1.TabIndex = 16;
            this.button1.Text = "Информация об автомобиле";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BestOnTruck
            // 
            this.BestOnTruck.Location = new System.Drawing.Point(38, 220);
            this.BestOnTruck.Name = "BestOnTruck";
            this.BestOnTruck.Size = new System.Drawing.Size(135, 66);
            this.BestOnTruck.TabIndex = 17;
            this.BestOnTruck.Text = "Найти лучшего водителя грузовиков";
            this.BestOnTruck.UseVisualStyleBackColor = true;
            // 
            // BestOnBus
            // 
            this.BestOnBus.Location = new System.Drawing.Point(38, 292);
            this.BestOnBus.Name = "BestOnBus";
            this.BestOnBus.Size = new System.Drawing.Size(135, 66);
            this.BestOnBus.TabIndex = 18;
            this.BestOnBus.Text = "Найти лучшего водителя фургонов";
            this.BestOnBus.UseVisualStyleBackColor = true;
            // 
            // BestOnVan
            // 
            this.BestOnVan.Location = new System.Drawing.Point(38, 364);
            this.BestOnVan.Name = "BestOnVan";
            this.BestOnVan.Size = new System.Drawing.Size(135, 66);
            this.BestOnVan.TabIndex = 19;
            this.BestOnVan.Text = "Найти лучшего водителя автобуса";
            this.BestOnVan.UseVisualStyleBackColor = true;
            // 
            // AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 585);
            this.Controls.Add(this.BestOnVan);
            this.Controls.Add(this.BestOnBus);
            this.Controls.Add(this.BestOnTruck);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.WaybillCost);
            this.Controls.Add(this.UpdateCar);
            this.Controls.Add(this.DeleteCar);
            this.Controls.Add(this.CreateCar);
            this.Controls.Add(this.UpdateWaybill);
            this.Controls.Add(this.DeleteWaybill);
            this.Controls.Add(this.CreateWaybill);
            this.Controls.Add(this.UpdateUser);
            this.Controls.Add(this.DeleteUser);
            this.Controls.Add(this.AddUser);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.UsersDG);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.label1);
            this.Name = "AdminMain";
            this.Text = "AdminMain";
            ((System.ComponentModel.ISupportInitialize)(this.UsersDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.DataGridView UsersDG;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button AddUser;
        private System.Windows.Forms.Button DeleteUser;
        private System.Windows.Forms.Button UpdateUser;
        private System.Windows.Forms.Button UpdateWaybill;
        private System.Windows.Forms.Button DeleteWaybill;
        private System.Windows.Forms.Button CreateWaybill;
        private System.Windows.Forms.Button UpdateCar;
        private System.Windows.Forms.Button DeleteCar;
        private System.Windows.Forms.Button CreateCar;
        private System.Windows.Forms.Button WaybillCost;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BestOnTruck;
        private System.Windows.Forms.Button BestOnBus;
        private System.Windows.Forms.Button BestOnVan;
    }
}