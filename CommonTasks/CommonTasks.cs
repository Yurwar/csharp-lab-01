using System;

namespace Common.Tasks
{
    public class CommonTasks
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }

        public int Product(int a, int b)
        {
            return a * b
        }

        public int Division(int a, int b)
        {
            return a / b;
        }

        public int Pow(int a, int b)
        {
            return (int) Math.Pow(a, b);
        }
    }
}
