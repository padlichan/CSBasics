using System;
using System.Collections.Generic;
using System.Linq;



namespace BankingSystem
{
    public static class BankingSystem
    {
        private static List<BankAccount> BankAccounts = new List<BankAccount>();
        public static BankAccount CreateAccount(string accountNumber, decimal startingBalance, string ownerName, decimal agreedOverdraft, decimal monthlyLimit)
        {
            BankAccount account = new BankAccount(accountNumber, startingBalance, ownerName, agreedOverdraft, monthlyLimit);
            BankAccounts.Add(account);
            return account;
        }

        public static List<BankAccount> ListBankAccounts()
        {
            foreach(BankAccount account in BankAccounts)
            {
                Console.WriteLine($"Name: {account.OwnerName}, Account number: {account.AccountNumber}");
            }
            return BankAccounts;
        }

        public static bool TryMakeTransaction(BankAccount fromAccount, BankAccount toAccount, decimal amount, TransactionCategory category = TransactionCategory.Default)
        {
            if(amount <= 0)
            {
                Console.WriteLine("Transfer amount must be greater than 0.");
                return false;
            }
            if(!fromAccount.TryUpdateBalance(-1 * amount))
            {
                Console.WriteLine("Not enough funds for transaction.");
                return false;
            }
            toAccount.TryUpdateBalance(amount);
            string transactionId = GenerateTransactionId();
            fromAccount.AddTransaction(new BankTransaction(transactionId, "Withdrawal", amount, DateTime.Now, category));
            toAccount.AddTransaction(new BankTransaction(transactionId, "Deposit", amount, DateTime.Now, category));
            return true;
        }

        public static void MakeDeposit(BankAccount account, decimal amount, TransactionCategory category = TransactionCategory.Default)
        {
            account.TryUpdateBalance(amount);
            account.AddTransaction(new BankTransaction(GenerateTransactionId(), "Deposit", amount, DateTime.Now, category));
        }

        public static bool TryMakeWithdrawal(BankAccount account, decimal amount, TransactionCategory category = TransactionCategory.Default)
        {
            if(amount < 0)
            {
                Console.WriteLine("Amount must be positive.");
                return false;
            }
            if (!account.TryUpdateBalance(-1 * amount))
            {
                Console.WriteLine("Insufficient funds.");
                return false;
            }
            account.AddTransaction(new BankTransaction(GenerateTransactionId(), "Withdrawal", amount, DateTime.Now, category));
            return true;
        }
        public static decimal CheckBalance(BankAccount account)
        {
            Console.WriteLine($"Account owner: {account.OwnerName}, Account balance: {account.Balance}");
            return account.Balance;
        }

        public static List<BankTransaction> ListTransactions(BankAccount account)
        {
            Console.WriteLine($"Account owner: {account.OwnerName}, Bank transactions: ");
            foreach(BankTransaction transaction in account.Transactions)
            {
                Console.WriteLine(transaction.GetTransactionInfo());
            }
            return account.Transactions;
        }

        public static List<BankTransaction> ListTransactions(BankAccount account, TransactionCategory category)
        {
            List<BankTransaction> filteredTransactions = account.Transactions.Where(transaction => transaction.Category == category).ToList();
            Console.WriteLine($"Account owner: {account.OwnerName}, Bank transactions ({category}): ");
            foreach (BankTransaction transaction in filteredTransactions)
            {
                Console.WriteLine(transaction.GetTransactionInfo());
            }
            return filteredTransactions;
        }

        public static string GenerateTransactionId()
        {
            return "00000";
        }
    }
}
