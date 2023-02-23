using MyBank.Data;
using MyBank.DTO;
using MyBank.Models;
using MyBank.Utils;

namespace MyBank.Services;

public class ApplicationMainService
{
    public string RegisterCustomer(string name, string phone, string password, string email = "")
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
            Solde = 0.5M,
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

        return $"All Setted up. Your checkingResult checkingResult number is {account.AccountNumber}." +
            $"\n your need to keep in a safe place! to lost it please.";
    }

    public BaseResponse DepositMoney(string password, string accountNumber, decimal amountOfMoney)
    {

        var validationResult = TryValidateUser(password, accountNumber, out var customer);
        if (!validationResult.IsSucceed)
            throw new UnauthorizedAccessException("You're not authorized to access this checkingResult.");

        var transactions = new Transaction
        {
            AmountSent = amountOfMoney,
            Sender = customer.Id,
            Receiver = customer.Id,
            DateTime = DateTime.Now,
        };

        MockDataBase.Accounts.Remove(validationResult.Data);

        validationResult.Data.Solde += amountOfMoney;

        MockDataBase.Transactions.Add(transactions);
        MockDataBase.Accounts.Add(validationResult.Data);

        return new BaseResponse(true, "transaction completed");
    }

    public BaseResponse WithDrawMyMoney(string password, string accountNumber, decimal amountOfMoney)
    {

        var validationResult = TryValidateUser(password, accountNumber, out var customer);
        if (!validationResult.IsSucceed)
            throw new UnauthorizedAccessException("You're not authorized to access this checkingResult.");

        var transactions = new Transaction
        {
            AmountSent = amountOfMoney,
            Sender = customer.Id,
            Receiver = customer.Id,
            DateTime = DateTime.Now,
            IsActive = true,
        };

        MockDataBase.Accounts.Remove(validationResult.Data);

        validationResult.Data.Solde -= amountOfMoney;

        MockDataBase.Transactions.Add(transactions);
        MockDataBase.Accounts.Add(validationResult.Data);

        return new BaseResponse(true, "transaction completed");
    }

    public BaseResponse TransferMonenyToFriend(string password, string accountNumber, string recieverAcount, decimal amountOfMoney)
    {
        var validationResult = TryValidateUser(password, accountNumber, out var customer);
        if (!validationResult.IsSucceed)
            throw new UnauthorizedAccessException("You're not authorized to access this checkingResult.");

        var receiver = MockDataBase.Accounts.FirstOrDefault(c => c.AccountNumber == recieverAcount && c.IsActive);
        if (receiver is null) return new BaseResponse(false, "Receiver does not exist. please refers an existing checkingResult");

        var receiverAccount = MockDataBase.CustomerAccounts.FirstOrDefault(ca => ca.AccountId == receiver.Id);
        if (receiverAccount is null) return new BaseResponse(false, "Receiver does not exist. please refers an existing checkingResult");

        var transactions = new Transaction
        {
            AmountSent = amountOfMoney,
            Sender = customer.Id,
            Receiver = receiverAccount.Id,
            DateTime = DateTime.Now,
            IsActive = true,
        };

        MockDataBase.Accounts.Remove(validationResult.Data);
        MockDataBase.Accounts.Remove(receiver);

        validationResult.Data.Solde -= amountOfMoney;
        receiver.Solde += amountOfMoney;

        MockDataBase.Transactions.Add(transactions);

        MockDataBase.Accounts.Add(receiver);
        MockDataBase.Accounts.Add(validationResult.Data);

        return new BaseResponse(true, "transaction completed");
    }

    public BaseResponse GetSolde(string password, string accountNumber)
    {
        var checkingResult = ValidateUser(password, accountNumber);
        if (!checkingResult.IsSucceed) return new BaseResponse(false, checkingResult.meessage);

        return new BaseResponse(true, $"Your actual sold is {checkingResult.Data.Solde}");
    }

    private BaseResponse<Account> TryValidateUser(string password, string accountNumber, out Customer? customer)
    {
        customer = default!;

        var account = MockDataBase.Accounts.FirstOrDefault(a => a.AccountNumber == accountNumber && a.IsActive);
        if (account is null)
            new BaseResponse(false, "Oops! this checkingResult does not exist. Please enter valid credentials");

        //var owner = from ac in MockDataBase.CustomerAccounts
        //            where ac.IsActive == true && ac.AccountId == checkingResult.Id
        //            select ac;

        var accountOnwer = MockDataBase.CustomerAccounts.FirstOrDefault(x => x.IsActive && x.AccountId == account?.Id);
        if (accountOnwer is null)
            new BaseResponse(false, "this checkingResult does not have an owner. ");

        var owner = MockDataBase.Customers.FirstOrDefault(c => c.Id == accountOnwer?.CustomerId && c.IsActive);
        if (owner is null) new BaseResponse(false, "Access error. try again");

        var encryptedPwd = Cryptor.EncryptPassword(password);
        if (owner?.Password != encryptedPwd)
            new BaseResponse(false, "Error on the password. incorrect password. did you forget it?? try again later");

        customer = owner;

        return new BaseResponse<Account>(true, "Validation passed", account!);
    }

    private BaseResponse<Account> ValidateUser(string password, string accountNumber)
    {
        var account = MockDataBase.Accounts.FirstOrDefault(a => a.AccountNumber == accountNumber && a.IsActive);
        if (account is null)
            new BaseResponse(false, "Oops! this checkingResult does not exist. Please enter valid credentials");

        //var owner = from ac in MockDataBase.CustomerAccounts
        //            where ac.IsActive == true && ac.AccountId == checkingResult.Id
        //            select ac;

        var accountOnwer = MockDataBase.CustomerAccounts.FirstOrDefault(x => x.IsActive && x.AccountId == account?.Id);
        if (accountOnwer is null)
            new BaseResponse(false, "this checkingResult does not have an owner. ");

        var owner = MockDataBase.Customers.FirstOrDefault(c => c.Id == accountOnwer?.CustomerId && c.IsActive);
        if (owner is null) new BaseResponse(false, "Access error. try again");

        var encryptedPwd = Cryptor.EncryptPassword(password);
        if (owner?.Password != encryptedPwd)
            new BaseResponse(false, "Error on the password. incorrect password. did you forget it?? try again later");


        return new BaseResponse<Account>(true, "Validation passed", account!);
    }
}


