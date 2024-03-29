﻿using System.Windows.Forms;

namespace diplom.src.front.forms
{
    partial class CreateClient : Form
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
            this.phone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.inn = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pSeries = new System.Windows.Forms.TextBox();
            this.pNum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.maker = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.releaseYear = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.model = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(10, 80);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(100, 20);
            this.phone.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ИНН";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Телефон";
            // 
            // lname
            // 
            this.lname.Location = new System.Drawing.Point(10, 31);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(100, 20);
            this.lname.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(113, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Адрес";
            // 
            // mname
            // 
            this.mname.Location = new System.Drawing.Point(222, 30);
            this.mname.Name = "mname";
            this.mname.Size = new System.Drawing.Size(100, 20);
            this.mname.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(113, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Имя";
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(116, 31);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(100, 20);
            this.fname.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(7, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Фамилия";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(116, 80);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(206, 20);
            this.address.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(219, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Отчество";
            // 
            // inn
            // 
            this.inn.Location = new System.Drawing.Point(10, 130);
            this.inn.Name = "inn";
            this.inn.Size = new System.Drawing.Size(100, 20);
            this.inn.TabIndex = 10;
            this.inn.TextChanged += new System.EventHandler(this.allowOnlynumbers);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(540, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 24);
            this.button1.TabIndex = 12;
            this.button1.Text = "Создать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.createBtn);
            // 
            // pSeries
            // 
            this.pSeries.Location = new System.Drawing.Point(116, 130);
            this.pSeries.Name = "pSeries";
            this.pSeries.Size = new System.Drawing.Size(100, 20);
            this.pSeries.TabIndex = 13;
            this.pSeries.TextChanged += new System.EventHandler(this.allowOnlynumbers);
            // 
            // pNum
            // 
            this.pNum.Location = new System.Drawing.Point(222, 130);
            this.pNum.Name = "pNum";
            this.pNum.Size = new System.Drawing.Size(100, 20);
            this.pNum.TabIndex = 14;
            this.pNum.TextChanged += new System.EventHandler(this.allowOnlynumbers);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(113, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Серия паспорта";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(219, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Номер паспорта";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(6, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "Марка";
            // 
            // maker
            // 
            this.maker.Location = new System.Drawing.Point(9, 41);
            this.maker.Name = "maker";
            this.maker.Size = new System.Drawing.Size(100, 20);
            this.maker.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.description);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.releaseYear);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.model);
            this.groupBox1.Controls.Add(this.maker);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(389, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 246);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Машина Клиента";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(6, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(163, 15);
            this.label12.TabIndex = 24;
            this.label12.Text = "Описание неисправностей";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(9, 143);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(236, 96);
            this.description.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(6, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 15);
            this.label11.TabIndex = 22;
            this.label11.Text = "Год";
            // 
            // releaseYear
            // 
            this.releaseYear.Location = new System.Drawing.Point(9, 93);
            this.releaseYear.Name = "releaseYear";
            this.releaseYear.Size = new System.Drawing.Size(100, 20);
            this.releaseYear.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(112, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Модель";
            // 
            // model
            // 
            this.model.Location = new System.Drawing.Point(115, 41);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(100, 20);
            this.model.TabIndex = 19;
            // 
            // CreateClient
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(652, 297);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pNum);
            this.Controls.Add(this.pSeries);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.inn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.address);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "CreateClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создание клиента";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox phone;
        private Label label1;
        private Label label2;
        private TextBox lname;
        private Label label3;
        private TextBox mname;
        private Label label4;
        private TextBox fname;
        private Label label5;
        private TextBox address;
        private Label label6;
        private TextBox inn;
        private Button button1;
        private TextBox pSeries;
        private TextBox pNum;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox maker;
        private GroupBox groupBox1;
        private Label label10;
        private TextBox model;
        private Label label12;
        private TextBox description;
        private Label label11;
        private TextBox releaseYear;
    }
}
