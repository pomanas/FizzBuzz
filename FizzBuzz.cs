using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzPlay
{
    class FizzBuzz
    {
        private string _result;

        public FizzBuzz(string defaultResult)
        {
            _result = defaultResult;
        }
        public string GetStatus(int value)
        {
            var modulo3 = value % 3;
            var modulo5 = value % 5;
            if (modulo3 == 0 && modulo5 == 0 )
            {
                _result = "FizzBuzz";
            }
            else if (modulo3 == 0)
            {
                _result = "Fizz";
            }
            else if (modulo5 == 0)
            {
                _result = "Buzz";

            }
            else
            {
                _result = value.ToString();
            }

            return _result;
        }
    }
}
