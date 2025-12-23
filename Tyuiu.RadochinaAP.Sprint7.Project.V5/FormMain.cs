using Tyuiu.RadochinaAP.Sprint7.Project.V5.Lib;
namespace Tyuiu.RadochinaAP.Sprint7.Project.V5
{
    public partial class FormMain_RAP : Form
    {
        private DataService сервис_RAP = new DataService();
        private List<DataService.Товар_RAP> товары_RAP = new List<DataService.Товар_RAP>();
        private string текущийФайл_RAP = "";

        public FormMain_RAP()
        {
            InitializeComponent();

            // Настраиваем таблицу
            НастроитьТаблицу_RAP();

            // Показываем подсказку
            MessageBox.Show("Добро пожаловать! Нажмите 'Демо' для тестовых данных.",
                "Оптовая база", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void НастроитьТаблицу_RAP()
        {
            dataGridViewТовары_RAP.AutoGenerateColumns = false;
            dataGridViewТовары_RAP.Columns.Clear();

            // Колонки таблицы
            dataGridViewТовары_RAP.Columns.Add("Код_RAP", "Код");
            dataGridViewТовары_RAP.Columns["Код_RAP"].DataPropertyName = "Код_RAP";
            dataGridViewТовары_RAP.Columns["Код_RAP"].Width = 80;

            dataGridViewТовары_RAP.Columns.Add("Название_RAP", "Название");
            dataGridViewТовары_RAP.Columns["Название_RAP"].DataPropertyName = "Название_RAP";
            dataGridViewТовары_RAP.Columns["Название_RAP"].Width = 150;

            dataGridViewТовары_RAP.Columns.Add("Количество_RAP", "Количество");
            dataGridViewТовары_RAP.Columns["Количество_RAP"].DataPropertyName = "Количество_RAP";
            dataGridViewТовары_RAP.Columns["Количество_RAP"].Width = 90;

            dataGridViewТовары_RAP.Columns.Add("Цена_RAP", "Цена");
            dataGridViewТовары_RAP.Columns["Цена_RAP"].DataPropertyName = "Цена_RAP";
            dataGridViewТовары_RAP.Columns["Цена_RAP"].Width = 80;
            dataGridViewТовары_RAP.Columns["Цена_RAP"].DefaultCellStyle.Format = "C2";

            dataGridViewТовары_RAP.Columns.Add("Примечание_RAP", "Примечание");
            dataGridViewТовары_RAP.Columns["Примечание_RAP"].DataPropertyName = "Примечание_RAP";
            dataGridViewТовары_RAP.Columns["Примечание_RAP"].Width = 200;
        }

        private void ОбновитьТаблицу_RAP()
        {
            dataGridViewТовары_RAP.DataSource = null;
            dataGridViewТовары_RAP.DataSource = товары_RAP;
            ОбновитьСтатистику_RAP();
        }

        private void ОбновитьСтатистику_RAP()
        {
            string статистика_RAP = сервис_RAP.ПолучитьСтатистику_RAP(товары_RAP);
            labelСтатистика_RAP.Text = статистика_RAP;
        }

        // КНОПКА: Открыть файл
        private void buttonОткрыть_RAP_Click(object sender, EventArgs e)
        {
            OpenFileDialog диалог_RAP = new OpenFileDialog();
            диалог_RAP.Filter = "CSV файлы|*.csv|Все файлы|*.*";

            if (диалог_RAP.ShowDialog() == DialogResult.OK)
            {
                текущийФайл_RAP = диалог_RAP.FileName;
                товары_RAP = сервис_RAP.ПрочитатьCSV_RAP(текущийФайл_RAP);
                ОбновитьТаблицу_RAP();

                MessageBox.Show($"Загружено {товары_RAP.Count} товаров", "Успех");
            }
        }

        // КНОПКА: Сохранить файл
        private void buttonСохранить_RAP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(текущийФайл_RAP))
            {
                SaveFileDialog диалог_RAP = new SaveFileDialog();
                диалог_RAP.Filter = "CSV файлы|*.csv";
                диалог_RAP.FileName = "товары.csv";

                if (диалог_RAP.ShowDialog() == DialogResult.OK)
                    текущийФайл_RAP = диалог_RAP.FileName;
                else
                    return;
            }

            сервис_RAP.ЗаписатьCSV_RAP(текущийФайл_RAP, товары_RAP);
            MessageBox.Show($"Сохранено {товары_RAP.Count} товаров", "Успех");
        }

        // КНОПКА: Демо данные
        private void buttonДемо_RAP_Click(object sender, EventArgs e)
        {
            товары_RAP = сервис_RAP.СоздатьТестовыеДанные_RAP();
            ОбновитьТаблицу_RAP();
        }

        // КНОПКА: Добавить товар
        private void buttonДобавить_RAP_Click(object sender, EventArgs e)
        {
            // Простая форма для добавления
            using (Form ввод_RAP = new Form())
            {
                ввод_RAP.Text = "Новый товар";
                ввод_RAP.Size = new System.Drawing.Size(300, 250);

                TextBox полеКод_RAP = new TextBox { Location = new System.Drawing.Point(10, 30), Width = 260, Text = "П" + (товары_RAP.Count + 1).ToString("000") };
                TextBox полеНазвание_RAP = new TextBox { Location = new System.Drawing.Point(10, 70), Width = 260, Text = "Новый товар" };
                NumericUpDown полеКоличество_RAP = new NumericUpDown { Location = new System.Drawing.Point(10, 110), Width = 260, Minimum = 0, Maximum = 10000 };
                NumericUpDown полеЦена_RAP = new NumericUpDown { Location = new System.Drawing.Point(10, 150), Width = 260, Minimum = 0, Maximum = 1000000, DecimalPlaces = 2 };

                Button кнопкаОК_RAP = new Button { Text = "Добавить", Location = new System.Drawing.Point(10, 190), DialogResult = DialogResult.OK };
                Button кнопкаОтмена_RAP = new Button { Text = "Отмена", Location = new System.Drawing.Point(120, 190), DialogResult = DialogResult.Cancel };

                ввод_RAP.Controls.AddRange(new Control[] {
                    new Label { Text = "Код:", Location = new System.Drawing.Point(10, 10) },
                    полеКод_RAP,
                    new Label { Text = "Название:", Location = new System.Drawing.Point(10, 50) },
                    полеНазвание_RAP,
                    new Label { Text = "Количество:", Location = new System.Drawing.Point(10, 90) },
                    полеКоличество_RAP,
                    new Label { Text = "Цена:", Location = new System.Drawing.Point(10, 130) },
                    полеЦена_RAP,
                    кнопкаОК_RAP,
                    кнопкаОтмена_RAP
                });

                if (ввод_RAP.ShowDialog() == DialogResult.OK)
                {
                    товары_RAP.Add(new DataService.Товар_RAP
                    {
                        Код_RAP = полеКод_RAP.Text,
                        Название_RAP = полеНазвание_RAP.Text,
                        Количество_RAP = (int)полеКоличество_RAP.Value,
                        Цена_RAP = (decimal)полеЦена_RAP.Value,
                        Примечание_RAP = ""
                    });

                    ОбновитьТаблицу_RAP();
                }
            }
        }

        // КНОПКА: Удалить товар
        private void buttonУдалить_RAP_Click(object sender, EventArgs e)
        {
            if (dataGridViewТовары_RAP.CurrentRow != null)
            {
                var товар_RAP = (DataService.Товар_RAP)dataGridViewТовары_RAP.CurrentRow.DataBoundItem;

                if (MessageBox.Show($"Удалить товар {товар_RAP.Название_RAP}?",
                    "Подтверждение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    товары_RAP.Remove(товар_RAP);
                    ОбновитьТаблицу_RAP();
                }
            }
        }

        // ПОИСК: При изменении текста
        private void textBoxПоиск_RAP_TextChanged(object sender, EventArgs e)
        {
            var найденные_RAP = сервис_RAP.НайтиТовары_RAP(товары_RAP, textBoxПоиск_RAP.Text);
            dataGridViewТовары_RAP.DataSource = найденные_RAP;
        }

        // КНОПКА: О программе
        private void buttonОПрограмме_RAP_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Оптовая база товаров\n" +
                "Версия 1.0\n\n" +
                "Функции:\n" +
                "1. Загрузка/сохранение CSV\n" +
                "2. Просмотр товаров\n" +
                "3. Добавление/удаление\n" +
                "4. Поиск и статистика\n\n" +
                "Разработчик: Радочина А.П.\n" +
                "Вариант 5",
                "О программе");
        }
    }
}