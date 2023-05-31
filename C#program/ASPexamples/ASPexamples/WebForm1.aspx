<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ASPexamples.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        .auto-style2 {
            width: 100%;
            border-collapse: collapse;
        }
        .auto-style3 {
            height: 24px;
            margin-left: 40px;
        }
        .auto-style4 {
            width: 146px;
        }
        .auto-style5 {
            height: 24px;
            width: 146px;
        }
        .auto-style6 {
            height: 105px;
            width: 146px;
        }
        .auto-style7 {
            height: 105px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            MKPITS SERVICES<br />
            FORTUNE MALLL,<br />
            SITABARDI NAGPUR</div>
        <table class="auto-style2">
            <tr>
                <td class="auto-style4">Country&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                        <asp:ListItem>India</asp:ListItem>
                        <asp:ListItem>USA</asp:ListItem>
                        <asp:ListItem>Nepal</asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">City&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:DropDownList ID="DropDownList2" runat="server">
                        <asp:ListItem>Nagpur</asp:ListItem>
                        <asp:ListItem>Amravati</asp:ListItem>
                        <asp:ListItem>Delhi</asp:ListItem>
                        <asp:ListItem>Mumbai</asp:ListItem>
                        <asp:ListItem>Texas</asp:ListItem>
                        <asp:ListItem>California</asp:ListItem>
                        <asp:ListItem>Tennessee</asp:ListItem>
                        <asp:ListItem>Rukum</asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">Course&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                <td class="auto-style7">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:CheckBoxList ID="CheckBoxList1" runat="server">
                        <asp:ListItem>Dot net</asp:ListItem>
                        <asp:ListItem>Java</asp:ListItem>
                        <asp:ListItem>Python</asp:ListItem>
                        <asp:ListItem>Angular</asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                    </asp:CheckBoxList>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5"></td>
                <td class="auto-style3">&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="OK" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="data:image/jpeg;base64,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" />
                </td>
            </tr>
            <tr>
                <td class="auto-style4">Center</td>
                <td>
                    <asp:ListBox ID="ListBox1" runat="server">
                        <asp:ListItem>Nagpur</asp:ListItem>
                        <asp:ListItem>Mumbai</asp:ListItem>
                        <asp:ListItem>Chandigarh</asp:ListItem>
                        <asp:ListItem>Bhopal</asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                    </asp:ListBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
