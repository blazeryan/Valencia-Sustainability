<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="ValenciaSustainability.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Manage Lab Rooms</h1>
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ValenciaLocalDBConnectionString %>" SelectCommand="SELECT [RoomNumber], [RoomID], [BuildingID] FROM [Room]" DeleteCommand="DELETE FROM [Room] WHERE [RoomID] = @RoomID" InsertCommand="INSERT INTO [Room] ([RoomNumber], [BuildingID]) VALUES (@RoomNumber, @BuildingID)" UpdateCommand="UPDATE [Room] SET [RoomNumber] = @RoomNumber, [BuildingID] = @BuildingID WHERE [RoomID] = @RoomID">
            <DeleteParameters>
                <asp:Parameter Name="RoomID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="RoomNumber" Type="String" />
                <asp:Parameter Name="BuildingID" Type="Int32" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="RoomNumber" Type="String" />
                <asp:Parameter Name="BuildingID" Type="Int32" />
                <asp:Parameter Name="RoomID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" style="z-index: 1; left: 23px; top: 186px; position: absolute; height: 152px; width: 232px" DataKeyNames="RoomID">
            <AlternatingRowStyle BackColor="#E2F3FC" />
            <Columns>
                <asp:CommandField ShowEditButton="True" />
                <asp:BoundField DataField="RoomNumber" HeaderText="RoomNumber" SortExpression="RoomNumber" />
            </Columns>
            <FooterStyle BackColor="#E2F3FC" />
            <HeaderStyle BackColor="#E2F3FC" />
            <RowStyle BackColor="#C5E7F8" />
        </asp:GridView>
        <asp:Button ID="NewLabButton" runat="server" OnClick="NewLabButton_Click" style="z-index: 1; left: 25px; top: 130px; position: absolute" Text="New Lab" />
    </form>
</body>
</html>
