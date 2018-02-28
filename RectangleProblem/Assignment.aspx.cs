using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Assignment : System.Web.UI.Page
{

  Bitmap myBitmap;

  public Assignment()
  {
    myBitmap = new Bitmap(840, 600);
  }


  protected void Page_Load(object sender, EventArgs e)
  {
    if (Page.IsPostBack)
    {
      int count = Convert.ToInt32(RectangleCount.Text);
      for(int i = 0; i<=count; i++)
      {
        List<MyRectangle> newRectangle = new List<MyRectangle>();
        newRectangle.Add();



      }
    }
  }


  protected void Button1_Click(object sender, EventArgs e)
  {


    Graphics myGraphics = Graphics.FromImage(myBitmap);
    myGraphics.Clear(Color.Black);
    Pen myPen = new Pen(Color.White, 2);


    if (ValueX.Text.Length > 0 && ValueY.Text.Length > 0 && ValueWidth.Text.Length > 0 &&
      ValueHeight.Text.Length > 0)
    {
      int valueX = Convert.ToInt32(ValueX.Text);
      int valueY = Convert.ToInt32(ValueY.Text);
      int valueWidth = Convert.ToInt32(ValueWidth.Text);
      int valueHeight = Convert.ToInt32(ValueHeight.Text);

      MyRectangle myRectangle = new MyRectangle(valueX, valueY, valueWidth, valueHeight);
      myRectangle.DrawRectangle(myGraphics, myPen);

      string path = Server.MapPath("~/Image/Canvas.jpg");
      myBitmap.Save(path, ImageFormat.Jpeg);
      Image1.ImageUrl = "~/Image/Canvas.jpg";
      myGraphics.Dispose();
      myBitmap.Dispose();

    }
    else
      Label1.Text = "Enter the value of all fields";
  }
}

