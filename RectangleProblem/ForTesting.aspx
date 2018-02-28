<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ForTesting.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title></title>
  <style type="text/css">
    .auto-style1 {
      width: 100%;
    }

    .auto-style2 {
      width: 376px;
    }
  </style>
</head>
<div class="PageWrapper">
  <body>
    <form id="form1" runat="server">

      <div style="display: inline; width: 65%">
        <asp:Image ID="Image1" runat="server" />
      </div>
      <aside style="float: right; display: inline; width: 30%; margin-right: 20px">
        <div id="rectCount">
          <h2>Enter the number of rectangle to show</h2>
          <asp:TextBox ID="RectangleNumber" runat="server" placeholder="Enter the number of rectangle"></asp:TextBox>
          <button id="RectangleSubmit" onclick="submit()">Submit</button>

        </div>

        <br />
        <div>

          <h2>
            <asp:Label ID="Counter" runat="server" />
          </h2>

          <br />
          <asp:Panel runat="server" Style="display: none" ID="rectform">
          
           
                <table class="auto-style1">
                  <tr>
                    <td class="auto-style2">X:&nbsp;
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style2">Y:&nbsp;
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                  </tr>
                  <tr>
                    <td class="auto-style2">Width:&nbsp;
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style2">Height:&nbsp;
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    </td>
                  </tr>
                </table>
                <br />
                <asp:Button ID="RectangleData" Text="Next" runat="server" />
                <!--<button onclick="submitForm()" id="next" style="margin-left: 166px;">Next</button>-->
            
          </asp:Panel>

        </div>


      
      </aside>
    </form>

  </body>
  <script>
    var totalrect = '',
      counter = 1,
     arr = [],
        obj = {};
    document.getElementById('RectangleSubmit').onclick = function (e) {
      e.preventDefault();
      document.getElementById("rectCount").style.display = 'none';
      document.getElementById("rectform").style.display = 'block';
      totalrect = document.getElementById("RectangleNumber").value;
      document.getElementById("Counter").innerHTML = 'Enter data for rectangle' + counter;
    }
    function submit() {
      document.getElementById("rectCount").style.display = 'none';
      document.getElementById("rectform").style.display = 'block';
      totalrect = document.getElementById("RectangleNumber").value;
      document.getElementById("Counter").innerHTML = 'Enter data for rectangle' + counter;
    }
    function submitForm() {
      counter = counter + 1;
      if (totalrect >= counter) {
        obj.x = document.getElementById("TextBox1").value;
        obj.y = document.getElementById("TextBox2").value;
        obj.width = document.getElementById("TextBox3").value;
        obj.height = document.getElementById("TextBox4").value;
        arr.push(obj);
        document.getElementById("TextBox1").value = '';
        document.getElementById("TextBox2").value = '';
        document.getElementById("TextBox3").value = '';
        document.getElementById("TextBox4").value = '';
        if (totalrect == counter) {
          document.getElementById("next").innerHTML = 'Submit';
        }
        document.getElementById("Counter").innerHTML = 'Enter data for rectangle' + counter;
      }

    }

  </script>
</div>
</html>
