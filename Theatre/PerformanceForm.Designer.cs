namespace Theatre
{
    partial class PerformanceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PerformanceForm));
            labelNameOfPerformance = new Label();
            tbNameOfPerformance = new TextBox();
            labelDirectorName = new Label();
            tbDirectorName = new TextBox();
            labelGenre = new Label();
            cbGenre = new ComboBox();
            labelPremiereDate = new Label();
            dtpPremiereDate = new DateTimePicker();
            labelDuration = new Label();
            dtpDuration = new DateTimePicker();
            labelTicketCost = new Label();
            nudTicketCost = new NumericUpDown();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)nudTicketCost).BeginInit();
            SuspendLayout();
            // 
            // labelNameOfPerformance
            // 
            labelNameOfPerformance.AutoSize = true;
            labelNameOfPerformance.Location = new Point(39, 18);
            labelNameOfPerformance.Margin = new Padding(2, 0, 2, 0);
            labelNameOfPerformance.Name = "labelNameOfPerformance";
            labelNameOfPerformance.Size = new Size(149, 20);
            labelNameOfPerformance.TabIndex = 0;
            labelNameOfPerformance.Text = "Название спектакля";
            // 
            // tbNameOfPerformance
            // 
            tbNameOfPerformance.Location = new Point(235, 15);
            tbNameOfPerformance.Margin = new Padding(2);
            tbNameOfPerformance.Name = "tbNameOfPerformance";
            tbNameOfPerformance.Size = new Size(243, 27);
            tbNameOfPerformance.TabIndex = 1;
            // 
            // labelDirectorName
            // 
            labelDirectorName.AutoSize = true;
            labelDirectorName.Location = new Point(39, 64);
            labelDirectorName.Margin = new Padding(2, 0, 2, 0);
            labelDirectorName.Name = "labelDirectorName";
            labelDirectorName.Size = new Size(119, 20);
            labelDirectorName.TabIndex = 2;
            labelDirectorName.Text = "Имя режиссера";
            // 
            // tbDirectorName
            // 
            tbDirectorName.Location = new Point(235, 57);
            tbDirectorName.Margin = new Padding(2);
            tbDirectorName.Name = "tbDirectorName";
            tbDirectorName.Size = new Size(243, 27);
            tbDirectorName.TabIndex = 3;
            // 
            // labelGenre
            // 
            labelGenre.AutoSize = true;
            labelGenre.Location = new Point(39, 104);
            labelGenre.Margin = new Padding(2, 0, 2, 0);
            labelGenre.Name = "labelGenre";
            labelGenre.Size = new Size(48, 20);
            labelGenre.TabIndex = 4;
            labelGenre.Text = "Жанр";
            // 
            // cbGenre
            // 
            cbGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            cbGenre.FormattingEnabled = true;
            cbGenre.Items.AddRange(new object[] { "Драма", "Трагедия", "Комедия", "Трагикомедия", "Фарс", "Мелодрама", "Мюзикл", "Опера", "Оперетта", "Балет" });
            cbGenre.Location = new Point(235, 96);
            cbGenre.Margin = new Padding(2);
            cbGenre.MaxDropDownItems = 4;
            cbGenre.Name = "cbGenre";
            cbGenre.Size = new Size(243, 28);
            cbGenre.TabIndex = 5;
            // 
            // labelPremiereDate
            // 
            labelPremiereDate.AutoSize = true;
            labelPremiereDate.Location = new Point(39, 144);
            labelPremiereDate.Margin = new Padding(2, 0, 2, 0);
            labelPremiereDate.Name = "labelPremiereDate";
            labelPremiereDate.Size = new Size(118, 20);
            labelPremiereDate.TabIndex = 6;
            labelPremiereDate.Text = "Дата премьеры";
            // 
            // dtpPremiereDate
            // 
            dtpPremiereDate.Location = new Point(235, 139);
            dtpPremiereDate.Margin = new Padding(2);
            dtpPremiereDate.Name = "dtpPremiereDate";
            dtpPremiereDate.Size = new Size(241, 27);
            dtpPremiereDate.TabIndex = 7;
            // 
            // labelDuration
            // 
            labelDuration.AutoSize = true;
            labelDuration.Location = new Point(39, 184);
            labelDuration.Margin = new Padding(2, 0, 2, 0);
            labelDuration.Name = "labelDuration";
            labelDuration.Size = new Size(152, 20);
            labelDuration.TabIndex = 8;
            labelDuration.Text = "Продолжительность";
            // 
            // dtpDuration
            // 
            dtpDuration.Format = DateTimePickerFormat.Time;
            dtpDuration.Location = new Point(235, 179);
            dtpDuration.Margin = new Padding(2);
            dtpDuration.Name = "dtpDuration";
            dtpDuration.ShowUpDown = true;
            dtpDuration.Size = new Size(241, 27);
            dtpDuration.TabIndex = 9;
            // 
            // labelTicketCost
            // 
            labelTicketCost.AutoSize = true;
            labelTicketCost.Location = new Point(39, 223);
            labelTicketCost.Margin = new Padding(2, 0, 2, 0);
            labelTicketCost.Name = "labelTicketCost";
            labelTicketCost.Size = new Size(135, 20);
            labelTicketCost.TabIndex = 10;
            labelTicketCost.Text = "Стоимость билета";
            // 
            // nudTicketCost
            // 
            nudTicketCost.DecimalPlaces = 2;
            nudTicketCost.Location = new Point(235, 221);
            nudTicketCost.Margin = new Padding(2);
            nudTicketCost.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            nudTicketCost.Name = "nudTicketCost";
            nudTicketCost.Size = new Size(240, 27);
            nudTicketCost.TabIndex = 11;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(175, 279);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(122, 27);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // PerformanceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(512, 317);
            Controls.Add(btnAdd);
            Controls.Add(nudTicketCost);
            Controls.Add(labelTicketCost);
            Controls.Add(dtpDuration);
            Controls.Add(labelDuration);
            Controls.Add(dtpPremiereDate);
            Controls.Add(labelPremiereDate);
            Controls.Add(cbGenre);
            Controls.Add(labelGenre);
            Controls.Add(tbDirectorName);
            Controls.Add(labelDirectorName);
            Controls.Add(tbNameOfPerformance);
            Controls.Add(labelNameOfPerformance);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PerformanceForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавление новой записи";
            Load += PerformanceForm_Load;
            ((System.ComponentModel.ISupportInitialize)nudTicketCost).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNameOfPerformance;
        private TextBox tbNameOfPerformance;
        private Label labelDirectorName;
        private TextBox tbDirectorName;
        private Label labelGenre;
        private ComboBox cbGenre;
        private Label labelPremiereDate;
        private DateTimePicker dtpPremiereDate;
        private Label labelDuration;
        private DateTimePicker dtpDuration;
        private Label labelTicketCost;
        private NumericUpDown nudTicketCost;
        private Button btnAdd;
    }
}