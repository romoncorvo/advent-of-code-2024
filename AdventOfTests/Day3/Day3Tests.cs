using Xunit.Abstractions;
using static AdventOfSolutions.Day3;

namespace AdventOfTests.Day3;

public class Day3Tests
{
    private readonly ITestOutputHelper _testOutputHelper;

    public Day3Tests(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void ScanCorruptedMemory_WithExampleInput_ReturnsExampleAnswer()
    {
        // Arrange
        var filePath = "./Day3/day-3-example.txt";
        
        // Act
        var result = ScanCorruptedMemory(filePath);
        
        // Assert
        Assert.Equal(161, result);
    }
    
    [Fact]
    public void ScanCorruptedMemory_WithRealInput_ReturnsAnswer()
    {
        // Arrange
        var filePath = "./Day3/day-3-input.txt";
        
        // Act
        var result = ScanCorruptedMemory(filePath);
        
        // Assert
        _testOutputHelper.WriteLine(result.ToString());
    }
    
    [Fact]
    public void ScanCorruptedMemoryWithExtraInstructions_WithExampleInput_ReturnsExampleAnswer()
    {
        // Arrange
        var filePath = "./Day3/day-3-example.txt";
        
        // Act
        var result = ScanCorruptedMemoryWithExtraInstructions(filePath);
        
        // Assert
        Assert.Equal(48, result);
    }
    
    [Fact]
    public void ScanCorruptedMemoryWithExtraInstructions_WithRealInput_ReturnsAnswer()
    {
        // Arrange
        var filePath = "./Day3/day-3-input.txt";
        
        // Act
        var result = ScanCorruptedMemoryWithExtraInstructions(filePath);
        
        // Assert
        _testOutputHelper.WriteLine(result.ToString());
    }
}