using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Text;

namespace Library
{
    public static class ForCompiler
    {
        private const string COUNTER_NAME = "myCounterABCDEFGI";
        public static CompilerResults CompileExeFile(string input, string fileName)
        {
            //string code = input.Replace(" ", string.Empty);
            //code = code.Replace("\r", string.Empty);
            //code = code.Replace("\n", string.Empty);
            string code = input;

            int indexFor = code.IndexOf("for");
            if (indexFor == -1)
            {
                throw new Exception("Ошибка синтаксиса цикла for");
            }
            int indexFirstBracket = code.IndexOf("(", indexFor);
            if (indexFirstBracket == -1)
            {
                throw new Exception("Ошибка синтаксиса цикла for");
            }
            int indexFirstComma = code.IndexOf(";", indexFirstBracket);
            if (indexFirstComma == -1)
            {
                throw new Exception("Ошибка синтаксиса цикла for");
            }
            int indexSecondComma = code.IndexOf(";", indexFirstComma+1);
            if (indexSecondComma == -1)
            {
                throw new Exception("Ошибка синтаксиса цикла for");
            }
            int indexSecondBracket = code.IndexOf(")", indexSecondComma);
            if (indexSecondBracket == -1)
            {
                throw new Exception("Ошибка синтаксиса цикла for");
            }
            int indexFirstSquareBracket = code.IndexOf("{", indexSecondBracket);
            if (indexFirstSquareBracket == -1)
            {
                throw new Exception("Ошибка синтаксиса цикла for");
            }
            int indexSecondSquareBracket = code.IndexOf("}", indexFirstSquareBracket);
            if (indexSecondSquareBracket == -1)
            {
                throw new Exception("Ошибка синтаксиса цикла for");
            }
            code = code.Insert(indexSecondSquareBracket+1, "Console.WriteLine("+COUNTER_NAME+ ");");
            code = code.Insert(indexFirstSquareBracket + 1, COUNTER_NAME + "++;");
            code = code.Insert(indexFor, "int " + COUNTER_NAME + "=0;");
            
            
            string[] codes = { string.Format("using System; namespace HelloWorld\n {{ class HelloWorldClass{{static void Main(string[] args){{{0}}}}}}}", code)};
            // Задаём язык
            CodeDomProvider codeProvider = CodeDomProvider.CreateProvider("CSharp");
            // Имя файла
            CompilerParameters parameters = new CompilerParameters
            {
                GenerateExecutable = true,
                OutputAssembly = fileName + ".exe"
            };
            // создаём exeFile
            CompilerResults result = codeProvider.CompileAssemblyFromSource(parameters, codes);
            if (result.Errors.Count > 0)
            {
                throw new Exception("Ошибка синтаксиса");
            }
            return result;
        }

        public static string RunExeFile(CompilerResults results) 
        {
            Process process = new Process();

            // Задаём стартовые параметры 
            process.StartInfo.FileName = results.PathToAssembly;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = false;
            process.StartInfo.UseShellExecute = false;

            // В StringBuilder будем добавлять полученные данные
            var sb = new StringBuilder(string.Empty);
            // Запускаем процесс
            process.Start();
            while (!process.StandardOutput.EndOfStream)
            {
                sb.Append(process.StandardOutput.ReadLine());
            }
            process.Close();

            return sb.ToString();
        }
    }
}
