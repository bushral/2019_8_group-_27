<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MandatoryCoursesAdmin.aspx.cs" Inherits="project2018yos.MandatoryCoursesAdmin" %>

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
            font-size: xx-large;
        }
    </style>
</head>
<body>
    <form id="form1" class="mc" runat="server">
        <table class="auto-style1">
            <tr>
                <td>
                    <p>
                        <strong>
                    <asp:Label ID="lblmsn" runat="server" Text="Label" CssClass="auto-style2" Visible="False" ForeColor="#FF6600"></asp:Label>
                        </strong>
                    </p>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/AdminRoom.aspx">Home Page</asp:HyperLink>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td colspan="4">
                    <table class="auto-style1">
                        <tr>
                            <td>
                                <asp:Label ID="lblDepartment" runat="server" Text="Department" ForeColor="White"></asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="DropDownDepartment" runat="server" AutoPostBack="True">
                                    <asp:ListItem>Software</asp:ListItem>
                                    <asp:ListItem>Structual</asp:ListItem>
                                    <asp:ListItem>Mechanical</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td>
                                <asp:Label ID="lblYear" runat="server" Text="Year" ForeColor="White"></asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="DropDownYear" runat="server" AutoPostBack="True">
                                    <asp:ListItem>1</asp:ListItem>
                                    <asp:ListItem>2</asp:ListItem>
                                    <asp:ListItem>3</asp:ListItem>
                                    <asp:ListItem>4</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td>
                                <asp:Label ID="lblSemster" runat="server" Text="Semster" ForeColor="White"></asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="DropDownSemster" runat="server" AutoPostBack="True">
                                    <asp:ListItem>1</asp:ListItem>
                                    <asp:ListItem>2</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td>
                                <asp:Label ID="lblMandatory" runat="server" Text="Mandatory" ForeColor="White"></asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="DropDownMandatory" runat="server" AutoPostBack="True">
                                    <asp:ListItem>Yes</asp:ListItem>
                                    <asp:ListItem>No</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                            <td>
                                <asp:Button ID="btnGo" CssClass="btn" runat="server" OnClick="btnGo_Click" Text="Go" />
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:GridView ID="GridViewPrint" runat="server" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal">
                        <FooterStyle BackColor="White" ForeColor="#333333" />
                        <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="White" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#F7F7F7" />
                        <SortedAscendingHeaderStyle BackColor="#487575" />
                        <SortedDescendingCellStyle BackColor="#E5E5E5" />
                        <SortedDescendingHeaderStyle BackColor="#275353" />
                    </asp:GridView>
                </td>
                <td>&nbsp;</td>
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
    <div>
    
    </div>
    </form>
</body>
</html>
