using diplom.src.back.entity;
using diplom.src.back.service;
using diplom.src.back.service.impl;
using diplom.src.forms;
using System;
using System.Threading;
using System.Windows.Forms;

namespace diplom.src.front.forms
{
    public partial class CreateOrderRepairCar : Form
    {
        private readonly IOrderRepairService orderService = OrderRepairServiceImpl.GetService();

        public CreateOrderRepairCar()
        {
            InitializeComponent();
            LoadClientCar();
        }

        private void LoadClientCar()
        {
            CarClient car = Main.currentClient.CarClientList[0];
            maker.Text = car.Maker;
            model.Text = car.Model;
            releaseYear.Text = car.ReleaseYear.ToString();
            status.Text = "Поломана жизнью";
            description.Text = car.Description;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                progressBar1.Value++;
                Thread.Sleep(250);
            }
            progressBar1.Value = 0;
            repairPrice.Text = "Цена ремонта: 500Р";
            repairTime.Text = "Время ремонта: 5 дней";
            checkDate.Text = "Дата диагностики: " + DateTimeOffset.Now;
        }

        private void CreateOrderRepairBtn(object sender, EventArgs e)
        {
            orderService.Create(new OrderRepair
            {
                Status = "В ремонте",
                Timestamp = DateTimeOffset.Now,
                Price = 500,
                ClientId = Main.currentClient.Id
            });
        }
    }
}
