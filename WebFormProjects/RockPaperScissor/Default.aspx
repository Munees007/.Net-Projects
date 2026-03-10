<%@ Page Title="Home" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RockPaperScissor._Default" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="position-relative overflow-hidden d-flex w-100 vh-100 flex-column gap-4 justify-content-center align-items-center" 
         style="background: linear-gradient(to bottom, #f0f8ff, #cce7ff); font-family: 'Segoe UI', sans-serif;">

        <!-- Page Title -->
        <h1 class="text-primary" style="font-weight: bold; font-size:3rem; text-shadow: 1px 1px #aaa;">
            Rock / Paper / Scissors
        </h1>

        <!-- Emoji Symbols -->
        <p style="font-size:3rem; margin-bottom:2rem;">🪨 📄 ✂️</p>

        <!-- Floating lifecycle event labels -->
        <div class="position-absolute top-0 start-0 p-3 bg-white border shadow-sm rounded"
             style="max-width:220px;">
            <h5 class="text-center mb-2" style="font-weight:bold; color:#333;">Lifecycle Status</h5>
            <p>PreInit: <asp:Label ID="lblPreInit" runat="server" Text="Not Completed" CssClass="text-secondary"></asp:Label></p>
            <p>Init: <asp:Label ID="lblInit" runat="server" Text="Not Completed" CssClass="text-secondary"></asp:Label></p>
            <p>InitComplete: <asp:Label ID="lblInitComplete" runat="server" Text="Not Completed" CssClass="text-secondary"></asp:Label></p>
            <p>Load: <asp:Label ID="lblLoad" runat="server" Text="Not Completed" CssClass="text-secondary"></asp:Label></p>
            <p>LoadComplete: <asp:Label ID="lblLoadComplete" runat="server" Text="Not Completed" CssClass="text-secondary"></asp:Label></p>
            <p>PreRender: <asp:Label ID="lblPreRender" runat="server" Text="Not Completed" CssClass="text-secondary"></asp:Label></p>
            <p>PreRenderComplete: <asp:Label ID="lblPreRenderComplete" runat="server" Text="Not Completed" CssClass="text-secondary"></asp:Label></p>
            <p>SaveStateComplete: <asp:Label ID="lblSaveStateComplete" runat="server" Text="Not Completed" CssClass="text-secondary"></asp:Label></p>
            <p>Button_Click: <asp:Label ID="lblButtonClick" runat="server" Text="Not Completed" CssClass="text-secondary"></asp:Label></p>
        </div>

        <!-- Game buttons -->
        <div class="d-flex gap-3">
            <asp:Button ID="btnRock" runat="server" Text="🪨 Rock" CssClass="btn btn-danger btn-lg" OnClick="PlayGame" />
            <asp:Button ID="btnPaper" runat="server" Text="📄 Paper" CssClass="btn btn-warning btn-lg" OnClick="PlayGame" />
            <asp:Button ID="btnScissors" runat="server" Text="✂️ Scissors" CssClass="btn btn-success btn-lg" OnClick="PlayGame" />
        </div>

        <!-- Game output -->
        <div class="d-flex flex-column align-items-center mt-3">
            <asp:Label ID="lblUser" runat="server" Font-Size="Large" CssClass="mb-1 fw-bold text-primary"></asp:Label>
            <asp:Label ID="lblComputer" runat="server" Font-Size="Large" CssClass="mb-1 fw-bold text-danger"></asp:Label>
            <asp:Label ID="lblResult" runat="server" Font-Size="X-Large" ForeColor="Blue" CssClass="fw-bold"></asp:Label>
        </div>

    </div>

</asp:Content>
