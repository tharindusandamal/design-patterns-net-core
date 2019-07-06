using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Abstract
{
    public abstract class Database
    {
        //Provide an interface for creating families of related or 
        //dependent objects without specifying their concrete classes.

        public virtual DbConnection Connection { get; set; }
        public virtual DbCommand Command { get; set; }
    }
}
