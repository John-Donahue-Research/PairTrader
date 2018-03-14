using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IBApi;

namespace IB_972_Console_HistData_CS
{
    public class Macro_Futures
    {
        /*
        public static Dictionary<int,Contract> Symbol()
        {
            Dictionary<int, Contract> sym = new Dictionary<int, Contract>();
            sym.Add(1, Macro_Futures.ZT());
            sym.Add(2, Macro_Futures.ZF());
            return sym;
        }
        */

        
         
            public static KeyValuePair<int, string> ZT = new KeyValuePair<int, string>(1, "ZT");
            public static KeyValuePair<int, string> ZF = new KeyValuePair<int, string>(2, "ZF");
            public static KeyValuePair<int, string> ZN = new KeyValuePair<int, string>(3, "ZN");
            public static KeyValuePair<int, string> ZB = new KeyValuePair<int, string>(4, "ZB");
            public static KeyValuePair<int, string> ES = new KeyValuePair<int, string>(5, "ES");
            public static KeyValuePair<int, string> CL = new KeyValuePair<int, string>(6, "CL");
            public static KeyValuePair<int, string> GC = new KeyValuePair<int, string>(7, "GC");
            public static KeyValuePair<int, string> SPY = new KeyValuePair<int, string>(8, "SPY");
            public static KeyValuePair<int, string> SPX = new KeyValuePair<int, string>(9, "SPX");
            public static KeyValuePair<int, string> IRX = new KeyValuePair<int, string>(10, "IRX");
            public static KeyValuePair<int, string> TNX = new KeyValuePair<int, string>(11, "TNX");
            public static KeyValuePair<int, string> TYX = new KeyValuePair<int, string>(12, "TYX");

            public static ConcurrentDictionary<int, string> Symbol = new ConcurrentDictionary<int, string>();
        



        /*
        public static int ZT_ID = 1;
        public static int ZF_ID = 2;
        public static int ZN_ID = 3;
        public static int ZB_ID = 4;
        public static int ES_ID = 5;
        public static int CL_ID = 6;
        public static int GC_ID = 7;
        public static int SPY_ID = 8;
        public static int SPX_ID = 9;
        public static int IRX_ID = 10;
        public static int TNX_ID = 11;
        public static int TYX_ID = 12;
        */
        public static Contract ZT_FUT()
        {
            Symbol.TryAdd(ZT.Key, ZT.Value);
            //! [futurescontract]
            Contract contract = new Contract();
            contract.Symbol = "ZT";
            contract.SecType = "FUT";
            contract.Currency = "USD";
            contract.Exchange = "ECBOT";
            contract.PrimaryExch = "ECBOT";
            contract.LastTradeDateOrContractMonth = "201606";
            //! [futurescontract]
            return contract;
        }

        public static Contract ZF_FUT()
        {
            //! [futurescontract]
            Contract contract = new Contract();
            contract.Symbol = "ZF";
            contract.SecType = "FUT";
            contract.Currency = "USD";
            contract.Exchange = "ECBOT";
            contract.PrimaryExch = "ECBOT";
            contract.LastTradeDateOrContractMonth = "201606";
            //! [futurescontract]
            return contract;
        }

        public static Contract ZN_FUT()
        {
            //! [futurescontract]
            Contract contract = new Contract();
            contract.Symbol = "ZN";
            contract.SecType = "FUT";
            contract.Currency = "USD";
            contract.Exchange = "ECBOT";
            contract.PrimaryExch = "ECBOT";
            contract.LastTradeDateOrContractMonth = "201606";
            //! [futurescontract]
            return contract;
        }

        public static Contract ZB_FUT()
        {
            //! [futurescontract]
            Contract contract = new Contract();
            contract.Symbol = "ZB";
            contract.SecType = "FUT";
            contract.Currency = "USD";
            contract.Exchange = "ECBOT";
            contract.PrimaryExch = "ECBOT";
            contract.LastTradeDateOrContractMonth = "201606";
            //! [futurescontract]
            return contract;
        }

        public static Contract ES_FUT()
        {
            Symbol.TryAdd(ES.Key, ES.Value);
            Console.WriteLine(ES.Key.ToString() + " " + ES.Value.ToString());

            //! [futurescontract]
            Contract contract = new Contract();
            contract.Symbol = "ES";
            contract.SecType = "FUT";
            contract.Currency = "USD";
            contract.Exchange = "GLOBEX";
            contract.PrimaryExch = "GLOBEX";
            contract.LastTradeDateOrContractMonth = "201606";
            //! [futurescontract]
            return contract;
        }

        public static Contract CL_FUT()
        {
            //! [futurescontract]
            Contract contract = new Contract();
            contract.Symbol = "CL";
            contract.SecType = "FUT";
            contract.Currency = "USD";
            contract.Exchange = "NYMEX";
            contract.PrimaryExch = "NYMEX";
            contract.LastTradeDateOrContractMonth = "201607";
            //! [futurescontract]
            return contract;
        }

        public static Contract GC_FUT()
        {
            //! [futurescontract]
            Contract contract = new Contract();
            contract.Symbol = "GC";
            contract.SecType = "FUT";
            contract.Currency = "USD";
            contract.Exchange = "NYMEX";
            contract.PrimaryExch = "NYMEX";
            contract.LastTradeDateOrContractMonth = "201606";
            //! [futurescontract]
            return contract;
        }

        public static Contract SPY_STK()
        {
            //! [stock]
            Contract contract = new Contract();
            contract.Symbol = "SPY";
            contract.SecType = "STK";
            contract.Currency = "USD";
            contract.Exchange = "SMART";
            contract.PrimaryExch = "ARCA";

            //! [stock]
            return contract;
        }

        public static Contract SPX_IND()
        {
            //! [index]
            Contract contract = new Contract();
            contract.Symbol = "SPX";
            contract.SecType = "IND";
            contract.Currency = "USD";
            contract.Exchange = "CBOE";
            contract.PrimaryExch = "CBOE";

            //! [index]
            return contract;
        }

        /// <summary>
        ///  Interest rate option Indicies are 10X what the underlying annualized interest rate it.
        ///  Therefor if 2.90 on the INX = 0.290 on the 13 week tbill
        /// </summary>
        /// <returns></returns>
       public static Contract IRX_IND()
        {
            //! [index]
            Contract contract = new Contract();
            contract.Symbol = "IRX";
            contract.SecType = "IND";
            contract.Currency = "USD";
            contract.Exchange = "CBOE";
            contract.PrimaryExch = "CBOE";

            //! [index]
            return contract;
        }

        public static Contract TNX_IND()
        {
            //! [index]
            Contract contract = new Contract();
            contract.Symbol = "TNX";
            contract.SecType = "IND";
            contract.Currency = "USD";
            contract.Exchange = "CBOE";
            contract.PrimaryExch = "CBOE";

            //! [index]
            return contract;
        }

        public static Contract TYX_IND()
        {
            //! [index]
            Contract contract = new Contract();
            contract.Symbol = "TYX";
            contract.SecType = "IND";
            contract.Currency = "USD";
            contract.Exchange = "CBOE";
            contract.PrimaryExch = "CBOE";

            //! [index]
            return contract;
        }


    }
}
