<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadPessoas.aspx.cs" Inherits="System.Aplicacao.Views.Pessoas.CadPessoas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            width: 32%;
        }
        .style2
        {
            width: 186px;
        }
        .style3
        {
            width: 34%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="Panel2" runat="server">
        <h1 align="center">
            <asp:Label ID="Label1" runat="server" style="text-align: center" 
                Text="Cadastro de Pessoas"></asp:Label>
        </h1>
        <p align="center">
            &nbsp;</p>
    </asp:Panel>
    <asp:Panel ID="Panel3" runat="server" HorizontalAlign="Justify">
        <table align="center" style="width: 36%;">
            <tr>
                <td class="style3">
                    <asp:Label ID="Label2" runat="server" Text="Nome:"></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="nome" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label ID="Label7" runat="server" Text="Login"></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="login" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label ID="Label3" runat="server" Text="Senha:"></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="senha" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label ID="Label4" runat="server" 
                Text="Confirmar Senha:"></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="confirmarSenha" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3" style="margin-left: 80px">
                    <asp:Label ID="Label5" runat="server" Text="Sexo"></asp:Label>
                </td>
                <td class="style2">
                    <asp:RadioButtonList ID="Sexo" runat="server" align=left
                AutoPostBack="True" RepeatDirection="Horizontal" style="text-align: left">
                        <asp:ListItem>Masculino</asp:ListItem>
                        <asp:ListItem>Feminino</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td class="style3" style="margin-left: 80px">
                    <asp:Label ID="Label6" runat="server" Text="Idade"></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="idade" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
    </asp:Panel>
    <p>
        &nbsp;</p>
    <asp:Panel ID="Panel1" runat="server" style="text-align: center">
        <asp:Button ID="Salvar" runat="server" Text="Salvar" 
            style="text-align: center" onclick="Salvar_Click" />
    </asp:Panel>
</asp:Content>
