<%@ Page Title="648 Game House - Online Enquiry System" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="OnlineItemEnquiry.Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        .GridHeader{
            text-align:center !important;   
        }
    </style>
    <div>
    <h3>語言(Language) :&nbsp;
&nbsp;&nbsp;&nbsp;
                &nbsp;&nbsp;&nbsp; </h3>
        <p>
                <asp:Button ID="btnEng" runat="server" Height="28px" style="font-size: 14px" Text="英文(English)" Visible="true" AutoPostBack="true" OnClick="btnEng_Click" />
&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnSC" runat="server" Height="28px" style="font-size: 14px" Text="简体中文(Simplified Chinese)" AutoPostBack="true"  Visible="true" OnClick="btnSC_Click" />
&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnTC" runat="server" Height="28px" style="font-size: 14px" Text="繁體中文(Traditional Chinese)" AutoPostBack="true" Visible="true" OnClick="btnTC_Click" /></p>
    </div>
        <div class="jumbotron">
            <h1 class="auto-style3"><strong id="SubHead">
                <asp:Label ID="lblSubHead" runat="server" style="font-size: 28px" Text="Online Item Enquiry System"></asp:Label>
                </strong></h1>

    <div class="row">
        <div class="col-md-4">
            <h3>
            <asp:Label ID="lblDescSC" runat="server" style="font-size: x-large" Text="Select The Search Criteria: "></asp:Label>
        </h3>
        <asp:SqlDataSource ID="DataSourceSC" runat="server" ConnectionString="Provider=Microsoft.Jet.OLEDB.4.0;Data Source=&quot;D:\Folder_Tommy\IVEassignment\Sem3\SDP\RSS\Retail Sales SystemV1.0\Retail Sales SystemV1.0\bin\Debug\RSSDatabase.mdb&quot;" ProviderName="System.Data.OleDb" SelectCommand="SELECT DISTINCT ItemList.Category FROM ItemList"></asp:SqlDataSource>
        <strong>
        <asp:Label ID="lblCate" runat="server" style="font-size: large" Text="Category:"></asp:Label>
        </strong><br />
        <asp:CheckBox ID="cbCategory" runat="server" AutoPostBack="true" OnCheckedChanged="cbCategory_CheckedChanged"/>
        <asp:DropDownList ID="dDLCategory" runat="server" Height="28px" Width="186px" style="font-size: 18px" DataSourceID="DataSourceSC" DataTextField="Category" DataValueField="Category" Enabled="False">
            <asp:ListItem></asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <strong>
        <asp:Label ID="lblShop" runat="server" style="font-size: large" Text="Shop:"></asp:Label>
        </strong><br />
        <asp:CheckBox ID="cbShop" runat="server"  AutoPostBack="true" OnCheckedChanged="cbShop_CheckedChanged"/>
        <asp:DropDownList ID="dDLShop" runat="server" Height="28px" Width="186px" style="font-size: 18px" DataSourceID="DataSourceSCShop" DataTextField="Shop" DataValueField="Shop" Enabled="False">
        </asp:DropDownList>
        <asp:SqlDataSource ID="DataSourceSCShop" runat="server" ConnectionString="<%$ ConnectionStrings:RSSDatabaseConnectionString %>" ProviderName="<%$ ConnectionStrings:RSSDatabaseConnectionString.ProviderName %>" SelectCommand="SELECT DISTINCT Location AS Shop FROM ShopItem"></asp:SqlDataSource>
        <br />
        <asp:Button ID="btnSearch" runat="server" Height="28px" Text="Search" style="font-size: large; margin-top: 0px" OnClick="btnSearch_Click" />
        <br />
        </div>
     </div>
     <div class="row">   
        <div class="table-responsive">
            <asp:Label ID="lblML" runat="server" style="font-weight: 700; font-size: large" Text="Matching List: " Visible="False"></asp:Label>
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="gridViewTableSource" ForeColor="#333333" GridLines="None" Height="210px" Width="820px" BorderStyle="Solid" OnSelectedIndexChanging="GridView1_SelectedIndexChanging" SelectedIndex="0" OnPreRender="GridView1_PreRender"  CssClass="table-responsive" HeaderStyle-CssClass="GridHeader" Font-Size="16px">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:CommandField ShowSelectButton="True" SelectText="Select"/>
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <asp:SqlDataSource ID="gridViewTableSource" runat="server" ConnectionString="<%$ ConnectionStrings:RSSDatabaseConnectionString %>" ProviderName="<%$ ConnectionStrings:RSSDatabaseConnectionString.ProviderName %>" SelectCommand="SELECT ItemList.ItemCode, ItemList.Name, ShopItem.Location, ShopItem.ShelfNum FROM (ItemList INNER JOIN ShopItem ON ItemList.ItemCode = ShopItem.ItemCode)"></asp:SqlDataSource>
        <br />
            </div>
        </div>
        <div class="row">
        <div class="table-responsive">
            <asp:Label ID="lblDetaisDesc" runat="server" style="font-weight: 700; font-size: large" Text="Details of Selected Items: " Visible="False"></asp:Label>
        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" DataSourceID="detailSource" Height="50px" Width="812px" AllowPaging="True" OnPageIndexChanging="DetailsView1_PageIndexChanging" CaptionAlign="Left" HorizontalAlign="Left" OnPreRender="DetailsView1_PreRender" CssClass="table-responsive" Font-Size="16px" ForeColor="Black">
            <PagerSettings Visible="False" />
        </asp:DetailsView>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        <asp:SqlDataSource ID="detailSource" runat="server" ConnectionString="<%$ ConnectionStrings:RSSDatabaseConnectionString %>" ProviderName="<%$ ConnectionStrings:RSSDatabaseConnectionString.ProviderName %>" SelectCommand="SELECT ItemList.ItemCode, ItemList.Name, ItemList.DetailDesc, ItemPrice.Price, ItemPrice.Discounts, ItemPrice.MemberPrice, ShopItem.Location, ShopItem.ShelfNum FROM ((ItemList INNER JOIN ItemPrice ON ItemList.ItemCode = ItemPrice.ItemCode) INNER JOIN ShopItem ON ItemList.ItemCode = ShopItem.ItemCode)"></asp:SqlDataSource>
        </div>
    </div>
            </div>

</asp:Content>
