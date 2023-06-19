using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data_Base
{
    public class DBRecord
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string Version { get; set; }
        public DateTime CreateDate { get; set; }

        public DBRecord()
        {}

        public DBRecord(int id, string fileName, string version, DateTime createDate)
        {
            Id = id;
            FileName = fileName;
            Version = version;
            CreateDate = createDate;
        }
    }
}
