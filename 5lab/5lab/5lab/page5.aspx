<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page5.aspx.cs" Inherits="_5lab.page5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color: #e6faff">
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Вітаємо вас на нашому сайті,"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="&lt;ІМ'Я&gt; &lt;ПРІЗВИЩЕ&gt;!"></asp:Label>
            <br />
            <br />
            <asp:Image ID="Image1" runat="server" Height="200px" Width="150px" />
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Логін ..... "></asp:Label>
            <asp:Label ID="Label5" runat="server" Text="&lt;ЛОГІН&gt;"></asp:Label>
            <br />
            <asp:Label ID="Label4" runat="server" Text="E-mail ..... "></asp:Label>
            <asp:Label ID="Label6" runat="server" Text="&lt;E-mail-адреса&gt;"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Height="56px" Text="ВИХІД" Width="190px" OnClick="Button1_Click" />
            <br />
            <br />
            <br />
            <br />
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
