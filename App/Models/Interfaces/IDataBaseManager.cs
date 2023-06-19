using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Data_Base;

namespace App.Models.Interfaces
{
    internal interface IDataBaseManager
    {
        List<DBRecord> Records
        {
            get;
        }

        bool Connected 
        {
            get;
        }

        DBRecord GetRecord(int i);
        void AddRecord(DBRecord record);
        void DeleteRecord(int i);
        void EditRecord(int i, DBRecord record);
    }
}
