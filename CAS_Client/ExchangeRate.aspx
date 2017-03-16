<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ExchangeRate.aspx.cs" Inherits="CAS_Client.ExchangeRate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family: Arial">
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Source Currency"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtFromCurrency" runat="server" ToolTip="Source Currency"></asp:TextBox>
                    </td>
                    <td></td>
                    <td><asp:Label ID="lblResult" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Target Currency"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtToCurrency" runat="server" ToolTip="Target Currency"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="Amount"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtAmount" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>

                    </td>
                    <td>
                        <asp:Button ID="btnSubmit" runat="server" Text="Get Rate" OnClick="btnSubmit_Click" />                        
                    </td>
                </tr>                
            </table>

        </div>
    </form>
</body>
</html>
