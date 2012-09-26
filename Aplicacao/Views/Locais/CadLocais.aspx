<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="CadLocais.aspx.cs" Inherits="System.Aplicacao.Views.Locais.CadLocais" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style3
        {
            width: 34%;
        }
        .style2
        {
            width: 186px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="Panel2" runat="server">
        <h1 align="center">
            <asp:Label ID="Label1" runat="server" Style="text-align: center" 
                Text="CADASTRO DE LOCAIS"></asp:Label>
        </h1>
    </asp:Panel>
    <asp:Panel ID="Panel3" runat="server" HorizontalAlign="Justify">
        <table align="center" style="width: 36%;">
            <tr>
                <td class="style3">
                    <asp:Label ID="Label2" runat="server" Text="Nome:"></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="nome" runat="server" Width="200px"></asp:TextBox>
                </td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="Panel4" runat="server" HorizontalAlign="Center">
        <h2>
            <asp:Label ID="Aviso" runat="server" Text="" ForeColor="Red" ></asp:Label>
        </h2>
    </asp:Panel>
    <asp:Panel ID="Panel1" runat="server" Style="text-align: center">
        <asp:Button ID="Salvar" runat="server" Text="Salvar" Style="text-align: center" OnClick="Salvar_Click" />
    </asp:Panel>
</asp:Content>
