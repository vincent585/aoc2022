var datastream = File.ReadAllText("C:\\Users\\vklim\\OneDrive\\Desktop\\Advent Of Code 2022\\aocday6.txt");

for (int i = 0; i < datastream.Length - 3; i++)
{
    var sequence = datastream.Substring(i, 4);
    if (sequence.Distinct().Count() == sequence.Length)
    {
        return i + 4;
    }
}

return 0;