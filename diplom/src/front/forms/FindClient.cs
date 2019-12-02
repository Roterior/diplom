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

namespace diplom.src.forms {

    public partial class FindClient : Form {

        private readonly IClientService service = ClientServiceImpl.GetService();
        private Main main;

        public FindClient() {
            InitializeComponent();
        }

        public FindClient(Main main) : this() {
            this.main = main;
        }

        private void Button1_Click(object sender, EventArgs e) {
            try {
                main.updateState(service.findBy(fname.Text, mname.Text));
                //main.updateState(service.findByInn(int.Parse(inn.Text)));
                Close();
            } catch (EntityNotFoundException exception) {
                MessageBox.Show(exception.Message);
            }
        }

    }

}
