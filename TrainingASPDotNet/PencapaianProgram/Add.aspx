<%@ Page Title="" Language="C#" MasterPageFile="~/Metronic.Master" AutoEventWireup="true" CodeBehind="Add.aspx.cs" Inherits="TrainingASPDotNet.PencapaianProgram.Add" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <!-- BEGIN: Subheader -->
    <div class="m-subheader ">
        <div class="d-flex align-items-center">
            <div class="mr-auto">
                <h3 class="m-subheader__title ">Tambah Pencapaian Program
                </h3>
            </div>
        </div>
    </div>
    <!-- END: Subheader -->
    <div class="form-group">
        <label>Kod Program</label>
        <asp:TextBox ID="KodProgram" runat="server" CssClass="form-control"></asp:TextBox>
    </div>

    <div class="form-group">
        <label>Tarikh Program</label>
        <asp:TextBox ID="TarikhProgram" runat="server" CssClass="form-control"></asp:TextBox>
    </div>

    <div class="form-group">
        <label>Bilangan Hari</label>
        <asp:TextBox ID="BilanganHari" runat="server" CssClass="form-control"></asp:TextBox>
    </div>

    <div class="form-check">
        <label class="form-check-label">
            <asp:CheckBox ID="Lulus" runat="server" CssClass="form-check-input"/>
            Lulus
        </label>
    </div>

    <asp:Button ID="btnSubmit" runat="server" Text="Simpan" CssClass="btn btn-primary" OnClick="btnSubmit_Click"/>
</asp:Content>
