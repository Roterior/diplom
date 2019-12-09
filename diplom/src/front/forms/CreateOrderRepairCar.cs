using diplom.src.back.entity;
using diplom.src.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diplom.src.front.forms
{
    public partial class CreateOrderRepairCar : Form
    {
        public CreateOrderRepairCar()
        {
            InitializeComponent();
            LoadClientCar();
        }

        private void LoadClientCar()
        {
            ClientCar car = Main.currentClient.ClientsCars[0];
            maker.Text = car.maker;
            model.Text = car.model;
            releaseYear.Text = car.releaseYear.ToString();
            status.Text = "Поломана жизнью";
            description.Text = car.description;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                progressBar1.Value++;
                Thread.Sleep(250);
            }
            progressBar1.Value = 0;
            Close();
        }
    }
}
