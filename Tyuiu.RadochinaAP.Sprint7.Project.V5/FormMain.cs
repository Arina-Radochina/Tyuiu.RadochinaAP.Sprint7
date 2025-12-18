using Tyuiu.RadochinaAP.Sprint7.Project.V5.Lib;
namespace Tyuiu.RadochinaAP.Sprint7.Project.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            SetConditionText();
        }

        private void SetConditionText()
        {
            // Очищаем старый текст
            richTextBoxCondition_PAA.Clear();

            // Добавляем форматированный текст
            richTextBoxCondition_PAA.AppendText("УСЛОВИЕ ЗАДАЧИ (Вариант 11):\n");
            richTextBoxCondition_PAA.AppendText("--------------------------------------------------\n");
            richTextBoxCondition_PAA.AppendText("Дан файл InPutFileTask7V11.csv в котором хранится матрица целочисленных значений.\n\n");

            richTextBoxCondition_PAA.AppendText("ТРЕБОВАНИЯ:\n");
            richTextBoxCondition_PAA.AppendText("1. Загрузить файл через диалоговое окно\n");
            richTextBoxCondition_PAA.AppendText("2. Изменить в пятой строке матрицы все отрицательные числа на 9\n");
            richTextBoxCondition_PAA.AppendText("3. Результат вывести в правую таблицу\n");
            richTextBoxCondition_PAA.AppendText("4. Сохранить результат в CSV файл\n\n");

            richTextBoxCondition_PAA.AppendText("ИСПОЛЬЗУЕМАЯ БИБЛИОТЕКА:\n");
            richTextBoxCondition_PAA.AppendText("• DataService.GetMatrix(string path) - загрузка матрицы из файла\n\n");

            richTextBoxCondition_PAA.AppendText("АЛГОРИТМ РАБОТЫ:\n");
            richTextBoxCondition_PAA.AppendText("1. Нажмите 'Загрузить файл' ? выберите CSV файл\n");
            richTextBoxCondition_PAA.AppendText("2. Нажмите 'Преобразовать' ? выполняется замена в 5-й строке\n");
            richTextBoxCondition_PAA.AppendText("3. Нажмите 'Сохранить результат' ? сохраняете изменения\n");
            richTextBoxCondition_PAA.AppendText("4. Нажмите 'Справка' ? информация о разработчике\n\n");

            richTextBoxCondition_PAA.AppendText("ФОРМАТ ФАЙЛА:\n");
            richTextBoxCondition_PAA.AppendText("• Разделитель - точка с запятой (;)\n");
            richTextBoxCondition_PAA.AppendText("• Пример: 1;2;-3;4;5\n");
            richTextBoxCondition_PAA.AppendText("      6;-7;8;9;-10");
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // Если нужно что-то выполнить при загрузке формы
            // Оставьте пустым или добавьте другую логику
        }
    }
}
       