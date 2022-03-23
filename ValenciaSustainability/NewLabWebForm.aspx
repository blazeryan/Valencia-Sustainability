<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewLabWebForm.aspx.cs" Inherits="ValenciaSustainability.NewLabWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1 style="font-size: xx-large">&nbsp;&nbsp;&nbsp; Add Lab Room</h1>
    
    </div>
        <asp:Label ID="LabRoomLabel" runat="server" style="z-index: 1; left: 547px; top: 93px; position: absolute; font-weight: 700;" Text="Room Number"></asp:Label>
        <asp:DropDownList ID="CampusDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="CampusDropDownList_SelectedIndexChanged" style="z-index: 1; left: 48px; top: 128px; position: absolute; " DataTextField="CampusName" DataValueField="CampusName">
            <asp:ListItem>East</asp:ListItem>
            <asp:ListItem>West</asp:ListItem>
            <asp:ListItem>Osceola</asp:ListItem>
            <asp:ListItem>Lake Nona</asp:ListItem>
            <asp:ListItem>Winter Park</asp:ListItem>
            <asp:ListItem>SPS</asp:ListItem>
            <asp:ListItem>District Office</asp:ListItem>
        </asp:DropDownList>
        <asp:SqlDataSource ID="Campus" runat="server" ConnectionString="<%$ ConnectionStrings:ValenciaLocalDBConnectionString %>" SelectCommand="SELECT [CampusName] FROM [Campus]"></asp:SqlDataSource>
        <asp:Label ID="BuildingLabel" runat="server" style="z-index: 1; left: 299px; top: 93px; position: absolute; font-weight: 700; right: 842px;" Text="Building"></asp:Label>
        <asp:Label ID="CampusLabel" runat="server" style="z-index: 1; left: 47px; top: 93px; position: absolute; font-weight: 700;" Text="Campus"></asp:Label>
        <asp:TextBox ID="LabRoomTextBox" runat="server" OnTextChanged="LabRoomTextBox_TextChanged1" style="z-index: 1; left: 548px; top: 125px; position: absolute; width: 125px;"></asp:TextBox>
        <asp:Button ID="InsertLabRoomButton" runat="server" OnClick="InsertLabRoomButton_Click" style="z-index: 1; left: 41px; top: 187px; position: absolute; font-weight: 700;" Text="Insert New Lab Room" />
        <asp:DropDownList ID="BuildingDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="BuildingDropDownList_SelectedIndexChanged" style="z-index: 1; left: 298px; top: 128px; position: absolute" DataTextField="BuildingNumber" DataValueField="BuildingID">
            <asp:ListItem>1</asp:ListItem>
        </asp:DropDownList>

    </form>
</body>
</html>
