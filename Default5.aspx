<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default5.aspx.cs" Inherits="Default5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><br />
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <br />
         <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Upload File" Width="143px" />
    </div>
       
    </form>
</body>
</html>
