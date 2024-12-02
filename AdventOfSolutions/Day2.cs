using System.Collections;

namespace AdventOfSolutions;

public class Day2
{
    public static int CountSafeReports(string fileName)
    {
        var reports = GetReports(fileName);

        return reports.Count(CheckReportSafety);
    }

    private static bool CheckReportSafety(List<int> report)
    {
        var isIncreasing = report[0] < report[1];
        for (var i = 1; i < report.Count; i++)
        {
            var previousLevel = report[i - 1];
            var level = report[i];
            if (isIncreasing != previousLevel < level)
            {
                return false;
            }
            
            var difference = Math.Abs(previousLevel - level);
            if (difference is < 1 or > 3)
            {
                return false;
            }
        }

        return true;
    }
    
    public static int CountSafeReportsWithTolerance(string fileName)
    {
        var reports = GetReports(fileName);

        return reports.Count(CheckReportSafetyWithTolerance);
    }
    
    private static bool CheckReportSafetyWithTolerance(List<int> report)
    {
        List<List<int>> reportPermutations = [report];
        
        for (var i = 0; i < report.Count; i++)
        {
            var permutation = new List<int>(report);
            permutation.RemoveAt(i);
            reportPermutations.Add(permutation);
        }

        return reportPermutations.Any(CheckReportSafety);
    }

    private static List<List<int>> GetReports(string fileName)
    {
        var unparsedFile = File.ReadAllLines(fileName);
        var reports = new List<List<int>>();
        
        foreach (var line in unparsedFile)
        {
            var report = line.Split(" ").Select(int.Parse).ToList();
            reports.Add(report);
        }

        return reports;
    }
}