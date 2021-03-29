using System;
using static System.Console;

namespace CastingConverting
{
  class Program
  {
    static void Main(string[] args)
    {
      int a = 10;
      double b = a;
      WriteLine(b);

      double c = 9.8;
      int d = (int)c;
      WriteLine(d);
    }
  }
}
