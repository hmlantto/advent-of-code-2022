namespace day2_puzzle2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rock     = 1 ;
            int paper    = 2 ;
            int scissors = 3 ;
            int loss     = 0 ;
            int draw     = 3 ;
            int win      = 6 ;
            int score    = 0 ;

            string path    = @"C:\work\Omat projektit\advent-of-code\input\day2.txt";
            string[] input = File.ReadAllLines(path);

            for (int i = 0; i < input.Length; i++)
            {
                string[] items = input[i].Split(' ');
                
                string opponent = items[0] ;
                string result   = items[1] ;
                
                if ( result.Equals( "X" ) )                 // loss
                {
                    score += loss ;

                    switch ( opponent )
                    {
                        case "A":                           // rock
                            score += scissors ;
                            break;
                        case "B":                           // paper
                            score += rock ;
                            break;
                        case "C":                           // scissors
                            score += paper ;
                            break;
                        default:
                            break ;
                    }
                }
                else if ( result.Equals ( "Y" ) )           // draw
                {
                    score += draw ;

                    switch ( opponent )
                    {
                        case "A":                           // rock
                            score += rock ;
                            break;
                        case "B":                           // paper
                            score += paper ;
                            break;
                        case "C":                           // scissors
                            score += scissors ;
                            break;
                        default:
                            break ;
                    }
                }
                else if ( result.Equals( "Z" ) )            // win
                {
                    score += win ;

                    switch ( opponent )
                    {
                        case "A":                           // rock
                            score += paper ;
                            break;
                        case "B":                           // paper
                            score += scissors ;
                            break;
                        case "C":                           // scissors
                            score += rock ;
                            break;
                        default:
                            break ;
                    }
                }
            }

            Console.WriteLine ( "Score: " + score ) ;
        }
    }
}