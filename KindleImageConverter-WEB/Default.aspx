<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>Amazon Kindle Image Converter</title>
    <link href="~/Styles/Site.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="header">
        <center class="style1"><h1>Amazon Kindle Screensaver Converter</h1></center>
    </div>
    <div class="page">
        <div class="main">
        <center>
            <asp:FileUpload ID="pictureUpload" runat="server" />
        <br />
        <br />

    <asp:RadioButton ID="kindleRadio" runat="server" Text="Kindle (600x800)" 
        GroupName="ImageSize" />
    <asp:RadioButton ID="kindleDXRadio" runat="server" 
        Text="Kindle DX (824x1200)" GroupName="ImageSize" />
    <br />
    <br />
            <asp:Button ID="buttonConvert" runat="server" onclick="buttonConvert_Click" Text="Convert" />
        
            
         </center>
         </div>
        
    </div>
    <div class="footer">
        
    </div>
    </form>
</body>
</html>
