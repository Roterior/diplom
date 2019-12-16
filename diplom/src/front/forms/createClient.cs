using System;
using System.Collections.Generic;
using System.Windows.Forms;
using diplom.src.back.entity;
using diplom.src.back.service;
using diplom.src.back.service.impl;

namespace diplom.src.front.forms
{
    public partial class CreateClient : Form
    {
        private readonly IClientService service = ClientServiceImpl.GetService();
        private readonly ICarClientService carService = CarClientServiceImpl.GetService();
        private readonly Main main;

        public CreateClient() => InitializeComponent();

        public CreateClient(Main main) : this() => this.main = main;

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
                Client client = service.Create(new Client
                {
                    Id = Guid.NewGuid(),
                    FirstName = fname.Text,
                    MiddleName = mname.Text,
                    LastName = lname.Text,
                    Phone = phone.Text,
                    Address = address.Text,
                    Inn = int.Parse(inn.Text),
                    PassportNumber = int.Parse(pNum.Text),
                    PassportSeries = int.Parse(pSeries.Text)
                });
                carService.Create(new CarClient
                {
                    ClientId = client.Id,
                    Maker = maker.Text,
                    Model = model.Text,
                    ReleaseYear = (releaseYear.Text != "") ? int.Parse(releaseYear.Text) : 0,
                    Description = description.Text
                });
                main.updateClientTable(new List<Client>(1) { client });
                Close();
            }
        }
    }
}
