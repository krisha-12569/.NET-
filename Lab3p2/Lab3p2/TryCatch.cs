using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3p2
{
    internal class TryCatch
    {
        public int first;
        public int second;

        public TryCatch(int first , int second)
        {
            this.first = first;
            this.second = second;
        }
        public int calculate()
        {
            try
            {
                return this.first / this.second;
            }
            catch (Exception e)
            {
                Console.WriteLine("Division by zero is not allowed.");
                return 0;
            }
        }
    }
}
