using System;
using System.Collections.Generic;

namespace Library
{
  public class Account
  {
    private decimal _balance;
    private List<string> _transactions;
    public decimal Balance => _balance;
    public List<string> Transactions => _transactions;
    public string Id { get; set; }
    public User Owner { get; set; }
    public Account(string id, string first, string last)
    {
      _balance = 0;
      Id = id;
      Owner = new() { First = first, Last = last };
      _transactions = new();
    }
    public void Deposit(decimal amount)
    {
      if (amount < 0)
        throw new ApplicationException("Cannot deposit negative amounts");

      _balance += amount;
      _transactions.Add($"Deposit: ${amount}");
    }
    public void Withdrawal(decimal amount)
    {
      if (amount < 0)
        throw new ApplicationException("Cannot withdrawal negative amounts");

      if (amount > _balance)

        throw new ApplicationException("Not enough funds in account");

      _balance -= amount;
      _transactions.Add($"Withdrawal: ${amount}");
    }
  }
}
