<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="ValenciaSustainability.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 37px;
            width: 320px;
        }
        .auto-style1 {
            font-size: x-large;
            z-index: 1;
            left: 14px;
            top: 22px;
            position: absolute;
        }
        #Submit1 {
            z-index: 1;
            left: 319px;
            top: 1353px;
            position: absolute;
            font-weight: 700;
        }
        #File1 {
            z-index: 1;
            left: 10px;
            top: 1355px;
            position: absolute;
            font-weight: 700;
            right: 722px;
        }
    </style>
</head>
<body style="height: 1500px; width: 1390px; font-size: small;">
    <form id="form1" enctype="multipart/form-data" runat="server" aria-atomic="False">


        
        <div style="height: 1500px; width: 1024px; font-weight: 700;" id="HomePageForm">
            <asp:Label ID="ValenciaCollegeLabel" runat="server" Text="VALENCIA COLLEGE" CssClass="auto-style1" ForeColor="#000099"></asp:Label>
            &nbsp;<span class="auto-style1">&nbsp;&nbsp;
        <asp:Label ID="AuditFormLabel" runat="server" Text="Sustainability Audit Form" ForeColor="#000099" style="z-index: 1; left: 308px; top: 0px; position: absolute; width: 387px"></asp:Label>
            </span>
            <br />
            &nbsp;&nbsp;&nbsp;
        <br />
            <asp:Label ID="NameLabel" runat="server" Style="font-weight: 700; z-index: 1; left: 14px; top: 50px; position: absolute; right: 1364px;" Text="Name"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="CampusLabel" runat="server" Text="Campus" Style="position: absolute; font-weight: 700; z-index: 1; left: 168px; top: 50px; bottom: 545px; right: 1188px;"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="BuildingDropDownLabel" runat="server" Style="font-weight: 700; z-index: 1; top: 50px; position: absolute; left: 293px;" Text="Building"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:Label ID="ParkingLotLabel" runat="server" Style="font-weight: 700; z-index: 1; left: 470px; top: 50px; position: absolute;" Text="Lot"></asp:Label>
            &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="ZoneLabel" runat="server" Style="font-weight: 700; z-index: 1; left: 540px; top: 50px; position: absolute;" Text="Zone"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        <asp:Label ID="AuditTypeLabel" runat="server" Text="Audit Type" Style="position: absolute; font-weight: 700; z-index: 1; left: 614px; top: 50px; bottom: 540px; width: 80px;"></asp:Label>
            <br />
            <asp:DropDownList ID="NameDropDownList" runat="server" Style="position: absolute; top: 80px; left: 10px; width: 132px; height: 19px; z-index: 1; right: 1873px;" EnableTheming="True" DataTextField="AuditorFirstName" DataValueField="AuditorFirstName">
            </asp:DropDownList>
            <asp:SqlDataSource ID="Auditor" runat="server" ConnectionString="<%$ ConnectionStrings:ValenciaLocalDBConnectionString %>" OnSelecting="Auditor_Selecting" SelectCommand="SELECT DISTINCT [AuditorFirstName], [AuditorLastName] FROM [Auditor] ORDER BY [AuditorFirstName]"></asp:SqlDataSource>
        <asp:DropDownList ID="CampusDropDownList" runat="server" Height="19px" Style="position: absolute; top: 80px; left: 168px; z-index: 1; " AutoPostBack="True" OnSelectedIndexChanged="CampusDropDownList_SelectedIndexChanged" DataTextField="CampusName" DataValueField="CampusID">
        </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
            <asp:SqlDataSource ID="Campus" runat="server" ConnectionString="<%$ ConnectionStrings:ValenciaLocalDBConnectionString %>" SelectCommand="SELECT DISTINCT [CampusName] FROM [Campus] ORDER BY [CampusName]"></asp:SqlDataSource>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="BuildingDropDownList" runat="server" Style="z-index: 1; top: 80px; position: absolute; height: 19px; width: 132px; bottom: 829px; left: 291px;" AutoPostBack="True" OnSelectedIndexChanged="BuildingDropDownList_SelectedIndexChanged" DataTextField="BuildingNumber" DataValueField="BuildingID">
                <asp:ListItem>NA</asp:ListItem>
                <asp:ListItem Value="1"></asp:ListItem>
            </asp:DropDownList>
            <asp:SqlDataSource ID="Buildings" runat="server" ConnectionString="<%$ ConnectionStrings:ValenciaLocalDBConnectionString %>" SelectCommand="SELECT DISTINCT [BuildingNumber] FROM [Building]"></asp:SqlDataSource>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
            <asp:DropDownList ID="ZoneDropDownList" runat="server" Style="z-index: 1; left: 540px; top: 80px; position: absolute; width: 50px;right: 1259px;" OnSelectedIndexChanged="ZoneDropDownList_SelectedIndexChanged" AutoPostBack="True" DataTextField="Zone" DataValueField="ZoneID">
                <asp:ListItem>NA</asp:ListItem>
                <asp:ListItem>A</asp:ListItem>
                <asp:ListItem>B</asp:ListItem>
                <asp:ListItem>C</asp:ListItem>
                <asp:ListItem>D</asp:ListItem>
                <asp:ListItem>E</asp:ListItem>
                <asp:ListItem>F</asp:ListItem>
                <asp:ListItem>G</asp:ListItem>
                <asp:ListItem>H</asp:ListItem>
                <asp:ListItem>I</asp:ListItem>
                <asp:ListItem>J</asp:ListItem>
                <asp:ListItem>K</asp:ListItem>
            </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ParkingLotDropDownList" runat="server" Style="z-index: 1; top: 80px; position: absolute; width: 50px; left: 470px; " AutoPostBack="True" DataTextField="LotName" DataValueField="ParkingLotID" OnSelectedIndexChanged="ParkingLotDropDownList_SelectedIndexChanged">
            <asp:ListItem>NA</asp:ListItem>
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
            <asp:ListItem>5</asp:ListItem>
            <asp:ListItem>6</asp:ListItem>
            <asp:ListItem>7</asp:ListItem>
            <asp:ListItem>8</asp:ListItem>
            <asp:ListItem>9</asp:ListItem>
            <asp:ListItem>10</asp:ListItem>
        </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ValenciaLocalDBConnectionString %>" SelectCommand="SELECT [LotName] FROM [ParkingLot] WHERE ([CampusID] = @CampusID)">
                <SelectParameters>
                    <asp:ControlParameter ControlID="CampusDropDownList" DefaultValue="1" Name="CampusID" PropertyName="SelectedValue" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        <asp:DropDownList ID="AuditDropDownList" runat="server" Style="position: absolute; top: 80px; z-index: 1; left: 618px;" OnSelectedIndexChanged="AuditDropDownList_SelectedIndexChanged" AutoPostBack="True" DataTextField="AuditType" DataValueField="AuditTypeID">
            <asp:ListItem>NA</asp:ListItem>
            <asp:ListItem>Break</asp:ListItem>
            <asp:ListItem>Holiday</asp:ListItem>
            <asp:ListItem>Weekday</asp:ListItem>
            <asp:ListItem>Weeknight</asp:ListItem>
            <asp:ListItem>Weekend(Day)</asp:ListItem>
            <asp:ListItem>Weekend(Night)</asp:ListItem>
            <asp:ListItem>Weeknight</asp:ListItem>
            <asp:ListItem>Remote</asp:ListItem>
        </asp:DropDownList>
            <asp:SqlDataSource ID="AuditTypes" runat="server" ConnectionString="<%$ ConnectionStrings:ValenciaLocalDBConnectionString %>" SelectCommand="SELECT [AuditType] FROM [AuditType]"></asp:SqlDataSource>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;<br />
            &nbsp;
            <asp:Label ID="KitchenLabel" runat="server" Style="font-weight: 700; position: absolute; z-index: 1; left: 14px; top: 156px" Text="Kitchen"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="AHULabel" runat="server" Style="font-weight: 700; position: absolute; z-index: 1; left: 171px; top: 156px" Text="Air Handler"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
            <asp:CheckBoxList ID="AHUCheckBoxList" runat="server" Style="z-index: 1; left: 167px; top: 201px; position: absolute; height: 188px; width: 122px" OnSelectedIndexChanged="AHUCheckBoxList_SelectedIndexChanged" AutoPostBack="True">
                <asp:ListItem>Filter</asp:ListItem>
                <asp:ListItem>Water Leak</asp:ListItem>
                <asp:ListItem>Air Leak</asp:ListItem>
                <asp:ListItem>Noise</asp:ListItem>
                <asp:ListItem>VFD</asp:ListItem>
                <asp:ListItem>In Hand</asp:ListItem>
                <asp:ListItem>Error</asp:ListItem>
                <asp:ListItem>Other/Notes</asp:ListItem>
            </asp:CheckBoxList>
            <asp:SqlDataSource ID="AirHandler" runat="server" ConnectionString="<%$ ConnectionStrings:ValenciaLocalDBConnectionString %>" SelectCommand="SELECT [Filter], [AHUNotes], [AHUWaterLeak], [AirLeak], [Noise], [VFD], [InHand], [Error], [AHUOther] FROM [Audit]"></asp:SqlDataSource>
            <asp:CheckBoxList ID="LabCheckBoxList" runat="server" Style="position: absolute; top: 474px; left: 323px; z-index: 5; height: 132px; width: 139px" OnSelectedIndexChanged="LabCheckBoxList_SelectedIndexChanged">
                <asp:ListItem>Computers On</asp:ListItem>
                <asp:ListItem>TVs On</asp:ListItem>
                <asp:ListItem>Projectors On</asp:ListItem>
                <asp:ListItem>Lights On</asp:ListItem>
                <asp:ListItem>Other/Notes</asp:ListItem>
            </asp:CheckBoxList>
            <asp:Label ID="ParkingLightsLabel" runat="server" Style="font-weight: 700; position: absolute; z-index: 1; left: 11px; top: 429px" Text="Parking Lights"></asp:Label>
            <asp:Label ID="TempLabel" runat="server" Style="font-weight: 700; position: absolute; z-index: 1; left: 171px; top: 429px" Text="Temperature"></asp:Label>
            <asp:CheckBoxList ID="TempCheckBoxList" runat="server" Style="position: absolute; top: 474px; left: 166px; z-index: 3; height: 106px; width: 176px; right: 1029px;" OnSelectedIndexChanged="TempCheckBoxList_SelectedIndexChanged">
                <asp:ListItem>Temp Too Cold</asp:ListItem>
                <asp:ListItem>Temp Too Hot</asp:ListItem>
                <asp:ListItem>Thermostat Broken</asp:ListItem>
                <asp:ListItem>Other/Notes</asp:ListItem>
            </asp:CheckBoxList>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="LabLabel" runat="server" Style="font-weight: 700; position: absolute; z-index: 1; left: 328px; top: 429px; right: 977px;" Text="Computer Lab"></asp:Label>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <h1>
            <asp:TextBox ID="TVsWattsTextBox" runat="server" style="z-index: 1; left: 245px; top: 706px; position: absolute; width: 88px">125</asp:TextBox>
            </h1>
            <asp:Label ID="ListBoxLabel" runat="server" 
                Style="z-index: 1; left: 786px; top: 50px; position: absolute; font-weight: 700; right: 457px; width: 144px;" 
                Text="Current Lab"></asp:Label>
            <asp:Label ID="EnergySavingsLabel" runat="server" style="z-index: 1; left: 232px; top: 644px; position: absolute; color: #000099; font-size: large; background-color: #FFFFFF" Text="Electric Use Savings Calculation" ForeColor="#000099"></asp:Label>
            <asp:TextBox ID="CompWattsTextBox" runat="server" style="z-index: 1; left: 117px; top: 708px; position: absolute; width: 88px">65</asp:TextBox>
            <asp:Label ID="WattsUsedLabel" runat="server" style="z-index: 1; left: 13px; top: 714px; position: absolute" Text="Watts Used"></asp:Label>
            <asp:Label ID="TimeUsedLabel" runat="server" style="z-index: 1; left: 13px; top: 752px; position: absolute" Text="Hours Used"></asp:Label>
            <asp:TextBox ID="ComputersTimeTextBox" runat="server" OnTextChanged="TextBox2_TextChanged" style="z-index: 1; left: 116px; top: 744px; position: absolute; width: 88px; right: 1069px">0</asp:TextBox>
            <br />

            <asp:TextBox ID="LightsWattsUsedTextBox" runat="server" style="z-index: 1; left: 487px; top: 704px; position: absolute" Width="88px">60</asp:TextBox>
            <asp:TextBox ID="LightsTimeUsedTextBox" runat="server" style="z-index: 1; left: 487px; top: 741px; position: absolute; width: 88px">0</asp:TextBox>

            <h1>
                <asp:Label ID="CWHLabel" runat="server" style="z-index: 1; left: 639px; top: 644px; position: absolute; font-size: large" Text="Cost KWH" BackColor="White" ForeColor="#000099"></asp:Label>
                <asp:Label ID="EnergyCostLabel" runat="server" style="z-index: 1; left: 641px; top: 743px; position: absolute; font-size: large; bottom: 313px" Text="Daily Cost"></asp:Label>
                <asp:Label ID="ComputerElectricLabel" runat="server" style="z-index: 1; left: 121px; top: 681px; position: absolute; font-size: medium" Text="Computers"></asp:Label>
                <asp:Label ID="ProjectorEnergyUseLabel" runat="server" style="z-index: 1; left: 367px; top: 680px; position: absolute; font-size: medium; width: 40px" Text="Projector"></asp:Label>
                <asp:TextBox ID="ProjectorWattsUsedTextBox" runat="server" style="z-index: 1; left: 367px; top: 706px; position: absolute; width: 88px">260</asp:TextBox>
                <asp:TextBox ID="ProjectorTimeUsedTextBox" runat="server" style="z-index: 1; left: 366px; top: 743px; position: absolute; width: 88px">0</asp:TextBox>
                <asp:TextBox ID="EnergyCostTextBox" runat="server" OnTextChanged="EnergyUseTextBox_TextChanged" style="z-index: 1; left: 641px; top: 774px; position: absolute; width: 88px"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" BackColor="#65C5F3" Font-Bold="True" ForeColor="#0033CC" OnClick="Button1_Click" style="z-index: 1; width: 95px; left: 641px; top: 709px; position: absolute; right: 539px" Text="Calculate" />
            </h1>
            <br />

            <asp:TextBox ID="TVsTimeTextBox" runat="server" style="z-index: 1; left: 246px; top: 744px; position: absolute; width: 88px; right: 939px">0</asp:TextBox>

            <h1>&nbsp;</h1>
            <br />

            <h1>
                <asp:Label ID="LightsEnergyUseLabel" runat="server" style="z-index: 1; left: 487px; top: 680px; position: absolute; font-size: medium; height: 23px" Text="Lights"></asp:Label>
            </h1>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="z-index: 1; left: 625px; top: 1282px; position: absolute; font-weight: 700;" Text="Management" Width="200px" />
            <br />

            <h1>
                <asp:Label ID="TvsEnergyUseLabel" runat="server" style="z-index: 1; left: 245px; top: 680px; position: absolute; font-size: medium" Text="TVs"></asp:Label>
            </h1>
            <asp:TextBox ID="CostPerKWHTextBox" runat="server" style="z-index: 1; left: 641px; top: 674px; position: absolute; width: 88px;">28.7</asp:TextBox>
            <br />

            <h1>&nbsp;</h1>
            <br />

            <h1>&nbsp;</h1>
            <br />




            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CheckBoxList ID="ParkingLightsCheckBoxList" runat="server" Style="height: 158px; width: 142px; position: absolute; top: 474px; left: 9px; z-index: 2" OnSelectedIndexChanged="ParkingLightsCheckBoxList_SelectedIndexChanged">
            <asp:ListItem>Security Mode</asp:ListItem>
            <asp:ListItem>Locked</asp:ListItem>
            <asp:ListItem>On Daytime</asp:ListItem>
            <asp:ListItem>On Night</asp:ListItem>
            <asp:ListItem>Broken Bulb</asp:ListItem>
            <asp:ListItem>Other/Notes</asp:ListItem>
        </asp:CheckBoxList>
            <asp:CheckBoxList ID="IrrigationCheckBoxList" runat="server" Style="position: absolute; top: 200px; left: 321px; z-index: 4; height: 188px; width: 162px" OnSelectedIndexChanged="IrrigationCheckBoxList_SelectedIndexChanged" AutoPostBack="True">
                <asp:ListItem>Head Adjustment</asp:ListItem>
                <asp:ListItem>Broken Head</asp:ListItem>
                <asp:ListItem>On Daytime</asp:ListItem>
                <asp:ListItem>On Night</asp:ListItem>
                <asp:ListItem>Manual Override</asp:ListItem>
                <asp:ListItem>Water Leak</asp:ListItem>
                <asp:ListItem>Other/Notes</asp:ListItem>
            </asp:CheckBoxList>
            <asp:SqlDataSource ID="IrrigationCBDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:ValenciaLocalDBConnectionString %>" SelectCommand="SELECT [IssueName] FROM [Issue]"></asp:SqlDataSource>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="IrrigationLabel" runat="server" Style="font-weight: 700; position: absolute; z-index: 1; left: 328px; top: 157px; bottom: 488px" Text="Irrigation"></asp:Label>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="NumberCompOnLabel" runat="server" Style="z-index: 1; left: 540px; top: 480px; position: absolute; width: 110px;" Text="#Comp"></asp:Label>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
            <asp:DropDownList ID="CompOnDropDownList" runat="server" Style="z-index: 1; left: 487px; top: 480px; position: absolute; width: 40px;" DataTextField="NumberComputersOn" DataValueField="NumberComputersOnID" AutoPostBack="True">
                <asp:ListItem>0</asp:ListItem>
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem>7</asp:ListItem>
                <asp:ListItem>8</asp:ListItem>
                <asp:ListItem>9</asp:ListItem>
                <asp:ListItem>10</asp:ListItem>
                <asp:ListItem>11</asp:ListItem>
                <asp:ListItem>12</asp:ListItem>
                <asp:ListItem>13</asp:ListItem>
                <asp:ListItem>14</asp:ListItem>
                <asp:ListItem>15</asp:ListItem>
                <asp:ListItem>16</asp:ListItem>
                <asp:ListItem>17</asp:ListItem>
                <asp:ListItem>18</asp:ListItem>
                <asp:ListItem>19</asp:ListItem>
                <asp:ListItem>20</asp:ListItem>
                <asp:ListItem>21</asp:ListItem>
                <asp:ListItem>22</asp:ListItem>
                <asp:ListItem>23</asp:ListItem>
                <asp:ListItem>24</asp:ListItem>
                <asp:ListItem>25</asp:ListItem>
                <asp:ListItem>26</asp:ListItem>
                <asp:ListItem>27</asp:ListItem>
                <asp:ListItem>28</asp:ListItem>
                <asp:ListItem>29</asp:ListItem>
                <asp:ListItem>30</asp:ListItem>
                <asp:ListItem>31</asp:ListItem>
                <asp:ListItem>32</asp:ListItem>
                <asp:ListItem>33</asp:ListItem>
                <asp:ListItem>34</asp:ListItem>
                <asp:ListItem>35</asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
            <asp:DropDownList ID="TvsOnDropDownList" runat="server" Style="z-index: 1; left: 486px; top: 520px; position: absolute; width: 40px;" OnSelectedIndexChanged="TvsOnDropDownList_SelectedIndexChanged" DataTextField="NumberTvsOn" DataValueField="NumberTvsOnID">
                <asp:ListItem>0</asp:ListItem>
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem>7</asp:ListItem>
                <asp:ListItem>8</asp:ListItem>
                <asp:ListItem>9</asp:ListItem>
                <asp:ListItem>10</asp:ListItem>
                <asp:ListItem>11</asp:ListItem>
                <asp:ListItem>12</asp:ListItem>
                <asp:ListItem>13</asp:ListItem>
                <asp:ListItem>14</asp:ListItem>
                <asp:ListItem>15</asp:ListItem>
                <asp:ListItem>16</asp:ListItem>
                <asp:ListItem>17</asp:ListItem>
                <asp:ListItem>18</asp:ListItem>
                <asp:ListItem>19</asp:ListItem>
                <asp:ListItem>20</asp:ListItem>
                <asp:ListItem>21</asp:ListItem>
                <asp:ListItem>22</asp:ListItem>
                <asp:ListItem>23</asp:ListItem>
                <asp:ListItem>24</asp:ListItem>
                <asp:ListItem>25</asp:ListItem>
                <asp:ListItem>26</asp:ListItem>
                <asp:ListItem>27</asp:ListItem>
                <asp:ListItem>28</asp:ListItem>
                <asp:ListItem>29</asp:ListItem>
                <asp:ListItem>30</asp:ListItem>
                <asp:ListItem>31</asp:ListItem>
                <asp:ListItem>32</asp:ListItem>
                <asp:ListItem>33</asp:ListItem>
                <asp:ListItem>34</asp:ListItem>
                <asp:ListItem>35</asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <br />
            <asp:DropDownList ID="ProjOnDropDownList" runat="server" Style="z-index: 1; left: 487px; top: 560px; position: absolute; width: 40px;" DataTextField="NumberProjectorsOn" DataValueField="NumberProjectorsOnID">
                <asp:ListItem>0</asp:ListItem>
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem>7</asp:ListItem>
                <asp:ListItem>8</asp:ListItem>
                <asp:ListItem>9</asp:ListItem>
                <asp:ListItem>10</asp:ListItem>
                <asp:ListItem>11</asp:ListItem>
                <asp:ListItem>12</asp:ListItem>
                <asp:ListItem>13</asp:ListItem>
                <asp:ListItem>14</asp:ListItem>
                <asp:ListItem>15</asp:ListItem>
                <asp:ListItem>16</asp:ListItem>
                <asp:ListItem>17</asp:ListItem>
                <asp:ListItem>18</asp:ListItem>
                <asp:ListItem>19</asp:ListItem>
                <asp:ListItem>20</asp:ListItem>
                <asp:ListItem>21</asp:ListItem>
                <asp:ListItem>22</asp:ListItem>
                <asp:ListItem>23</asp:ListItem>
                <asp:ListItem>24</asp:ListItem>
                <asp:ListItem>25</asp:ListItem>
                <asp:ListItem>26</asp:ListItem>
                <asp:ListItem>27</asp:ListItem>
                <asp:ListItem>28</asp:ListItem>
                <asp:ListItem>29</asp:ListItem>
                <asp:ListItem>30</asp:ListItem>
                <asp:ListItem>31</asp:ListItem>
                <asp:ListItem>32</asp:ListItem>
                <asp:ListItem>33</asp:ListItem>
                <asp:ListItem>34</asp:ListItem>
                <asp:ListItem>35</asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <br />
            <asp:DropDownList ID="LightsOnDropDownList" runat="server" Style="z-index: 1; left: 487px; top: 600px; position: absolute; width: 40px;" DataTextField="NumberLightsOn" DataValueField="NumberLightsOnID">
                <asp:ListItem>0</asp:ListItem>
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem>7</asp:ListItem>
                <asp:ListItem>8</asp:ListItem>
                <asp:ListItem>9</asp:ListItem>
                <asp:ListItem>10</asp:ListItem>
                <asp:ListItem>11</asp:ListItem>
                <asp:ListItem>12</asp:ListItem>
                <asp:ListItem>13</asp:ListItem>
                <asp:ListItem>14</asp:ListItem>
                <asp:ListItem>15</asp:ListItem>
                <asp:ListItem>16</asp:ListItem>
                <asp:ListItem>17</asp:ListItem>
                <asp:ListItem>18</asp:ListItem>
                <asp:ListItem>19</asp:ListItem>
                <asp:ListItem>20</asp:ListItem>
                <asp:ListItem>21</asp:ListItem>
                <asp:ListItem>22</asp:ListItem>
                <asp:ListItem>23</asp:ListItem>
                <asp:ListItem>24</asp:ListItem>
                <asp:ListItem>25</asp:ListItem>
                <asp:ListItem>26</asp:ListItem>
                <asp:ListItem>27</asp:ListItem>
                <asp:ListItem>28</asp:ListItem>
                <asp:ListItem>29</asp:ListItem>
                <asp:ListItem>30</asp:ListItem>
                <asp:ListItem>31</asp:ListItem>
                <asp:ListItem>32</asp:ListItem>
                <asp:ListItem>33</asp:ListItem>
                <asp:ListItem>34</asp:ListItem>
                <asp:ListItem>35</asp:ListItem>
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
            <asp:Label ID="ItemsOnLabel" runat="server" Style="z-index: 1; left: 487px; top: 429px; position: absolute" Text="Items On"></asp:Label>
            <br />
            <br />
            <br />

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="TVsOnLabel" runat="server" Style="z-index: 1; left: 540px; top: 520px; position: absolute" Text="#TV"></asp:Label>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="SubmitButton" runat="server" Style="z-index: 1; left: 734px; top: 1200px; position: absolute; font-weight: 700;" Text="Submit Data" OnClick="SubmitButton_Click" Width="200px" />
            <asp:Label ID="MarqueeLabel" runat="server" Style="z-index: 1; left: 637px; top: 429px; position: absolute; font-weight: 700; height: 19px;" Text="Marquee"></asp:Label>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ClearFormButton" runat="server" Style="z-index: 1; left: 10px; top: 1200px; position: absolute; font-weight: 700;" Text="Clear Form" OnClick="ClearFormButton_Click" Width="200px" />
            <asp:Label ID="ProjectorsOnLabel" runat="server" Style="z-index: 1; left: 540px; top: 560px; position: absolute" Text="# Proj"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label7" runat="server" Style="z-index: 1; left: 541px; top: 600px; position: absolute" Text="#Lights"></asp:Label>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" Style="font-weight: 700; z-index: 1; left: 413px; top: 896px; position: absolute" Text="Parking Light Notes"></asp:Label>
            <br />
            &nbsp;
            <asp:Label ID="KitchenNotesLabel" runat="server" Style="font-weight: 700; z-index: 1; left: 15px; top: 808px; position: absolute" Text="Kitchen Notes"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CheckBoxList ID="KitchenCheckBoxList" runat="server" Height="184px" Style="position: absolute; top: 201px; left: 9px; z-index: 1; height: 188px; width: 156px; bottom: 208px; right: 1116px;" OnSelectedIndexChanged="KitchenCheckBoxList_SelectedIndexChanged" AutoPostBack="True" DataTextField="WaterRunning" DataValueField="WaterRunning">
            <asp:ListItem>Water Running</asp:ListItem>
            <asp:ListItem>Water Leak</asp:ListItem>
            <asp:ListItem>Lights On</asp:ListItem>
            <asp:ListItem>Fridge Open</asp:ListItem>
            <asp:ListItem>Freezer Open</asp:ListItem>
            <asp:ListItem>Other/Notes</asp:ListItem>
        </asp:CheckBoxList>
            <asp:SqlDataSource ID="KitchenIssue" runat="server" ConnectionString="<%$ ConnectionStrings:ValenciaLocalDBConnectionString %>" SelectCommand="SELECT [WaterRunning], [KitchenWaterLeak], [KitchenLightsOn], [FridgeOpen], [FreezerOpen], [KitchenOther] FROM [Audit]"></asp:SqlDataSource>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Calendar ID="Calendar1" runat="server" Style="height: 211px; width: 219px; position: absolute; top: 162px; left: 506px; z-index: 1" ShowNextPrevMonth="False" OnSelectionChanged="Calendar1_SelectionChanged" SelectedDate="04/06/2017 10:14:10">
            <SelectedDayStyle BackColor="#00CCFF" />
            <SelectorStyle BackColor="#65C5F3" />
            </asp:Calendar>
            <asp:CheckBoxList ID="MarqueeCheckBoxList" runat="server" Style="z-index: 1; left: 632px; top: 474px; position: absolute; height: 106px; width: 137px" OnSelectedIndexChanged="MarqueeCheckBoxList_SelectedIndexChanged" BackColor="White">
                <asp:ListItem>On Daytime</asp:ListItem>
                <asp:ListItem>On Night</asp:ListItem>
                <asp:ListItem>Broken Pixels</asp:ListItem>
                <asp:ListItem>Other/Notes</asp:ListItem>
            </asp:CheckBoxList>
            <br />
            <br />
            <br />
            <asp:FileUpload ID="ImageFileUpload" runat="server" AllowMultiple="True" Style="position: absolute; top: 1200px; left: 247px; z-index: 1; width: 274px; font-weight: 700; right: 674px;" />

            <asp:Button ID="NewAuditFormButton" runat="server" style="z-index: 1; left: 480px; top: 1200px; position: absolute; font-weight: 700" Text="New Audit" Width="200px" OnClick="NewAuditFormButton_Click" />

            <br />
            <asp:Label ID="Label2" runat="server" Style="font-weight: 700; z-index: 1; left: 14px; top: 896px; position: absolute" Text="Irrigation Notes"></asp:Label>
            <br />
            <br />
            <asp:Label ID="AHUNotesLabel" runat="server" Style="z-index: 1; left: 414px; top: 808px; position: absolute; font-weight: 700;" Text="Air Handler Notes"></asp:Label>
            <asp:TextBox ID="AHUTextBox" runat="server" Style="z-index: 1; left: 414px; top: 837px; position: absolute; width: 345px; right: 516px" TextMode="MultiLine" ForeColor="Blue"></asp:TextBox>
            <asp:TextBox ID="IrrigationTextBox" runat="server" TextMode="MultiLine" Width="345px" Style="z-index: 1; left: 14px; top: 926px; position: absolute" ForeColor="Blue"></asp:TextBox>
            <asp:TextBox ID="ParkingLightsTextBox" runat="server" Style="z-index: 1; left: 414px; top: 926px; position: absolute; width: 345px;" TextMode="MultiLine" ForeColor="Blue"></asp:TextBox>
            <br />

            <asp:Label ID="Label4" runat="server" Style="z-index: 1; left: 14px; top: 987px; position: absolute; font-weight: 700" Text="Temperature Notes"></asp:Label>
            <asp:Label ID="Label5" runat="server" Text="Marquee Notes" Style="z-index: 1; left: 14px; top: 1080px; position: absolute; font-weight: 700"></asp:Label>
            <asp:Label ID="LabNotesTextBoxLabel" runat="server" Style="z-index: 1; left: 416px; top: 987px; position: absolute; font-weight: 700" Text="Computer Lab Notes"></asp:Label>
            <asp:TextBox ID="TempTextBox" runat="server" Style="z-index: 1; left: 14px; top: 1015px; position: absolute; width: 345px" TextMode="MultiLine" ForeColor="Blue"></asp:TextBox>

            <asp:TextBox ID="MarqueeTextBox" runat="server" Style="z-index: 1; left: 14px; top: 1108px; position: absolute; width: 348px; right: 1023px;" TextMode="MultiLine" ForeColor="Blue"></asp:TextBox>

            <asp:TextBox ID="LabTextBox" runat="server" Style="z-index: 1; left: 414px; top: 1015px; position: absolute; width: 345px; right: 676px;" TextMode="MultiLine" ForeColor="Blue"></asp:TextBox>

            <asp:Label ID="Label6" runat="server" Style="z-index: 1; left: 416px; top: 1080px; position: absolute; font-weight: 700" Text="Other Notes"></asp:Label>

        </div>
        <asp:TextBox ID="KitchenTextBox" runat="server" Style="z-index: 1; left: 13px; top: 837px; position: absolute; width: 345px; right: 917px;" TextMode="MultiLine" ForeColor="Blue"></asp:TextBox>
        <asp:TextBox ID="OtherTextBox" runat="server" Style="z-index: 1; left: 416px; top: 1104px; position: absolute; width: 345px;" TextMode="MultiLine" ForeColor="Blue"></asp:TextBox>
        <asp:ListBox ID="RoomListBox" runat="server" 
            
            style="z-index: 1; left: 785px; top: 81px; position: absolute; height: 1070px; width: 149px;" 
            BackColor="#65C5F3" 
            DataTextField="RoomNumber" DataValueField="RoomNumberID" ForeColor="Black" 
            OnSelectedIndexChanged="ListBoxEast_SelectedIndexChanged" AutoPostBack="True"
            >
            <asp:ListItem>NA</asp:ListItem>
        </asp:ListBox>

            <asp:SqlDataSource ID="Rooms" runat="server" ConnectionString="<%$ ConnectionStrings:ValenciaLocalDBConnectionString %>" SelectCommand="SELECT [RoomNumber] FROM [Room] WHERE ([BuildingID] = @BuildingID)">
                <SelectParameters>
                    <asp:ControlParameter ControlID="BuildingDropDownList" DefaultValue="1" Name="BuildingID" PropertyName="SelectedValue" Type="Int32" />
                </SelectParameters>
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>



    </form>
</body>
</html>
