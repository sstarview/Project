using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
  Bitmap myBitmap;

  public _Default()
  {
    myBitmap = new Bitmap(840, 600);
  }

  protected void Page_Load(object sender, EventArgs e)
  {
    if (!Page.IsPostBack)
    {
      drawCanvas();
    
    }
  }

  private void drawCanvas()
  {
    Graphics myGraphics = Graphics.FromImage(myBitmap);
    myGraphics.Clear(Color.Black);
    Pen myPen = new Pen(Color.White, 2);
    //myGraphics.DrawRectangle(myPen, 50, 50, 250, 200);
   /*
    int x = 20 , y = 100;
    int width = 100 , length = 200;
    Point p1 = new Point(x,y);
    Point p2 = new Point(x+width, y);
    Point p3 = new Point(x+width, y+length);
    Point p4 = new Point(x,y+length );
    myGraphics.DrawLine(myPen, p1, p2);
    myGraphics.DrawLine(myPen, p2, p3);
    myGraphics.DrawLine(myPen, p3, p4);
    myGraphics.DrawLine(myPen, p4, p1);
    */

    List<Dictionary<string,int>> myList = new List<Dictionary<string,int>>();
    Dictionary<string,int> dict = new Dictionary<string,int>();
    dict.Add("X", 20);
    dict.Add("Y", 100);
    dict.Add("width", 40);
    dict.Add("length", 200);

    myList.Add(dict);

    foreach (Dictionary<string,int> d in myList)
    {
      Rectangle rect = new Rectangle(d["X"], d["Y"], d["width"], d["length"]);
      rect.DrawRectangle(myGraphics,myPen);

    }
    //Rectangle myRect = new Rectangle(20, 100, 40, 200);
    //myRect.DrawRectangle(myGraphics, myPen);

    //Hard coded value for testing.

    Rectangle myRect1 = new Rectangle(30, 130, 10, 100);
    myRect1.DrawRectangle(myGraphics, myPen);

    Rectangle myRect2 = new Rectangle(40, 200, 200, 30);
    myRect2.DrawRectangle(myGraphics, myPen);

    string path = Server.MapPath("~/Image/Canvas.jpg");
    myBitmap.Save(path, ImageFormat.Jpeg);
    Image1.ImageUrl = "~/Image/Canvas.jpg";
    myGraphics.Dispose();
    myBitmap.Dispose();
  }



}