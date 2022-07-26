using System.Collections.Generic;
using CurrencyConverter.DTO;


namespace CurrencyConverter
{
    public interface ICurrencyConverter
    {
        /// <summary>
        /// Converts value corresponding to the Amount of the Base Currency to the Amount of Quoted Currency according the Course
        /// </summary>
        /// <param name="baseCurrencyValue">Amount of the Base Currency</param>
        /// <param name="pair">The ratio of the prices of two currencies</param>
        /// <returns>Amount of the Quoted Currency</returns>
        decimal ConvertBaseCurrency(decimal baseCurrencyValue, CurrencyPair pair);

        /// <summary>
        /// Converts value corresponding to the Amount of the Quoted currency to the Amount Base currency according the Course
        /// </summary>
        /// <param name="quotedCurrencyValue">Amount of the Quoted Currency</param>
        /// <param name="pair">The ratio of the prices of two currencies</param>
        /// <returns>Amount of the Base Currency</returns>
        decimal ConvertQuotedCurrency(decimal quotedCurrencyValue, CurrencyPair pair);

        /// <summary>
        /// Converts value corresponding to the Amount of the Base currency to the Amount of the Quoted currency according the Course Collection
        /// </summary>
        /// <param name="baseCurrencyValue">Amount of the Base Currency</param>
        /// <param name="pair">The ratio of the prices of two currencies</param>
        /// <returns>Dictionary contains Pair Name in Key and Amount of Quoted currency in Value, according the Course</returns>
        IDictionary<string, decimal> ConvertBaseToQuoted(decimal baseCurrencyValue, params CurrencyPair[] pair);

        /// <summary>
        /// Converts value corresponding to the amount of the base currency to the quoted currency according the Course Collection
        /// </summary>
        /// <param name="quotedCurrencyValue">Amount of the Quoted Currency</param>
        /// <param name="pair">The ratio of the prices of two currencies</param>
        /// <returns>Dictionary contains Pair Name in Key and Amount of Base currency in Value, according the Course</returns>
        IDictionary<string, decimal> ConvertQuotedToBase(decimal quotedCurrencyValue, params CurrencyPair[] pair);

    }
}
