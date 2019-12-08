using diplom.src.back.entity;
using diplom.src.back.service;
using diplom.src.back.service.impl;
using diplom.src.forms;
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
    public partial class AddNewCar : Form
    {

        private readonly INewCarService service = CarServiceImpl.GetService();
        private Main main;

        public AddNewCar()
        {
            InitializeComponent();
        }
        public AddNewCar(Main main) : this()
        {
            this.main = main;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            service.Create(new NewCar(
                maker.Text, 
                model.Text, 
                Decimal.Parse(price.Text)));
            Close();
        }
    }
}
