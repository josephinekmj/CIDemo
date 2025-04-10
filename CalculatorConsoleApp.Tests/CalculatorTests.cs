using CalculatorConsoleApp;
using Xunit;

namespace CalculatorConsoleApp.Tests;

public class CalculatorTests
{
    private readonly ICalculator _calc = new Calculator();

    [Fact]
    public void Add_ShouldReturnCorrectSum()
    {
        // Arrange + Act + Assert
        Assert.Equal(7, _calc.Add(4, 3));
    }

    [Fact]
    public void Subtract_ShouldReturnCorrectResult()
    {
        Assert.Equal(2, _calc.Subtract(5, 3));
    }

    [Fact]
    public void Multiply_ShouldReturnCorrectProduct()
    {
        Assert.Equal(15, _calc.Multiply(5, 3));
    }

    [Fact]
    public void Divide_ShouldReturnCorrectQuotient()
    {
        Assert.Equal(2.0, _calc.Divide(6, 3));
    }

    [Fact]
    public void Divide_ByZero_ShouldThrowDivideByZeroException()
    {
        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => _calc.Divide(5, 0));
    }
}