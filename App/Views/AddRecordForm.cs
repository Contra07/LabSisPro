using System;
using System.Windows.Forms;
using Library.File;
using App.Views.Interfaces;
using Library.Data_Base;

namespace App.Views
{
    public partial class AddRecordForm : Form, IRecordView, IDBRecordView
    {
        public AddRecordForm()
        {
            InitializeComponent();
        }

        public DBRecord EditDBRecord(DBRecord record)
        {
            textBoxFileName.Text = record.FileName;
            textBoxVersion.Text = record.Version;
            dateTimePickerData.Value = record.CreateDate;
            ShowDialog();
            return new DBRecord(1, textBoxFileName.Text, textBoxVersion.Text, dateTimePickerData.Value);
        }

        public Record EditRecord(Record record)
        {
            textBoxFileName.Text = record.FileName;
            textBoxVersion.Text = record.Version;
            dateTimePickerData.Value = record.CreateDate;
            ShowDialog();
            return new Record(textBoxFileName.Text, textBoxVersion.Text, dateTimePickerData.Value);
        }

        public DBRecord NewDBRecord()
        {
            textBoxFileName.Text = "Название";
            textBoxVersion.Text = "Версия";
            ShowDialog();
            return new DBRecord(1, textBoxFileName.Text, textBoxVersion.Text, dateTimePickerData.Value);
        }

        public Record NewRecord()
        {
            textBoxFileName.Text = "Название";
            textBoxVersion.Text = "Версия";
            ShowDialog();
            return new Record(textBoxFileName.Text, textBoxVersion.Text, dateTimePickerData.Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
