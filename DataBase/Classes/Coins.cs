using DataBase.IContext;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Classes
{
    //Essa classe será mapeada e irá gerar uma tabela Coins no banco de dados com as propriedades definidas
    public class Coins
    {
        [Key()]
        public int Id { get; set; }
        public string CoinName { get; set; }
        public double RealValue { get; set; }

        //Equivalente a INSERT INTO TABLE Coins(CoinName, RealValue) values(CoinNameValue, RealValueValue);
        public void Save()
        {
            IContextDB db = new IContextDB();
            db.coins.Add(this);
            db.SaveChanges();
        }
        //Equivalente a SELECT * FROM Coins;
        public static List<Coins> get_all()
        {
            IContextDB db = new IContextDB();
            return db.coins.ToList();
        }
    }
}
