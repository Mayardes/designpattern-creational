// See https://aka.ms/new-console-template for more information
using SimpleFactory.Factory;
using SimpleFactory.Services;

Console.WriteLine("Hello, World!");

IAccountFactory _accountFactory = new AccountFactory();
var account = new AccountServices(_accountFactory).GenerateAccount(250, SimpleFactory.Enum.TypeAccountEnum.CheckingAccount);
account.MakeDeposit(250);
account.MakeWithDraw(50);

Console.WriteLine($"{account.Balance}");