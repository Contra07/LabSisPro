using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using App.Models.Interfaces;

namespace App.Models
{
    internal class Logger: ILogger
    {
        private const string FILE_NAME = "Log.txt";
        private FileStream fileStream;
        private StreamWriter writer;
        private string _log = "";

        public Logger() 
        {
            fileStream = new FileStream(FILE_NAME, FileMode.Create);
            fileStream.Close();
        }

        public string Log 
        {
            set 
            {
                string newMassage = $"[{DateTime.Now.ToLongTimeString()}]: {value}";
                _log += newMassage + "\r\n";
                fileStream = new FileStream(FILE_NAME, FileMode.OpenOrCreate);
                fileStream.Position=fileStream.Length;
                writer = new StreamWriter(fileStream);
                writer.WriteLine(newMassage);
                writer.Flush();
                writer.Close();
                fileStream.Close();
                if (NewMassage != null) 
                {
                    NewMassage();
                }
            }
            get 
            {
                return _log;
            }
        }

        public event Action NewMassage;
    }
}
