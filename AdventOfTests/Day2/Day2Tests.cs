using Xunit.Abstractions;
using static AdventOfSolutions.Day2;

namespace AdventOfTests.Day2;

public class Day2Tests
{
    private readonly ITestOutputHelper _testOutputHelper;

    public Day2Tests(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void CountSafeReports_WithExampleInput_ReturnsExampleAnswer()
    {
        // Arrange
        var filePath = "./Day2/day-2-2-example.txt";
        
        // Act
        var result = CountSafeReports(filePath);
        
        // Assert
        Assert.Equal(2, result);
    }
    
    [Fact]
    public void CountSafeReports_WithRealInput_ReturnsAnswer()
    {
        // Arrange
        var filePath = "./Day2/day-2-2-input.txt";
        
        // Act
        var result = CountSafeReports(filePath);
        
        // Assert
        _testOutputHelper.WriteLine(result.ToString());
    }
    
    [Fact]
    public void CountSafeReportsWithTolerance_WithExampleInput_ReturnsExampleAnswer()
    {
        // Arrange
        var filePath = "./Day2/day-2-2-example.txt";
        
        // Act
        var result = CountSafeReportsWithTolerance(filePath);
        
        // Assert
        Assert.Equal(4, result);
    }
    
    [Fact]
    public void CountSafeReportsWithTolerance_WithRealInput_ReturnsAnswer()
    {
        // Arrange
        var filePath = "./Day2/day-2-2-input.txt";
        
        // Act
        var result = CountSafeReportsWithTolerance(filePath);
        
        // Assert
        _testOutputHelper.WriteLine(result.ToString());
    }
}