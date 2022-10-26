
namespace WindowsFormsApp4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tc_main = new System.Windows.Forms.TabControl();
            this.tp_workers = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_add_worker = new System.Windows.Forms.Button();
            this.cb_pos_worker = new System.Windows.Forms.ComboBox();
            this.positionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBDataSet = new WindowsFormsApp4.DBDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_name_worker = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idworkerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fioworkerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionworkerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tp_menu = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_menu_price = new System.Windows.Forms.TextBox();
            this.btn_menu_add = new System.Windows.Forms.Button();
            this.cb_menu_type = new System.Windows.Forms.ComboBox();
            this.typesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_menu_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idmenuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namemenuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costmenuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typemenuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tp_makeOrder = new System.Windows.Forms.TabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_make_order = new System.Windows.Forms.Button();
            this.tb_total_orderPrice = new System.Windows.Forms.TextBox();
            this.lb_total = new System.Windows.Forms.Label();
            this.dgv_cart = new System.Windows.Forms.DataGridView();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.idmenuDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namemenuDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costmenuDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typemenuDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_add_cart = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tp_orders = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.idorderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalorderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerorderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.workersTableAdapter = new WindowsFormsApp4.DBDataSetTableAdapters.workersTableAdapter();
            this.menuTableAdapter = new WindowsFormsApp4.DBDataSetTableAdapters.menuTableAdapter();
            this.positionsTableAdapter = new WindowsFormsApp4.DBDataSetTableAdapters.positionsTableAdapter();
            this.typesTableAdapter = new WindowsFormsApp4.DBDataSetTableAdapters.typesTableAdapter();
            this.ordersTableAdapter = new WindowsFormsApp4.DBDataSetTableAdapters.ordersTableAdapter();
            this.listordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.list_ordTableAdapter = new WindowsFormsApp4.DBDataSetTableAdapters.list_ordTableAdapter();
            this.panel1.SuspendLayout();
            this.tc_main.SuspendLayout();
            this.tp_workers.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.positionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).BeginInit();
            this.tp_menu.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).BeginInit();
            this.tp_makeOrder.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cart)).BeginInit();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.tp_orders.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listordBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tc_main);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // tc_main
            // 
            this.tc_main.Controls.Add(this.tp_workers);
            this.tc_main.Controls.Add(this.tp_menu);
            this.tc_main.Controls.Add(this.tp_makeOrder);
            this.tc_main.Controls.Add(this.tp_orders);
            this.tc_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_main.Location = new System.Drawing.Point(0, 0);
            this.tc_main.Name = "tc_main";
            this.tc_main.SelectedIndex = 0;
            this.tc_main.Size = new System.Drawing.Size(800, 450);
            this.tc_main.TabIndex = 0;
            this.tc_main.Selected += new System.Windows.Forms.TabControlEventHandler(this.tc_main_Selected);
            // 
            // tp_workers
            // 
            this.tp_workers.Controls.Add(this.panel2);
            this.tp_workers.Location = new System.Drawing.Point(4, 25);
            this.tp_workers.Name = "tp_workers";
            this.tp_workers.Padding = new System.Windows.Forms.Padding(3);
            this.tp_workers.Size = new System.Drawing.Size(792, 421);
            this.tp_workers.TabIndex = 0;
            this.tp_workers.Text = "Сотрудники";
            this.tp_workers.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(786, 415);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_add_worker);
            this.panel3.Controls.Add(this.cb_pos_worker);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.tb_name_worker);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(606, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 415);
            this.panel3.TabIndex = 1;
            // 
            // btn_add_worker
            // 
            this.btn_add_worker.Location = new System.Drawing.Point(6, 374);
            this.btn_add_worker.Name = "btn_add_worker";
            this.btn_add_worker.Size = new System.Drawing.Size(169, 36);
            this.btn_add_worker.TabIndex = 5;
            this.btn_add_worker.Text = "Добавить";
            this.btn_add_worker.UseVisualStyleBackColor = true;
            this.btn_add_worker.Click += new System.EventHandler(this.btn_add_worker_Click);
            // 
            // cb_pos_worker
            // 
            this.cb_pos_worker.DataSource = this.positionsBindingSource;
            this.cb_pos_worker.DisplayMember = "name_position";
            this.cb_pos_worker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_pos_worker.FormattingEnabled = true;
            this.cb_pos_worker.Location = new System.Drawing.Point(6, 127);
            this.cb_pos_worker.Name = "cb_pos_worker";
            this.cb_pos_worker.Size = new System.Drawing.Size(163, 24);
            this.cb_pos_worker.TabIndex = 4;
            this.cb_pos_worker.ValueMember = "id_position";
            // 
            // positionsBindingSource
            // 
            this.positionsBindingSource.DataMember = "positions";
            this.positionsBindingSource.DataSource = this.dBDataSet;
            // 
            // dBDataSet
            // 
            this.dBDataSet.DataSetName = "DBDataSet";
            this.dBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Должность";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "ФИО";
            // 
            // tb_name_worker
            // 
            this.tb_name_worker.Location = new System.Drawing.Point(6, 68);
            this.tb_name_worker.Name = "tb_name_worker";
            this.tb_name_worker.Size = new System.Drawing.Size(163, 22);
            this.tb_name_worker.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавить сотрудника";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idworkerDataGridViewTextBoxColumn,
            this.fioworkerDataGridViewTextBoxColumn,
            this.positionworkerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.workersBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(606, 415);
            this.dataGridView1.TabIndex = 0;
            // 
            // idworkerDataGridViewTextBoxColumn
            // 
            this.idworkerDataGridViewTextBoxColumn.DataPropertyName = "id_worker";
            this.idworkerDataGridViewTextBoxColumn.HeaderText = "Идентификатор";
            this.idworkerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idworkerDataGridViewTextBoxColumn.Name = "idworkerDataGridViewTextBoxColumn";
            this.idworkerDataGridViewTextBoxColumn.Width = 143;
            // 
            // fioworkerDataGridViewTextBoxColumn
            // 
            this.fioworkerDataGridViewTextBoxColumn.DataPropertyName = "fio_worker";
            this.fioworkerDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fioworkerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fioworkerDataGridViewTextBoxColumn.Name = "fioworkerDataGridViewTextBoxColumn";
            this.fioworkerDataGridViewTextBoxColumn.Width = 71;
            // 
            // positionworkerDataGridViewTextBoxColumn
            // 
            this.positionworkerDataGridViewTextBoxColumn.DataPropertyName = "position_worker";
            this.positionworkerDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.positionworkerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.positionworkerDataGridViewTextBoxColumn.Name = "positionworkerDataGridViewTextBoxColumn";
            this.positionworkerDataGridViewTextBoxColumn.Width = 110;
            // 
            // workersBindingSource
            // 
            this.workersBindingSource.DataMember = "workers";
            this.workersBindingSource.DataSource = this.dBDataSet;
            // 
            // tp_menu
            // 
            this.tp_menu.Controls.Add(this.panel4);
            this.tp_menu.Controls.Add(this.dataGridView2);
            this.tp_menu.Location = new System.Drawing.Point(4, 25);
            this.tp_menu.Name = "tp_menu";
            this.tp_menu.Padding = new System.Windows.Forms.Padding(3);
            this.tp_menu.Size = new System.Drawing.Size(792, 421);
            this.tp_menu.TabIndex = 1;
            this.tp_menu.Text = "Меню";
            this.tp_menu.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.tb_menu_price);
            this.panel4.Controls.Add(this.btn_menu_add);
            this.panel4.Controls.Add(this.cb_menu_type);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.tb_menu_name);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(609, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(180, 415);
            this.panel4.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Цена";
            // 
            // tb_menu_price
            // 
            this.tb_menu_price.Location = new System.Drawing.Point(6, 117);
            this.tb_menu_price.Name = "tb_menu_price";
            this.tb_menu_price.Size = new System.Drawing.Size(163, 22);
            this.tb_menu_price.TabIndex = 6;
            // 
            // btn_menu_add
            // 
            this.btn_menu_add.Location = new System.Drawing.Point(6, 374);
            this.btn_menu_add.Name = "btn_menu_add";
            this.btn_menu_add.Size = new System.Drawing.Size(169, 36);
            this.btn_menu_add.TabIndex = 5;
            this.btn_menu_add.Text = "Добавить";
            this.btn_menu_add.UseVisualStyleBackColor = true;
            this.btn_menu_add.Click += new System.EventHandler(this.btn_menu_add_Click);
            // 
            // cb_menu_type
            // 
            this.cb_menu_type.DataSource = this.typesBindingSource;
            this.cb_menu_type.DisplayMember = "name_type";
            this.cb_menu_type.FormattingEnabled = true;
            this.cb_menu_type.Location = new System.Drawing.Point(6, 168);
            this.cb_menu_type.Name = "cb_menu_type";
            this.cb_menu_type.Size = new System.Drawing.Size(163, 24);
            this.cb_menu_type.TabIndex = 4;
            this.cb_menu_type.ValueMember = "id_type";
            // 
            // typesBindingSource
            // 
            this.typesBindingSource.DataMember = "types";
            this.typesBindingSource.DataSource = this.dBDataSet;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Тип";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Название";
            // 
            // tb_menu_name
            // 
            this.tb_menu_name.Location = new System.Drawing.Point(6, 68);
            this.tb_menu_name.Name = "tb_menu_name";
            this.tb_menu_name.Size = new System.Drawing.Size(163, 22);
            this.tb_menu_name.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Добавить блюдо";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idmenuDataGridViewTextBoxColumn,
            this.namemenuDataGridViewTextBoxColumn,
            this.costmenuDataGridViewTextBoxColumn,
            this.typemenuDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.menuBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(606, 415);
            this.dataGridView2.TabIndex = 1;
            // 
            // idmenuDataGridViewTextBoxColumn
            // 
            this.idmenuDataGridViewTextBoxColumn.DataPropertyName = "id_menu";
            this.idmenuDataGridViewTextBoxColumn.HeaderText = "#";
            this.idmenuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idmenuDataGridViewTextBoxColumn.Name = "idmenuDataGridViewTextBoxColumn";
            this.idmenuDataGridViewTextBoxColumn.Visible = false;
            this.idmenuDataGridViewTextBoxColumn.Width = 22;
            // 
            // namemenuDataGridViewTextBoxColumn
            // 
            this.namemenuDataGridViewTextBoxColumn.DataPropertyName = "name_menu";
            this.namemenuDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.namemenuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namemenuDataGridViewTextBoxColumn.Name = "namemenuDataGridViewTextBoxColumn";
            this.namemenuDataGridViewTextBoxColumn.Width = 135;
            // 
            // costmenuDataGridViewTextBoxColumn
            // 
            this.costmenuDataGridViewTextBoxColumn.DataPropertyName = "cost_menu";
            this.costmenuDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.costmenuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costmenuDataGridViewTextBoxColumn.Name = "costmenuDataGridViewTextBoxColumn";
            this.costmenuDataGridViewTextBoxColumn.Width = 72;
            // 
            // typemenuDataGridViewTextBoxColumn
            // 
            this.typemenuDataGridViewTextBoxColumn.DataPropertyName = "type_menu";
            this.typemenuDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.typemenuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typemenuDataGridViewTextBoxColumn.Name = "typemenuDataGridViewTextBoxColumn";
            this.typemenuDataGridViewTextBoxColumn.Width = 62;
            // 
            // menuBindingSource
            // 
            this.menuBindingSource.DataMember = "menu";
            this.menuBindingSource.DataSource = this.dBDataSet;
            // 
            // tp_makeOrder
            // 
            this.tp_makeOrder.Controls.Add(this.panel8);
            this.tp_makeOrder.Location = new System.Drawing.Point(4, 25);
            this.tp_makeOrder.Name = "tp_makeOrder";
            this.tp_makeOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tp_makeOrder.Size = new System.Drawing.Size(792, 421);
            this.tp_makeOrder.TabIndex = 3;
            this.tp_makeOrder.Text = "Сделать заказ";
            this.tp_makeOrder.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.comboBox1);
            this.panel8.Controls.Add(this.btn_make_order);
            this.panel8.Controls.Add(this.tb_total_orderPrice);
            this.panel8.Controls.Add(this.lb_total);
            this.panel8.Controls.Add(this.dgv_cart);
            this.panel8.Controls.Add(this.panel11);
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(786, 415);
            this.panel8.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.workersBindingSource;
            this.comboBox1.DisplayMember = "fio_worker";
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(388, 348);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(398, 24);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.ValueMember = "id_worker";
            // 
            // btn_make_order
            // 
            this.btn_make_order.Location = new System.Drawing.Point(628, 375);
            this.btn_make_order.Name = "btn_make_order";
            this.btn_make_order.Size = new System.Drawing.Size(158, 37);
            this.btn_make_order.TabIndex = 6;
            this.btn_make_order.Text = "Оформить заказ";
            this.btn_make_order.UseVisualStyleBackColor = true;
            this.btn_make_order.Click += new System.EventHandler(this.btn_make_order_Click);
            // 
            // tb_total_orderPrice
            // 
            this.tb_total_orderPrice.Location = new System.Drawing.Point(446, 382);
            this.tb_total_orderPrice.Name = "tb_total_orderPrice";
            this.tb_total_orderPrice.ReadOnly = true;
            this.tb_total_orderPrice.Size = new System.Drawing.Size(100, 22);
            this.tb_total_orderPrice.TabIndex = 5;
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.Location = new System.Drawing.Point(394, 382);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(46, 17);
            this.lb_total.TabIndex = 4;
            this.lb_total.Text = "Итого";
            // 
            // dgv_cart
            // 
            this.dgv_cart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_cart.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cart.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_cart.Location = new System.Drawing.Point(388, 23);
            this.dgv_cart.Name = "dgv_cart";
            this.dgv_cart.RowHeadersVisible = false;
            this.dgv_cart.RowHeadersWidth = 51;
            this.dgv_cart.RowTemplate.Height = 24;
            this.dgv_cart.Size = new System.Drawing.Size(398, 325);
            this.dgv_cart.TabIndex = 3;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label11);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(388, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(398, 23);
            this.panel11.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(178, 2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Корзина";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.textBox1);
            this.panel10.Controls.Add(this.dataGridView5);
            this.panel10.Controls.Add(this.btn_add_cart);
            this.panel10.Controls.Add(this.label10);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(388, 415);
            this.panel10.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(6, 378);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(59, 34);
            this.textBox1.TabIndex = 4;
            // 
            // dataGridView5
            // 
            this.dataGridView5.AutoGenerateColumns = false;
            this.dataGridView5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView5.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView5.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idmenuDataGridViewTextBoxColumn1,
            this.namemenuDataGridViewTextBoxColumn1,
            this.costmenuDataGridViewTextBoxColumn1,
            this.typemenuDataGridViewTextBoxColumn1});
            this.dataGridView5.DataSource = this.menuBindingSource;
            this.dataGridView5.Location = new System.Drawing.Point(0, 23);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersVisible = false;
            this.dataGridView5.RowHeadersWidth = 51;
            this.dataGridView5.RowTemplate.Height = 24;
            this.dataGridView5.Size = new System.Drawing.Size(388, 346);
            this.dataGridView5.TabIndex = 3;
            this.dataGridView5.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView5_CellClick);
            // 
            // idmenuDataGridViewTextBoxColumn1
            // 
            this.idmenuDataGridViewTextBoxColumn1.DataPropertyName = "id_menu";
            this.idmenuDataGridViewTextBoxColumn1.HeaderText = "#";
            this.idmenuDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idmenuDataGridViewTextBoxColumn1.Name = "idmenuDataGridViewTextBoxColumn1";
            this.idmenuDataGridViewTextBoxColumn1.Visible = false;
            // 
            // namemenuDataGridViewTextBoxColumn1
            // 
            this.namemenuDataGridViewTextBoxColumn1.DataPropertyName = "name_menu";
            this.namemenuDataGridViewTextBoxColumn1.HeaderText = "Наименование";
            this.namemenuDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.namemenuDataGridViewTextBoxColumn1.Name = "namemenuDataGridViewTextBoxColumn1";
            // 
            // costmenuDataGridViewTextBoxColumn1
            // 
            this.costmenuDataGridViewTextBoxColumn1.DataPropertyName = "cost_menu";
            this.costmenuDataGridViewTextBoxColumn1.HeaderText = "Цена";
            this.costmenuDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.costmenuDataGridViewTextBoxColumn1.Name = "costmenuDataGridViewTextBoxColumn1";
            // 
            // typemenuDataGridViewTextBoxColumn1
            // 
            this.typemenuDataGridViewTextBoxColumn1.DataPropertyName = "type_menu";
            this.typemenuDataGridViewTextBoxColumn1.HeaderText = "type_menu";
            this.typemenuDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.typemenuDataGridViewTextBoxColumn1.Name = "typemenuDataGridViewTextBoxColumn1";
            this.typemenuDataGridViewTextBoxColumn1.Visible = false;
            // 
            // btn_add_cart
            // 
            this.btn_add_cart.Location = new System.Drawing.Point(71, 375);
            this.btn_add_cart.Name = "btn_add_cart";
            this.btn_add_cart.Size = new System.Drawing.Size(317, 40);
            this.btn_add_cart.TabIndex = 2;
            this.btn_add_cart.Text = "В корзину";
            this.btn_add_cart.UseVisualStyleBackColor = true;
            this.btn_add_cart.Click += new System.EventHandler(this.btn_add_cart_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(158, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Меню";
            // 
            // tp_orders
            // 
            this.tp_orders.Controls.Add(this.panel5);
            this.tp_orders.Location = new System.Drawing.Point(4, 25);
            this.tp_orders.Name = "tp_orders";
            this.tp_orders.Size = new System.Drawing.Size(792, 421);
            this.tp_orders.TabIndex = 2;
            this.tp_orders.Text = "История заказов";
            this.tp_orders.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dataGridView4);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.dataGridView3);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(792, 421);
            this.panel5.TabIndex = 0;
            // 
            // dataGridView4
            // 
            this.dataGridView4.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(411, 17);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersVisible = false;
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(381, 404);
            this.dataGridView4.TabIndex = 3;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(392, 17);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(19, 404);
            this.panel7.TabIndex = 2;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idorderDataGridViewTextBoxColumn,
            this.totalorderDataGridViewTextBoxColumn,
            this.workerorderDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.ordersBindingSource;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView3.Location = new System.Drawing.Point(0, 17);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(392, 404);
            this.dataGridView3.TabIndex = 0;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellClick);
            // 
            // idorderDataGridViewTextBoxColumn
            // 
            this.idorderDataGridViewTextBoxColumn.DataPropertyName = "id_order";
            this.idorderDataGridViewTextBoxColumn.HeaderText = "id_order";
            this.idorderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idorderDataGridViewTextBoxColumn.Name = "idorderDataGridViewTextBoxColumn";
            this.idorderDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalorderDataGridViewTextBoxColumn
            // 
            this.totalorderDataGridViewTextBoxColumn.DataPropertyName = "total_order";
            this.totalorderDataGridViewTextBoxColumn.HeaderText = "total_order";
            this.totalorderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalorderDataGridViewTextBoxColumn.Name = "totalorderDataGridViewTextBoxColumn";
            this.totalorderDataGridViewTextBoxColumn.Width = 125;
            // 
            // workerorderDataGridViewTextBoxColumn
            // 
            this.workerorderDataGridViewTextBoxColumn.DataPropertyName = "worker_order";
            this.workerorderDataGridViewTextBoxColumn.HeaderText = "worker_order";
            this.workerorderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.workerorderDataGridViewTextBoxColumn.Name = "workerorderDataGridViewTextBoxColumn";
            this.workerorderDataGridViewTextBoxColumn.Width = 125;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "orders";
            this.ordersBindingSource.DataSource = this.dBDataSet;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(792, 17);
            this.panel6.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(554, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 17);
            this.label9.TabIndex = 1;
            this.label9.Text = "Детали заказа";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(167, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Заказы";
            // 
            // workersTableAdapter
            // 
            this.workersTableAdapter.ClearBeforeFill = true;
            // 
            // menuTableAdapter
            // 
            this.menuTableAdapter.ClearBeforeFill = true;
            // 
            // positionsTableAdapter
            // 
            this.positionsTableAdapter.ClearBeforeFill = true;
            // 
            // typesTableAdapter
            // 
            this.typesTableAdapter.ClearBeforeFill = true;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // listordBindingSource
            // 
            this.listordBindingSource.DataMember = "list_ord";
            this.listordBindingSource.DataSource = this.dBDataSet;
            // 
            // list_ordTableAdapter
            // 
            this.list_ordTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Управление кафе";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.tc_main.ResumeLayout(false);
            this.tp_workers.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.positionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersBindingSource)).EndInit();
            this.tp_menu.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBindingSource)).EndInit();
            this.tp_makeOrder.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cart)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.tp_orders.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listordBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tc_main;
        private System.Windows.Forms.TabPage tp_workers;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cb_pos_worker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_name_worker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tp_menu;
        private System.Windows.Forms.TabPage tp_orders;
        private System.Windows.Forms.Button btn_add_worker;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_menu_add;
        private System.Windows.Forms.ComboBox cb_menu_type;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_menu_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_menu_price;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tp_makeOrder;
        private DBDataSet dBDataSet;
        private System.Windows.Forms.BindingSource workersBindingSource;
        private DBDataSetTableAdapters.workersTableAdapter workersTableAdapter;
        private System.Windows.Forms.BindingSource menuBindingSource;
        private DBDataSetTableAdapters.menuTableAdapter menuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idworkerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioworkerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionworkerDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource positionsBindingSource;
        private DBDataSetTableAdapters.positionsTableAdapter positionsTableAdapter;
        private System.Windows.Forms.BindingSource typesBindingSource;
        private DBDataSetTableAdapters.typesTableAdapter typesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmenuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namemenuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costmenuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typemenuDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btn_make_order;
        private System.Windows.Forms.TextBox tb_total_orderPrice;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.DataGridView dgv_cart;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.Button btn_add_cart;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmenuDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn namemenuDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn costmenuDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn typemenuDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private DBDataSetTableAdapters.ordersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idorderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalorderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerorderDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource listordBindingSource;
        private DBDataSetTableAdapters.list_ordTableAdapter list_ordTableAdapter;
    }
}

