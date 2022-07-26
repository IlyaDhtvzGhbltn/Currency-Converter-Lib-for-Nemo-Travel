using CurrencyConverter.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter.Implementation.Math
{
    public class SimpleCurrencyMath : ICurrencyMath
    {
        public ICurrencyConverter ConvertionProvider { get; }
        private ICurrencyCaster CurrencyCaster { get; }

        public SimpleCurrencyMath(ICurrencyConverter convertionProvider, ICurrencyCaster currencyCaster)
        {
            ConvertionProvider = convertionProvider;
            CurrencyCaster = currencyCaster;
        }


        public decimal AddToBase(CurrencyPair pair, params Currency[] currArray)
        {
            decimal result = 0;
            foreach (Currency c in currArray) 
            {
                result += CurrencyCaster.CastToBase(c, pair);
            }

            return result;
        }

        public decimal AddToQuoted(CurrencyPair pair, params Currency[] currArray)
        {
            decimal result = 0;
            foreach (Currency c in currArray)
            {
                result += CurrencyCaster.CastToQuoted(c, pair);
            }

            return result;
        }

        public decimal SubtractionToBase(Currency minuend, Currency subtrahend, CurrencyPair pair)
        {
            decimal minuendInBase = CurrencyCaster.CastToBase(minuend, pair);
            decimal subtrahendInBase = CurrencyCaster.CastToBase(subtrahend, pair);

            return minuendInBase - subtrahendInBase;
        }

        public decimal SubtractionToQuoted(Currency minuend, Currency subtrahend, CurrencyPair pair)
        {
            decimal minuendInBase = CurrencyCaster.CastToQuoted(minuend, pair);
            decimal subtrahendInBase = CurrencyCaster.CastToQuoted(subtrahend, pair);

            return minuendInBase - subtrahendInBase;
        }
    }
}
