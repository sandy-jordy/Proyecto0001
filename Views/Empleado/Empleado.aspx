<%@ Page Title="Empleado" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Empleado.aspx.cs" Inherits="SIS_CA.Empleado" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <table style="padding: 20px; width: 100%" id="tabla">
        <tr>
            <td style="height: 20px"></td>
            <td style="width: 166px; height: 20px;"></td>
            <td style="height: 20px"></td>
            <td style="height: 20px"></td>
            <td style="height: 20px"></td>
            <td style="width: 11px; height: 20px;"></td>
            <td style="width: 12px; height: 20px;"></td>
            <td style="height: 20px"></td>
            <td style="height: 20px"></td>
            <td style="height: 20px; width: 67px"></td>
        </tr>
        <tr>
            <td colspan="10" style="font-family: Arial, Helvetica, sans-serif; font-size: x-large; font-weight: bold; font-style: normal; color: #000000; height: 34px;">Formulario de registro de empleados.</td>
        </tr>
        <tr>
            <td style="height: 20px">
                <asp:Label ID="id_empleado" runat="server" Text="_"></asp:Label>
            </td>
            <td style="height: 20px; width: 166px;">
                <asp:TextBox ID="txtidempleado" runat="server"></asp:TextBox>
            </td>
            <td style="height: 20px"></td>
            <td style="height: 20px"></td>
            <td style="height: 20px"></td>
            <td style="height: 20px; width: 11px;"></td>
            <td style="height: 20px; width: 12px;"></td>
            <td style="height: 20px"></td>
            <td style="height: 20px"></td>
            <td style="height: 20px; width: 67px;"></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Primer nombre:"></asp:Label>
            </td>
            <td style="width: 166px">
                <asp:TextBox ID="txtPnombre" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Primer apellido:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPapellido" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
            <td style="width: 11px">&nbsp;</td>
            <td style="width: 12px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td style="width: 67px">&nbsp;</td>
        </tr>
        <tr>
            <td style="height: 22px">
                <asp:Label ID="Label2" runat="server" Text="Segundo nombre:"></asp:Label>
            </td>
            <td style="height: 22px; width: 166px">
                <asp:TextBox ID="txtSnombre" runat="server"></asp:TextBox>
            </td>
            <td style="height: 22px">
                <asp:Label ID="Label4" runat="server" Text="Segundo apellido:"></asp:Label>
            </td>
            <td style="height: 22px">
                <asp:TextBox ID="txtSapellido" runat="server"></asp:TextBox>
            </td>
            <td style="height: 22px"></td>
            <td style="height: 22px; width: 11px"></td>
            <td style="width: 12px; height: 22px;"></td>
            <td style="height: 22px"></td>
            <td style="height: 22px"></td>
            <td style="height: 22px; width: 67px;"></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Estado:"></asp:Label>
            </td>
            <td style="width: 166px">
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem Selected="True">Activo</asp:ListItem>
                    <asp:ListItem>Inactivo</asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Fecha ingreso:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtCalendar" runat="server"></asp:TextBox>
                <asp:ImageButton ID="ImageButton1" runat="server" DescriptionUrl="~/Recursos/calendar_plus_48px.png" Height="18px" ImageUrl="~/Recursos/calendar_plus_48px.png" OnClick="ImageButton1_Click" Width="29px" />
            </td>
            <td>&nbsp;</td>
            <td style="width: 11px">&nbsp;</td>
            <td style="width: 12px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td style="width: 67px">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td style="width: 166px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="10px" NextPrevFormat="ShortMonth" Width="230px" CellPadding="1" CellSpacing="1" OnSelectionChanged="Calendar1_SelectionChanged" Visible="False">
                    <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                    <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                    <OtherMonthDayStyle ForeColor="#999999" />
                    <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                    <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                    <TodayDayStyle BackColor="#CCCCCC" />
                </asp:Calendar>
            </td>
            <td>&nbsp;</td>
            <td style="width: 11px">&nbsp;</td>
            <td style="width: 12px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td style="width: 67px">&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label7" runat="server" Text="Cargo:"></asp:Label>
            </td>
            <td style="width: 166px">
                <asp:DropDownList ID="dropCargo" runat="server">
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td style="width: 11px">&nbsp;</td>
            <td style="width: 12px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td style="width: 67px">&nbsp;</td>
        </tr>
        <tr>
            <td style="height: 20px"></td>
            <td style="width: 166px; height: 20px;">&nbsp;</td>
            <td style="height: 20px">&nbsp;</td>
            <td style="height: 20px"></td>
            <td style="height: 20px"></td>
            <td style="width: 11px; height: 20px;"></td>
            <td style="width: 12px; height: 20px;"></td>
            <td style="height: 20px"></td>
            <td style="height: 20px"></td>
            <td style="width: 67px; height: 20px;"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td style="width: 166px">
                <asp:Button ID="btnagregar" runat="server" Text="Agregar" OnClick="btnagregar_Click" />
            </td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Button" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td style="width: 11px">&nbsp;</td>
            <td style="width: 12px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td style="width: 67px">&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td style="width: 166px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td style="width: 11px">&nbsp;</td>
            <td style="width: 12px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td style="width: 67px">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="10">
                <div class="table-responsive">
                    <asp:GridView ID="GridView1" runat="server" Height="75px" Width="721px">
                    <HeaderStyle BackColor="#666666" ForeColor="White" />
                    </asp:GridView>
                </div>
                
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td style="width: 166px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td style="width: 11px">&nbsp;</td>
            <td style="width: 12px">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td style="width: 67px">&nbsp;</td>
        </tr>
    </table>
    
</asp:Content>
