using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kosov_Practice5
{
    class Pair
    {
        private int _firstValue;
        private int _secondValue;

        public Pair(int firstValue, int secondValue)
        {
            _firstValue = firstValue;
            _secondValue = secondValue;
        }

        public int FirstValue
        {
            get => _firstValue;
            set
            {
                _firstValue = value;
            }
        }

        public int SecondValue
        {
            get => _secondValue;
            set
            {
                _secondValue = value;
            }
        }

        public static bool PairCompare(Pair ParaOne, Pair ParaTwo)
        {
            if (ParaOne.FirstValue > ParaTwo.FirstValue)
                return true;
            else
               if (ParaOne.FirstValue == ParaTwo.FirstValue && ParaOne.SecondValue > ParaTwo.SecondValue)
                return true;
            else
                return false;
        }

        public void SetParams(int value)
        {
            FirstValue = value;
            SecondValue = value;
        }

        public void SetParams(int FValue, int SValue)
        {
            FirstValue = FValue;
            SecondValue = SValue;
        }

        public static bool operator >(Pair First, Pair Second)
        {
            if (First.FirstValue + First.SecondValue > Second.FirstValue + Second.SecondValue)
                return true;
            else
                return false;
        }  
        
        public static bool operator <(Pair First, Pair Second)
        {
            if (First.FirstValue + First.SecondValue < Second.FirstValue + Second.SecondValue)
                return true;
            else
                return false;
        }
    }
}