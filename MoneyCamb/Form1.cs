using DataBase.Classes;
using DataBase.IContext;
using LogicalLayer;
using MoneyCamb.Forms;
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

namespace MoneyCamb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool UseDate = false;
        private bool UseClient = false;
        private Coins orCoin;
        private Coins deCoin;
        private void Test()
        {
            DbOperations op = new DbOperations();
        }

        #region LoadLists

        //Carrega os métodos responsáveis por carregar as listas de operãções e moedas
        private void set_Lists()
        {
            set_Coins();
            set_Operations(false);
            
           
        }
        private void set_Coins()
        {
            //Carrega todas as moedas disponíveis para câmbio e coloca dentro de uma combobox
            cbxDestCoin.Items.Clear();
            cbxOriginCoin.Items.Clear();
            DbOperations op = new DbOperations();
            List<Coins> coins = op.Get_All_Coins();
            foreach (var coin in coins)
            {
                cbxDestCoin.Items.Add(coin.CoinName);
                cbxOriginCoin.Items.Add(coin.CoinName);
            }
            if (coins.Count > 0)
            {
                cbxDestCoin.SelectedIndex = 0;
                cbxOriginCoin.SelectedIndex = 0;
            }

        }
        private void set_Operations(bool Usefilter)
        {
            //Carrega todas as operações registradas no sistema. Se a prorpiedade Usefilter estiver ativa ele chama o método responsável por carregar os filtros.
            DbOperations opp = new DbOperations();

            if (Usefilter)
            {
                if (UseDate && UseClient == false)
                {
                    List<Operations> op = Filter_byDate();
                    load_items(op);
                }
                else if (UseDate && UseClient)
                {
                    List<Operations> op = Filter_byDateAndByClient();
                    load_items(op);
                }
                else if (UseDate == false && UseClient)
                {
                    List<Operations> op = Filter_byClient();
                    load_items(op);
                }
                else
                {
                    List<Operations> operations = opp.Get_All_Operations();
                    load_items(operations);
                }
            }
            else{
                List<Operations> operations = opp.Get_All_Operations();
                load_items(operations);
            }
            
            
        }
        #endregion


        #region filters
        //Todos os filtros utilizados, o primeiro usando as datas e o nome do cliente, o segundo somente a data e o terceiro somente o cliente, são chamados 
        //no metodo set_operations


        private List<Operations> Filter_byDateAndByClient()
        {
            DbOperations op = new DbOperations();
            List<Operations> operations = op.Get_All_Operations().Where(b => b.Operation_Date.Date >= datestart.Value.Date && b.Operation_Date.Date <= dateend.Value.Date & b.Client.ToLower() == textBox1.Text.ToLower()).ToList();
            return operations;
        }
        private List<Operations> Filter_byDate()
        {
            DbOperations op = new DbOperations();
            List<Operations> operations = op.Get_All_Operations().Where(b => b.Operation_Date.Date >= datestart.Value.Date & b.Operation_Date.Date <= dateend.Value.Date).ToList();
            return operations;
        }

        private List<Operations> Filter_byClient()
        {
            DbOperations op = new DbOperations();
            List<Operations> operations = op.Get_All_Operations().Where(b => b.Client.ToLower() == textBox1.Text.ToLower()).ToList() ;
            return operations;
        }
        #endregion
        
        //Carrega uma lista predeterminada de operações, usado no método set_operations.
        private void load_items(List<Operations> op)
        {
            flowitems.Controls.Clear();
            foreach (var operation in op)
            {
                ListItemOp o = new ListItemOp();
                o.ClientName = operation.Client;
                o.DestCoin = operation.Dest_Coin;
                o.OriginCoin = operation.Origin_Coin;
                o.ValueOrigin = Convert.ToString(operation.Origin_Value);
                o.ValueFinal = Convert.ToString(operation.Dest_Value);
                o.Date = Convert.ToString(operation.Operation_Date.Date);
                o.Click += O_Click;
                flowitems.Controls.Add(o);
            }
        }

        #region Events

        //Evento responsável por verificar em qual item da lista de operações foi selecionado e mostra um relatório dele
        private void O_Click(object sender, EventArgs e)
        {
            DbOperations db = new DbOperations();
            ListItemOp op = (ListItemOp)sender;
            Operations operation = db.Get_All_Operations().Where(b => b.Client.ToLower() == op.ClientName.ToLower()).First();
            RelatoryForm relatory = new RelatoryForm();
            relatory.listItem = operation;
            relatory.Show();
        }


        //Evento click do botão salvar das operações, salva a operação e chama a função para salvar no banco de dados
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClient.Text) || nudValorOrigin.Value.Equals(0))
            {
                MessageBox.Show("Por favor preencha os campos Disponíveis");
            }
            else
            {

                DbOperations op = new DbOperations();
                op.Insert_Operation(txtClient.Text, cbxDestCoin.SelectedItem.ToString(), decimal.ToDouble(nudNewValue.Value), datenow.Value.Date, cbxOriginCoin.SelectedItem.ToString(),
                                       decimal.ToDouble(nudValorOrigin.Value), decimal.ToDouble(NudRate.Value));
                set_Operations(false);
            }
            nudNewValue.Value = 0;
            nudValorOrigin.Value = 0;
            btnSave.Enabled = false;
            NudRate.Value = 0;
            txtClient.Clear();
        }


        //Evento click do botão salvar das moedas, salva a moeda no banco de dados e já a carrega na combobox de moédas de cambio
        private void btnSaveCoin_Click(object sender, EventArgs e)
        {
            DbOperations op = new DbOperations();
            op.insert_Coin(txtCoinName.Text, decimal.ToDouble(nudCoinRealValue.Value));
            set_Coins();
            txtCoinName.Clear();
            nudCoinRealValue.Value = 0;
        }


        //Evemto click da lupa para pesquisar operações com filtros
        private void panel1_Click(object sender, EventArgs e)
        {
            set_Operations(true);
        }

        //Detecta se há alteração na caixa de texto de busca por cliente, se sim uma prorpriedade global que indica que o filtro de cliente está sendo usado é setada para true
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UseClient = true;
        }

        //Detecta se há alteração nos dateTime de busca, se sim uma prorpriedade global que indica que o filtro de data está sendo usado é setada para true

        private void dateend_ValueChanged(object sender, EventArgs e)
        {
            UseDate = true;
        }

        private void datestart_ValueChanged(object sender, EventArgs e)
        {
            UseDate = true;
        }

        //Reseta os filtros
        private void resetBtn_Click(object sender, EventArgs e)
        {
            UseDate = false;
            UseClient = false;
            textBox1.Clear();
            dateend.Value = DateTime.Now; 
            datestart.Value = DateTime.Now;
            set_Operations(false);
        }


        //Seta variáveis globais responsáveis por indicar qual a moeda de origem e qual a moeda de destino
        private void cbxDestCoin_SelectedIndexChanged(object sender, EventArgs e)
        {
            DbOperations op = new DbOperations();
            deCoin = op.Get_All_Coins().Where(b => b.CoinName == cbxDestCoin.SelectedItem.ToString()).First();
            txtRateCoin.Text = deCoin.CoinName;
        }

        private void cbxOriginCoin_SelectedIndexChanged(object sender, EventArgs e)
        {
            DbOperations op = new DbOperations();
            orCoin = op.Get_All_Coins().Where(b => b.CoinName == cbxOriginCoin.SelectedItem.ToString()).First();
        }


        //Carrega as moedas e caso tenha pelo menos uma moeda cadastrada e seta os index de cada combobox para o primeiro que encontrar
        private void Form1_Load(object sender, EventArgs e)
        {
            DbOperations op = new DbOperations();
            set_Lists();
            if (op.Get_All_Coins().Count > 0)
            {
                deCoin = op.Get_All_Coins().Where(b => b.CoinName == cbxDestCoin.SelectedItem.ToString()).First();
                orCoin = op.Get_All_Coins().Where(b => b.CoinName == cbxOriginCoin.SelectedItem.ToString()).First();
            }
        }

        //Calcula e preenche o valor convertido e a taxa cobrada
        private void txtCalc_Click(object sender, EventArgs e)
        {
            calculateValue value = new calculateValue(decimal.ToDouble(nudValorOrigin.Value));
            nudNewValue.Value = Convert.ToDecimal(value.Get_DestValue(deCoin, orCoin));
            NudRate.Value = Convert.ToDecimal(value.Get_Rate());
            btnSave.Enabled = true;
        }
        #endregion
    }

}
