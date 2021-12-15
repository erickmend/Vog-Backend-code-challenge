using System;
using System.Collections.Generic;
using System.Text;

namespace TestModule
{
    public  class Logic
    {
        public int Multiplicate ( int number, int multiple)
        {
            return number * multiple;
        }
        public void IsValid(int value)
        {
            if (value < 1)
                throw new Exception("Only numbers greater than 1.");
        }
        public string ToUpperCase(string word)
        {
            return word.ToUpper();
        }
        public object IsEqual(object something)
        {
            return something;
        }
    }
}
