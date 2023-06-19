using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Data_Base;

namespace App.Views.Interfaces
{
    internal interface IDBRecordView
    {
        DBRecord EditDBRecord(DBRecord record);
        DBRecord NewDBRecord();
    }
}
