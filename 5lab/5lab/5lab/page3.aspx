<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page3.aspx.cs" Inherits="_5lab.page3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Text1 {
            height: 30px;
            margin-top: 0px;
        }
    </style>
</head>
<body style="background-color: #ffffcc">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="ВЕРИФІКАЦІЯ АДРЕСИ ЕЛЕКТРОННОЇ ПОШТИ"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="На Вашу адресу направлений одноразовий пароль. "></asp:Label>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Введіть його в поле і натисніть &quot;ЗАРЕЄСТРУВАТИ&quot;:"></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Height="30px" OnTextChanged="TextBox1_TextChanged" Width="224px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Height="47px" Text="ЗАРЕЄСТРУВАТИ" Width="155px" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Height="47px" Text="НАЗАД" Width="155px" OnClick="Button2_Click" />
        <br />
    </form>
    <script src="ThanosMode.js"></script>
</body>
</html>
