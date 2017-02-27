<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Customer_Login.aspx.cs" Inherits="FinalASPGroupProj.Customer_Login" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    
    
    <div>

    <p>
        <strong>
    <br />
        </strong>
</p>
<p class="text-center">
    &nbsp;</p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <table class="nav-justified" style="height: 77px">
            <tr>
                <td style="height: 63px; width: 267px; margin-left: 40px;" class="text-right">
                    &nbsp;</td>
                <td style="height: 63px; width: 221px">
                    <div class="text-left">
                        <br />
                        <strong>CustomerID</strong></div>
    <asp:TextBox ID="txtBoxID" runat="server" Width="164px" CssClass="form-control" style="margin-top: 0"></asp:TextBox>
                </td>
                <td style="height: 63px"><strong>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtBoxID" Display="Dynamic" ErrorMessage="Customer Id required"></asp:RequiredFieldValidator>
                    </strong></td>
            </tr>
        </table>
<p>
    &nbsp;</p>

    &nbsp;<table class="nav-justified" style="height: 80px">

        <tr>
            <td style="width: 268px">
                &nbsp;</td>
                <td style="height: 63px; width: 224px;">
                    <div class="text-left">
                        <asp:Label ID="Password0" runat="server" Text="Password"></asp:Label>
                    </div>
                    <div class="text-center">
    <asp:TextBox ID="txtboxPass" runat="server" Width="167px" CssClass="form-control"></asp:TextBox>
                    </div>
    
            
            <td class="text-left" style="margin-left: 920px">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtboxPass" Display="Dynamic" ErrorMessage="Password field is empty"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
        </tr>
    
    </table>
    

<p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</p>
<p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="clicke" BorderStyle="None" Width="146px" />
</p>
<p>
    &nbsp;</p>
    
    

    </div>

</asp:Content>
