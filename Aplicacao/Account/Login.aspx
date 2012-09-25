<%@ Page Title="Log In" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="~/Account/Login.aspx.cs" Inherits="System.Aplicacao.Account.Login" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <p align=center>
        <asp:Label ID="Label1" runat="server" Text="Login"></asp:Label>
        <asp:Login ID="Login1" runat="server" BackColor="#F7F6F3" BorderColor="#E6E2D8" BorderPadding="4"
            BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em"
            ForeColor="#333333" align="center" style="text-align: center">
            <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
            <LayoutTemplate >
                <table cellpadding="1" cellspacing="0" style="border-collapse: collapse;" >
                    <tr>
                        <td align="center">
                            <table cellpadding="0" align="center">
                                <tr>
                                    <td align="center" colspan="2">
                                        Fazer Logon
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">Nome do Usuário:</asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="UserName" runat="server"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName"
                                            ErrorMessage="O Nome do Usuário é obrigatório." ToolTip="O Nome do Usuário é obrigatório."
                                            ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Senha:</asp:Label>
                                    </td>
                                    <td>
                                        <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password"
                                            ErrorMessage="A senha é obrigatória." ToolTip="A senha é obrigatória." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td colspan="2">
                                        <asp:CheckBox ID="RememberMe" runat="server" Text="Lembrar na próxima vez." />
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right" colspan="2">
                                        <asp:Button ID="LoginButton" runat="server" CommandName="Login" Text="Fazer Logon"
                                            ValidationGroup="Login1" OnClick="LoginButton_Click" />
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </LayoutTemplate>
            <LoginButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px"
                Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284775" />
            <TextBoxStyle Font-Size="0.8em" />
            <TitleTextStyle BackColor="#5D7B9D" Font-Bold="True" Font-Size="0.9em" ForeColor="White" />
        </asp:Login>
        <asp:Panel ID="Panel1" runat="server" HorizontalAlign="Center">
            <h2>
                <asp:Label ID="Aviso" runat="server" Text="" ForeColor="Red"></asp:Label>
            </h2>
        </asp:Panel>
    </p>
    <p>
        Please enter your username and password.Please enter your username and password.
        lease enter your username and password.
        <asp:HyperLink ID="RegisterHyperLink" runat="server" EnableViewState="false">Register</asp:HyperLink>
        if you don't have an account.
    </p>
</asp:Content>
