<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="EasyIngresso.WEB.Login1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row"></div>
    <div class="row form-login">
        <div class="col s12 center-postal">
            <div class="card">
                <div class="card-action">
                    <h4>Easy Ingresso</h4>
                </div>
                <div class="card-action">
                    <div class="row">
                        <div class="col s12">
                            <asp:TextBox runat="server" CssClass="js-matricula" ID="txtUsuario" Enabled="True" placeholder="Usuario" ToolTip="Entre como seu usuário de Rede" />
                            <asp:RequiredFieldValidator ID="UsuarioObrigatorio" runat="server"
                                ControlToValidate="txtUsuario"
                                ErrorMessage="Usuário obrigatorio."
                                ForeColor="Red">
                            </asp:RequiredFieldValidator>
                        </div>
                        <div class="col s12">
                            <asp:TextBox runat="server" CssClass="js-matricula" ID="txtSenha" Enabled="True" TextMode="Password" placeholder="Senha" ToolTip="Entre com sua senha de Rede" />
                            <asp:RequiredFieldValidator ID="SenhaObrigatoria" runat="server"
                                ControlToValidate="txtSenha"
                                ErrorMessage="Senha obrigatória."
                                ForeColor="Red">
                            </asp:RequiredFieldValidator>
                        </div>
                        <div class="col s12">
                            <asp:CustomValidator OnServerValidate="ValidadorUsuario_ServerValidate"  ID="ValidadorUsuario" runat="server" ></asp:CustomValidator>
                        </div>
                        <div class="col s12">
                            
                            <asp:Button ID="LoginButton" CausesValidation="true" CssClass="btn btn-large waves-effect waves-light postal-azul" runat="server" UseSubmitBehavior="true" Text="Entrar" OnClick="LoginButton_Click"  />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>


</asp:Content>