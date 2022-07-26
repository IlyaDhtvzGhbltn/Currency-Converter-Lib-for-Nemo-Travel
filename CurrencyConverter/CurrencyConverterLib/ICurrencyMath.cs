﻿using CurrencyConverter.DTO;

namespace CurrencyConverter
{
    public interface ICurrencyMath
    {
        /// <summary>
        /// Convertion Provider
        /// </summary>
        ICurrencyConverter ConvertionProvider { get; }

        /// <summary>
        /// Converts Quote Currency to Base Currency according to the rate then totals
        /// </summary>
        /// <param name="pair">The ratio of the prices of two currencies</param>
        /// <param name="currArray">Array of Currencies</param>
        /// <returns>Summ in Base Currency</returns>
        decimal AddToBase(CurrencyPair pair, params Currency[] currArray);

        /// <summary>
        /// Converts Base Currency to Quote Currency according to the rate then totals
        /// </summary>
        /// <param name="pair">The ratio of the prices of two currencies</param>
        /// <param name="currArray">Array of Currencies</param>
        /// <returns>Summ in Quoted Currency</returns>
        decimal AddToQuoted(CurrencyPair pair, params Currency[] currArray);

        /// <summary>
        /// Converts Minuend and Subtrahend to Base Currency according to the rate then executes subtract operation
        /// </summary>
        /// <param name="minuend">Minuend Currency</param>
        /// <param name="subtrahend">Subtrahend Currency</param>
        /// <param name="pair">The ratio of the prices of two currencies</param>
        /// <returns></returns>
        decimal SubtractionToBase(Currency minuend, Currency subtrahend, CurrencyPair pair);

        /// <summary>
        /// Converts Minuend and Subtrahend to Quoted Currency according to the rate then executes subtract operation
        /// </summary>
        /// <param name="minuend">Minuend Currency</param>
        /// <param name="subtrahend">Subtrahend Currency</param>
        /// <param name="pair">The ratio of the prices of two currencies</param>
        /// <returns></returns>
        decimal SubtractionToQuoted(Currency minuend, Currency subtrahend, CurrencyPair pair);
    }
}
