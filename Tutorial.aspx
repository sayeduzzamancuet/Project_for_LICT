<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Tutorial.aspx.cs" Inherits="Tutorial" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div id="content">
        <!-- insert the page content here -->
        <h1>Available tutorials</h1>

        <div>
            <asp:Panel ID="Panel1" runat="server" Height="580" Width="90%">
                <div>

                    <asp:ScriptManager ID="scriptmanager1" runat="server"></asp:ScriptManager>
                    <%--<asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server"></asp:ScriptManagerProxy>--%>
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>
                            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" BackColor="#339966" Font-Bold="true" ForeColor="#000000" Height="25px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="100px">
                            </asp:DropDownList><asp:HiddenField ID="HiddenField1" runat="server" />
                            <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="true" BackColor="#339966" Font-Bold="true" ForeColor="#000000" Height="25px" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" Width="100px">
                            </asp:DropDownList><asp:HiddenField ID="HiddenField2" runat="server" />
                            <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="true" BackColor="#339966" Font-Bold="true" ForeColor="#000000" Height="25px" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged" Width="100px">
                            </asp:DropDownList><asp:HiddenField ID="HiddenField3" runat="server" />
                            <br />
                            <br />
                            <br />
                            <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical" Width="400px" AllowPaging="True" OnPageIndexChanging="GridView1_PageIndexChanging1" PageIndex="0">
                                <AlternatingRowStyle BackColor="White" />
                                <FooterStyle BackColor="#CCCC99" />
                                <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
                                <PagerSettings NextPageText="vcbncvncn" />
                                <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
                                <RowStyle BackColor="#F7F7DE" />
                                <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
                                <SortedAscendingCellStyle BackColor="#FBFBF2" />
                                <SortedAscendingHeaderStyle BackColor="#848384" />
                                <SortedDescendingCellStyle BackColor="#EAEAD3" />
                                <SortedDescendingHeaderStyle BackColor="#575357" />
                            </asp:GridView>
                        </ContentTemplate>
                    </asp:UpdatePanel>

                </div>
            </asp:Panel>
        </div>
    </div>
</asp:Content>

