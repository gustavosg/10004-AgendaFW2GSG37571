<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="CadPessoas.aspx.cs" Inherits="System.Aplicacao.Views.Pessoas.CadPessoas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">

        .style1
        {
            width: 506px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 >
        
        <asp:Label ID="Label1" runat="server" Text="Cadastro de Pessoas"></asp:Label>
        </h1>
        <br />
    
        <table width=100%>
            <tr>
                <td width=15%>
                    <asp:Label ID="Label2" runat="server" Text="Nome"></asp:Label>
                </td>
                <td class="style1">
                    <asp:TextBox ID="nome" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Sexo"></asp:Label>
                </td>
                <td class="style1">
                    <asp:RadioButtonList ID="Sexo" runat="server">
                        <asp:ListItem>Masculino</asp:ListItem>
                        <asp:ListItem>Feminino</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Idade"></asp:Label>
                </td>
                <td class="style1">
                    <asp:TextBox ID="idade" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
    
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
        style="text-align: center" Text="Cadastrar" />
    
    </p>
</asp:Content>
