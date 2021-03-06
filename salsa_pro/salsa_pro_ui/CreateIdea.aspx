﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateIdea.aspx.cs" Inherits="salsa_pro_ui.CreateIdea" %>

<meta name="viewport" content="width=device-width, initial-scale=1.0"> 
<link rel="stylesheet" href="createIdea.css">
<script src="homepage.js"></script>

<%-- photo of university; author: Anais Hristea (not published online) --%>
<div class="cover-photo" title="Photo of university campus"></div>
<%-- department name --%>
<asp:Label ID="lblDepartment" runat="server" text="Department" class="uniDep"></asp:Label>
<br /> <br />

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
        <asp:Label runat="server" CssClass="lbl"><h3>New idea</h3></asp:Label>

        <asp:Table ID="container" runat="server" CssClass="ideaForm" CellPadding="10">
            <asp:TableRow>
                <asp:TableCell CssClass="c1"><asp:Label ID="lblTitle" runat="server" Text="Title: "></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="txtTitle" CssClass="txt" runat="server"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:Label ID="lblTValid" Text="" runat="server" CssClass="valid" AssociatedControlID="txtTitle"></asp:Label></asp:TableCell>
            </asp:TableRow>
          <%-- select type of author --%>
            <asp:TableRow>
                <asp:TableCell CssClass="c1"><asp:Label ID="lblAuthor" runat="server" Text="Author type: "></asp:Label></asp:TableCell>
                <asp:TableCell>
                    <asp:RadioButtonList ID="authorType" runat="server" RepeatDirection="Vertical" CellPadding="5" >
                        <asp:ListItem  ID="lblAuthorName" runat="server" Text="Author name"></asp:ListItem>
                        <asp:ListItem  ID="lblAnonymous" runat="server" Text="Anonymous"></asp:ListItem>
                    </asp:RadioButtonList>
                </asp:TableCell>
                 <asp:TableCell><asp:Label ID="lblAValid" Text="" runat="server" CssClass="valid" AssociatedControlID="authorType"></asp:Label></asp:TableCell>
            </asp:TableRow>

            <%-- select tags --%>
            <asp:TableRow>
                <asp:TableCell CssClass="c1"><asp:Label ID="lblTags" runat="server" Text="Tags: "></asp:Label></asp:TableCell>
                <asp:TableCell>
                    <%-- datalist of tags? some sort of container that selects items and displays as group--%>
                    <asp:CheckBoxList ID="listTags" runat="server" RepeatDirection="Horizontal" RepeatLayout="Flow" 
                        TextAlign="Right" CssClass="listTag" Width="95%" 
                        OnSelectedIndexChanged="CL_ItemSelected">
                        <asp:ListItem>maintenance</asp:ListItem>
                        <asp:ListItem>paperwork</asp:ListItem>
                        <asp:ListItem>campus</asp:ListItem>
                        <asp:ListItem>students</asp:ListItem>
                        <asp:ListItem>course</asp:ListItem>
                        <asp:ListItem>events</asp:ListItem>
                    </asp:CheckBoxList>
                </asp:TableCell>
            </asp:TableRow>


            <asp:TableRow>
                <asp:TableCell CssClass="c1"><asp:Label ID="lblDetails" runat="server" Text="Description: "></asp:Label></asp:TableCell>
                <asp:TableCell>
                    <%-- text editor for description --%>
                    <div class="description">
                        <asp:TextBox ID="tbxDescription" TextMode="MultiLine" Columns="50" Rows="5" runat="server"></asp:TextBox>
     
                    </div>
                </asp:TableCell>
                 <asp:TableCell><asp:Label ID="lblDValid" Text="" runat="server" CssClass="valid" AssociatedControlID="tbxDescription"></asp:Label></asp:TableCell>
            </asp:TableRow>

            <%-- upload document --%>
            <asp:TableRow>
                <asp:TableCell CssClass="c1"><asp:Label ID="Label1" runat="server" Text="Upload document: "></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="tbxDocument" CssClass="txt" runat="server"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:Button ID="btnDocument" runat="server" Text="Upload" CssClass="btnDoc" OnClick="BtnDoc_Click"></asp:Button></asp:TableCell>
            </asp:TableRow>

            <asp:TableRow>
                <asp:TableCell>
                </asp:TableCell>
                <asp:TableCell>
                    <p>By submitting your idea you agree with our <a href="About.aspx">Terms & conditions</a></p>
                </asp:TableCell>
            </asp:TableRow>

                <asp:TableRow>
                <asp:TableCell CssClass="c1"><asp:Label ID="DocUpload" runat="server" Text="Upload Document: "></asp:Label></asp:TableCell>
                <asp:TableCell>
            <asp:FileUpload ID="uploadFile" CssClass="form-control-file" runat="server" />
                </asp:TableCell>
            </asp:TableRow>

            <asp:TableRow>
                <asp:TableCell CssClass="c1"></asp:TableCell>
                <asp:TableCell>
                      <asp:CheckBox ID="CheckBox1" runat="server" />
                    <asp:Label ID="Label1" runat="server" Text="Click the box to agree to Terms and Conditions: "></asp:Label>
                   
                </asp:TableCell>
            </asp:TableRow>

        </asp:Table>
        <br /><br />

        <%-- submit idea --%>
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="btn" OnClick="BtnSubmit_Click"></asp:Button>


    </form>
</body>

<footer>
    <p> Developed with ☕ by the <a href="https://github.com/HSAnais/Salsa">Salsa</a> team</p>
</footer>