using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace Miny
{
  public class Bomb
  {
    public int X { get; private set; }
    public int Y { get; private set; }
    public int Timeout { get; private set; }

    private int limitX;
    private int limitY;
    private Random random;
    private Timer timer;

    public Bomb(int limitX, int limitY)
    {
      this.limitX = limitX;
      this.limitY = limitY;
      random = new Random();
      X = random.Next(0, limitX);
      Y = random.Next(0, limitY);
      Timeout = Math.Max(limitX, limitY) * 1000;
      timer = new Timer();
      timer.Interval = Timeout;
      timer.Elapsed += Timer_Elapsed;
      timer.Start();
    }

    private void Timer_Elapsed(object sender, ElapsedEventArgs e)
    {
      X = random.Next(0, limitX);
      Y = random.Next(0, limitY);
    }
  }
}
