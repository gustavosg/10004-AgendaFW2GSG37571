<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EdLocais.aspx.cs" Inherits="System.Aplicacao.Views.Locais.EdLocais" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="Panel1" runat="server" HorizontalAlign="Center">
        <h1>
            <asp:Label ID="Label1" runat="server" Style="text-align: center" 
                Text="ALTERAÇÃO DE LOCAIS"></asp:Label>
        </h1>
    </asp:Panel>
    <br />
    <asp:Panel ID="Panel2" runat="server">
        <asp:GridView ID="gvLocais" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None"
            Style="text-align: center" HorizontalAlign="Center" AutoGenerateColumns="False"
            AutoGenerateSelectButton="True" AllowSorting="True">
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
    </asp:Panel>
    <br />
    <asp:Panel ID="Panel5" runat="server" HorizontalAlign="Center">
        <asp:Button ID="Editar" runat="server" OnClick="Editar_Click" Text="Editar" />
        
    </asp:Panel>
    <asp:Panel ID="Panel6" runat="server" HorizontalAlign=Center>
    <h2>
        <asp:Label ID="Aviso" runat="server" Text="" ForeColor=Red></asp:Label>
        </h2>
    </asp:Panel>

    <asp:Panel ID="Panel3" runat="server">
        <h2 align="center">
            <asp:Label ID="Label7" runat="server" Style="text-align: center" 
                Text="DADOS DO LOCAL SELECIONADO:"></asp:Label>
        </h2>
    </asp:Panel>
    <br />
    <asp:Panel ID="Panel4" runat="server">
        <table align="center" style="width: 36%;">
            <tr>
                <td class="style3">
                    <asp:Label ID="Label8" runat="server" Text="Código"></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="id" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    <asp:Label ID="Label2" runat="server" Text="Nome:"></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="nome" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
    </asp:Panel>
    <br />
    <asp:Panel ID="Panel7" runat="server" HorizontalAlign="Center">
        <asp:Button ID="Atualizar" runat="server" OnClick="Atualizar_Click" Text="Atualizar" />
    </asp:Panel>
</asp:Content>
