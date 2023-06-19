using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Models.Interfaces;
using Library.Data_Base;

namespace App.Models
{
    internal class DataBaseManager : IDataBaseManager
    {
        private DataBase _dataBase;
        private bool isConnected;
        public DataBaseManager() 
        {
            isConnected = Connect();
        }

        public List<DBRecord> Records 
        {
            get 
            {
                if (isConnected)
                {
                    return _dataBase.GetRecords();
                }
                return null;
            }
        }

        public bool Connected
        {
            get { return isConnected; }
        }

        private bool Connect()
        {
            _dataBase = new DataBase();
            return _dataBase.Database.Connection.State == System.Data.ConnectionState.Open;
        }

        public void AddRecord(DBRecord record)
        {
            if (isConnected)
            {
                _dataBase.AddRecord(record);
            }
        }

        public void DeleteRecord(int i)
        {
            if (isConnected)
            {
                _dataBase.RemoveRecord(i);
            }
        }

        public void EditRecord(int i, DBRecord record)
        {
            if (isConnected)
            {
                _dataBase.EditRecord(i, record);
            }
        }

        public DBRecord GetRecord(int i)
        {
            if (isConnected)
            {
                return _dataBase.GetRecord(i);
            }
            return null;
        }
    }
}
