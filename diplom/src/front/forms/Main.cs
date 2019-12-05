using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using diplom.src.context;
using diplom.src.entity;
using System.Data.Entity;
using diplom.src.data;
using diplom.src.service;
using diplom.src.service.impl;
using diplom.src.front.forms;
using diplom.src.back.entity;

namespace diplom.src.forms
{

    public partial class Main
    {

        private static Client currentClient = null;
        private static OrderBuyCar currentOrderInfo = null;
        private List<Client> clients;

        public Main()
        {
            InitializeComponent();
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            new CreateClient(this).Show();
        }

        public void updateClientOrders(Client client)
        {
            try
            {
                for (int i = 0; i < tabControl1.TabPages.Count; i++) {
                    tabControl1.TabPages.Remove(tabControl1.TabPages[i]);
                }
                int pages = client.orders.Count / 8 + 1;
                List<TabPage> tabPages = new List<TabPage>(pages);
                for (int i = 0; i < pages; i++) {
                    TabPage tabPage = new TabPage((i + 1).ToString());
                    DataGridView dataGrid = new DataGridView();
                    dataGrid.BorderStyle = BorderStyle.None;
                    dataGrid.AllowUserToAddRows = false;
                    dataGrid.AllowUserToDeleteRows = false;
                    dataGrid.AllowUserToResizeRows = false;
                    dataGrid.AllowUserToResizeColumns = false;
                    dataGrid.AllowUserToDeleteRows = false;
                    dataGrid.RowHeadersVisible = false;
                    dataGrid.Dock = DockStyle.Fill;
                    DataGridViewCell cell = new DataGridViewTextBoxCell();
                    DataGridViewColumn column = new DataGridViewColumn(cell);
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    column.Frozen = false;
                    column.HeaderText = "Дата";
                    dataGrid.Columns.Add(column);
                    dataGrid.Columns.Add("price", "Цена");
                    dataGrid.ReadOnly = true;
                    dataGrid.BackgroundColor = SystemColors.Control;
                    dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGrid.CellClick += new DataGridViewCellEventHandler(CellClick);
                    dataGrid.Name = "dataGridView" + (i + 1);
                    tabPage.Controls.Add(dataGrid);
                    tabPage.BackColor = Color.Transparent;
                    tabControl1.TabPages.Add(tabPage);
                    tabPages.Add(tabPage);
                }
                List<List<OrderBuyCar>> pagesOrder = new List<List<OrderBuyCar>>(pages);
                for (int i = 0; i < pagesOrder.Capacity; i++)
                {
                    pagesOrder.Add(new List<OrderBuyCar>(8));
                }
                pagesOrder.ForEach(page =>
                {
                    int start = pagesOrder.IndexOf(page) * 8;
                    for (int i = start; i < start + 8; i++)
                    {
                        if (i >= client.orders.Count) break;
                        page.Add(client.orders[i]);
                    }
                });
                tabPages.ForEach(page =>
                {
                    pagesOrder[tabControl1.TabPages.IndexOf(page)].ForEach(order =>
                    {
                        ((DataGridView)page.Controls[0]).Rows.Add(
                            String.Format("{0:dd/MM/yyyy}", order.timestamp.GetValueOrDefault()), order.price);
                    });
                });
            }
            catch (NullReferenceException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void updateOrderInfo(OrderBuyCar order)
        {
            textBox3.Text = order.description;
            label10.Text = "Дата создания: " + String.Format("{0:dd/MM/yyyy}", order.timestamp.GetValueOrDefault());
            label12.Text = "Время создания: " + String.Format("{0:HH/mm/ss}", order.timestamp.GetValueOrDefault());
            label11.Text = "Общая стоимость: " + order.price;
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            new FindClient(this).Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            IOrderService service = OrderServiceImpl.GetService();
            if (currentClient != null)
            {
                Order order = new Order(currentClient.id, "test1",
                    DateTimeOffset.Now, Convert.ToDecimal("10"));
                service.create(order);
                IClientService customerService = ClientServiceImpl.GetService();
                Client customer = customerService.findById(currentClient.id);
                //updateState(customer);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {
            Console.WriteLine("click");
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGrid = (DataGridView)sender;
            int page = int.Parse(dataGrid.Name.Substring("dataGridView".Length)) - 1;
            OrderBuyCar selected = null;
            if (e.RowIndex != -1)
            {
                selected = currentClient.orders[page * 8 + e.RowIndex];
            }
            if (selected != null && selected != currentOrderInfo)
            {
                currentOrderInfo = selected;
                updateOrderInfo(currentOrderInfo);
            }
        }

        private void createOrderOnBtnClick(object sender, EventArgs e)
        {
            new CreateOrder(this, currentClient).Show();
        }

        private void createOrderBuyCar(object sender, EventArgs e)
        {
            new CreateOrderBuyCar(this, currentClient).Show();
        }

        private void createOrderRepairCar(object sender, EventArgs e)
        {
            new CreateOrderRepairCar().Show();
        }

        private void новыйАвтомобильToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddNewCar(this).Show();
        }

        public void updateClientTable(List<Client> clients)
        {
            this.clients = clients;
            try
            {
                for (int i = 0; i < tabControl2.TabPages.Count; i++)
                {
                    tabControl2.TabPages.Remove(tabControl2.TabPages[i]);
                }
                int pages = clients.Count / 8 + 1;
                List<TabPage> tabPages = new List<TabPage>(pages);
                for (int i = 0; i < pages; i++)
                {
                    TabPage tabPage = new TabPage((i + 1).ToString());
                    DataGridView dataGrid = new DataGridView();
                    dataGrid.BorderStyle = BorderStyle.None;
                    dataGrid.AllowUserToAddRows = false;
                    dataGrid.AllowUserToDeleteRows = false;
                    dataGrid.AllowUserToResizeRows = false;
                    dataGrid.AllowUserToResizeColumns = false;
                    dataGrid.AllowUserToDeleteRows = false;
                    dataGrid.RowHeadersVisible = false;
                    dataGrid.Dock = DockStyle.Fill;
                    DataGridViewCell cell = new DataGridViewTextBoxCell();
                    DataGridViewColumn column = new DataGridViewColumn(cell);
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    column.Frozen = false;
                    column.HeaderText = "Имя";
                    dataGrid.Columns.Add(column);
                    dataGrid.Columns.Add("lname", "Фамилия");
                    dataGrid.Columns.Add("inn", "ИНН");
                    dataGrid.ReadOnly = true;
                    dataGrid.BackgroundColor = SystemColors.Control;
                    dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    dataGrid.CellClick += new DataGridViewCellEventHandler(CellClickClient);
                    dataGrid.Name = "dataGridView" + (i + 1);
                    tabPage.Controls.Add(dataGrid);
                    tabPage.BackColor = Color.Transparent;
                    tabControl2.TabPages.Add(tabPage);
                    tabPages.Add(tabPage);
                }
                List<List<Client>> pagesOrder = new List<List<Client>>(pages);
                for (int i = 0; i < pagesOrder.Capacity; i++)
                {
                    pagesOrder.Add(new List<Client>(8));
                }
                pagesOrder.ForEach(page =>
                {
                    int start = pagesOrder.IndexOf(page) * 8;
                    for (int i = start; i < start + 8; i++)
                    {
                        if (i >= clients.Count) break;
                        page.Add(clients[i]);
                    }
                });

                tabPages.ForEach(page =>
                {
                    pagesOrder[tabControl2.TabPages.IndexOf(page)].ForEach(client =>
                    {
                        ((DataGridView)page.Controls[0]).Rows.Add(client.firstName, client.lastName, client.inn);
                    });
                });
                if (clients != null && clients.Count > 0)
                {
                    currentClient = clients[0];
                    updateClientInfo(currentClient);
                    updateClientOrders(currentClient);
                }
                else
                {
                    currentClient = null;
                }
            }
            catch (NullReferenceException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void CellClickClient(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGrid = (DataGridView)sender;
            int page = int.Parse(dataGrid.Name.Substring("dataGridView".Length)) - 1;
            Client selected = null;
            if (e.RowIndex != -1)
            {
                selected = clients[page * 8 + e.RowIndex];
            }
            if (selected != null && (currentClient == null || selected != currentClient))
            {
                currentClient = selected;
                updateClientInfo(currentClient);
                updateClientOrders(currentClient);
            }
        }

        private void updateClientInfo(Client client)
        {
            fname.Text = "Имя: " + client.firstName;
            mname.Text = "Отчество: " + client.middleName;
            lname.Text = "Фамилия: " + client.lastName;
            inn.Text = "ИНН: " + client.inn;
            phone.Text = "Телефон: " + client.phone;
            address.Text = "Адрес: " + client.address;
        }

    }

}
