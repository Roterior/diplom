namespace diplom.src.front.forms
{
    partial class CreateOrderRepairCar
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
            this.maker = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.Label();
            this.releaseYear = new System.Windows.Forms.Label();
            this.model = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.repairTime = new System.Windows.Forms.Label();
            this.repairPrice = new System.Windows.Forms.Label();
            this.checkDate = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // maker
            // 
            this.maker.AutoSize = true;
            this.maker.Location = new System.Drawing.Point(4, 16);
            this.maker.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maker.Name = "maker";
            this.maker.Size = new System.Drawing.Size(43, 13);
            this.maker.TabIndex = 0;
            this.maker.Text = "Марка:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(11, 234);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(150, 21);
            this.button1.TabIndex = 1;
            this.button1.Text = "Диагностика";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.description);
            this.groupBox1.Controls.Add(this.status);
            this.groupBox1.Controls.Add(this.releaseYear);
            this.groupBox1.Controls.Add(this.model);
            this.groupBox1.Controls.Add(this.maker);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(150, 196);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Характеристики Машины";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 81);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Описание:";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(4, 98);
            this.description.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(142, 94);
            this.description.TabIndex = 4;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(4, 65);
            this.status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(44, 13);
            this.status.TabIndex = 3;
            this.status.Text = "Статус:";
            // 
            // releaseYear
            // 
            this.releaseYear.AutoSize = true;
            this.releaseYear.Location = new System.Drawing.Point(4, 49);
            this.releaseYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.releaseYear.Name = "releaseYear";
            this.releaseYear.Size = new System.Drawing.Size(74, 13);
            this.releaseYear.TabIndex = 2;
            this.releaseYear.Text = "Год выпуска:";
            // 
            // model
            // 
            this.model.AutoSize = true;
            this.model.Location = new System.Drawing.Point(4, 32);
            this.model.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(49, 13);
            this.model.TabIndex = 1;
            this.model.Text = "Модель:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(165, 234);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 21);
            this.button2.TabIndex = 3;
            this.button2.Text = "Начать ремонт";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(11, 211);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(150, 19);
            this.progressBar1.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkDate);
            this.groupBox2.Controls.Add(this.repairTime);
            this.groupBox2.Controls.Add(this.repairPrice);
            this.groupBox2.Location = new System.Drawing.Point(165, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(174, 78);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Результаты диагностики";
            // 
            // repairTime
            // 
            this.repairTime.AutoSize = true;
            this.repairTime.Location = new System.Drawing.Point(4, 32);
            this.repairTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.repairTime.Name = "repairTime";
            this.repairTime.Size = new System.Drawing.Size(89, 13);
            this.repairTime.TabIndex = 1;
            this.repairTime.Text = "Время ремонта:";
            // 
            // repairPrice
            // 
            this.repairPrice.AutoSize = true;
            this.repairPrice.Location = new System.Drawing.Point(4, 16);
            this.repairPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.repairPrice.Name = "repairPrice";
            this.repairPrice.Size = new System.Drawing.Size(82, 13);
            this.repairPrice.TabIndex = 0;
            this.repairPrice.Text = "Цена ремонта:";
            // 
            // checkDate
            // 
            this.checkDate.AutoSize = true;
            this.checkDate.Location = new System.Drawing.Point(4, 49);
            this.checkDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.checkDate.Name = "checkDate";
            this.checkDate.Size = new System.Drawing.Size(103, 13);
            this.checkDate.TabIndex = 3;
            this.checkDate.Text = "Дата диагностики:";
            // 
            // CreateOrderRepairCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(347, 263);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CreateOrderRepairCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Починка Машины";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label maker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label model;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label releaseYear;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label status;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label repairTime;
        private System.Windows.Forms.Label repairPrice;
        private System.Windows.Forms.Label checkDate;
    }
}