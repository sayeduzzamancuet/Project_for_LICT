<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Contact.aspx.cs" Inherits="Contact" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 684px;
        }
        .auto-style2 {
            height: 72px;
        }
        .auto-style3 {
            width: 451px;
            height: 72px;
        }
        .auto-style4 {
            width: 451px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Panel ID="Panel1" Height="859px" Width="105%" runat="server">
        <div id="content">
            <!-- insert the page content here -->
            <h1>Contact Us</h1>
            <p>
                Below is an example of how a contact form might look with this template:
            </p>

            <div>
                <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>
                <table style="background-position: center center; border: thick solid #009933; width: 600px; height: 550px; position: relative; z-index: auto; table-layout: fixed; border-collapse: collapse; background-color: #FFFFFF;">
                    <tr>
                        <td>Name
                        </td>
                        <td >
                            <asp:TextBox ID="nameTextBox" runat="server" required=""></asp:TextBox>
                        </td>
                    </tr>

                    <tr>
                        <td>Email Address
                        </td>
                        <td>
                            <asp:TextBox ID="emailTextBox" TextMode="Email" runat="server" required=""></asp:TextBox>
                        </td>
                    </tr>

                    <tr>
                        <td>Subject
                        </td>
                        <td>
                            <asp:TextBox ID="subjectTextBox" runat="server" required=""></asp:TextBox>
                        </td>
                    </tr>

                    <tr>
                        <td>Message </td>
                        <td>
                            <asp:TextBox ID="MessageTextBox" TextMode="MultiLine" runat="server" required="" Height="139px" Width="288px"></asp:TextBox><br />
                            <asp:HtmlEditorExtender ID="HtmlEditorExtender1" runat="server" TargetControlID="MessageTextBox"></asp:HtmlEditorExtender>
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />
                            <br />

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <br />
                            <br />
                            <br />
                        </td>

                        <td>
                            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Send" />
                        </td>

                    </tr>
                </table>
            </div>
        </div>

    </asp:Panel>
</asp:Content>

