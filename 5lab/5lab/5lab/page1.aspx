<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page1.aspx.cs" Inherits="_5lab.page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Text1 {
            height: 32px;
            width: 206px;
        }
        #Text2 {
            height: 32px;
            width: 206px;
        }
        #Button1 {
            height: 51px;
            width: 210px;
        }
        #Button2 {
            height: 51px;
            width: 210px;
        }
        #Button2 {
            height: 51px;
            width: 210px;
        }
    </style>
</head>
<body style="background-color: #ccffff">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="САЙТ З АВТОРИЗОВАНИМ ДОСТУПОМ"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="ЛОГІН:"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="TextBox1" runat="server" Height="38px" Width="190px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="ПАРОЛЬ:"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="TextBox2" TextMode="Password" runat="server" Height="38px" Width="190px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="ВХІД" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="РЕЄСТРАЦІЯ" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
    <script src="ThanosMode.js"></script>
</body>
</html>
