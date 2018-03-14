namespace PairTrader
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                ibClient.ClientSocket.cancelMktData(A_id);
                ibClient.ClientSocket.cancelMktData(B_id);
                ibClient.ClientSocket.eDisconnect();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConnect = new System.Windows.Forms.Button();
            this.tbConnect = new System.Windows.Forms.TextBox();
            this.lblSymbol = new System.Windows.Forms.Label();
            this.tbSymbolA = new System.Windows.Forms.TextBox();
            this.lblSecType = new System.Windows.Forms.Label();
            this.tbCurrencyA = new System.Windows.Forms.TextBox();
            this.lblCurrency = new System.Windows.Forms.Label();
            this.tbExchangeA = new System.Windows.Forms.TextBox();
            this.lblExchange = new System.Windows.Forms.Label();
            this.cbSecTypeA = new System.Windows.Forms.ComboBox();
            this.tbPrimExchA = new System.Windows.Forms.TextBox();
            this.lblPrimExch = new System.Windows.Forms.Label();
            this.tbExpirationA = new System.Windows.Forms.TextBox();
            this.lblExpiry = new System.Windows.Forms.Label();
            this.tbStrikeA = new System.Windows.Forms.TextBox();
            this.lblStrike = new System.Windows.Forms.Label();
            this.cbRightA = new System.Windows.Forms.ComboBox();
            this.tbMultiplierA = new System.Windows.Forms.TextBox();
            this.lblMultiplier = new System.Windows.Forms.Label();
            this.lblRight = new System.Windows.Forms.Label();
            this.lblAssetA = new System.Windows.Forms.Label();
            this.lblAssetB = new System.Windows.Forms.Label();
            this.cbRightB = new System.Windows.Forms.ComboBox();
            this.tbMultiplierB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbStrikeB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbExpirationB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPrimExchB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbSecTypeB = new System.Windows.Forms.ComboBox();
            this.tbExchangeB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbCurrencyB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbSymbolB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnData = new System.Windows.Forms.Button();
            this.dgvPriceData = new System.Windows.Forms.DataGridView();
            this.clmnSymbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnChgOpen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnBid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnBidSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnAskSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnAsk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnVolume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnChgClose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnOpen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnHigh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnLow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnClose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnTimeStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMarketData = new System.Windows.Forms.Label();
            this.lbErrors = new System.Windows.Forms.ListBox();
            this.dgvSPData = new System.Windows.Forms.DataGridView();
            this.btnBuyPair = new System.Windows.Forms.Button();
            this.tbBuyDelta = new System.Windows.Forms.TextBox();
            this.btnSellPair = new System.Windows.Forms.Button();
            this.tbSellDelta = new System.Windows.Forms.TextBox();
            this.dgvExecutions = new System.Windows.Forms.DataGridView();
            this.dgvOrderData = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvPositions = new System.Windows.Forms.DataGridView();
            this.clmOrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPriceData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSPData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExecutions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPositions)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(8, 16);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(88, 24);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect TWS";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tbConnect
            // 
            this.tbConnect.Location = new System.Drawing.Point(104, 16);
            this.tbConnect.Name = "tbConnect";
            this.tbConnect.Size = new System.Drawing.Size(576, 20);
            this.tbConnect.TabIndex = 1;
            // 
            // lblSymbol
            // 
            this.lblSymbol.AutoSize = true;
            this.lblSymbol.Location = new System.Drawing.Point(88, 48);
            this.lblSymbol.Name = "lblSymbol";
            this.lblSymbol.Size = new System.Drawing.Size(67, 13);
            this.lblSymbol.TabIndex = 2;
            this.lblSymbol.Text = "Root Symbol";
            // 
            // tbSymbolA
            // 
            this.tbSymbolA.Location = new System.Drawing.Point(88, 72);
            this.tbSymbolA.Name = "tbSymbolA";
            this.tbSymbolA.Size = new System.Drawing.Size(72, 20);
            this.tbSymbolA.TabIndex = 3;
            this.tbSymbolA.Text = "IBM";
            // 
            // lblSecType
            // 
            this.lblSecType.AutoSize = true;
            this.lblSecType.Location = new System.Drawing.Point(168, 48);
            this.lblSecType.Name = "lblSecType";
            this.lblSecType.Size = new System.Drawing.Size(31, 13);
            this.lblSecType.TabIndex = 4;
            this.lblSecType.Text = "Type";
            // 
            // tbCurrencyA
            // 
            this.tbCurrencyA.Location = new System.Drawing.Point(248, 72);
            this.tbCurrencyA.Name = "tbCurrencyA";
            this.tbCurrencyA.Size = new System.Drawing.Size(72, 20);
            this.tbCurrencyA.TabIndex = 7;
            this.tbCurrencyA.Text = "USD";
            // 
            // lblCurrency
            // 
            this.lblCurrency.AutoSize = true;
            this.lblCurrency.Location = new System.Drawing.Point(248, 48);
            this.lblCurrency.Name = "lblCurrency";
            this.lblCurrency.Size = new System.Drawing.Size(49, 13);
            this.lblCurrency.TabIndex = 6;
            this.lblCurrency.Text = "Currency";
            // 
            // tbExchangeA
            // 
            this.tbExchangeA.Location = new System.Drawing.Point(328, 72);
            this.tbExchangeA.Name = "tbExchangeA";
            this.tbExchangeA.Size = new System.Drawing.Size(72, 20);
            this.tbExchangeA.TabIndex = 9;
            this.tbExchangeA.Text = "SMART";
            // 
            // lblExchange
            // 
            this.lblExchange.AutoSize = true;
            this.lblExchange.Location = new System.Drawing.Point(328, 48);
            this.lblExchange.Name = "lblExchange";
            this.lblExchange.Size = new System.Drawing.Size(55, 13);
            this.lblExchange.TabIndex = 8;
            this.lblExchange.Text = "Exchange";
            // 
            // cbSecTypeA
            // 
            this.cbSecTypeA.FormattingEnabled = true;
            this.cbSecTypeA.Items.AddRange(new object[] {
            "STK",
            "FUT",
            "OPT",
            "FOP",
            "IND",
            "BAG"});
            this.cbSecTypeA.Location = new System.Drawing.Point(168, 72);
            this.cbSecTypeA.Name = "cbSecTypeA";
            this.cbSecTypeA.Size = new System.Drawing.Size(72, 21);
            this.cbSecTypeA.TabIndex = 10;
            this.cbSecTypeA.Text = "STK";
            // 
            // tbPrimExchA
            // 
            this.tbPrimExchA.Location = new System.Drawing.Point(408, 72);
            this.tbPrimExchA.Name = "tbPrimExchA";
            this.tbPrimExchA.Size = new System.Drawing.Size(104, 20);
            this.tbPrimExchA.TabIndex = 12;
            this.tbPrimExchA.Text = "BATS";
            // 
            // lblPrimExch
            // 
            this.lblPrimExch.AutoSize = true;
            this.lblPrimExch.Location = new System.Drawing.Point(408, 48);
            this.lblPrimExch.Name = "lblPrimExch";
            this.lblPrimExch.Size = new System.Drawing.Size(107, 13);
            this.lblPrimExch.TabIndex = 11;
            this.lblPrimExch.Text = "PRIMARY Exchange";
            // 
            // tbExpirationA
            // 
            this.tbExpirationA.Location = new System.Drawing.Point(520, 72);
            this.tbExpirationA.Name = "tbExpirationA";
            this.tbExpirationA.Size = new System.Drawing.Size(104, 20);
            this.tbExpirationA.TabIndex = 14;
            // 
            // lblExpiry
            // 
            this.lblExpiry.AutoSize = true;
            this.lblExpiry.Location = new System.Drawing.Point(520, 48);
            this.lblExpiry.Name = "lblExpiry";
            this.lblExpiry.Size = new System.Drawing.Size(88, 13);
            this.lblExpiry.TabIndex = 13;
            this.lblExpiry.Text = "Last Trading Day";
            // 
            // tbStrikeA
            // 
            this.tbStrikeA.Location = new System.Drawing.Point(632, 72);
            this.tbStrikeA.Name = "tbStrikeA";
            this.tbStrikeA.Size = new System.Drawing.Size(72, 20);
            this.tbStrikeA.TabIndex = 16;
            // 
            // lblStrike
            // 
            this.lblStrike.AutoSize = true;
            this.lblStrike.Location = new System.Drawing.Point(632, 48);
            this.lblStrike.Name = "lblStrike";
            this.lblStrike.Size = new System.Drawing.Size(34, 13);
            this.lblStrike.TabIndex = 15;
            this.lblStrike.Text = "Strike";
            // 
            // cbRightA
            // 
            this.cbRightA.FormattingEnabled = true;
            this.cbRightA.Items.AddRange(new object[] {
            "PUT",
            "CALL"});
            this.cbRightA.Location = new System.Drawing.Point(712, 72);
            this.cbRightA.Name = "cbRightA";
            this.cbRightA.Size = new System.Drawing.Size(72, 21);
            this.cbRightA.TabIndex = 20;
            // 
            // tbMultiplierA
            // 
            this.tbMultiplierA.Location = new System.Drawing.Point(792, 72);
            this.tbMultiplierA.Name = "tbMultiplierA";
            this.tbMultiplierA.Size = new System.Drawing.Size(72, 20);
            this.tbMultiplierA.TabIndex = 19;
            this.tbMultiplierA.Text = "100";
            // 
            // lblMultiplier
            // 
            this.lblMultiplier.AutoSize = true;
            this.lblMultiplier.Location = new System.Drawing.Point(792, 48);
            this.lblMultiplier.Name = "lblMultiplier";
            this.lblMultiplier.Size = new System.Drawing.Size(48, 13);
            this.lblMultiplier.TabIndex = 18;
            this.lblMultiplier.Text = "Multiplier";
            // 
            // lblRight
            // 
            this.lblRight.AutoSize = true;
            this.lblRight.Location = new System.Drawing.Point(712, 48);
            this.lblRight.Name = "lblRight";
            this.lblRight.Size = new System.Drawing.Size(32, 13);
            this.lblRight.TabIndex = 17;
            this.lblRight.Text = "Right";
            // 
            // lblAssetA
            // 
            this.lblAssetA.AutoSize = true;
            this.lblAssetA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssetA.Location = new System.Drawing.Point(8, 64);
            this.lblAssetA.Name = "lblAssetA";
            this.lblAssetA.Size = new System.Drawing.Size(74, 24);
            this.lblAssetA.TabIndex = 21;
            this.lblAssetA.Text = "Asset A";
            // 
            // lblAssetB
            // 
            this.lblAssetB.AutoSize = true;
            this.lblAssetB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssetB.Location = new System.Drawing.Point(8, 120);
            this.lblAssetB.Name = "lblAssetB";
            this.lblAssetB.Size = new System.Drawing.Size(73, 24);
            this.lblAssetB.TabIndex = 40;
            this.lblAssetB.Text = "Asset B";
            // 
            // cbRightB
            // 
            this.cbRightB.FormattingEnabled = true;
            this.cbRightB.Items.AddRange(new object[] {
            "PUT",
            "CALL"});
            this.cbRightB.Location = new System.Drawing.Point(712, 128);
            this.cbRightB.Name = "cbRightB";
            this.cbRightB.Size = new System.Drawing.Size(72, 21);
            this.cbRightB.TabIndex = 39;
            // 
            // tbMultiplierB
            // 
            this.tbMultiplierB.Location = new System.Drawing.Point(792, 128);
            this.tbMultiplierB.Name = "tbMultiplierB";
            this.tbMultiplierB.Size = new System.Drawing.Size(72, 20);
            this.tbMultiplierB.TabIndex = 38;
            this.tbMultiplierB.Text = "100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(792, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Multiplier";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(712, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Right";
            // 
            // tbStrikeB
            // 
            this.tbStrikeB.Location = new System.Drawing.Point(632, 128);
            this.tbStrikeB.Name = "tbStrikeB";
            this.tbStrikeB.Size = new System.Drawing.Size(72, 20);
            this.tbStrikeB.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(632, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Strike";
            // 
            // tbExpirationB
            // 
            this.tbExpirationB.Location = new System.Drawing.Point(520, 128);
            this.tbExpirationB.Name = "tbExpirationB";
            this.tbExpirationB.Size = new System.Drawing.Size(104, 20);
            this.tbExpirationB.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(520, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Last Trading Day";
            // 
            // tbPrimExchB
            // 
            this.tbPrimExchB.Location = new System.Drawing.Point(408, 128);
            this.tbPrimExchB.Name = "tbPrimExchB";
            this.tbPrimExchB.Size = new System.Drawing.Size(104, 20);
            this.tbPrimExchB.TabIndex = 31;
            this.tbPrimExchB.Text = "BATS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(408, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "PRIMARY Exchange";
            // 
            // cbSecTypeB
            // 
            this.cbSecTypeB.FormattingEnabled = true;
            this.cbSecTypeB.Items.AddRange(new object[] {
            "STK",
            "FUT",
            "OPT",
            "FOP",
            "IND",
            "BAG"});
            this.cbSecTypeB.Location = new System.Drawing.Point(168, 128);
            this.cbSecTypeB.Name = "cbSecTypeB";
            this.cbSecTypeB.Size = new System.Drawing.Size(72, 21);
            this.cbSecTypeB.TabIndex = 29;
            this.cbSecTypeB.Text = "STK";
            // 
            // tbExchangeB
            // 
            this.tbExchangeB.Location = new System.Drawing.Point(328, 128);
            this.tbExchangeB.Name = "tbExchangeB";
            this.tbExchangeB.Size = new System.Drawing.Size(72, 20);
            this.tbExchangeB.TabIndex = 28;
            this.tbExchangeB.Text = "SMART";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(328, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "Exchange";
            // 
            // tbCurrencyB
            // 
            this.tbCurrencyB.Location = new System.Drawing.Point(248, 128);
            this.tbCurrencyB.Name = "tbCurrencyB";
            this.tbCurrencyB.Size = new System.Drawing.Size(72, 20);
            this.tbCurrencyB.TabIndex = 26;
            this.tbCurrencyB.Text = "USD";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(248, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Currency";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(168, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Type";
            // 
            // tbSymbolB
            // 
            this.tbSymbolB.Location = new System.Drawing.Point(88, 128);
            this.tbSymbolB.Name = "tbSymbolB";
            this.tbSymbolB.Size = new System.Drawing.Size(72, 20);
            this.tbSymbolB.TabIndex = 23;
            this.tbSymbolB.Text = "MSFT";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(88, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Root Symbol";
            // 
            // btnData
            // 
            this.btnData.Location = new System.Drawing.Point(880, 128);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(88, 24);
            this.btnData.TabIndex = 41;
            this.btnData.Text = "Get Data";
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // dgvPriceData
            // 
            this.dgvPriceData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPriceData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnSymbol,
            this.clmnChgOpen,
            this.clmnLast,
            this.clmnBid,
            this.clmnBidSize,
            this.clmnAskSize,
            this.clmnAsk,
            this.clmnVolume,
            this.clmnChgClose,
            this.clmnOpen,
            this.clmnHigh,
            this.clmnLow,
            this.clmnClose,
            this.clmnTimeStamp});
            this.dgvPriceData.Location = new System.Drawing.Point(8, 160);
            this.dgvPriceData.Name = "dgvPriceData";
            this.dgvPriceData.Size = new System.Drawing.Size(1072, 72);
            this.dgvPriceData.TabIndex = 42;
            // 
            // clmnSymbol
            // 
            this.clmnSymbol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmnSymbol.HeaderText = "Symbol";
            this.clmnSymbol.Name = "clmnSymbol";
            this.clmnSymbol.Width = 66;
            // 
            // clmnChgOpen
            // 
            this.clmnChgOpen.HeaderText = "Chg Open";
            this.clmnChgOpen.Name = "clmnChgOpen";
            // 
            // clmnLast
            // 
            this.clmnLast.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmnLast.HeaderText = "Last";
            this.clmnLast.Name = "clmnLast";
            this.clmnLast.Width = 52;
            // 
            // clmnBid
            // 
            this.clmnBid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmnBid.HeaderText = "Bid";
            this.clmnBid.Name = "clmnBid";
            this.clmnBid.Width = 47;
            // 
            // clmnBidSize
            // 
            this.clmnBidSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmnBidSize.HeaderText = "Bid Size";
            this.clmnBidSize.Name = "clmnBidSize";
            this.clmnBidSize.Width = 70;
            // 
            // clmnAskSize
            // 
            this.clmnAskSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmnAskSize.HeaderText = "Ask Size";
            this.clmnAskSize.Name = "clmnAskSize";
            this.clmnAskSize.Width = 73;
            // 
            // clmnAsk
            // 
            this.clmnAsk.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmnAsk.HeaderText = "Ask";
            this.clmnAsk.Name = "clmnAsk";
            this.clmnAsk.Width = 50;
            // 
            // clmnVolume
            // 
            this.clmnVolume.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmnVolume.HeaderText = "Volume";
            this.clmnVolume.Name = "clmnVolume";
            this.clmnVolume.Width = 67;
            // 
            // clmnChgClose
            // 
            this.clmnChgClose.HeaderText = "Chg Close";
            this.clmnChgClose.Name = "clmnChgClose";
            // 
            // clmnOpen
            // 
            this.clmnOpen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmnOpen.HeaderText = "Open";
            this.clmnOpen.Name = "clmnOpen";
            this.clmnOpen.Width = 58;
            // 
            // clmnHigh
            // 
            this.clmnHigh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmnHigh.HeaderText = "High";
            this.clmnHigh.Name = "clmnHigh";
            this.clmnHigh.Width = 54;
            // 
            // clmnLow
            // 
            this.clmnLow.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmnLow.HeaderText = "Low";
            this.clmnLow.Name = "clmnLow";
            this.clmnLow.Width = 52;
            // 
            // clmnClose
            // 
            this.clmnClose.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmnClose.HeaderText = "Close";
            this.clmnClose.Name = "clmnClose";
            this.clmnClose.Width = 58;
            // 
            // clmnTimeStamp
            // 
            this.clmnTimeStamp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clmnTimeStamp.HeaderText = "Time Stamp";
            this.clmnTimeStamp.Name = "clmnTimeStamp";
            this.clmnTimeStamp.Width = 88;
            // 
            // lblMarketData
            // 
            this.lblMarketData.AutoSize = true;
            this.lblMarketData.BackColor = System.Drawing.Color.Lime;
            this.lblMarketData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarketData.ForeColor = System.Drawing.Color.Yellow;
            this.lblMarketData.Location = new System.Drawing.Point(880, 24);
            this.lblMarketData.Name = "lblMarketData";
            this.lblMarketData.Size = new System.Drawing.Size(108, 24);
            this.lblMarketData.TabIndex = 43;
            this.lblMarketData.Text = "Market Data";
            // 
            // lbErrors
            // 
            this.lbErrors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbErrors.FormattingEnabled = true;
            this.lbErrors.Location = new System.Drawing.Point(616, 435);
            this.lbErrors.Name = "lbErrors";
            this.lbErrors.Size = new System.Drawing.Size(464, 69);
            this.lbErrors.TabIndex = 44;
            // 
            // dgvSPData
            // 
            this.dgvSPData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSPData.Location = new System.Drawing.Point(880, 56);
            this.dgvSPData.Name = "dgvSPData";
            this.dgvSPData.Size = new System.Drawing.Size(200, 64);
            this.dgvSPData.TabIndex = 45;
            // 
            // btnBuyPair
            // 
            this.btnBuyPair.Location = new System.Drawing.Point(8, 240);
            this.btnBuyPair.Name = "btnBuyPair";
            this.btnBuyPair.Size = new System.Drawing.Size(80, 24);
            this.btnBuyPair.TabIndex = 46;
            this.btnBuyPair.Text = "Buy Pair";
            this.btnBuyPair.UseVisualStyleBackColor = true;
            this.btnBuyPair.Click += new System.EventHandler(this.btnBuyPair_Click);
            // 
            // tbBuyDelta
            // 
            this.tbBuyDelta.Location = new System.Drawing.Point(96, 240);
            this.tbBuyDelta.Name = "tbBuyDelta";
            this.tbBuyDelta.Size = new System.Drawing.Size(80, 20);
            this.tbBuyDelta.TabIndex = 47;
            // 
            // btnSellPair
            // 
            this.btnSellPair.Location = new System.Drawing.Point(192, 240);
            this.btnSellPair.Name = "btnSellPair";
            this.btnSellPair.Size = new System.Drawing.Size(80, 24);
            this.btnSellPair.TabIndex = 48;
            this.btnSellPair.Text = "Sell Pair";
            this.btnSellPair.UseVisualStyleBackColor = true;
            this.btnSellPair.Click += new System.EventHandler(this.btnSellPair_Click);
            // 
            // tbSellDelta
            // 
            this.tbSellDelta.Location = new System.Drawing.Point(280, 240);
            this.tbSellDelta.Name = "tbSellDelta";
            this.tbSellDelta.Size = new System.Drawing.Size(80, 20);
            this.tbSellDelta.TabIndex = 49;
            // 
            // dgvExecutions
            // 
            this.dgvExecutions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExecutions.Location = new System.Drawing.Point(10, 271);
            this.dgvExecutions.Name = "dgvExecutions";
            this.dgvExecutions.Size = new System.Drawing.Size(597, 83);
            this.dgvExecutions.TabIndex = 51;
            // 
            // dgvOrderData
            // 
            this.dgvOrderData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmOrderID});
            this.dgvOrderData.Location = new System.Drawing.Point(620, 243);
            this.dgvOrderData.Name = "dgvOrderData";
            this.dgvOrderData.Size = new System.Drawing.Size(450, 111);
            this.dgvOrderData.TabIndex = 52;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(366, 243);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 20);
            this.textBox1.TabIndex = 53;
            // 
            // dgvPositions
            // 
            this.dgvPositions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPositions.Location = new System.Drawing.Point(12, 367);
            this.dgvPositions.Name = "dgvPositions";
            this.dgvPositions.Size = new System.Drawing.Size(593, 107);
            this.dgvPositions.TabIndex = 54;
            // 
            // clmOrderID
            // 
            this.clmOrderID.HeaderText = "Order ID";
            this.clmOrderID.Name = "clmOrderID";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 536);
            this.Controls.Add(this.dgvPositions);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgvOrderData);
            this.Controls.Add(this.dgvExecutions);
            this.Controls.Add(this.tbSellDelta);
            this.Controls.Add(this.btnSellPair);
            this.Controls.Add(this.tbBuyDelta);
            this.Controls.Add(this.btnBuyPair);
            this.Controls.Add(this.dgvSPData);
            this.Controls.Add(this.lbErrors);
            this.Controls.Add(this.lblMarketData);
            this.Controls.Add(this.dgvPriceData);
            this.Controls.Add(this.btnData);
            this.Controls.Add(this.lblAssetB);
            this.Controls.Add(this.cbRightB);
            this.Controls.Add(this.tbMultiplierB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbStrikeB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbExpirationB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPrimExchB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbSecTypeB);
            this.Controls.Add(this.tbExchangeB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbCurrencyB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbSymbolB);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblAssetA);
            this.Controls.Add(this.cbRightA);
            this.Controls.Add(this.tbMultiplierA);
            this.Controls.Add(this.lblMultiplier);
            this.Controls.Add(this.lblRight);
            this.Controls.Add(this.tbStrikeA);
            this.Controls.Add(this.lblStrike);
            this.Controls.Add(this.tbExpirationA);
            this.Controls.Add(this.lblExpiry);
            this.Controls.Add(this.tbPrimExchA);
            this.Controls.Add(this.lblPrimExch);
            this.Controls.Add(this.cbSecTypeA);
            this.Controls.Add(this.tbExchangeA);
            this.Controls.Add(this.lblExchange);
            this.Controls.Add(this.tbCurrencyA);
            this.Controls.Add(this.lblCurrency);
            this.Controls.Add(this.lblSecType);
            this.Controls.Add(this.tbSymbolA);
            this.Controls.Add(this.lblSymbol);
            this.Controls.Add(this.tbConnect);
            this.Controls.Add(this.btnConnect);
            this.Name = "mainForm";
            this.Text = "Pair Trading";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPriceData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSPData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExecutions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPositions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox tbConnect;
        private System.Windows.Forms.Label lblSymbol;
        private System.Windows.Forms.TextBox tbSymbolA;
        private System.Windows.Forms.Label lblSecType;
        private System.Windows.Forms.TextBox tbCurrencyA;
        private System.Windows.Forms.Label lblCurrency;
        private System.Windows.Forms.TextBox tbExchangeA;
        private System.Windows.Forms.Label lblExchange;
        private System.Windows.Forms.ComboBox cbSecTypeA;
        private System.Windows.Forms.TextBox tbPrimExchA;
        private System.Windows.Forms.Label lblPrimExch;
        private System.Windows.Forms.TextBox tbExpirationA;
        private System.Windows.Forms.Label lblExpiry;
        private System.Windows.Forms.TextBox tbStrikeA;
        private System.Windows.Forms.Label lblStrike;
        private System.Windows.Forms.ComboBox cbRightA;
        private System.Windows.Forms.TextBox tbMultiplierA;
        private System.Windows.Forms.Label lblMultiplier;
        private System.Windows.Forms.Label lblRight;
        private System.Windows.Forms.Label lblAssetA;
        private System.Windows.Forms.Label lblAssetB;
        private System.Windows.Forms.ComboBox cbRightB;
        private System.Windows.Forms.TextBox tbMultiplierB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbStrikeB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbExpirationB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPrimExchB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbSecTypeB;
        private System.Windows.Forms.TextBox tbExchangeB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbCurrencyB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbSymbolB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.DataGridView dgvPriceData;
        private System.Windows.Forms.Label lblMarketData;
        private System.Windows.Forms.ListBox lbErrors;
        private System.Windows.Forms.DataGridView dgvSPData;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnSymbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnChgOpen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnLast;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnBid;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnBidSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnAskSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnAsk;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnVolume;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnChgClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnOpen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnHigh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnLow;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTimeStamp;
        private System.Windows.Forms.Button btnBuyPair;
        private System.Windows.Forms.TextBox tbBuyDelta;
        private System.Windows.Forms.Button btnSellPair;
        private System.Windows.Forms.TextBox tbSellDelta;
        private System.Windows.Forms.DataGridView dgvExecutions;
        private System.Windows.Forms.DataGridView dgvOrderData;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgvPositions;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOrderID;
    }
}

