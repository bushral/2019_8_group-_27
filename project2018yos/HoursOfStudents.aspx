<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HoursOfStudents.aspx.cs" Inherits="project2018yos.HoursOfStudents" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link href="AdminRoom.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 20px;
        }
    </style>
</head>
<body>
    <form id="form1" class="hcs" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/AdminRoom.aspx">Back To Home Page</asp:HyperLink>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblIdStudent" runat="server" Text="Id Student"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtIdStudent" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="BtnExplore" runat="server" OnClick="BtnExplore_Click" Text="Explore" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2" rowspan="2">
                    <asp:Panel ID="pnlHourStudents" runat="server" Visible="False">
                        <table class="auto-style1">
                            <tr>
                                <td class="auto-style2">
                                    <asp:Label ID="lblTotalHour" runat="server" Text="Total Hours:"></asp:Label>
                                    <asp:Label ID="lblTotal" runat="server" Text="Label"></asp:Label>
                                </td>
                                <td class="auto-style2"></td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="lbltt" runat="server" Text="Total Hours:"></asp:Label>
                                    <asp:Label ID="lblTotalHours" runat="server" Text="Label"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
                <td>
                    <asp:Label ID="lblmsn" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
