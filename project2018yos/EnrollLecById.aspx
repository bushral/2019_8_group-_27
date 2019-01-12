<%@ Page Title="" Language="C#" MasterPageFile="~/LectureM.Master" AutoEventWireup="true" CodeBehind="EnrollLecById.aspx.cs" Inherits="project2018yos.EnrollLecById" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 100%;
    }
</style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contentBody" runat="server">
    <table class="auto-style1">
    <tr>
        <td colspan="3">
            <asp:Label ID="lblMsn" runat="server" Text="Label" Visible="False"></asp:Label>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td colspan="3">
            <asp:GridView ID="GridViewlist" runat="server">
            </asp:GridView>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblIdCourse" runat="server" Text="IdCourse"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtIdCourse" runat="server"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td colspan="3">
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Enroll" />
        </td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>
