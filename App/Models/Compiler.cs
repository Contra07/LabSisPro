using Library;
using App.Models.Interfaces;

namespace App.Models
{
    internal class Compiler : ICompiler
    {
        string _fileName;
        public Compiler(string fileName) 
        {
            _fileName = fileName;
        }
        public string CountForCycle(string code)
        {
            return ForCompiler.RunExeFile(ForCompiler.CompileExeFile(code, _fileName));
        }
    }
}
