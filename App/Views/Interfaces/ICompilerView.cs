using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Views.Interfaces
{
    internal interface ICompilerView
    {
        string Result { set; }
        string Code { get; }
        event Action Compile;
    }
}
