<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebClient._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>TestService WebClient</h1>
        <hr />
        <asp:UpdatePanel ID="UpdatePanel" runat="server">
            <ContentTemplate>
                <div class="row">
                    <div class="col"></div>
                    <div class="col-6">
                        <div class="form-group">
                            <div class="input-group">
                                <div class="input-group-prepend">
                                    <asp:Button CssClass="btn btn-secondary" ID="ButtonMRA" runat="server" Text="MR" OnClick="ButtonMRA_Click" />
                                </div>
                                <div class="input-group-prepend">
                                    <asp:Button CssClass="btn btn-dark" ID="ButtonARA" runat="server" Text="AR" OnClick="ButtonARA_Click" />
                                </div>
                                <asp:TextBox CssClass="form-control text-right" ID="TextBoxA" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="input-group">
                                <asp:DropDownList CssClass="form-control" ID="DropDownListOperation" runat="server">
                                    <asp:ListItem Value="+" Selected="True"></asp:ListItem>
                                    <asp:ListItem Value="−"></asp:ListItem>
                                    <asp:ListItem Value="×"></asp:ListItem>
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="input-group">
                                <div class="input-group-prepend">
                                    <asp:Button CssClass="btn btn-secondary" ID="ButtonMRB" runat="server" Text="MR" OnClick="ButtonMRB_Click" />
                                </div>
                                <div class="input-group-prepend">
                                    <asp:Button CssClass="btn btn-dark" ID="ButtonARB" runat="server" Text="AR" OnClick="ButtonARB_Click" />
                                </div>
                                <asp:TextBox CssClass="form-control text-right" ID="TextBoxB" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="input-group">
                                <asp:Button CssClass="btn btn-primary form-control" ID="ButtonEquals" runat="server" Text="=" OnClick="ButtonEquals_Click" />
                            </div>
                        </div>
                        <div class="form-group">
                            <div class="input-group">
                                <div class="input-group-prepend">
                                    <asp:Button CssClass="btn btn-secondary" ID="ButtonMS" runat="server" Text="MS" OnClick="ButtonMS_Click" />
                                </div>
                                <div class="input-group-prepend">
                                    <asp:Button CssClass="btn btn-dark" ID="ButtonAS" runat="server" Text="AS" OnClick="ButtonAS_Click" />
                                </div>
                                <asp:TextBox CssClass="form-control text-right" ID="TextBoxResult" runat="server" ReadOnly="true"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="col"></div>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>

</asp:Content>
