using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public enum CurrencyType
    {
        USD,
        EUR,
        UAH
    }

    public class Money
    {
        public int Whole { get; set; }
        public int Cents { get; set; }
        public CurrencyType Currency { get; protected set; }

        private static readonly Dictionary<CurrencyType, decimal> ExchangeRates = new Dictionary<CurrencyType, decimal>
        {
            { CurrencyType.UAH, 1m },
            { CurrencyType.USD, 40m },
            { CurrencyType.EUR, 43m }
        };

        protected Money(int whole, int cents, CurrencyType currency)
        {
            Whole = whole;
            Cents = cents;
            Currency = currency;
        }

        public Money(decimal amount, CurrencyType currency)
        {
            Whole = (int)amount;
            Cents = (int)Math.Round((amount - Whole) * 100, 2);
            Currency = currency;
        }

        public void Display()
        {
            Console.WriteLine($"{Whole}.{Cents:D2}{Currency}");
        }

        public Money ConvertTo(CurrencyType targetCurrency)
        {
            if (Currency == targetCurrency)
                return this;

            decimal totalInBase = (Whole + Cents / 100m) * ExchangeRates[Currency];
            decimal convertedAmount = totalInBase / ExchangeRates[targetCurrency];
            return new Money(convertedAmount, targetCurrency);
        }

        public static Money operator -(Money m1, Money m2)
        {
            if (m1.Currency != m2.Currency)
                throw new InvalidOperationException("Неможливо відняти різні валюти");

            int totalCents1 = m1.Whole * 100 + m1.Cents;
            int totalCents2 = m2.Whole * 100 + m2.Cents;
            int resultCents = totalCents1 - totalCents2;

            return new Money(resultCents / 100, resultCents % 100, m1.Currency);
        }
    }
}
