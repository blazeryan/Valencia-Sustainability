<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Management.aspx.cs" Inherits="ValenciaSustainability.Management" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="font-size: xx-large">
    
        <strong>Management Page<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="z-index: 1; left: 10px; top: 250px; position: absolute; font-weight: 700;" Text="Lab Room Management" Width="220px" />
        </strong>
    
    </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 10px; top: 200px; position: absolute; font-weight: 700;" Text="Auditor Management" Width="220px" />
        <asp:Button ID="ReportsButton" runat="server" style="z-index: 1; left: 10px; top: 150px; position: absolute; font-weight: 700;" Text="Reports" OnClick="ReportsButton_Click" Width="220px" />
        <asp:Button ID="AuditsButton" runat="server" style="z-index: 1; left: 10px; top: 100px; position: absolute; font-weight: 700;" Text="Audits" OnClick="AuditsButton_Click" Width="220px" />
    </form>
</body>
</html>
