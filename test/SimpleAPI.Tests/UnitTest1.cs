namespace SimpleAPI.Tests;

using SimpleAPI.Controllers;

public class UnitTest1
{
    ValuesController controller = new ValuesController(); // Arrange
    [Fact]
    public void Test1()
    {
        var returnValue = controller.Get(1); //Act
          Assert.Equal("Rajeev", returnValue); //Assert
    }
}