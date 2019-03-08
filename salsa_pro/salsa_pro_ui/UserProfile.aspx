<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserProfile.aspx.cs" Inherits="salsa_pro_ui.UserProfile" %>

<link rel="stylesheet" href="userProfile.css">

<body>
<form id="form1" runat="server">
    <asp:Label ID="lblWelcome" CssClass="welcome" runat="server" Text="Welcome, [name]!"></asp:Label><br />
    <asp:Label ID="lblLastLogin" Visible="false" CssClass="login" runat="server" Text="Your last login was: xxxxxxxx"></asp:Label>

    <div class="container">
        <div class="info">
            <asp:Label runat="server" Text="Email:"></asp:Label><br />
            <asp:Label ID="lblEmail" runat="server" Text="xxxxxxx@greenwich.ac.uk"></asp:Label><br /><br />
            <asp:Label runat="server" Text="Department:"></asp:Label><br />
            <asp:Label ID="lblDep" runat="server" Text="Coomputing and Maths"></asp:Label><br />
        </div>

        <div class="datalist">
            <asp:Label CssClass="lbl" runat="server" Text="Your ideas"></asp:Label>
            <asp:DataList ID="dlIdeas"  runat="server"
                RepeatColumns="0" 
                CellSpacing="20" 
                RepeatDirection="Vertical"
                OnItemDataBound = "DL_ItemDataBound"
                OnItemCommand="DL_ItemCommand">

                <itemtemplate>
                    <asp:LinkButton id="SelectButton" CommandName="Select" runat="server" CssClass="selectItem" >
                        <b><asp:Label ID="lblVotes" runat="server" Text='<%#Eval("Rating")%>'></asp:Label><br />votes</b>
                        <b><asp:Label ID="lblIdea" runat="server" Text='<%#Eval("Title") %>'></asp:Label></b><br />
                        <asp:Label ID="lblDetails" runat="server" Text='<%#Eval("Details") %>'></asp:Label>
                    </asp:LinkButton>
                </itemtemplate>
            </asp:DataList>
        </div>

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
                        <b> On <asp:Label ID="lblIdeaTitle" runat="server" Text='<%#Eval("Title")%>'></asp:Label></b><br />
                        <asp:Label ID="lblComment" runat="server" Text='<%#Eval("ComDetail") %>'></asp:Label><br />
                        <asp:Label ID="lblComDate" runat="server" Text='<%#Eval("ComDate") %>'></asp:Label>
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