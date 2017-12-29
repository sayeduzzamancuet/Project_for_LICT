<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="insert_tutorial.aspx.cs" Inherits="Admin_insert_tutorial" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table>
        <tr>
            <td>Select University Name
            </td>
            <td>

                <asp:DropDownList ID="DropDownList1" runat="server" DataTextField="UniversityName" DataValueField="UniversityName" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Height="16px" Width="101px">
                </asp:DropDownList>

                <%--<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnStringDb %>" SelectCommand="SELECT DISTINCT [UniversityName] FROM [Tutorial]"></asp:SqlDataSource>--%>


            </td>
        </tr>
        <tr>
            <td>Select Department Name
            </td>
            <td>

                <asp:DropDownList ID="DropDownList2" runat="server" DataTextField="Department" DataValueField="Department" AutoPostBack="True" OnSelectedDefaultChanged="DropDownList2_SelectedDefaultChanged" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" Height="16px" Width="101px">
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

                <asp:DropDownList ID="DropDownList3" runat="server" DataTextField="Subject" DataValueField="Subject" AutoPostBack="True" Height="16px" Width="101px">
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
            <td>Insert Topic
            </td>
            <td>

                <asp:TextBox ID="TextBoxTopic" required="" runat="server" Height="16px" Width="101px"></asp:TextBox>


            </td>
        </tr>
        <tr>
            <td>Topic description
            </td>
            <td>

                <asp:TextBox ID="TextBoxDescription" required="" runat="server" Height="16px" Width="101px"></asp:TextBox>


            </td>
        </tr>
        <tr>
            <td>Insert Link
            </td>

            <td>

                <asp:TextBox ID="TextBox1" required="" runat="server" Height="16px" Width="101px"></asp:TextBox>


            </td>
        </tr>
        <tr>

            <td>

                <asp:Label ID="Label1" runat="server" Text="" Height="16px" Width="101px"></asp:Label>
                <br />

                <asp:Button ID="Button1" runat="server" Text="Insert" OnClick="Button1_Click" Height="16px" Width="101px"/>


            </td>
        </tr>

    </table>
</asp:Content>

