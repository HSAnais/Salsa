<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateIdea.aspx.cs" Inherits="salsa_pro_ui.CreateIdea" %>

<link rel="stylesheet" href="createIdea.css">

<%-- photo of university; author: Anais Hristea (not published online) --%>
<div class="cover-photo"></div>

<%-- department name --%>
<asp:Label ID="lblDepartment" runat="server" text="Department" class="uniDep"></asp:Label>
<br /> <br /> <br />

<body>
    <form id="form1" runat="server">
        <asp:Label runat="server" CssClass="lbl"><h3>New idea</h3></asp:Label>

        <asp:Table ID="container" runat="server" CssClass="ideaForm" CellPadding="10">
            <asp:TableRow>
                <asp:TableCell CssClass="c1"><asp:Label ID="lblTitle" runat="server" Text="Title: "></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID="txtTitle" CssClass="txt" runat="server"></asp:TextBox></asp:TableCell>
            </asp:TableRow>

            <%-- select type of author --%>
            <asp:TableRow>
                <asp:TableCell CssClass="c1"><asp:Label ID="lblAuthor" runat="server" Text="Author type: "></asp:Label></asp:TableCell>
                <asp:TableCell>
                    <asp:RadioButtonList ID="authorType" runat="server" RepeatDirection="Vertical" CellPadding="5" >
                        <asp:ListItem ID="lblAuthorName" runat="server" Text="Author name"></asp:ListItem>
                        <asp:ListItem ID="lblAnonymous" runat="server" Text="Anonymous"></asp:ListItem>
                    </asp:RadioButtonList>
                </asp:TableCell>
            </asp:TableRow>

            <%-- select tags --%>
            <asp:TableRow>
                <asp:TableCell CssClass="c1"><asp:Label ID="lblTags" runat="server" Text="Tags: "></asp:Label></asp:TableCell>
                <asp:TableCell><div class="container">
                    <%-- datalist of tags? some sort of container that selects items and displays as group--%>
                </div></asp:TableCell>
            </asp:TableRow>

            <asp:TableRow>
                <asp:TableCell CssClass="c1"><asp:Label ID="lblDetails" runat="server" Text="Description: "></asp:Label></asp:TableCell>
                <asp:TableCell><%-- text editor for description --%></asp:TableCell>
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