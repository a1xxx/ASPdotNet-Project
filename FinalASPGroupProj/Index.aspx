<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="FinalASPGroupProj.Index1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div style="text-align: center;" >
        <br>
        <br>
        <div>
          
                <p>Good Afternoon Welcome to travel experts!</p>			
        </div>

        <div id="asiaImg" class="carousel slide img-responsive" data-ride="carousel" />
       
        <div class="carousel-inner" role="listbox">
            <div class="item active">
                <img class="rotatingImageSize" src="images/tr1.jpg" alt="">
                <div class="carousel-caption">
                    <h3>Banff</h3>
                    <p></p>
                </div>
            </div>

            <div class="item">
                <img class="rotatingImageSize" src="images/tr2.jpg" alt="">
                <div class="carousel-caption">
                    <h3>Grand Canyon</h3>
                    <p></p>
                </div>
            </div>

            <div class="item">
                <img class="rotatingImageSize" src="images/tr3.jpg" alt="">
                <div class="carousel-caption">
                    <h3>Hawaii</h3>
                    <p></p>
                </div>
            </div>

            <div class="item">
                <img class="rotatingImageSize" src="images/tr4.jpg" alt="singapore">
                <div class="carousel-caption">
                    <h3>Ohio</h3>
                    <p></p>
                </div>

            </div>
        </div>
          
        

        <!-- Left and right controls -->
        <a class="left carousel-control" href="#asiaImg" role="button" data-slide="prev">
            <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
            <span class="sr-only">Previous</span>
        </a>
        <a class="right carousel-control" href="#asiaImg" role="button" data-slide="next">
            <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
            <span class="sr-only">Next</span>
        </a>
			
            
    </div>

      
        
	<br><br><br>

    <div style="text-align: center;" >
        <table style="width: 100%">
            <tr>
                <th>
                    <div style="text-align: center;" ><h1 class="headingColor" >Banff</h1></div>
                </th>
                <th>
                    <div style="text-align: center;" ><h1 class="headingColor" >Hawaii</h1></div>
                </th> 
                <th>
                    <div style="text-align: center;" ><h1 class="headingColor" >Grand Canyon</h1></div>
                </th>
                <th>
                    <div style="text-align: center;" ><h1 class="headingColor" >Ohio</h1></div>
                </th>  
            </tr>
            <tr>
                <td>
                    <p style="padding: 10px 30px 50px 40px;"> Mauris vel vulputate sapien. Duis ante lacus, ultricies porttitor auctor in, suscipit a mauris. Nullam tincidunt vestibulum ornare. Integer eu odio iaculis, egestas nibh iaculis, vehicula nisl. Etiam consequat est orci, pellentesque ultricies nunc elementum vel. Nam eget auctor elit. Integer ac erat ac nisi viverra suscipit a et tortor. Quisque consequat pharetra egestas. Donec at sapien eget dolor ultricies auctor. Ut consectetur odio ut porta convallis. Quisque pretium elit interdum ultrices condimentum. Cras erat lorem, consequat eget lectus non, luctus commodo nibh. </p>
                </td>
                <td>
                    <p style="padding: 10px 30px 50px 40px;"> Mauris vel vulputate sapien. Duis ante lacus, ultricies porttitor auctor in, suscipit a mauris. Nullam tincidunt vestibulum ornare. Integer eu odio iaculis, egestas nibh iaculis, vehicula nisl. Etiam consequat est orci, pellentesque ultricies nunc elementum vel. Nam eget auctor elit. Integer ac erat ac nisi viverra suscipit a et tortor. Quisque consequat pharetra egestas. Donec at sapien eget dolor ultricies auctor. Ut consectetur odio ut porta convallis. Quisque pretium elit interdum ultrices condimentum. Cras erat lorem, consequat eget lectus non, luctus commodo nibh. </p>
                </td>
                <td>
                    <p style="padding: 10px 30px 50px 40px;"> Mauris vel vulputate sapien. Duis ante lacus, ultricies porttitor auctor in, suscipit a mauris. Nullam tincidunt vestibulum ornare. Integer eu odio iaculis, egestas nibh iaculis, vehicula nisl. Etiam consequat est orci, pellentesque ultricies nunc elementum vel. Nam eget auctor elit. Integer ac erat ac nisi viverra suscipit a et tortor. Quisque consequat pharetra egestas. Donec at sapien eget dolor ultricies auctor. Ut consectetur odio ut porta convallis. Quisque pretium elit interdum ultrices condimentum. Cras erat lorem, consequat eget lectus non, luctus commodo nibh. </p>
                </td>
                <td>
                    <p style="padding: 10px 30px 50px 40px;"> Mauris vel vulputate sapien. Duis ante lacus, ultricies porttitor auctor in, suscipit a mauris. Nullam tincidunt vestibulum ornare. Integer eu odio iaculis, egestas nibh iaculis, vehicula nisl. Etiam consequat est orci, pellentesque ultricies nunc elementum vel. Nam eget auctor elit. Integer ac erat ac nisi viverra suscipit a et tortor. Quisque consequat pharetra egestas. Donec at sapien eget dolor ultricies auctor. Ut consectetur odio ut porta convallis. Quisque pretium elit interdum ultrices condimentum. Cras erat lorem, consequat eget lectus non, luctus commodo nibh. </p>
                </td>
            </tr>

        </table>
    </div>

    <br>

	

<div class="copyright">
    <div style="text-align: center;" ><div class="copyright"> Copyright 2016 &#169; Travel Experts, Inc.</div></div>
</div>
<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js"></script>
<script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
<script src="scripts/script.js"></script>


</asp:Content>































