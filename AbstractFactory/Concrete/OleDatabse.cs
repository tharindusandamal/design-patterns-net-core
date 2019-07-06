using AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Concrete
{
    public class OleDatabse : Database
    {
        private DbConnection _connection = null;
        private DbCommand _command = null;

        public override DbConnection Connection { get {
                if(_connection == null)
                    _connection = new OleDbConnection(ConfigurationManager.ConnectionStrings["Ole.Db.Connection"].ConnectionString);

                return _connection;
            } set => _connection = value; }

        public override DbCommand Command { get {
                if (_command == null)
                {
                    _command = new OleDbCommand();
                    _command.Connection = _connection;
                }
                return _command;
            } set => base.Command = value; }
    }
}
