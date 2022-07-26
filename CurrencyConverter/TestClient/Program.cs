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

            decimal result = conv.ConvertBaseCurrency(10, GBPUSD);

            Console.ReadKey();
        }
    }
}
