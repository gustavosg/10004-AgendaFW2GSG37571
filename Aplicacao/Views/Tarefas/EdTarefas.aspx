<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EdTarefas.aspx.cs" Inherits="System.Aplicacao.Views.Tarefas.EdTarefas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="Panel1" runat="server">
        <h1>
            <asp:Label ID="Label1" runat="server" Text="EDITAR TAREFAS"></asp:Label>
        </h1>
    </asp:Panel>
    <asp:Panel ID="Panel3" runat="server" HorizontalAlign="Center" 
        style="margin-top: 0px">
        <br />
        <asp:GridView ID="gvTarefas" runat="server" 
    CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" 
            AutoGenerateSelectButton="True" HorizontalAlign="Center">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:BoundField DataField="id" HeaderText="Código" />
                <asp:BoundField DataField="nome" HeaderText="Nome" />
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <br />
        <asp:Button ID="Editar" runat="server" onclick="Editar_Click" Text="Editar" />
          <br />
        <h2>
            <asp:Label ID="Aviso" runat="server" ForeColor="Red"></asp:Label>
        </h2>
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server" >
        <table align="center" style="width:40%" >
            <tr>
                <td width="25%">
                    <asp:Label ID="Label3" runat="server" Text="Código"></asp:Label>
                </td>
                <td >
                    <asp:TextBox ID="id" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td width="25%">
                    <asp:Label ID="Label2" runat="server" Text="Nome"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="nome" runat="server" Width="250"></asp:TextBox>
                </td>
            </tr>
        </table>
    </asp:Panel>
    <p align="center">
        <asp:Button ID="Atualizar" runat="server" onclick="Atualizar_Click" 
            Text="Atualizar" />
    </p>
</asp:Content>
