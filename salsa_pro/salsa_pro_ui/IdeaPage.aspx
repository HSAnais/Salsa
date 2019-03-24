<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IdeaPage.aspx.cs" Inherits="salsa_pro_ui.IdeaPage" %>

<meta name="viewport" content="width=device-width, initial-scale=1.0"> 
<link rel="stylesheet" href="ideaPage.css">
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
<br /> <br /> <br />

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
        <br /> <br />
        <span onclick="authorClick()">
            <div id="options">
                <asp:RadioButtonList ID="rbAuthor" runat="server" TextAlign="Left" >
                    <asp:ListItem>hide/unhide</asp:ListItem>
                    <asp:ListItem>block/unblock</asp:ListItem>
                </asp:RadioButtonList>
            </div>
        <asp:Label ID="lblAuthor" CssClass="lbl" runat="server" Text="Author name"></asp:Label> <%--OnClick="authorClick()"--%>
        
        <script>
            function authorClick() {
                var links = document.getElementById("options");
                if (links.style.display === "block")
                    links.style.display = "none";
                else
                    links.style.display = "inline-block";
            }
        </script>
        </span>

        <asp:Label ID="lblDate" CssClass="lbl" runat="server" Text="Date of submission"></asp:Label>

        <br /> <br />
        <asp:Label ID="lblTitle" CssClass="lblT" runat="server" Text="Title of idea"></asp:Label>
        <br />
        
        <div class="container">
        <asp:Label ID="lblDetails" CssClass="lblD" runat="server" Text="Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed ut placerat urna. Curabitur id enim scelerisque elit vehicula mattis. Quisque dignissim vel magna at luctus. Nulla vestibulum purus at purus fringilla, nec aliquam enim pellentesque. Ut pellentesque elementum consequat. Curabitur tristique tempus posuere. Nam faucibus metus felis, nec cursus quam dapibus varius. Integer tellus libero, molestie at condimentum at, consequat nec nunc. Nulla et justo id mi congue sollicitudin."></asp:Label>
        <div class="votes">
            <div class="voteUp" id="upArrow" onclick="voteUp_Click"></div> 
            <br />
            <asp:Label ID="lblVotes" CssClass="lblV" runat="server" Text="XX"></asp:Label> 
            <br /> <br />
            <div class="voteDown" id="downArrow" onclick="voteDown_Click"></div>   
        </div>
        </div>

        <%-- text editor for new comment --%>
        <div class="comment">
            <asp:TextBox ID="tbxComment" TextMode="MultiLine" Columns="50" Rows="5" runat="server"></asp:TextBox>
        </div>
        <%-- submit comment --%>
            <asp:Button ID="btnComment" runat="server" Text="Add comment" CssClass="btn" OnClick="BtnCom_Click"></asp:Button>

        <br /><br />
        <%-- Comments --%>
         <div class="datalist">
            <asp:DataList ID="dlComments"  runat="server"
                RepeatColumns="0" 
                CellSpacing="20" 
                RepeatDirection="Vertical"
                OnItemDataBound = "DL_ItemDataBound">

                <itemtemplate>
                    <b><asp:Literal ID="Literal1" runat="server" Text='<%#Eval("Author") %>'></asp:Literal></b>
                    <b><asp:Literal ID="Literal2" runat="server" Text='<%#Eval("Date") %>'></asp:Literal></b>
                    <br />
                    <asp:Literal ID="Literal3" runat="server" Text='<%#Eval("Details") %>'></asp:Literal>
                    <br /><br /><br />               
                </itemtemplate>
            </asp:DataList>
        </div>

    </form>
</body>    

<footer>
    <p> Developed with ☕ by the <a href="https://github.com/HSAnais/Salsa">Salsa</a> team</p>
</footer>