using System;
using System.Collections.Generic;
using System.Transactions;

namespace BankingSystem
{
    public enum TransactionCategory
    {
        Groceries,
        Entertainment,
        Default
    }
    public class BankTransaction
    {
        public TransactionCategory Category { get;}
        public string TransactionId {  get; }
        public string Type { get;}
        public decimal Amount { get; }
        public BankTransaction(string transactionId, string type, decimal amount, DateTime timeStamp, TransactionCategory category)
        {
            TransactionId = transactionId;
            Type = type;
            Amount = amount;
            TimeStamp = timeStamp;
            Category = category;
        }

        public DateTime TimeStamp { get; }

        public string GetTransactionInfo()
        {
            return $"Transaction ID: {TransactionId}, Transaction type: {Type}, Amount: {Amount}, TimeStamp: {TimeStamp.ToString()}, " +
                $"Category: {Category}";
        }
    }
}
