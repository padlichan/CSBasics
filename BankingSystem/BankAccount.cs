using System;
using System.Collections.Generic;

namespace BankingSystem
{
    public class BankAccount
    {
        public string? AccountNumber { get; private set; }
        public decimal Balance { get; private set; }
        public string? OwnerName { get; private set; }
        public decimal AgreedOverdraft { get; private set; }
        public List<BankTransaction> Transactions { get; private set; }
        public decimal MonthlyLimit { get; private set; }
        public BankAccount(string accountNumber, decimal balance, string ownerName, decimal agreedOverdraft, decimal monthlyLimit) 
        {
            AccountNumber = accountNumber;
            Balance = balance;
            OwnerName = ownerName;
            AgreedOverdraft = agreedOverdraft;
            Transactions = new List<BankTransaction>();
            MonthlyLimit = monthlyLimit;
        }
        public bool TryUpdateBalance(decimal amount)
        {
            if (Balance + amount >= -1*AgreedOverdraft)
            {
                Balance += amount;
                return true;
            }
            return false;
        }

        public void AddTransaction(BankTransaction transaction)
        {
            Transactions.Add(transaction);
        }
    }
}
