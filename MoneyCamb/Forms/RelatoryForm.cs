using DataBase.Classes;
using MoneyCamb.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyCamb.Forms
{
    public partial class RelatoryForm : Form
    {
        Operations op;
        public Operations listItem
        {
            get { return this.op; }
            set { op = value; }
        }
        public RelatoryForm()
        {
            InitializeComponent();
        }

        private void RelatoryForm_Load(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            foreach (var item in makeRel())
            {
                richTextBox1.Text += item + "\r\n";
            }
        }
        private string[] makeRel()
        {
            string[] n = new string[5];
            n[0] = string.Format("O cliente {0} solicitou a seguinte operação de cãmbio:", op.Client);
            n[1] = string.Format("A moeda de origem {0}, foi convertida para {1} na data de {2} \r\n", op.Origin_Coin, op.Dest_Coin, op.Operation_Date.Date.ToString());
            n[2] = string.Format("O valor de origem {0}({1}) foi convertido para {2}({3}) já com o desconto da taxa \r\n",op.Origin_Value.ToString(), op.Origin_Coin, op.Dest_Value.ToString(), op.Dest_Coin);
            n[3] = string.Format("A taxa foi de {0}({1}) \r\n", op.rate.ToString(), op.Dest_Coin);
            n[4] = string.Format("O Valor convertido sem o desconto da taxa é de {0}({1}) \r\n", (op.Dest_Value + op.rate).ToString(), op.Dest_Coin);
            return n;
        }
    }
}
