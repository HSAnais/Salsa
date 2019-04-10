<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="salsa_pro_ui.Dashboard" %>

<meta name="viewport" content="width=device-width, initial-scale=1.0"> 
<link rel="stylesheet" href="dashboard.css">
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
    <a href="Dashboard.aspx">Dashboard</a>
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
        <br /><br />
        <asp:Label ID="lblWelcome" CssClass="welcome" runat="server" Text="Welcome, [name]!"></asp:Label><br /><br />
        <asp:Label ID="lblRole" CssClass="role" runat="server" Text="Quality Assurance Manager"></asp:Label> <br />

        <div class="container">
            <%-- Role specific task; QAM = tags, QAC = notifications, admin = dates;--%>
             <div class="datalist">
                <asp:Label ID="lblR" CssClass="lblR" runat="server" Text="Notifications" ></asp:Label><br />
                <asp:DataList ID="dlRole"  runat="server"
                    RepeatColumns="0" 
                    CellSpacing="20" 
                    RepeatDirection="Vertical"
                    OnItemDataBound = "DL_ItemDataBound"
                    OnItemCommand="DL_ItemCommand">

                    <itemtemplate>
                        <b><asp:Label ID="lblTitle" runat="server" Text='<%#Eval("Title")%>'></asp:Label></b>
                        <br />
                        <%-- hide/unhide the following, depending on role --%>
                        <%-- QAC --%>
                        <asp:Label ID="lblDescription" runat="server" Text='<%#Eval("Details") %>' Visible="false"></asp:Label>
                        <%-- QAM/admin --%>
                        <asp:Button ID="btnEditSave" runat="server" Text="Edit" CssClass="btnLeft" OnClick="BtnEditSave_Click"></asp:Button>
                        <asp:Button ID="btnDelete" runat="server" Text="Delete" CssClass="btnRight" OnClick="BtnDelete_Click"></asp:Button>
                    </itemtemplate>
                </asp:DataList>
            </div>

            <%-- Bar chart: Number of ideas and contributors per department --%>
            <div class="stats">
                <%--<asp:Table ID="tblBar" runat="server" CellPadding="0" CellSpacing="0" Caption="Number of ideas and contributors per department" >
                    <asp:TableRow>
                        <asp:TableCell>Department 1</asp:TableCell>
                        <asp:TableCell>
                            <asp:Label ID="perI1" CssClass="perIdeas" runat="server" Width=""></asp:Label> ideas
                            <br />
                            <asp:Label ID="perC1" CssClass="perCon" runat="server" Width=""></asp:Label> contributors
                        </asp:TableCell>
                    </asp:TableRow>
                </asp:Table>--%>

                <%--<asp:DataList ID="dlBarChart"  runat="server"
                    RepeatColumns="0" 
                    CellSpacing="20" 
                    RepeatDirection="Vertical"
                    OnItemDataBound = "DL_ItemDataBound">

                    <itemtemplate>
                        <asp:Literal ID="lblDep" runat="server" Text='<%#Eval("Department")%>'></asp:Literal>
                        
                        <div class="bars">
                             <asp:Literal ID="perIdeas" runat="server" Text="Ideas"></asp:Literal>
                            <asp:Literal ID="perContributors" runat="server" Text="Contributors"></asp:Literal>
                        </div>                  
                    </itemtemplate>
                </asp:DataList>--%>
            </div>

            <%-- Pie chart: Percentage of ideas per department --%>
            <div class="stats">
                
            </div>
        </div>
    </form>
</body>

<footer>
    <p> Developed with ☕ by the <a href="https://github.com/HSAnais/Salsa">Salsa</a> team</p>
</footer>