<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Detail.aspx.cs" Inherits="Detail" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <%--<asp:DataList ID="ListView1" cssclass="list"  runat="server">
       <ItemTemplate>
           <asp:Image ID="Image1" CssClass="sekil"  runat="server" width="100px" height="100px" imageurl="~/suc.jpg"/></br>
           <asp:Label ID="Label1" CssClass="sekil"  runat="server" Text='<%#Eval("OName") %>'></asp:Label>
           <asp:Label ID="Label2"  CssClass="sekil" runat="server" Text='<%#Eval("OSurname") %>'></asp:Label></br>
           <asp:Label ID="Label3" CssClass="sekil" runat="server" Text='<%#Eval("OGender") %>'></asp:Label>
           <asp:Label ID="Label4" CssClass="sekil" runat="server" Text='<%#Eval("XKoord") %>'></asp:Label>
           <asp:Label ID="Label5" CssClass="sekil" runat="server" Text='<%#Eval("YKood") %>'></asp:Label>
           <asp:Label ID="Label6" CssClass="sekil" runat="server" Text='<%#Eval("DateTime") %>'></asp:Label>
       </ItemTemplate>

    </asp:DataList>--%>
    
    </br>
    <div id="list">
    <div id="label">
        <asp:Label ID="Label1" runat="server" Text='<%#Eval("OName") %>'></asp:Label>
        <asp:Label ID="Label2" runat="server" Text='<%#Eval("OSurname") %>'></asp:Label>
        <asp:Label ID="Label3" runat="server" Text='<%#Eval("OGender") %>'></asp:Label></br>
        <asp:Image ID="Image1" width="100px" height="100px" imageurl="~/suc.jpg" runat="server" />
    </div>
    </br>
    <asp:GridView ID="GridView1" cssclass="sekil" runat="server" AutoGenerateColumns="False">
        
         <Columns>   
            <asp:BoundField DataField="XKoord" HeaderText="XKoord" />
            <asp:BoundField DataField="YKood" HeaderText="YKoord" />
            <asp:BoundField DataField="DateTime" HeaderText="DateTime" />
            <asp:BoundField DataField="Distance" HeaderText="Distance" />
            
           
        </Columns>
    </asp:GridView> 
       <iframe src="https://www.google.com/maps/embed?pb=!1m14!1m12!1m3!1d6354001.431501089!2d35.24157594999999!3d38.95734145000001!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!5e0!3m2!1str!2s!4v1425937287034" width="600" height="450" frameborder="0" style="border:0"></iframe>
    </div>
</asp:Content>

