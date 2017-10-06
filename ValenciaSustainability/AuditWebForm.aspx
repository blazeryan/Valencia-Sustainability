<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AuditWebForm.aspx.cs" Inherits="ValenciaSustainability.AuditWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        AUDIT FORM</div>
        <asp:GridView ID="AuditGridView" runat="server" AutoGenerateColumns="False" DataSourceID="Audit">
            <Columns>
                <asp:CheckBoxField DataField="WaterRunning" HeaderText="WaterRunning" SortExpression="WaterRunning" />
                <asp:CheckBoxField DataField="KitchenWaterLeak" HeaderText="KitchenWaterLeak" SortExpression="KitchenWaterLeak" />
                <asp:CheckBoxField DataField="KitchenLightsOn" HeaderText="KitchenLightsOn" SortExpression="KitchenLightsOn" />
                <asp:CheckBoxField DataField="FridgeOpen" HeaderText="FridgeOpen" SortExpression="FridgeOpen" />
                <asp:CheckBoxField DataField="FreezerOpen" HeaderText="FreezerOpen" SortExpression="FreezerOpen" />
                <asp:CheckBoxField DataField="KitchenOther" HeaderText="KitchenOther" SortExpression="KitchenOther" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="Audit" runat="server" ConnectionString="<%$ ConnectionStrings:ValenciaLocalDBConnectionString %>" SelectCommand="SELECT [WaterRunning], [KitchenWaterLeak], [KitchenLightsOn], [FridgeOpen], [FreezerOpen], [KitchenOther] FROM [Audit]"></asp:SqlDataSource>
    </form>
</body>
</html>
