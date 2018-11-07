<%@ Page Language="vb" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v13.1, Version=13.1.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
	Namespace="DevExpress.Web.ASPxEditors" TagPrefix="dx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
</head>
<body>
	<form id="form1" runat="server">
	<table>
		<tr>
			<td>
				<strong>x:</strong>
				<dx:ASPxTextBox ID="txt1" runat="server" Width="170px" Text="5">
				</dx:ASPxTextBox>
			</td>
			<td>
				<strong>y:</strong>
				<dx:ASPxTextBox ID="txt2" runat="server" Width="170px" Text="10">
				</dx:ASPxTextBox>
			</td>
		</tr>
		<tr>
			<td>
				<dx:ASPxButton ID="btn" runat="server" Text="Check" OnClick="btn_Click">
				</dx:ASPxButton>
			</td>
			<td>
				<dx:ASPxLabel ID="lblResult" runat="server" Text="Check the expression">
				</dx:ASPxLabel>
			</td>
		</tr>
	</table>
	<dx:ASPxFilterControl ID="fc" runat="server" FilterExpression="[x] &gt; 3 And [y] &lt; 13">
		<Columns>
			<dx:FilterControlColumn ColumnType="Integer" DisplayName="x" PropertyName="x">
			</dx:FilterControlColumn>
			<dx:FilterControlColumn ColumnType="Integer" DisplayName="y" PropertyName="y">
			</dx:FilterControlColumn>
		</Columns>
	</dx:ASPxFilterControl>
	</form>
</body>
</html>
