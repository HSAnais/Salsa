﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserProfile.aspx.cs" Inherits="salsa_pro_ui.UserProfile" %>

<meta name="viewport" content="width=device-width, initial-scale=1.0"> 
<link rel="stylesheet" href="userProfile.css">
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
    </div>
</div>

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
    <asp:Label ID="lblWelcome" CssClass="welcome" runat="server" Text="Welcome, [name]!"></asp:Label><br />
    <asp:Label ID="lblLastLogin" Visible="false" CssClass="login" runat="server" Text="Your last login was: xxxxxxxx"></asp:Label>

    <%-- user account information --%>
    <div class="container">
        <div class="info">
            <b><asp:Label runat="server" Text="Email:"></asp:Label></b><br />
            <asp:Label ID="lblEmail" runat="server" Text="xxxxxxx@greenwich.ac.uk"></asp:Label><br /><br />
            <b><asp:Label runat="server" Text="Department:"></asp:Label></b><br />
            <asp:Label ID="lblDep" runat="server" Text="Computing and Maths"></asp:Label><br />
        </div>

        <%-- ideas by user --%>
        <div class="datalist">
            <asp:Label CssClass="lbli" runat="server" Text="Your ideas" ></asp:Label>
            <asp:DataList ID="dlIdeas"  runat="server"
                RepeatColumns="0" 
                CellSpacing="20" 
                RepeatDirection="Vertical"
                OnItemDataBound = "DL_ItemDataBound"
                OnItemCommand="DL_ItemCommand">

                <itemtemplate>
                    <asp:LinkButton id="SelectButton" CommandName="Select" runat="server" CssClass="selectItem" >
                        
                        <b><asp:Label ID="lblIdea" runat="server" Text='<%#Eval("Title") %>'></asp:Label></b><br />
                        <asp:Label ID="lblVotes" runat="server" Text='<%#Eval("Rating")%>'></asp:Label><b> votes</b><br />
                        <asp:Label ID="lblDetails" runat="server" Text='<%#Eval("Details") %>'></asp:Label>
                    </asp:LinkButton>
                </itemtemplate>
            </asp:DataList>
        </div>

        <%-- comments by user --%>
        <div class="datalist">
            <asp:Label CssClass="lbl" runat="server" Text="Your comments"></asp:Label>
            <asp:DataList ID="dlComments"  runat="server"
                RepeatColumns="0" 
                CellSpacing="20" 
                RepeatDirection="Vertical"
                OnItemDataBound = "DL_ItemDataBound"
                OnItemCommand="DL_ItemCommand">

                <itemtemplate>
                    <asp:LinkButton id="SelectButton" CommandName="Select" runat="server" CssClass="selectItem" >
                        <b> On: <asp:Label ID="lblComAuthor" runat="server" Text='<%#Eval("Title")%>'></asp:Label></b>
                        <asp:Label ID="lblComDate" runat="server" Text='<%#Eval("ComDate") %>'></asp:Label><br />
                        <asp:Label ID="lblComment" runat="server" Text='<%#Eval("ComDetail") %>'></asp:Label><br />
                    </asp:LinkButton>
                </itemtemplate>
            </asp:DataList>
        </div>
    </div>
</form>
</body>

<footer>
    <p> Developed with ☕ by the <a href="https://github.com/HSAnais/Salsa">Salsa</a> team</p>
</footer>