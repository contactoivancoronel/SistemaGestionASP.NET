<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="Sistema._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Sistema</title>
    <style type="text/css">
        #form1
        {
            width: 767px;
            height: 800px;
            margin: auto auto;
            margin-top: auto;
            margin-bottom: auto;
        }
        .auto-style3 {
            width: 116px;
            height: 72px;
        }
        .auto-style6 {
            width: 165px;
            height: 72px;
        }
        .auto-style7 {
            width: 136px;
            height: 72px;
        }
        .auto-style8 {
            width: 83px;
            height: 72px;
        }
        .auto-style9 {
            height: 72px;
        }
        .auto-style10 {
            height: 24px;
        }
        .auto-style11 {
            height: 24px;
            width: 294px;
        }
        .auto-style12 {
            width: 265px;
        }
        .auto-style13 {
            width: 265px;
            height: 24px;
        }
        .auto-style15 {
            width: 314px;
        }
        .auto-style16 {
            height: 24px;
            width: 314px;
        }
        .auto-style17 {
            width: 265px;
            height: 33px;
        }
        .auto-style18 {
            width: 314px;
            height: 33px;
        }
        .auto-style19 {
            height: 33px;
        }
        .auto-style20 {
            width: 100%;
            height: 104px;
        }
        .auto-style23 {
            height: 30px;
        }
        .auto-style49 {
            width: 100%;
            height: 229px;
        }
        .auto-style51 {
            height: 50px;
        }
        .auto-style52 {
            height: 21px;
        }
        .auto-style53 {
            height: 66px;
        }
        .auto-style56 {
            height: 65px;
        }
        .auto-style57 {
            height: 80px;
        }
        .auto-style58 {
            width: 100%;
            height: 259px;
        }
        .auto-style64 {
            height: 61px;
        }
        .auto-style65 {
            margin-left: 28px;
        }
        .auto-style68 {
            width: 81%;
        }
        .auto-style69 {
            width: 194px;
        }
        .auto-style70 {
            width: 236px;
        }
        .auto-style71 {
            width: 88%;
            height: 47px;
        }
        .auto-style72 {
            width: 111px;
        }
        .auto-style73 {
            width: 271px;
        }
        .auto-style75 {
            width: 95%;
            height: 27px;
        }
        .auto-style76 {
            width: 194px;
            height: 25px;
        }
        .auto-style77 {
            width: 100%;
            height: 24px;
            margin-bottom: 61px;
        }
        .auto-style78 {
            width: 100%;
            height: 57px;
            margin-bottom: 100px;
        }
        .auto-style79 {
            height: 64px;
        }
        .auto-style80 {
            height: 87px;
        }
        .auto-style81 {
            width: 100%;
            height: 356px;
            margin-bottom: 0px;
        }
        .auto-style82 {
            height: 64px;
            width: 386px;
        }
        .auto-style84 {
            height: 249px;
        }
        .auto-style87 {
            height: 60px;
        }
        .auto-style88 {
            height: 34px;
        }
        .auto-style90 {
            height: 26px;
        }
        .auto-style91 {
            width: 100%;
            height: 85px;
            margin-bottom: 35px;
        }
        .auto-style92 {
            height: 94px;
        }
        .auto-style93 {
            width: 100%;
            height: 63px;
            margin-bottom: 32px;
        }
        .auto-style94 {
            height: 54px;
        }
        .auto-style98 {
            height: 50px;
            width: 199px;
        }
        .auto-style99 {
            height: 54px;
            width: 199px;
        }
        .auto-style100 {
            height: 63px;
            width: 199px;
        }
        .auto-style101 {
            height: 63px;
        }
        .auto-style102 {
            height: 63px;
            width: 375px;
        }
        .auto-style103 {
            height: 50px;
            width: 375px;
        }
        .auto-style105 {
            height: 54px;
            width: 375px;
        }
        .auto-style106 {
            height: 23px;
        }
        .auto-style107 {
            height: 27px;
            width: 916px;
        }
        .auto-style108 {
            width: 101%;
            height: 124px;
            margin-bottom: 0px;
        }
        .auto-style114 {
            height: 37px;
        }
        .auto-style116 {
            height: 59px;
        }
        .auto-style118 {
            width: 39px;
        }
        .auto-style119 {
            width: 665px;
        }
        .auto-style120 {
            width: 100%;
            height: 482px;
        }
        .auto-style121 {
            width: 39px;
            height: 45px;
        }
        .auto-style122 {
            width: 665px;
            height: 45px;
        }
        .auto-style124 {
            height: 45px;
        }
        .auto-style125 {
            width: 39px;
            height: 134px;
        }
        .auto-style126 {
            width: 665px;
            height: 134px;
            font-weight: bold;
            font-size: large;
        }
        .auto-style127 {
            height: 134px;
        }
        .auto-style128 {
            width: 39px;
            height: 31px;
        }
        .auto-style129 {
            width: 665px;
            height: 31px;
        }
        .auto-style130 {
            height: 31px;
        }
        .auto-style131 {
            width: 39px;
            height: 57px;
        }
        .auto-style132 {
            width: 665px;
            height: 57px;
        }
        .auto-style133 {
            height: 57px;
        }
        .auto-style136 {
            width: 281px;
        }
        .auto-style137 {
            width: 224px;
            height: 26px;
        }
        .auto-style138 {
            width: 224px;
        }
        .auto-style139 {
            height: 51px;
        }
        .auto-style140 {
            width: 100%;
            height: 105px;
        }
        .auto-style141 {
            width: 116px;
            height: 43px;
        }
        .auto-style142 {
            width: 136px;
            height: 43px;
        }
        .auto-style143 {
            width: 83px;
            height: 43px;
        }
        .auto-style144 {
            width: 165px;
            height: 43px;
        }
        .auto-style145 {
            height: 43px;
        }
        .auto-style146 {
            height: 28px;
        }
        .auto-style147 {
            width: 100%;
            height: 186px;
            margin-bottom: 100px;
        }
        .auto-style148 {
            height: 82px;
        }
        .auto-style149 {
            height: 87px;
            width: 916px;
        }
        .auto-style150 {
            width: 916px;
        }
        </style>
</head>
<body bgcolor="#ffffff">
    <form id="form1" runat="server" >

            <asp:Panel ID="pPortada" runat="server" Height="350px" Width="7650px">
            <asp:ImageButton ID="bPortada" runat="server" ImageAlign="Middle" ImageUrl="~/imagenes/fondoppal.jpg" Width="761px" Height="314px" />
        </asp:Panel>

        <asp:Panel ID="pLogin" runat="server"  Height="574px"  ForeColor="Blue" Width="751px"   BackImageUrl="~/imagenes/fondoheladeria.jpg" Visible="false" >
            <table style="width:100%;">
                <tr>
                    <td>
                        <asp:Label ID="lVersion" runat="server" Font-Bold="true" Text="Versión">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        </asp:Label>
                    </td>
                </tr>
               <tr>
                   <td align="center">
                       <asp:Label ID="lIngresa" runat="server" Font-Bold="True"  Text="Ingresá tu Usuario y Clave!" ></asp:Label>
                   </td>
               </tr>
                <tr>
                    <td align="center">&nbsp;</td>
                </tr>
                <tr>
                    <td align="center">
                        <table class="auto-style140">
                            <tr>
                                <td class="auto-style3">
                                    <asp:Label ID="lUsuario" runat="server" Text="Usuario:" ></asp:Label>
                                </td>
                                <td class="auto-style7">
                                    <asp:TextBox ID="tUsuario" runat="server"  ForeColor="Black" Width="135px" Height="28px" ></asp:TextBox>
                                </td>
                                <td class="auto-style8">
                                    <asp:Label ID="lClave" runat="server"  Text="Clave:" ></asp:Label>
                                </td>
                                <td class="auto-style6">
                                    <asp:TextBox ID="tClave" runat="server" ForeColor="Black" Height="28px" Width="135px" TextMode="Password" ></asp:TextBox>
                                </td>
                                <td class="auto-style9">
                                    <asp:RadioButtonList ID="rRol" runat="server" Font-Size="Small" ForeColor="Black" Height="70px" Width="75px">
                                        <asp:ListItem>Usuario</asp:ListItem>
                                        <asp:ListItem>Admin</asp:ListItem>
                                    </asp:RadioButtonList>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style141"></td>
                                <td class="auto-style142"></td>
                                <td class="auto-style143"></td>
                                <td class="auto-style144"></td>
                                <td class="auto-style145">
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td align="center">
                        <asp:ImageButton ID="bEntrar" runat="server" Height="68px" ImageUrl="~/imagenes/entrar.png" Width="177px" />
                    </td>
                </tr>
                <tr>
                    <td align="center">
                        <asp:Label ID="lErrorLogin" runat="server" Font-Size="X-Large" ForeColor="Red" Text="Error Login" Visible="False"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="center">
                        <table style="width:100%;">
                            <tr>
                                <td class="auto-style11"><asp:ImageButton ID="bRecuperarClave" runat="server" Height="61px" ImageUrl="~/imagenes/reenviarclave.png" Width="497px" /></td>
                                <td class="auto-style10">
                                    <asp:Label ID="lReenviarClave" runat="server" Text="[lReenviarClave]" Visible="False" ForeColor="Red"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style11">&nbsp;</td>
                                <td class="auto-style10">&nbsp;</td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
            <table style="width:100%;">
                <tr>
                    <td align="center">
                        <asp:ImageButton ID="bVolverLogin" runat="server" Height="68px" ImageUrl="~/imagenes/terminarvolver1.png" Width="259px" />
                    </td>
                    
                </tr>
            </table>
        </asp:Panel>

        <asp:Panel ID="pLoginMenu" runat="server" BackImageUrl="~/imagenes/fondoheladeria.jpg" Height="392px" Font-Bold="True" ForeColor="Blue" Width="757px" Font-Size="Large" BorderStyle="Solid" Visible="false">
            <table style="width:100%;">
                <tr>
                    <td align="center">
                        Bienvenido!</td>
                </tr>
                <tr>
                    <td align="center">
                        <asp:ImageButton ID="bRegistrarse" runat="server" ImageUrl="~/imagenes/registrateaqui1.png" Width="753px" />
                    </td>
                </tr>
                <tr>
                    <td align="center">
                        <asp:ImageButton ID="bAlogin" runat="server" ImageUrl="~/imagenes/yaregistrado1.png" Width="753px" />
                    </td>
                </tr>
                <tr>
                   <td align="center">
                        <asp:ImageButton ID="bRegistrarseVolverLoginU13" runat="server" ImageUrl="~/imagenes/terminarvolver1.png" Width="281px" Height="82px" />
                    </td>
                </tr>
            </table>
        </asp:Panel>

        <asp:Panel ID="pRegistrarse" runat="server"  Height="950px" Visible="False"  style="margin-right: 0px" BackImageUrl="~/imagenes/fondoheladeria.jpg" >
            <table style="width:100%;">
                <tr>
                    <td align="center" colspan="2">
                        CREAR CUENTA</td>
                </tr>
                <tr>
                    <td colspan="2" >Para poder registrarte debés ser mayor de 18 años, residir en Argentina y contar con documento válido en Argentina que acredite tu identidad.
                        <br />
                        Sólo se puede hacer un registro por documento. Los datos deben ser reales, correctos y vigentes.<br /> Todos los datos a continuación (menos Origen) son obligatorios:</td>
                </tr>
                <tr>
                    <td colspan="2">&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2">
                        <table style="width:100%;">
                            <tr>
                                <td class="auto-style13" >Tu/s Nombre/s:</td>
                                <td class="auto-style16">
                                    <asp:TextBox ID="tNombreU" runat="server"  ForeColor="Black" Height="25px" MaxLength="20" Width="256px"></asp:TextBox>
                                </td>
                                <td class="auto-style10">
                                    <asp:Label ID="lENombreU" runat="server"  Text="ENombreU" Visible="False"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style12">Apellido/s:</td>
                                <td class="auto-style15">
                                    <asp:TextBox ID="tApellidoU" runat="server"  ForeColor="Black" Height="25px" MaxLength="20" Width="256px"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:Label ID="lEApellidoU" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="EApellidoU" Visible="False"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style17">Tipo Doc.:</td>
                                <td class="auto-style18">
                                    <asp:DropDownList ID="dTDocU" runat="server"  ForeColor="Black" Height="89px" Width="262px">
                                        <asp:ListItem Value="DNI">Doc. Nacional de Identidad</asp:ListItem>
                                        <asp:ListItem Value="LC">Libreta Cívica</asp:ListItem>
                                        <asp:ListItem Value="LE">Libreta de Enrolamiento</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                                <td class="auto-style19"></td>
                            </tr>
                            <tr>
                                <td class="auto-style12"> N° de Doc. (sin puntos ni espacios):</td>
                                <td class="auto-style15">
                                    <asp:TextBox ID="tDocU" runat="server" BackColor="White" ForeColor="Black" Height="25px" MaxLength="8" Width="256px"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:Label ID="lEDocU" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="IEDocU" Visible="False"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style12" >Fecha Nac.: (ddmmaa)</td>
                                <td class="auto-style15">
                                    <asp:TextBox ID="tF_Nac" runat="server" BackColor="White" ForeColor="Black" Height="25px" MaxLength="8" Width="166px"></asp:TextBox>
                                    <asp:Label ID="lEdad" runat="server" Text="0"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="lEFNac" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="IEFNac" Visible="False"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style12" >Email válido para notificaciones:</td>
                                <td class="auto-style15">
                                    <asp:TextBox ID="tEmailU" runat="server" BackColor="White" ForeColor="Black" Height="26px" MaxLength="70" Rows="2" TextMode="MultiLine" Width="256px"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:Label ID="lEEmailU" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="IEEmailU" Visible="False"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style12" >Provincia:</td>
                                <td class="auto-style15">
                                    <asp:DropDownList ID="didProvU" runat="server" BackColor="White" Font-Size="Large" ForeColor="Black" Height="89px" Width="262px">
                                        <asp:ListItem>Buenos Aires</asp:ListItem>
                                        <asp:ListItem>CABA</asp:ListItem>
                                        <asp:ListItem>Catamarca</asp:ListItem>
                                        <asp:ListItem>Chaco</asp:ListItem>
                                        <asp:ListItem>Chubut</asp:ListItem>
                                        <asp:ListItem>Córdoba</asp:ListItem>
                                        <asp:ListItem>Corrientes</asp:ListItem>
                                        <asp:ListItem>Entre Ríos</asp:ListItem>
                                        <asp:ListItem>Formosa</asp:ListItem>
                                        <asp:ListItem>Jujuy</asp:ListItem>
                                        <asp:ListItem>La Pampa</asp:ListItem>
                                        <asp:ListItem>La Rioja</asp:ListItem>
                                        <asp:ListItem>Mendoza</asp:ListItem>
                                        <asp:ListItem>Misiones</asp:ListItem>
                                        <asp:ListItem>Neuquén</asp:ListItem>
                                        <asp:ListItem>Río Negro</asp:ListItem>
                                        <asp:ListItem>Salta</asp:ListItem>
                                        <asp:ListItem>San Juan</asp:ListItem>
                                        <asp:ListItem>San Luis</asp:ListItem>
                                        <asp:ListItem>Santa Cruz</asp:ListItem>
                                        <asp:ListItem>Santa Fe</asp:ListItem>
                                        <asp:ListItem>Santiago del Estero</asp:ListItem>
                                        <asp:ListItem>Tierra del Fuego</asp:ListItem>
                                        <asp:ListItem>Tucumán</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style12" >Localidad:</td>
                                <td class="auto-style15">
                                    <asp:TextBox ID="tLocalidadU" runat="server" BackColor="White" ForeColor="Black" Height="25px" MaxLength="20" Width="256px"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:Label ID="lELocalidadU" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="IELocalidadU" Visible="False"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style12" >Dirección:</td>
                                <td class="auto-style15">
                                    <asp:TextBox ID="tDireccionU" runat="server" BackColor="White" ForeColor="Black" Height="48px" MaxLength="100" Rows="2" TextMode="MultiLine" Width="256px"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:Label ID="lEDireccionU" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="IEDireccionU" Visible="False"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style12">Teléfono (agregue característica):</td>
                                <td class="auto-style15">
                                    <asp:TextBox ID="tTelefonosU" runat="server" BackColor="White" ForeColor="Black" Height="25px" MaxLength="20" Width="256px"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:Label ID="lETelefonosU" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="IETelefonosU" Visible="False"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style12">Usuario:</td>
                                <td class="auto-style15">
                                    <asp:TextBox ID="tUsuarioU" runat="server" BackColor="White" ForeColor="Black" Height="25px" MaxLength="20" Width="256px"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:Label ID="lEUsuarioU" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="IEUsuarioU" Visible="False"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style12">Clave:</td>
                                <td class="auto-style15">
                                    <asp:TextBox ID="tPassU" runat="server" BackColor="White" ForeColor="Black" Height="25px" MaxLength="10" Width="256px" TextMode="Password"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:Label ID="lEPassU" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="IEPassU" Visible="False"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style12">Repetir Clave:</td>
                                <td class="auto-style15">
                                    <asp:TextBox ID="tPass2U" runat="server" BackColor="White" ForeColor="Black" Height="25px" MaxLength="10" Width="256px" TextMode="Password"></asp:TextBox>
                                </td>
                                <td>
                                    <asp:Label ID="lEPass2U" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="IEPass2U" Visible="False"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style13">
                                    <asp:Label ID="lErroresU" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="lErroresU" Visible="False"></asp:Label>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td align="center">
                        <asp:ImageButton ID="bRegistrarseU" runat="server" ImageUrl="~/imagenes/registrateaqui1.png" Height="76px" Width="246px" />
                    </td>
                    <td align="center">
                        <asp:ImageButton ID="bRegistrarseU0" runat="server" ImageUrl="~/imagenes/cancelarvolver1.png" Height="79px" Width="246px" />
                    </td>
                </tr>
            </table>
        </asp:Panel>
        
        <asp:Panel ID="pBienvenido" runat="server" BorderColor="#66CCFF" Height="320px" BackImageUrl="~/imagenes/fondoheladeria.jpg" ForeColor="Black" Font-Size="Large" Visible="false" Width="767px" >
            <table style="width:100%;">
                <tr>
                    <td align="center">
                        <asp:Label ID="lBienvenido" runat="server" Text="Bienvenido!"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Registro con exito.
                        <br />
                        Ya puede iniciar sesion y comenzar a utilizar las funciones que brinda nuestra aplicacion.</td>
                </tr>
                <tr>
                    <td align="center">
                        
                        <asp:ImageButton ID="bRegistrarseVolverLoginU" runat="server" ImageUrl="~/imagenes/todook1.png" Height="90px" Width="287px"/>
                    </td>
                    </tr>
                </table>
            </asp:Panel>
                        <asp:Panel ID="pAreaUsuario" runat="server" BackImageUrl="~/imagenes/fondoheladeria.jpg" Height="450px" Visible="False" Width="764px">
                            <table class="auto-style20" >
                                <tr>
                                    <td align="center" class="auto-style23">
                                        <asp:Label ID="lBienvenidoAreaU" runat="server" Text="Bienvenido al panel"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center">
                                        <asp:ImageButton ID="bAhoraQueHago" runat="server" ImageUrl="~/imagenes/ahora_que_hago1.png" Height="99px" Width="389px"/>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center">
                                        <asp:Label ID="Label1" runat="server" Font-Size="Large"  Text="Gestioná tu cuenta, revisa o realiza nuevos pedidos:"></asp:Label>
                                    </td>
                                </tr>
                               
                                    <tr>
                                    <td align="center">
                                        &nbsp;</td>
                                    </tr>
                                <tr>
                                <td align="center">
                                    <asp:ImageButton ID="bVerHistorico" runat="server" Height="72px" ImageUrl="~/imagenes/vertodosmov1.png" Width="462px" />
                                </td>
                                </tr>
                                <tr>
                                    <td align="center">
                                        <asp:ImageButton ID="bModificarDatos" runat="server" Height="72px" ImageUrl="~/imagenes/modificardatos1.png" Width="463px" />
                                    </td>
                                </tr>
                              
                                <tr>
                                    <td align="center">
                                        <asp:ImageButton ID="bVolverLoginU1" runat="server" Height="74px" ImageUrl="~/imagenes/terminarvolver1.png" Width="260px" />
                                    </td>
                                </tr>
                                
                            </table>
                        </asp:Panel>
                        <asp:Panel ID="pAhoraQueHago" runat="server" BackImageUrl="~/imagenes/fondoheladeria.jpg" Height="440px" Visible="False">
                            <table class="auto-style49" >
                                <tr>
                                    <td align="center" class="auto-style51">
                                        Bienvenido!</td>
                                </tr>
                                <tr>
                                    <td class="auto-style52"></td>
                                </tr>
                                <tr>
                                    <td align="center" class="auto-style53">
                                        Los botones en el panel de usuario te indican las funciones que podes realizar pulsando click en cada uno de ellos.</td>
                                </tr>
                                <tr>
                                    <td align="left" class="auto-style87">
                                        &nbsp;</td>
                                </tr>
                               
                                <tr>
                                    <td align="center">
                                        <asp:ImageButton ID="bVolverLoginU2" runat="server" Height="64px" ImageUrl="~/imagenes/terminarvolver1.png" Width="244px" />
                                       
                                        
                                        
                                    </td>
                                </tr>
                            </table>
                            </asp:Panel>
                            <asp:Panel ID="pCambiarDatosPersonales" runat="server" Height="800px" Visible="False" BackImageUrl="~/imagenes/datospersonales1.jpg" HorizontalAlign="center">
                                            <table style="width:100%";>
                                                <tr>  
                                                <td class="auto-style136"></td>
                                                </tr>
                                            </table>
                                                
                                <table style="width:100%; ">
                                                <tr>
                                                    <td class="auto-style138">&nbsp;</td>
                                                    <td class="auto-style26">&nbsp;</td>
                                                </tr>
                                                <tr>

                                                    <td class="auto-style138">&nbsp;</td>
                                                    <td class="auto-style43" align="center">
                                                        MODIFICACION DE DATOS PERSONALES</td>
                                                </tr>
                                                <tr>
                                                    <td class="auto-style137"></td>
                                                    <td class="auto-style90"></td>
                                                    <td class="auto-style90"></td>
                                                </tr>
                                                <tr>
                                                    <td class="auto-style138">
                                                        <asp:Label ID="lEmailCambiar" runat="server" Font-Bold="True"  Text="Email válido para notificaciones:"></asp:Label>
                                                    </td>
                                                    <td class="auto-style43">
                                                        <asp:TextBox ID="tEmailCambiar" runat="server" BackColor="White" ForeColor="Black" Height="26px" MaxLength="70" Rows="2" TextMode="MultiLine" Width="256px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="lEEmailUCambiar" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="#CC0000" Text="EEmailU" Visible="False"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="auto-style138">
                                                        <asp:Label ID="lProvCambiar" runat="server" Font-Bold="True"  Text="Provincia:"></asp:Label>
                                                    </td>
                                                    <td class="auto-style43">
                                                        <asp:DropDownList ID="didProvUCambiar" runat="server" BackColor="White" Font-Size="Large" ForeColor="Black" Height="89px" Width="262px">
                                                            <asp:ListItem>Buenos Aires</asp:ListItem>
                                                            <asp:ListItem>CABA</asp:ListItem>
                                                            <asp:ListItem>Catamarca</asp:ListItem>
                                                            <asp:ListItem>Chaco</asp:ListItem>
                                                            <asp:ListItem>Chubut</asp:ListItem>
                                                            <asp:ListItem>Córdoba</asp:ListItem>
                                                            <asp:ListItem>Corrientes</asp:ListItem>
                                                            <asp:ListItem>Entre Ríos</asp:ListItem>
                                                            <asp:ListItem>Formosa</asp:ListItem>
                                                            <asp:ListItem>Jujuy</asp:ListItem>
                                                            <asp:ListItem>La Pampa</asp:ListItem>
                                                            <asp:ListItem>La Rioja</asp:ListItem>
                                                            <asp:ListItem>Mendoza</asp:ListItem>
                                                            <asp:ListItem>Misiones</asp:ListItem>
                                                            <asp:ListItem>Neuquén</asp:ListItem>
                                                            <asp:ListItem>Río Negro</asp:ListItem>
                                                            <asp:ListItem>Salta</asp:ListItem>
                                                            <asp:ListItem>San Juan</asp:ListItem>
                                                            <asp:ListItem>San Luis</asp:ListItem>
                                                            <asp:ListItem>Santa Cruz</asp:ListItem>
                                                            <asp:ListItem>Santa Fe</asp:ListItem>
                                                            <asp:ListItem>Santiago del Estero</asp:ListItem>
                                                            <asp:ListItem>Tierra del Fuego</asp:ListItem>
                                                            <asp:ListItem>Tucumán</asp:ListItem>
                                                        </asp:DropDownList>
                                                    </td>
                                                    <td>&nbsp;</td>
                                                </tr>
                                                <tr>
                                                    <td class="auto-style138">
                                                        <asp:Label ID="lLocalidadCambiar" runat="server" Font-Bold="True" Text="Localidad:"></asp:Label>
                                                    </td>
                                                    <td class="auto-style43">
                                                        <asp:TextBox ID="tLocalidadUCambiar" runat="server" BackColor="White" ForeColor="Black" Height="25px" MaxLength="20" Width="256px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="lELocalidadUCambiar" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="#CC0000" Text="ELocalidadU" Visible="False"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="auto-style138">
                                                        <asp:Label ID="lDireccionCambiar" runat="server" Font-Bold="True"  Text="Dirección:"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="tDireccionUCambiar" runat="server" BackColor="White" ForeColor="Black" Height="48px" MaxLength="100" Rows="2" TextMode="MultiLine" Width="256px"></asp:TextBox>
                                                    </td>
                                                    <td class="auto-style26">
                                                        <asp:Label ID="lEDireccionUCambiar" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="#CC0000" Text="EDireccionU" Visible="False"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="auto-style138">
                                                        <asp:Label ID="lTelefonoCambiar" runat="server" Font-Bold="True"  Text="Teléfono (agregue característica):"></asp:Label>
                                                    </td>
                                                    <td class="auto-style44">
                                                        <asp:TextBox ID="tTelefonosUCambiar" runat="server" BackColor="White" ForeColor="Black" Height="25px" MaxLength="20" Width="256px"></asp:TextBox>
                                                    </td>
                                                    <td class="auto-style26">
                                                        <asp:Label ID="lETelefonosUCambiar" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="#CC0000" Text="ETelefonosU" Visible="False"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="auto-style138">
                                                        <asp:Label ID="lUsuarioCambiar" runat="server" Font-Bold="True" Text="Usuario:"></asp:Label>
                                                    </td>
                                                    <td class="auto-style43">
                                                        <asp:TextBox ID="tUsuarioUCambiar" runat="server" BackColor="White" ForeColor="Black" Height="25px" MaxLength="20" Width="256px"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="lEUsuarioUCambiar" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="#CC0000" Text="EUsuarioU" Visible="False"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td class="auto-style138">
                                                        <asp:Label ID="lPassCambiar" runat="server" Font-Bold="True"  Text="Clave:"></asp:Label>
                                                    </td>
                                                    <td class="auto-style43">
                                                        <asp:TextBox ID="tPassUCambiar" runat="server" BackColor="White" ForeColor="Black" Height="25px" MaxLength="10" Width="256px" TextMode="Password"></asp:TextBox>
                                                    </td>
                                                    <td>
                                                        <asp:Label ID="lEPassUCambiar" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="#CC0000" Text="EPassU" Visible="False"></asp:Label>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="center" class="auto-style138">&nbsp;</td>
                                                    <td class="auto-style43">
                                                        <asp:Label ID="lErrorCambiar" runat="server" Font-Bold="True" Font-Size="X-Large" Font-Strikeout="False" ForeColor="#CC0000" Text="Error" Visible="False"></asp:Label>
                                                    </td>
                                                    <td></td>
                                                </tr>
                                                <tr>
                                                    <td align="center" class="auto-style138">&nbsp;</td>
                                                    <td class="auto-style43">
                                                        <table style="width:100%;">
                                                            <tr>
                                                                <td> &nbsp;</td>
                                                                <td> &nbsp;</td>
                                                            </tr>
                                                        </table>
                                                    </td>
                                                    <td>&nbsp;</td>
                                                </tr>
                                            </table>
                                            <table style="width:100%;">
                                                <tr>
                                                    <td>
                                                        <asp:ImageButton ID="bCambiarDatos" runat="server" Height="74px" ImageUrl="~/imagenes/cambiarlosdatos1.png" Width="260px" />
                                                    </td>
                                                    <td>
                                                        <asp:ImageButton ID="bCancelarCambios" runat="server" Height="74px" ImageUrl="~/imagenes/cancelarvolver1.png" Width="260px" />
                                                    </td>
                                                </tr>
                                            </table>
                                        </asp:Panel>
                                        
                                        <asp:Panel ID="pDatosCambiados" runat="server" BackImageUrl="~/imagenes/datospersonales1.jpg" Height="523px" Width="764px" Visible="False">
                                            <table class="auto-style58">
                                                <tr>
                                                    <td class="auto-style56"></td>
                                                </tr>
                                                <tr>
                                                    <td class="auto-style57" align="center" >
                                                        Operacion realizada correctamente.</td>
                                                </tr>
                                                <tr>
                                                    <td align="center">
                                                        <asp:ImageButton ID="bVolverAreaUsuario" runat="server" Height="73px" ImageUrl="~/imagenes/volveratuarea1.png" Width="357px" />
                                                    </td>
                                                </tr>
                                            </table>
                          
                                        </asp:Panel>
                            <asp:Panel ID="pPedidos" runat="server"  Height="450px" BackImageUrl="~/imagenes/fondoheladeria.jpg" Width="764px" Visible="False">
                                <table style="width:100%;">
                                    <tr>
                                        <td class="auto-style57"  align="center">
                                            PEDIDOS</td>
                                    </tr>
                                    <tr>
                                        <td align="center">
                                            <asp:ImageButton ID="ImageButton2" runat="server" Height="73px" ImageUrl="~/imagenes/nuevopedido1.png" Width="357px" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="center">
                                            <asp:ImageButton ID="ImageButton3" runat="server" Height="73px" ImageUrl="~/imagenes/todoslospedidos1.png" Width="357px" />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style139"></td>
                                    </tr>
                                    <tr>
                                        <td align="center">
                                            <asp:ImageButton ID="ImageButton4" runat="server" Height="73px" ImageUrl="~/imagenes/terminarvolver1.png" Width="357px" />
                                        </td>
                                    </tr>
                                </table>
                                         
                                        </asp:Panel>
                            <asp:Panel ID="pNuevoPedido" runat="server"  BackImageUrl="~/imagenes/fondoheladeria.jpg" Height="814px" Width="764px" Visible="False" >
                                <table style="margin-bottom:20px" class="auto-style61">
                                    <tr>
                                        <td class="auto-style64">
                                            NUEVO PEDIDO</td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style88">&nbsp;&nbsp;<asp:Button ID="bInstrucciones" runat="server" CssClass="auto-style65" Text="Abrir Instrucciones" Width="188px" />
                                            &nbsp;<asp:Label ID="lInstrucciones" runat="server" Text="Instrucciones"></asp:Label>
                                        </td>
                                    </tr>
                                  
                                 
                                    <tr>
                                        <td class="auto-style90">
                                            &nbsp;<asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Size="Large" Text="Seleccione el producto deseado:"></asp:Label>
                                        </td>
                                    </tr>
                                   
                                    <tr>
                                        <td>
                                            <asp:DropDownList ID="dProductos" runat="server" BackColor="White" Font-Bold="True" Height="64px" Width="755px" AutoPostBack="True">
                                            </asp:DropDownList>
                                        </td>
                                    </tr>
                                </table>
                         
                                         
                                        <table class="auto-style68" align="center">
                                            <tr>
                                                <td class="auto-style69">Agregar:</td>
                                                <td class="auto-style70">
                                                    <asp:Label ID="lCosaAgregar" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Label" Visible="False"></asp:Label>
                                                </td>
                                                <td>
                                                    <asp:Label ID="lQueEs" runat="server" Text="Label" Visible="False"></asp:Label>
                                                </td>
                                            </tr>
                                </table>
                         
                                         <table class="auto-style71" align="center">
                                            <tr>
                                                <td class="auto-style73">Cantidad de unidades:</td>
                                                <td class="auto-style72">
                                                    <asp:DropDownList ID="tCantLatas" runat="server" BackColor="White" Font-Bold="True" Font-Size="X-Large" ForeColor="Black" Height="50px" Width="96px">
                                                        <asp:ListItem Value="1"></asp:ListItem>
                                                        <asp:ListItem Value="2"></asp:ListItem>
                                                        <asp:ListItem Value="3"></asp:ListItem>
                                                        <asp:ListItem Value="4"></asp:ListItem>
                                                        <asp:ListItem Value="5"></asp:ListItem>
                                                        <asp:ListItem Value="6"></asp:ListItem>
                                                        <asp:ListItem Value="7"></asp:ListItem>
                                                        <asp:ListItem Value="8"></asp:ListItem>
                                                        <asp:ListItem Value="9"></asp:ListItem>
                                                        <asp:ListItem Value="10"></asp:ListItem>
                                                        <asp:ListItem Value="11"></asp:ListItem>
                                                        <asp:ListItem Value="12"></asp:ListItem>
                                                        <asp:ListItem Value="13"></asp:ListItem>
                                                    </asp:DropDownList>
                                                </td>
                                                <td align="center">
                                                    <asp:ImageButton ID="bAgregarALista" runat="server" Height="73px" ImageUrl="~/imagenes/agregar1.png" Width="209px" />
                                                </td>
                                            </tr>
                                </table>
                                <table class="auto-style75" align="center">
                                            <tr>
                                                <td class="auto-style76">Lista de productos:</td>
                                            </tr>
                                            <tr>
                                                <td class="auto-style76">
                                                    <asp:GridView ID="gListaPedido" runat="server" AutoGenerateColumns="False" CellPadding="4" Width="736px" ForeColor="#333333" GridLines="None">
                                                        <AlternatingRowStyle BackColor="White" />
                                                        <Columns>
                                                            <asp:ButtonField ButtonType="Image" CommandName="Quitar" ImageUrl="~/imagenes/quitar2.png" Text="Quitar" />
                                                            <asp:BoundField DataField="Item" HeaderText="Item Solicitado" />
                                                            <asp:BoundField DataField="Cantidad" HeaderText="Cant." />
                                                        </Columns>
                                                        <EditRowStyle BackColor="#2461BF" />
                                                        <FooterStyle BackColor="#507CD1" ForeColor="White" Font-Bold="True" />
                                                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                                        <PagerStyle ForeColor="White" HorizontalAlign="Center" BackColor="#2461BF" />
                                                        <RowStyle BackColor="#EFF3FB" />
                                                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                                        <SortedAscendingCellStyle BackColor="#F5F7FB" />
                                                        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                                                        <SortedDescendingCellStyle BackColor="#E9EBEF" />
                                                        <SortedDescendingHeaderStyle BackColor="#4870BE" />
                                                    </asp:GridView>
                                                </td>
                                            </tr>
                                </table>
                                <table class="auto-style68" align="center">
                                            <tr>
                                                <td class="auto-style69">
                                                    <asp:ImageButton ID="bQuitarTodos" runat="server" Height="73px" ImageUrl="~/imagenes/quitartodos1.png" Width="209px" />
                                                </td>
                                                <td class="auto-style70">
                                                    <asp:ImageButton ID="bSolicitarPedido" runat="server" Height="73px" ImageUrl="~/imagenes/solicitar1.png" Width="209px" />
                                                </td>
                                                <td>
                                                   <asp:ImageButton ID="bCancelarPedido" runat="server" Height="73px" ImageUrl="~/imagenes/cancelarpedido1.png" Width="209px" />
                                                </td>
                                            </tr>
                                </table>
                                        <asp:Label ID="lErrorPedido" runat="server" ForeColor="#CC3300" Text="lErrorPedido" Visible="False"></asp:Label>
                                        </asp:Panel>
                         <asp:Panel ID="pPedidoCreado" runat="server" BackImageUrl="~/imagenes/fondoheladeria.jpg" Height="365px" Width="764px" Visible="False">
                             <table class="auto-style77">
                                 <tr>
                                     <td class="auto-style106"></td>
                                     <td class="auto-style106"></td>
                                     <td class="auto-style106"></td>
                                 </tr>

                             </table>
                               <table class="auto-style78" align="center">
                                 <tr>
                                     
                                     <td align="center" class="auto-style79">
                                         <asp:Label ID="lPedidoCreado" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Label"></asp:Label>
                                     </td>
                                  
                                 </tr>

                             </table>
                              <table class="auto-style78" align="center">
                                 <tr>
                                     
                                     <td align="center" class="auto-style79">
                                       <asp:ImageButton ID="bTerminaryVolverPedido" runat="server" Height="73px" ImageUrl="~/imagenes/terminarvolver1.png" Width="331px" />
                                     </td>
                                  
                                 </tr>

                             </table>

                            </asp:Panel>
                        <asp:Panel ID="pHistorico" runat="server"  Height="486px" BackImageUrl="~/imagenes/fondoheladeria.jpg" Width="764px" Visible="False">
                            <table class="auto-style81" >
                                <tr>
                                    <td class="auto-style80" align="center">
                                        HISTORICO DE PEDIDOS Y REVISAR ESTADO</td>
                                </tr>
                                <tr>
                                    <td align="center">
                                        <asp:Label ID="lErrorHistorico" runat="server" ForeColor="#CC0000" Text="lErrorHistorico"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:GridView ID="gHistorico" runat="server" AutoGenerateColumns="False" CellPadding="4" Width="753px"  ForeColor="#333333" GridLines="None">
                                            <AlternatingRowStyle BackColor="White" />
                                            <Columns>
                                                <asp:ButtonField ButtonType="Button" CommandName="Ver" Text="Ver Pedido" />
                                                <asp:ButtonField ButtonType="Button" CommandName="Anular" HeaderText="(sólo &quot;Solicitado&quot;)" Text="Anular Pedido" />
                                                <asp:BoundField DataField="NPedido" HeaderText="N° Pedido" />
                                                <asp:BoundField DataField="fecha" DataFormatString="{0:dd/MM/yyyy HH:mm:tt}" HeaderText="Fecha y Hora" ReadOnly="True" />
                                                <asp:BoundField DataField="estado" HeaderText="Estado del Pedido" />
                                            </Columns>
                                            <EditRowStyle BackColor="#2461BF" />
                                            <FooterStyle BackColor="#507CD1" ForeColor="White" Font-Bold="True" />
                                            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                            <PagerStyle ForeColor="White" HorizontalAlign="Center" BackColor="#2461BF" />
                                            <RowStyle BackColor="#EFF3FB" />
                                            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                            <SortedAscendingCellStyle BackColor="#F5F7FB" />
                                            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                                            <SortedDescendingCellStyle BackColor="#E9EBEF" />
                                            <SortedDescendingHeaderStyle BackColor="#4870BE" />
                                        </asp:GridView>
                                    </td>
                                </tr>
                            </table>
                             <table class="auto-style78" align="center">
                                 <tr>
                                     
                                     <td align="center" class="auto-style82">
                                       <asp:ImageButton ID="bActualizar" runat="server" Height="73px" ImageUrl="~/imagenes/actualizar1.png" Width="239px" />
                                     </td>
                                     <td align="center" class="auto-style79">
                                       <asp:ImageButton ID="bTerminarHistorico" runat="server" Height="73px" ImageUrl="~/imagenes/terminarvolver1.png" Width="289px" />
                                     </td>
                                  
                                 </tr>

                             </table> 

                        </asp:Panel>
                        <asp:Panel ID="pVerUnPedido" runat="server"  Height="577px" BackImageUrl="~/imagenes/fondoheladeria.jpg" Width="764px" Visible="False">
                            <table style="width:100%;>
                                <tr>
                                    <td class="auto-style83" align="center">
                                        <asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Detalle del Pedido N°"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style84" align="center">
                                        <asp:GridView ID="gVerUnPedido" runat="server" AutoGenerateColumns="False" CellPadding="4" Height="274px" Width="713px" ForeColor="#333333" GridLines="None">
                                            <AlternatingRowStyle BackColor="White" />
                                            <Columns>
                                                <asp:BoundField DataField="Item" HeaderText="Item Solicitado" />
                                                <asp:BoundField DataField="Cantidad" HeaderText="Cant." />
                                            </Columns>
                                            <EditRowStyle BackColor="#2461BF" />
                                            <FooterStyle BackColor="#507CD1" ForeColor="White" Font-Bold="True" />
                                            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                            <PagerStyle ForeColor="White" HorizontalAlign="Center" BackColor="#2461BF" />
                                            <RowStyle BackColor="#EFF3FB" />
                                            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                            <SortedAscendingCellStyle BackColor="#F5F7FB" />
                                            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                                            <SortedDescendingCellStyle BackColor="#E9EBEF" />
                                            <SortedDescendingHeaderStyle BackColor="#4870BE" />
                                        </asp:GridView>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style106"></td>
                                </tr>
                                <tr>
                                    <td align="center">
                                        <asp:Label ID="lErrorVerUnPedido" runat="server" ForeColor="#CC0000" Text="lErrorVerUnPedido" Visible="False"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td align="center">
                                         <asp:ImageButton ID="bTerminarVerPedido" runat="server" Height="63px" ImageUrl="~/imagenes/terminarvolver1.png" Width="261px" />
                                    </td>
                                </tr>
                            </table>

                            </asp:Panel>

            <asp:Panel ID="pAdministrador" runat="server" BackImageUrl="~/imagenes/fondoheladeria.jpg" Height="649px" Width="761px" Visible="False" >
                <table class="auto-style91">
                    <tr>
                        <td align="center">
                            <asp:Label ID="lBienvenidoAdmin" runat="server" Font-Bold="True"  Text="Menu de administración:"></asp:Label>
                        </td>
                    </tr>
                </table>
                <table class="auto-style91">
                    <tr>
                        <td class="auto-style80" align="center">
                            <asp:Button ID="bAdministrar" runat="server" Height="50px" Text="Administrar Productos" Width="210px"/>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style92" align="center">
                            <asp:Button ID="bVerPedidos" runat="server" Height="50px" Text="Ver Pedidos" Width="181px"  />
                        </td>
                    </tr>
                     <tr>
                        <td class="auto-style92" align="center">
                            <asp:Button ID="bModerar" runat="server" Height="50px" Text="Moderación de Usuarios" Width="237px"  />
                        </td>
                    </tr>
                      <tr>
                        <td class="auto-style92" align="center">
                            <asp:Button ID="bTerminarA" runat="server" Height="56px" Text="Terminar y Volver" Width="184px" />
                        </td>
                    </tr>
                </table>

            </asp:Panel>

        <asp:Panel ID="pProductosA" runat="server" BackImageUrl="~/imagenes/fondoheladeria.jpg" Height="600px" Width="764px" Visible="False">
                             <table class="auto-style77">
                                 <tr>
                                     <td class="auto-style106"></td>
                                     <td class="auto-style106"></td>
                                     <td class="auto-style106"></td>
                                 </tr>

                             </table>
                               <table class="auto-style147" align="center">
                                 <tr>
                                     
                                     <td align="center" class="auto-style79">
                                         <asp:Button ID="bAgregarP" runat="server" Height="52px" Text="Agregar Productos" Width="179px"  />
                                     </td>
                                  
                                 </tr>

                                   <tr>
                                       <td align="center" class="auto-style146"></td>
                                   </tr>
                                   <tr>
                                       <td align="center" class="auto-style148">
                                           <asp:Button ID="bModificarP" runat="server" Height="53px" Text="Modificar Productos" Width="180px"  />
                                       </td>
                                   </tr>
                                   <tr>
                                       <td align="center" class="auto-style52"></td>
                                   </tr>
                                   <tr>
                                       <td align="center" class="auto-style52">
                                           <asp:Button ID="bEliminarP" runat="server" Height="53px" Text="Eliminar Productos" Width="180px"  />
                                       </td>
                                   </tr>

                             </table>
                              <table class="auto-style78" align="center">
                                 <tr>
                                     
                                     <td align="center" class="auto-style79">
                                         <asp:Button ID="bTerminarAdmin0" runat="server" Height="56px" Text="Terminar y Volver" Width="184px"  />
                                     </td>
                                  
                                 </tr>

                             </table>

                            </asp:Panel>


         <asp:Panel ID="pAltaProd" runat="server" BackImageUrl="~/imagenes/fondoheladeria.jpg" Height="486px" Width="764px" Visible="False" >
             <table class="auto-style93" >
                 <tr>
                     <td>&nbsp;</td>
                 </tr>
                 <tr>
                     <td class="auto-style94" align="center">
                         <asp:Label ID="Label9" runat="server" Font-Bold="True" Font-Size="X-Large"  Text="Alta de Productos:" ></asp:Label>
                     </td>
                 </tr>
             </table>
             <table class="auto-style93">
                 <tr>
                     <td class="auto-style100" align="center" >
                         <asp:Label ID="Label10" runat="server" Font-Bold="False" Font-Size="Large"  Text="Gusto:"></asp:Label>
                     </td>
                     <td class="auto-style102">
                         <asp:TextBox ID="tGusto" runat="server" BackColor="White" ForeColor="Black" Width="361px" Height="30px"></asp:TextBox>
                     </td>
                     <td class="auto-style101">
                         <asp:Label ID="lErrorProd" runat="server" ForeColor="#CC0000" Text="lErrorProd" Visible="False"></asp:Label>
                     </td>
                 </tr>
                 <tr>
                     <td class="auto-style98" align="center" >
                         <asp:Label ID="Label13" runat="server" Font-Bold="False" Font-Size="Large"  Text="Precio sin IVA:"></asp:Label>
                     </td>
                     <td class="auto-style103">
                         <asp:TextBox ID="tPrecio" runat="server" BackColor="White" Height="31px" Width="361px" ForeColor="Black"></asp:TextBox>
                     </td>
                     <td class="auto-style51">
                         <asp:Label ID="lErrorPrecio" runat="server" ForeColor="#CC0000" Text="lErrorPrecio" Visible="False"></asp:Label>
                     </td>
                 </tr>
                 <tr>
                     <td class="auto-style99" align="center">
                         <asp:Label ID="Label14" runat="server" Font-Bold="False" Font-Size="Large" Text="Stock:"></asp:Label>
                     </td>
                     <td class="auto-style105">
                         <asp:TextBox ID="tStock" runat="server" BackColor="White" Height="32px" Width="361px" ForeColor="Black"></asp:TextBox>
                     </td>
                     <td class="auto-style94">
                         <asp:Label ID="lErrorStock" runat="server" ForeColor="#CC0000" Text="lErrorStock" Visible="False"></asp:Label>
                     </td>
                 </tr>
                 <tr>
                     <td class="auto-style99" align="center">
                         &nbsp;</td>
                     <td class="auto-style105" align="center"> 
                         <asp:Label ID="lAgregado" runat="server" Text="Label" Visible="False"></asp:Label>
                     </td>
                     <td class="auto-style94">
                         &nbsp;</td>
                 </tr>
                 <tr>
                     <td class="auto-style99" align="center">
                         <asp:Label ID="lErrorAlta" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="#CC0000" Text="lErrorAlta" Visible="False"></asp:Label>
                     </td>
                     <td class="auto-style105" align="center">
                         <asp:Button ID="bAgregar" runat="server" Height="46px" Text="Agregar Producto"  />
                     </td>
                     <td class="auto-style94">
                         <asp:Button ID="bVolver0" runat="server" Height="46px" Text="Volver" Width="155px"  />
                     </td>
                 </tr>
                 <tr>
                     <td class="auto-style99">&nbsp;</td>
                     <td class="auto-style105" align="center">
                         &nbsp;</td>
                     <td class="auto-style94">&nbsp;</td>
                 </tr>
             </table>
             </asp:Panel>
        <asp:Panel ID="pModificarProd" runat="server" BackImageUrl="~/imagenes/fondoheladeria.jpg" Height="577px" Width="764px" Visible="False">
             <table class="auto-style93" >
                 <tr>
                     <td>&nbsp;</td>
                 </tr>
                 <tr>
                     <td class="auto-style94" align="center">
                         <asp:Label ID="Label4" runat="server" Font-Bold="True"  ForeColor="Black" Text="Modificar Producto:"></asp:Label>
                     </td>
                 </tr>
                 <tr>
                     <td align="center" class="auto-style94">
                         <asp:DropDownList ID="dProductosMod" runat="server" AutoPostBack="True" BackColor="White" Font-Bold="True" Height="62px" Width="748px">
                         </asp:DropDownList>
                     </td>
                 </tr>
             </table>
            <table class="auto-style68" align="center">
                                            <tr>
                                                <td class="auto-style69">Modificar:</td>
                                                <td class="auto-style70">
                                                    <asp:Label ID="lCosaModificar" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Label" Visible="False"></asp:Label>
                                                </td>
                                                <td>
                                                    &nbsp;</td>
                                            </tr>
                                </table>
             <table class="auto-style93">
                 <tr>
                     <td class="auto-style100" align="center">
                         <asp:Label ID="Label7" runat="server" Font-Bold="False" Font-Size="Large" Text="Gusto:"></asp:Label>
                     </td>
                     <td class="auto-style102">
                         <asp:TextBox ID="tGustoM" runat="server" BackColor="White" ForeColor="Black" Width="361px" Height="30px" ReadOnly="True"></asp:TextBox>
                     </td>
                     <td class="auto-style101">
                         <asp:Label ID="lErrorProdMod" runat="server" ForeColor="#CC0000" Text="lErrorProd" Visible="False"></asp:Label>
                     </td>
                 </tr>
                 <tr>
                     <td class="auto-style98" align="center">
                         <asp:Label ID="Label17" runat="server" Font-Bold="False" Font-Size="Large"  Text="Precio sin IVA:"></asp:Label>
                     </td>
                     <td class="auto-style103">
                         <asp:TextBox ID="tPrecioM" runat="server" BackColor="White" Height="31px" Width="361px"></asp:TextBox>
                     </td>
                     <td class="auto-style51">
                         <asp:Label ID="lErrorPrecioMod" runat="server" ForeColor="#CC0000" Text="lErrorPrecio" Visible="False"></asp:Label>
                     </td>
                 </tr>
                 <tr>
                     <td class="auto-style99" align="center">
                         <asp:Label ID="Label19" runat="server" Font-Bold="False" Font-Size="Large"  Text="Stock:"></asp:Label>
                     </td>
                     <td class="auto-style105">
                         <asp:TextBox ID="tStockM" runat="server" BackColor="White" Height="32px" Width="361px"></asp:TextBox>
                     </td>
                     <td class="auto-style94">
                         <asp:Label ID="lErrorStockMod" runat="server" ForeColor="#CC0000" Text="lErrorStock" Visible="False"></asp:Label>
                     </td>
                 </tr>
                 <tr>
                     <td class="auto-style99" align="center">
                         &nbsp;</td>
                     <td class="auto-style105" align="center">
                         <asp:Label ID="lModi" runat="server" Text="Label" Visible="False"></asp:Label>
                     </td>
                     <td class="auto-style94">
                         &nbsp;</td>
                 </tr>
                 <tr>
                     <td class="auto-style99" align="center">
                         <asp:Label ID="lErrorMod" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="#CC0000" Text="lErrorMod" Visible="False"></asp:Label>
                     </td>
                     <td class="auto-style105" align="center"><asp:Button ID="bModificar" runat="server" Height="47px" Text="Modificar Producto"  />
                         
                     </td>
                     <td class="auto-style94">
                         <asp:Button ID="bVolver1" runat="server" Height="46px" Text="Volver" Width="155px"  />
                     </td>
                 </tr>
             </table>
             </asp:Panel>

        <asp:Panel ID="pEliminarProd" runat="server" BackImageUrl="~/imagenes/fondoheladeria.jpg" Height="450px" Width="764px" Visible="False" >
             <table class="auto-style93" >
                 <tr>
                     <td>&nbsp;</td>
                 </tr>
                 <tr>
                     <td class="auto-style94" align="center">
                         <asp:Label ID="Label11" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="Black" Text="Eliminar Productos:"></asp:Label>
                     </td>
                 </tr>
                 <tr>
                     <td align="center" class="auto-style94">
                         <asp:DropDownList ID="dProductosEli" runat="server" AutoPostBack="True" BackColor="White" Font-Bold="True" Height="62px" Width="748px">
                         </asp:DropDownList>
                     </td>
                 </tr>
             </table>
            <table class="auto-style68" align="center">
                                            <tr>
                                                <td class="auto-style69">Eliminar:</td>
                                                <td class="auto-style70">
                                                    <asp:Label ID="lCosaModificar2" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Label" Visible="False"></asp:Label>
                                                </td>
                                                <td>
                                                    &nbsp;</td>
                                            </tr>
                                </table>
             <table class="auto-style93">
                 <tr>
                     <td class="auto-style99" align="center">
                         &nbsp;</td>
                     <td class="auto-style105" align="center">
                         <asp:Label ID="lErrorE" runat="server" Text="Label" Visible="False"></asp:Label>
                     </td>
                     <td class="auto-style94">
                         &nbsp;</td>
                 </tr>
                 <tr>
                     <td class="auto-style99" align="center">
                         <asp:Label ID="lErrorE2" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="#CC0000" Text="lErrorEli" Visible="False"></asp:Label>
                     </td>
                     <td class="auto-style105" align="center">
                         <asp:Button ID="bEliminar" runat="server" Height="48px" Text="Eliminar Producto" Width="206px" />
                     </td>
                     <td class="auto-style94">
                         <asp:Button ID="bVolver2" runat="server" Height="46px" Text="Volver" Width="155px" />
                     </td>
                 </tr>
             </table>
             </asp:Panel>

                <asp:Panel ID="pPedidoAnulado" BackImageUrl="~/imagenes/fondoheladeria.jpg" runat="server" Height="365px" Visible="False" Width="764px">
                 <table class="auto-style77">
                     <tr>
                         <td class="auto-style106"></td>
                         <td class="auto-style106"></td>
                         <td class="auto-style106"></td>
                     </tr>
                 </table>
                 <table align="center" class="auto-style78">
                     <tr>
                         <td align="center" class="auto-style79">
                             <asp:Label ID="lPedidoAnulado" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Label" ></asp:Label>
                         </td>
                     </tr>
                 </table>
                 <table align="center" class="auto-style78">
                     <tr>
                         <td align="center" class="auto-style79">
                             <asp:ImageButton ID="bTerminaryVolverPedido0" runat="server" Height="73px" ImageUrl="~/imagenes/terminarvolver1.png" Width="331px" />
                         </td>
                     </tr>
                 </table>
             </asp:Panel>

        <asp:Panel ID="pModificado" BackImageUrl="~/imagenes/fondoheladeria.jpg" runat="server" Height="365px" Visible="False" Width="764px">
                 <table class="auto-style77">
                     <tr>
                         <td class="auto-style106"></td>
                         <td class="auto-style106"></td>
                         <td class="auto-style106"></td>
                     </tr>
                 </table>
                 <table align="center" class="auto-style78">
                     <tr>
                         <td align="center" class="auto-style79">
                             <asp:Label ID="lModificado" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Label" ></asp:Label>
                         </td>
                     </tr>
                 </table>
                 <table align="center" class="auto-style78">
                     <tr>
                         <td align="center" class="auto-style79">
                             <asp:ImageButton ID="bTerminarModificado" runat="server" Height="73px" ImageUrl="~/imagenes/terminarvolver1.png" Width="331px" />
                         </td>
                     </tr>
                 </table>
             </asp:Panel>
        <asp:Panel ID="pVerPedidosAdministrador" BackImageUrl="~/imagenes/fondoheladeria.jpg" runat="server" Height="540px" Visible="False" Width="922px">
            <table class="auto-style108" >
                <tr>
                    <td class="auto-style149" align="center">
                        <asp:Label ID="Label20" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Histórico de Pedidos" ForeColor="Black"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="center" class="auto-style107">
                        <asp:Label ID="lErrorHistorico2" runat="server" ForeColor="#CC0000" Text="lErrorHistorico" Visible="False"></asp:Label>
                    </td>

                </tr>
                
                
                <tr>
                    <td class="auto-style150">
                        <asp:GridView ID="gHistorico2"  runat="server" AutoGenerateColumns="False" CellPadding="4" Width="753px" ForeColor="#333333" GridLines="None">
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                                <asp:ButtonField ButtonType="Button" CommandName="Editar" Text="Editar" />
                                <asp:ButtonField ButtonType="Button" CommandName="Ver" Text="Ver Pedido" />
                                <asp:ButtonField ButtonType="Button" CommandName="Anular" HeaderText="(sólo &quot;Solicitado&quot;)" Text="Anular Pedido" />
                                <asp:BoundField DataField="NPedido" HeaderText="N° Pedido" />
                                <asp:BoundField DataField="fecha" DataFormatString="{0:dd/MM/yyyy HH:mm:tt}" HeaderText="Fecha y Hora" ReadOnly="True" />
                                <asp:BoundField DataField="estado" HeaderText="Estado del Pedido" />
                                <asp:BoundField DataField="NUM_Cli" HeaderText="N° de Cliente" />
                            </Columns>
                            <EditRowStyle BackColor="#2461BF" />
                            <FooterStyle BackColor="#507CD1" ForeColor="White" Font-Bold="True" />
                            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <PagerStyle ForeColor="White" HorizontalAlign="Center" BackColor="#2461BF" />
                            <RowStyle BackColor="#EFF3FB" />
                            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#F5F7FB" />
                            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                            <SortedDescendingCellStyle BackColor="#E9EBEF" />
                            <SortedDescendingHeaderStyle BackColor="#4870BE" />
                        </asp:GridView>
                    </td>
                </tr>
            </table>
            <table class="auto-style78" align="center">
                <tr>
                    <td align="center" class="auto-style82">
                        <asp:ImageButton ID="bActualizar2" runat="server" Height="73px" ImageUrl="~/imagenes/actualizar1.png" Width="239px" />
                    </td>
                    <td align="center" class="auto-style79">
                        <asp:ImageButton ID="bTerminarHistorico2" runat="server" Height="73px" ImageUrl="~/imagenes/terminarvolver1.png" Width="289px" />
                    </td>
                </tr>
            </table>
            </asp:Panel>
        <asp:Panel ID="pEditarPedidoAdmin" BackImageUrl="~/imagenes/fondoheladeria.jpg" runat="server"  Height="607px" Width="764px" Visible="False">
                            <table style="width:100%; >
                                <tr>
                                    <td class="auto-style112" align="center">
                                        <asp:Label ID="lDetallePedidoAdmin" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Detalle del Pedido N°" ></asp:Label>
                                        <asp:Label ID="lPruebaItem" runat="server" Text="Label"></asp:Label>
                                    </td>
                                </tr>
                                  <tr>
                                    <td class="auto-style114" align="center">
                                        <asp:Label ID="Label16" runat="server" Font-Bold="False" Font-Size="Medium" Text="Cambiar estado de pedido:"></asp:Label>
                                    </td>
                                    
                                </tr>
                                <tr>
                                    <td class="auto-style116" align="center">
                                        <asp:DropDownList ID="dEstadoEnvio" runat="server" AutoPostBack="True" BackColor="White" Font-Bold="True" Font-Size="Large" Height="23px" Width="269px" ForeColor="Black">
                                            <asp:ListItem>Solicitado</asp:ListItem>
                                            <asp:ListItem>Anulado</asp:ListItem>
                                            <asp:ListItem>Enviado</asp:ListItem>
                                        </asp:DropDownList>
                                    </td>
                                    
                                </tr>
                             
                                <tr>
                                    <td class="auto-style84" align="center">
                                        <asp:GridView ID="gEditarPedidoAdmin" runat="server" AutoGenerateColumns="False" CellPadding="4" Height="274px" Width="713px" ForeColor="#333333" GridLines="None">
                                            <AlternatingRowStyle BackColor="White" />
                                            <Columns>
                                                <asp:BoundField DataField="NItem" HeaderText="NItem" />
                                                <asp:BoundField DataField="Item" HeaderText="Item Solicitado" />
                                                <asp:BoundField DataField="Cantidad" HeaderText="Cant." />
                                                <asp:ButtonField ButtonType="Button" CommandName="Quitar" Text="Quitar" />
                                            </Columns>
                                            <EditRowStyle BackColor="#2461BF" />
                                            <FooterStyle BackColor="#507CD1" ForeColor="White" Font-Bold="True" />
                                            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                            <PagerStyle ForeColor="White" HorizontalAlign="Center" BackColor="#2461BF" />
                                            <RowStyle BackColor="#EFF3FB" />
                                            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                            <SortedAscendingCellStyle BackColor="#F5F7FB" />
                                            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                                            <SortedDescendingCellStyle BackColor="#E9EBEF" />
                                            <SortedDescendingHeaderStyle BackColor="#4870BE" />
                                        </asp:GridView>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="auto-style106"></td>
                                </tr>
                                <tr>
                                    <td align="center" class="auto-style106">
                                        <asp:Label ID="lErrorVerPedidoAdmin" runat="server" ForeColor="#CC0000" Text="lErrorVerUnPedido" Visible="False"></asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <td align="center">
                                         <asp:ImageButton ID="bTerminarEditarPedidoAdmin" runat="server" Height="63px" ImageUrl="~/imagenes/terminarvolver1.png" Width="261px" />
                                    </td>
                                </tr>
                            </table>

                            </asp:Panel>
          <asp:Panel ID="pAccesosUsuario" runat="server" BackImageUrl="~/imagenes/fondoheladeria.jpg" Height="639px" Width="1040px" Visible="False">
              <table style="width:100%; >
                  <tr>
                      <td class="auto-style112" align="center">
                          <asp:Label ID="lAccesosDeUsuario" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Administración de Usuarios" ></asp:Label>
                      </td>
                  </tr>
                  <tr>
                      <td class="auto-style114" align="center">&nbsp;</td>
                  </tr>
                  <tr>
                      <td class="auto-style116" align="center">
                          <asp:GridView ID="gEditarAccesos" runat="server" AutoGenerateColumns="False" CellPadding="4" Height="274px" Width="713px" ForeColor="#333333" GridLines="None">
                              <AlternatingRowStyle BackColor="White" />
                              <Columns>
                                  <asp:BoundField DataField="idusuario" HeaderText="ID" />
                                  <asp:BoundField DataField="Usuario" HeaderText="Usuario" />
                                  <asp:BoundField DataField="Estado" HeaderText="Estado" />
                                  <asp:ButtonField ButtonType="Button" CommandName="HabilitarCuenta" Text="Habilitar Cuenta" />
                                  <asp:ButtonField ButtonType="Button" CommandName="BloquearCuenta" Text="Bloquear Cuenta" />
                                  <asp:ButtonField ButtonType="Button" CommandName="EliminarCuenta" Text="Eliminar Cuenta" />
                              </Columns>
                              <EditRowStyle BackColor="#2461BF" />
                              <FooterStyle BackColor="#507CD1" ForeColor="White" Font-Bold="True" />
                              <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                              <PagerStyle ForeColor="White" HorizontalAlign="Center" BackColor="#2461BF" />
                              <RowStyle BackColor="#EFF3FB" />
                              <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                              <SortedAscendingCellStyle BackColor="#F5F7FB" />
                              <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                              <SortedDescendingCellStyle BackColor="#E9EBEF" />
                              <SortedDescendingHeaderStyle BackColor="#4870BE" />
                          </asp:GridView>
                      </td>
                  </tr>
                  <tr>
                      <td align="center" class="auto-style106">
                          &nbsp;</td>
                  </tr>
                  <tr>
                      <td align="center" class="auto-style106">
                          <asp:TextBox ID="tMotivoAcceso" runat="server" BackColor="White" ForeColor="Black" Height="84px" MaxLength="100" Rows="8" TextMode="MultiLine" Width="492px">Motivo:</asp:TextBox>
                      </td>
                  </tr>
                  <tr>
                      <td align="center">
                          <asp:Label ID="lEr" runat="server" Font-Bold="True" ForeColor="Red" Text="lError" Visible="False"></asp:Label>
                      </td>
                  </tr>
                  <tr>
                      <td align="center">
                          <asp:ImageButton ID="bTerminarAccesos" runat="server" Height="63px" ImageUrl="~/imagenes/terminarvolver1.png" Width="261px" />
                      </td>
                  </tr>
              </table>

            </asp:Panel>
        <asp:Panel ID="pVerificarMail" BackImageUrl="~/imagenes/fondoheladeria.jpg" runat="server"  Height="639px" Width="764px" Visible="False">
            <table class="auto-style120" >
                <tr>
                    <td class="auto-style121"></td>
                    <td class="auto-style122"></td>
                    <td class="auto-style124"></td>
                </tr>
                <tr>
                    <td class="auto-style125"></td>
                    <td class="auto-style126" align="center">
                        Activacion de cuenta, revise su correo e ingrese el codigo que le hemos enviado.</td>
                    <td class="auto-style127"></td>
                </tr>
                <tr>
                    <td class="auto-style131"></td>
                    <td class="auto-style132" align="center">
                        <asp:TextBox ID="tValidar" runat="server" BackColor="White" Font-Bold="True" Font-Size="X-Large" ForeColor="Black" Height="32px" Width="283px"></asp:TextBox>
                    </td>
                    <td class="auto-style133"></td>
                </tr>
                <tr>
                    <td class="auto-style128"></td>
                    <td class="auto-style129" align="center">
                        <asp:Label ID="lCodigo" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="#FF3300" Text=" Código Incorrecto " Visible="False"></asp:Label>
                    </td>
                    <td class="auto-style130"></td>
                </tr>
                <tr>
                    <td class="auto-style118">&nbsp;</td>
                    <td class="auto-style119" align="center">
                        <asp:Button ID="bValidar" runat="server" Height="46px" Text="Validar Código" Width="187px"  />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style118">&nbsp;</td>
                    <td class="auto-style119" align="center">
                        <asp:Button ID="bRegresarRegistro" runat="server" Height="45px" Text="Regresar al Registro" Width="189px" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style118">&nbsp;</td>
                    <td class="auto-style119" align="center">&nbsp;
                        <asp:ImageButton ID="bCancelarValidar" runat="server" ImageAlign="Middle" ImageUrl="~/imagenes/cancelarvolver1.png" Height="62px" Width="200px" />
                    </td>
                    
                    <td>&nbsp;</td>
                </tr>
            </table>

            </asp:Panel>
    </form>
</body>
</html>
