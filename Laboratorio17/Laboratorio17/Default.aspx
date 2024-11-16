<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio17._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <asp:GridView ID="MyGridView" DataSourceID="MyDataSource1"
            AllowSorting="true" AllowPaging="true"
            DataKeyNames="ProductID"
            AutoGenerateEditButton="true"
            runat="server">
        </asp:GridView>

        <asp:SqlDataSource ID="MyDataSource1" runat="server"
            ConnectionString="data source=DESKTOP-KCJH1I6\SQLEXPRESS;initial catalog=northwind; persist security info=true; Integrated Security=SSPI;"
            ProviderName="System.Data.SqlClient"
            SelectCommand="SELECT ProductId, ProductName, UnitPrice FROM Products"
            UpdateCommand="UPDATE Products SET [ProductName]=@ProductName, [UnitPrice]=@UnitPrice WHERE [ProductId]=@ProductId">
            
           
        </asp:SqlDataSource>
    </div>

</asp:Content>
