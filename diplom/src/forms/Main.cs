﻿using System;
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

namespace diplom.src.forms
{
    public partial class Main
    {

        private static Client currentCustomer = null;
        private static Order currentOrderInfo = null;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
        }

        private void ToolStripButton1_Click(object sender, EventArgs e)
        {
            new createCustomer(this).Show();
        }

        public void updateState(Client customer)
        {
            try
            {
/*                label1.Text = Prefix.COUNTRY.GetDescription() + customer.address.country;
                label2.Text = Prefix.CITY.GetDescription() + customer.address.city;
                label3.Text = Prefix.DISTRICT.GetDescription() + customer.address.district;
                label4.Text = Prefix.STREET.GetDescription() + customer.address.street;
                label5.Text = Prefix.INN.GetDescription() + customer.inn;
                label6.Text = Prefix.KPP.GetDescription() + customer.kpp;*/

                label1.Text = Prefix.COUNTRY.GetDescription() + customer.address;
                label2.Text = Prefix.CITY.GetDescription() + customer.address;
                label3.Text = Prefix.DISTRICT.GetDescription() + customer.address;
                label4.Text = Prefix.STREET.GetDescription() + customer.address;
                label5.Text = Prefix.INN.GetDescription() + customer.address;
                label6.Text = Prefix.KPP.GetDescription() + customer.address;

                for (int i = 0; i < tabControl1.TabPages.Count; i++)
                {
                    tabControl1.TabPages.Remove(tabControl1.TabPages[i]);
                }
                int pages = customer.orders.Count / 8 + 1;
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
                    column.HeaderText = "Description";
                    dataGrid.Columns.Add(column);
                    dataGrid.Columns.Add("Pay", "Payment");
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
                List<List<Order>> pagesOrder = new List<List<Order>>(pages);
                for (int i = 0; i < pagesOrder.Capacity; i++)
                {
                    pagesOrder.Add(new List<Order>(8));
                }
                pagesOrder.ForEach(page =>
                {
                    int start = pagesOrder.IndexOf(page) * 8;
                    for (int i = start; i < start + 8; i++)
                    {
                        if (i >= customer.orders.Count) break;
                        page.Add(customer.orders[i]);
                    }
                });

                tabPages.ForEach(page =>
                {
                    pagesOrder[tabControl1.TabPages.IndexOf(page)].ForEach(order =>
                    {
                        ((DataGridView)page.Controls[0]).Rows.Add(order.description, order.paymentValue);
                    });
                });
                currentCustomer = customer;
            }
            catch (NullReferenceException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void updateOrderInfo(Order order)
        {
            textBox3.Text = order.description;
            label9.Text = "Номер: " + order.id.ToString();
            label10.Text = "Дата создания: " + String.Format("{0:dd/MM/yyyy}", order.timestamp.GetValueOrDefault());
            label12.Text = "Время создания: " + String.Format("{0:HH/mm/ss}", order.timestamp.GetValueOrDefault());
            label11.Text = "Общая стоимость: " + order.paymentValue;
        }

        private void ToolStripButton2_Click(object sender, EventArgs e)
        {
            new findCustomer(this).Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OrderService service = OrderServiceImpl.GetService();
            if (currentCustomer != null)
            {
                Order order = new Order(currentCustomer.id, textBox1.Text,
                    DateTimeOffset.Now, Convert.ToDecimal(textBox2.Text));
                service.create(order);
                CustomerService customerService = CustomerServiceImpl.GetService();
                Client customer = customerService.findById(currentCustomer.id);
                updateState(customer);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("click");
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGrid = (DataGridView)sender;
            int page = int.Parse(dataGrid.Name.Substring("dataGridView".Length)) - 1;
            Order selected = currentCustomer.orders[page * 8 + e.RowIndex];
            if (selected != currentOrderInfo)
            {
                currentOrderInfo = selected;
                updateOrderInfo(currentOrderInfo);
                Console.WriteLine("update order info");
            }
        }
    }
}