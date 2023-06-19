using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Library.Data_Base
{
    public class DataBase : DbContext
    {
        public DbSet<DBRecord> Records { get; set; }

        public DataBase() : base("DbConnectionString")
        {

        }

        public List<DBRecord> GetRecords()
        {
            return Records.OrderBy(x => x.Id).ToList();
        }

        public void AddRecord(DBRecord record)
        {
            Records.Add(record);
            SaveChanges();
        }

        public void RemoveRecord(int id) 
        {
            Records.RemoveRange(Records.Where(x => x.Id == id).ToList());
            SaveChanges();
        }

        public void EditRecord(int id, DBRecord record)
        {
            Records.Single(x => x.Id == id).FileName = record.FileName;
            Records.Single(x => x.Id == id).Version = record.Version;
            Records.Single(x => x.Id == id).CreateDate = record.CreateDate;
            SaveChanges();
        }

        public DBRecord GetRecord(int id)
        {
            return Records.Single(x => x.Id == id);
        }

    }
}
