using DataBase.IContext;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Classes
{
    //Classe que será mapeada e irá gerar uma tabela Operations no banco de dados com as propriedades especificadas
    public class Operations
    {
        [Key()]
        public int Operation_Id { get; set; }
        public string Client { get; set; }
        public string Origin_Coin { get; set; }
        public string Dest_Coin { get; set; }
        public double Origin_Value { get; set; }
        public double Dest_Value { get; set; }
        public DateTime Operation_Date { get; set; }
        public double rate { get; set; }

        //Equivalente a INSERT INTO TABLE Operations(Cliente, Origin_Coin....etc) values (ClientValue, Origin_CoinValue....etc)
        public void Save()
        {
            IContextDB db = new IContextDB();
            db.operations.Add(this);
            db.SaveChanges();
        }
        //Equivalente a SELECT * FROM Operations
        public static List<Operations> get_all()
        {
            IContextDB db = new IContextDB();
            return db.operations.ToList();
        }
    }
}
