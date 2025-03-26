using NUnit.Framework;

namespace Attempt1.Test;

public class StringCalculatorTests
{
    [Test]
    public void GIVEN_EmptyString_WHEN_Adding_THEN_ReturnZero()
    {
        // Arrange
        var input = "";        
        var expectedResult = 0;

        var stringCalculator = new StringCalculator();

        // Act
        var result = stringCalculator.Add(input);

        // Assert
        Assert.That(result, Is.EqualTo(expectedResult));
    } 
}
