using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.Views.Interfaces
{
    internal interface IDataBaseView
    {
        event Action AddDBRecord;
        event Action DeleteDBRecord;
        event Action EditDBRecord;
        int SelectedDBRecordIndex { get; }
        DataGridView DataBaseTable { get; }
    }
}
