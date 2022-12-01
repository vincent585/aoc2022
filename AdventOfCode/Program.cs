internal class Program
{
    private static int Main(string[] args)
    {
        //var maxCalories = 0;

        var threeElvesCalories = new List<int>();

        var foodCarriedByElves = File.ReadAllText("C:\\Users\\vklim\\OneDrive\\Desktop\\Advent Of Code 2022\\aocday1.txt").Split("\n\n", StringSplitOptions.TrimEntries);

        for (int i = 0; i < foodCarriedByElves.Length; i++)
        {
           string? elf = foodCarriedByElves[i];
           var caloriesCarriedByElf = Array.ConvertAll(elf.Split('\n'), s => int.Parse(s)).Sum();
           
           if (i < 3)
           {
              threeElvesCalories.Add(caloriesCarriedByElf);
           }
            else
            {
                var currentMinCaloriesIndex = threeElvesCalories.IndexOf(threeElvesCalories.Min());

                if (caloriesCarriedByElf > threeElvesCalories.Min())
                {
                    threeElvesCalories[currentMinCaloriesIndex] = caloriesCarriedByElf;
                }
                
            }
           

            //maxCalories = caloriesCarriedByElf > maxCalories ? caloriesCarriedByElf : maxCalories;
        }

        //return maxCalories;

        return threeElvesCalories.Sum();
    }
}