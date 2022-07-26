using CurrencyConverter.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter.Implementation
{
    public class SimpleConverter : ICurrencyConverter
    {
        public decimal ConvertBaseCurrency(decimal baseCurrencyValue, CurrencyPair pair)
        {
            return pair.Course * baseCurrencyValue;
        }

        public IDictionary<string, decimal> ConvertBaseToQuoted(decimal baseCurrencyValue, params CurrencyPair[] pair)
        {
            throw new NotImplementedException();
        }

        public decimal ConvertQuotedCurrency(decimal quotedCurrencyValue, CurrencyPair pair)
        {
            throw new NotImplementedException();
        }

        public IDictionary<string, decimal> ConvertQuotedToBase(decimal quotedCurrencyValue, params CurrencyPair[] pair)
        {
            throw new NotImplementedException();
        }
    }
}
