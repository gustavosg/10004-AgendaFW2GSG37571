<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AtribuirTarefa.aspx.cs" Inherits="System.Aplicacao.Views.Operacional.AtribuirTarefa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <style type="text/css">
        .style1
        {
            width: 6px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="Panel1" runat="server">
        <h1>
            <asp:Label ID="Label1" runat="server" Text="ATRIBUIR TAREFAS À PARTICIPANTES"></asp:Label>
        </h1>
    </asp:Panel>
    <br />
    <asp:Panel ID="Panel2" runat="server">
        <table style="width:100%;">
            <tr>
                <td align="center">
                    <h2>
                        <asp:Label ID="Label2" runat="server" Text="Tarefas"></asp:Label>
                    </h2>
                </td>
                <td align=center>
                    <h2>
                        <asp:Label ID="Label5" runat="server" style="text-align: center" Text="LOCAIS"></asp:Label>
                    </h2>
                </td>
            </tr>
            <tr>
                <td width="50%">
                    <asp:GridView ID="gvTarefas" runat="server" AutoGenerateColumns="False" 
                        AutoGenerateSelectButton="True" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" HorizontalAlign="Center" 
                        onselectedindexchanged="gvTarefas_SelectedIndexChanged" >
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
                </td>
                
                <td>
                    <asp:GridView ID="gvLocais" runat="server" AutoGenerateColumns="False" 
                        AutoGenerateSelectButton="True" CellPadding="4" ForeColor="#333333" 
                        GridLines="None" HorizontalAlign="Center" Style="text-align: center" 
                        onselectedindexchanged="gvLocais_SelectedIndexChanged">
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
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <h2 align="center">
                        <asp:Label ID="Label4" runat="server" Text="Pessoas"></asp:Label>
                    </h2>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:GridView ID="gvPessoas" runat="server" AutoGenerateColumns="False" 
                        CellPadding="4" ForeColor="#333333" 
                        GridLines="None" HorizontalAlign="Center" Style="text-align: center">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <Columns>
                            <asp:TemplateField HeaderText="Selecionar">
                                <ItemTemplate>
                                    <asp:CheckBox ID="cbxSelecionar" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="id" HeaderText="Código" />
                            <asp:BoundField DataField="nome" HeaderText="Nome" />
                            <asp:BoundField DataField="login" HeaderText="Login" />
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
                </td>
            </tr>
            <tr>
                <td align="center" colspan="2" >
                    <h2>
                        <asp:Label ID="Label6" runat="server" Text="Momento do compromisso"></asp:Label>
                    </h2>
                </td>
            </tr>
            <tr>
                <td align="center" colspan="2">
                    <asp:Calendar ID="data" runat="server"></asp:Calendar>
                </td>
            </tr>
        </table>
    </asp:Panel>
    <p>
        &nbsp;</p>
    <asp:Panel ID="Panel3" runat="server" HorizontalAlign="Center">
        <asp:Button ID="Atribuir" runat="server" Text="Atribuir" 
            onclick="Atribuir_Click" />
    </asp:Panel>
</asp:Content>
