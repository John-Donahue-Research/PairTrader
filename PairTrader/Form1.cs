using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;
using IBApi;

namespace PairTrader
{
    public partial class mainForm : Form
    {
        protected IBClient ibClient;
        private EReaderMonitorSignal signal = new EReaderMonitorSignal();
        private bool isConnected = false;
        int ServerPort = 7496;
        // Setup the two contracts to trade for this trivial pair trading scenerio.
        int A_id = new Random().Next(1,32);
        int B_id = new Random().Next(33,99);
        int S_id = new Random().Next(900, 999);

        Contract c_A ;
        Contract c_B ;
        Contract c_S;

        Order o_A;
        Order o_B;
        int nextID = -1;

        private double a_ask = -1;
        private double b_ask = -1;
        private double a_bid = -1;
        private double b_bid = -1;
        private double a_high = -1;
        private double b_high = -1;
        private double a_low = -1;
        private double b_low = -1;
        private double a_open = -1;
        private double b_open = -1;
        private double a_last = -1;
        private double b_last = -1;
        private double a_close = -1;
        private double b_close = -1;
        private double buyDelta = -1;
        private double sellDelta = -1;
        private double delta = -1;
        private double hedgeRatio = -1;


        public mainForm()
        {
            InitializeComponent();
            ibClient = new IBClient(signal);
            c_A = new Contract();
            c_B = new Contract();
            c_S = new Contract();
            o_A = new Order();
            o_B = new Order();

            ibClient.TickPrice += IbClient_TickPrice;
            ibClient.TickSize += IbClient_TickSize;
            ibClient.TickString += IbClient_TickString;
            ibClient.TickGeneric += IbClient_TickGeneric;
            ibClient.TickOptionCommunication += IbClient_TickOptionCommunication;
            ibClient.MarketDataType += IbClient_MarketDataType;
            ibClient.Error += IbClient_Error;
            ibClient.NextValidId += IbClient_NextValidId;
            


        }

        private void IbClient_NextValidId(int orderID)
        {
            IsConnected = true;
            nextID = orderID;
            dgvOrderData.BeginInvoke(new Action(delegate {
                dgvOrderData[0, 0].Value = nextID;
                dgvOrderData.Rows.Add();

            }));
            
        }

        private void IbClient_Error(int arg1, int arg2, string arg3, Exception arg4)
        {
            lbErrors.BeginInvoke(new Action(delegate {
      
                 if(arg4 != null)
                {
                    lbErrors.Items.Add(arg4.ToString());
                }
                 if(arg3 != null)
                {
                    lbErrors.Items.Add( arg3 );
                }
                 if(arg4 == null)
                {
                    lbErrors.Items.Add(arg1 + " " + arg2 + " " + arg3 );
                }
                
            }));

        }

        private void IbClient_MarketDataType(int reqID, int MDT)
        {
            lbErrors.Items.Add(reqID);
            lblMarketData.BeginInvoke(new Action(delegate {
                switch(MDT)
                {
                    case 1:
                        lblMarketData.Text = "LIVE";
                        lblMarketData.BackColor = System.Drawing.Color.Green;
                        lblMarketData.ForeColor = System.Drawing.Color.Yellow;
                        break;
                    case 2:
                        lblMarketData.Text = "FROZEN";
                        lblMarketData.BackColor = System.Drawing.Color.Red;
                        lblMarketData.ForeColor = System.Drawing.Color.Yellow;
                        break;
                    case 3:
                        lblMarketData.Text = "DELAYED";
                        lblMarketData.BackColor = System.Drawing.Color.Green;
                        lblMarketData.ForeColor = System.Drawing.Color.Black;
                        break;
                    case 4:
                        lblMarketData.Text = "FROZEN - DELAYED";
                        lblMarketData.BackColor = System.Drawing.Color.Red;
                        lblMarketData.ForeColor = System.Drawing.Color.Black;
                        break;
                    default:
                        lblMarketData.Text = "NO DATA";
                        lblMarketData.BackColor = System.Drawing.Color.Black;
                        lblMarketData.ForeColor = System.Drawing.Color.Yellow;
                        break;
                }
            }));
        }

        private void IbClient_TickOptionCommunication(int arg1, int arg2, double arg3, double arg4, double arg5, double arg6, double arg7, double arg8, double arg9, double arg10)
        {
            lbErrors.BeginInvoke(new Action(delegate {

                lbErrors.Items.Add(arg1 + " " + arg2 + " " + arg3 + " " + arg4 + " " + arg5 + " " + arg6 + " " + arg6 + " " + arg7 + " " + arg8 + " " + arg9 + " " + arg10) ;
            }));

        }

        private void IbClient_TickGeneric(int tickerID, int field, double value)
        {
            lbErrors.BeginInvoke(new Action(delegate {
                if(tickerID == S_id)
                {
                    lbErrors.Items.Add(c_S.Symbol + " field -> " + field + " value = " + value);
                }
               

            }));

        }

        private void IbClient_TickString(int tickerID, int field, string value)
        {
            
            dgvPriceData.BeginInvoke(new Action(delegate {
                if((tickerID == A_id) && (field == 45))
                {
                    DateTime timeStamp = UnixTimeStampToDateTime(double.Parse(value));
                    dgvPriceData[13, 0].Value = timeStamp.ToString();
                }
                if((tickerID == B_id) && (field == 45))
                {
                    DateTime timeStamp = UnixTimeStampToDateTime(double.Parse(value));
                    dgvPriceData[13, 1].Value = timeStamp.ToString();
                }              
                else
                {
                    lbErrors.BeginInvoke(new Action(delegate {
                        lbErrors.Items.Add("ticker id : " + tickerID + " field " + field + " value = " + value);
                    }));
                }
           }));
           

        }

        private void IbClient_TickSize(int tickerID, int field, int size)
        {
            dgvPriceData.BeginInvoke(new Action(delegate {
                if (tickerID == A_id)
                {
                    switch (field)
                    {
                        case 0:  // bid size
                            dgvPriceData[4, 0].Value = size;
                            break;
                        case 3:  // ask size
                            dgvPriceData[5, 0].Value = size;
                            break;
                        case 8:   // volume
                            dgvPriceData[7, 0].Value = size * 100;
                            break;
                        default:
                            break;
                    }
                }
                if (tickerID == B_id)
                {
                    switch (field)
                    {
                        case 0:  // bid size
                            dgvPriceData[4, 1].Value = size;
                            break;
                        case 3:  // ask size
                            dgvPriceData[5, 1].Value = size;
                            break;
                        case 8:   // volume
                            dgvPriceData[7, 1].Value = size * 100;
                            break;
                        default:
                            break;
                    }
                }
            }));



        }

        private void IbClient_TickPrice(int tickerID, int field, double price, int canAutoExecute)
        {

            dgvPriceData.BeginInvoke(new Action(delegate {
                
                if (tickerID == A_id)
                {
                    dgvPriceData[0, 0].Value = c_A.Symbol.ToString();

                    switch (field)
                    {
                        case 1: //bid
                            dgvPriceData[3, 0].Value = price;   // column 1
                            a_bid = price;
                            break;
                        case 2: //ask
                            dgvPriceData[6, 0].Value = price;  // column 3
                            a_ask = price;
                            break;
                        case 4: //last                         // column 5
                            dgvPriceData[2, 0].Value = price;
                            a_last = price;
                            break;
                        case 14: //open tick
                            dgvPriceData[9, 0].Value = price;
                            a_open = price;
                            dgvPriceData[1, 0].Value = (a_last - a_open).ToString("F4");
                            break;
                        case 6: // high
                            dgvPriceData[10, 0].Value = price;
                            a_high = price;
                            break;
                        case 7: //low 
                            dgvPriceData[11, 0].Value = price;
                            a_low = price;
                            break;
                        case 9: // close
                            dgvPriceData[12, 0].Value = price;
                            a_close = price;
                            dgvPriceData[8, 0].Value = (a_close - a_last).ToString("F4");
                            break;
                        default:
                            break;
                    }
                    
                }
                if (tickerID == B_id)
                {
                    dgvPriceData[0, 1].Value = c_B.Symbol.ToString();
                    switch (field)
                    {
                        case 1: //bid
                            dgvPriceData[3, 1].Value = price;   // column 1
                            b_bid = price;
                            break;
                        case 2: //ask
                            dgvPriceData[6, 1].Value = price;  // column 3
                            b_ask = price;
                            break;
                        case 4: //last                         // column 5
                            dgvPriceData[2, 1].Value = price;
                            b_last = price;
                            break;
                        case 14: //open tick
                            dgvPriceData[9, 1].Value = price;
                            b_open = price;
                            dgvPriceData[1, 1].Value = (b_last - b_open).ToString("F4");
                            break;
                        case 6: // high
                            dgvPriceData[10, 1].Value = price;
                            b_high = price;
                            break;
                        case 7: //low 
                            dgvPriceData[11, 1].Value = price;
                            b_low = price;
                            break;
                        case 9: // close
                            dgvPriceData[12, 1].Value = price;
                            b_close = price;
                            dgvPriceData[8, 1].Value = (b_close - b_last).ToString("F4");
                            break;
                        default:
                            break;
                    }
                }
                hedgeRatio = a_last / b_last;

                buyDelta = a_ask - 3 * b_bid;
                sellDelta = a_bid - 3 * b_ask;
                delta = a_last - 3 * b_last;

                tbBuyDelta.Text = buyDelta.ToString("F4");
                tbSellDelta.Text = sellDelta.ToString("F4");
                lbErrors.Items.Add(hedgeRatio.ToString("F4"));
                
            }));


        }

        public bool IsConnected
        {
            get { return isConnected; }
            set { isConnected = value; }
        }

        private void ibClient_CurrentTime(long obj)
        {
           
            tbConnect.BeginInvoke(new Action(delegate {
                tbConnect.Text = obj.ToString();
            }));

        }
        
        private void btnData_Click(object sender, EventArgs e)
        {
            
            List<TagValue> mDOA = new List<TagValue>();
            c_A.Symbol = tbSymbolA.Text;
            c_A.SecType = cbSecTypeA.SelectedItem.ToString();
            c_A.Currency = tbCurrencyA.Text;
            c_A.Exchange = tbExchangeA.Text;
            c_A.PrimaryExch = tbPrimExchA.Text;

            List<TagValue> mDOB = new List<TagValue>();
            c_B.Symbol = tbSymbolB.Text;
            c_B.SecType = cbSecTypeB.SelectedItem.ToString();
            c_B.Currency = tbCurrencyB.Text;
            c_B.Exchange = tbExchangeB.Text;
            c_B.PrimaryExch = tbPrimExchB.Text;

            List<TagValue> mDOS = new List<TagValue>();
            c_S.Symbol = "SPX";
            c_S.SecType = "IND";
            c_S.Currency = "USD";
            c_S.Exchange = "CBOE";
            c_S.PrimaryExch = "CBOE";

            ibClient.ClientSocket.reqMarketDataType(1);
            ibClient.ClientSocket.reqMktData(A_id, c_A, "", false, mDOA);
            ibClient.ClientSocket.reqMktData(B_id, c_B, "", false, mDOB);
            ibClient.ClientSocket.reqMktData(S_id, c_S, "162", false, mDOS);
            dgvPriceData.Rows.Add();

        }

        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }

        private void btnBuyPair_Click(object sender, EventArgs e)
        {


          //  ibClient.ClientSocket.reqIds(1);
            o_A.Action = "BUY";
            o_A.Tif = "DAY";
            o_A.OrderType = "LMT";
            o_A.TotalQuantity = 100;
            o_A.LmtPrice = a_ask;
            //
         //   ibClient.ClientSocket.reqIds(1);
            o_B.Action = "SELL";
            o_B.Tif = "DAY";
            o_B.OrderType = "LMT";
            o_B.TotalQuantity = 300;
            o_B.LmtPrice = b_bid;

            //lbOrderData.Items.Add("Next ID before increment Buy Pair = " + nextID);
            dgvOrderData.BeginInvoke(new Action(delegate {
                
                dgvOrderData[0, 1].Value = nextID;
            }));
            //dgvOrderData[0, 1].Value = nextID;

            ibClient.ClientSocket.placeOrder(++nextID, c_A, o_A);
            ibClient.ClientSocket.placeOrder(++nextID, c_B, o_B);
            //lbOrderData.Items.Add("Next ID after increment Buy Pair = " + nextID);
            dgvOrderData.BeginInvoke(new Action(delegate {
               
                dgvOrderData[0, 2].Value = nextID;
            }));
            //dgvOrderData[0, 2].Value = nextID;
        }

        private void btnSellPair_Click(object sender, EventArgs e)
        {
           // ibClient.ClientSocket.reqIds(1);
           
            o_A.Action = "SELL";
            o_A.Tif = "DAY";
            o_A.OrderType = "LMT";
            o_A.TotalQuantity = 100;
            o_A.LmtPrice = a_bid;

          //  ibClient.ClientSocket.reqIds(1);

            o_B.Action = "BUY";
            o_B.Tif = "DAY";
            o_B.OrderType = "LMT";
            o_B.TotalQuantity = 300;
            o_B.LmtPrice = b_ask;
            //lbOrderData.Items.Add("Next ID before increment Sell Pair = " + nextID);
            //dgvOrderData[0, 3].Value = nextID;
            dgvOrderData.BeginInvoke(new Action(delegate {
               
                dgvOrderData[0, 3].Value = nextID;
            }));
            ibClient.ClientSocket.placeOrder(++nextID, c_A, o_A);
            ibClient.ClientSocket.placeOrder(++nextID, c_B, o_B);
            //lbOrderData.Items.Add("Next ID after increment Sell Pair = " + nextID);
            dgvOrderData.BeginInvoke(new Action(delegate {
               
                dgvOrderData[0, 4].Value = nextID;
            }));
            //dgvOrderData[0, 4].Value = nextID;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!IsConnected)
            {
                try
                {

                    this.ibClient.ClientSocket.eConnect("127.0.0.1", ServerPort, 99);
                    var reader = new EReader(this.ibClient.ClientSocket, signal);

                    reader.Start();
                    new Thread(() => { while (this.ibClient.ClientSocket.IsConnected()) { this.signal.waitForSignal(); reader.processMsgs(); } }) { IsBackground = true }.Start();
                    tbConnect.Text = ibClient.ClientSocket.ServerTime;
                    ibClient.ClientSocket.reqCurrentTime();
                    ibClient.ClientSocket.reqIds(-1);

                }
                catch (Exception ex)
                {
                   tbConnect.Text = ex.ToString();
                }
            }
        }
    }
}
