using Xunit;
using Library;
using FluentAssertions;

namespace Application.Tests
{
  public class UserTest
  {
    [Fact]
    public void UserObjectShouldDisplayFullName()
    {
      // Arrange
      User user = new() { First = "Bob", Last = "Smith" };
      // Act
      string fullName = user.ToString();
      // Assert
      fullName.Should().Be("Bob Smith");
    }
  }
}
