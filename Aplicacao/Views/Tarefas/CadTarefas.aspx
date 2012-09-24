<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="CadTarefas.aspx.cs" Inherits="System.Aplicacao.Views.Tarefas.CadTarefas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="Panel1" runat="server">
        <h1>
            <asp:Label ID="Label1" runat="server" Text="CADASTRO DE TAREFAS"></asp:Label>
        </h1>
    </asp:Panel>
    <br />
    <asp:Panel ID="Panel2" runat="server" >
        <table align="center" style="width:40%" >
            <tr>
                <td width="25%">
                    <asp:Label ID="Label2" runat="server" Text="Nome"></asp:Label>
                </td>
                <td >
                    <asp:TextBox ID="nome" runat="server" Width="250"></asp:TextBox>
                </td>
            </tr>
        </table>
    </asp:Panel>
    <asp:Panel ID="Panel4" runat="server" HorizontalAlign="Center">
        <h2>
            <asp:Label ID="Aviso" runat="server" ForeColor="Red"></asp:Label>
        </h2>
    </asp:Panel>
    <asp:Panel ID="Panel3" runat="server" HorizontalAlign="Center">
        <asp:Button ID="Salvar" runat="server" onclick="Salvar_Click" 
    Text="Salvar" />
    </asp:Panel>
</asp:Content>
