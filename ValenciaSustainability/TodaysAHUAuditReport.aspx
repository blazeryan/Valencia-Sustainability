<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TodaysAHUAuditReport.aspx.cs" Inherits="ValenciaSustainability.TodaysAHUAuditReport" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="TodaysAHUAuditReportScriptManager" runat="server"></asp:ScriptManager>
    <div>
        <rsweb:ReportViewer ID="TodaysAHUAuditReportViewer" runat="server" Font-Names="Verdana" Font-Size="8pt" Height="1080px" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="100%">
            <LocalReport ReportPath="TodaysAHUAuditReport.rdlc">
                <DataSources>
                    <rsweb:ReportDataSource DataSourceId="TodaysAHUReportObjectDataSource" Name="TodaysAHUReportDataSet" />
                </DataSources>
            </LocalReport>
        </rsweb:ReportViewer>
        <asp:ObjectDataSource ID="TodaysAHUReportObjectDataSource" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="ValenciaSustainability.TodaysAHUAuditReportDataSetTableAdapters.AuditTableAdapter"></asp:ObjectDataSource>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetData" TypeName="ValenciaSustainability.TodaysAHUReportDataSetTableAdapters.AuditTableAdapter"></asp:ObjectDataSource>
    </div>
    </form>
</body>
</html>
