<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Customer_Purchase_History.aspx.cs" Inherits="FinalASPGroupProj.Customer_Purchase_History" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <div style="margin-left:20%;">

       <p>
           <br />
    </p>
    <p>
        <span style="font-size: x-large">Customer Id:</span><asp:TextBox ID="txtCustIdGridView" runat="server" style="font-size: small" Width="178px" OnTextChanged="txtCustIdGridView_TextChanged"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:GridView ID="GridView1" runat="server" Width="611px">
        </asp:GridView>
    </p>
    <p>
        <span style="font-size: x-large">Total Base Price = <asp:Label ID="lblTotal" runat="server"></asp:Label>
        </span>
    </p>
    <p>
        &nbsp;</p>
    <p>
    </p>
    <p>
    </p>
    

    
           </div>
</asp:Content>
