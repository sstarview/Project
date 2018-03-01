using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for MyRectangle
/// </summary>
/// Setting the property of the rectangle
public class MyRectangle
{
  public int XValue { get; set; }
  public int YValue { get; set; }
  public int WidthValue { get; set; }
  public int HeightValue { get; set; }

  //Construstor for the rectangle

  public MyRectangle(int xValue, int yValue, int widthValue, int heightValue)
  {
    this.XValue = xValue;
    this.YValue = yValue;
    this.WidthValue = widthValue;
    this.HeightValue = heightValue;
  }

  //method for rectangle drawing

  public void DrawRectangle(Graphics myGraphics, Pen myPen)
  {
    Point p1 = new Point(XValue, YValue);
    Point p2 = new Point(XValue + this.WidthValue, YValue);
    Point p3 = new Point(XValue + this.WidthValue, YValue + this.HeightValue);
    Point p4 = new Point(XValue, YValue + this.HeightValue);

    myGraphics.DrawLine(myPen, p1, p2);
    myGraphics.DrawLine(myPen, p2, p3);
    myGraphics.DrawLine(myPen, p3, p4);
    myGraphics.DrawLine(myPen, p4, p1);
  }

  public bool Intersection(MyRectangle rec1, MyRectangle rec2)
  {
    if (rec1.XValue + rec1.WidthValue < rec2.XValue || rec2.XValue + rec2.WidthValue < rec1.XValue ||
      rec1.YValue + rec1.HeightValue < rec2.YValue || rec2.YValue + rec2.HeightValue < rec1.YValue)
    {

      return false;
    }
    else
      return true;
  }
}