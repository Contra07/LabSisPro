using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Views.Interfaces
{
    internal interface IAsmFuncView
    {
        int FirstOperand { get; }
        int SecondOperand { get; }
        int AssemblyMethodResult { set; }
        event Action AssemblyMethod;
    }
}
