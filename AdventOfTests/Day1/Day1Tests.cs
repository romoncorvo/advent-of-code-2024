using Xunit.Abstractions;
using static AdventOfSolutions.Day1;

namespace AdventOfTests.Day1;

public class Day1Tests
{
    private readonly ITestOutputHelper _testOutputHelper;

    public Day1Tests(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void FindListDistance_WithExampleInput_ReturnsExampleAnswer()
    {
        // Arrange
        var filePath = "./Day1/day-1-example.txt";
        
        // Act
        var result = FindListDistance(filePath);
        
        // Assert
        Assert.Equal(11, result);
    }
    
    [Fact]
    public void FindListDistance_WithRealInput_ReturnsAnswer()
    {
        // Arrange
        var filePath = "./Day1/day-1-input.txt";
        
        // Act
        var result = FindListDistance(filePath);
        
        // Assert
        _testOutputHelper.WriteLine(result.ToString());
    }
    
    [Fact]
    public void FindListSimilarity_WithExampleInput_ReturnsExampleAnswer()
    {
        // Arrange
        var filePath = "./Day1/day-1-example.txt";
        
        // Act
        var result = FindListSimilarity(filePath);
        
        // Assert
        Assert.Equal(31, result);
    }
    
    [Fact]
    public void FindListSimilarity_WithRealInput_ReturnsAnswer()
    {
        // Arrange
        var filePath = "./Day1/day-1-input.txt";
        
        // Act
        var result = FindListSimilarity(filePath);
        
        // Assert
        _testOutputHelper.WriteLine(result.ToString());
    }
}