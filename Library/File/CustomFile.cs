using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System;


namespace Library.File
{
    /// <summary>
    /// Класс CSV файла
    /// </summary>
    public class CustomFile
    {
        /// <summary>
        /// Тип файла
        /// </summary>
        public const string FILE_TYPE = "CSV Files (*.csv)|*.csv";
        /// <summary>
        /// Путь к файлу
        /// </summary>
        private string _path;
        /// <summary>
        /// Записи в файле
        /// </summary>
        private List<Record> _records;

        /// <summary>
        /// Записи в файле
        /// </summary>
        public List<Record> Records
        {
            get { return _records; }
        }

        /// <summary>
        /// Путь к файлу
        /// </summary>
        public string Path 
        {
            get { return _path; }
        }

        /// <summary>
        /// Создание нового пустого файла
        /// </summary>
        public CustomFile()
        {
            _path = null;
            _records = new List<Record>();
        }

        /// <summary>
        /// Созданеи файла из существующего
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <param name="records">Записи в файле</param>
        private CustomFile(string path, List<Record> records)
        {
            _path = path;
            _records = records;
        }

        /// <summary>
        /// Открытие существующего файла
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <returns></returns>
        public static CustomFile OpenFile()
        {
            CustomFile file = null;
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = FILE_TYPE;
            if (fileDialog.ShowDialog() == DialogResult.OK )
            {
                StreamReader fileStreamReader = new StreamReader(fileDialog.OpenFile());
                List<Record> records = new List<Record>();
                if (!fileStreamReader.EndOfStream)
                {
                    while (!fileStreamReader.EndOfStream) 
                    {
                        try
                        {
                            string[] line = fileStreamReader.ReadLine().Split(';');
                            if (line != null && line.Length == 3)
                            {
                                records.Add(new Record(line[0], line[1], DateTime.Parse(line[2])));
                            }
                        }
                        catch 
                        {
                            throw new Exception("Ошибка формата файла"); 
                        }
                        
                    }
                }
                file = new CustomFile(fileDialog.FileName, records);
                fileStreamReader.Close();
            }
            return file;
        }

        /// <summary>
        /// Сохранение файла
        /// </summary>
        public void SaveFileAs()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = FILE_TYPE;
            if (saveFileDialog.ShowDialog() == DialogResult.OK && _records != null)
            {
                _path = saveFileDialog.FileName;
                SaveFile();
            }
            else 
            {
                throw new Exception("Ошибка сохранения файла");
            }
        }
        /// <summary>
        /// Сохранение файла
        /// </summary>
        public void SaveFile()
        {
            StreamWriter fileStreamWriter = new StreamWriter(new FileStream(_path, FileMode.Create));
            foreach (Record record in _records)
            {
                fileStreamWriter.WriteLine(record.FileName + ";" + record.Version + ";" + record.CreateDate.ToString());
            }
            fileStreamWriter.Close();
        }

        /// <summary>
        /// Удаление записи
        /// </summary>
        /// <param name="i">Номер записи</param>
        public void RemoveRecord(int i) 
        {
            if (i < _records.Count && i > -1 && _records != null) 
            {
                _records.RemoveAt(i);
            }
        }

        /// <summary>
        /// Редактирвоание файла
        /// </summary>
        /// <param name="i">Номер записи</param>
        /// <param name="newRecord">Новая запись</param>
        public void EditRecord(int i, Record newRecord) 
        {
            if (i < _records.Count && i > -1 && newRecord != null)
            {
                _records[i] = newRecord;
            }
        }

        /// <summary>
        /// Добавление записи в конец
        /// </summary>
        /// <param name="newRecord">Новая запись</param>
        public void AddRecord(Record newRecord)
        {
            if (newRecord != null && _records != null) 
            {
                _records.Add(newRecord);
            }
        }


    }
}
