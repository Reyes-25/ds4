<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WebForm1.aspx.cs" Inherits="WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Enviar Saludo</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtNombre" runat="server" placeholder="Introduce tu nombre"></asp:TextBox>
            <asp:Button ID="btnEnviar" runat="server" Text="Enviar Saludo" OnClick="btnEnviar_Click" />
            <asp:Label ID="lblSaludo" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
