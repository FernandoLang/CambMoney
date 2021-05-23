using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyCamb.UserControls
{
    public partial class ListItemOp : UserControl
    {
        public string ClientName
        {
            get { return lblClient.Text; }
            set { lblClient.Text = value; }

        }
        public string ValueOrigin
        {
            get { return lblOriginValue.Text; }
            set { lblOriginValue.Text = value; }
        }
        public string ValueFinal
        {
            get { return lblDestValue.Text; }
            set { lblDestValue.Text = value; }
        }
        public string OriginCoin
        {
            get { return lblOriginCoin.Text; }
            set { lblOriginCoin.Text = value; }
        }
        public string DestCoin
        {
            get { return lblDestCoin.Text; }
            set { lblDestCoin.Text = value; }
        }
        public string Date
        {
            get { return lblDate.Text; }
            set { lblDate.Text = value; }
        }
        public ListItemOp()
        {
            InitializeComponent();
        }
    }
}
