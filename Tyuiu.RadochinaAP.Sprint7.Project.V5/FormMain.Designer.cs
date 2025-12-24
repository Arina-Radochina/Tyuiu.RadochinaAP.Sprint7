namespace Tyuiu.RadochinaAP.Sprint7.Project.V5
{
    partial class FormMain
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.ToolTip toolTip;

    // Таблица товаров
    private System.Windows.Forms.DataGridView dataGridView_RAP;

    // Панель управления
    private System.Windows.Forms.Panel panelButtons_RAP;
    private System.Windows.Forms.Button buttonOpen_RAP;
    private System.Windows.Forms.Button buttonSave_RAP;
    private System.Windows.Forms.Button buttonDemo_RAP;
    private System.Windows.Forms.Button buttonAdd_RAP;
    private System.Windows.Forms.Button buttonDelete_RAP;
    private System.Windows.Forms.Button buttonSortName_RAP;
    private System.Windows.Forms.Button buttonSortPrice_RAP;
    private System.Windows.Forms.Button buttonFilter_RAP;
    private System.Windows.Forms.Button buttonReset_RAP;
    private System.Windows.Forms.Button buttonHelp_RAP;
    private System.Windows.Forms.Button buttonAbout_RAP;
    private System.Windows.Forms.Button buttonExit_RAP;
    private System.Windows.Forms.TextBox textBoxSearch_RAP;
    private System.Windows.Forms.Label labelSearch_RAP;

    
    private System.Windows.Forms.Panel panelStats_RAP;
    private System.Windows.Forms.Label labelCount_RAP;
    private System.Windows.Forms.Label labelTotalValue_RAP;
    private System.Windows.Forms.Label labelAvgPrice_RAP;
    private System.Windows.Forms.Label labelOutOfStock_RAP;
    private System.Windows.Forms.Label labelStatsTitle_RAP;

    
    private System.Windows.Forms.StatusStrip statusStrip_RAP;
    private System.Windows.Forms.ToolStripStatusLabel statusLabel_RAP;

    private System.Windows.Forms.Label labelTitle_RAP;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView_RAP = new DataGridView();
            panelButtons_RAP = new Panel();
            buttonExit_RAP = new Button();
            buttonAbout_RAP = new Button();
            buttonHelp_RAP = new Button();
            buttonReset_RAP = new Button();
            buttonFilter_RAP = new Button();
            buttonSortPrice_RAP = new Button();
            buttonSortName_RAP = new Button();
            buttonDelete_RAP = new Button();
            buttonAdd_RAP = new Button();
            buttonDemo_RAP = new Button();
            buttonSave_RAP = new Button();
            buttonOpen_RAP = new Button();
            textBoxSearch_RAP = new TextBox();
            labelSearch_RAP = new Label();
            panelStats_RAP = new Panel();
            labelOutOfStock_RAP = new Label();
            labelAvgPrice_RAP = new Label();
            labelTotalValue_RAP = new Label();
            labelCount_RAP = new Label();
            labelStatsTitle_RAP = new Label();
            statusStrip_RAP = new StatusStrip();
            statusLabel_RAP = new ToolStripStatusLabel();
            labelTitle_RAP = new Label();
            toolTip = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView_RAP).BeginInit();
            panelButtons_RAP.SuspendLayout();
            panelStats_RAP.SuspendLayout();
            statusStrip_RAP.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView_RAP
            // 
            dataGridView_RAP.AllowUserToAddRows = false;
            dataGridView_RAP.AllowUserToDeleteRows = false;
            dataGridView_RAP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_RAP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_RAP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_RAP.Location = new Point(11, 40);
            dataGridView_RAP.Name = "dataGridView_RAP";
            dataGridView_RAP.ReadOnly = true;
            dataGridView_RAP.RowHeadersVisible = false;
            dataGridView_RAP.RowHeadersWidth = 62;
            dataGridView_RAP.RowTemplate.Height = 28;
            dataGridView_RAP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_RAP.Size = new Size(578, 400);
            dataGridView_RAP.TabIndex = 0;
            // 
            // panelButtons_RAP
            // 
            panelButtons_RAP.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panelButtons_RAP.BackColor = SystemColors.ControlLight;
            panelButtons_RAP.BorderStyle = BorderStyle.FixedSingle;
            panelButtons_RAP.Controls.Add(buttonExit_RAP);
            panelButtons_RAP.Controls.Add(buttonAbout_RAP);
            panelButtons_RAP.Controls.Add(buttonHelp_RAP);
            panelButtons_RAP.Controls.Add(buttonReset_RAP);
            panelButtons_RAP.Controls.Add(buttonFilter_RAP);
            panelButtons_RAP.Controls.Add(buttonSortPrice_RAP);
            panelButtons_RAP.Controls.Add(buttonSortName_RAP);
            panelButtons_RAP.Controls.Add(buttonDelete_RAP);
            panelButtons_RAP.Controls.Add(buttonAdd_RAP);
            panelButtons_RAP.Controls.Add(buttonDemo_RAP);
            panelButtons_RAP.Controls.Add(buttonSave_RAP);
            panelButtons_RAP.Controls.Add(buttonOpen_RAP);
            panelButtons_RAP.Location = new Point(596, 40);
            panelButtons_RAP.Name = "panelButtons_RAP";
            panelButtons_RAP.Size = new Size(267, 400);
            panelButtons_RAP.TabIndex = 1;
            // 
            // buttonExit_RAP
            // 
            buttonExit_RAP.Location = new Point(138, 360);
            buttonExit_RAP.Name = "buttonExit_RAP";
            buttonExit_RAP.Size = new Size(120, 30);
            buttonExit_RAP.TabIndex = 11;
            buttonExit_RAP.Text = "Выход";
            buttonExit_RAP.UseVisualStyleBackColor = true;
            buttonExit_RAP.Click += buttonExit_RAP_Click;
            // 
            // buttonAbout_RAP
            // 
            buttonAbout_RAP.Location = new Point(9, 360);
            buttonAbout_RAP.Name = "buttonAbout_RAP";
            buttonAbout_RAP.Size = new Size(120, 30);
            buttonAbout_RAP.TabIndex = 10;
            buttonAbout_RAP.Text = "О программе";
            buttonAbout_RAP.UseVisualStyleBackColor = true;
            buttonAbout_RAP.Click += buttonAbout_RAP_Click;
            // 
            // buttonHelp_RAP
            // 
            buttonHelp_RAP.Location = new Point(9, 325);
            buttonHelp_RAP.Name = "buttonHelp_RAP";
            buttonHelp_RAP.Size = new Size(249, 30);
            buttonHelp_RAP.TabIndex = 9;
            buttonHelp_RAP.Text = "Справка";
            buttonHelp_RAP.UseVisualStyleBackColor = true;
            buttonHelp_RAP.Click += buttonHelp_RAP_Click;
            // 
            // buttonReset_RAP
            // 
            buttonReset_RAP.Location = new Point(9, 290);
            buttonReset_RAP.Name = "buttonReset_RAP";
            buttonReset_RAP.Size = new Size(249, 30);
            buttonReset_RAP.TabIndex = 8;
            buttonReset_RAP.Text = "Сбросить фильтры";
            buttonReset_RAP.UseVisualStyleBackColor = true;
            buttonReset_RAP.Click += buttonReset_RAP_Click;
            // 
            // buttonFilter_RAP
            // 
            buttonFilter_RAP.Location = new Point(9, 255);
            buttonFilter_RAP.Name = "buttonFilter_RAP";
            buttonFilter_RAP.Size = new Size(249, 30);
            buttonFilter_RAP.TabIndex = 7;
            buttonFilter_RAP.Text = "Только в наличии";
            buttonFilter_RAP.UseVisualStyleBackColor = true;
            buttonFilter_RAP.Click += buttonFilter_RAP_Click;
            // 
            // buttonSortPrice_RAP
            // 
            buttonSortPrice_RAP.Location = new Point(9, 220);
            buttonSortPrice_RAP.Name = "buttonSortPrice_RAP";
            buttonSortPrice_RAP.Size = new Size(249, 30);
            buttonSortPrice_RAP.TabIndex = 6;
            buttonSortPrice_RAP.Text = "Сортировать по цене";
            buttonSortPrice_RAP.UseVisualStyleBackColor = true;
            buttonSortPrice_RAP.Click += buttonSortPrice_RAP_Click;
            // 
            // buttonSortName_RAP
            // 
            buttonSortName_RAP.Location = new Point(9, 185);
            buttonSortName_RAP.Name = "buttonSortName_RAP";
            buttonSortName_RAP.Size = new Size(249, 30);
            buttonSortName_RAP.TabIndex = 5;
            buttonSortName_RAP.Text = "Сортировать по названию";
            buttonSortName_RAP.UseVisualStyleBackColor = true;
            buttonSortName_RAP.Click += buttonSortName_RAP_Click;
            // 
            // buttonDelete_RAP
            // 
            buttonDelete_RAP.Location = new Point(9, 150);
            buttonDelete_RAP.Name = "buttonDelete_RAP";
            buttonDelete_RAP.Size = new Size(249, 30);
            buttonDelete_RAP.TabIndex = 4;
            buttonDelete_RAP.Text = "Удалить товар";
            buttonDelete_RAP.UseVisualStyleBackColor = true;
            buttonDelete_RAP.Click += buttonDelete_RAP_Click;
            // 
            // buttonAdd_RAP
            // 
            buttonAdd_RAP.Location = new Point(9, 115);
            buttonAdd_RAP.Name = "buttonAdd_RAP";
            buttonAdd_RAP.Size = new Size(249, 30);
            buttonAdd_RAP.TabIndex = 3;
            buttonAdd_RAP.Text = "Добавить товар";
            buttonAdd_RAP.UseVisualStyleBackColor = true;
            buttonAdd_RAP.Click += buttonAdd_RAP_Click;
            // 
            // buttonDemo_RAP
            // 
            buttonDemo_RAP.Location = new Point(9, 80);
            buttonDemo_RAP.Name = "buttonDemo_RAP";
            buttonDemo_RAP.Size = new Size(249, 30);
            buttonDemo_RAP.TabIndex = 2;
            buttonDemo_RAP.Text = "Демо данные";
            buttonDemo_RAP.UseVisualStyleBackColor = true;
            buttonDemo_RAP.Click += buttonDemo_RAP_Click;
            // 
            // buttonSave_RAP
            // 
            buttonSave_RAP.Location = new Point(9, 45);
            buttonSave_RAP.Name = "buttonSave_RAP";
            buttonSave_RAP.Size = new Size(249, 30);
            buttonSave_RAP.TabIndex = 1;
            buttonSave_RAP.Text = "Сохранить CSV";
            buttonSave_RAP.UseVisualStyleBackColor = true;
            buttonSave_RAP.Click += buttonSave_RAP_Click;
            // 
            // buttonOpen_RAP
            // 
            buttonOpen_RAP.Location = new Point(9, 10);
            buttonOpen_RAP.Name = "buttonOpen_RAP";
            buttonOpen_RAP.Size = new Size(249, 30);
            buttonOpen_RAP.TabIndex = 0;
            buttonOpen_RAP.Text = "Открыть CSV";
            buttonOpen_RAP.UseVisualStyleBackColor = true;
            buttonOpen_RAP.Click += buttonOpen_RAP_Click;
            // 
            // textBoxSearch_RAP
            // 
            textBoxSearch_RAP.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxSearch_RAP.Location = new Point(62, 445);
            textBoxSearch_RAP.Name = "textBoxSearch_RAP";
            textBoxSearch_RAP.Size = new Size(527, 27);
            textBoxSearch_RAP.TabIndex = 2;
            textBoxSearch_RAP.TextChanged += textBoxSearch_RAP_TextChanged;
            // 
            // labelSearch_RAP
            // 
            labelSearch_RAP.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelSearch_RAP.AutoSize = true;
            labelSearch_RAP.Location = new Point(11, 448);
            labelSearch_RAP.Name = "labelSearch_RAP";
            labelSearch_RAP.Size = new Size(55, 20);
            labelSearch_RAP.TabIndex = 3;
            labelSearch_RAP.Text = "Поиск:";
            // 
            // panelStats_RAP
            // 
            panelStats_RAP.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelStats_RAP.BackColor = SystemColors.ControlLight;
            panelStats_RAP.BorderStyle = BorderStyle.FixedSingle;
            panelStats_RAP.Controls.Add(labelOutOfStock_RAP);
            panelStats_RAP.Controls.Add(labelAvgPrice_RAP);
            panelStats_RAP.Controls.Add(labelTotalValue_RAP);
            panelStats_RAP.Controls.Add(labelCount_RAP);
            panelStats_RAP.Controls.Add(labelStatsTitle_RAP);
            panelStats_RAP.Location = new Point(11, 480);
            panelStats_RAP.Name = "panelStats_RAP";
            panelStats_RAP.Size = new Size(852, 70);
            panelStats_RAP.TabIndex = 4;
            // 
            // labelOutOfStock_RAP
            // 
            labelOutOfStock_RAP.AutoSize = true;
            labelOutOfStock_RAP.Location = new Point(356, 30);
            labelOutOfStock_RAP.Name = "labelOutOfStock_RAP";
            labelOutOfStock_RAP.Size = new Size(125, 20);
            labelOutOfStock_RAP.TabIndex = 4;
            labelOutOfStock_RAP.Text = "Нет в наличии: 0";
            // 
            // labelAvgPrice_RAP
            // 
            labelAvgPrice_RAP.AutoSize = true;
            labelAvgPrice_RAP.Location = new Point(356, 10);
            labelAvgPrice_RAP.Name = "labelAvgPrice_RAP";
            labelAvgPrice_RAP.Size = new Size(121, 20);
            labelAvgPrice_RAP.TabIndex = 3;
            labelAvgPrice_RAP.Text = "Средняя цена: 0";
            // 
            // labelTotalValue_RAP
            // 
            labelTotalValue_RAP.AutoSize = true;
            labelTotalValue_RAP.Location = new Point(133, 30);
            labelTotalValue_RAP.Name = "labelTotalValue_RAP";
            labelTotalValue_RAP.Size = new Size(148, 20);
            labelTotalValue_RAP.TabIndex = 2;
            labelTotalValue_RAP.Text = "Общая стоимость: 0";
            // 
            // labelCount_RAP
            // 
            labelCount_RAP.AutoSize = true;
            labelCount_RAP.Location = new Point(133, 10);
            labelCount_RAP.Name = "labelCount_RAP";
            labelCount_RAP.Size = new Size(83, 20);
            labelCount_RAP.TabIndex = 1;
            labelCount_RAP.Text = "Товаров: 0";
            // 
            // labelStatsTitle_RAP
            // 
            labelStatsTitle_RAP.AutoSize = true;
            labelStatsTitle_RAP.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelStatsTitle_RAP.Location = new Point(9, 10);
            labelStatsTitle_RAP.Name = "labelStatsTitle_RAP";
            labelStatsTitle_RAP.Size = new Size(103, 18);
            labelStatsTitle_RAP.TabIndex = 0;
            labelStatsTitle_RAP.Text = "Статистика:";
            // 
            // statusStrip_RAP
            // 
            statusStrip_RAP.ImageScalingSize = new Size(24, 24);
            statusStrip_RAP.Items.AddRange(new ToolStripItem[] { statusLabel_RAP });
            statusStrip_RAP.Location = new Point(0, 567);
            statusStrip_RAP.Name = "statusStrip_RAP";
            statusStrip_RAP.Padding = new Padding(1, 0, 12, 0);
            statusStrip_RAP.Size = new Size(873, 26);
            statusStrip_RAP.TabIndex = 5;
            statusStrip_RAP.Text = "statusStrip_RAP";
            // 
            // statusLabel_RAP
            // 
            statusLabel_RAP.Name = "statusLabel_RAP";
            statusLabel_RAP.Size = new Size(121, 20);
            statusLabel_RAP.Text = "Готов к работе...";
            // 
            // labelTitle_RAP
            // 
            labelTitle_RAP.AutoSize = true;
            labelTitle_RAP.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelTitle_RAP.Location = new Point(11, 9);
            labelTitle_RAP.Name = "labelTitle_RAP";
            labelTitle_RAP.Size = new Size(364, 20);
            labelTitle_RAP.TabIndex = 6;
            labelTitle_RAP.Text = "Оптовая база - Управление товарами";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 593);
            Controls.Add(labelTitle_RAP);
            Controls.Add(statusStrip_RAP);
            Controls.Add(panelStats_RAP);
            Controls.Add(labelSearch_RAP);
            Controls.Add(textBoxSearch_RAP);
            Controls.Add(panelButtons_RAP);
            Controls.Add(dataGridView_RAP);
            MinimumSize = new Size(891, 640);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Оптовая база - Вариант 5 (Радочина А.П.)";
            ((System.ComponentModel.ISupportInitialize)dataGridView_RAP).EndInit();
            panelButtons_RAP.ResumeLayout(false);
            panelStats_RAP.ResumeLayout(false);
            panelStats_RAP.PerformLayout();
            statusStrip_RAP.ResumeLayout(false);
            statusStrip_RAP.PerformLayout();
            ResumeLayout(false);
            PerformLayout();


        }

    }
}