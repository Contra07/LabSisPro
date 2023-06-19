namespace App.Views
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageFile = new System.Windows.Forms.TabPage();
            this.groupBoxFileButtons = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonCreateFile = new System.Windows.Forms.Button();
            this.buttonEditRecord = new System.Windows.Forms.Button();
            this.buttonAddRecord = new System.Windows.Forms.Button();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.dataGridViewFileTable = new System.Windows.Forms.DataGridView();
            this.tabPageAnalizator = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.labelCompileResult = new System.Windows.Forms.Label();
            this.buttonCompile = new System.Windows.Forms.Button();
            this.tabPageAssembler = new System.Windows.Forms.TabPage();
            this.buttonOR = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.labelAnswer1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.numericUpDownOperand2 = new System.Windows.Forms.NumericUpDown();
            this.labelOperand2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericUpDownOperand1 = new System.Windows.Forms.NumericUpDown();
            this.labelOperand1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.buttonDeleteDB = new System.Windows.Forms.Button();
            this.buttonEditDB = new System.Windows.Forms.Button();
            this.buttonAddDB = new System.Windows.Forms.Button();
            this.dataGridViewDB = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPageFile.SuspendLayout();
            this.groupBoxFileButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFileTable)).BeginInit();
            this.tabPageAnalizator.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPageAssembler.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOperand2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOperand1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDB)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageFile);
            this.tabControl1.Controls.Add(this.tabPageAnalizator);
            this.tabControl1.Controls.Add(this.tabPageAssembler);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(615, 434);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageFile
            // 
            this.tabPageFile.Controls.Add(this.groupBoxFileButtons);
            this.tabPageFile.Controls.Add(this.dataGridViewFileTable);
            this.tabPageFile.Location = new System.Drawing.Point(4, 33);
            this.tabPageFile.Name = "tabPageFile";
            this.tabPageFile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFile.Size = new System.Drawing.Size(607, 397);
            this.tabPageFile.TabIndex = 0;
            this.tabPageFile.Text = "Работа с файлом";
            this.tabPageFile.UseVisualStyleBackColor = true;
            // 
            // groupBoxFileButtons
            // 
            this.groupBoxFileButtons.Controls.Add(this.button2);
            this.groupBoxFileButtons.Controls.Add(this.buttonCreateFile);
            this.groupBoxFileButtons.Controls.Add(this.buttonEditRecord);
            this.groupBoxFileButtons.Controls.Add(this.buttonAddRecord);
            this.groupBoxFileButtons.Controls.Add(this.buttonSaveFile);
            this.groupBoxFileButtons.Controls.Add(this.buttonOpenFile);
            this.groupBoxFileButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxFileButtons.Location = new System.Drawing.Point(3, 166);
            this.groupBoxFileButtons.Name = "groupBoxFileButtons";
            this.groupBoxFileButtons.Size = new System.Drawing.Size(601, 228);
            this.groupBoxFileButtons.TabIndex = 7;
            this.groupBoxFileButtons.TabStop = false;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(3, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(595, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "Удалить запись";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonDeleteRecord_Click);
            // 
            // buttonCreateFile
            // 
            this.buttonCreateFile.AutoSize = true;
            this.buttonCreateFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCreateFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCreateFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateFile.Location = new System.Drawing.Point(3, 161);
            this.buttonCreateFile.Name = "buttonCreateFile";
            this.buttonCreateFile.Size = new System.Drawing.Size(595, 34);
            this.buttonCreateFile.TabIndex = 4;
            this.buttonCreateFile.Text = "Создать файл";
            this.buttonCreateFile.UseVisualStyleBackColor = true;
            this.buttonCreateFile.Click += new System.EventHandler(this.buttonCreateFile_Click);
            // 
            // buttonEditRecord
            // 
            this.buttonEditRecord.AutoSize = true;
            this.buttonEditRecord.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonEditRecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEditRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEditRecord.Location = new System.Drawing.Point(3, 127);
            this.buttonEditRecord.Name = "buttonEditRecord";
            this.buttonEditRecord.Size = new System.Drawing.Size(595, 34);
            this.buttonEditRecord.TabIndex = 5;
            this.buttonEditRecord.Text = "Изменить запись";
            this.buttonEditRecord.UseVisualStyleBackColor = true;
            this.buttonEditRecord.Click += new System.EventHandler(this.buttonEditRecord_Click);
            // 
            // buttonAddRecord
            // 
            this.buttonAddRecord.AutoSize = true;
            this.buttonAddRecord.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAddRecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddRecord.Location = new System.Drawing.Point(3, 93);
            this.buttonAddRecord.Name = "buttonAddRecord";
            this.buttonAddRecord.Size = new System.Drawing.Size(595, 34);
            this.buttonAddRecord.TabIndex = 6;
            this.buttonAddRecord.Text = "Добавить запись";
            this.buttonAddRecord.UseVisualStyleBackColor = true;
            this.buttonAddRecord.Click += new System.EventHandler(this.buttonAddRecord_Click);
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.AutoSize = true;
            this.buttonSaveFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSaveFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSaveFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveFile.Location = new System.Drawing.Point(3, 59);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(595, 34);
            this.buttonSaveFile.TabIndex = 3;
            this.buttonSaveFile.Text = "Сохранить файл";
            this.buttonSaveFile.UseVisualStyleBackColor = true;
            this.buttonSaveFile.Click += new System.EventHandler(this.buttonSaveFile_Click);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.AutoSize = true;
            this.buttonOpenFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonOpenFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenFile.Location = new System.Drawing.Point(3, 25);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(595, 34);
            this.buttonOpenFile.TabIndex = 1;
            this.buttonOpenFile.Text = "Открыть файл";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click);
            // 
            // dataGridViewFileTable
            // 
            this.dataGridViewFileTable.AllowUserToAddRows = false;
            this.dataGridViewFileTable.AllowUserToDeleteRows = false;
            this.dataGridViewFileTable.AllowUserToResizeColumns = false;
            this.dataGridViewFileTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewFileTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewFileTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFileTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFileTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFileTable.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewFileTable.MultiSelect = false;
            this.dataGridViewFileTable.Name = "dataGridViewFileTable";
            this.dataGridViewFileTable.ReadOnly = true;
            this.dataGridViewFileTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewFileTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFileTable.ShowCellErrors = false;
            this.dataGridViewFileTable.ShowCellToolTips = false;
            this.dataGridViewFileTable.ShowEditingIcon = false;
            this.dataGridViewFileTable.ShowRowErrors = false;
            this.dataGridViewFileTable.Size = new System.Drawing.Size(601, 391);
            this.dataGridViewFileTable.TabIndex = 0;
            // 
            // tabPageAnalizator
            // 
            this.tabPageAnalizator.Controls.Add(this.groupBox2);
            this.tabPageAnalizator.Controls.Add(this.labelCompileResult);
            this.tabPageAnalizator.Controls.Add(this.buttonCompile);
            this.tabPageAnalizator.Location = new System.Drawing.Point(4, 33);
            this.tabPageAnalizator.Name = "tabPageAnalizator";
            this.tabPageAnalizator.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAnalizator.Size = new System.Drawing.Size(532, 395);
            this.tabPageAnalizator.TabIndex = 1;
            this.tabPageAnalizator.Text = "Анализатор";
            this.tabPageAnalizator.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxCode);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(526, 300);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // textBoxCode
            // 
            this.textBoxCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCode.Location = new System.Drawing.Point(3, 25);
            this.textBoxCode.Multiline = true;
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(520, 272);
            this.textBoxCode.TabIndex = 0;
            // 
            // labelCompileResult
            // 
            this.labelCompileResult.AutoSize = true;
            this.labelCompileResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelCompileResult.Location = new System.Drawing.Point(3, 303);
            this.labelCompileResult.Name = "labelCompileResult";
            this.labelCompileResult.Size = new System.Drawing.Size(274, 24);
            this.labelCompileResult.TabIndex = 2;
            this.labelCompileResult.Text = "Количество итераций цикла: ";
            // 
            // buttonCompile
            // 
            this.buttonCompile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonCompile.Location = new System.Drawing.Point(3, 327);
            this.buttonCompile.Name = "buttonCompile";
            this.buttonCompile.Size = new System.Drawing.Size(526, 65);
            this.buttonCompile.TabIndex = 1;
            this.buttonCompile.Text = "Выполнить";
            this.buttonCompile.UseVisualStyleBackColor = true;
            this.buttonCompile.Click += new System.EventHandler(this.buttonCompile_Click);
            // 
            // tabPageAssembler
            // 
            this.tabPageAssembler.Controls.Add(this.buttonOR);
            this.tabPageAssembler.Controls.Add(this.groupBox5);
            this.tabPageAssembler.Controls.Add(this.groupBox4);
            this.tabPageAssembler.Controls.Add(this.groupBox3);
            this.tabPageAssembler.Location = new System.Drawing.Point(4, 33);
            this.tabPageAssembler.Name = "tabPageAssembler";
            this.tabPageAssembler.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAssembler.Size = new System.Drawing.Size(532, 395);
            this.tabPageAssembler.TabIndex = 2;
            this.tabPageAssembler.Text = "Функция ИЛИ";
            this.tabPageAssembler.UseVisualStyleBackColor = true;
            // 
            // buttonOR
            // 
            this.buttonOR.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonOR.Location = new System.Drawing.Point(3, 287);
            this.buttonOR.Name = "buttonOR";
            this.buttonOR.Size = new System.Drawing.Size(526, 105);
            this.buttonOR.TabIndex = 6;
            this.buttonOR.Text = "ИЛИ";
            this.buttonOR.UseVisualStyleBackColor = true;
            this.buttonOR.Click += new System.EventHandler(this.buttonOR_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.textBoxAnswer);
            this.groupBox5.Controls.Add(this.labelAnswer1);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(3, 131);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(526, 71);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAnswer.Location = new System.Drawing.Point(70, 25);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(453, 29);
            this.textBoxAnswer.TabIndex = 5;
            // 
            // labelAnswer1
            // 
            this.labelAnswer1.AutoSize = true;
            this.labelAnswer1.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelAnswer1.Location = new System.Drawing.Point(3, 25);
            this.labelAnswer1.Name = "labelAnswer1";
            this.labelAnswer1.Size = new System.Drawing.Size(67, 24);
            this.labelAnswer1.TabIndex = 2;
            this.labelAnswer1.Text = "Ответ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.numericUpDownOperand2);
            this.groupBox4.Controls.Add(this.labelOperand2);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(3, 66);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(526, 65);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            // 
            // numericUpDownOperand2
            // 
            this.numericUpDownOperand2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownOperand2.Location = new System.Drawing.Point(109, 25);
            this.numericUpDownOperand2.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDownOperand2.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.numericUpDownOperand2.Name = "numericUpDownOperand2";
            this.numericUpDownOperand2.Size = new System.Drawing.Size(414, 29);
            this.numericUpDownOperand2.TabIndex = 7;
            // 
            // labelOperand2
            // 
            this.labelOperand2.AutoSize = true;
            this.labelOperand2.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelOperand2.Location = new System.Drawing.Point(3, 25);
            this.labelOperand2.Name = "labelOperand2";
            this.labelOperand2.Size = new System.Drawing.Size(106, 24);
            this.labelOperand2.TabIndex = 1;
            this.labelOperand2.Text = "Операнд 2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numericUpDownOperand1);
            this.groupBox3.Controls.Add(this.labelOperand1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(526, 63);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // numericUpDownOperand1
            // 
            this.numericUpDownOperand1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownOperand1.Location = new System.Drawing.Point(109, 25);
            this.numericUpDownOperand1.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numericUpDownOperand1.Minimum = new decimal(new int[] {
            2147483647,
            0,
            0,
            -2147483648});
            this.numericUpDownOperand1.Name = "numericUpDownOperand1";
            this.numericUpDownOperand1.Size = new System.Drawing.Size(414, 29);
            this.numericUpDownOperand1.TabIndex = 7;
            // 
            // labelOperand1
            // 
            this.labelOperand1.AutoSize = true;
            this.labelOperand1.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelOperand1.Location = new System.Drawing.Point(3, 25);
            this.labelOperand1.Name = "labelOperand1";
            this.labelOperand1.Size = new System.Drawing.Size(106, 24);
            this.labelOperand1.TabIndex = 0;
            this.labelOperand1.Text = "Операнд 1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxLog);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(0, 434);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 227);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Логи";
            // 
            // textBoxLog
            // 
            this.textBoxLog.BackColor = System.Drawing.Color.White;
            this.textBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLog.Location = new System.Drawing.Point(3, 25);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.Size = new System.Drawing.Size(609, 199);
            this.textBoxLog.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewDB);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(607, 397);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "База данных";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.buttonDeleteDB);
            this.groupBox6.Controls.Add(this.buttonEditDB);
            this.groupBox6.Controls.Add(this.buttonAddDB);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox6.Location = new System.Drawing.Point(3, 261);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(601, 133);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            // 
            // buttonDeleteDB
            // 
            this.buttonDeleteDB.AutoSize = true;
            this.buttonDeleteDB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonDeleteDB.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDeleteDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDeleteDB.Location = new System.Drawing.Point(3, 93);
            this.buttonDeleteDB.Name = "buttonDeleteDB";
            this.buttonDeleteDB.Size = new System.Drawing.Size(595, 34);
            this.buttonDeleteDB.TabIndex = 9;
            this.buttonDeleteDB.Text = "Удалить запись";
            this.buttonDeleteDB.UseVisualStyleBackColor = true;
            this.buttonDeleteDB.Click += new System.EventHandler(this.buttonDeleteDB_Click);
            // 
            // buttonEditDB
            // 
            this.buttonEditDB.AutoSize = true;
            this.buttonEditDB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonEditDB.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEditDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEditDB.Location = new System.Drawing.Point(3, 59);
            this.buttonEditDB.Name = "buttonEditDB";
            this.buttonEditDB.Size = new System.Drawing.Size(595, 34);
            this.buttonEditDB.TabIndex = 8;
            this.buttonEditDB.Text = "Изменить запись";
            this.buttonEditDB.UseVisualStyleBackColor = true;
            this.buttonEditDB.Click += new System.EventHandler(this.buttonEditDB_Click);
            // 
            // buttonAddDB
            // 
            this.buttonAddDB.AutoSize = true;
            this.buttonAddDB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAddDB.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddDB.Location = new System.Drawing.Point(3, 25);
            this.buttonAddDB.Name = "buttonAddDB";
            this.buttonAddDB.Size = new System.Drawing.Size(595, 34);
            this.buttonAddDB.TabIndex = 7;
            this.buttonAddDB.Text = "Добавить запись";
            this.buttonAddDB.UseVisualStyleBackColor = true;
            this.buttonAddDB.Click += new System.EventHandler(this.buttonAddDB_Click);
            // 
            // dataGridViewDB
            // 
            this.dataGridViewDB.AllowUserToAddRows = false;
            this.dataGridViewDB.AllowUserToDeleteRows = false;
            this.dataGridViewDB.AllowUserToResizeColumns = false;
            this.dataGridViewDB.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewDB.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewDB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDB.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewDB.MultiSelect = false;
            this.dataGridViewDB.Name = "dataGridViewDB";
            this.dataGridViewDB.ReadOnly = true;
            this.dataGridViewDB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewDB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDB.ShowCellErrors = false;
            this.dataGridViewDB.ShowCellToolTips = false;
            this.dataGridViewDB.ShowEditingIcon = false;
            this.dataGridViewDB.ShowRowErrors = false;
            this.dataGridViewDB.Size = new System.Drawing.Size(601, 258);
            this.dataGridViewDB.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 661);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(600, 700);
            this.Name = "MainForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPageFile.ResumeLayout(false);
            this.groupBoxFileButtons.ResumeLayout(false);
            this.groupBoxFileButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFileTable)).EndInit();
            this.tabPageAnalizator.ResumeLayout(false);
            this.tabPageAnalizator.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPageAssembler.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOperand2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOperand1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageFile;
        private System.Windows.Forms.TabPage tabPageAnalizator;
        private System.Windows.Forms.DataGridView dataGridViewFileTable;
        private System.Windows.Forms.Button buttonSaveFile;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.Button buttonCreateFile;
        private System.Windows.Forms.Button buttonAddRecord;
        private System.Windows.Forms.Button buttonEditRecord;
        private System.Windows.Forms.GroupBox groupBoxFileButtons;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.Button buttonCompile;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Label labelCompileResult;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage tabPageAssembler;
        private System.Windows.Forms.Button buttonOR;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.Label labelAnswer1;
        private System.Windows.Forms.Label labelOperand2;
        private System.Windows.Forms.Label labelOperand1;
        private System.Windows.Forms.NumericUpDown numericUpDownOperand1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown numericUpDownOperand2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewDB;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button buttonDeleteDB;
        private System.Windows.Forms.Button buttonEditDB;
        private System.Windows.Forms.Button buttonAddDB;
    }
}

