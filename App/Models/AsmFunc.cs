using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Models.Interfaces;
using System.Reflection;
using System.IO;
using Library;


namespace App.Models
{
    internal class AsmFunc : IAsmFunc
    {
        private object obj;
        private MethodInfo m;
        public AsmFunc()
        {
            AsmFunction.CreateORLibrary();
            Assembly asm = Assembly.Load(File.ReadAllBytes(AsmFunction.MODULE_NAME));
            Type type = asm.GetType(AsmFunction.TYPE_NAME);
            m = type.GetMethod(AsmFunction.METHOD_NAME, BindingFlags.Instance | BindingFlags.Public);
            obj = Activator.CreateInstance(type);
        }
        public int Method(int val1, int val2)
        {
            return (Int32)m.Invoke(obj, new object[] { val1, val2 });
        }
    }
}
