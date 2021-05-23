using DataBase.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.IContext
{
    public class IContextDB: DbContext
    {

        //Responsávvel por mapear as classes coins e operations para criar o banco de dados
        public IContextDB() : base("name=CambMoney") {
            this.Database.CreateIfNotExists();
        }

        public static DbContext create()
        {
            return new IContextDB();
        }
        
        public DbSet<Coins> coins { get; set; }
        public DbSet<Operations> operations { get; set; }

    }
}
