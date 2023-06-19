using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Models.Interfaces;
using App.Views.Interfaces;
using Library.Data_Base;

namespace App.Presenters
{
    internal class DataBasePresenter
    {
        private readonly IDataBaseManager _dataBaseManager;
        private readonly IDataBaseView _dataBaseView;
        private readonly IDBRecordView _dataBaseRecordView;
        private readonly ILogger _logger;
        public DataBasePresenter(IDataBaseManager dataBaseManager, IDataBaseView dataBaseView, ILogger logger, IDBRecordView dataBaseRecordView)
        {
            _dataBaseManager = dataBaseManager;
            _dataBaseView = dataBaseView;
            _dataBaseRecordView = dataBaseRecordView;
            _logger = logger;
            _dataBaseView.AddDBRecord += AddRecord;
            _dataBaseView.EditDBRecord += EditRecord;
            _dataBaseView.DeleteDBRecord += DeleteRecord;
            ShowDB();
            if (dataBaseManager.Connected)
            {
                _logger.Log = "Подключение к базе данных установленно";
            }
            else 
            {
                _logger.Log = "Отсутствует подключение к базе данных";
            }
            
        }

        private void ShowDB()
        {
            if (_dataBaseManager.Connected)
            {
                var bindingList = new BindingList<DBRecord>(_dataBaseManager.Records);
                var source = new BindingSource(bindingList, null);
                _dataBaseView.DataBaseTable.DataSource = source;
                _dataBaseView.DataBaseTable.Columns[0].Visible = false;
                _dataBaseView.DataBaseTable.Columns[1].HeaderCell.Value = "Название файла";
                _dataBaseView.DataBaseTable.Columns[2].HeaderCell.Value = "Версия";
                _dataBaseView.DataBaseTable.Columns[3].HeaderCell.Value = "Дата создания";
            }
        }

        private void AddRecord()
        {
            _logger.Log = "Добавление записи";
            try
            {
                if (_dataBaseManager.Connected)
                {
                    _dataBaseManager.AddRecord(_dataBaseRecordView.NewDBRecord());
                    ShowDB();
                    _logger.Log = "Запись добавлена успешно";
                }
                else
                {
                    _dataBaseManager.AddRecord(null);
                }
            }
            catch (Exception ex)
            {
                _logger.Log = ex.Message;
            }
        }

        private void EditRecord()
        {
            _logger.Log = "Изменение записи";
            try
            {
                if (_dataBaseManager.Connected)
                {
                    if (_dataBaseManager.Records.Count != 0)
                    {
                        _dataBaseManager.EditRecord(_dataBaseView.SelectedDBRecordIndex, _dataBaseRecordView.EditDBRecord(_dataBaseManager.GetRecord(_dataBaseView.SelectedDBRecordIndex)));
                        ShowDB();
                        _logger.Log = "Запись изменена успешно";
                    }
                    else
                    {
                        _logger.Log = "Ошибка. База данных пуста";
                    }
                }
                else
                {
                    _logger.Log = "Ошибка. База данных пуста";
                }
            }
            catch (Exception ex)
            {
                _logger.Log = ex.Message;
            }
        }

        private void DeleteRecord()
        {
            _logger.Log = "Удаление записи";
            try
            {
                if (_dataBaseManager.Connected) 
                {
                    _dataBaseManager.DeleteRecord(_dataBaseView.SelectedDBRecordIndex);
                    ShowDB();
                    _logger.Log = "Запись удалена успешно";
                }
            }
            catch (Exception ex)
            {
                _logger.Log = ex.Message;
            }
        }
    }
}
