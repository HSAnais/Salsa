<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Homepage.aspx.cs" Inherits="salsa_pro_ui.Homepage" %>

<meta name="viewport" content="width=device-width, initial-scale=1.0"> 
<link rel="stylesheet" href="homepage.css">
<script src="homepage.js"></script>

<%-- photo of university; author: Anais Hristea (not published online) --%>
<div class="cover-photo" title="Photo of university campus"></div>
<%-- department name --%>
<asp:Label ID="lblDepartment" runat="server" text="Department of Computing & Information Systems" class="uniDep"></asp:Label>

<%-- menu--%>
<div class="menu" onclick="menuClick()">
    <div class ="menuBar"></div>
    <div class ="menuBar"></div>
    <div class ="menuBar"></div>
    <br />
<div id="links" class="links">
    <br />
    <a href="Homepage.aspx">Home</a>
    <br />
    <a href="Browse.aspx">Browse ideas</a>
    <br />
    <a href="UserProfile.aspx" id="aProfile" runat="server"><asp:Label id="mProfile" Text="Profile" runat="server"></asp:Label></a>
    <br />
    <a href="About.aspx">About</a>
    <br />
    <a href="Login.aspx"><asp:Label id="mLogin" Text="Login" runat="server"></asp:Label></a>
    <br /><br />
    <%-- toggle between colours--%>
    <asp:Label runat="server">Light/Dark background</asp:Label>
    <br />
    <label class="switch">
      <input type="checkbox" >
      <span class="slider" onclick="bkgSwitch()"></span>
    </label>
</div></div>

<%-- create idea button --%>
<div class="circle-plus">
    <div class="tooltip">
        <label class="tooltiptext">Create a   new idea</label>
        <a href="CreateIdea.aspx">
            <div class="circle">
                <div class="horizontal"></div>
                <div class="vertical"></div>
            </div>
        </a>  
    </div>
</div> 

<body>
<form id="form1" runat="server">
<%--<%-- search bar
        <br /><br />
        <asp:TextBox ID="txtSearch" runat="server" CssClass="inputSearch"></asp:TextBox>
        <asp:Button ID="btnSearch" runat="server" Text="Search" CssClass="btn" OnClick="BtnSearch_Click"></asp:Button>
        <br /><br />
        <%-- tags for search
        <asp:CheckBoxList ID="listTags" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow" TextAlign="Right" CssClass="listTag" Width="30%">
            <asp:ListItem>Test_tag</asp:ListItem>
            <asp:ListItem>Test_tag1</asp:ListItem>
            <asp:ListItem>Test_tag2</asp:ListItem>
            <asp:ListItem>Test_tag3</asp:ListItem>
            <asp:ListItem>Test_tag4</asp:ListItem>
        </asp:CheckBoxList>--%>
        
        <%-- Most popular ideas / Trending ideas --%>
        <br /><br /><br />
        <div class="lbl" style="width:100px;"><asp:Label ID="lblTrending" runat="server" Text="Trending"></asp:Label></div>
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
                    <b><h3><asp:Literal ID="Literal1" runat="server" Text='<%#Eval("Title")%>'></asp:Literal></h3></b>
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
        <div class="lbl" style="width:130px;"><asp:Label ID="Label1" runat="server" Text="Most viewed"></asp:Label></div>
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
        <div class="lbl" style="width:130px;"><asp:Label ID="Label2" runat="server" Text="Latest ideas"></asp:Label></div>
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
        <div class="lbl" style="width:180px;"><asp:Label ID="Label3" runat="server" Text="Latest comments"></asp:Label></div>
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
                    <b> On: <asp:Label ID="lblComAuthor" runat="server" Text='<%#Eval("Title")%>'></asp:Label></b><br />
                        <asp:Label ID="lblComDate" runat="server" Text='<%#Eval("ComDate") %>'></asp:Label><br />
                        <asp:Label ID="lblComment" runat="server" Text='<%#Eval("ComDetail") %>'></asp:Label><br />
                    </asp:LinkButton>
                </itemtemplate>
            </asp:DataList>
        </div>
</form>
</body>

<footer>
    <p> Developed with ☕ by the <a href="https://github.com/HSAnais/Salsa">Salsa</a> team</p>
</footer>