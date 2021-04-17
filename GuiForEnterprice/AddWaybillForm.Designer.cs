namespace GuiForEnterprice
{
    partial class AddWaybillForm
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
            this.DriversView = new System.Windows.Forms.DataGridView();
            this.CarsView = new System.Windows.Forms.DataGridView();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.TrackDistance = new System.Windows.Forms.TrackBar();
            this.DistanceLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.Enter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DriversView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackDistance)).BeginInit();
            this.SuspendLayout();
            // 
            // DriversView
            // 
            this.DriversView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DriversView.Location = new System.Drawing.Point(28, 68);
            this.DriversView.Name = "DriversView";
            this.DriversView.RowHeadersWidth = 51;
            this.DriversView.RowTemplate.Height = 24;
            this.DriversView.Size = new System.Drawing.Size(249, 303);
            this.DriversView.TabIndex = 0;
            // 
            // CarsView
            // 
            this.CarsView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarsView.Location = new System.Drawing.Point(298, 68);
            this.CarsView.Name = "CarsView";
            this.CarsView.RowHeadersWidth = 51;
            this.CarsView.RowTemplate.Height = 24;
            this.CarsView.Size = new System.Drawing.Size(249, 303);
            this.CarsView.TabIndex = 1;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(167, 40);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(245, 22);
            this.datePicker.TabIndex = 2;
            // 
            // TrackDistance
            // 
            this.TrackDistance.Location = new System.Drawing.Point(28, 387);
            this.TrackDistance.Maximum = 1000;
            this.TrackDistance.Minimum = 1;
            this.TrackDistance.Name = "TrackDistance";
            this.TrackDistance.Size = new System.Drawing.Size(519, 56);
            this.TrackDistance.TabIndex = 3;
            this.TrackDistance.Value = 1;
            this.TrackDistance.Scroll += new System.EventHandler(this.TrackDistance_Scroll);
            // 
            // DistanceLabel
            // 
            this.DistanceLabel.AutoSize = true;
            this.DistanceLabel.Location = new System.Drawing.Point(129, 435);
            this.DistanceLabel.Name = "DistanceLabel";
            this.DistanceLabel.Size = new System.Drawing.Size(0, 17);
            this.DistanceLabel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Расстояние: ";
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(269, 435);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Назад";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // Enter
            // 
            this.Enter.Location = new System.Drawing.Point(482, 435);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(75, 23);
            this.Enter.TabIndex = 7;
            this.Enter.Text = "Далее";
            this.Enter.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Статус: ";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(83, 13);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 17);
            this.StatusLabel.TabIndex = 9;
            // 
            // AddWaybillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 479);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Enter);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DistanceLabel);
            this.Controls.Add(this.TrackDistance);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.CarsView);
            this.Controls.Add(this.DriversView);
            this.Name = "AddWaybillForm";
            this.Text = "д";
            ((System.ComponentModel.ISupportInitialize)(this.DriversView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackDistance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DriversView;
        private System.Windows.Forms.DataGridView CarsView;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.TrackBar TrackDistance;
        private System.Windows.Forms.Label DistanceLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label StatusLabel;
    }
}