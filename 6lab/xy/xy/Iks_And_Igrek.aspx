<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Iks_And_Igrek.aspx.cs" Inherits="xy.Iks_And_Igrek" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color: #ffeeaa; height: 765px;">
    <form id="form1" runat="server">
        Input X:
        <asp:TextBox ID="XBox" runat="server" Height="34px" Width="150px"></asp:TextBox>
        <br />
        <br />
        Input Y:
        <asp:TextBox ID="YBox" runat="server" Height="34px" Width="150px"></asp:TextBox>
        <br />
        <br />
        RESULT:
        <asp:TextBox ID="ResultBox" runat="server" Height="34px" Width="150px"></asp:TextBox>
        <p>
            <asp:Button ID="Button1" runat="server" Height="38px" OnClick="Button1_Click" Text="Порахувати" Width="215px" />
        </p>
    </form>
</body>
</html>
