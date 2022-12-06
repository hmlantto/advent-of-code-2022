namespace day1_puzzle2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read input from file
            string path = @"C:\work\Omat projektit\advent-of-code\input\day1.txt";
            string[] input = File.ReadAllLines(path);

            // Variable initialization
            int currentElf      = 0;           // Current elf
            int currentCalories = 0;           // The calorie count for currentElf
            int maxCalories1    = 0;           // The highest calorie count
            int maxCalories2    = 0;           // The 2nd highest calorie count
            int maxCalories3    = 0;           // The 3rd highest calorie count

            // Iterate through the input array
            for ( int i = 0; i < input.Length; i++ )
            {
                // If we reached the end of this elf's list
                if ( input[i].Length == 0 )
                {
                    currentElf++;

                    if ( currentCalories > maxCalories1 )
                    {
                        maxCalories3 = maxCalories2    ;
                        maxCalories2 = maxCalories1    ;
                        maxCalories1 = currentCalories ;
                    }
                    else if ( currentCalories > maxCalories2 )
                    {
                        maxCalories3 = maxCalories2    ;
                        maxCalories2 = currentCalories ;
                    }
                    else if ( currentCalories > maxCalories3 )
                    {
                        maxCalories3 = currentCalories ;
                    }

                    currentCalories = 0;
                }
                // Else keep adding calories to this elf's count
                else
                {
                    currentCalories += Int32.Parse(input[i]);
                }
            }

            int maxCalories = maxCalories1 + maxCalories2 + maxCalories3 ;

            // Print results
            Console.WriteLine( "Calorie count: " + maxCalories ) ;
        }
    }
}