namespace BankingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount liliAccount = BankingSystem.CreateAccount("123456", 100, "Lili", 20, 100);
            BankAccount waldoAccount = BankingSystem.CreateAccount("123457", 0, "Waldo", 50, 100);
            BankingSystem.ListBankAccounts();
            BankingSystem.CheckBalance(liliAccount);
            BankingSystem.TryMakeTransaction(liliAccount, waldoAccount, 10);
            BankingSystem.CheckBalance(liliAccount);
            BankingSystem.TryMakeTransaction(liliAccount, waldoAccount, 15, TransactionCategory.Entertainment);
            BankingSystem.CheckBalance(liliAccount);
            BankingSystem.TryMakeTransaction(liliAccount, waldoAccount, 10);
            BankingSystem.CheckBalance(liliAccount);
            BankingSystem.ListTransactions(waldoAccount);
            BankingSystem.MakeDeposit(liliAccount, 50);
            BankingSystem.CheckBalance(liliAccount);
            BankingSystem.TryMakeWithdrawal(liliAccount, 140);
            BankingSystem.CheckBalance(liliAccount);
            BankingSystem.ListTransactions(liliAccount, TransactionCategory.Groceries);
        }
    }
}
