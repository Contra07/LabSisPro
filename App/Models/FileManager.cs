using System;
using System.Collections.Generic;
using Library.File;
using App.Models.Interfaces;

namespace App.Models
{
    internal class FileManager: IFileManager
    {
        private CustomFile file;

        public List<Record> Records
        {
            get 
            {
                if (file != null) 
                {
                    return file.Records;
                }
                return null; 
            }
        }

        public void OpenFile()
        {
            file = CustomFile.OpenFile();
            if (file == null) 
            {
                throw new Exception("Ошибка открытия файла");
            }
        }

        public void CreateFile()
        {
            file = new CustomFile();
        }

        public void SaveFile()
        {
            if (file != null)
            {
                if (file.Path == null)
                {
                    file.SaveFileAs();
                }
                else
                {
                    file.SaveFile();
                }
            }
            else 
            {
                throw new Exception("Ошибка. Файл отсутствует");
            }
        }

        public void AddRecord(Record record) 
        {
            if (file != null && record != null)
            {
                file.AddRecord(record);
            }
            else
            {
                throw new Exception("Ошибка. Файл отсутствует");
            }
        }

        public void DeleteRecord(int i) 
        {
            if (file != null) 
            {
                if (i >= 0) 
                {
                    file.RemoveRecord(i);
                }
                else
                {
                    throw new Exception("Ошибка удаления");
                }
            }
            else
            {
                throw new Exception("Ошибка. Файл отсутствует");
            }
        }

        public void EditRecord(int i, Record record) 
        {
            if (file != null)
            {
                if (i >= 0 && i < Records.Count)
                {
                    file.EditRecord(i, record);
                }
                else
                {
                    throw new Exception("Ошибка изменения");
                }
            }
            else
            {
                throw new Exception("Ошибка. Файл отсутствует");
            }
        }

    }
}
