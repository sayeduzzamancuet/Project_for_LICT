<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Details.aspx.cs" Inherits="Details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Panel ID="Panel1" Height="580" Width="70%" runat="server">
        <asp:PlaceHolder ID="PlaceHolder1" runat="server">
            <asp:ListView ID="ListView1" runat="server"></asp:ListView>
            <asp:GridView ID="GridView2" runat="server"></asp:GridView>
        </asp:PlaceHolder>
        
    </asp:Panel>
</asp:Content>

