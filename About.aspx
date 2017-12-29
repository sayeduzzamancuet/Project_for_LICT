<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="About.aspx.cs" Inherits="About" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <title>About this page</title>
    <style type="text/css">
        .accordion {
            width: 400px;
        }
        
        .accordionHeader {
            border: 1px solid #2F4F4F;
            color: white;
            background-color: #2E4d7B;
            font-family: Arial, Sans-Serif;
            font-size: 12px;
            font-weight: bold;
            padding: 5px;
            margin-top: 5px;
            cursor: pointer;
        }
        
        .accordionHeaderSelected {
            border: 1px solid #2F4F4F;
            color: white;
            background-color: #5078B3;
            font-family: Arial, Sans-Serif;
            font-size: 12px;
            font-weight: bold;
            padding: 5px;
            margin-top: 5px;
            cursor: pointer;
        }
        
        .accordionContent {
            background-color: #D3DEEF;
            border: 1px dashed #2F4F4F;
            border-top: none;
            padding: 5px;
            padding-top: 10px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:Accordion
        ID="Accordion1"
        CssClass="accordion"
        HeaderCssClass="accordionHeader"
        HeaderSelectedCssClass="accordionHeaderSelected"
        ContentCssClass="accordionContent"
        runat="server">
        <Panes>
            <asp:AccordionPane ID="AccordionPane1" runat="server">
                <Header>Caching</Header>
                <Content>
                   <p> Partial caching is implemented in master page</p>
                    <p>Data source caching is implemented in gridview </p>           
                </Content>
            </asp:AccordionPane>
            <asp:AccordionPane ID="AccordionPane2" runat="server">
                <Header>Ajax control toolkit</Header>
                <Content>
                   <p>Ajax control toolkit controls are used in Cascaded dropdown list and about page. In cascaded dropdown list only dropdown list value will be reloaded, rest of the page will not be refreshed</p>
                </Content>
            </asp:AccordionPane>
            <asp:AccordionPane ID="AccordionPane3" runat="server">
                <Header>Dynamic gridview</Header>
                <Content>
                   <p> Gridview is created on runtime. </p>
                </Content>
            </asp:AccordionPane>
             <asp:AccordionPane ID="AccordionPane4" runat="server">
                <Header>Session</Header>
                <Content>
                   <p>Session is implemented in user account management </p>
                </Content>
            </asp:AccordionPane>
             <asp:AccordionPane ID="AccordionPane5" runat="server">
                <Header>Send feedback Email</Header>
                <Content>
                   <p>User can send feedback email using contact form </p>
                </Content>
            </asp:AccordionPane>
             <asp:AccordionPane ID="AccordionPane6" runat="server">
                <Header>Register using email</Header>
                <Content>
                   <p>A email will be sent to user when he tries to create an account. User need to confirm that email </p>
                </Content>
            </asp:AccordionPane>
             <asp:AccordionPane ID="AccordionPane7" runat="server">
                <Header>Javascript</Header>
                <Content>
                   <p>Javascript is used to give user some popup notification</p>
                </Content>
            </asp:AccordionPane>
            <asp:AccordionPane ID="AccordionPane8" runat="server">
                <Header>Custom dll library</Header>
                <Content>
                   <p>Custom dll library is implemented to generate random 6 digit number which will be sent to user email to verify user account.</p>
                </Content>
            </asp:AccordionPane>
            <asp:AccordionPane ID="AccordionPane9" runat="server">
                <Header>LINQ</Header>
                <Content>
                   <p>LINQ is applied to retrive details of a selected item from database in details.aspx page</p>
                </Content>
            </asp:AccordionPane>
            

        </Panes>
    </asp:Accordion>
</asp:Content>

