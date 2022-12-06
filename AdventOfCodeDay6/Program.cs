var datastream = File.ReadAllText("C:\\Users\\vklim\\OneDrive\\Desktop\\Advent Of Code 2022\\aocday6.txt");

// part 1

//for (int i = 0; i < datastream.Length - 3; i++)
//{
//    var sequence = datastream.Substring(i, 4);
//    if (sequence.Distinct().Count() == sequence.Length)
//    {
//        return i + 4;
//    }
//}

// part 2

for (int i = 0; i < datastream.Length - 13; i++)
{
    var sequence = datastream.Substring(i, 14);
    if (sequence.Distinct().Count() == sequence.Length)
    {
        return i + 14;
    }
}

return 0;