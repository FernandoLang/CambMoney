using DataBase.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalLayer
{
    public class DbOperations
    {
        public void Insert_Operation(string Client, string Dest_Coin, double Dest_Value, DateTime Operation_Date, string Origin_Coin, double Origin_Value, double rate)
        {
            new Operations()
            {
                Client = Client,
                Dest_Coin = Dest_Coin,
                Dest_Value = Dest_Value,
                Operation_Date = Operation_Date,
                Origin_Coin = Origin_Coin,
                Origin_Value = Origin_Value,
                rate = rate
            }.Save();
        }
        public void insert_Coin(string coin_name, double Real_Value)
        {
            new Coins()
            {
                CoinName = coin_name,
                RealValue = Real_Value
            }.Save();
        }
        public List<Coins> Get_All_Coins()
        {
            return Coins.get_all();
        }
        public List<Operations> Get_All_Operations()
        {
            return Operations.get_all();
        }






    }
}
