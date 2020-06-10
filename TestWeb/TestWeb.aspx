<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestWeb.aspx.cs" Inherits="TestWeb.TestWeb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 40px">
            <br />
            <asp:Label ID="Label3" runat="server" Text="Ingrese un numero entero para verificar si es par o impar"></asp:Label>
            <br />
            <asp:TextBox ID="txtNum" runat="server" Width="174px"></asp:TextBox>
&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Verificar" Width="160px" />
            <br />
            <br />
            <asp:TextBox ID="txtNumR" runat="server" Width="342px"></asp:TextBox>
        </div>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Ingrese el numero del mes correspondiente entre 1 y 12"></asp:Label>
        <div style="margin-left: 40px">
            <asp:TextBox ID="txtMes" runat="server" Width="166px"></asp:TextBox>
&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="OK" Width="157px" />
            <br />
            <br />
            <asp:TextBox ID="txtMesR" runat="server" Width="341px"></asp:TextBox>
            <br />
        </div>
    </form>
</body>
</html>
