using System;
using System.Windows.Forms;
using App.Views.Interfaces;
using System.ComponentModel;


namespace App.Views
{
    public partial class MainForm : Form, IFileView, ILoggerView, ICompilerView, IAsmFuncView, IDataBaseView
    {
        public event Action CreateFile;
        public event Action SaveFile;
        public event Action OpenFile;
        public event Action AddRecord;
        public event Action DeleteRecord;
        public event Action EditRecord;
        public event Action AddDBRecord;
        public event Action DeleteDBRecord;
        public event Action EditDBRecord;
        public event Action Compile;
        public event Action AssemblyMethod;
        
        public int SelectedDBRecordIndex 
        {
            get
            {
                if (dataGridViewDB.SelectedCells.Count > 0)
                {
                    return dataGridViewDB.SelectedCells[0].RowIndex;
                }
                return -1;
            }
        }

        public DataGridView DataBaseTable 
        {
            get 
            {
                return dataGridViewDB;
            }
        }

        public int FirstOperand 
        {
            get 
            {
                return (int)numericUpDownOperand1.Value;
            }
        }

        public int SecondOperand
        {
            get
            {
                return (int)numericUpDownOperand2.Value;
            }
        }


        public int AssemblyMethodResult
        {
            set
            {
                textBoxAnswer.Text = value.ToString();
            }
        }

        public int SelectedRecordIndex
        {
            get 
            {
                if (dataGridViewFileTable.SelectedCells.Count > 0) 
                {
                    return dataGridViewFileTable.SelectedCells[0].RowIndex;
                }
                return -1;
            }
        }

        public IBindingList FileTable 
        {
            set
            {
                var source = new BindingSource(value, null);
                dataGridViewFileTable.DataSource = source;
                dataGridViewFileTable.Columns[0].HeaderCell.Value = "Название файла";
                dataGridViewFileTable.Columns[1].HeaderCell.Value = "Версия";
                dataGridViewFileTable.Columns[2].HeaderCell.Value = "Дата создания";
            }
        }

        public string Log 
        {
            set 
            {
                textBoxLog.Text = value;
                textBoxLog.SelectionStart = textBoxLog.Text.Length;
                textBoxLog.ScrollToCaret();
            }
        }

        public string Result 
        {
            set { labelCompileResult.Text = "Количество итераций цикла: " + value; }
        }


        public string Code 
        {
            get 
            {
                return textBoxCode.Text;
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            if (OpenFile != null) 
            {
                OpenFile();
            }
        }

        private void buttonDeleteRecord_Click(object sender, EventArgs e)
        {
            if (DeleteRecord != null)
            {
                DeleteRecord();
            }
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            if (SaveFile != null) 
            {
                SaveFile();
            }
        }


        private void buttonCreateFile_Click(object sender, EventArgs e)
        {
            if (CreateFile != null) 
            {
                CreateFile();
            }
        }

        private void buttonAddRecord_Click(object sender, EventArgs e)
        {
            if (AddRecord != null)
            {
                AddRecord();
            }
        }

        private void buttonEditRecord_Click(object sender, EventArgs e)
        {
            if (EditRecord != null)
            {
                EditRecord();
            }
        }

        private void buttonCompile_Click(object sender, EventArgs e)
        {
            if (Compile != null)
            {
                Compile();
            }
        }

        private void buttonOR_Click(object sender, EventArgs e)
        {
            if (AssemblyMethod != null)
            {
                AssemblyMethod();
            }
        }

        private void buttonAddDB_Click(object sender, EventArgs e)
        {
            if (AddDBRecord != null)
            {
                AddDBRecord();
            }
        }

        private void buttonEditDB_Click(object sender, EventArgs e)
        {
            if (EditDBRecord != null)
            {
                EditDBRecord();
            }
        }

        private void buttonDeleteDB_Click(object sender, EventArgs e)
        {
            if (DeleteDBRecord != null)
            {
                DeleteDBRecord();
            }
        }
    }
}
