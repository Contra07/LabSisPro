using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.File
{
    /// <summary>
    /// Класс записи в CSV файле
    /// </summary>
    public class Record
    {
        /// <summary>
        /// Имя файла
        /// </summary>
        private readonly string _fileName;
        /// <summary>
        /// Версия файла
        /// </summary>
        private readonly string _version;
        /// <summary>
        /// Дата создания файла
        /// </summary>
        private readonly DateTime _createDate;

        /// <summary>
        /// Инициализация записи в файле
        /// </summary>
        /// <param name="fileName">     Имя файла</param>
        /// <param name="version">      Версия файла</param>
        /// <param name="createDate">   Дата создания</param>
        public Record(string fileName, string version, DateTime createDate)
        {
            _fileName = fileName;
            _version = version;
            _createDate = createDate;
        }
        /// <summary>
        /// Имя файла
        /// </summary>
        public string FileName
        {
            get { return _fileName; }
        }
        /// <summary>
        /// Версия файла
        /// </summary>
        public string Version
        {
            get { return _version; }
        }
        /// <summary>
        /// Дата создания файла
        /// </summary>
        public DateTime CreateDate 
        {
            get { return _createDate; }
        }
    }
}
