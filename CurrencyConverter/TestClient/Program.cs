using CurrencyConverter;
using CurrencyConverter.DTO;
using CurrencyConverter.Implementation.Converter;
using CurrencyConverter.Implementation.Math;
using CurrencyConverter.Implementation.Casting;
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
            var USDGBP = new CurrencyPair("USD/GBP", 0.83m, "USD", "GBP");

            var EURUSD = new CurrencyPair("EUR/USD", 1.01m, "EUR", "USD");

            decimal result = conv.BaseToQuoted(100, GBPUSD);
            decimal result2 = conv.QuotedToBase(100, GBPUSD);

            Dictionary<string, decimal> result3 = conv.BaseToQuotedCollection(100, GBPUSD, EURUSD);
            Dictionary<string, decimal> result4 = conv.QuotedToBaseCollection(100, GBPUSD, EURUSD);

            ICurrencyCaster validator = new CurrencyCaster(conv);
            ICurrencyMath math = new SimpleCurrencyMath(conv, validator);
            var gbp = new Currency("GBP", 10);
            var usd = new Currency("USD", 1);

            decimal result5 = math.AddToBase(GBPUSD, gbp, usd, gbp, gbp, usd);
            decimal result6 = math.AddToQuoted(GBPUSD, gbp, usd);
            decimal result7 = math.AddToBase(GBPUSD, gbp, usd, gbp, gbp, usd);
            decimal result8 = math.AddToQuoted(GBPUSD, gbp, usd);
            decimal result9 = math.AddToQuoted(GBPUSD, usd, usd);
            decimal result10 = math.AddToQuoted(GBPUSD, gbp, gbp);



            Console.ReadKey();
        }
    }
}
