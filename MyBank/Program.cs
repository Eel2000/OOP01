using MyBank.Services;
using System.Linq.Expressions;

namespace MyBank
{
    internal class Program
    {
        private static ApplicationMainService mainService = new();//initialize first the service
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------MY SAVIOUR--------------");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();

            string? response = string.Empty;
            do
            {

                Console.WriteLine("Welcome to our bank app. to start we've a question. Have an account? (Y/N)");
                response = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(response));


            if (response.ToUpper() == "N")
            {
                string? identities = string.Empty;
                do
                {
                    Console.WriteLine("In order to continue please register first. to do so  enter your name and phone in one line");
                    identities = Console.ReadLine();
                } while (string.IsNullOrWhiteSpace(identities));

                Console.WriteLine("please define a password for your account security");
                string? password = string.Empty;

                do
                {
                    Console.WriteLine($"{identities} please specify a password!");
                    password = Console.ReadLine();
                } while (string.IsNullOrWhiteSpace(password));

                Console.WriteLine("Processing to the account creation." +
                    " Your account will have a starting sold 0.5 credit");

                try
                {
                    var ids = identities.Split(' ');
                    var result = mainService.RegisterCustomer(ids.First(), ids.Last(), password);
                    Console.WriteLine(result);

                }
                catch (Exception e)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"Ooops! your application crushed!\n\r{e.Message}");
                }
                finally
                {
                menu:
                    int selectedMenu = 0;
                    DisplayMenu(ref selectedMenu);
                    try
                    {
                        switch (selectedMenu)
                        {
                            case 1: Deposit(); goto menu;
                            case 2: WithDraw(); goto menu;
                            case 3: Transfers(); goto menu;
                            case 4: GetSolde(); goto menu;
                            default: goto menu;
                        }
                    }
                    catch (Exception e)
                    {

                        Console.Clear();
                        Console.WriteLine(e.Message);
                        goto menu;
                    }
                }

            }
            else
            {
            menu:
                int selectedMenu = 0;
                DisplayMenu(ref selectedMenu);
                try
                {
                    switch (selectedMenu)
                    {
                        case 1: Deposit(); goto menu;
                        case 2: WithDraw(); goto menu;
                        case 3: Transfers(); goto menu;
                        case 4: GetSolde(); goto menu;
                        default: goto menu;
                    }
                }
                catch (Exception e)
                {

                    Console.Clear();
                    Console.WriteLine(e.Message);
                    goto menu;
                }
            }
        }

        private static void DisplayMenu(ref int selectedMenu)
        {
            var menu = new string[] { "1.Deposite money ", "2.WithDraw money", "3.Transfer money", "4. Solde" };

            do
            {
                Console.WriteLine("Choose the option for what you want to do");
                foreach (var menuItem in menu)
                {
                    Console.WriteLine(menuItem);
                }

                int.TryParse(Console.ReadLine(), out selectedMenu);

            } while (selectedMenu == 0);
        }

        private static void GetSolde()
        {
            var response = string.Empty;
            do
            {
                Console.WriteLine("Please enter your password and the account number in one line(required to follow to struct '1 password,2 account number')");
                response = Console.ReadLine();
            } while (string.IsNullOrEmpty(response));
            Console.WriteLine("Processing...");
            var info = response.Split(" ");
            mainService.GetSolde(info.First(), info.Last());
        }

        private static void Transfers()
        {
            var response = string.Empty;
            do
            {
                Console.WriteLine("Please enter your password and the account number in one line(required to follow to struct '1 password,2 account number')");
                response = Console.ReadLine();
            } while (string.IsNullOrEmpty(response));

            decimal amountToWithdraw = 0M;
            do
            {
                Console.WriteLine("Enter the amount to withdraw.");
                decimal.TryParse(Console.ReadLine(), out amountToWithdraw);
            } while (amountToWithdraw == 0M);

            Console.WriteLine("Processing...");
            var info = response.Split(" ");
            mainService.WithDrawMyMoney(info.First(), info.Last(), amountToWithdraw);
        }

        private static void WithDraw()
        {
            var response = string.Empty;
            do
            {
                Console.WriteLine("Please enter your password and the account number in one line(required to follow to struct '1 password,2 account number')");
                response = Console.ReadLine();
            } while (string.IsNullOrEmpty(response));

            var recieverAccount = string.Empty;
            do
            {
                Console.WriteLine("Please enter the receiver account number");
                recieverAccount = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(recieverAccount));

            decimal amountToTranfers = 0M;
            do
            {
                Console.WriteLine("Enter the amoun to transfer.");
                decimal.TryParse(Console.ReadLine(), out amountToTranfers);
            } while (amountToTranfers == 0M);

            Console.WriteLine("Processing...");
            var info = response.Split(" ");
            mainService.TransferMonenyToFriend(info.First(), info.Last(), recieverAccount, amountToTranfers);
        }

        private static void Deposit()
        {
            var response = string.Empty;
            do
            {
                Console.WriteLine("Please enter your password and the account number in one line(required to follow to struct '1 password,2 account number')");
                response = Console.ReadLine();
            } while (string.IsNullOrEmpty(response));

            decimal amountToTranfers = 0M;
            do
            {
                Console.WriteLine("Enter the amoun to Deposit.");
                decimal.TryParse(Console.ReadLine(), out amountToTranfers);
            } while (amountToTranfers == 0M);

            Console.WriteLine("Processing...");
            var info = response.Split(" ");
            mainService.DepositMoney(info.First(), info.Last(), amountToTranfers);
        }
    }
}