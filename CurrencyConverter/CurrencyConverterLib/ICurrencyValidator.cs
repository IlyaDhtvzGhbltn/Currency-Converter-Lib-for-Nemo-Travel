using CurrencyConverter.DTO;

namespace CurrencyConverter
{
    public interface ICurrencyCaster
    {
        decimal CastToBase(Currency curr, CurrencyPair pair);
        decimal CastToQuoted(Currency curr, CurrencyPair pair);
    }
}
