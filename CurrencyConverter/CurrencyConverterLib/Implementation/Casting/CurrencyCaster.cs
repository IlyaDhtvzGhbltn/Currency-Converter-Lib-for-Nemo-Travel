using CurrencyConverter.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter.Implementation.Casting
{
    public class CurrencyCaster : ICurrencyCaster
    {
        public ICurrencyConverter ConvertionProvider { get; }

        public CurrencyCaster(ICurrencyConverter convertionProvider)
        {
            ConvertionProvider = convertionProvider;
        }

        public decimal CastToBase(Currency curr, CurrencyPair pair)
        {
            if (curr.Name == pair.BaseCurrency)
            {
                return curr.Amount;
            }
            else if (curr.Name == pair.QuotedCurrency)
            {
                return ConvertionProvider.QuotedToBase(curr.Amount, pair);
            }
            else
            {
                throw new InvalidCastException($"Unexpected Currency. Make sure you currency corresponds {pair.BaseCurrency} or {pair.QuotedCurrency}");
            }
        }

        public decimal CastToQuoted(Currency curr, CurrencyPair pair)
        {
            if (curr.Name == pair.QuotedCurrency)
            {
                return curr.Amount;
            }
            else if (curr.Name == pair.BaseCurrency)
            {
                return ConvertionProvider.BaseToQuoted(curr.Amount, pair);
            }
            else
            {
                throw new InvalidCastException($"Unexpected Currency. Make sure you currency corresponds {pair.BaseCurrency} or {pair.QuotedCurrency}");
            }
        }
    }
}
