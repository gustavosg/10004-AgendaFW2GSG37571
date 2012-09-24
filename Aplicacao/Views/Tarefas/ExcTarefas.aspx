<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true"
    CodeBehind="ExcTarefas.aspx.cs" Inherits="System.Aplicacao.Views.Tarefas.ExcTarefas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="Panel1" runat="server">
        <h1>
            <asp:Label ID="Label1" runat="server" Text="EDITAR TAREFAS"></asp:Label>
        </h1>
    </asp:Panel>
    <asp:Panel ID="Panel3" runat="server" HorizontalAlign="Center" Style="margin-top: 0px">
        <br />
        <asp:GridView ID="gvTarefas" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None"
            AutoGenerateColumns="False" HorizontalAlign="Center">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <Columns>
                <asp:TemplateField HeaderText="Selecionar">
                    <ItemTemplate>
                        <asp:CheckBox ID="cbxSelecionar" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
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
                <asp:Panel ID="Panel2" runat="server" HorizontalAlign="Center">
            <h2>
                <asp:Label ID="Aviso" runat="server" Font-Size="14pt" ForeColor="Red"></asp:Label>
            </h2>
        </asp:Panel>
    </asp:Panel>
    <asp:Panel ID="Panel4" runat="server" HorizontalAlign="Center">
            <asp:Button ID="Remover" runat="server" Text="Remover" 
                onclick="Remover_Click" />
    </asp:Panel>
</asp:Content>
