<%@ Page Title="" Language="C#" MasterPageFile="~/Demo.Master" AutoEventWireup="true" CodeBehind="Dtest.aspx.cs" Inherits="Testing.Dtest" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div>
            <table class="auto-style1">
                <tr>
                    <td>Numerator</td>
                    <td>
                        <asp:TextBox ID="txtNumerator" runat="server"></asp:TextBox> </td>
                   
                </tr>
                <tr>
                    <td>Denominator</td>
                    <td><asp:TextBox ID="txtDenominator" runat="server"></asp:TextBox></td>
                 
                </tr>
                <tr>
                    <td>Result</td>
                    <td><asp:TextBox ID="txtResult" runat="server"></asp:TextBox></td>
              
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Calcuate" OnClick="Button1_Click" />
                        </td>
                </tr>
            </table>
</asp:Content>
