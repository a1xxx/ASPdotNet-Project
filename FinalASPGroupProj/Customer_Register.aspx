

<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Customer_Register.aspx.cs" Inherits="FinalASPGroupProj.Customer_Register1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <div style="margin-left:20%;">

     <div class="form-group">
					&nbsp;
                    <br />
                    <br />
					<label for="inputName" class="control-label">First name</label><br />
                    <table class="nav-justified">
                        <tr>
                            <td style="width: 370px">
                    <asp:TextBox ID="txtBoxFirstName" runat="server" Height="28px" Width="350px"></asp:TextBox>
				            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtBoxFirstName" Display="Dynamic" ErrorMessage="First Name is Required" ForeColor="#FF6600"></asp:RequiredFieldValidator>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
				</div>
			
            	<div class="form-group">
					<label for="inputName" class="control-label">Last name</label>
	                <br />
                    <table class="nav-justified">
                        <tr>
                            <td style="width: 370px">
                    <asp:TextBox ID="txtBoxLastName" runat="server" Height="28px" Width="350px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtBoxLastName" Display="Dynamic" ErrorMessage="Last Name is Required" ForeColor="#FF6600"></asp:RequiredFieldValidator>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                    <br />
                    <label for="inputName" class="control-label">Password</label><br />
                    <table class="nav-justified">
                        <tr>
                            <td style="width: 370px">
                    <asp:TextBox ID="txtBoxPassword" runat="server" Height="28px" Width="350px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtBoxPassword" Display="Dynamic" ErrorMessage="Password is Required" ForeColor="#FF6600"></asp:RequiredFieldValidator>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                    <br /><strong>Confirm Password</strong><br />
                    <table class="nav-justified">
                        <tr>
                            <td style="width: 370px">
                    <asp:TextBox ID="txtBoxConfirmPass" runat="server" Height="28px" Width="350px"></asp:TextBox>
            	            </td>
                            <td class="modal-sm" style="width: 275px">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtBoxConfirmPass" Display="Dynamic" ErrorMessage="Confirm Password is Required is Required" ForeColor="#FF6600"></asp:RequiredFieldValidator>
                            </td>
                            <td>
                                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtBoxPassword" ControlToValidate="txtBoxConfirmPass" Display="Dynamic" ErrorMessage="Passwords dont match up, please reenter" ForeColor="#FF6600"></asp:CompareValidator>
                            </td>
                        </tr>
                    </table>
            	</div>
				
			<div class="form-group">                
	                &nbsp;<label class="auto-style3">Address</label>
                    <br />
                    <table class="nav-justified">
                        <tr>
                            <td style="width: 370px">
                    <asp:TextBox ID="txtBoxAddress" runat="server" Height="28px" Width="350px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtBoxAddress" Display="Dynamic" ErrorMessage="Address is required" ForeColor="#FF6600"></asp:RequiredFieldValidator>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
    </div>
		
			
			
					
				<div class="form-group">                
	                <label class="auto-style4">City</label> 
	                <br />
                    <table class="nav-justified">
                        <tr>
                            <td style="width: 370px">
                    <asp:TextBox ID="txtBoxCity" runat="server" Height="28px" Width="350px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtBoxCity" Display="Dynamic" ErrorMessage="City field is Required" ForeColor="#FF6600"></asp:RequiredFieldValidator>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
    </div>
			
			
			
					
				<div class="form-group">                
	                <label>Province/State</label> 
	                <br />
                    <table class="nav-justified">
                        <tr>
                            <td style="width: 370px">
                    <asp:TextBox ID="txtBoxProv" runat="server" Height="28px" Width="350px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtBoxProv" Display="Dynamic" ErrorMessage="Province field is Required" ForeColor="#FF6600"></asp:RequiredFieldValidator>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
    </div>
		
				<div class="form-group">                
	                <label>PostalCode</label> 
	                <br />
                    <table class="nav-justified">
                        <tr>
                            <td style="width: 370px">
                    <asp:TextBox ID="txtBoxPostal" runat="server" Height="28px" Width="350px"></asp:TextBox>
                            </td>
                            <td style="width: 200px">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtBoxPostal" Display="Dynamic" ErrorMessage="Postal Code is Required" ForeColor="#FF6600"></asp:RequiredFieldValidator>
                            </td>
                            <td>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtBoxPostal" Display="Dynamic" ErrorMessage="Please Enter Postal Code ex. A1A1A1" ForeColor="#FF6600" ValidationExpression="[ABCEGHJKLMNPRSTVXY][0-9][ABCEGHJKLMNPRSTVWXYZ] ?[0-9][ABCEGHJKLMNPRSTVWXYZ][0-9]"></asp:RegularExpressionValidator>
                            </td>
                        </tr>
                    </table>
    </div>
				
		
					
					
				<div class="form-group">                
	                <label>Country</label>
                    <br />
                    <table class="nav-justified">
                        <tr>
                            <td style="width: 370px">
                    <asp:TextBox ID="txtBoxCountry" runat="server" Height="28px" Width="350px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtBoxCountry" Display="Dynamic" ErrorMessage="Country field is Required" ForeColor="#FF6600"></asp:RequiredFieldValidator>
                            </td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
    </div>
				
				
			<div class="form-group">                
	                <label>Home Phone Number</label>
                    <br />
                    <table class="nav-justified">
                        <tr>
                            <td style="width: 370px">
                    <asp:TextBox ID="txtBoxHomePhone" runat="server" Height="28px" Width="350px"></asp:TextBox>
                            </td>
                            <td style="width: 200px">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="txtBoxHomePhone" Display="Dynamic" ErrorMessage="Home Phone is Required" ForeColor="#FF6600"></asp:RequiredFieldValidator>
                            </td>
                            <td>
                                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtBoxHomePhone" ErrorMessage="Please enter a Numeric phone number like 403-926-4747" ForeColor="#FF6600" ValidationExpression="^(\+\d{1,2}\s)?\(?\d{3}\)?[\s.-]\d{3}[\s.-]\d{4}$"></asp:RegularExpressionValidator>
                            </td>
                        </tr>
                    </table>
    </div>			
			
				<div class="form-group">                
	                <label class="auto-style6">Business Phone Number</label> 
	                <br />
	                <table class="nav-justified">
                        <tr>
                            <td style="width: 370px">
	                <asp:TextBox ID="txtBoxBusPhone" runat="server" Height="28px" Width="350px" OnTextChanged="txtBoxBusPhone_TextChanged"></asp:TextBox>
                            </td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
    </div>	
						
				<div class="form-group">                
	                <label class="auto-style5">Customer Email</label> 
	                <br />
                    <table class="nav-justified">
                        <tr>
                            <td style="width: 371px">
                    <asp:TextBox ID="txtBoxCustEmail" runat="server" Height="28px" Width="350px"></asp:TextBox>
                            </td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
    </div>	
				
				<div class="form-group">                
	                <label class="auto-style7">Customer About</label> 
	                <br />
                    <table class="nav-justified">
                        <tr>
                            <td style="width: 370px">
                    <asp:TextBox ID="txtBoxCustAbout" runat="server" Height="28px" Width="350px"></asp:TextBox>
                            </td>
                            <td>
                                &nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                    
                    </div>
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnRegCust" runat="server" OnClick="btnRegCust_OnClick" Text="Register" />
                    </div>
				
				
				<p>
                    &nbsp;</p>
<p>
</p>
</asp:Content>
