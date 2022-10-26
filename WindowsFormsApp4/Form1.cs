using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        int selectedMenuItemId;
        int selectedMenuItemsAmount;
        int selectedOrderId;
        int temp;
        string selectedMenuItemName;
        double selectedMenuItemPrice;
        double currentCartPrice = 0;

        DataTable cartTable = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ordersTableAdapter.Fill(this.dBDataSet.orders);
            this.typesTableAdapter.Fill(this.dBDataSet.types);
            this.positionsTableAdapter.Fill(this.dBDataSet.positions);
            this.menuTableAdapter.Fill(this.dBDataSet.menu);
            this.workersTableAdapter.Fill(this.dBDataSet.workers);

            cartTable.Columns.Add("№", typeof(int));
            cartTable.Columns.Add("Наименование", typeof(string));
            cartTable.Columns.Add("Количество", typeof(int));
            cartTable.Columns.Add("Цена", typeof(double));
            cartTable.Columns.Add("Итого", typeof(double));
            dgv_cart.DataSource = cartTable;
            dgv_cart.ReadOnly = true;
        }


        private void btn_add_worker_Click(object sender, EventArgs e)
        {
            if (workersTableAdapter.Insert(tb_name_worker.Text, Convert.ToInt32(cb_pos_worker.SelectedValue)) >= 0)
            {
                MessageBox.Show("Сотрудник добавлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                workersTableAdapter.Fill(this.dBDataSet.workers);
            }
        }

        private void btn_menu_add_Click(object sender, EventArgs e)
        {
            if (menuTableAdapter.Insert(tb_menu_name.Text, Convert.ToDouble(tb_menu_price.Text), Convert.ToInt32(cb_menu_type.SelectedValue)) >= 0)
            {
                MessageBox.Show("Блюдо добавлено в меню", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                menuTableAdapter.Fill(this.dBDataSet.menu);
            }
        }

        private void btn_add_cart_Click(object sender, EventArgs e)
        {
            selectedMenuItemsAmount = Convert.ToInt32(textBox1.Text);
            double totalMenuItemsPrice = selectedMenuItemPrice * selectedMenuItemsAmount;
            cartTable.Rows.Add(selectedMenuItemId, selectedMenuItemName, selectedMenuItemsAmount, selectedMenuItemPrice, totalMenuItemsPrice);
            currentCartPrice += totalMenuItemsPrice;
            tb_total_orderPrice.Text = currentCartPrice.ToString();
        }

        private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView5.Rows[e.RowIndex];
                selectedMenuItemId = Convert.ToInt32(row.Cells[0].Value);
                selectedMenuItemName = row.Cells[1].Value.ToString();
                selectedMenuItemPrice = Convert.ToDouble(row.Cells[2].Value);
            }
        }

        private void btn_make_order_Click(object sender, EventArgs e)
        {
           try 
            {
                ordersTableAdapter.Insert(Convert.ToDouble(tb_total_orderPrice.Text), Convert.ToInt32(comboBox1.SelectedValue));

                temp = (int)ordersTableAdapter.GetLastOrderId();

                for (int i = 0; i < dgv_cart.Rows.Count; i++)
                {
                    list_ordTableAdapter.Insert(temp, (int)dgv_cart.Rows[i].Cells["№"].Value, (int)dgv_cart.Rows[i].Cells["Количество"].Value);
                }
            }
            catch (Exception ex) { };
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView3.Rows[e.RowIndex];
                selectedOrderId = Convert.ToInt32(selectedRow.Cells[0].Value);
            }

            using (MySqlConnection Connection = new MySqlConnection(Properties.Settings.Default.DBConnectionString))
            {
                try
                {
                    string query = "SELECT `id_menu` AS `Номер`, `amount` AS `Количество` FROM `2510`.`list_ord` WHERE `id_order` = @id";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, Connection);
                    MySqlCommandBuilder cb = new MySqlCommandBuilder(da);
                    cb.DataAdapter.SelectCommand.Parameters.Add("@id", MySqlDbType.Int32).Value = selectedOrderId;
                    DataTable table = new DataTable();
                    da.Fill(table);
                    dataGridView4.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tc_main_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage.Name == "tp_orders")
            {
                this.ordersTableAdapter.Fill(this.dBDataSet.orders);
            }
        }
    }
}
