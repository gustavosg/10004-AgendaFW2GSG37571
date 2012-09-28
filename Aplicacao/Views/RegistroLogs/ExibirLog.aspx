<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ExibirLog.aspx.cs" Inherits="System.Aplicacao.Views.RegistroLogs.ExibirLog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <asp:Panel ID="Panel2" runat="server">
        <h2 align="center">
            <asp:Label ID="Label1" runat="server" Text="LOGS GERADOS PELO SISTEMA"></asp:Label>
        </h2>
    </asp:Panel>

    <asp:Panel ID="Panel1" runat="server">
    <asp:TextBox ID="Logs" runat="server" Height="400px" ReadOnly="True" 
    TextMode="MultiLine" Width="100%"></asp:TextBox>
    </asp:Panel>
    
</asp:Content>
