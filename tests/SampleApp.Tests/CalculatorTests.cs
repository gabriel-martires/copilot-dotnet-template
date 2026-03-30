namespace SampleApp.Tests;

public class CalculatorTests
{
    private readonly Calculator _calculator = new();

    [Fact]
    public void Add_TwoNumbers_ReturnsSum()
    {
        var result = _calculator.Add(2, 3);
        Assert.Equal(5, result);
    }

    [Fact]
    public void Subtract_TwoNumbers_ReturnsDifference()
    {
        var result = _calculator.Subtract(10, 4);
        Assert.Equal(6, result);
    }

    [Fact]
    public void Multiply_TwoNumbers_ReturnsProduct()
    {
        var result = _calculator.Multiply(3, 7);
        Assert.Equal(21, result);
    }

    [Fact]
    public void Divide_TwoNumbers_ReturnsQuotient()
    {
        var result = _calculator.Divide(15, 4);
        Assert.Equal(3.75, result);
    }

    [Fact]
    public void Divide_ByZero_ThrowsDivideByZeroException()
    {
        Assert.Throws<DivideByZeroException>(() => _calculator.Divide(10, 0));
    }
}