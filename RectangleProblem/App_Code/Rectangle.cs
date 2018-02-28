using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

/// <summary>
/// Demo for testing of class.
/// </summary>
public class Rectangle
{
  private Point _p;
  private int _width;
  private int _length;

  public Rectangle(int x , int y , int width , int length) 
  {
    this._p = new Point(x, y);
    this._width = width;
    this._length = length;
  } 
 
    public void DrawRectangle(Graphics myGraphics, Pen myPen)
	{

    Point p1 = this._p;
    Point p2 = new Point(p1.X + this._width, p1.Y);
    Point p3 = new Point(p1.X + this._width, p1.Y + this._length);
    Point p4 = new Point(p1.X, p1.Y + this._length);

    myGraphics.DrawLine(myPen, p1, p2);
    myGraphics.DrawLine(myPen, p2, p3);
    myGraphics.DrawLine(myPen, p3, p4);
    myGraphics.DrawLine(myPen, p4, p1);
	}
}