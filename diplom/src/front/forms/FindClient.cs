using diplom.src.back.dto;
using diplom.src.back.utils.exception;
using diplom.src.back.service;
using diplom.src.back.service.impl;
using System;
using System.Windows.Forms;

namespace diplom.src.front.forms
{

    public partial class FindClient : Form
    {
        private readonly IClientService service = ClientServiceImpl.GetService();
        private readonly Main main;

        public FindClient() => InitializeComponent();

        public FindClient(Main main) : this() => this.main = main;

        private void FindClientBtn(object sender, EventArgs e)
        {
            try
            {
                FilterClient filter = new FilterClient
                {
                    FirstName = fname.Text,
                    MiddleName = mname.Text,
                    LastName = lname.Text
                };
                if (inn.Text != "")
                {
                    filter.Inn = int.Parse(inn.Text);
                }
                main.updateClientTable(service.GetByFilter(filter));
                Close();
            }
            catch (EntityNotFoundException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
