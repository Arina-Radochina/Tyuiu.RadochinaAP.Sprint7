using Tyuiu.RadochinaAP.Sprint7.Project.V5.Lib;
namespace Tyuiu.RadochinaAP.Sprint7.Project.V5
{
    public partial class FormMain : Form
    {
        private DataService service = new DataService();
        private List<DataService.Product> products = new List<DataService.Product>();
        private string currentFile = "";

        public FormMain()
        {
            InitializeComponent();
            SetupGridView();

            toolTip.SetToolTip(buttonOpen_RAP, "Открыть CSV файл с товарами");
            toolTip.SetToolTip(buttonSave_RAP, "Сохранить товары в CSV файл");
            toolTip.SetToolTip(buttonDemo_RAP, "Загрузить тестовые данные");
            toolTip.SetToolTip(buttonAdd_RAP, "Добавить новый товар");
            toolTip.SetToolTip(buttonDelete_RAP, "Удалить выбранный товар");
            toolTip.SetToolTip(buttonSortName_RAP, "Сортировать по названию");
            toolTip.SetToolTip(buttonSortPrice_RAP, "Сортировать по цене");
            toolTip.SetToolTip(buttonFilter_RAP, "Показать только товары в наличии");
            toolTip.SetToolTip(buttonReset_RAP, "Сбросить фильтры");
            toolTip.SetToolTip(buttonHelp_RAP, "Открыть справку");
            toolTip.SetToolTip(buttonAbout_RAP, "О программе");

            statusLabel_RAP.Text = "Готов к работе. Нажмите 'Демо' для тестовых данных.";
        }

        private void SetupGridView()
        {
            dataGridView_RAP.AutoGenerateColumns = false;
            dataGridView_RAP.Columns.Clear();

            dataGridView_RAP.Columns.Add("colCode_RAP", "Код");
            dataGridView_RAP.Columns["colCode_RAP"].DataPropertyName = "Code";
            dataGridView_RAP.Columns["colCode_RAP"].Width = 80;

            dataGridView_RAP.Columns.Add("colName_RAP", "Название");
            dataGridView_RAP.Columns["colName_RAP"].DataPropertyName = "Name";
            dataGridView_RAP.Columns["colName_RAP"].Width = 150;

            dataGridView_RAP.Columns.Add("colQuantity_RAP", "Количество");
            dataGridView_RAP.Columns["colQuantity_RAP"].DataPropertyName = "Quantity";
            dataGridView_RAP.Columns["colQuantity_RAP"].Width = 90;

            dataGridView_RAP.Columns.Add("colPrice_RAP", "Цена");
            dataGridView_RAP.Columns["colPrice_RAP"].DataPropertyName = "Price";
            dataGridView_RAP.Columns["colPrice_RAP"].Width = 80;
            dataGridView_RAP.Columns["colPrice_RAP"].DefaultCellStyle.Format = "C2";

            dataGridView_RAP.Columns.Add("colTotal_RAP", "Сумма");
            dataGridView_RAP.Columns["colTotal_RAP"].DataPropertyName = "TotalValue";
            dataGridView_RAP.Columns["colTotal_RAP"].Width = 90;
            dataGridView_RAP.Columns["colTotal_RAP"].DefaultCellStyle.Format = "C2";

            dataGridView_RAP.Columns.Add("colNotes_RAP", "Примечание");
            dataGridView_RAP.Columns["colNotes_RAP"].DataPropertyName = "Notes";
            dataGridView_RAP.Columns["colNotes_RAP"].Width = 200;
        }

        private void UpdateGridView()
        {
            dataGridView_RAP.DataSource = null;
            dataGridView_RAP.DataSource = products;
            UpdateStatistics();
            UpdateStatus();
        }

        private void UpdateStatistics()
        {
            if (products.Count == 0)
            {
                labelCount_RAP.Text = "Товаров: 0";
                labelTotalValue_RAP.Text = "Общая стоимость: 0 ?";
                labelAvgPrice_RAP.Text = "Средняя цена: 0 ?";
                labelOutOfStock_RAP.Text = "Нет в наличии: 0";
                return;
            }

            var stats = service.GetStatistics(products);

            labelCount_RAP.Text = $"Товаров: {stats.count}";
            labelTotalValue_RAP.Text = $"Общая стоимость: {stats.totalValue:C}";
            labelAvgPrice_RAP.Text = $"Средняя цена: {stats.avgPrice:C}";
            labelOutOfStock_RAP.Text = $"Нет в наличии: {stats.outOfStock}";
        }

        private void UpdateStatus()
        {
            statusLabel_RAP.Text = $"Загружено {products.Count} товаров. " +
                                 $"Файл: {Path.GetFileName(currentFile) ?? "демо данные"}";
        }

        private void buttonOpen_RAP_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "CSV файлы|*.csv|Все файлы|*.*";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    currentFile = dialog.FileName;
                    products = service.LoadFromCSV(currentFile);
                    UpdateGridView();
                    MessageBox.Show($"Загружено {products.Count} товаров", "Успешно");
                }
            }
        }

        private void buttonSave_RAP_Click(object sender, EventArgs e)
        {
            if (products.Count == 0)
            {
                MessageBox.Show("Нет данных для сохранения", "Внимание");
                return;
            }

            if (string.IsNullOrEmpty(currentFile))
            {
                using (SaveFileDialog dialog = new SaveFileDialog())
                {
                    dialog.Filter = "CSV файлы|*.csv";
                    dialog.FileName = "products.csv";

                    if (dialog.ShowDialog() == DialogResult.OK)
                        currentFile = dialog.FileName;
                    else
                        return;
                }
            }

            service.SaveToCSV(currentFile, products);
            MessageBox.Show($"Сохранено {products.Count} товаров", "Успешно");
        }

        private void buttonDemo_RAP_Click(object sender, EventArgs e)
        {
            products = service.GetDemoData();
            currentFile = "";
            textBoxSearch_RAP.Text = "";
            UpdateGridView();
            MessageBox.Show("Загружены демонстрационные данные", "Демо");
        }

        private void buttonAdd_RAP_Click(object sender, EventArgs e)
        {
            using (Form addForm = new Form())
            {
                addForm.Text = "Добавить товар";
                addForm.Size = new System.Drawing.Size(300, 200);
                addForm.StartPosition = FormStartPosition.CenterParent;

                TextBox txtCode = new TextBox { Location = new System.Drawing.Point(100, 20), Width = 150 };
                TextBox txtName = new TextBox { Location = new System.Drawing.Point(100, 50), Width = 150 };
                NumericUpDown numQuantity = new NumericUpDown
                {
                    Location = new System.Drawing.Point(100, 80),
                    Width = 150,
                    Minimum = 0,
                    Maximum = 10000
                };
                NumericUpDown numPrice = new NumericUpDown
                {
                    Location = new System.Drawing.Point(100, 110),
                    Width = 150,
                    Minimum = 0,
                    Maximum = 1000000,
                    DecimalPlaces = 2
                };

                txtCode.Text = "P" + (products.Count + 101).ToString("000");

                Button btnOK = new Button
                {
                    Text = "Добавить",
                    Location = new System.Drawing.Point(80, 140),
                    DialogResult = DialogResult.OK
                };
                Button btnCancel = new Button
                {
                    Text = "Отмена",
                    Location = new System.Drawing.Point(170, 140),
                    DialogResult = DialogResult.Cancel
                };

                addForm.Controls.AddRange(new Control[] {
                    new Label { Text = "Код:", Location = new System.Drawing.Point(20, 23) },
                    txtCode,
                    new Label { Text = "Название:", Location = new System.Drawing.Point(20, 53) },
                    txtName,
                    new Label { Text = "Количество:", Location = new System.Drawing.Point(20, 83) },
                    numQuantity,
                    new Label { Text = "Цена:", Location = new System.Drawing.Point(20, 113) },
                    numPrice,
                    btnOK,
                    btnCancel
                });

                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    products.Add(new DataService.Product
                    {
                        Code = txtCode.Text,
                        Name = txtName.Text,
                        Quantity = (int)numQuantity.Value,
                        Price = numPrice.Value,
                        Notes = ""
                    });

                    UpdateGridView();
                }
            }
        }

        private void buttonDelete_RAP_Click(object sender, EventArgs e)
        {
            if (dataGridView_RAP.CurrentRow == null)
            {
                MessageBox.Show("Выберите товар для удаления", "Внимание");
                return;
            }

            var product = (DataService.Product)dataGridView_RAP.CurrentRow.DataBoundItem;

            if (MessageBox.Show($"Удалить товар '{product.Name}'?", "Подтверждение",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                products.Remove(product);
                UpdateGridView();
            }
        }

        private void buttonSortName_RAP_Click(object sender, EventArgs e)
        {
            products = service.SortByName(products);
            UpdateGridView();
        }

        private void buttonSortPrice_RAP_Click(object sender, EventArgs e)
        {
            products = service.SortByPrice(products);
            UpdateGridView();
        }

        private void buttonFilter_RAP_Click(object sender, EventArgs e)
        {
            var filtered = service.FilterInStock(products);
            dataGridView_RAP.DataSource = filtered;
            statusLabel_RAP.Text = $"Показано {filtered.Count} товаров (только в наличии)";
        }

        private void buttonReset_RAP_Click(object sender, EventArgs e)
        {
            textBoxSearch_RAP.Text = "";
            UpdateGridView();
        }

        private void textBoxSearch_RAP_TextChanged(object sender, EventArgs e)
        {
            var filtered = service.SearchProducts(products, textBoxSearch_RAP.Text);
            dataGridView_RAP.DataSource = filtered;
        }

        private void buttonHelp_RAP_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "=== РУКОВОДСТВО ПОЛЬЗОВАТЕЛЯ ===\n\n" +
                "1. Открыть - загрузить товары из CSV файла\n" +
                "2. Сохранить - сохранить в CSV файл\n" +
                "3. Демо - тестовые данные\n" +
                "4. Добавить - новый товар\n" +
                "5. Удалить - выбранный товар\n" +
                "6. Сортировка - по названию или цене\n" +
                "7. Поиск - по коду или названию\n" +
                "8. Фильтр - только в наличии\n\n" +
                "Формат CSV: Code;Name;Quantity;Price;Notes",
                "Справка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void buttonAbout_RAP_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Оптовая база - Управление товарами\n" +
                "Вариант 5\n\n" +
                "Разработчик: Радочина А.П.\n" +
                "Проект: Sprint7.Project.V5\n\n" +
                "Все права защищены, 2025",
                "О программе",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void buttonExit_RAP_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}