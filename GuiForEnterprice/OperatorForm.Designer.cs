namespace GuiForEnterprice
{
    partial class OperatorForm
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
            this.WaybillView = new System.Windows.Forms.DataGridView();
            this.CarsView = new System.Windows.Forms.DataGridView();
            this.CreateCar = new System.Windows.Forms.Button();
            this.CreateWaybill = new System.Windows.Forms.Button();
            this.CarsToXML = new System.Windows.Forms.Button();
            this.WBtoXML = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WaybillView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarsView)).BeginInit();
            this.SuspendLayout();
            // 
            // WaybillView
            // 
            this.WaybillView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WaybillView.Location = new System.Drawing.Point(513, 37);
            this.WaybillView.Name = "WaybillView";
            this.WaybillView.RowHeadersWidth = 51;
            this.WaybillView.RowTemplate.Height = 24;
            this.WaybillView.Size = new System.Drawing.Size(249, 303);
            this.WaybillView.TabIndex = 4;
            // 
            // CarsView
            // 
            this.CarsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarsView.Location = new System.Drawing.Point(243, 37);
            this.CarsView.Name = "CarsView";
            this.CarsView.RowHeadersWidth = 51;
            this.CarsView.RowTemplate.Height = 24;
            this.CarsView.Size = new System.Drawing.Size(249, 303);
            this.CarsView.TabIndex = 5;
            // 
            // CreateCar
            // 
            this.CreateCar.Location = new System.Drawing.Point(243, 346);
            this.CreateCar.Name = "CreateCar";
            this.CreateCar.Size = new System.Drawing.Size(249, 23);
            this.CreateCar.TabIndex = 14;
            this.CreateCar.Text = "Добавить Автомобиль";
            this.CreateCar.UseVisualStyleBackColor = true;
            // 
            // CreateWaybill
            // 
            this.CreateWaybill.Location = new System.Drawing.Point(513, 346);
            this.CreateWaybill.Name = "CreateWaybill";
            this.CreateWaybill.Size = new System.Drawing.Size(249, 23);
            this.CreateWaybill.TabIndex = 13;
            this.CreateWaybill.Text = "Добавить Путевой Лист";
            this.CreateWaybill.UseVisualStyleBackColor = true;
            // 
            // CarsToXML
            // 
            this.CarsToXML.Location = new System.Drawing.Point(243, 376);
            this.CarsToXML.Name = "CarsToXML";
            this.CarsToXML.Size = new System.Drawing.Size(249, 23);
            this.CarsToXML.TabIndex = 15;
            this.CarsToXML.Text = "Отчёт в XML";
            this.CarsToXML.UseVisualStyleBackColor = true;
            // 
            // WBtoXML
            // 
            this.WBtoXML.Location = new System.Drawing.Point(513, 376);
            this.WBtoXML.Name = "WBtoXML";
            this.WBtoXML.Size = new System.Drawing.Size(249, 23);
            this.WBtoXML.TabIndex = 16;
            this.WBtoXML.Text = "Отчёт в XML";
            this.WBtoXML.UseVisualStyleBackColor = true;
            // 
            // OperatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WBtoXML);
            this.Controls.Add(this.CarsToXML);
            this.Controls.Add(this.CreateCar);
            this.Controls.Add(this.CreateWaybill);
            this.Controls.Add(this.CarsView);
            this.Controls.Add(this.WaybillView);
            this.Name = "OperatorForm";
            this.Text = "OperatorForm";
            ((System.ComponentModel.ISupportInitialize)(this.WaybillView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarsView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView WaybillView;
        private System.Windows.Forms.DataGridView CarsView;
        private System.Windows.Forms.Button CreateCar;
        private System.Windows.Forms.Button CreateWaybill;
        private System.Windows.Forms.Button CarsToXML;
        private System.Windows.Forms.Button WBtoXML;
    }
}