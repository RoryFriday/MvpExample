<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SubscriberFormView.ascx.cs" Inherits="MvpExample.Components.SubscriberFormView" %>

<asp:TextBox runat="server" ID="txtName"></asp:TextBox>
<asp:TextBox runat="server" ID="txtEmail"></asp:TextBox>

<asp:Button runat="server" ID="SubmitSubscriber" OnClick="SubmitSubscriber_Click" />