<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminRoom.aspx.cs" Inherits="project2018yos.AdminRoom" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="AdminRoom.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 100vw;
        }
        .auto-style2 {
            height: 34vh;
        }
        .auto-style3 {
            font-size: xx-large;
        }
        .auto-style4 {
            height: 30px;
        }
        .auto-style5 {
            height: 36px;
        }
        .auto-style6 {
            height: 36px;
            width: 8px;
        }
        .auto-style7 {
            width: 8px;
        }
        .auto-style8 {
            height: 34vh;
            width: 8px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="container2">
    
        <table class="auto-style1" style="background-image: url('Image/admin.jpg')">
            <tr>
                <td class="auto-style5"></td>
                <td class="auto-style5"></td>
                <td colspan="2" class="auto-style5"><strong>
                    <asp:Label ID="LBLAdmibRoom" runat="server" CssClass="auto-style3" Text="Admin Room" ForeColor="White"></asp:Label>
                    </strong></td>
                <td class="auto-style5"></td>
                <td class="auto-style5"></td>
                <td class="auto-style5"></td>
                <td class="auto-style6"></td>
                <td class="auto-style5"></td>
                <td class="auto-style5"></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2"></td>
                <td class="auto-style2">
                    <asp:Button ID="btnPrintCourses" runat="server" CssClass="btn" OnClick="btnPrintCourses_Click" Text="Print Courses" Width="300px" />
                    <br />
                    <asp:Button ID="btnDeleteCourse" runat="server" CssClass="btn" OnClick="btnDeleteCourse_Click" Text="Delete Course" Width="300px" />
                    <br />
                    <asp:Button ID="btnAddCourse" runat="server" CssClass="btn" OnClick="btnAddCourse_Click" Text="Add Course" Width="300px" />
                    <br />
                    <asp:Button ID="btnUpdateCourses" runat="server" CssClass="btn" OnClick="btnUpdateCourses_Click" Text="Update Courses" Width="300px" />
                    <br />
                    <asp:Button ID="btnMandCourses" runat="server" CssClass="btn" OnClick="btnMandCourses_Click" Text="Mandatory Courses" Width="300px" />
                    <br />
                    <asp:Button ID="btnHourStudent" runat="server" CssClass="btn" OnClick="btnHourStudent_Click" Text="Hours &amp; Credits Of Student" Width="300px" />
                    <br />
                    <asp:Button ID="btnPrintStudLec" runat="server" CssClass="btn" OnClick="btnPrintStudLec_Click" Text="Print Courses of student/lecture" Width="300px" />
                    <br />
                    <asp:Button ID="btnLogOutAdmin" runat="server" CssClass="btn" OnClick="btnLogOutAdmin_Click" Text="Log Out" Width="300px" />
                </td>
                <td class="auto-style2">
                    <br />
                    <br />
                    <asp:Image ID="Image1" runat="server" ImageUrl="~/Image/Admin.png" />
                </td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style2">
                    &nbsp;</td>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
                <td class="auto-style8">
                    &nbsp;</td>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style2">
                    &nbsp;</td>
                <td class="auto-style2">
                    &nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style8">
                    &nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4"></td>
                <td class="auto-style4">
                    &nbsp;</td>
                <td colspan="6" rowspan="4">
                    &nbsp;</td>
                <td class="auto-style4"></td>
                <td class="auto-style4">
                    </td>
            </tr>
            <tr>
                <td class="auto-style4"></td>
                <td class="auto-style4">
                    &nbsp;</td>
                <td class="auto-style4"></td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2"></td>
                <td class="auto-style2">
                    &nbsp;</td>
                <td class="auto-style2"></td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
