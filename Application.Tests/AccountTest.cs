using System;
using Xunit;
using Library;
using FluentAssertions;

namespace Application.Tests
{
  public class AccountTest
  {
    private Account _account;

    public AccountTest()
    {
      _account = new("CX-3", "Monica", "Barns");
    }

    [Fact]
    public void AccountShouldBeProperlyInitialized()
    {
      // Arrange
      // Act
      // Assert
      _account.Balance.Should().Be(0);
      _account.Id.Should().Be("CX-3");
      _account.Owner.ToString().Should().Be("Monica Barns");
    }

    [Theory]
    [InlineData(20)]
    [InlineData(25)]
    [InlineData(30)]
    public void DepositingMoneyInAccountShouldWork(int value)
    {
      // Arrange
      // Act
      _account.Deposit(value);
      // Assert
      _account.Balance.Should().Be(value);
      _account.Transactions[0].Should().Be($"Deposit: ${value}");
    }

    [Fact]
    public void ShouldNotBeAbleToDepositNegativeAmount()
    {
      // Arrange
      // Act
      Action action = () => _account.Deposit(-10);
      // Assert
      action.Should().Throw<ApplicationException>()
      .WithMessage("Cannot deposit negative amounts");
      _account.Transactions.Should().HaveCount(0);
    }

    [Fact]
    public void ShouldNotBeAbleToWithdrawlNegativeAmount()
    {
      // Arrange
      // Act
      Action action = () => _account.Withdrawal(-10);
      // Assert
      action.Should().Throw<ApplicationException>()
      .WithMessage("Cannot withdrawal negative amounts");
      _account.Transactions.Should().HaveCount(0);
    }

    [Fact]
    public void ShouldThrowExceptionIfWithdrawlIsTooLarge()
    {
      // Arrange
      _account.Deposit(100);
      // Act
      Action action = () => _account.Withdrawal(101);
      // Assert
      action.Should().Throw<ApplicationException>()
      .WithMessage("Not enough funds in account");
      _account.Transactions.Should().HaveCount(1);
      _account.Balance.Should().Be(100);
    }

    [Fact]
    public void ShouldAllowDepositAndWithdrawl()
    {
      // Arrange
      _account.Deposit(100);
      // Act
      _account.Withdrawal(30);
      // Assert
      _account.Balance.Should().Be(70);
      _account.Transactions.Should().HaveCount(2);
    }
  }
}
