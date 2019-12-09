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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // maker
            // 
            this.maker.AutoSize = true;
            this.maker.Location = new System.Drawing.Point(6, 20);
            this.maker.Name = "maker";
            this.maker.Size = new System.Drawing.Size(54, 17);
            this.maker.TabIndex = 0;
            this.maker.Text = "Марка:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Диагностика";
            this.button1.UseVisualStyleBackColor = true;
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 263);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Характеристики Машины";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Описание:";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(6, 120);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(188, 137);
            this.description.TabIndex = 4;
            // 
            // status
            // 
            this.status.AutoSize = true;
            this.status.Location = new System.Drawing.Point(6, 80);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(57, 17);
            this.status.TabIndex = 3;
            this.status.Text = "Статус:";
            // 
            // releaseYear
            // 
            this.releaseYear.AutoSize = true;
            this.releaseYear.Location = new System.Drawing.Point(6, 60);
            this.releaseYear.Name = "releaseYear";
            this.releaseYear.Size = new System.Drawing.Size(94, 17);
            this.releaseYear.TabIndex = 2;
            this.releaseYear.Text = "Год выпуска:";
            // 
            // model
            // 
            this.model.AutoSize = true;
            this.model.Location = new System.Drawing.Point(6, 40);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(62, 17);
            this.model.TabIndex = 1;
            this.model.Text = "Модель:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(126, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Починить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 311);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(200, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // CreateOrderRepairCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(469, 346);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "CreateOrderRepairCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Починка Машины";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}