<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="truconetWeb.User" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <style type="text/css">
        .style1
        {
            top: 115px;
            left: 590px;
            width: 170px;
            margin-left: 0px;
        }
        .style3
        {
            top: 331px;
            left: 590px;
            position: absolute;
            margin-right: 0px;
        }
        .style4
        {
            top: 384px;
            left: 276px;
            }
        .style5
        {
            top: 254px;
            left: 629px;
            position: absolute;
            height: 26px;
            width: 114px;
        }
        .style6
        {
            z-index: 1;
            left: 788px;
            top: 161px;
            width: 30px;
            height: 27px;
        }
        .style7
        {
            z-index: 1;
            left: 605px;
            top: 473px;
            position: absolute;
        }
        .style8
        {
            z-index: 1;
            left: 697px;
            top: 472px;
            position: absolute;
        }
        .style9
        {
            z-index: 1;
            left: 617px;
            top: 61px;
            position: absolute;
            height: 41px;
            width: 382px;
        }
        .style10
        {
            z-index: 1;
            left: 636px;
            top: 304px;
            position: absolute;
            height: 19px;
            width: 64px;
        }
        .style11
        {
            width: 473px;
            height: 135px;
            position: absolute;
            top: 107px;
            left: 586px;
            z-index: 1;
        }
        .style12
        {
            width: 1062px;
            height: 551px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="style12">
    
        <asp:Panel ID="Panel" runat="server" Height="514px">
            <asp:Label ID="Label1" runat="server" Text="Partido Nº:"></asp:Label>
            &nbsp;<asp:Label ID="lbIdPartido" runat="server"></asp:Label>
            <br />
            <div class="style9">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                &nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label5" runat="server" Text="Invitados"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label4" runat="server" Text="Jugadores en sistema"></asp:Label>
            </div>
            <br />
            <div class="style10">
                <asp:Label ID="Label3" runat="server" Text="Partidos"></asp:Label>
            </div>
            <asp:Label ID="Label8" runat="server" Text="Muestra: "></asp:Label>
            <asp:Label ID="lbMuestra" runat="server"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="TextBox1" runat="server" Height="61px" Width="551px"></asp:TextBox>
            <br />
            <asp:Button ID="Button2" runat="server" CssClass="style7" Text="Button" 
                onclick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" CssClass="style8" Text="Button" />
            <br />
            <asp:Button ID="btnCartas" runat="server" onclick="btnCartas_Click" 
                Text="Salir" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnVer" runat="server" onclick="btnVer_Click" Text="ver" />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label2" runat="server" Text="Jugadores Partido"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ListBox ID="lstPartidos" runat="server" Height="132px" 
                onselectedindexchanged="lstPartidos_SelectedIndexChanged" Width="190px" 
                CssClass="style3">
            </asp:ListBox>
            &nbsp;&nbsp;
            <asp:ListBox ID="listaUsuarios" runat="server" CssClass="style1" Height="130px">
            </asp:ListBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="iniciarPartido" runat="server" CssClass="style5" 
                onclick="iniciarPartido_Click" Text="Crear Partido" />
            <br />
            <br />
            <br />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<div 
                class="style11">
                <asp:ListBox ID="listaInvitados" runat="server" CssClass="style4" 
                    Height="137px" onselectedindexchanged="listaUsuarios_SelectedIndexChanged" 
                    Width="196px"></asp:ListBox>
                <span lang="es">&nbsp;
                <asp:Button ID="Button1" runat="server" CssClass="style6" 
                    onclick="Button1_Click1" Text="&lt;&lt;" />
                &nbsp; </span>
                <asp:ListBox ID="listaJugSistema" runat="server" Height="137px" 
                    onselectedindexchanged="ListBox1_SelectedIndexChanged" Width="189px">
                </asp:ListBox>
            </div>
            </asp:Panel>
    
    </div>
    </form>
</body>
</html>
