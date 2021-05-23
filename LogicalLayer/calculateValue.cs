using DataBase.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalLayer
{
    public class calculateValue
    {
        private double value;
        private double rate;

        //Construtor que seta a propriedade value
        public calculateValue(double value)
        {
            this.value = value;
        }

        //Responsável por calcular o valor convertido, esse método sempre converte primeiro para Real e depois para a moeda de destino
        public double Get_DestValue(Coins coind, Coins coino)
        {
            if (coind.CoinName == coino.CoinName)
            {
                return value;
            }
            double new_value = (value * coino.RealValue) / coind.RealValue;
            rate = Convert.ToDouble(((new_value / 100) * 10).ToString("F"));
            double valor_liquido = new_value - rate;
            return Convert.ToDouble(valor_liquido.ToString("F"));
        }
        //Retorna a taxa
        public double Get_Rate()
        {
            return rate;
        }


    }
}
