using System.Formats.Asn1;
using System.Text.RegularExpressions;

var stacks = new Dictionary<int, Stack<char>>
{
    { 1, new Stack<char>(new[] { 'T', 'D', 'W', 'Z', 'V', 'P' }) },
    { 2, new Stack<char>(new[] {'L', 'S', 'W', 'V', 'F', 'J', 'D' }) },
    { 3, new Stack<char>(new[] { 'Z', 'M', 'L', 'S', 'V', 'T', 'B', 'H' }) },
    { 4, new Stack<char>(new[] { 'R', 'S', 'J' }) },
    { 5, new Stack<char>(new[] { 'C', 'Z', 'B', 'G', 'F', 'M', 'L', 'W' }) },
    { 6, new Stack<char>(new[] { 'Q', 'W', 'V', 'H', 'Z', 'R', 'G', 'B' }) },
    { 7, new Stack<char>(new[] { 'V', 'J', 'P', 'C', 'B', 'D', 'N' }) },
    { 8, new Stack<char>(new[] { 'P', 'T', 'B', 'Q' }) },
    { 9, new Stack<char>(new[] { 'H', 'G', 'Z', 'R', 'C' }) }
};


var instructions = File.ReadAllLines("C:\\Users\\vklim\\OneDrive\\Desktop\\Advent Of Code 2022\\aocday5.txt").Skip(10).ToArray();

var rgx = new Regex(@"\d+");
foreach (var line in instructions)
{
    var movement = rgx.Matches(line);

    var numberOfUnitsToMove = int.Parse(movement[0].Value);
    var moveFrom = int.Parse(movement[1].Value);
    var moveTo = int.Parse(movement[2].Value);

    var movedUnits = new List<char>();

    while (movedUnits.Count < numberOfUnitsToMove)
    {
        movedUnits.Add(stacks[moveFrom].Pop());
    }

    foreach (var unit in movedUnits)
    {
        stacks[moveTo].Push(unit);
    }
}

foreach (var stack in stacks)
{
    Console.Write(stack.Value.Peek());
}





