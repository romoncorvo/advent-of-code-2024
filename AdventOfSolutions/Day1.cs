namespace AdventOfSolutions;

public class Day1
{
    public static int FindListDistance(string fileName)
    {
        var unparsedFile = File.ReadAllLines(fileName);
        var list1 = new List<int>();
        var list2 = new List<int>();
        
        foreach (var line in unparsedFile)
        {
            var split = line.Split("  ");
            list1.Add(int.Parse(split[0]));
            list2.Add(int.Parse(split[1]));
        }
        
        list1.Sort();
        list2.Sort();
        var distance = 0;

        for (var i = 0; i < list1.Count; i++)
        {
            distance += Math.Abs(list1[i] - list2[i]);
        }
        
        return distance;
    }
}