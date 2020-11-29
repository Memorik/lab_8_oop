using System;

namespace lab8_3
{
    class Program
    {
        static void Main(string[] args)
        {
           Child child = new Child();
           Parent parent = new Parent();
           child[0] = 'q';
           parent[0] = 123;
           foreach (var VARIABLE in child.length)
           {
               Console.WriteLine(VARIABLE);
           }
           

        }
    }
}
