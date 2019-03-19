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

<body>
<form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
