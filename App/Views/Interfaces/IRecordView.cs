using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.File;

namespace App.Views.Interfaces
{
    internal interface IRecordView
    {
        Record EditRecord(Record record);
        Record NewRecord();
    }
}
