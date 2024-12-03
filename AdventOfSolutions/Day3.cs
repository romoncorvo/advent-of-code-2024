using System.Collections;
using System.Text.RegularExpressions;

namespace AdventOfSolutions;

public class Day3
{
    public static int ScanCorruptedMemory(string fileName)
    {
        var instructions = GetMultiplicationInstructions(fileName);

        return instructions.Select(x => x.Item1 * x.Item2).Sum();
    }
        
    public static int ScanCorruptedMemoryWithExtraInstructions(string fileName)
    {
        var instructions = GetMultiplicationWithExtraInstructions(fileName);

        return instructions.Select(x => x.Item1 * x.Item2).Sum();
    }

    private static List<(int, int)> GetMultiplicationInstructions(string fileName)
    {
        var unparsedFile = File.ReadAllText(fileName);
        var instructions = new List<(int, int)>();
        var shouldAdd = true;
        
        var regex = new Regex(@"mul\((?<X>\d{1,3}),(?<Y>\d{1,3})\)");
        var matches = regex.Matches(unparsedFile);
        
        foreach (Match match in matches)
        {
                instructions.Add((int.Parse(match.Groups["X"].ToString()), int.Parse(match.Groups["Y"].ToString())));
        }

        return instructions;
    }
    
    private static List<(int, int)> GetMultiplicationWithExtraInstructions(string fileName)
    {
        var unparsedFile = File.ReadAllText(fileName);
        var instructions = new List<(int, int)>();
        var shouldAdd = true;
        
        var regex = new Regex(@"mul\((?<X>\d{1,3}),(?<Y>\d{1,3})\)|(?<Dont>don't())|(?<Do>do())");
        var matches = regex.Matches(unparsedFile);
        
        foreach (Match match in matches)
        {
            if (shouldAdd && match.Groups["X"].Success && match.Groups["Y"].Success)
            {
                instructions.Add((int.Parse(match.Groups["X"].ToString()), int.Parse(match.Groups["Y"].ToString())));
            }
            else if (match.Groups["Dont"].Success)
            {
                shouldAdd = false;
            }
            else if (match.Groups["Do"].Success)
            {
                shouldAdd = true;
            }
        }

        return instructions;
    }
}