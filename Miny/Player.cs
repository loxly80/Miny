using System;
using System.Collections.Generic;
using System.Text;

namespace Miny
{
  public class Player
  {
    public int X { get; private set; }
    public int Y { get; private set; }

    private int limitX;
    private int limitY;

    public Player(int limitX, int limitY)
    {
      X = 0;
      Y = 0;
      this.limitX = limitX;
      this.limitY = limitY;
    }

    public void MoveUp()
    {
      if(Y < limitY)
      {
        Y++;
      }
    }

    public void MoveDown()
    {
      if (Y > 0)
      {
        Y--;
      }
    }

    public void MoveRight()
    {
      if (X < limitX)
      {
        X++;
      }
    }

    public void MoveLeft()
    {
      if (X > 0)
      {
        X--;
      }
    }
  }
}
