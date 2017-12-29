<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="member_home.aspx.cs" Inherits="member_home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


    <asp:Panel ID="Panel1" runat="server" Height="704px">
    <br />
    Welcome
    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    <br />
    <asp:Button ID="Button1" runat="server" Text="Change Password" OnClick="Button1_Click" />
    &nbsp;&nbsp;
    <asp:Button ID="Button2" runat="server" Text="Logout" OnClick="Button2_Click" />
</asp:Panel>


</asp:Content>

