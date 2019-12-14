using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace diplom.src.back.utils.view
{
    public class TableBuilder
    {
        public TableBuilder() { }

        public static void BuildTable(IList list, TabControl tabControl, Dictionary<string, string> tableColumns, DataGridViewCellEventHandler handler)
        {
            try
            {
                foreach (TabPage tabPage in tabControl.TabPages)
                {
                    tabControl.TabPages.Remove(tabPage);
                }
                int pages = list.Count / 8 + 1;
                List<TabPage> tabPages = new List<TabPage>(pages);
                for (int i = 0; i < pages; ++i)
                {
                    DataGridView dataGrid = new DataGridView
                    {
                        ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing,
                        AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells,
                        SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                        BorderStyle = BorderStyle.None,
                        Dock = DockStyle.Fill,
                        AllowUserToResizeColumns = false,
                        AllowUserToDeleteRows = false,
                        AllowUserToResizeRows = false,
                        AllowUserToAddRows = false,
                        RowHeadersVisible = false,
                        ReadOnly = true,
                        BackgroundColor = SystemColors.Control,
                        Name = "dataGridView" + (i + 1)
                    };
                    dataGrid.CellClick += handler;
                    foreach (KeyValuePair<string, string> entry in tableColumns)
                    {
                        dataGrid.Columns.Add(new DataGridViewColumn(new DataGridViewTextBoxCell())
                        {
                            AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                            HeaderText = entry.Value
                        });
                    }
                    TabPage tabPage = new TabPage((i + 1).ToString());
                    tabPage.Controls.Add(dataGrid);
                    tabPage.BackColor = Color.Transparent;
                    tabControl.TabPages.Add(tabPage);
                    tabPages.Add(tabPage);
                }
                List<List<object>> pagesObj = new List<List<object>>(pages);
                for (int i = 0; i < pagesObj.Capacity; ++i)
                {
                    pagesObj.Add(new List<object>(8));
                }
                pagesObj.ForEach(page =>
                {
                    int start = pagesObj.IndexOf(page) * 8;
                    for (int i = start; i < start + 8; ++i)
                    {
                        if (i >= list.Count) break;
                        page.Add(list[i]);
                    }
                });
                List<string> tempColumns = new List<string>(list.Count);
                tabPages.ForEach(page =>
                {
                    pagesObj[tabControl.TabPages.IndexOf(page)].ForEach(obj =>
                    {
                        foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(obj))
                        {
                            foreach (string key in tableColumns.Keys)
                            {
                                if (key.Equals(descriptor.Name)) tempColumns.Add(descriptor.GetValue(obj).ToString());
                            }
                        }
                        string[] row = new string[tempColumns.Count];
                        for (int i = 0; i < tempColumns.Count; ++i)
                        {
                            row[i] = tempColumns[i];
                        }
                        ((DataGridView)page.Controls[0]).Rows.Add(row);
                        tempColumns.Clear();
                        row = null;
                    });
                });
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
