<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EdPessoas.aspx.cs" Inherits="System.Aplicacao.Views.Pessoas.EdPessoas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="Panel1" runat="server" HorizontalAlign="Center" >
        <h1>
            <asp:Label ID="Label1" runat="server" style="text-align: center" 
                Text="Alteração de Dados de Pessoas"></asp:Label>
        </h1>
    </asp:Panel>
    <br />
    <asp:Panel ID="Panel2" runat="server">
        <asp:GridView ID="gvPessoas" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None"
            Style="text-align: center" HorizontalAlign="Center" 
            AutoGenerateColumns="False">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:ButtonField CommandName="Editar" Text="Editar" />
                <asp:BoundField DataField="id" HeaderText="Código" />
                <asp:BoundField DataField="nome" HeaderText="Nome" />
                <asp:BoundField DataField="sexo" HeaderText="Sexo" />
                <asp:BoundField DataField="idade" HeaderText="Idade" />
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
    <asp:Panel ID="Panel3" runat="server" >
        <h2 align="center">
            <asp:Label ID="Label7" runat="server" style="text-align: center" 
                Text="Dados da pessoa selecionada:"></asp:Label>
        </h2>
    </asp:Panel>
    <br />
    <asp:Panel ID="Panel4" runat="server">
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



</asp:Content>
