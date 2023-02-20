using MyBank.Models;
using System.Collections.ObjectModel;

namespace MyBank.Data
{
    /// <summary>
    /// Our mock database.
    /// simple class that olds all of this program data tha we want to save for later use.
    /// </summary>
    public static class MockDataBase
    {
        public static ObservableCollection<Customer> Customers = new();
        public static ObservableCollection<Account> Accounts = new();
        public static ObservableCollection<Transaction> Transactions = new();
        public static ObservableCollection<CustomerAccount> CustomerAccounts = new();
    }
}
