using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    public class Calculator
    {
        public int Add(int first, int second)
        {
            return PerformOperation(first, second, (a, b) => a + b);
        }

        public int Subtract(int first, int second)
        {
            return PerformOperation(first, second, (a, b) => a - b);
        }

        public int Multiply(int first, int second)
        {
            return PerformOperation(first, second, (a, b) => a * b);
        }

        public double Divide(double first, double second)
        {
            if (second == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }

            return first / second;
        }

        private T PerformOperation<T>(T first, T second, Func<T, T, T> operation)
        {
            return operation(first, second);
        }
    }
}