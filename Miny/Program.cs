using System;
using System.Threading;

namespace Miny
{
  class Program
  {
    static void Main(string[] args)
    {
      Bomb bomb = new Bomb(5, 5);

      while (true)
      {
        Console.Clear();
        Console.WriteLine($"Bomba je na souřadnicích x={bomb.X}; y={bomb.Y}");
        Thread.Sleep(500);
      }
    }
  }
}
