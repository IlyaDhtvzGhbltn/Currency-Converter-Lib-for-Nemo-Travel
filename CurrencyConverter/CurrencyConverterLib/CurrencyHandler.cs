using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    public class CurrencyHandler
    {
        private ICurrencyConverter CurrencyConverter { get; }
        private ICurrencyMath CurrencyMath { get; }

        public CurrencyHandler(ICurrencyConverter currencyConverter, ICurrencyMath currencyMath)
        {
            this.CurrencyConverter = currencyConverter;
            this.CurrencyMath = currencyMath;
        }
    }
}
