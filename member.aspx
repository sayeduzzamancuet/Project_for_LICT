<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="member.aspx.cs" Inherits="member" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <asp:Panel ID="Panel1" runat="server" Height="703px" BorderColor="#009933" Style="margin-left: 0px">
        <center>
        <table border="0">
            <tr>
                <td>
                    Email
                </td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Width="179px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Password
                </td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" Width="179px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>

                </td>
                <td>
                    <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    
                    
                </td>
                <td>
                    <asp:Button ID="Button1" runat="server" BorderStyle="Solid" OnClick="Button1_Click" Text="Create Account" Width="98px" />
                    <asp:Button ID="Button2" runat="server" BorderStyle="Solid" OnClick="Button2_Click" Text="Login" Width="82px" />
                </td>
            </tr>
        </table>
            </center>


    </asp:Panel>

</asp:Content>

