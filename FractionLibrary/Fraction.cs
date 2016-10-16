using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionLibrary
{
    /// <summary>
    /// This is my fun project. In this library I want realize work with fractials
    /// </summary>
    public class Fractial
    {
        int numerator;
        int denominator;

        private static int LowestCommonMultiple(int firstValue,int secondValue)
        {
            int big, low;
            if(firstValue>secondValue)
            {
                big = firstValue;
                low = secondValue;
            }
            else
            {
                big = secondValue;
                low = firstValue;
            }

            int lcm=big;
            while(true)
            {
                if( lcm % big == 0 && lcm % low == 0 )
                { return lcm; }
                lcm++;
            }         
        }

        public int Denominator
        {
            get
            {
                return denominator;
            }
            set
            {
                if( value != 0 )
                    denominator = value;
                else
                    throw new ArgumentException("Denominator cannot be zero!");
            }
        }

        public Fractial(int _numer,int _denom)
        {
            numerator = _numer;
            denominator = _denom;
        }

        public string GetDoubleValue()
        {
            return ( (double)numerator / denominator ).ToString();
        }
        /// <summary>
        /// Return new fractial value
        /// </summary>
        /// <param name="addingValue"></param>
        /// <returns></returns>
        public Fractial Sum(Fractial addingValue)
        {
            if( denominator == addingValue.denominator )
                return new Fractial(( numerator + addingValue.numerator ) , denominator);
            //TODO: STOPPER
            return null;

        }
    }
}
