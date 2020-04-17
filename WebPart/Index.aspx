<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebPart.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox TextMode="MultiLine" ID="txbx_Output" runat="server" Text="Some Text" Height="238px" Width="568px"></asp:TextBox>
            <br />
            <asp:Button ID="btn_CallMethodDll" runat="server" Text="Вызвать метод из DLL" OnClick="btn_CallMethodDll_Click"></asp:Button>
        </div>
    </form>
</body>
</html>
