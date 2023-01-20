using NUnit.Framework;

[TestFixture]
public class CalculatorTests
{
    private Calculator calculator;

    [SetUp]
    public void SetUp()
    {
        calculator = new Calculator();
    }

    [Test]
    public void Add_WhenCalled_ReturnsTheSumOfArguments()
    {
        // Arrange
        var a = 1;
        var b = 2;

        // Act
        var result = calculator.Add(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(3));
    }

    [Test]
    public void Subtract_WhenCalled_ReturnsTheDifferenceOfArguments()
    {
        // Arrange
        var a = 1;
        var b = 2;

        // Act
        var result = calculator.Subtract(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(-1));
    }
}
