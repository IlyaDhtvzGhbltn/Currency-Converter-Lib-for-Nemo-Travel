using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter.DTO
{
    /// <summary>
    /// The ratio of the prices of two currencies.
    /// Example: GBP/USD = 1.202 means that 1GBP = 1.202USD. 
    /// GBP - Base and USD - Quoted
    /// </summary>
    public class CurrencyPair
    {
        public string Name { get; }
        /// <summary>
        /// Notation GBP/USD means that the base currency is GBP
        /// </summary>
        public string BaseCurrency { get; }
        /// <summary>
        /// Notation GBP/USD means that the quoted currency is USD
        /// </summary>
        public string QuotedCurrency { get; }

        public decimal Course { get; }

        private CurrencyPair(string name, decimal course)
        {
            if (string.IsNullOrWhiteSpace(name) || name.Length <= 1)
            {
                throw new Exception("Ratio should contains at least 2 symbols");
            }
            if (course <= 0)
            {
                throw new Exception("Cours couldn't be zero or less");
            }

            this.Name = name;
            this.Course = course;
        }

        public CurrencyPair(string name, decimal course, string baseCurrency, string quotedCurrency) : this (name, course)
        {
            if (string.IsNullOrWhiteSpace(baseCurrency))
            {
                throw new Exception("Base Currency Name should contains at least 1 symbols");
            }            
            if (string.IsNullOrWhiteSpace(quotedCurrency))
            {
                throw new Exception("Quoted Currency Name should contains at least 1 symbols");
            }

            this.BaseCurrency = baseCurrency;
            this.QuotedCurrency = quotedCurrency;
        }
    }
}
