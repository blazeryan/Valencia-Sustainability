<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReportsWebForm.aspx.cs" Inherits="ValenciaSustainability.ReportsWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            z-index: 1;
            left: 10px;
            top: 15px;
            position: absolute;
            height: 47px;
            width: 999px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="font-weight: 700; font-size: x-large">
    
        <h1>REPORTS</h1>
    
    </div>
        <asp:Button ID="AuditReportsButton" runat="server" style="z-index: 1; left: 10px; top: 150px; position: absolute; font-weight: 700; text-align: center; width: 220px; " Text="Audit Reports" OnClick="AuditReportsButton_Click" Width="220px" />
        <asp:Button ID="AHUReportsButton" runat="server" style="z-index: 1; left: 10px; top: 200px; position: absolute; width: 220px; font-weight: 700; text-align: center;" Text="AHU Reports" OnClick="AHUReportsButton_Click" Width="220px" />
        <asp:Button ID="LabRoomButton" runat="server" style="z-index: 1; left: 10px; top: 250px; position: absolute; width: 220px; font-weight: 700; height: 29px;" Text="Lab Room Reports" OnClick="LabRoomButton_Click" Width="220px" />
        <asp:Button ID="ParkingLightsReportButton" runat="server" style="z-index: 1; left: 10px; top: 350px; position: absolute; width: 220px; font-weight: 700;" Text="Parking Lights Reports" OnClick="ParkingLightsReportButton_Click" Width="220px" />
        <asp:Button ID="MarqueeReportsButton" runat="server" style="z-index: 1; left: 10px; top: 400px; position: absolute; font-weight: 700; width: 220px; right: 769px;" Text="Marquee Reports" OnClick="MarqueeReportsButton_Click" Width="220px" />
        <asp:Label ID="ReportsLabel" runat="server" style="z-index: 1; left: 12px; top: 100px; position: absolute; font-weight: 700; font-size: large; height: 25px;" Text="Reports"></asp:Label>
        <asp:Button ID="TempButton" runat="server" style="z-index: 1; left: 10px; top: 450px; position: absolute; width: 220px; font-weight: 700;" Text="Temperature Reports" OnClick="TempButton_Click" Width="220px" />
        <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 300px; top: 150px; position: absolute; font-weight: 700;" Text="Audit Report" OnClick="Button1_Click" Width="220px" />
        <p>
            <asp:Button ID="Button2" runat="server" style="z-index: 1; left: 300px; top: 200px; position: absolute; font-weight: 700;" Text="AHU Report" Width="220px" OnClick="Button2_Click" />
        </p>
        <p>
            <asp:Button ID="Button3" runat="server" style="z-index: 1; left: 300px; top: 250px; position: absolute; font-weight: 700;" Text="Lab Room Report" Width="220px" OnClick="Button3_Click" />
        </p>
        <p>
            <asp:Button ID="Button4" runat="server" style="z-index: 1; left: 300px; top: 350px; position: absolute; font-weight: 700;" Text="Parking Lights Report" Width="220px" OnClick="Button4_Click" />
        </p>
        <p>
            <asp:Button ID="Button5" runat="server" style="z-index: 1; left: 300px; top: 400px; position: absolute; font-weight: 700;" Text="Marquee Report" Width="220px" OnClick="Button5_Click" />
        </p>
        <p>
            <asp:Button ID="Button6" runat="server" style="z-index: 1; left: 300px; top: 450px; position: absolute; font-weight: 700;" Text="Temperature Report" Width="220px" OnClick="Button6_Click" />
        </p>
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 303px; top: 102px; position: absolute; font-weight: 700; font-size: large" Text="Todays Reports"></asp:Label>
        <asp:Button ID="KitchenReportsButton" runat="server" style="z-index: 1; left: 10px; top: 300px; position: absolute; font-weight: 700; height: 29px;" Text="Kitchen Reports" Width="220px" OnClick="KitchenReportsButton_Click" />
        <asp:Button ID="TodaysKitchenReportButton" runat="server" style="z-index: 1; left: 300px; top: 300px; position: absolute; font-weight: 700" Text="Kitchen Report" OnClick="TodaysKitchenReportButton_Click" Width="220px" />
    </form>
</body>
</html>
