using AbstractFactory.Abstract;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Concrete
{
    public class SqlServerDatabase : Database
    {
        private DbConnection _connection = null;
        private DbCommand _command = null; 

        public override DbConnection Connection {
            get
            {
                if (_connection == null)
                {
                    _connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Sql.Server.Connection"].ConnectionString);
                    return _connection;
                }
                else
                    return _connection;
            }
            set => _connection = value; }

        public override DbCommand Command {
            get {
                if(_command == null)
                {
                    _command = new SqlCommand();
                    _command.Connection = _connection;
                }
                return _command;
            } set => _command = value; }
    }
}
