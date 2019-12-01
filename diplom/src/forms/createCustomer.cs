using diplom.src.context;
using diplom.src.entity;
using diplom.src.data.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using diplom.src.service;
using diplom.src.service.impl;

namespace diplom.src.forms
{
    public partial class createCustomer : Form
    {

        private readonly CustomerService customerService = CustomerServiceImpl.GetService();
        private Main main;

        public createCustomer()
        {
            InitializeComponent();
        }

        public createCustomer(Main main): this()
        {
            this.main = main;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Client customer = customerService.create(new Client(int.Parse(textBox1.Text), textBox2.Text,
                    new Location(textBox3.Text, textBox4.Text, textBox6.Text, textBox5.Text)));
            Close();

            main.updateState(customer);
        }
    }
}
