using CurrencyConverter.DTO;

namespace CurrencyConverter
{
    public interface ICurrencyCaster
    {
        /// <summary>
        /// Converts Quoted Currency to Base or just returns amount of Base
        /// </summary>
        /// <param name="curr">Currency</param>
        /// <param name="pair">The ratio of the prices of two currencies</param>
        /// <returns></returns>
        decimal CastToBase(Currency curr, CurrencyPair pair);

        /// <summary>
        /// Converts Base Currency to Quoted or just returns amount of Quoted
        /// </summary>
        /// <param name="curr">Currency</param>
        /// <param name="pair">The ratio of the prices of two currencies</param>
        /// <returns></returns>
        decimal CastToQuoted(Currency curr, CurrencyPair pair);
    }
}
