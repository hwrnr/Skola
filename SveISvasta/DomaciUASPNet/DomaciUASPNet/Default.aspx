<%@ Page Language="C#" Inherits="DomaciUASPNet.Default" %>
<!DOCTYPE html>
<html>
<head runat="server">
	<title>Lista skola</title>
</head>
<body>
	<form id="form1" runat="server">
        <asp:TextBox id="imeSkole" runat="server" /> <asp:br/>
        <asp:TextBox id="adresaSkole" runat="server" /> <asp:br/>
        <asp:TextBox id="mestoSkole" runat="server" />
        <asp:Button id="button1" runat="server" Text="Click me!" OnClick="button1Clicked" />
        <asp:Table id="Table1" runat="server" GridLines="Both" >
        <asp:Table/>

	</form>
</body>
</html>
