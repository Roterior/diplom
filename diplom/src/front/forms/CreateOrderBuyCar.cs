using diplom.src.back.entity;
using diplom.src.back.service;
using diplom.src.back.service.impl;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace diplom.src.front.forms
{
    public partial class CreateOrderBuyCar : Form
    {
        private readonly IClientService clientService = ClientServiceImpl.GetService();
        private readonly ICarNewService service = CarNewServiceImpl.GetService();
        private readonly IOrderBuyService orderService = OrderBuyServiceImpl.GetService();
        private readonly Main main;
        private CarNew currentNewCar;
        private List<CarNew> newCars;

        public CreateOrderBuyCar()
        {
            InitializeComponent();
            loadNewCars();
        }

        public CreateOrderBuyCar(Main main) : this() => this.main = main;

        private void loadNewCars()
        {
            newCars = service.GetAll();
            try
            {
                for (int i = 0; i < tabControl1.TabPages.Count; i++)
                {
                    tabControl1.TabPages.Remove(tabControl1.TabPages[i]);
                }
                int pages = newCars.Count / 8 + 1;
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
                List<List<CarNew>> pagesOrder = new List<List<CarNew>>(pages);
                for (int i = 0; i < pagesOrder.Capacity; i++)
                {
                    pagesOrder.Add(new List<CarNew>(8));
                }
                pagesOrder.ForEach(page =>
                {
                    int start = pagesOrder.IndexOf(page) * 8;
                    for (int i = start; i < start + 8; i++)
                    {
                        if (i >= newCars.Count) break;
                        page.Add(newCars[i]);
                    }
                });
                tabPages.ForEach(page =>
                {
                    pagesOrder[tabControl1.TabPages.IndexOf(page)].ForEach(car =>
                    {
                        ((DataGridView)page.Controls[0]).Rows.Add(car.Maker, car.Model);
                    });
                });
                if (newCars != null && newCars.Count > 0)
                {
                    currentNewCar = newCars[0];
                    updateInfo(currentNewCar);
                } 
                else
                {
                    currentNewCar = null;
                }
                
            }
            catch (NullReferenceException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGrid = (DataGridView)sender;
            int page = int.Parse(dataGrid.Name.Substring("dataGridView".Length)) - 1;
            CarNew selected = newCars[page * 8 + e.RowIndex];
            if (currentNewCar == null || selected != currentNewCar)
            {
                currentNewCar = selected;
                updateInfo(currentNewCar);
            }
        }

        private void updateInfo(CarNew car)
        {
            maker.Text = "Марка:" + car.Maker;
            model.Text = "Модель:" + car.Model;
            price.Text = "Стоимость:" + car.Price;
        }

        private void BuySelectedCarBtnClick(object sender, EventArgs e)
        {
            orderService.Create(new OrderBuy
            {
                ClientId = Main.currentClient.Id,
                NewCarId = currentNewCar.Id,
                Price = currentNewCar.Price,
                Timestamp = DateTimeOffset.Now,
                Description = "test"
            });
            main.updateClientOrders(Main.currentClient);
            Close();
        }
    }
}
