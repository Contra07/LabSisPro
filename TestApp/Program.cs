using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Library;
using System.Data.SqlClient;

namespace TestApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }
    }

    class MySqlClass
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-18PC82B\SQLEXPRESS; Initial Catalog=CSV;Integrated Security=True");
        
        public void Method()
        {
            sqlConnection.Open();
            var r = sqlConnection.GetSchema();
            sqlConnection.Close();
        }
    }

    class FunctionLowController
    {
        private object obj;
        private MethodInfo m;
        public FunctionLowController()
        {
            Assembly asm = Assembly.Load(File.ReadAllBytes(AsmFunction.MODULE_NAME));
            Type type = asm.GetType(AsmFunction.TYPE_NAME);
            m = type.GetMethod(AsmFunction.METHOD_NAME, BindingFlags.Instance | BindingFlags.Public);
            obj = Activator.CreateInstance(type);
        }
        public int getValueXOR(int val1, int val2)
        {
            return (Int32)m.Invoke(obj, new object[] { val1, val2 });
        }
    }
}
