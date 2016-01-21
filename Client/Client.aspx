<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Client.aspx.vb" Inherits="Client.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="X-Large"
            ForeColor="Red" Height="32px" Text="Web Service SOAP Calulator" Width="304px"></asp:Label><br />
        <br />
        <asp:Label ID="FirstNumber" runat="server" Font-Bold="True" Text="FirstNumber: "
            Width="192px"></asp:Label>
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        <asp:TextBox ID="TextBoxFirstNumber" runat="server" Font-Bold="True" Width="216px">Type a Number</asp:TextBox><br />
        <br />
        <asp:Label ID="SecondNumber" runat="server" Font-Bold="True" Text="SecondNumber:"
            Width="192px"></asp:Label>
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        <asp:TextBox ID="TextBoxSecondNumber" runat="server" Font-Bold="True" Width="216px">Type a Number</asp:TextBox><br />
        <br />
        <asp:DropDownList ID="DropDownList" runat="server">
            <asp:ListItem>Add</asp:ListItem>
            <asp:ListItem>Subtract</asp:ListItem>
            <asp:ListItem>Multiply</asp:ListItem>
            <asp:ListItem>Division</asp:ListItem>
        </asp:DropDownList>
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
        <asp:Button ID="Button" runat="server" Font-Bold="True" Text="Submit" /><br />
        <br />
        <asp:Label ID="LabelResult" runat="server" Font-Bold="True" Text="LabelResult" Width="472px"></asp:Label></div>
    </form>
</body>
</html>
