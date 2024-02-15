using System;
using System.Threading;

namespace Miny
{
  class Program
  {
    static void Main(string[] args)
    {
      ConsoleKeyInfo key;
      Bomb bomb = new Bomb(20, 20);
      Player player = new Player(20, 20);
      while (true)
      {
        Console.Clear();
        Console.WriteLine($"Bomb:   x={bomb.X}; y={bomb.Y}");
        Console.WriteLine($"Player: x={player.X}; y={player.Y}");
        key = Console.ReadKey(true);
        if(key.Key == ConsoleKey.UpArrow)
        {
          player.MoveUp();
        }
        else if(key.Key == ConsoleKey.DownArrow)
        {
          player.MoveDown();
        }
        else if (key.Key == ConsoleKey.RightArrow)
        {
          player.MoveRight();
        }
        else if (key.Key == ConsoleKey.LeftArrow)
        {
          player.MoveLeft();
        }
      }
    }
  }
}
