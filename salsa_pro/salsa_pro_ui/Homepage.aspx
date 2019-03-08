<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="salsa_pro_ui.Homepage" %>

<link rel="stylesheet" href="homepage.css">

<%-- photo of university; author: Anais Hristea (not published online) --%>
<div class="cover-photo"></div>
<%-- department name --%>
<asp:Label ID="lblDepartment" runat="server" text="Department" class="uniDep"></asp:Label>

<body>
<form id="form1" runat="server">
<%-- search bar --%>
        <br /><br />
        <asp:TextBox ID="txtSearch" runat="server" CssClass="inputSearch"></asp:TextBox>
        <asp:Button ID="btnSearch" runat="server" Text="Search" CssClass="btn" OnClick="BtnSearch_Click"></asp:Button>
        <br /><br />
        <%-- tags for search --%>
        <asp:CheckBoxList ID="listTags" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow" TextAlign="Right" CssClass="listTag" Width="30%">
            <asp:ListItem>Test_tag</asp:ListItem>
            <asp:ListItem>Test_tag1</asp:ListItem>
            <asp:ListItem>Test_tag2</asp:ListItem>
            <asp:ListItem>Test_tag3</asp:ListItem>
            <asp:ListItem>Test_tag4</asp:ListItem>
        </asp:CheckBoxList>
        
        <%-- Most popular ideas / Trending ideas --%>
        <br /><br /><br />
        <div class="lbl" style="margin-right:69%;"><asp:Label ID="lblTrending" runat="server" Text="Trending"></asp:Label></div>
        <div class="lbl"></div>
        <div class="datalist">
            <asp:DataList ID="dlTrending"  runat="server"
                RepeatColumns="0" 
                CellSpacing="20" 
                RepeatDirection="Horizontal"
                OnItemDataBound = "DL_ItemDataBound"
                OnItemCommand="DL_ItemCommand">

                <itemtemplate>
                    <asp:LinkButton id="SelectButton" CommandName="Select" runat="server" CssClass="selectItem" >
                    <b><asp:Literal ID="Literal1" runat="server" Text='<%#Eval("Title")%>'></asp:Literal></b>
                    <br />
                    <b>Proposed by: </b><asp:Literal ID="Literal2" runat="server" Text='<%#Eval("Author") %>'></asp:Literal>
                    <br />
                    <b>Submitted on: </b><asp:Literal ID="Literal3" runat="server" Text='<%#Eval("Date") %>'></asp:Literal>
                    <br />
                    <b>Votes: </b><asp:Literal ID="Literal4" runat="server" Text='<%#Eval("Rating") %>'></asp:Literal>
                    <br />
                    <asp:Literal ID="Literal5" runat="server" Text='<%#Eval("Details") %>'></asp:Literal>
                    </asp:LinkButton>
                </itemtemplate>
            </asp:DataList>
        </div>

        <%-- Most viewed ideas --%>
        <br /><br /><br />
        <div class="lbl" style="margin-right:69%;"><asp:Label ID="Label1" runat="server" Text="Most viewed"></asp:Label></div>
        <div class="lbl"></div>
        <div class="datalist">
            <asp:DataList ID="dlMostViewed"  runat="server"
                RepeatColumns="0" 
                CellSpacing="20" 
                RepeatDirection="Horizontal"
                OnItemDataBound = "DL_ItemDataBound"
                OnItemCommand="DL_ItemCommand">

                <itemtemplate>
                    <asp:LinkButton id="SelectButton" CommandName="Select" runat="server" CssClass="selectItem" >
                    <b><asp:Literal ID="Literal1" runat="server" Text='<%#Eval("Title")%>'></asp:Literal></b>
                    <br />
                    <b>Proposed by: </b><asp:Literal ID="Literal2" runat="server" Text='<%#Eval("Author") %>'></asp:Literal>
                    <br />
                    <b>Submitted on: </b><asp:Literal ID="Literal3" runat="server" Text='<%#Eval("Date") %>'></asp:Literal>
                    <br />
                    <b>Votes: </b><asp:Literal ID="Literal4" runat="server" Text='<%#Eval("Rating") %>'></asp:Literal>
                    <br />
                    <asp:Literal ID="Literal5" runat="server" Text='<%#Eval("Details") %>'></asp:Literal>
                    </asp:LinkButton>
                </itemtemplate>
            </asp:DataList>
        </div>

        <%-- Latest ideas --%>
        <br /><br /><br />
        <div class="lbl" style="margin-right:69%;"><asp:Label ID="Label2" runat="server" Text="Latest ideas"></asp:Label></div>
        <div class="lbl"></div>
        <div class="datalist">
            <asp:DataList ID="dlLastIdeas"  runat="server"
                RepeatColumns="0" 
                CellSpacing="20" 
                RepeatDirection="Horizontal"
                OnItemDataBound = "DL_ItemDataBound"
                OnItemCommand="DL_ItemCommand">

                <itemtemplate>
                    <asp:LinkButton id="SelectButton" CommandName="Select" runat="server" CssClass="selectItem" >
                    <b><asp:Literal ID="Literal1" runat="server" Text='<%#Eval("Title")%>'></asp:Literal></b>
                    <br />
                    <b>Proposed by: </b><asp:Literal ID="Literal2" runat="server" Text='<%#Eval("Author") %>'></asp:Literal>
                    <br />
                    <b>Submitted on: </b><asp:Literal ID="Literal3" runat="server" Text='<%#Eval("Date") %>'></asp:Literal>
                    <br />
                    <b>Votes: </b><asp:Literal ID="Literal4" runat="server" Text='<%#Eval("Rating") %>'></asp:Literal>
                    <br />
                    <asp:Literal ID="Literal5" runat="server" Text='<%#Eval("Details") %>'></asp:Literal>
                    </asp:LinkButton>
                </itemtemplate>
            </asp:DataList>
        </div>

        <%-- Latest comments --%>
        <br /><br /><br />
        <div class="lbl" style="margin-right:69%;"><asp:Label ID="Label3" runat="server" Text="Latest comments"></asp:Label></div>
        <div class="lbl"></div>
        <div class="datalist">
            <asp:DataList ID="dlLastComs"  runat="server"
                RepeatColumns="0" 
                CellSpacing="20" 
                RepeatDirection="Horizontal"
                OnItemDataBound = "DL_ItemDataBound"
                OnItemCommand="DL_ItemCommand">

                <itemtemplate>
                    <asp:LinkButton id="SelectButton" CommandName="Select" runat="server" CssClass="selectItem" >
                    <b><asp:Literal ID="Literal1" runat="server" Text='<%#Eval("Title")%>'></asp:Literal></b>
                    <br />
                    <b>Proposed by: </b><asp:Literal ID="Literal2" runat="server" Text='<%#Eval("Author") %>'></asp:Literal>
                    <br />
                    <b>Submitted on: </b><asp:Literal ID="Literal3" runat="server" Text='<%#Eval("Date") %>'></asp:Literal>
                    <br />
                    <b>Votes: </b><asp:Literal ID="Literal4" runat="server" Text='<%#Eval("Rating") %>'></asp:Literal>
                    <br />
                    <asp:Literal ID="Literal5" runat="server" Text='<%#Eval("Details") %>'></asp:Literal>
                    </asp:LinkButton>
                </itemtemplate>
            </asp:DataList>
        </div>
</form>
</body>

<footer>
    <p> Developed with ☕ by the <a href="https://github.com/HSAnais/Salsa">Salsa</a> team</p>
</footer>