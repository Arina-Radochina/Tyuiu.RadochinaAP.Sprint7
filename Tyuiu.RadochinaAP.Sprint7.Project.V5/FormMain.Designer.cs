namespace Tyuiu.RadochinaAP.Sprint7.Project.V5
{
    partial class FormMain_RAP
    {
        private System.ComponentModel.IContainer components = null;

        // Элементы формы
        private DataGridView dataGridViewТовары_RAP;
        private Label labelСтатистика_RAP;
        private TextBox textBoxПоиск_RAP;

        private Button buttonОткрыть_RAP;
        private Button buttonСохранить_RAP;
        private Button buttonДемо_RAP;
        private Button buttonДобавить_RAP;
        private Button buttonУдалить_RAP;
        private Button buttonОПрограмме_RAP;

        private Label labelПоиск_RAP;
        private Label labelИнфо_RAP;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_RAP));
            this.dataGridViewТовары_RAP = new System.Windows.Forms.DataGridView();
            this.labelСтатистика_RAP = new System.Windows.Forms.Label();
            this.textBoxПоиск_RAP = new System.Windows.Forms.TextBox();
            this.buttonОткрыть_RAP = new System.Windows.Forms.Button();
            this.buttonСохранить_RAP = new System.Windows.Forms.Button();
            this.buttonДемо_RAP = new System.Windows.Forms.Button();
            this.buttonДобавить_RAP = new System.Windows.Forms.Button();
            this.buttonУдалить_RAP = new System.Windows.Forms.Button();
            this.buttonОПрограмме_RAP = new System.Windows.Forms.Button();
            this.labelПоиск_RAP = new System.Windows.Forms.Label();
            this.labelИнфо_RAP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewТовары_RAP)).BeginInit();
            this.SuspendLayout();

            // dataGridViewТовары_RAP
            this.dataGridViewТовары_RAP.AllowUserToAddRows = false;
            this.dataGridViewТовары_RAP.AllowUserToDeleteRows = false;
            this.dataGridViewТовары_RAP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewТовары_RAP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewТовары_RAP.Location = new System.Drawing.Point(12, 40);
            this.dataGridViewТовары_RAP.Name = "dataGridViewТовары_RAP";
            this.dataGridViewТовары_RAP.ReadOnly = true;
            this.dataGridViewТовары_RAP.RowHeadersWidth = 62;
            this.dataGridViewТовары_RAP.RowTemplate.Height = 28;
            this.dataGridViewТовары_RAP.Size = new System.Drawing.Size(700, 400);
            this.dataGridViewТовары_RAP.TabIndex = 0;

            // labelСтатистика_RAP
            this.labelСтатистика_RAP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelСтатистика_RAP.AutoSize = true;
            this.labelСтатистика_RAP.Location = new System.Drawing.Point(720, 40);
            this.labelСтатистика_RAP.MaximumSize = new System.Drawing.Size(250, 0);
            this.labelСтатистика_RAP.Name = "labelСтатистика_RAP";
            this.labelСтатистика_RAP.Size = new System.Drawing.Size(250, 120);
            this.labelСтатистика_RAP.TabIndex = 1;
            this.labelСтатистика_RAP.Text = "Статистика появится здесь";

            // textBoxПоиск_RAP
            this.textBoxПоиск_RAP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxПоиск_RAP.Location = new System.Drawing.Point(720, 200);
            this.textBoxПоиск_RAP.Name = "textBoxПоиск_RAP";
            this.textBoxПоиск_RAP.Size = new System.Drawing.Size(250, 26);
            this.textBoxПоиск_RAP.TabIndex = 2;
            this.textBoxПоиск_RAP.TextChanged += new System.EventHandler(this.textBoxПоиск_RAP_TextChanged);

            // buttonОткрыть_RAP
            this.buttonОткрыть_RAP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonОткрыть_RAP.Location = new System.Drawing.Point(12, 450);
            this.buttonОткрыть_RAP.Name = "buttonОткрыть_RAP";
            this.buttonОткрыть_RAP.Size = new System.Drawing.Size(120, 40);
            this.buttonОткрыть_RAP.TabIndex = 3;
            this.buttonОткрыть_RAP.Text = "Открыть CSV";
            this.buttonОткрыть_RAP.UseVisualStyleBackColor = true;
            this.buttonОткрыть_RAP.Click += new System.EventHandler(this.buttonОткрыть_RAP_Click);

            // buttonСохранить_RAP
            this.buttonСохранить_RAP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonСохранить_RAP.Location = new System.Drawing.Point(140, 450);
            this.buttonСохранить_RAP.Name = "buttonСохранить_RAP";
            this.buttonСохранить_RAP.Size = new System.Drawing.Size(120, 40);
            this.buttonСохранить_RAP.TabIndex = 4;
            this.buttonСохранить_RAP.Text = "Сохранить CSV";
            this.buttonСохранить_RAP.UseVisualStyleBackColor = true;
            this.buttonСохранить_RAP.Click += new System.EventHandler(this.buttonСохранить_RAP_Click);

            // buttonДемо_RAP
            this.buttonДемо_RAP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonДемо_RAP.Location = new System.Drawing.Point(268, 450);
            this.buttonДемо_RAP.Name = "buttonДемо_RAP";
            this.buttonДемо_RAP.Size = new System.Drawing.Size(120, 40);
            this.buttonДемо_RAP.TabIndex = 5;
            this.buttonДемо_RAP.Text = "Демо данные";
            this.buttonДемо_RAP.UseVisualStyleBackColor = true;
            this.buttonДемо_RAP.Click += new System.EventHandler(this.buttonДемо_RAP_Click);

            // buttonДобавить_RAP
            this.buttonДобавить_RAP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonДобавить_RAP.Location = new System.Drawing.Point(396, 450);
            this.buttonДобавить_RAP.Name = "buttonДобавить_RAP";
            this.buttonДобавить_RAP.Size = new System.Drawing.Size(120, 40);
            this.buttonДобавить_RAP.TabIndex = 6;
            this.buttonДобавить_RAP.Text = "Добавить товар";
            this.buttonДобавить_RAP.UseVisualStyleBackColor = true;
            this.buttonДобавить_RAP.Click += new System.EventHandler(this.buttonДобавить_RAP_Click);

            // buttonУдалить_RAP
            this.buttonУдалить_RAP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonУдалить_RAP.Location = new System.Drawing.Point(524, 450);
            this.buttonУдалить_RAP.Name = "buttonУдалить_RAP";
            this.buttonУдалить_RAP.Size = new System.Drawing.Size(120, 40);
            this.buttonУдалить_RAP.TabIndex = 7;
            this.buttonУдалить_RAP.Text = "Удалить товар";
            this.buttonУдалить_RAP.UseVisualStyleBackColor = true;
            this.buttonУдалить_RAP.Click += new System.EventHandler(this.buttonУдалить_RAP_Click);

            // buttonОПрограмме_RAP
            this.buttonОПрограмме_RAP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonОПрограмме_RAP.Location = new System.Drawing.Point(720, 450);
            this.buttonОПрограмме_RAP.Name = "buttonОПрограмме_RAP";
            this.buttonОПрограмме_RAP.Size = new System.Drawing.Size(250, 40);
            this.buttonОПрограмме_RAP.TabIndex = 8;
            this.buttonОПрограмме_RAP.Text = "О программе";
            this.buttonОПрограмме_RAP.UseVisualStyleBackColor = true;
            this.buttonОПрограмме_RAP.Click += new System.EventHandler(this.buttonОПрограмме_RAP_Click);

            // labelПоиск_RAP
            this.labelПоиск_RAP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelПоиск_RAP.AutoSize = true;
            this.labelПоиск_RAP.Location = new System.Drawing.Point(720, 170);
            this.labelПоиск_RAP.Name = "labelПоиск_RAP";
            this.labelПоиск_RAP.Size = new System.Drawing.Size(186, 20);
            this.labelПоиск_RAP.TabIndex = 9;
            this.labelПоиск_RAP.Text = "Поиск по названию/коду:";

            // labelИнфо_RAP
            this.labelИнфо_RAP.AutoSize = true;
            this.labelИнфо_RAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelИнфо_RAP.Location = new System.Drawing.Point(12, 9);
            this.labelИнфо_RAP.Name = "labelИнфо_RAP";
            this.labelИнфо_RAP.Size = new System.Drawing.Size(287, 25);
            this.labelИнфо_RAP.TabIndex = 10;
            this.labelИнфо_RAP.Text = "Оптовая база - Управление товарами";

            // FormMain_RAP
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 503);
            this.Controls.Add(this.labelИнфо_RAP);
            this.Controls.Add(this.labelПоиск_RAP);
            this.Controls.Add(this.buttonОПрограмме_RAP);
            this.Controls.Add(this.buttonУдалить_RAP);
            this.Controls.Add(this.buttonДобавить_RAP);
            this.Controls.Add(this.buttonДемо_RAP);
            this.Controls.Add(this.buttonСохранить_RAP);
            this.Controls.Add(this.buttonОткрыть_RAP);
            this.Controls.Add(this.textBoxПоиск_RAP);
            this.Controls.Add(this.labelСтатистика_RAP);
            this.Controls.Add(this.dataGridViewТовары_RAP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 550);
            this.Name = "FormMain_RAP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оптовая база - Вариант 5 (Радочина А.П.)";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewТовары_RAP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}