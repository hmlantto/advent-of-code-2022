namespace day2_puzzle1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string   path  = @"C:\work\omat\advent-of-code\input\day2.txt" ;
            string[] input = File.ReadAllLines( path ) ;

            Game game  = new Game( input ) ;
            int  score = game.playGame()   ;

            Console.WriteLine ( "Score: " + score ) ;
        }
    }
}