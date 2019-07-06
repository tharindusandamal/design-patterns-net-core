using AbstractFactory.Abstract;
using AbstractFactory.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractFactory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database _database;
            DbCommand _command;

            if (radioButton_SqlSrver.Checked)
            {
                _database = new SqlServerDatabase();
            }
            else
            {
                _database = new OleDatabse();
            }

            _command = _database.Command;
            _command.CommandText = "GetUsers";
            _command.CommandType = CommandType.StoredProcedure;
            _database.Connection.Open();

        }
    }
}
