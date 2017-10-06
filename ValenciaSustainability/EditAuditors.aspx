<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditAuditors.aspx.cs" Inherits="ValenciaSustainability.EditAuditors" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="InsertAuditorForm" runat="server">
    <div>
    
        <h1>&nbsp; Manage Auditors</h1>
    
    </div>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
            AutoGenerateColumns="False" DataKeyNames="AuditorID" 
            DataSourceID="SqlDataSource1" EnableTheming="True" 
            style="z-index: 1; left: 40px; top: 179px; position: absolute; height: 152px; width: 232px" 
            Font-Bold="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged2">
            <AlternatingRowStyle BackColor="#EAF7FD" Font-Bold="False" />
            <Columns>
                <asp:CommandField ShowEditButton="True" />
                <asp:BoundField DataField="AuditorFirstName" HeaderText="AuditorFirstName" SortExpression="AuditorFirstName" />
                <asp:BoundField DataField="AuditorMiddleName" HeaderText="AuditorMiddleName" SortExpression="AuditorMiddleName" />
                <asp:BoundField DataField="AuditorLastName" HeaderText="AuditorLastName" SortExpression="AuditorLastName" />
                <asp:BoundField DataField="AuditorEmail" HeaderText="AuditorEmail" SortExpression="AuditorEmail" />
                <asp:BoundField DataField="AuditorPhoneNumber" HeaderText="AuditorPhoneNumber" SortExpression="AuditorPhoneNumber" />
            </Columns>
            <FooterStyle BackColor="#E6C1BB" />
            <HeaderStyle BackColor="#EAF7FD" BorderStyle="Double" />
            <RowStyle BackColor="#DAF0FC" Font-Bold="False" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ValenciaLocalDBConnectionString %>" DeleteCommand="DELETE FROM [Auditor] WHERE [AuditorID] = @AuditorID" InsertCommand="INSERT INTO [Auditor] ([AuditorFirstName], [AuditorMiddleName], [AuditorLastName], [AuditorEmail], [AuditorPhoneNumber]) VALUES (@AuditorFirstName, @AuditorMiddleName, @AuditorLastName, @AuditorEmail, @AuditorPhoneNumber)" SelectCommand="SELECT [AuditorID], [AuditorFirstName], [AuditorMiddleName], [AuditorLastName], [AuditorEmail], [AuditorPhoneNumber] FROM [Auditor]" UpdateCommand="UPDATE [Auditor] SET [AuditorFirstName] = @AuditorFirstName, [AuditorMiddleName] = @AuditorMiddleName, [AuditorLastName] = @AuditorLastName, [AuditorEmail] = @AuditorEmail, [AuditorPhoneNumber] = @AuditorPhoneNumber WHERE [AuditorID] = @AuditorID">
            <DeleteParameters>
                <asp:Parameter Name="AuditorID" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="AuditorFirstName" Type="String" />
                <asp:Parameter Name="AuditorMiddleName" Type="String" />
                <asp:Parameter Name="AuditorLastName" Type="String" />
                <asp:Parameter Name="AuditorEmail" Type="String" />
                <asp:Parameter Name="AuditorPhoneNumber" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="AuditorFirstName" Type="String" />
                <asp:Parameter Name="AuditorMiddleName" Type="String" />
                <asp:Parameter Name="AuditorLastName" Type="String" />
                <asp:Parameter Name="AuditorEmail" Type="String" />
                <asp:Parameter Name="AuditorPhoneNumber" Type="String" />
                <asp:Parameter Name="AuditorID" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <asp:Button ID="NewAuditorButton" runat="server" OnClick="InsertAuditorButton_Click" style="position: absolute; top: 126px; left: 40px; z-index: 1;" Text="New Auditor"/>
       
    </form>
</body>
</html>
