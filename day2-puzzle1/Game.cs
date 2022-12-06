using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2_puzzle1
{
    internal class Game
    {
        private string[] m_input     ;
        private int      m_score = 0 ;

        public Game( string[] p_input )
        {
            m_input = p_input;
        }

        public int playGame()
        {
            for ( int i = 0; i < this.m_input.Length; i++ )
            {
                string[] items = this.m_input[i].Split(' ');
                
                GameItem player   = new GameItem( items[1] ) ;
                GameItem opponent = new GameItem( items[0] ) ;

                this.m_score += this.boutScore( player, opponent ) ;
                this.m_score += player.getValue() ;
            }

            return this.m_score ;
        }

        private int boutScore( GameItem p_player, GameItem p_opponent )
        {
            int loss   = 0 ;
            int draw   = 3 ;
            int win    = 6 ;

            int result = p_player.CompareTo( p_opponent ) ;
            
            if      ( result > 0 ) return win  ;
            else if ( result < 0 ) return loss ;
            else                   return draw ;
        }

        public int getScore()
        {
            return this.m_score ;
        }
    }
}
