namespace Theatre
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            msMenuMain = new MenuStrip();
            FileToolStripMenuItem = new ToolStripMenuItem();
            CreateToolStripMenuItem = new ToolStripMenuItem();
            LoadToolStripMenuItem = new ToolStripMenuItem();
            SaveToolStripMenuItem = new ToolStripMenuItem();
            SaveAsToolStripMenuItem = new ToolStripMenuItem();
            CreatePdfToolStripMenuItem = new ToolStripMenuItem();
            ChangeToolStripMenuItem = new ToolStripMenuItem();
            AddRecordToolStripMenuItem = new ToolStripMenuItem();
            ChangeRecordToolStripMenuItem = new ToolStripMenuItem();
            RemoveRecordToolStripMenuItem = new ToolStripMenuItem();
            dgvMainTable = new DataGridView();
            bindingSource = new BindingSource(components);
            labelFIlter = new Label();
            labelValue = new Label();
            tbFilterValue = new TextBox();
            cbFilter = new ComboBox();
            btnSort = new Button();
            labelSearch = new Label();
            tbSearch = new TextBox();
            labelCount = new Label();
            label1 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            exit_Click = new Button();
            msMenuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMainTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // msMenuMain
            // 
            msMenuMain.ImageScalingSize = new Size(24, 24);
            msMenuMain.Items.AddRange(new ToolStripItem[] { FileToolStripMenuItem, ChangeToolStripMenuItem });
            msMenuMain.Location = new Point(0, 0);
            msMenuMain.Name = "msMenuMain";
            msMenuMain.Padding = new Padding(5, 2, 0, 2);
            msMenuMain.Size = new Size(1059, 28);
            msMenuMain.TabIndex = 0;
            msMenuMain.Text = "Файл";
            msMenuMain.ItemClicked += msMenuMain_ItemClicked;
            // 
            // FileToolStripMenuItem
            // 
            FileToolStripMenuItem.BackColor = SystemColors.InactiveCaption;
            FileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { CreateToolStripMenuItem, LoadToolStripMenuItem, SaveToolStripMenuItem, SaveAsToolStripMenuItem, CreatePdfToolStripMenuItem });
            FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            FileToolStripMenuItem.Size = new Size(59, 24);
            FileToolStripMenuItem.Text = "Файл";
            // 
            // CreateToolStripMenuItem
            // 
            CreateToolStripMenuItem.Name = "CreateToolStripMenuItem";
            CreateToolStripMenuItem.Size = new Size(334, 26);
            CreateToolStripMenuItem.Text = "Создать";
            CreateToolStripMenuItem.Click += CreateToolStripMenuItem_Click;
            // 
            // LoadToolStripMenuItem
            // 
            LoadToolStripMenuItem.Name = "LoadToolStripMenuItem";
            LoadToolStripMenuItem.Size = new Size(334, 26);
            LoadToolStripMenuItem.Text = "Загрузить";
            LoadToolStripMenuItem.Click += LoadToolStripMenuItem_Click;
            // 
            // SaveToolStripMenuItem
            // 
            SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            SaveToolStripMenuItem.Size = new Size(334, 26);
            SaveToolStripMenuItem.Text = "Сохранить";
            SaveToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
            // 
            // SaveAsToolStripMenuItem
            // 
            SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            SaveAsToolStripMenuItem.Size = new Size(334, 26);
            SaveAsToolStripMenuItem.Text = "Сохранить как";
            SaveAsToolStripMenuItem.Click += SaveAsToolStripMenuItem_Click;
            // 
            // CreatePdfToolStripMenuItem
            // 
            CreatePdfToolStripMenuItem.Name = "CreatePdfToolStripMenuItem";
            CreatePdfToolStripMenuItem.Size = new Size(334, 26);
            CreatePdfToolStripMenuItem.Text = "Создать отчет по текущим данным";
            CreatePdfToolStripMenuItem.Click += CreatePdfToolStripMenuItem_Click;
            // 
            // ChangeToolStripMenuItem
            // 
            ChangeToolStripMenuItem.BackColor = SystemColors.InactiveCaption;
            ChangeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { AddRecordToolStripMenuItem, ChangeRecordToolStripMenuItem, RemoveRecordToolStripMenuItem });
            ChangeToolStripMenuItem.Name = "ChangeToolStripMenuItem";
            ChangeToolStripMenuItem.Size = new Size(92, 24);
            ChangeToolStripMenuItem.Text = "Изменить";
            // 
            // AddRecordToolStripMenuItem
            // 
            AddRecordToolStripMenuItem.Name = "AddRecordToolStripMenuItem";
            AddRecordToolStripMenuItem.Size = new Size(213, 26);
            AddRecordToolStripMenuItem.Text = "Добавить запись";
            AddRecordToolStripMenuItem.Click += AddRecordToolStripMenuItem_Click;
            // 
            // ChangeRecordToolStripMenuItem
            // 
            ChangeRecordToolStripMenuItem.Name = "ChangeRecordToolStripMenuItem";
            ChangeRecordToolStripMenuItem.Size = new Size(213, 26);
            ChangeRecordToolStripMenuItem.Text = "Изменить запись";
            ChangeRecordToolStripMenuItem.Click += ChangeRecordToolStripMenuItem_Click;
            // 
            // RemoveRecordToolStripMenuItem
            // 
            RemoveRecordToolStripMenuItem.Name = "RemoveRecordToolStripMenuItem";
            RemoveRecordToolStripMenuItem.Size = new Size(213, 26);
            RemoveRecordToolStripMenuItem.Text = "Удалить запись";
            RemoveRecordToolStripMenuItem.Click += RemoveRecordToolStripMenuItem_Click;
            // 
            // dgvMainTable
            // 
            dgvMainTable.AllowUserToAddRows = false;
            dgvMainTable.AllowUserToDeleteRows = false;
            dgvMainTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvMainTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMainTable.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvMainTable.BackgroundColor = SystemColors.ButtonFace;
            dgvMainTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvMainTable.DefaultCellStyle = dataGridViewCellStyle1;
            dgvMainTable.Location = new Point(0, 198);
            dgvMainTable.Margin = new Padding(2);
            dgvMainTable.MultiSelect = false;
            dgvMainTable.Name = "dgvMainTable";
            dgvMainTable.ReadOnly = true;
            dgvMainTable.RowHeadersWidth = 62;
            dgvMainTable.Size = new Size(1059, 298);
            dgvMainTable.TabIndex = 1;
            // 
            // labelFIlter
            // 
            labelFIlter.AutoSize = true;
            labelFIlter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelFIlter.Location = new Point(2, 16);
            labelFIlter.Margin = new Padding(2, 0, 2, 0);
            labelFIlter.Name = "labelFIlter";
            labelFIlter.Size = new Size(102, 28);
            labelFIlter.TabIndex = 2;
            labelFIlter.Text = "Критерий";
            // 
            // labelValue
            // 
            labelValue.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelValue.AutoSize = true;
            labelValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelValue.Location = new Point(319, 16);
            labelValue.Margin = new Padding(2, 0, 2, 0);
            labelValue.Name = "labelValue";
            labelValue.Size = new Size(80, 28);
            labelValue.TabIndex = 4;
            labelValue.Text = "Фильтр";
            // 
            // tbFilterValue
            // 
            tbFilterValue.Location = new Point(403, 16);
            tbFilterValue.Margin = new Padding(2);
            tbFilterValue.Name = "tbFilterValue";
            tbFilterValue.Size = new Size(202, 27);
            tbFilterValue.TabIndex = 5;
            tbFilterValue.TextChanged += tbFilterValue_TextChanged;
            // 
            // cbFilter
            // 
            cbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilter.FormattingEnabled = true;
            cbFilter.Items.AddRange(new object[] { "Название спектакля", "Имя режиссера", "Жанр", "Дата премьеры", "Длительность", "Стоимость билета" });
            cbFilter.Location = new Point(108, 16);
            cbFilter.Margin = new Padding(2);
            cbFilter.Name = "cbFilter";
            cbFilter.Size = new Size(193, 28);
            cbFilter.TabIndex = 6;
            // 
            // btnSort
            // 
            btnSort.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnSort.Location = new Point(435, 139);
            btnSort.Margin = new Padding(2);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(138, 27);
            btnSort.TabIndex = 7;
            btnSort.Text = "Сортировать";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // labelSearch
            // 
            labelSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelSearch.AutoSize = true;
            labelSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelSearch.Location = new Point(668, 16);
            labelSearch.Margin = new Padding(2, 0, 2, 0);
            labelSearch.Name = "labelSearch";
            labelSearch.Size = new Size(69, 28);
            labelSearch.TabIndex = 8;
            labelSearch.Text = "Поиск";
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(777, 20);
            tbSearch.Margin = new Padding(2);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(202, 27);
            tbSearch.TabIndex = 9;
            tbSearch.TextChanged += tbSearch_TextChanged;
            // 
            // labelCount
            // 
            labelCount.AutoSize = true;
            labelCount.Location = new Point(0, 176);
            labelCount.Margin = new Padding(2, 0, 2, 0);
            labelCount.Name = "labelCount";
            labelCount.Size = new Size(203, 20);
            labelCount.TabIndex = 10;
            labelCount.Text = "Отображено 0 из 0 записей";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(435, 168);
            label1.Name = "label1";
            label1.Size = new Size(168, 28);
            label1.TabIndex = 11;
            label1.Text = "Список записей";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.UseMnemonic = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(labelFIlter);
            panel1.Controls.Add(cbFilter);
            panel1.Controls.Add(labelValue);
            panel1.Controls.Add(tbSearch);
            panel1.Controls.Add(tbFilterValue);
            panel1.Controls.Add(labelSearch);
            panel1.Location = new Point(12, 55);
            panel1.Name = "panel1";
            panel1.Size = new Size(1035, 60);
            panel1.TabIndex = 12;
            // 
            // clearDB
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Location = new Point(401, 505);
            button1.Name = "button1";
            button1.Size = new Size(234, 39);
            button1.TabIndex = 13;
            button1.Text = "Очистить базу данных";
            button1.UseVisualStyleBackColor = false;
            button1.Click += clearDB_Click;
            // 
            // exit_Click
            // 
            exit_Click.Location = new Point(872, 505);
            exit_Click.Name = "exit_Click";
            exit_Click.Size = new Size(175, 35);
            exit_Click.TabIndex = 14;
            exit_Click.Text = "Выход";
            exit_Click.UseVisualStyleBackColor = true;
            exit_Click.Click += exit_Click_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1059, 552);
            Controls.Add(exit_Click);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(labelCount);
            Controls.Add(btnSort);
            Controls.Add(dgvMainTable);
            Controls.Add(msMenuMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = msMenuMain;
            Margin = new Padding(2);
            MinimumSize = new Size(1077, 399);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ИС «Театр»";
            Load += MainForm_Load;
            MouseDown += MainForm_MouseDown;
            msMenuMain.ResumeLayout(false);
            msMenuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMainTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip msMenuMain;
        private ToolStripMenuItem FileToolStripMenuItem;
        private ToolStripMenuItem CreateToolStripMenuItem;
        private ToolStripMenuItem LoadToolStripMenuItem;
        private ToolStripMenuItem SaveToolStripMenuItem;
        private ToolStripMenuItem SaveAsToolStripMenuItem;
        private ToolStripMenuItem ChangeToolStripMenuItem;
        private ToolStripMenuItem AddRecordToolStripMenuItem;
        private ToolStripMenuItem ChangeRecordToolStripMenuItem;
        private ToolStripMenuItem RemoveRecordToolStripMenuItem;
        private DataGridView dgvMainTable;
        private BindingSource bindingSource;
        private Label labelFIlter;
        private Label labelValue;
        private TextBox tbFilterValue;
        private ComboBox cbFilter;
        private Button btnSort;
        private ToolStripMenuItem CreatePdfToolStripMenuItem;
        private Label labelSearch;
        private TextBox tbSearch;
        private Label labelCount;
        private Label label1;
        private Panel panel1;
        private Button button1;
        private Button exit_Click;
    }
}
