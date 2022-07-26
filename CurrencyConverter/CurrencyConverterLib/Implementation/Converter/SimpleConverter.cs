using CurrencyConverter.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter.Implementation.Converter
{
    public class SimpleConverter : ICurrencyConverter
    {
        public decimal BaseToQuoted(decimal baseCurrencyValue, CurrencyPair pair)
        {
            return convertBaseToQuoted(baseCurrencyValue, pair.Course);
        }

        public decimal QuotedToBase(decimal quotedCurrencyValue, CurrencyPair pair)
        {
            return convertQuotedToBase(quotedCurrencyValue, pair.Course);
        }

        public Dictionary<string, decimal> BaseToQuotedCollection(decimal baseCurrencyValue, params CurrencyPair[] pair)
        {
            var dict = new Dictionary<string, decimal>();
            foreach (CurrencyPair p in pair)
            {
                dict[p.PairName] = BaseToQuoted(baseCurrencyValue, p);
            }
            return dict;
        }

        public Dictionary<string, decimal> QuotedToBaseCollection(decimal quotedCurrencyValue, params CurrencyPair[] pair)
        {
            var dict = new Dictionary<string, decimal>();
            foreach (CurrencyPair p in pair)
            {
                dict[p.PairName] = QuotedToBase(quotedCurrencyValue, p);
            }
            return dict;
        }


        private decimal convertBaseToQuoted(decimal baseCurrencyValue, decimal course)
        {
            return course * baseCurrencyValue;
        }

        private decimal convertQuotedToBase(decimal quotedCurrencyValue, decimal course) 
        {
            return quotedCurrencyValue / course;
        }
    }
}
