using diplom.src.entity;
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
using diplom.src.back.entity;
using diplom.src.back.service;
using diplom.src.back.service.impl;

namespace diplom.src.forms {

    public partial class CreateClient : Form {

        private readonly IClientService service = ClientServiceImpl.GetService();
        private readonly IClientCarService carService = ClientCarServiceImpl.GetService();
        private readonly Main main;

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
                //Client client = customerService.Create(new Client(
                //    fname.Text, mname.Text, lname.Text, phone.Text, address.Text, int.Parse(inn.Text), int.Parse(pNum.Text), int.Parse(pSeries.Text)));
                Client client = service.Create(new Client
                {
                    id = Guid.NewGuid(),
                    firstName = fname.Text,
                    middleName = mname.Text,
                    lastName = lname.Text,
                    phone = phone.Text,
                    address = address.Text,
                    inn = int.Parse(inn.Text),
                    passportId = int.Parse(pNum.Text),
                    passportSeries = int.Parse(pSeries.Text)
                });
                ClientCar car = new ClientCar
                {
                    ClientId = client.id,
                    maker = maker.Text,
                    model = model.Text,
                    releaseYear = int.Parse(releaseYear.Text),
                    description = description.Text
                };
                carService.Create(car);
                main.updateClientTable(new List<Client>(1) { client });
                Close();
            }
        }
    }
}
