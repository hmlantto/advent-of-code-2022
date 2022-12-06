namespace day1_puzzle1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read input from file
            string path = @"C:\work\Omat projektit\advent-of-code\input\day1.txt" ;
            string[] input = File.ReadAllLines( path ) ;

            // Variable initialization
            int currentElf      = 0 ;           // Current elf
            int maxElf          = 0 ;           // The elf with most calories
            int currentCalories = 0 ;           // The calorie count for currentElf
            int maxCalories     = 0 ;           // The calorie count for maxElf

            // Iterate through the input array
            for ( int i = 0 ; i < input.Length ; i++ )
            {
                // If we reached the end of this elf's list
                if ( input[i].Length == 0 )
                {
                    currentElf++;

                    if ( currentCalories > maxCalories )
                    {
                        maxCalories = currentCalories ;
                        maxElf      = currentElf      ;
                    }

                    currentCalories = 0 ;
                }
                // Else keep adding calories to this elf's count
                else
                {
                    currentCalories += Int32.Parse( input[i] ) ;
                }
            }

            // Print results
            Console.WriteLine( "Elf with most calories is elf number " + maxElf ) ;
            Console.WriteLine( "Calorie count: " + maxCalories ) ;
        }
    }
}