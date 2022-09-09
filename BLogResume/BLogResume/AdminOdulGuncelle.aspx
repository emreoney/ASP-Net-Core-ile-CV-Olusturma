<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminOdulGuncelle.aspx.cs" Inherits="BLogResume.AdminOdulGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">




     <form id="Form1" runat="server">

        <div class="form-group">

            <div>
                <asp:Label ID="Label1" runat="server" Text="ID"></asp:Label>
                <asp:TextBox ID="TxtID" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <asp:Label ID="Label5" runat="server" Text="Ödül"></asp:Label>
                <asp:TextBox ID="TxtOdul" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            
            <asp:Button ID="BtnGuncelle"  runat="server" Text="Güncelle" CssClass="btn btn-success" OnClick="BtnGuncelle_Click" />

        </div>

    </form>





</asp:Content>
