<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="P06rzetwarzanieAsynchroniczneAJAX.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="jquery-3.6.3.min.js"></script>
    <script src="MojSkrypt.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        
       <%-- rozwiązanie synchroniczne--%>

        <asp:TextBox ID="txtLiczba1ASP" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtLiczba2ASP" runat="server"></asp:TextBox>
        <asp:Button ID="btnWynik" OnClick="btnWynik_Click" runat="server" Text="Button" />

        <asp:Label ID="lblWynik" runat="server" Text="Label"></asp:Label>

        <br />
       <%-- rozwiązanie asynchroniczne --%>

        <input type="text" id="txtLiczba1HTML" />
        <input type="text" id="txtLiczba2HTML" />

        <input type="button" id="btnPolicz" value="Policz" />

        <span id="wynik" ></span>


    </form>
</body>
</html>
