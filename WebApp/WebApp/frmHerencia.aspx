<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmHerencia.aspx.cs" Inherits="WebApp.frmHerencia" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Cálculo de Figuras Geométricas</title>
    <!-- Referencias a Bootstrap -->
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/css/bootstrap.min.css" crossorigin="anonymous"/>
    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.12.9/dist/umd/popper.min.js" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/js/bootstrap.min.js" crossorigin="anonymous"></script>
    <style>
        body {
            height: 989px;
            width: 653px;
            font-family: Arial, sans-serif;
            background-color: #f8f9fa;
            text-align: center;
        }
        .panel {
            background-color: #d3d3d3;
            padding: 15px;
            margin: 10px auto;
            width: 50%;
            border-radius: 10px;
        }
        img {
            width: 200px;
            height: 200px;
        }
        .radio-horizontal label {
            display: inline-block;
            margin-right: 15px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-4">
            <h1 class="font-weight-bold">Cálculo de Figuras Geométricas</h1>
            
            <label class="mt-3">Seleccione la figura que desea calcular</label>
            <div class="text-center">
                <asp:RadioButtonList ID="rblFiguras" runat="server" AutoPostBack="true" 
                    RepeatDirection="Horizontal" 
                    RepeatLayout="Flow" 
                    CssClass="radio-horizontal"
                    OnSelectedIndexChanged="rblFiguras_SelectedIndexChanged" Width="609px">
                    <asp:ListItem Text="Esfera" Value="opcEsf" Selected="True"></asp:ListItem>
                    <asp:ListItem Text="Cubo" Value="opcCub"></asp:ListItem>
                    <asp:ListItem Text="Prisma" Value="opcPri"></asp:ListItem>
                </asp:RadioButtonList>
            </div>
            
            <div class="text-center mt-3">
                <asp:Image ID="imgFigura" runat="server" ImageUrl="~/imagenes/Sphere.jpg" CssClass="img-fluid" />
                <br />
                <asp:Label ID="lblMsj" runat="server" Text="Imagen"></asp:Label>
            </div>

            <div id="pnlEsfera" class="panel" runat="server">
                <asp:Label runat="server" Text="Radio: " CssClass="font-weight-bold"></asp:Label>
                <asp:TextBox ID="txtRadio" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            
            <div id="pnlCubo" class="panel" runat="server" visible="false">
                <asp:Label runat="server" Text="Lado: " CssClass="font-weight-bold"></asp:Label>
                <asp:TextBox ID="txtLado" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            
            <div id="pnlPrima" class="panel" runat="server" visible="false">
                <asp:Label runat="server" Text="Lado A: " CssClass="font-weight-bold"></asp:Label>
                <asp:TextBox ID="txtLadoa" runat="server" CssClass="form-control"></asp:TextBox><br />
                <asp:Label runat="server" Text="Lado B: " CssClass="font-weight-bold"></asp:Label>
                <asp:TextBox ID="txtLadob" runat="server" CssClass="form-control"></asp:TextBox><br />
                <asp:Label runat="server" Text="Altura (C): " CssClass="font-weight-bold"></asp:Label>
                <asp:TextBox ID="txtAltura" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            
            <asp:Button ID="btnCalcular" runat="server" Text="Calcular" CssClass="btn btn-primary mt-3" OnClick="btnCalcular_Click" />
            
            <div id="pnlRpta" class="panel" runat="server" visible="false">
                <asp:Label runat="server" Text="Área: " CssClass="font-weight-bold"></asp:Label>
                <asp:TextBox ID="lblArea" runat="server" ReadOnly="true" CssClass="form-control"></asp:TextBox><br />
                <asp:Label runat="server" Text="Volumen: " CssClass="font-weight-bold"></asp:Label>
                <asp:TextBox ID="lblVolumen" runat="server" ReadOnly="true" CssClass="form-control"></asp:TextBox><br />
                <asp:Button ID="btnLimpiar" runat="server" Text="Limpiar" CssClass="btn btn-secondary mt-3" OnClick="btnLimpiar_Click" />
            </div>
        </div>
    </form>
</body>
</html>