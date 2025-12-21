namespace Tyuiu.RadochinaAP.Sprint7.Project.V5
{
    partial class FormMain
    {
        private void InitializeComponent()
        {
            this.richTextBoxCondition_PAA = new System.Windows.Forms.RichTextBox();
            this.richTextBoxCondition_PAA.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBoxCondition_PAA.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBoxCondition_PAA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxCondition_PAA.ForeColor = System.Drawing.Color.Black;
            this.richTextBoxCondition_PAA.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxCondition_PAA.Name = "richTextBoxCondition_PAA";
            this.richTextBoxCondition_PAA.ReadOnly = true;
            this.richTextBoxCondition_PAA.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxCondition_PAA.Size = new System.Drawing.Size(884, 150);
            this.richTextBoxCondition_PAA.TabIndex = 0;

            this.richTextBoxCondition_PAA.Text = "УСЛОВИЕ ЗАДАЧИ (Вариант 11):\n" +
                "--------------------------------------------------\n" +
                "Дан файл InPutFileTask7V11.csv в котором хранится матрица целочисленных значений.\n\n" +
                "ТРЕБОВАНИЯ:\n" +
                "1. Загрузить файл через диалоговое окно\n" +
                "2. Изменить в пятой строке матрицы все отрицательные числа на 9\n" +
                "3. Результат вывести в правую таблицу\n" +
                "4. Сохранить результат в CSV файл\n\n" +
                "ИСПОЛЬЗУЕМАЯ БИБЛИОТЕКА:\n" +
                "• DataService.GetMatrix(string path) - загрузка матрицы из файла\n\n" +
                "АЛГОРИТМ РАБОТЫ:\n" +
                "1. Нажмите 'Загрузить файл' → выберите CSV файл\n" +
                "2. Нажмите 'Преобразовать' → выполняется замена в 5-й строке\n" +
                "3. Нажмите 'Сохранить результат' → сохраняете изменения\n" +
                "4. Нажмите 'Справка' → информация о разработчике\n\n" +
                "ФОРМАТ ФАЙЛА:\n" +
                "• Разделитель - точка с запятой (;)\n" +
                "• Пример: 1;2;-3;4;5\n" +
                "      6;-7;8;9;-10";

            this.Controls.Add(this.richTextBoxCondition_PAA);
              
        }
         
        private System.Windows.Forms.RichTextBox richTextBoxCondition_PAA;
    }
}