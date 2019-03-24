<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="salsa_pro_ui.Login" %>

<link rel="stylesheet" href="login.css">
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
<br /><br /><br />

<body>
<form id="form1" runat="server">
        <asp:Table ID="container" runat="server" CssClass="loginForm" CellPadding="10">
            <%--Username--%>
            <asp:TableRow>
                <asp:TableCell CssClass="c1"><asp:Label ID="lblUsername" runat="server" Text="Username: "></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="txtUsername" CssClass="txt" runat="server"></asp:TextBox></asp:TableCell>
            </asp:TableRow>

            <%--Password--%>
            <asp:TableRow>
                <asp:TableCell CssClass="c1"><asp:Label ID="lblPassword" runat="server" Text="Password: "></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="txtPassword" CssClass="txt" runat="server"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    <br />

    <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="btn" OnClick="BtnLogin_Click"></asp:Button>
    </form>
</body>

<footer>
    <p> Developed with ☕ by the <a href="https://github.com/HSAnais/Salsa">Salsa</a> team</p>
</footer>