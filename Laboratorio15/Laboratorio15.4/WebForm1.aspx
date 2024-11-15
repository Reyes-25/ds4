<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Laboratorio15._4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Realizando Cálculos de Suma</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbl_numero" EnableViewState="false" runat="server" Text="Introduzca dos numeros:"></asp:Label>
            <br /><br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:Button ID="btn_sumar" runat="server" Text="Sumar" OnClick="btn_sumar_Click" />
            <br /><br />
            <asp:Label ID="lbl_resultado" EnableViewState="false" runat="server" Text="Resultado:"></asp:Label>            

        </div>
    </form>
</body>
</html>
