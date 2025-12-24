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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.dataGridView_RAP = new System.Windows.Forms.DataGridView();
            this.panelButtons_RAP = new System.Windows.Forms.Panel();
            this.buttonOpen_RAP = new System.Windows.Forms.Button();
            this.buttonSave_RAP = new System.Windows.Forms.Button();
            this.buttonDemo_RAP = new System.Windows.Forms.Button();
            this.buttonAdd_RAP = new System.Windows.Forms.Button();
            this.buttonDelete_RAP = new System.Windows.Forms.Button();
            this.buttonSortName_RAP = new System.Windows.Forms.Button();
            this.buttonSortPrice_RAP = new System.Windows.Forms.Button();
            this.buttonFilter_RAP = new System.Windows.Forms.Button();
            this.buttonReset_RAP = new System.Windows.Forms.Button();
            this.buttonHelp_RAP = new System.Windows.Forms.Button();
            this.buttonAbout_RAP = new System.Windows.Forms.Button();
            this.buttonExit_RAP = new System.Windows.Forms.Button();
            this.textBoxSearch_RAP = new System.Windows.Forms.TextBox();
            this.labelSearch_RAP = new System.Windows.Forms.Label();
            this.panelStats_RAP = new System.Windows.Forms.Panel();
            this.labelStatsTitle_RAP = new System.Windows.Forms.Label();
            this.labelCount_RAP = new System.Windows.Forms.Label();
            this.labelTotalValue_RAP = new System.Windows.Forms.Label();
            this.labelAvgPrice_RAP = new System.Windows.Forms.Label();
            this.labelOutOfStock_RAP = new System.Windows.Forms.Label();
            this.statusStrip_RAP = new System.Windows.Forms.StatusStrip();
            this.statusLabel_RAP = new System.Windows.Forms.ToolStripStatusLabel();
            this.labelTitle_RAP = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RAP)).BeginInit();
            this.panelButtons_RAP.SuspendLayout();
            this.panelStats_RAP.SuspendLayout();
            this.statusStrip_RAP.SuspendLayout();
            this.SuspendLayout();

            // dataGridView_RAP
            this.dataGridView_RAP.AllowUserToAddRows = false;
            this.dataGridView_RAP.AllowUserToDeleteRows = false;
            this.dataGridView_RAP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_RAP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_RAP.Location = new System.Drawing.Point(12, 40);
            this.dataGridView_RAP.Name = "dataGridView_RAP";
            this.dataGridView_RAP.ReadOnly = true;
            this.dataGridView_RAP.RowHeadersWidth = 62;
            this.dataGridView_RAP.RowTemplate.Height = 28;
            this.dataGridView_RAP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_RAP.Size = new System.Drawing.Size(650, 400);
            this.dataGridView_RAP.TabIndex = 0;

            // panelButtons_RAP
            this.panelButtons_RAP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelButtons_RAP.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelButtons_RAP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelButtons_RAP.Controls.Add(this.buttonExit_RAP);
            this.panelButtons_RAP.Controls.Add(this.buttonAbout_RAP);
            this.panelButtons_RAP.Controls.Add(this.buttonHelp_RAP);
            this.panelButtons_RAP.Controls.Add(this.buttonReset_RAP);
            this.panelButtons_RAP.Controls.Add(this.buttonFilter_RAP);
            this.panelButtons_RAP.Controls.Add(this.buttonSortPrice_RAP);
            this.panelButtons_RAP.Controls.Add(this.buttonSortName_RAP);
            this.panelButtons_RAP.Controls.Add(this.buttonDelete_RAP);
            this.panelButtons_RAP.Controls.Add(this.buttonAdd_RAP);
            this.panelButtons_RAP.Controls.Add(this.buttonDemo_RAP);
            this.panelButtons_RAP.Controls.Add(this.buttonSave_RAP);
            this.panelButtons_RAP.Controls.Add(this.buttonOpen_RAP);
            this.panelButtons_RAP.Location = new System.Drawing.Point(670, 40);
            this.panelButtons_RAP.Name = "panelButtons_RAP";
            this.panelButtons_RAP.Size = new System.Drawing.Size(300, 400);
            this.panelButtons_RAP.TabIndex = 1;

            // buttonOpen_RAP
            this.buttonOpen_RAP.Location = new System.Drawing.Point(10, 10);
            this.buttonOpen_RAP.Name = "buttonOpen_RAP";
            this.buttonOpen_RAP.Size = new System.Drawing.Size(280, 30);
            this.buttonOpen_RAP.TabIndex = 0;
            this.buttonOpen_RAP.Text = "Открыть CSV";
            this.buttonOpen_RAP.UseVisualStyleBackColor = true;
            this.buttonOpen_RAP.Click += new System.EventHandler(this.buttonOpen_RAP_Click);

            // buttonSave_RAP
            this.buttonSave_RAP.Location = new System.Drawing.Point(10, 45);
            this.buttonSave_RAP.Name = "buttonSave_RAP";
            this.buttonSave_RAP.Size = new System.Drawing.Size(280, 30);
            this.buttonSave_RAP.TabIndex = 1;
            this.buttonSave_RAP.Text = "Сохранить CSV";
            this.buttonSave_RAP.UseVisualStyleBackColor = true;
            this.buttonSave_RAP.Click += new System.EventHandler(this.buttonSave_RAP_Click);

            // buttonDemo_RAP
            this.buttonDemo_RAP.Location = new System.Drawing.Point(10, 80);
            this.buttonDemo_RAP.Name = "buttonDemo_RAP";
            this.buttonDemo_RAP.Size = new System.Drawing.Size(280, 30);
            this.buttonDemo_RAP.TabIndex = 2;
            this.buttonDemo_RAP.Text = "Демо данные";
            this.buttonDemo_RAP.UseVisualStyleBackColor = true;
            this.buttonDemo_RAP.Click += new System.EventHandler(this.buttonDemo_RAP_Click);

            // buttonAdd_RAP
            this.buttonAdd_RAP.Location = new System.Drawing.Point(10, 115);
            this.buttonAdd_RAP.Name = "buttonAdd_RAP";
            this.buttonAdd_RAP.Size = new System.Drawing.Size(280, 30);
            this.buttonAdd_RAP.TabIndex = 3;
            this.buttonAdd_RAP.Text = "Добавить товар";
            this.buttonAdd_RAP.UseVisualStyleBackColor = true;
            this.buttonAdd_RAP.Click += new System.EventHandler(this.buttonAdd_RAP_Click);

            // buttonDelete_RAP
            this.buttonDelete_RAP.Location = new System.Drawing.Point(10, 150);
            this.buttonDelete_RAP.Name = "buttonDelete_RAP";
            this.buttonDelete_RAP.Size = new System.Drawing.Size(280, 30);
            this.buttonDelete_RAP.TabIndex = 4;
            this.buttonDelete_RAP.Text = "Удалить товар";
            this.buttonDelete_RAP.UseVisualStyleBackColor = true;
            this.buttonDelete_RAP.Click += new System.EventHandler(this.buttonDelete_RAP_Click);

            // buttonSortName_RAP
            this.buttonSortName_RAP.Location = new System.Drawing.Point(10, 185);
            this.buttonSortName_RAP.Name = "buttonSortName_RAP";
            this.buttonSortName_RAP.Size = new System.Drawing.Size(280, 30);
            this.buttonSortName_RAP.TabIndex = 5;
            this.buttonSortName_RAP.Text = "Сортировать по названию";
            this.buttonSortName_RAP.UseVisualStyleBackColor = true;
            this.buttonSortName_RAP.Click += new System.EventHandler(this.buttonSortName_RAP_Click);

            // buttonSortPrice_RAP
            this.buttonSortPrice_RAP.Location = new System.Drawing.Point(10, 220);
            this.buttonSortPrice_RAP.Name = "buttonSortPrice_RAP";
            this.buttonSortPrice_RAP.Size = new System.Drawing.Size(280, 30);
            this.buttonSortPrice_RAP.TabIndex = 6;
            this.buttonSortPrice_RAP.Text = "Сортировать по цене";
            this.buttonSortPrice_RAP.UseVisualStyleBackColor = true;
            this.buttonSortPrice_RAP.Click += new System.EventHandler(this.buttonSortPrice_RAP_Click);

            // buttonFilter_RAP
            this.buttonFilter_RAP.Location = new System.Drawing.Point(10, 255);
            this.buttonFilter_RAP.Name = "buttonFilter_RAP";
            this.buttonFilter_RAP.Size = new System.Drawing.Size(280, 30);
            this.buttonFilter_RAP.TabIndex = 7;
            this.buttonFilter_RAP.Text = "Только в наличии";
            this.buttonFilter_RAP.UseVisualStyleBackColor = true;
            this.buttonFilter_RAP.Click += new System.EventHandler(this.buttonFilter_RAP_Click);

            // buttonReset_RAP
            this.buttonReset_RAP.Location = new System.Drawing.Point(10, 290);
            this.buttonReset_RAP.Name = "buttonReset_RAP";
            this.buttonReset_RAP.Size = new System.Drawing.Size(280, 30);
            this.buttonReset_RAP.TabIndex = 8;
            this.buttonReset_RAP.Text = "Сбросить фильтры";
            this.buttonReset_RAP.UseVisualStyleBackColor = true;
            this.buttonReset_RAP.Click += new System.EventHandler(this.buttonReset_RAP_Click);

            // buttonHelp_RAP
            this.buttonHelp_RAP.Location = new System.Drawing.Point(10, 325);
            this.buttonHelp_RAP.Name = "buttonHelp_RAP";
            this.buttonHelp_RAP.Size = new System.Drawing.Size(280, 30);
            this.buttonHelp_RAP.TabIndex = 9;
            this.buttonHelp_RAP.Text = "Справка";
            this.buttonHelp_RAP.UseVisualStyleBackColor = true;
            this.buttonHelp_RAP.Click += new System.EventHandler(this.buttonHelp_RAP_Click);

            // buttonAbout_RAP
            this.buttonAbout_RAP.Location = new System.Drawing.Point(10, 360);
            this.buttonAbout_RAP.Name = "buttonAbout_RAP";
            this.buttonAbout_RAP.Size = new System.Drawing.Size(135, 30);
            this.buttonAbout_RAP.TabIndex = 10;
            this.buttonAbout_RAP.Text = "О программе";
            this.buttonAbout_RAP.UseVisualStyleBackColor = true;
            this.buttonAbout_RAP.Click += new System.EventHandler(this.buttonAbout_RAP_Click);

            // buttonExit_RAP
            this.buttonExit_RAP.Location = new System.Drawing.Point(155, 360);
            this.buttonExit_RAP.Name = "buttonExit_RAP";
            this.buttonExit_RAP.Size = new System.Drawing.Size(135, 30);
            this.buttonExit_RAP.TabIndex = 11;
            this.buttonExit_RAP.Text = "Выход";
            this.buttonExit_RAP.UseVisualStyleBackColor = true;
            this.buttonExit_RAP.Click += new System.EventHandler(this.buttonExit_RAP_Click);

            // textBoxSearch_RAP
            this.textBoxSearch_RAP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSearch_RAP.Location = new System.Drawing.Point(70, 445);
            this.textBoxSearch_RAP.Name = "textBoxSearch_RAP";
            this.textBoxSearch_RAP.Size = new System.Drawing.Size(592, 26);
            this.textBoxSearch_RAP.TabIndex = 2;
            this.textBoxSearch_RAP.TextChanged += new System.EventHandler(this.textBoxSearch_RAP_TextChanged);

            // labelSearch_RAP
            this.labelSearch_RAP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelSearch_RAP.AutoSize = true;
            this.labelSearch_RAP.Location = new System.Drawing.Point(12, 448);
            this.labelSearch_RAP.Name = "labelSearch_RAP";
            this.labelSearch_RAP.Size = new System.Drawing.Size(52, 20);
            this.labelSearch_RAP.TabIndex = 3;
            this.labelSearch_RAP.Text = "Поиск:";

            // panelStats_RAP
            this.panelStats_RAP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelStats_RAP.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelStats_RAP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStats_RAP.Controls.Add(this.labelOutOfStock_RAP);
            this.panelStats_RAP.Controls.Add(this.labelAvgPrice_RAP);
            this.panelStats_RAP.Controls.Add(this.labelTotalValue_RAP);
            this.panelStats_RAP.Controls.Add(this.labelCount_RAP);
            this.panelStats_RAP.Controls.Add(this.labelStatsTitle_RAP);
            this.panelStats_RAP.Location = new System.Drawing.Point(12, 480);
            this.panelStats_RAP.Name = "panelStats_RAP";
            this.panelStats_RAP.Size = new System.Drawing.Size(958, 70);
            this.panelStats_RAP.TabIndex = 4;

            // labelStatsTitle_RAP
            this.labelStatsTitle_RAP.AutoSize = true;
            this.labelStatsTitle_RAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatsTitle_RAP.Location = new System.Drawing.Point(10, 10);
            this.labelStatsTitle_RAP.Name = "labelStatsTitle_RAP";
            this.labelStatsTitle_RAP.Size = new System.Drawing.Size(110, 22);
            this.labelStatsTitle_RAP.TabIndex = 0;
            this.labelStatsTitle_RAP.Text = "Статистика:";

            // labelCount_RAP
            this.labelCount_RAP.AutoSize = true;
            this.labelCount_RAP.Location = new System.Drawing.Point(150, 10);
            this.labelCount_RAP.Name = "labelCount_RAP";
            this.labelCount_RAP.Size = new System.Drawing.Size(94, 20);
            this.labelCount_RAP.TabIndex = 1;
            this.labelCount_RAP.Text = "Товаров: 0";

            // labelTotalValue_RAP
            this.labelTotalValue_RAP.AutoSize = true;
            this.labelTotalValue_RAP.Location = new System.Drawing.Point(150, 30);
            this.labelTotalValue_RAP.Name = "labelTotalValue_RAP";
            this.labelTotalValue_RAP.Size = new System.Drawing.Size(154, 20);
            this.labelTotalValue_RAP.TabIndex = 2;
            this.labelTotalValue_RAP.Text = "Общая стоимость: 0";

            // labelAvgPrice_RAP
            this.labelAvgPrice_RAP.AutoSize = true;
            this.labelAvgPrice_RAP.Location = new System.Drawing.Point(400, 10);
            this.labelAvgPrice_RAP.Name = "labelAvgPrice_RAP";
            this.labelAvgPrice_RAP.Size = new System.Drawing.Size(128, 20);
            this.labelAvgPrice_RAP.TabIndex = 3;
            this.labelAvgPrice_RAP.Text = "Средняя цена: 0";

            // labelOutOfStock_RAP
            this.labelOutOfStock_RAP.AutoSize = true;
            this.labelOutOfStock_RAP.Location = new System.Drawing.Point(400, 30);
            this.labelOutOfStock_RAP.Name = "labelOutOfStock_RAP";
            this.labelOutOfStock_RAP.Size = new System.Drawing.Size(133, 20);
            this.labelOutOfStock_RAP.TabIndex = 4;
            this.labelOutOfStock_RAP.Text = "Нет в наличии: 0";

            // statusStrip_RAP
            this.statusStrip_RAP.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip_RAP.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel_RAP});
            this.statusStrip_RAP.Location = new System.Drawing.Point(0, 553);
            this.statusStrip_RAP.Name = "statusStrip_RAP";
            this.statusStrip_RAP.Size = new System.Drawing.Size(982, 32);
            this.statusStrip_RAP.TabIndex = 5;
            this.statusStrip_RAP.Text = "statusStrip_RAP";

            // statusLabel_RAP
            this.statusLabel_RAP.Name = "statusLabel_RAP";
            this.statusLabel_RAP.Size = new System.Drawing.Size(170, 25);
            this.statusLabel_RAP.Text = "Готов к работе...";

            // labelTitle_RAP
            this.labelTitle_RAP.AutoSize = true;
            this.labelTitle_RAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle_RAP.Location = new System.Drawing.Point(12, 9);
            this.labelTitle_RAP.Name = "labelTitle_RAP";
            this.labelTitle_RAP.Size = new System.Drawing.Size(354, 25);
            this.labelTitle_RAP.TabIndex = 6;
            this.labelTitle_RAP.Text = "Оптовая база - Управление товарами";

            
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 585);
            this.Controls.Add(this.labelTitle_RAP);
            this.Controls.Add(this.statusStrip_RAP);
            this.Controls.Add(this.panelStats_RAP);
            this.Controls.Add(this.labelSearch_RAP);
            this.Controls.Add(this.textBoxSearch_RAP);
            this.Controls.Add(this.panelButtons_RAP);
            this.Controls.Add(this.dataGridView_RAP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 640);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оптовая база - Вариант 5 (Радочина А.П.)";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_RAP)).EndInit();
            this.panelButtons_RAP.ResumeLayout(false);
            this.panelStats_RAP.ResumeLayout(false);
            this.panelStats_RAP.PerformLayout();
            this.statusStrip_RAP.ResumeLayout(false);
            this.statusStrip_RAP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();


        }
    
    }
}