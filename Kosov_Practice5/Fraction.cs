using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kosov_Practice5
{
    class Fraction : Pair
    {
        int _rubles;
        int _copes;

        public Fraction(int firstValue, int secondValue) : base(firstValue, secondValue)
        {   
            Rubles = firstValue;
            Copes = secondValue;
        }

        public int Rubles
        {
            get { return _rubles; }
            set { _rubles = value; }
        }

        public int Copes
        {
            get { return _copes; }
            set
            {
                _copes = value;

                while(_copes > 99)
                {
                    _copes -= 100;
                    Rubles += 1;
                }

            }
        }
    }
}