using System;
using Library;

namespace Application
{
  class Program
  {
    static void Main(string[] args)
    {
      Bank b = new();
      b.AddAccount("A1", "Sarah", "Conner");
      b.Accounts[0].Deposit(1000);
      b.Accounts[0].Withdrawal(100);
      Console.WriteLine($"Balance : {b.Accounts[0].Balance}");
    }
  }
}
