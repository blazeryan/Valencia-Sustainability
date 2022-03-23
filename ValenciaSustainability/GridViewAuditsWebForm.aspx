<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridViewAuditsWebForm.aspx.cs" Inherits="ValenciaSustainability.GridViewAuditsWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:SqlDataSource ID="GridViewAuditsSqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:ValenciaLocalDBConnectionString %>" SelectCommand="SELECT [AuditID], [AuditDate], [AuditName], [CampusName], [BuildingName], [RoomName] FROM [Audit]"></asp:SqlDataSource>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="AuditID" DataSourceID="GridViewAuditsSqlDataSource" Height="600px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="#CEE8FA" />
            <Columns>
                <asp:CommandField ShowSelectButton="True" />
                <asp:BoundField DataField="AuditID" HeaderText="AuditID" InsertVisible="False" ReadOnly="True" SortExpression="AuditID" />
                <asp:BoundField DataField="AuditDate" HeaderText="AuditDate" SortExpression="AuditDate" />
                <asp:BoundField DataField="AuditName" HeaderText="AuditName" SortExpression="AuditName" />
                <asp:BoundField DataField="CampusName" HeaderText="CampusName" SortExpression="CampusName" />
                <asp:BoundField DataField="BuildingName" HeaderText="BuildingName" SortExpression="BuildingName" />
                <asp:BoundField DataField="RoomName" HeaderText="RoomName" SortExpression="RoomName" />
            </Columns>
            <HeaderStyle BackColor="#C5EBFF" />
            <RowStyle BackColor="#C5EBFF" />
        </asp:GridView>
    </form>
</body>
</html>
