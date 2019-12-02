using diplom.src.data.exception;
using diplom.src.service;
using diplom.src.service.impl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace diplom.src.forms
{
    public partial class findCustomer : Form
    {

        private readonly IClientService customerService = CustomerServiceImpl.GetService();
        private Main main;

        public findCustomer()
        {
            InitializeComponent();
        }

        public findCustomer(Main main) : this()
        {
            this.main = main;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                main.updateState(customerService.findByInn(int.Parse(textBox1.Text)));
                Close();
            }
            catch (EntityNotFoundException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
