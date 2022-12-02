var elfLetterValues = new Dictionary<string, int>()
{
    { "A", 1 },
    { "B", 2 },
    { "C", 3 }
};

var humanLetterValues = new Dictionary<string, int>
{
    { "X", 1 },
    { "Y", 2 },
    { "Z", 3 }
};

var strategy = File.ReadAllLines("C:\\Users\\vklim\\OneDrive\\Desktop\\Advent Of Code 2022\\aocday2.txt");
var totalScore = 0;

foreach (var round in strategy)
{
    totalScore += DetermineWinnerPart2(round.Split(' '));
}

return totalScore;

int DetermineWinnerPart1(string[] round)
{
    var scoreDifference = humanLetterValues[round[1]] - elfLetterValues[round[0]];
    if (elfLetterValues[round[0]] == humanLetterValues[round[1]])
    {
        return humanLetterValues[round[1]] + 3;
    }
    else if (scoreDifference == 1 || scoreDifference == -2)
    {
        return humanLetterValues[round[1]] + 6;
    }
    else if (scoreDifference == 2 || scoreDifference == -1)
    {
        return humanLetterValues[round[1]];
    }

    return 0;
}

int DetermineWinnerPart2(string[] round)
{
    if (round[1] == "Y")
    {
        foreach (var kvp in humanLetterValues)
        {
            if (kvp.Value - elfLetterValues[round[0]] == 0)
            {
                round[1] = kvp.Key;
                break;
            }
        }
    }
    else if (round[1] == "X")
    {
        foreach (var kvp in humanLetterValues)
        {
            if (kvp.Value - elfLetterValues[round[0]] == 2 || kvp.Value - elfLetterValues[round[0]] == -1)
            {
                round[1] = kvp.Key;
                break;
            }
        }
    }
    else if (round[1] == "Z")
    {
        foreach (var kvp in humanLetterValues)
        {
            if (kvp.Value - elfLetterValues[round[0]] == 1 || kvp.Value - elfLetterValues[round[0]] == -2)
            {
                round[1] = kvp.Key;
                break;
            }
        }
    }

    return DetermineWinnerPart1(round);
}