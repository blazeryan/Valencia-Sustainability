<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TodaysTempReportWebForm.aspx.cs" Inherits="ValenciaSustainability.TodaysTempReportWebForm" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="TodaysTempReportScriptManager" runat="server"></asp:ScriptManager>
    <div>
        <rsweb:ReportViewer ID="TodaysTempReportViewer" runat="server" Font-Names="Verdana" Font-Size="8pt" Height="600px" WaitMessageFont-Names="Verdana" WaitMessageFont-Size="14pt" Width="100%">
            <LocalReport ReportPath="TodaysTempReport.rdlc">
                <DataSources>
                    <rsweb:ReportDataSource DataSourceId="TodaysTempReportObjectDataSource" Name="TodaysTempDataSet" />
                </DataSources>
            </LocalReport>
        </rsweb:ReportViewer>
        <asp:ObjectDataSource ID="TodaysTempReportObjectDataSource" runat="server" OldValuesParameterFormatString="original_{0}" SelectMethod="GetData" TypeName="ValenciaSustainability.TodaysTempReportDataSetTableAdapters.AuditTableAdapter"></asp:ObjectDataSource>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetData" TypeName="ValenciaSustainability.TodaysTempReportDataSetTableAdapters.AuditTableAdapter"></asp:ObjectDataSource>
    </div>
    </form>
</body>
</html>
