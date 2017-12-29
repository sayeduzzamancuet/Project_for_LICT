<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="Delete.aspx.cs" Inherits="Delete" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table>
        <tr>
            <td>Select University Name
            </td>
            <td>

                <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="101px" DataTextField="UniversityName" DataValueField="UniversityName" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                </asp:DropDownList>
                <%--<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnStringDb %>" SelectCommand="SELECT DISTINCT [UniversityName] FROM [Tutorial]"></asp:SqlDataSource>--%>


            </td>
        </tr>
        <tr>
            <td>Select Department Name
            </td>
            <td>

                <asp:DropDownList ID="DropDownList2" runat="server" Height="16px" Width="101px" DataTextField="Department" DataValueField="Department" AutoPostBack="True" OnSelectedDefaultChanged="DropDownList2_SelectedDefaultChanged" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                </asp:DropDownList>
                <%--<asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ConnStringDb %>" SelectCommand="SELECT DISTINCT [Department] FROM [Tutorial] WHERE ([UniversityName] = @UniversityName)">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="DropDownList1" Name="UniversityName" PropertyName="SelectedValue" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>--%>

            </td>
        </tr>
        <tr>
            <td>Select Subject Name
            </td>
            <td>

                <asp:DropDownList ID="DropDownList3" runat="server" Height="16px" Width="101px" DataTextField="Subject" DataValueField="Subject" AutoPostBack="True" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged">
                </asp:DropDownList>
                <%--<asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:ConnStringDb %>" SelectCommand="SELECT DISTINCT [Subject] FROM [Tutorial] WHERE (([UniversityName] = @UniversityName) AND ([Department] = @Department))">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="DropDownList1" Name="UniversityName" PropertyName="SelectedValue" Type="String" />
                        <asp:ControlParameter ControlID="DropDownList2" Name="Department" PropertyName="SelectedValue" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>--%>


            </td>
        </tr>
        <tr>
            <td>Select Topic
            </td>
            <td>

                <asp:DropDownList ID="DropDownList4" runat="server" Height="16px" Width="101px" DataTextField="Topic" DataValueField="Id" OnSelectedIndexChanged="DropDownList4_SelectedIndexChanged"></asp:DropDownList>
                <%--<asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:ConnStringDb %>" SelectCommand="SELECT [Id], [Topic] FROM [Tutorial] WHERE (([UniversityName] = @UniversityName) AND ([Department] = @Department) AND ([Subject] = @Subject))">
                    <SelectParameters>
                        <asp:ControlParameter ControlID="DropDownList1" Name="UniversityName" PropertyName="SelectedValue" Type="String" />
                        <asp:ControlParameter ControlID="DropDownList2" Name="Department" PropertyName="SelectedValue" Type="String" />
                        <asp:ControlParameter ControlID="DropDownList3" Name="Subject" PropertyName="SelectedValue" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>--%>



            </td>
        </tr>
        
        <tr>

            <td>

                <asp:Label ID="Label1" runat="server" Height="16px" Width="101px" Text=""></asp:Label>
                <br />

                <asp:Button ID="Button1" runat="server" Height="25px" Width="101px" Text="Delete" OnClick="Button1_Click" BackColor="#D1D1D1" ForeColor="#CC0000" />


            </td>
        </tr>

    </table>
</asp:Content>

