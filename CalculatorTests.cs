using Xunit;
using CalculatorLib;

public class CalculatorTests
{
    [Fact]
    public void Add_ReturnsCorrectSum()
    {
        var calculator = new Calculator();
        Assert.Equal(5, calculator.Add(2, 3));
    }

    [Fact]
    public void Subtract_ReturnsCorrectDifference()
    {
        var calculator = new Calculator();
        Assert.Equal(1, calculator.Subtract(3, 2));
    }
}
