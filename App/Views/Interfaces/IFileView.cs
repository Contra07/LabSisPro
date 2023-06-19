using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace App.Views.Interfaces
{
    internal interface IFileView
    {
        event Action CreateFile;
        event Action SaveFile;
        event Action OpenFile;
        event Action AddRecord;
        event Action DeleteRecord;
        event Action EditRecord;
        //event Action Close;
        int SelectedRecordIndex { get;  }
        IBindingList FileTable { set; }
    }
}
