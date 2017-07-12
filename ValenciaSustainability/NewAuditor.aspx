<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewAuditor.aspx.cs" Inherits="ValenciaSustainability.NewAuditor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1 style="font-size: xx-large">Add Auditor</h1>
        <asp:Button ID="InsertNewAuditorButton" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 10px; top: 164px; position: absolute; font-weight: 700;" Text="Insert New Auditor" />
        <asp:TextBox ID="FirstNameTextBox" runat="server" style="z-index: 1; left: 10px; top: 111px; position: absolute" OnTextChanged="FirstNameTextBox_TextChanged"></asp:TextBox>
        <asp:Label ID="FirstNameLabel" runat="server" style="position: absolute; z-index: 1; left: 11px; top: 80px; font-weight: 700;" Text="First Name"></asp:Label>
        <asp:Label ID="MiddleNameLabel" runat="server" style="z-index: 1; left: 154px; top: 80px; position: absolute; font-weight: 700;" Text="Middle Name"></asp:Label>
        <asp:TextBox ID="MiddleNameTextBox" runat="server" style="position: absolute; top: 111px; left: 150px; z-index: 1;" OnTextChanged="MiddleNameTextBox_TextChanged"></asp:TextBox>
        <asp:Label ID="LastNameLabel" runat="server" style="z-index: 1; left: 302px; top: 80px; position: absolute; font-weight: 700;" Text="Last Name"></asp:Label>
        <asp:TextBox ID="LastNameTextBox" runat="server" style="position: absolute; z-index: 1; left: 299px; top: 111px" OnTextChanged="LastNameTextBox_TextChanged"></asp:TextBox>
        <asp:Label ID="EmailLabel" runat="server" style="z-index: 1; left: 441px; top: 80px; position: absolute; font-weight: 700;" Text="Email"></asp:Label>
        <asp:TextBox ID="EmailTextBox" runat="server" style="position: absolute; z-index: 1; left: 438px; top: 111px" OnTextChanged="LastNameTextBox_TextChanged"></asp:TextBox>
        <asp:Label ID="PhoneNumberLabel" runat="server" style="z-index: 1; left: 600px; top: 80px; position: absolute; font-weight: 700;" Text="Phone Number"></asp:Label>
        <asp:TextBox ID="PhoneNumberTextBox" runat="server" style="position: absolute; z-index: 1; left: 601px; top: 111px" OnTextChanged="LastNameTextBox_TextChanged"></asp:TextBox>
        <A HREF="Auditor.ASPX"/>
    </form>
</body>
</html>
