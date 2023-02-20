using MyBank.Data;
using MyBank.Models;
using MyBank.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBank.Services
{
    public class ApplicationMainService
    {
        public string RegisterCustomer(string name, string phone, string password, string email)
        {
            Customer customer = new()
            {
                Name = name,
                Telephone = phone,
                Password = Cryptor.EncryptPassword(password),
                Email = email,
                IsActive = true,
                RegistrationDate = DateTime.Now
            };

            if (MockDataBase.Customers.Any(c => c.Name.ToUpper() == name))
                return "this customer exist";

            Account account = new()
            {
                AccountNumber = AccountNumberGenerator.Generate(),
                AmountOfMoney = 0.5M,
                CreationDate = DateTime.Now,
                IsActive = true,
            };

            CustomerAccount customerAccount = new()
            {
                CustomerId = customer.Id,
                AccountId = account.Id,
                IsActive = true,
            };

            MockDataBase.Customers.Add(customer);
            MockDataBase.Accounts.Add(account);
            MockDataBase.CustomerAccounts.Add(customerAccount);

            return $"All Setted up. Your account account number is {account.AccountNumber}." +
                $"\n your need to keep in a safe place! to lost it please.";
        }
    }
}
