namespace CurrencyConverter.DTO
{
    public class Currency
    {
        public string Name { get; }
        public decimal Amount { get; }

        public Currency(string name, decimal amount)
        {
            Name = name;
            Amount = amount;
        }
    }
}
