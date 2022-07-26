using CurrencyConverter;
using CurrencyConverter.DTO;
using CurrencyConverter.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ICurrencyConverter conv = new SimpleConverter();
            var GBPUSD = new CurrencyPair("GBP/USD", 1.2m, "GBP", "USD");
            var EURUSD = new CurrencyPair("EUR/USD", 1.01m, "EUR", "USD");

            decimal result = conv.BaseToQuoted(100, GBPUSD);
            decimal result2 = conv.QuotedToBase(100, GBPUSD);

            Dictionary<string, decimal> result3 = conv.BaseToQuotedCollection(100, GBPUSD, EURUSD);
            Dictionary<string, decimal> result4 = conv.QuotedToBaseCollection(100, GBPUSD, EURUSD);

            Console.ReadKey();
        }
    }
}
