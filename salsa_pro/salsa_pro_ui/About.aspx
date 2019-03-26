<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="salsa_pro_ui.About" %>

<link rel="stylesheet" href="about.css">
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
    <a href="UserProfile.aspx" id="aProfile" runat="server" ><asp:Label id="mProfile" Text="Profile" runat="server"></asp:Label></a>
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

<body>
<form id="form1" runat="server">
    <div class="credits">
    <p><h3>This project is developed by</h3></p>
    <p><h4>the <a href="https://github.com/HSAnais/Salsa">Salsa</a> team</h4></p>
    <br />
    <br />
    <div>
        <p>Agata K. Gajos</p>
        <p>Lavinia N. Girihagama H Mudiyanselage</p>
        <p>Sonia A. Goodluck</p>
        <p>Stefania A. Hristea</p>
        <p>Sadia Tasnim</p>
        <p>Annapurnima Vimalkumar</p>
    </div>
        </div>
    </form>
</body>
