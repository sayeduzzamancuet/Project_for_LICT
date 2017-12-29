<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="confirmEmail.aspx.cs" Inherits="confirmEmail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
        <tr>
            <td>
                Enter PIN received in your email:
            </td>
            <td>
                <asp:TextBox ID="TextBoxPin" runat="server"></asp:TextBox>
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
                <asp:Button ID="ButtonPinConfirm" runat="server" Text="Confirm" OnClick="ButtonPinConfirm_Click" />
            </td>
        </tr>
    </table>
</asp:Content>

