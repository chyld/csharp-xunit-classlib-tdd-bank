using Xunit;
using Library;
using FluentAssertions;

namespace Application.Tests
{
  public class BankTest
  {
    private Bank _bank;

    public BankTest()
    {
      _bank = new();
    }

    [Fact]
    public void NewBankShouldHaveNoAccounts()
    {
      // Arrange
      // Act
      // Assert
      _bank.Accounts.Should().HaveCount(0);
    }

    [Fact]
    public void BankShouldHaveOneAccount()
    {
      // Arrange
      // Act
      _bank.AddAccount("AB-1", "Sara", "Jones");
      // Assert
      _bank.Accounts.Should().HaveCount(1);
    }
  }
}
