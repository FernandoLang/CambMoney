
namespace MoneyCamb
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtClient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.datenow = new System.Windows.Forms.DateTimePicker();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtCalc = new System.Windows.Forms.Button();
            this.txtRateCoin = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NudRate = new System.Windows.Forms.NumericUpDown();
            this.nudNewValue = new System.Windows.Forms.NumericUpDown();
            this.nudValorOrigin = new System.Windows.Forms.NumericUpDown();
            this.cbxOriginCoin = new System.Windows.Forms.ComboBox();
            this.cbxDestCoin = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSaveCoin = new System.Windows.Forms.Button();
            this.nudCoinRealValue = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCoinName = new System.Windows.Forms.TextBox();
            this.flowitems = new System.Windows.Forms.FlowLayoutPanel();
            this.datestart = new System.Windows.Forms.DateTimePicker();
            this.dateend = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.resetBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValorOrigin)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoinRealValue)).BeginInit();
            this.SuspendLayout();
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(152, 31);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(121, 23);
            this.txtClient.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cliente :";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Enabled = false;
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSave.Location = new System.Drawing.Point(121, 247);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // datenow
            // 
            this.datenow.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datenow.Location = new System.Drawing.Point(284, 3);
            this.datenow.Name = "datenow";
            this.datenow.Size = new System.Drawing.Size(84, 23);
            this.datenow.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(381, 333);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtCalc);
            this.tabPage1.Controls.Add(this.txtRateCoin);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.NudRate);
            this.tabPage1.Controls.Add(this.nudNewValue);
            this.tabPage1.Controls.Add(this.nudValorOrigin);
            this.tabPage1.Controls.Add(this.cbxOriginCoin);
            this.tabPage1.Controls.Add(this.cbxDestCoin);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.datenow);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtClient);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(373, 305);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Operações";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtCalc
            // 
            this.txtCalc.BackColor = System.Drawing.Color.Transparent;
            this.txtCalc.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.txtCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtCalc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtCalc.Location = new System.Drawing.Point(278, 167);
            this.txtCalc.Name = "txtCalc";
            this.txtCalc.Size = new System.Drawing.Size(75, 23);
            this.txtCalc.TabIndex = 14;
            this.txtCalc.Text = "Calcular";
            this.txtCalc.UseVisualStyleBackColor = false;
            this.txtCalc.Click += new System.EventHandler(this.txtCalc_Click);
            // 
            // txtRateCoin
            // 
            this.txtRateCoin.AutoSize = true;
            this.txtRateCoin.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRateCoin.Location = new System.Drawing.Point(278, 208);
            this.txtRateCoin.Name = "txtRateCoin";
            this.txtRateCoin.Size = new System.Drawing.Size(0, 20);
            this.txtRateCoin.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(14, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Taxa :";
            // 
            // NudRate
            // 
            this.NudRate.DecimalPlaces = 2;
            this.NudRate.Enabled = false;
            this.NudRate.InterceptArrowKeys = false;
            this.NudRate.Location = new System.Drawing.Point(152, 205);
            this.NudRate.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.NudRate.Minimum = new decimal(new int[] {
            1000000000,
            0,
            0,
            -2147483648});
            this.NudRate.Name = "NudRate";
            this.NudRate.ReadOnly = true;
            this.NudRate.Size = new System.Drawing.Size(120, 23);
            this.NudRate.TabIndex = 11;
            // 
            // nudNewValue
            // 
            this.nudNewValue.DecimalPlaces = 2;
            this.nudNewValue.Enabled = false;
            this.nudNewValue.Location = new System.Drawing.Point(152, 167);
            this.nudNewValue.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudNewValue.Name = "nudNewValue";
            this.nudNewValue.ReadOnly = true;
            this.nudNewValue.Size = new System.Drawing.Size(120, 23);
            this.nudNewValue.TabIndex = 10;
            // 
            // nudValorOrigin
            // 
            this.nudValorOrigin.DecimalPlaces = 2;
            this.nudValorOrigin.Location = new System.Drawing.Point(154, 118);
            this.nudValorOrigin.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudValorOrigin.Name = "nudValorOrigin";
            this.nudValorOrigin.Size = new System.Drawing.Size(120, 23);
            this.nudValorOrigin.TabIndex = 9;
            // 
            // cbxOriginCoin
            // 
            this.cbxOriginCoin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxOriginCoin.FormattingEnabled = true;
            this.cbxOriginCoin.Location = new System.Drawing.Point(153, 60);
            this.cbxOriginCoin.Name = "cbxOriginCoin";
            this.cbxOriginCoin.Size = new System.Drawing.Size(121, 23);
            this.cbxOriginCoin.TabIndex = 7;
            this.cbxOriginCoin.SelectedIndexChanged += new System.EventHandler(this.cbxOriginCoin_SelectedIndexChanged);
            // 
            // cbxDestCoin
            // 
            this.cbxDestCoin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDestCoin.FormattingEnabled = true;
            this.cbxDestCoin.Location = new System.Drawing.Point(153, 89);
            this.cbxDestCoin.Name = "cbxDestCoin";
            this.cbxDestCoin.Size = new System.Drawing.Size(121, 23);
            this.cbxDestCoin.TabIndex = 6;
            this.cbxDestCoin.SelectedIndexChanged += new System.EventHandler(this.cbxDestCoin_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(14, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Valor Convertido :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(17, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Valor :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(15, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Moeda de Origem :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Moeda de Destino :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSaveCoin);
            this.tabPage2.Controls.Add(this.nudCoinRealValue);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtCoinName);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(373, 305);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Adicionar Nova Moeda";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSaveCoin
            // 
            this.btnSaveCoin.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveCoin.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnSaveCoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveCoin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSaveCoin.Location = new System.Drawing.Point(119, 105);
            this.btnSaveCoin.Name = "btnSaveCoin";
            this.btnSaveCoin.Size = new System.Drawing.Size(75, 23);
            this.btnSaveCoin.TabIndex = 12;
            this.btnSaveCoin.Text = "Salvar";
            this.btnSaveCoin.UseVisualStyleBackColor = false;
            this.btnSaveCoin.Click += new System.EventHandler(this.btnSaveCoin_Click);
            // 
            // nudCoinRealValue
            // 
            this.nudCoinRealValue.DecimalPlaces = 2;
            this.nudCoinRealValue.Location = new System.Drawing.Point(238, 49);
            this.nudCoinRealValue.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.nudCoinRealValue.Name = "nudCoinRealValue";
            this.nudCoinRealValue.Size = new System.Drawing.Size(120, 23);
            this.nudCoinRealValue.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(3, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Valor da Moeda em Reais :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(5, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Nome da Moeda :";
            // 
            // txtCoinName
            // 
            this.txtCoinName.Location = new System.Drawing.Point(238, 20);
            this.txtCoinName.Name = "txtCoinName";
            this.txtCoinName.Size = new System.Drawing.Size(121, 23);
            this.txtCoinName.TabIndex = 2;
            // 
            // flowitems
            // 
            this.flowitems.Location = new System.Drawing.Point(381, 27);
            this.flowitems.Name = "flowitems";
            this.flowitems.Size = new System.Drawing.Size(416, 276);
            this.flowitems.TabIndex = 5;
            // 
            // datestart
            // 
            this.datestart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datestart.Location = new System.Drawing.Point(383, 1);
            this.datestart.Name = "datestart";
            this.datestart.Size = new System.Drawing.Size(84, 23);
            this.datestart.TabIndex = 6;
            this.datestart.ValueChanged += new System.EventHandler(this.datestart_ValueChanged);
            // 
            // dateend
            // 
            this.dateend.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateend.Location = new System.Drawing.Point(482, 1);
            this.dateend.Name = "dateend";
            this.dateend.Size = new System.Drawing.Size(84, 23);
            this.dateend.TabIndex = 7;
            this.dateend.ValueChanged += new System.EventHandler(this.dateend_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(640, 1);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 23);
            this.textBox1.TabIndex = 13;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(573, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cliente :";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(770, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(21, 22);
            this.panel1.TabIndex = 14;
            this.panel1.Click += new System.EventHandler(this.panel1_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.Color.Transparent;
            this.resetBtn.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.resetBtn.Location = new System.Drawing.Point(722, 306);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 23);
            this.resetBtn.TabIndex = 13;
            this.resetBtn.Text = "Resetar";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 333);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateend);
            this.Controls.Add(this.datestart);
            this.Controls.Add(this.flowitems);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNewValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudValorOrigin)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoinRealValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker datenow;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown NudRate;
        private System.Windows.Forms.NumericUpDown nudNewValue;
        private System.Windows.Forms.NumericUpDown nudValorOrigin;
        private System.Windows.Forms.ComboBox cbxOriginCoin;
        private System.Windows.Forms.ComboBox cbxDestCoin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSaveCoin;
        private System.Windows.Forms.NumericUpDown nudCoinRealValue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCoinName;
        private System.Windows.Forms.FlowLayoutPanel flowitems;
        private System.Windows.Forms.DateTimePicker datestart;
        private System.Windows.Forms.DateTimePicker dateends;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateend;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Label txtRateCoin;
        private System.Windows.Forms.Button txtCalc;
    }
}

