<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="bootstrapasp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript"language ="javascipt">
        function alert_meth()
        {
            alert("client side alert messagebox");
        }
        function confirm_meth()
        {
            if (confirm("Do you want to continue click 'yes'") == true) {
                document.WriteLine("<b> you had click on 'yes'Button</b>");
            }
            else
            {
                document.WriteLine("<b> You had click on 'No' Button</b>");
            }

        }

    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <br />
            <asp:Button OnClientClick="alert_meth()" ID="Button1" runat=""/>
            <br />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Button" />
        </div>

            </form>
           </body>
    </html>