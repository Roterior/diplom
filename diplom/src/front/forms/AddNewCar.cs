using diplom.src.back.entity;
using diplom.src.back.service;
using diplom.src.back.service.impl;
using System;
using System.Windows.Forms;

namespace diplom.src.front.forms
{
    public partial class AddNewCar : Form
    {
        private readonly ICarNewService service = CarNewServiceImpl.GetService();
        private readonly Main main;

        public AddNewCar() => InitializeComponent();

        public AddNewCar(Main main) : this() => this.main = main;

        private void CreateNewCarBtn(object sender, EventArgs e)
        {
            service.Create(new CarNew
            {
                Maker = maker.Text,
                Model = model.Text,
                Price = decimal.Parse(price.Text)
            });
            Close();
        }
    }
}
