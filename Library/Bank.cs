using System.Collections.Generic;

namespace Library
{
  public class Bank
  {
    public List<Account> Accounts { get; set; }
    public Bank()
    {
      Accounts = new List<Account>();
    }
    public void AddAccount(string id, string first, string last)
    {
      var account = new Account(id, first, last);
      Accounts.Add(account);
    }
  }
}
