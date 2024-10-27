<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Simple Interest Calculator</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Simple Interest Calculator</h2>
            <p>
                Principal Amount: 
                <asp:TextBox ID="txtPrincipal" runat="server"></asp:TextBox>
            </p>
            <p>
                Interest Rate (%): 
                <asp:TextBox ID="txtRate" runat="server"></asp:TextBox>
            </p>
            <p>
                Time (Years): 
                <asp:TextBox ID="txtTime" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="btnCalculate" runat="server" Text="Calculate Interest" OnClick="btnCalculate_Click" />
            </p>
            <p>
                Result: 
                <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
            </p>
        </div>
    </form>
</body>
</html>