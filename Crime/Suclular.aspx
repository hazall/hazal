<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Suclular.aspx.cs" Inherits="Suclular" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="aa">
                <div id="bb">Suçlular</div>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        <asp:ListItem>Name</asp:ListItem>
        <asp:ListItem>Surname</asp:ListItem>
        <asp:ListItem>Female</asp:ListItem>
        <asp:ListItem>Male</asp:ListItem>

    </asp:DropDownList>
        <asp:DataList ID="DataList1" CssClass="GridMain" runat="server">
            <ItemTemplate>
                <a href="Detail.aspx?id=<%#Eval("OffID") %>">
                <asp:Label ID="Label2" runat="server" Text='<%#Eval("OName") %>'></asp:Label>
                <asp:Label ID="Label3" runat="server" Text='<%#Eval("OSurname") %>'></asp:Label></a>
                
            </ItemTemplate>

        </asp:DataList>
                <%--<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" cssclass="GridMain" DataKeyNames="OffID" OnSelectedIndexChanging="GridView1_SelectedIndexChanging">
                    <Columns>
                        <asp:BoundField DataField="OName" HeaderText="Name" />
                        <asp:BoundField DataField="OSurname" HeaderText="Surname" />
                        
                        <asp:HyperLinkField HeaderText="Ayrıntılar" NavigateUrl="~/Suclular.aspx" Text="Seç" />
                        
                    </Columns>
                </asp:GridView>--%>
        <asp:Label ID="Label1" runat="server" ></asp:Label>

            </div>
    <div id="cc">

        <asp:DataList ID="DataList2" runat="server">
            <ItemTemplate>
                <asp:Label ID="Label4" runat="server" Text='<%#Eval("OName") %>'></asp:Label>
            </ItemTemplate>
        </asp:DataList>
        <asp:DataList ID="DataList3" runat="server">
            <ItemTemplate>
                <asp:Label ID="Label4" runat="server" Text='<%#Eval("OSurname") %>'></asp:Label>
            </ItemTemplate>
        </asp:DataList>
        <asp:DataList ID="DataList4" runat="server">
            <ItemTemplate>
                <asp:Label ID="Label4" runat="server" Text='<%#Eval("OName") %>'></asp:Label>
            </ItemTemplate>
        </asp:DataList>
    </div>
</asp:Content>

