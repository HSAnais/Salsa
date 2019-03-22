<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Browse.aspx.cs" Inherits="salsa_pro_ui.Browse" %>

<link rel="stylesheet" href="browse.css">
<script src="homepage.js"></script>

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
    <a href="UserProfile.aspx">Profile</a>
    <br />
    <a href="About.aspx">About</a>
    <br />
    <a href="Login.aspx">Login</a>
    <br /><br />
    <%-- toggle between colours--%>
    <asp:Label runat="server">Light/Dark background</asp:Label>
    <br />
    <label class="switch">
      <input type="checkbox" >
      <span class="slider" onclick="bkgSwitch()"></span>
    </label>
</div></div>

<%-- photo of university; author: Anais Hristea (not published online) --%>
<div class="cover-photo"></div>
<%-- department name --%>
<asp:Label ID="lblDepartment" runat="server" text="Department" class="uniDep"></asp:Label>

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
    <asp:DropDownList ID="listTags" runat="server" CssClass="dropdown" AutoPostBack="True" OnSelectedIndexChanged="SelectedTag"></asp:DropDownList>
    <asp:Button ID="btnSort" runat="server" CssClass="btn" Text="Sort" OnClick="BtnSort_Click"></asp:Button>
    <br /><br />
    
    <div class="datalist">
        <asp:Label ID="lblTag" CssClass="lbl" runat="server" Text="#tagtagtag"></asp:Label>
        <br />
        <asp:DataList ID="dlTagResults"  runat="server"
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