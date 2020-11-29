using System;

namespace lab8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateChecker checker = new DateChecker();
            checker["day"] = 13;
            checker["month"] = 5;
            checker["year"] = 20;
            Console.WriteLine(checker.Check(16, 4, 20));
        }
    }
}
