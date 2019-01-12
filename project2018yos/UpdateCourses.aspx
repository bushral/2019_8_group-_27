<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateCourses.aspx.cs" Inherits="project2018yos.UpdateCourses" %>

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
        .auto-style3 {
            width: 83%;
        }
        .auto-style4 {
            height: 20px;
            width: 428px;
        }
        .auto-style5 {
            width: 428px;
        }
    </style>
</head>
<body>
    <form id="form1" class="ss" runat="server">
        <table class="auto-style3">
            <tr>
                <td class="auto-style2">
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/AdminRoom.aspx">Back To Home Page</asp:HyperLink>
                </td>
                <td class="auto-style4">
                    <asp:Label ID="lblMsn" runat="server" Text="Label" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblIdCourse" runat="server" Text="ID_Course"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtIdCourse" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style5">
                    <asp:Button ID="btnExploreCourse" runat="server" OnClick="btnExploreCourse_Click" Text="Explore" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Panel ID="pnlUpdtaeMandatory" runat="server" Visible="False">
                        <table class="auto-style1">
                            <tr>
                                <td>
                                    <asp:DropDownList ID="DropDownList1" runat="server" Visible="False">
                                        <asp:ListItem>Yes</asp:ListItem>
                                        <asp:ListItem>No</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="lblMandatoryUpdate" runat="server" Text="Mandatory"></asp:Label>
                                </td>
                                <td>
                                    <asp:DropDownList ID="dropUpdateMandatory" runat="server" AutoPostBack="True" OnSelectedIndexChanged="dropUpdateMandatory_SelectedIndexChanged">
                                        <asp:ListItem>Yes</asp:ListItem>
                                        <asp:ListItem Value="No"></asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>
                                    <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" />
                                </td>
                            </tr>
                        </table>
                    </asp:Panel>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
