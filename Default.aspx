<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FizzBuzz._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
         <table border="0" >
            <tr> <td >Enter the Numbers: </td>  <td><asp:TextBox ID="txtNumbers" runat="server" class="input-group-prepend" ></asp:TextBox></td> <td> <asp:Button ID="btnSubmit" runat="server" Text="Submit" class="btn btn-primary" OnClick="btnSubmit_Click"/></td></tr>
              <tr> <td style="width: 149px"></td>   </tr>
              <tr> <td style="width: 149px">Result:</td>  <td><asp:ListBox ID="txtResult1" runat="server" Height="240px" Width="144px"></asp:ListBox></td> </tr>
            <tr> <td  colspan="2"><asp:Label ID="lblError" runat="server"></asp:Label></td>   </tr>
        </table>

    </div>

    <div class="row">
        <div class="col-md-4">
            
        </div>
        <div class="col-md-4">
           
        </div>
        <div class="col-md-4">
           
        </div>
    </div>

</asp:Content>
