<%@ Page Title="Remover Tarefa" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RemoverTarefa.aspx.cs" Inherits="System.Aplicacao.Views.Operacional.RemoverTarefa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="Panel1" runat="server">
        <h1>
            <asp:Label ID="Label1" runat="server" Text="REMOVER TAREFAS À PARTICIPANTES"></asp:Label>
        </h1>
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server">
        <table style="width: 100%;">
            <tr>
                <td align="center">
                    <h2>
                        <asp:Label ID="Label7" runat="server" Text="Tarefas:"></asp:Label>
                    </h2>
                </td>
            </tr>
            <tr>
                <td align="center">
                    <asp:GridView ID="gvTarefasAtribuidas" runat="server" 
                        AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" 
                        GridLines="None">
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <Columns>
                            <asp:TemplateField HeaderText="Selecionar">
                                <ItemTemplate>
                                    <asp:CheckBox ID="cbxSelecionar" runat="server" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField DataField="id" HeaderText="Código" />
                            <asp:BoundField DataField="nome" HeaderText="Pessoa" />
                            <asp:BoundField DataField="tarefa" HeaderText="Tarefa" />
                            <asp:BoundField DataField="local" HeaderText="Local" />
                            <asp:BoundField DataField="data" DataFormatString="&quot;{0:dd/MM/yyyy}&quot;" 
                                HeaderText="Data" />
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
        </table>
    </asp:Panel>
    <asp:Panel ID="Panel4" runat="server">
        <h1>
            <asp:Label ID="Aviso" runat="server" ForeColor="Red"></asp:Label>
        </h1>
    </asp:Panel>
    <asp:Panel ID="Panel3" runat="server" HorizontalAlign="Center">
        <asp:Button ID="Remover" runat="server" Text="Remover" 
            OnClick="Remover_Click" />
    </asp:Panel>
</asp:Content>
