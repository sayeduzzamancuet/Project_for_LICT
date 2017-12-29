<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="create.aspx.cs" Inherits="create" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <asp:Panel ID="Panel1" runat="server" ForeColor="Black" Height="699px" BorderColor="#009900">
        <center>
            <table>
            <tr>
                <td>
                    Email
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" required="" BorderColor="#00CC00" Width="146px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Ente Password
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" required="" BorderColor="#009900" Width="146px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Confire Password
                </td>
                <td>
                     <asp:TextBox ID="TextBox3" runat="server" required="" BorderColor="#009900" Width="144px"></asp:TextBox>
                </td>
            </tr>
                <tr>
                    <td>

                    </td>
                    <td>
                        <asp:Label ID="Label1" runat="server" ForeColor="#CC0000"></asp:Label>
                    </td>
                </tr>
            <tr>
                <td>
                    
                </td>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Create Account" Width="153px" BorderColor="#009900" />
                </td>
            </tr>
        </table>
           </center>

    </asp:Panel>

</asp:Content>

