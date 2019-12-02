using diplom.src.entity;
using diplom.src.forms;
using diplom.src.service;
using diplom.src.service.impl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diplom.src.front.forms
{
    public partial class CreateOrder : Form
    {

        private readonly IClientService service = ClientServiceImpl.GetService();
        private Main main;
        private Client client;

        public CreateOrder()
        {
            InitializeComponent();
        }

        public CreateOrder(Main main, Client client) : this()
        {
            this.main = main;
            this.client = client;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (description.Text == "" || price.Text == "")
            {
                MessageBox.Show("Вы не ввели одно из важных полей: описание или стоимость заказа!");
            }
            else
            {
                client.orders.Add(new Order(description.Text, DateTimeOffset.Now, Decimal.Parse(price.Text)));
                service.update(client.id, client);
                main.updateState(client);
                Close();
            }
        }

    }

}
