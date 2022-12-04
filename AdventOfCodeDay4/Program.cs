var sectionPairs = File.ReadAllLines("C:\\Users\\vklim\\OneDrive\\Desktop\\Advent Of Code 2022\\aocday4.txt");

var redundantPairs = 0;

foreach (var pair in sectionPairs)
{
    var pairArray = pair.Split(',');

    var firstElf = pairArray[0].Split('-');
    var secondElf = pairArray[1].Split('-');

    var firstElfRange = Enumerable.Range(int.Parse(firstElf[0]), int.Parse(firstElf[1]) - int.Parse(firstElf[0]) + 1);
    var secondElfRange = Enumerable.Range(int.Parse(secondElf[0]), int.Parse(secondElf[1]) - int.Parse(secondElf[0]) + 1);

    // redundantPairs += PartOneSolution(firstElfRange, secondElfRange);
    redundantPairs += PartTwoSolution(firstElfRange, secondElfRange);
}

return redundantPairs;

int PartOneSolution(IEnumerable<int> firstElfRange, IEnumerable<int> secondElfRange)
{
    IEnumerable<int>? smallerRange = null;
    IEnumerable<int>? widerRange = null;

    if (firstElfRange.Count() >= secondElfRange.Count())
    {
        widerRange = firstElfRange;
        smallerRange = secondElfRange;
    }
    else
    {
        widerRange = secondElfRange;
        smallerRange = firstElfRange;
    }

    if (smallerRange.All(x => widerRange.Contains(x))) return 1;

    return 0;
}

int PartTwoSolution(IEnumerable<int> firstElfRange, IEnumerable<int> secondElfRange)
{
    if (firstElfRange.Any(x => secondElfRange.Contains(x))) return 1;

    return 0;
}