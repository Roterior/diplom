using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using diplom.src.front.forms;
using diplom.src.back.entity;
using diplom.src.back.utils.view;
using System.Collections;
using diplom.src.front;
using diplom.src.front.controls;

namespace diplom.src.front.forms
{
    public partial class Main : Form
    {
        public static Client currentClient;
        private OrderBuy currentOrderInfo;
        private List<Client> clients;
        private Point mouseLocation;
        private List<CurrentOrder> list;

        public Main() => InitializeComponent();

        public void updateClientOrders(Client client)
        {
            try
            {
                for (int i = 0; i < tabControl1.TabPages.Count; i++) {
                    tabControl1.TabPages.Remove(tabControl1.TabPages[i]);
                }
                list = new List<CurrentOrder>();
                if (null != client)
                {
                    if(null != client.OrderRepairList && client.OrderRepairList.Count > 0)
                    {
                        client.OrderRepairList.ForEach(e => 
                            list.Add(new CurrentOrder { date = e.Timestamp, price = e.Price, type = "Ремонт", id = e.Id }));
                    }
                    if (null != client.OrderBuyList && client.OrderBuyList.Count > 0)
                    {
                        client.OrderBuyList.ForEach(e =>
                            list.Add(new CurrentOrder { date = e.Timestamp, price = e.Price, type = "Покупка", id = e.Id }));
                    }
                }
                


                int pages = list.Count > 0 ? list.Count / 8 + 1 : 1;
                List<TabPage> tabPages = new List<TabPage>(pages);
                for (int i = 0; i < pages; i++) {
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
                    dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                    dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                    DataGridViewCell cell = new DataGridViewTextBoxCell();
                    DataGridViewColumn column = new DataGridViewColumn(cell);
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    column.Frozen = false;
                    column.HeaderText = "Дата";
                    dataGrid.Columns.Add(column);
                    dataGrid.Columns.Add("price", "Цена");
                    dataGrid.Columns.Add("type", "Тип");
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
                List<List<CurrentOrder>> pagesOrder = new List<List<CurrentOrder>>(pages);
                for (int i = 0; i < pagesOrder.Capacity; i++)
                {
                    pagesOrder.Add(new List<CurrentOrder>(8));
                }
                pagesOrder.ForEach(page =>
                {
                    int start = pagesOrder.IndexOf(page) * 8;
                    for (int i = start; i < start + 8; i++)
                    {
                        if (i >= list.Count) break;
                        page.Add(list[i]);
                    }
                });
                tabPages.ForEach(page =>
                    pagesOrder[tabControl1.TabPages.IndexOf(page)].ForEach(order =>
                        ((DataGridView)page.Controls[0]).Rows.Add(
                            String.Format("{0:dd/MM/yyyy}", order.date.GetValueOrDefault()), order.price, order.type)));



                if (client.OrderBuyList != null && client.OrderBuyList.Count > 0)
                {
                    if (currentOrderInfo == null)
                    {
                        updateOrderInfo(client.OrderBuyList[0]);
                    }
                }
                else
                {
                    currentOrderInfo = null;
                    updateOrderInfo(currentOrderInfo);
                }
            }
            catch (NullReferenceException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void updateOrderInfo(OrderBuy order)
        {
            if (null == order)
            {
                textBox3.Text = "";
                label10.Text = "Дата создания: ";
                label12.Text = "Время создания: ";
                label11.Text = "Общая стоимость: ";
            }
            else
            {
                textBox3.Text = order.Description;
                label10.Text = "Дата создания: " + String.Format("{0:dd/MM/yyyy}", order.Timestamp.GetValueOrDefault());
                label12.Text = "Время создания: " + String.Format("{0:HH/mm/ss}", order.Timestamp.GetValueOrDefault());
                label11.Text = "Общая стоимость: " + order.Price;
            }
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGrid = (DataGridView)sender;
            int page = int.Parse(dataGrid.Name.Substring("dataGridView".Length)) - 1;
            OrderBuy selected = null;
            //OrderBuyCar obc = null;
            OrderRepair orc = null;
            CurrentOrder current = list[page * 8 + e.RowIndex];
            if (e.RowIndex != -1 && currentClient != null)
            {
                try
                {
                    selected = currentClient.OrderBuyList.Find(o => o.Id == current.id);
                }
                catch
                {
                    orc = currentClient.OrderRepairList.Find(o => o.Id == current.id);
                }
            }
            if ((selected != null || orc != null) && selected != currentOrderInfo)
            {
                currentOrderInfo = selected;
                updateOrderInfo(currentOrderInfo);
            }
        }

        private void createOrderBuyCar(object sender, EventArgs e) => new CreateOrderBuyCar(this).Show();

        private void createOrderRepairCar(object sender, EventArgs e) => new CreateOrderRepairCar().Show();

        private void новыйАвтомобильToolStripMenuItem_Click(object sender, EventArgs e) => new AddNewCar(this).Show();

        public void updateClientTable(List<Client> clients)
        {
            this.clients = clients;
            try
            {
                List<string> tableColumns = new List<string>(3) { "FirstName", "LastName", "Inn" };
                Dictionary<string, string> map = new Dictionary<string, string>(3)
                {
                    ["LastName"] = "Фамилия",
                    ["FirstName"] = "Имя",
                    ["Inn"] = "Инн"
                };
                TableBuilder.BuildTable(clients, tabControl2, map, new DataGridViewCellEventHandler(CellClickClient));
                if (clients != null && clients.Count > 0)
                {
                    currentClient = clients[0];
                    updateClientInfo();
                    updateClientOrders(currentClient);
                }
                else
                {
                    currentClient = null;
                    currentOrderInfo = null;
                    updateClientOrders(currentClient);
                }
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void CellClickClient(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGrid = (DataGridView)sender;
            int page = int.Parse(dataGrid.Name.Substring("dataGridView".Length)) - 1;
            Client selected = null;
            if (e.RowIndex != -1)
            {
                selected = clients[page * 8 + e.RowIndex];
            }
            if (selected != null && (currentClient == null || selected != currentClient))
            {
                currentClient = selected;
                updateClientInfo();
                updateClientOrders(currentClient);
            }
        }

        private void updateClientInfo()
        {
            fname.Text = "Имя: " + currentClient.FirstName;
            mname.Text = "Отчество: " + currentClient.MiddleName;
            lname.Text = "Фамилия: " + currentClient.LastName;
            inn.Text = "ИНН: " + currentClient.Inn;
            phone.Text = "Телефон: " + currentClient.Phone;
            address.Text = "Адрес: " + currentClient.Address;
        }

        private void AddNewClientOnBtnClick(object sender, EventArgs e) => new CreateClient(this).Show();

        private void FindClientsBtnClick(object sender, EventArgs e) => new FindClient(this).Show();

        private void DragOnMouseDown(object sender, MouseEventArgs e) => mouseLocation = new Point(-e.X, -e.Y);

        private void DragOnMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = MousePosition;
                mousePose.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePose;
            }
        }

        private void CloseBtn(object sender, EventArgs e) => Close();

        private void MinimizeBtn(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        private class CurrentOrder
        {
            public CurrentOrder() { }
            internal Guid id;
            internal DateTimeOffset? date;
            internal decimal? price;
            internal string type;
        }

        private void CallUserControl(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            UCSearch uc = new UCSearch
            {
                Dock = DockStyle.Fill
            };
            panel4.Controls.Add(uc);
        }

        private void CallAddClientControl(object sender, EventArgs e)
        {
            panel4.Controls.Clear();
            UCCreateClient uc = new UCCreateClient
            {
                Dock = DockStyle.Fill
            };
            panel4.Controls.Add(uc);
        }

        private void ChangeColorOnLeave(object sender, EventArgs e)
        {
            if (sender.GetType().Name.Equals("PictureBox"))
            {
                PictureBox pb = (PictureBox)sender;
                pb.BackColor = Color.FromArgb(40, 47, 53);
                _ = pb;
            }
        }

        private void ChangeColorOnHover(object sender, MouseEventArgs e)
        {
            if (sender.GetType().Name.Equals("PictureBox"))
            {
                PictureBox pb = (PictureBox)sender;
                switch (pb?.Name)
                {
                    case "pictureBox4":
                        if (pb.BackColor != Color.FromArgb(140, 47, 53)) 
                            pb.BackColor = Color.FromArgb(140, 47, 53);
                        break;
                    case "pictureBox1":
                        if (pb.BackColor != Color.FromArgb(50, 57, 63)) 
                            pb.BackColor = Color.FromArgb(50, 57, 63);
                        break;
                    default:
                        break;
                }
                _ = pb;
            }
        }
    }
}
