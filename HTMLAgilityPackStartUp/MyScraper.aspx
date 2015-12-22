<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyScraper.aspx.cs" Inherits="HTMLAgilityPackStartUp.MyScraper" %> 

<!DOCTYPE html> 
<html xmlns="http://www.w3.org/1999/xhtml"> 
   <head runat="server"> <title></title> 
   </head> 
   <body>     
      <form id="form1" runat="server"> 
         <div> 
	    <asp:Label ID="InputHereLabel" runat="server" Text="Input Here" /> 
	    <asp:TextBox ID="InputTextBox" runat="server" /> <br /> 
	    <asp:Button ID="ClickMeButton" runat="server" Text="Click Me" OnClick="ClickMeButton_Click" /> <br />
             <asp:Label ID="Timeru" runat="server" /> <br /> <br /> 
            <asp:Label ID="OutputLabel" runat="server" /> 
	</div> 
      </form> 
   </body> 
</html> 