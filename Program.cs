using System;

namespace LineComparison
{
    internal class Program
    {
       static void Main(string[] args)
        {
            Comparison Compare= new Comparison();
            Compare.lineCompare(Compare.Line1(),Compare.Line2());
        }
}
}