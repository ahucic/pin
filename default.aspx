<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="PIN_projekt._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:CheckBoxList AutoPostBack="true" ID="ListBoxes" runat="server" OnSelectedIndexChanged="ListBoxes_OnSelectedItemsChanged"></asp:CheckBoxList>
            <br /><br />
            <asp:TextBox runat="server" ID="ListaOpis"></asp:TextBox> 
            <asp:Button ID="CreateLista" runat="server" Text="Dodaj obavezu" OnClick="CreateLista_OnClick" />
        </div>
    </form>
</body>
</html>
