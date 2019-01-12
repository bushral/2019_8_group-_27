<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="project2018yos.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LogIn</title>
    <link href="Style.css" rel="stylesheet" />
    <style>
        @import url('https://fonts.googleapis.com/family=Bitter|Crete+Round|Pacifico');

    </style>

</head>
<body>
    <form id="form1" runat="server">
  <section>
      <div class="container">
          <div class="inner1">
             <span>Log In As:</span><br />
             <br /> <asp:Button ID="btnLogAsAdmin" runat="server" CssClass="btn" Text="Log In Admin" OnClick="btnLogAsAdmin_Click"/>
              <br /><asp:Button ID="btnLogAsLecture" runat="server" CssClass="btn" Text="Log In Lecture" OnClick="btnLogAsLecture_Click" />
              <br /><asp:Button ID="btnLogAsStudent" runat="server" CssClass="btn" Text="Log In Student" OnClick="btnLogAsStudent_Click "/>
               
          </div>
          <div class="inner2">
                 <h3>Log In</h3>
                <asp:TextBox ID="txtUserName" placeholder="Username" runat="server"></asp:TextBox>
                <asp:TextBox ID="txtID" placeholder="ID" runat="server"></asp:TextBox>
        
              <asp:Label ID="lblMSN" runat="server" Text="Label"></asp:Label>
          </div>

      </div>
  </section>
    </form>
</body>
</html>
