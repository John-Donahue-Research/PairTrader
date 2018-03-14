using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using IBApi;

namespace IB_972_Console_HistData_CS
{
    class EWrapperImpl : EWrapper
    {

        // This part you must do your self
        /// <summary>
        /// This part you must do yourself
        /// setting up the clientSocket, the next order id and reader signal
       
        private int nextOrderID;
        EClientSocket clientSocket;
        public readonly EReaderSignal Signal;
        //int id = Thread.CurrentThread.ManagedThreadId;
        Program p = new Program();

        public EWrapperImpl()
        {
            Signal = new EReaderMonitorSignal();
            clientSocket = new EClientSocket(this, Signal);
        }

        public EClientSocket ClientSocket
        {
            get { return clientSocket;  }
            set { clientSocket = value; }
        }

        public int NextOrderId
        {
            get { return nextOrderID; }
            set { nextOrderID = value; }
        }

        public void connectAck()    // not VIRTUAL method why? I have no idea.   the dervied class can't overide the base class's implementation
        {
            if (clientSocket.AsyncEConnect)
                clientSocket.startApi();    /// START THE API THREAD!
            //throw new NotImplementedException();
        }


        /// end of block you must implement
        /// </summary>
        ///

        /// this is where errors are handled the API wants soemthing here no matter what.
        /// three types of errors all OVERRIDE Methods.
        /// first just with a general exception
        public virtual void error(Exception e)
        {
            Console.WriteLine("General Exception thrown: " + e.ToString());
            throw e;
            //throw new NotImplementedException();
        }
        /// <summary>
        ///  then an error that responds to and events with a string
        /// </summary>
        /// <param name="str"></param>
        public virtual void error(string str)
        {
            Console.WriteLine("String Error Mode : " + str + "\n");
            //throw new NotImplementedException();
        }
        /// <summary>
        /// then an error that response to an error event with a int id, int error code and then the error message as a string
        /// </summary>
        /// <param name="id"></param>
        /// <param name="errorCode"></param>
        /// <param name="errorMsg"></param>
        public virtual void error(int id, int errorCode, string errorMsg)
        {
            switch(errorCode)
            {
                case 2104:
                    Console.WriteLine("Connected to IB TWS via API data farm ok -: " + errorMsg);
                    break;
                case 2106:
                    Console.WriteLine("Historical Data Farm is now connected " + errorMsg);
                    break;
                default:
                    Console.WriteLine("Long int, int, string, : Error. Id: " + id + ", IB error Code: " + errorCode + ", IB Error Msg: " + errorMsg + "\n");
                    break;
            }
                
            
            //throw new NotImplementedException();
        }

        /// end of Error zone.

        /// <summary>
        /// Begin your implementation for consuming incoming messages
        /// </summary>
        /// <param name="account">
        /// sends the account info from TWS
        /// </param>

        public virtual void accountDownloadEnd(string account)
        {
            throw new NotImplementedException();
        }

        public virtual void accountSummary(int reqId, string account, string tag, string value, string currency)
        {
            throw new NotImplementedException();
        }

        public virtual void accountSummaryEnd(int reqId)
        {
            throw new NotImplementedException();
        }

        public virtual void accountUpdateMulti(int requestId, string account, string modelCode, string key, string value, string currency)
        {
            throw new NotImplementedException();
        }

        public virtual void accountUpdateMultiEnd(int requestId)
        {
            throw new NotImplementedException();
        }

        public virtual void bondContractDetails(int reqId, ContractDetails contract)
        {
            throw new NotImplementedException();
        }

        public virtual void commissionReport(CommissionReport commissionReport)
        {
            throw new NotImplementedException();
        }

        
        /// <summary>
        /// It wants to know that YOU know the connection to IB TWS API is now closed.  very specific implementation
        /// </summary>
        public virtual void connectionClosed()
        {
            Console.WriteLine("TWS API Connection closed.\n");
            
            //throw new NotImplementedException();
        }

        public virtual void contractDetails(int reqId, ContractDetails contractDetails)
        {
            throw new NotImplementedException();
        }

        public virtual void contractDetailsEnd(int reqId)
        {
            throw new NotImplementedException();
        }

        public virtual void currentTime(long time)
        {
            throw new NotImplementedException();
        }

        public virtual void deltaNeutralValidation(int reqId, UnderComp underComp)
        {
            throw new NotImplementedException();
        }

        public virtual void displayGroupList(int reqId, string groups)
        {
            Console.WriteLine("DisplayGroupList. Request: " + reqId + ", Groups" + groups);
            //throw new NotImplementedException();
        }

        public virtual void displayGroupUpdated(int reqId, string contractInfo)
        {
            Console.WriteLine("displayGroupUpdated. Request: " + reqId + ", ContractInfo: " + contractInfo);
            //throw new NotImplementedException();
        }

        public virtual void execDetails(int reqId, Contract contract, Execution execution)
        {
            throw new NotImplementedException();
        }

        public virtual void execDetailsEnd(int reqId)
        {
            throw new NotImplementedException();
        }

        public virtual void fundamentalData(int reqId, string data)
        {
            throw new NotImplementedException();
        }

        public virtual void historicalData(int reqId, string date, double open, double high, double low, double close, int volume, int count, double WAP, bool hasGaps)
        {
            string outputString = "HistoricalData. " + reqId +
                                " - Date: " + date +
                                ", Open: " + open +
                                ", High: " + high +
                                ", Low: " + low +
                                ", Close: " + close +
                                ", Volume: " + volume +
                                ", Count: " + count +
                                ", WAP: " + WAP +
                                ", HasGaps: " + hasGaps;
            //Console.WriteLine( outputString );
            //Console.WriteLine("\nDo I get this one at a time or in one blast? if one at a time I should see many of these.\n");
            Program.sendHistData q = new Program.sendHistData(p.WriteHistData);
            IAsyncResult R = null;
            R = q.BeginInvoke(reqId, outputString, null, null);


            //int id = Thread.CurrentThread.ManagedThreadId;
            /*
            Console.WriteLine("CUrrent Thread id From historicalData Call: " + id);
            ///throw new NotImplementedException();
            ///
            try { 
                StreamWriter sw = File.AppendText("mydata.txt");
                //sw.Write(outputString);
                sw.
                sw.WriteAsync(outputString);
                sw.Flush();
            } catch (Exception e)
            {
                Console.WriteLine("Exception " + e.ToString());
            }
            */
        }

        public virtual void historicalDataEnd(int reqId, string start, string end)
        {
            Console.WriteLine("Historical data end - " + reqId + " from " + start + " to " + end);
            int id2 = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine("CUrrent Thread id From historicalData End Call: " + id2);
            //throw new NotImplementedException();
        }

        public virtual void managedAccounts(string accountsList)
        {
            Console.WriteLine("Account list: " + accountsList);
            //throw new NotImplementedException();
        }

        public virtual void marketDataType(int reqId, int marketDataType)
        {
            throw new NotImplementedException();
        }

        public virtual void nextValidId(int orderId)
        {
            Console.WriteLine("Next Valid Id: " + orderId);
            nextOrderID = orderId;
            //throw new NotImplementedException();
        }

        public virtual void openOrder(int orderId, Contract contract, Order order, OrderState orderState)
        {
            throw new NotImplementedException();
        }

        public virtual void openOrderEnd()
        {
            throw new NotImplementedException();
        }

        public virtual void orderStatus(int orderId, string status, double filled, double remaining, double avgFillPrice, int permId, int parentId, double lastFillPrice, int clientId, string whyHeld)
        {
            throw new NotImplementedException();
        }

        public virtual void position(string account, Contract contract, double pos, double avgCost)
        {
            throw new NotImplementedException();
        }

        public virtual void positionEnd()
        {
            throw new NotImplementedException();
        }

        public virtual void positionMulti(int requestId, string account, string modelCode, Contract contract, double pos, double avgCost)
        {
            throw new NotImplementedException();
        }

        public virtual void positionMultiEnd(int requestId)
        {
            throw new NotImplementedException();
        }

        public virtual void realtimeBar(int reqId, long time, double open, double high, double low, double close, long volume, double WAP, int count)
        {
            throw new NotImplementedException();
        }

        public virtual void receiveFA(int faDataType, string faXmlData)
        {
            throw new NotImplementedException();
        }

        public virtual void scannerData(int reqId, int rank, ContractDetails contractDetails, string distance, string benchmark, string projection, string legsStr)
        {
            throw new NotImplementedException();
        }

        public virtual void scannerDataEnd(int reqId)
        {
            throw new NotImplementedException();
        }

        public virtual void scannerParameters(string xml)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// These two methods are not virtual?  Must be new for 9.72
        /// </summary>
        /// <param name="reqId"></param>
        /// <param name="underlyingConId"></param>
        /// <param name="tradingClass"></param>
        /// <param name="multiplier"></param>
        /// <param name="expirations"></param>
        /// <param name="strikes"></param>
        public void securityDefinitionOptionParameter(int reqId, int underlyingConId, string tradingClass, string multiplier, HashSet<string> expirations, HashSet<double> strikes)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="reqId"></param>
        public void securityDefinitionOptionParameterEnd(int reqId)
        {
            throw new NotImplementedException();
        }
        //////////////////////////////////////////////////////////////


        /// <summary>
        /// 
        /// </summary>
        /// <param name="tickerId"></param>
        /// <param name="tickType"></param>
        /// <param name="basisPoints"></param>
        /// <param name="formattedBasisPoints"></param>
        /// <param name="impliedFuture"></param>
        /// <param name="holdDays"></param>
        /// <param name="futureLastTradeDate"></param>
        /// <param name="dividendImpact"></param>
        /// <param name="dividendsToLastTradeDate"></param>
        public virtual void tickEFP(int tickerId, int tickType, double basisPoints, string formattedBasisPoints, double impliedFuture, int holdDays, string futureLastTradeDate, double dividendImpact, double dividendsToLastTradeDate)
        {
            throw new NotImplementedException();
        }

        public virtual void tickGeneric(int tickerId, int field, double value)
        {
            throw new NotImplementedException();
        }

        public virtual void tickOptionComputation(int tickerId, int field, double impliedVolatility, double delta, double optPrice, double pvDividend, double gamma, double vega, double theta, double undPrice)
        {
            throw new NotImplementedException();
        }

        public virtual void tickPrice(int tickerId, int field, double price, int canAutoExecute)
        {
            throw new NotImplementedException();
        }

        public virtual void tickSize(int tickerId, int field, int size)
        {
            throw new NotImplementedException();
        }

        public virtual void tickSnapshotEnd(int tickerId)
        {
            throw new NotImplementedException();
        }

        public virtual void tickString(int tickerId, int field, string value)
        {
            throw new NotImplementedException();
        }

        public virtual void updateAccountTime(string timestamp)
        {
            throw new NotImplementedException();
        }

        public virtual void updateAccountValue(string key, string value, string currency, string accountName)
        {
            throw new NotImplementedException();
        }

        public virtual void updateMktDepth(int tickerId, int position, int operation, int side, double price, int size)
        {
            throw new NotImplementedException();
        }

        public virtual void updateMktDepthL2(int tickerId, int position, string marketMaker, int operation, int side, double price, int size)
        {
            throw new NotImplementedException();
        }

        public virtual void updateNewsBulletin(int msgId, int msgType, string message, string origExchange)
        {
            throw new NotImplementedException();
        }

        public virtual void updatePortfolio(Contract contract, double position, double marketPrice, double marketValue, double averageCost, double unrealisedPNL, double realisedPNL, string accountName)
        {
            throw new NotImplementedException();
        }

        public virtual void verifyMessageAPI(string apiData)
        {
            Console.WriteLine("verifyMessageAPI: " + apiData);
        }
        public virtual void verifyCompleted(bool isSuccessful, string errorText)
        {
            Console.WriteLine("verifyCompleted. IsSuccessfule: " + isSuccessful + " - Error: " + errorText);
        }
        public virtual void verifyAndAuthMessageAPI(string apiData, string xyzChallenge)
        {
            Console.WriteLine("verifyAndAuthMessageAPI: " + apiData + " " + xyzChallenge);
        }
        public virtual void verifyAndAuthCompleted(bool isSuccessful, string errorText)
        {
            Console.WriteLine("verifyAndAuthCompleted. IsSuccessful: " + isSuccessful + " - Error: " + errorText);
        }
    }
}
