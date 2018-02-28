<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Assignment.aspx.cs" Inherits="Assignment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title></title>
  <style type="text/css">
    .auto-style1 {
      width: 100%;
    }

    .auto-style2 {
    }

    .auto-style3 {
      width: 186px;
    }
  </style>
</head>
<body>
  <form id="form1" runat="server">
    <div id="PageWrapper">
      <section id="ImageSection">
        <asp:Image ID="Image1" runat="server" EnableViewState="True" />
      </section>
      <aside id="Sidebar" style="float: left">
        
        <h3>Enter the number of rectangle.</h3>
        <asp:TextBox ID="RectangleCount" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <br />

        <table class="auto-style1">
          <tr>
            <td class="auto-style3">X :
            <asp:TextBox ID="ValueX" runat="server"></asp:TextBox>
            </td>
            <td>Y :
              <asp:TextBox ID="ValueY" runat="server"></asp:TextBox>
            </td>
          </tr>
          <tr>
            <td class="auto-style3">Width :
            <asp:TextBox ID="ValueWidth" runat="server"></asp:TextBox>
            </td>
            <td>Height :
              <asp:TextBox ID="ValueHeight" runat="server"></asp:TextBox>
            </td>
          </tr>
          <tr>
            <td class="auto-style2" colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
            </td>
          </tr>
        </table>

      </aside>
    </div>
  </form>
</body>
</html>
