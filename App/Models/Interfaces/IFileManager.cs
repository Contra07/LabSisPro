using Library.File;
using System.Collections.Generic;

namespace App.Models.Interfaces
{
    internal interface IFileManager
    {
        List<Record> Records 
        {
            get;
        }
        void OpenFile();
        void CreateFile();
        void SaveFile();
        void AddRecord(Record record);
        void DeleteRecord(int i);
        void EditRecord(int i, Record record);
    }
}
