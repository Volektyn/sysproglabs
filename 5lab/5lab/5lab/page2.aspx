<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page2.aspx.cs" Inherits="_5lab.page2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Text1 {
            height: 30px;
            width: 196px;
            margin-top: 0px;
        }
        #Text2 {
            height: 32px;
            width: 203px;
            margin-top: 0px;
        }
        #Text3 {
            height: 32px;
            width: 203px;
            margin-top: 0px;
        }
        #Text4 {
            height: 32px;
            width: 203px;
            margin-top: 0px;
        }
        #Text5 {
            height: 32px;
            width: 203px;
            margin-top: 0px;
        }
        #File1 {
            width: 462px;
            height: 30px;
        }
    </style>
</head>
<body style="background-color: #ffe6e6">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Text="ФОТОГРАФІЯ (JPEG/PNG, min 100x150, max 200x300):"></asp:Label>
        <br />
        <br />
        <asp:FileUpload ID="FileUpload1" runat="server" BorderStyle="Groove" Height="30px" Width="465px" />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="ІМ'Я:	"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" Text="ПРІЗВИЩЕ:	"></asp:Label>
        <br />
        &nbsp;<asp:TextBox ID="TextBox1" runat="server" Height="29px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" Height="29px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Логін:	"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label5" runat="server" Text="E-mail:	"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox3" runat="server" Height="29px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox4" runat="server" Height="29px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label6" runat="server" Text="Пароль:	"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox5" TextMode="Password" runat="server" Height="29px"></asp:TextBox>
        <br />
        <br />
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
            <asp:ListItem>Студент</asp:ListItem>
            <asp:ListItem Selected="True">Викладач</asp:ListItem>
            <asp:ListItem>Навчально-допоміжний персонал</asp:ListItem>
        </asp:RadioButtonList>
        <br />
        <asp:CheckBox ID="CheckBox1" runat="server" Text="Майстер спорту" />
&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="CheckBox2" runat="server" Text="Кандидат наук" />
&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="CheckBox3" runat="server" Text="Доктор наук" />
        <br />
        <br />
        <br />
        <asp:Label ID="Label7" runat="server" Text="Курс:	"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label8" runat="server" Text="Факультет:	"></asp:Label>
        <br />
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource3" DataTextField="Курс" DataValueField="Курс" Height="30px" Width="155px">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:5labDBConnectionString %>" SelectCommand="SELECT [Курс] FROM [Course]"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:5labDBConnectionString %>" SelectCommand="SELECT [Курс] FROM [Курс]"></asp:SqlDataSource>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="Факультет" DataValueField="Факультет" Height="30px" Width="275px">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:5labDBConnectionString %>" SelectCommand="SELECT [Факультет] FROM [Faculty]"></asp:SqlDataSource>
        <br />
        <br />
        <asp:Label ID="Label9" runat="server" Text="Структурний підрозділ:	"></asp:Label>
        <br />
        <br />
        <asp:DropDownList ID="DropDownList3" runat="server" DataSourceID="SqlDataSource4" DataTextField="Unit" DataValueField="Unit" Height="30px" Width="388px">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:5labDBConnectionString %>" SelectCommand="SELECT [Unit] FROM [StructUnits]"></asp:SqlDataSource>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Height="47px" Text="ДАЛІ" Width="207px" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Height="47px" Text="НАЗАД" Width="207px" OnClick="Button2_Click" />
        <br />
    </form>
    <script src="ThanosMode.js"></script>
</body>
</html>
