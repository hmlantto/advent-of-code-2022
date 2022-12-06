using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2_puzzle1
{
    internal class GameItem : IComparable< GameItem >
    {
        private string  m_name = "" ;
        private int     m_value     ;

        public GameItem( string p_nameCode )
        {
            this.setValues( p_nameCode ) ;
        }

        private void setValues( string p_code )
        {
            if ( p_code.Equals( "A" ) || p_code.Equals( "X" ) )
            {
                this.m_name  = "rock" ;
                this.m_value = 1      ;
            }

            if ( p_code.Equals( "B" ) || p_code.Equals( "Y" ) )
            {
                this.m_name  = "paper" ;
                this.m_value = 2       ;
            }

            if ( p_code.Equals( "C" ) || p_code.Equals( "Z" ) )
            {
                this.m_name  = "scissors" ;
                this.m_value = 3          ;
            }
        }

        public int CompareTo( GameItem? other )
        {
            if ( other == null ) return 1;

            if ( this.m_name.Equals( other.getName() ) ) return 0 ;

            if ( this.m_name.Equals( "rock"     ) && other.getName().Equals( "paper"    ) ) return -1 ;
            if ( this.m_name.Equals( "rock"     ) && other.getName().Equals( "scissors" ) ) return  1 ;
            if ( this.m_name.Equals( "paper"    ) && other.getName().Equals( "rock"     ) ) return  1 ;
            if ( this.m_name.Equals( "paper"    ) && other.getName().Equals( "scissors" ) ) return -1 ;
            if ( this.m_name.Equals( "scissors" ) && other.getName().Equals( "rock"     ) ) return -1 ;
            if ( this.m_name.Equals( "scissors" ) && other.getName().Equals( "paper"    ) ) return  1 ;

            // We should never get here, but just in case.
            return 0 ;
        }

        public string getName()  { return this.m_name;  }
        public int    getValue() { return this.m_value; }
    }
}
