<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Customer_Registered.aspx.cs" Inherits="FinalASPGroupProj.Customer_Registered" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    

    <p>
    <br />
</p>
<p>
    <strong style="margin-left: 240px"><span style="font-size: large">&nbsp;<span style="color: #00CC00">Your registration was successful.</span> </span></strong>&nbsp;&nbsp;
</p>
<p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Your user ID is:&nbsp;&nbsp;
    <asp:TextBox ID="txtBoxID" runat="server"></asp:TextBox>
    &nbsp;</p>
<p class="text-center">
    <asp:Button ID="btnHist" runat="server" OnClick="Button1_Clic" Text="View Purchase History" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnUpd" runat="server" Text="Update Customer Info" OnClick="Button2_Clic" />
</p>
<p class="text-center">
    &nbsp;</p>
<p class="text-center">
    &nbsp;</p>
<p class="text-center">
    &nbsp;</p>
<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
<p>
</p>
    
    

</asp:Content>
