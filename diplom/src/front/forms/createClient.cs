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

namespace diplom.src.forms {

    public partial class CreateClient : Form {

        private readonly IClientService customerService = ClientServiceImpl.GetService();
        private Main main;

        public CreateClient() {
            InitializeComponent();
        }

        public CreateClient(Main main): this() {
            this.main = main;
        }

        private void allowOnlynumbers(object sender, EventArgs e) {
            if (System.Text.RegularExpressions.Regex.IsMatch(inn.Text, "[^0-9]")) {
                MessageBox.Show("Пожалуйста, вводите только цифры.");
                inn.Text = inn.Text.Remove(inn.Text.Length - 1);
            } else if (System.Text.RegularExpressions.Regex.IsMatch(pSeries.Text, "[^0-9]")) {
                MessageBox.Show("Пожалуйста, вводите только цифры.");
                pSeries.Text = pSeries.Text.Remove(pSeries.Text.Length - 1);
            } else if (System.Text.RegularExpressions.Regex.IsMatch(pNum.Text, "[^0-9]")) {
                MessageBox.Show("Пожалуйста, вводите только цифры.");
                pNum.Text = pNum.Text.Remove(pNum.Text.Length - 1);
            }
        }

        private void createBtn(object sender, EventArgs e) {
            if (inn.Text == "" || pNum.Text == "" || pSeries.Text == "") {
                MessageBox.Show("Вы не ввели одно из важных полей: инн, номер паспорта, серия паспорта!");
            } else {
                Client client = customerService.create(new Client(
                    fname.Text, mname.Text, lname.Text, phone.Text, address.Text, int.Parse(inn.Text), int.Parse(pNum.Text), int.Parse(pSeries.Text)));
                main.updateState(client);
                Close();
            }
        }

    }

}
