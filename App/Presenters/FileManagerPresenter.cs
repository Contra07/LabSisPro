using System;
using System.Windows.Forms;
using Library.File;
using System.ComponentModel;
using App.Views.Interfaces;
using App.Models.Interfaces;

namespace App.Presenters
{
    internal class FileManagerPresenter
    {
        private readonly IFileManager _fileManager;
        private readonly IFileView _fileView;
        private readonly IRecordView _recordView;
        private readonly ILogger _logger;
        public FileManagerPresenter(IFileManager fileManager, IFileView fileView, IRecordView recordView, ILogger logger)
        {
            _fileManager = fileManager;
            _fileView = fileView;
            _recordView = recordView;
            _logger = logger;

            _fileView.OpenFile += OpenFile;
            _fileView.DeleteRecord += DeleteRecord;
            _fileView.SaveFile += SaveFile;
            _fileView.CreateFile += CreateFile;
            _fileView.AddRecord += AddRecord;
            _fileView.EditRecord += EditRecord;

            _logger.Log = "Файловый менеджер запущен";
        }


        private void CreateFile() 
        {
            _logger.Log = "Создание файла";
            try 
            {
                _fileManager.CreateFile();
                ShowFile();
                _logger.Log = "Файл успешно создан";
            }
            catch (Exception ex)
            {
                _logger.Log = ex.Message;
            }
        }

        private void OpenFile() 
        {
            _logger.Log = "Открытие файла";
            try
            {
                _fileManager.OpenFile();
                ShowFile();
                _logger.Log = "Файл успешно открыт";
            }
            catch (Exception ex) 
            {
                _logger.Log = ex.Message;
            }
            
        }

        private void SaveFile() 
        {
            _logger.Log = "Сохранение файла";
            try
            {
                _fileManager.SaveFile();
                _logger.Log = "Файл успешно сохранен";
            }
            catch (Exception ex)
            {
                _logger.Log = ex.Message;
            }
        }

        private void ShowFile()
        {

            if (_fileManager.Records != null) 
            {
                var bindingList = new BindingList<Record>(_fileManager.Records);
                var source = new BindingSource(bindingList, null);
                _fileView.FileTable = source;
            }
        }

        private void AddRecord() 
        {
            try
            {
                if (_fileManager.Records != null)
                {
                    _fileManager.AddRecord(_recordView.NewRecord());
                    ShowFile();
                }
                else 
                {
                    _fileManager.AddRecord(null);
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
                if (_fileManager.Records != null)
                {
                    if (_fileManager.Records.Count != 0)
                    {
                        _fileManager.EditRecord(_fileView.SelectedRecordIndex, _recordView.EditRecord(_fileManager.Records[_fileView.SelectedRecordIndex]));
                        ShowFile();
                        _logger.Log = "Запись изменена успешно";
                    }
                    else
                    {
                        _logger.Log = "Ошибка. Файл пуст";
                    }
                }
                else 
                {
                    _logger.Log = "Ошибка. Файл отсутствует";
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
                _fileManager.DeleteRecord(_fileView.SelectedRecordIndex);
                ShowFile();
                _logger.Log = "Запись удалена успешно";
            }
            catch (Exception ex)
            {
                _logger.Log = ex.Message;
            }
        }
    }
}
