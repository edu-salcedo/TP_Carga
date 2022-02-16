<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="TP_Carga.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>TP Carga</title>
    <link href="Style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="nav">
            <ul class="nav_link">
                <li><a href="#" class="link">inicio</a></li>
                <li><a href="#" class="link">about</a></li>
                <li><a href="#" class="link">contact</a></li>
                <li><a href="#" class="link">end</a></li>
            </ul>
        </div>

        <section class="container">

            <div class="box">

                <div class="file">
                    <asp:TextBox Style="font-family: 'Poppins', sans-serif;" placeholder="Seleccione un archivo.." readonly="true" ID="tbRuta" runat="server" CssClass="tex_ruta"></asp:TextBox>
                    <label class="lboton" for="archivo">buscar archivo</label>
                    <input id="oFile" type="file" class="boton_archivo" onchange="javascript: form1.submit();" runat="server" name="oFile" />
                </div>

                <div class="dropdown_box">
                    <label class="label-titulo">Carreras</label>
                    <asp:DropDownList ID="DCarrera" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DCarrera_SelectedIndexChanged" CssClass="dropdown"></asp:DropDownList>
                    <asp:DropDownList ID="DAltaCarrera" runat="server" AutoPostBack="true" CssClass="dropdown"></asp:DropDownList>
                </div>
                
                <div class="dropdown_box">
                    <label class="label-titulo">Descripcion</label>
                    <textarea placeholder="Descripcion..." runat="server" class="tex_descripcion"></textarea>
                </div>

                <asp:Button CssClass="boton_enviar" runat="server" Text="Enviar"/>

            </div>


        </section>
    </form>
</body>
</html>
