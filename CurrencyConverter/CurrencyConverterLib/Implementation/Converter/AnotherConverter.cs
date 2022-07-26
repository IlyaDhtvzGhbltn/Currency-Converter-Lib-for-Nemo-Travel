using CurrencyConverter.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter.Implementation.Converter
{
    public class AnotherConverter : ICurrencyConverter
    {
        public decimal BaseToQuoted(decimal baseCurrencyValue, CurrencyPair pair)
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, decimal> BaseToQuotedCollection(decimal baseCurrencyValue, params CurrencyPair[] pair)
        {
            throw new NotImplementedException();
        }

        public decimal QuotedToBase(decimal quotedCurrencyValue, CurrencyPair pair)
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, decimal> QuotedToBaseCollection(decimal quotedCurrencyValue, params CurrencyPair[] pair)
        {
            throw new NotImplementedException();
        }
    }
}
