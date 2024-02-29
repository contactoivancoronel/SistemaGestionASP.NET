Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Net.Mail
Public Class _Default
    Inherits System.Web.UI.Page
    Public x As Integer
    Public connectionstring As String = ConfigurationManager.ConnectionStrings(ConfigurationManager.AppSettings("Conexion")).ToString()
    Public EmailActivo As String = ConfigurationManager.AppSettings("EmailActivo")
    Public Email As String = ConfigurationManager.AppSettings(EmailActivo)
    Public EmailPass As String = ConfigurationManager.AppSettings(EmailActivo & "Pass")

    Dim con As New SqlConnection(connectionstring)
    Dim ar As String

    Function EnviarMail(ByVal EmailDestino As String, ByVal Subject As String, ByVal Mensaje As String) As String
        Dim Resultado As String = "OK"
        Dim SmtpServer As New SmtpClient()
        Dim mail As New MailMessage()
        Try
            mail = New MailMessage()
            mail.From = New MailAddress(Email, "Heladeria UNLZ")
            mail.To.Add(EmailDestino)
            mail.Subject = Subject
            mail.Body = Mensaje
            mail.IsBodyHtml = False
            mail.Priority = MailPriority.Normal

            If EmailActivo = "EmailGmail" Then
                SmtpServer.Credentials = New Net.NetworkCredential(Email, EmailPass)
                SmtpServer.Host = "smtp.gmail.com"
                SmtpServer.Port = 587
                SmtpServer.EnableSsl = True
            End If
            SmtpServer.Send(mail)
        Catch
            Resultado = Err.Description
        End Try
        mail.Dispose()
        Return Resultado
    End Function
    Public Function CreaCodigo(ByVal cantCaracteres As Integer) As String
        Dim strRand As String = Nothing, r As New Random, c As String, i As Integer

        For i = 0 To cantCaracteres - 1

            If Math.Round(r.Next(0, 2)) = 0 Then
                c = Chr(Math.Round(r.Next(48, 58)))
            Else
                c = Chr(Math.Round(r.Next(65, 91)))
            End If
            strRand &= c
        Next
        Return strRand
    End Function


    Public Function SQL_Accion(ByVal Sql_de_accion As String) As Boolean
        Dim adapter As New SqlDataAdapter, salida As Boolean = True
        Try
            If con.State = ConnectionState.Closed Then con.Open()
            If Sql_de_accion.ToUpper.IndexOf("INSERT") Then
                adapter.InsertCommand = New SqlCommand(Sql_de_accion, con)
                adapter.InsertCommand.ExecuteNonQuery()
            Else
                If Sql_de_accion.ToUpper.IndexOf("UPDATE") Then
                    adapter.InsertCommand = New SqlCommand(Sql_de_accion, con)
                    adapter.InsertCommand.ExecuteNonQuery()
                Else
                    If Sql_de_accion.ToUpper.IndexOf("DELETE") Then
                        adapter.InsertCommand = New SqlCommand(Sql_de_accion, con)
                        adapter.InsertCommand.ExecuteNonQuery()
                    Else
                        salida = False
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            salida = False
        End Try
        Return salida
    End Function
    Function LeeUnCampo(ByVal sql As String, ByVal campo As String) As Object

        Dim da1 As New SqlDataAdapter(sql, con)
        Dim ds1 As New DataSet
        Try
            If con.State = ConnectionState.Closed Then con.Open()
            da1.Fill(ds1, "datos")
            If ds1.Tables("datos").Rows.Count < 1 Then
                Return "**NADA**"
            Else
                Return ds1.Tables("datos").Rows(0)(campo)
            End If
        Catch
            Return "**Error**"
        End Try
    End Function

    Public Function YaExisteSQL(ByVal sql As String) As Boolean
        Dim con As New SqlConnection(connectionstring)
        Dim da1 As New SqlDataAdapter(sql, con)
        Dim ds1 As New DataSet
        da1.Fill(ds1, "afidesc")
        If ds1.Tables("afidesc").Rows.Count < 1 Then
            Return False
        Else
            Return True
        End If
    End Function


    Protected Sub bPortada_Click(sender As Object, e As ImageClickEventArgs) Handles bPortada.Click
        pPortada.Visible = False
        pLoginMenu.Visible = True
        rRol.SelectedIndex = 0
    End Sub



    Protected Sub bVolverLogin_Click(sender As Object, e As ImageClickEventArgs) Handles bVolverLogin.Click
        pPortada.Visible = True
        pLogin.Visible = False
        rRol.SelectedIndex = 0
    End Sub

    Protected Sub bEntrar_Click(sender As Object, e As ImageClickEventArgs)

    End Sub

    Protected Sub bRegistrarse_Click(sender As Object, e As ImageClickEventArgs) Handles bRegistrarse.Click
        pLoginMenu.Visible = False
        pRegistrarse.Visible = True
    End Sub

    Protected Sub bRegistrarseVolverLoginU13_Click(sender As Object, e As ImageClickEventArgs) Handles bRegistrarseVolverLoginU13.Click
        pLoginMenu.Visible = False
        pPortada.Visible = True
    End Sub

    Protected Sub bRegistrarseU0_Click(sender As Object, e As ImageClickEventArgs) Handles bRegistrarseU0.Click
        pLoginMenu.Visible = True
        rRol.SelectedIndex = 0
        pRegistrarse.Visible = False
    End Sub


    Protected Sub bRegistrarseVolverLoginU_Click(sender As Object, e As ImageClickEventArgs) Handles bRegistrarseVolverLoginU.Click
        pBienvenido.Visible = False
        pLogin.Visible = True
        rRol.SelectedIndex = 0
    End Sub
    Sub ArreglarCampo(ByRef campo As TextBox)
        campo.Text = campo.Text.Trim.Replace("'", "").Replace("""",
       "").Replace("*", "").Replace("+", "").Replace("-", "").Replace("/",
       "").Replace(":", "").Replace("`", "").Replace("<", "").Replace(">",
       "").Replace("=", "").Replace("&", "")
    End Sub

    Function comprobar(ByRef user As String) As Boolean
        If user Is System.DBNull.Value Then
            Return False
        Else
            Dim aux As Boolean = True
            Dim listaNegra, x As String
            listaNegra = "'*+-/:;`><&" & """"
            If user <> "" Then
                For Each x In user
                    If aux = True Then
                        If InStr(1, listaNegra, x) > 0 Then
                            aux = False
                        Else
                            aux = True
                        End If
                    Else
                        Return False
                    End If
                Next
                If aux = True Then
                    Return True
                End If
            Else
                Return False
            End If
            Return False
        End If
    End Function

    Sub LimpiarErroresRegistroU()
        lErroresU.Text = ""
        lErroresU.Visible = False
        lEFNac.Text = ""
        lENombreU.Text = ""
        lEApellidoU.Text = ""
        lEDocU.Text = ""
        lEEmailU.Text = ""
        lELocalidadU.Text = ""
        lEDireccionU.Text = ""
        lETelefonosU.Text = ""
        lEUsuarioU.Text = ""
        lEPassU.Text = ""
        lEPass2U.Text = ""
        lENombreU.Visible = False
        lEApellidoU.Visible = False
        lEDocU.Visible = False
        lEEmailU.Visible = False
        lELocalidadU.Visible = False
        lEDireccionU.Visible = False
        lETelefonosU.Visible = False
        lEUsuarioU.Visible = False
        lEPassU.Visible = False
        lEPass2U.Visible = False

    End Sub

    Sub LimpiarRegistroU()
        LimpiarErroresRegistroU()
        pRegistrarse.Visible = False
        tNombreU.Text = ""
        tApellidoU.Text = ""
        dTDocU.SelectedIndex = 0
        tDocU.Text = ""
        tEmailU.Text = ""
        didProvU.SelectedIndex = 0
        tLocalidadU.Text = ""
        tDireccionU.Text = ""
        tTelefonosU.Text = ""
        tUsuarioU.Text = ""
        tPassU.Text = ""
        tPass2U.Text = ""
    End Sub

    Public Function ValidateEmail(ByVal email As String) As Boolean
        Dim emailRegex As New System.Text.RegularExpressions.Regex("^(?<user>[^@]+)@(?<host>.+)$")
        Dim emailMatch As System.Text.RegularExpressions.Match = emailRegex.Match(email)
        Return emailMatch.Success
    End Function


    Sub SoloNumeros(ByRef campo As TextBox)
        Dim cam As String = campo.Text.Trim, salida As String = "", c As String
        For Each c In cam
            If IsNumeric(c) Then salida &= c
        Next
        campo.Text = salida
    End Sub

    Protected Sub bRegistrarseU_Click(sender As Object, e As ImageClickEventArgs) Handles bRegistrarseU.Click
        Dim ok As Boolean = True
        LimpiarErroresRegistroU()
        tNombreU.Text = tNombreU.Text.Trim.ToUpper
        If comprobar(tNombreU.Text) = False Then
            ArreglarCampo(tNombreU)
            ok = False
            lENombreU.Text = "El nombre contenía caracteres inválidos, fueron quitados"
            lENombreU.Visible = True
        End If
        tApellidoU.Text = tApellidoU.Text.Trim().ToUpper
        If comprobar(tApellidoU.Text) = False Then
            ArreglarCampo(tApellidoU)
            ok = False
            lEApellidoU.Text = "El apellido contenía caracteres inválidos, fueron quitados."
            lEApellidoU.Visible = True
        End If
        tDocU.Text = tDocU.Text.Trim
        If comprobar(tDocU.Text) = False Or Not IsNumeric(tDocU.Text) Then
            SoloNumeros(tDocU)
            ok = False
            lEDocU.Text = "El documento no era válido, se ajustó a número."
            lEDocU.Visible = True
        End If
        ArreglarCampo(tEmailU)
        If ValidateEmail(tEmailU.Text) = False Then
            ok = False
            lEEmailU.Text = "El email no es válido."
            lEEmailU.Visible = True
        End If
        tLocalidadU.Text = tLocalidadU.Text.Trim().ToUpper
        If comprobar(tLocalidadU.Text) = False Then
            ArreglarCampo(tLocalidadU)
            ok = False
            lELocalidadU.Text = "La Localidad contenía caracteres inválidos, fueron quitados."
            lELocalidadU.Visible = True
        End If

        tDireccionU.Text = tDireccionU.Text.Trim().ToUpper
        If comprobar(tDireccionU.Text) = False Then
            ArreglarCampo(tDireccionU)
            ok = False
            lEDireccionU.Text = "La Direccion contenía caracteres inválidos, fueron quitados."
            lEDireccionU.Visible = True
        End If

        tTelefonosU.Text = tTelefonosU.Text.Trim().ToUpper
        If comprobar(tTelefonosU.Text) = False Then
            ArreglarCampo(tTelefonosU)
            ok = False
            lETelefonosU.Text = "El teléfono contenía caracteres inválidos, fueron quitados."
            lETelefonosU.Visible = True
        End If

        Dim FechaNacimiento As Date
        ControlDeNacimiento(tF_Nac, ok, lEFNac, lEdad, True, FechaNacimiento)

        tUsuarioU.Text = tUsuarioU.Text.Trim().ToUpper
        If comprobar(tUsuarioU.Text) = False Or tUsuarioU.Text.IndexOf(" ") > -1 Then
            tUsuarioU.Text = tUsuarioU.Text.Replace(" ", "")
            ArreglarCampo(tUsuarioU)
            ok = False
            lEUsuarioU.Text = "El usuario contenia caracteres inválidos, fueron quitados."
            lEUsuarioU.Visible = True
        End If
        If tUsuarioU.Text.Length < 5 Then
            ok = False
            lEUsuarioU.Text = "El usuario debe tener de 5 a 10 caracteres, letras y/o números."
            lEUsuarioU.Visible = True
        End If
        tPassU.Text = tPassU.Text.Trim()
        If comprobar(tPassU.Text) = False Or tPassU.Text.IndexOf(" ") > -1 Then
            tPassU.Text = tPassU.Text.Replace(" ", "")
            ArreglarCampo(tPassU)
            ok = False
            lEPassU.Text = "La clave contenia caracteres inválidos. Pruebe con letras y números."
            lEPassU.Visible = True
        End If
        If tPassU.Text.Length < 5 Then
            ok = False
            lEPassU.Text = "La clave debe tener de 5 a 10 caracteres, letras y/o números."
            lEPassU.Visible = True
        End If
        tPass2U.Text = tPass2U.Text.Trim()
        If comprobar(tPass2U.Text) = False Or tPass2U.Text.IndexOf(" ") > -1 Then
            tPass2U.Text = tPass2U.Text.Replace(" ", "")
            ArreglarCampo(tPass2U)
            ok = False
            lEPass2U.Text = "La segunda clave contenia caracteres inválidos. Pruebe con letras y números."
            lEPass2U.Visible = True
        End If
        If ok = False Then
            lErroresU.Text = "Revise los errores por favor y luego reintente."
            lErroresU.Visible = True
            Exit Sub
        End If
        If tPass2U.Text <> tPassU.Text Then
            ok = False
            lEPass2U.Text = "Las 2 claves son diferentes."
            lEPass2U.Visible = True
        End If





        Session("Usuario") = tUsuarioU.Text
        Session("Password") = tPassU.Text
        Session("TipoDocumento") = dTDocU.SelectedValue.Trim
        Session("Documento") = tDocU.Text.Trim
        Session("Email") = tEmailU.Text.Trim
        If YaExisteSQL("select idusuario from usuarios where usuario='" & Session("Usuario") & "'") Then
            ok = False
            lEUsuarioU.Text = "El usuario elegido ya existe. Pruebe con otro."
            lEUsuarioU.Visible = True
        End If
        If YaExisteSQL("select idusuario from usuarios where doc='" & Session("Documento") & "' and tdoc='" & Session("TipoDocumento") & "'") Then
            ok = False
            lEDocU.Text = "Ya existe el " & Session("TipoDocumento") & " " & Session("Documento") & "."
            lEDocU.Visible = True
        End If

        If YaExisteSQL("select idusuario from usuarios where email='" & Session("Email") & "'") Then
            ok = False
            lEEmailU.Text = "El email elegido ya está registrado. Pruebe con otro."
            lEEmailU.Visible = True
            Exit Sub
        End If
        If ok = False Then
            lErroresU.Text = "Solo se permite una inscripción por persona."
            lErroresU.Visible = True
            Exit Sub
        End If
        Session("Usuario") = tUsuarioU.Text.ToLower
        Session("Password") = tPassU.Text
        Session("TipoDocumento") = dTDocU.SelectedValue.Trim
        Session("Documento") = tDocU.Text.Trim
        Session("ApellidoYNombre") = tNombreU.Text.Trim & " " & tApellidoU.Text.Trim

        If ok Then
            pRegistrarse.Visible = False
        End If
        LimpiarErroresRegistroU()
        Session("sqlIngreso") = "insert into Usuarios (Apellido,Nombre,tDoc,Doc,Usuario,Pass,Email,idProv,Localidad,Direccion,Telefonos,fNacimiento,estado) values('" & tApellidoU.Text.Trim & "','" & tNombreU.Text.Trim & "','" & Session("TipoDocumento") & "','" & Session("Documento") & "','" & Session("Usuario") & "','" & Session("Password") & "','" & Session("Email") & "'," & didProvU.SelectedIndex & ",'" & tLocalidadU.Text.Trim & "','" & tDireccionU.Text.Trim & "','" & tTelefonosU.Text.Trim & "','" & FechaNacimiento.ToString("yyyy-dd-MM") & "', 'Habilitado')"
        Dim codigo As String = CreaCodigo(4)
        Session("Codigo") = codigo
        Dim en As String = Chr(13) & Chr(10), mensaje As String = "Es un placer informarle " & Session("ApellidoYNombre") & "." & en & en & en & " Que ya se encuentra a un paso de tener su cuenta para el servicio Heladeria UNLZ, en respuesta a tu solicitud de registro como nuevo usuario te solicitamos que:" & en & en & "Por favor, ingreses el código: " & codigo & " en el cuadro de texto del codigo de verificación y presiones Validar. Esto completará tu registro como nuevo usuario y podras empezar a disfrutar del servicio." & en & en & "Saludos Cordiales!" & en & "heladeria UNLZ" & en & en & en & "Este email se generó de manera automnatica, favor de no responder. Muchas gracias!" & en & en

        Dim ok2 As String = EnviarMail(Session("Email"), "Heladeria UNLZ - Confirmación de nuevo usuario.", mensaje)
        tValidar.Text = ""
        lCodigo.Visible = False
        pRegistrarse.Visible = False
        pVerificarMail.Visible = True
    End Sub


    Function VNum(ByVal NTexto As String) As Decimal
        Return CDec(Val(NTexto.Trim.Replace(",", ".")))
    End Function

    Function NumSQL(ByVal numero As String) As String
        Return CStr(VNum(numero)).Trim.Replace(",", ".")
    End Function

    Function RellenaNum(ByVal numero As Integer, ByVal cantidad As Integer) As String
        Dim snum As String = CStr(numero).Trim
        Return "00000000000000000000".Substring(0, cantidad - snum.Length) & snum
    End Function

    Function FechaSQL(ByVal fecha As Date) As String
        Return "'" & RellenaNum(Year(fecha), 4) & RellenaNum(Month(fecha), 2) & RellenaNum(fecha.Day, 2) & "'"
    End Function

    Public Function AñoMes(ByVal fecha As Date) As String
        Return RellenaNum(Year(fecha), 4) & "-" & RellenaNum(Month(fecha), 2)
    End Function

    Public Function Vstr(ByVal cosa As Object) As String
        If IsDBNull(cosa) Then Return "" Else Return CStr(cosa)
    End Function

    Function CalcularEdad(ByVal FechaNac As Date) As Integer
        Dim edad As Integer = DateTime.Today.AddTicks(-FechaNac.Ticks).Year - 1
        Return edad
    End Function

    Sub ControlDeNacimiento(ByRef xtF_nac As TextBox, ByRef ok As Boolean, ByRef xlEFNac As Label, ByRef xlEdad As Label, ByVal Valida18 As Boolean, ByRef FechaNacimiento As Date)
        ArreglarCampo(xtF_nac)
        xlEFNac.Visible = False
        If xtF_nac.Text.Length < 6 Then
            ok = False
            xlEFNac.Text &= "El campo fecha de nacimiento debe tener 6 números"
            xlEdad.Text = "0"
            xlEFNac.Visible = True
        Else
            Dim FechaX As String = xtF_nac.Text
            Dim Añox As Integer = VNum(FechaX.Substring(4, 2))
            If Añox + 2000 > Date.Today.Year Then Añox += 1900 Else Añox += 2000
            FechaX = Añox.ToString.Trim & "-" & FechaX.Substring(2, 2) & "-" & FechaX.Substring(0, 2)
            If Not IsDate(FechaX) Then
                ok = False
                xlEFNac.Text &= "El campo fecha de nacimiento, es una fecha inválida."
                xlEdad.Text = "0"
                xlEFNac.Visible = True
            Else
                Dim dFechax As Date
                dFechax = CDate(FechaX)
                FechaNacimiento = dFechax
                If dFechax > Date.Today Then
                    ok = False
                    xlEFNac.Text &= "Nació en el futuro...."
                    xlEdad.Text = "0"
                    xlEFNac.Visible = True
                Else
                    Dim Edad As Integer = CalcularEdad(dFechax)
                    xlEdad.Text = Edad
                    If Edad < 18 And Valida18 Then
                        ok = False
                        xlEFNac.Text &= "Debe ser mayor de edad (18 años)."
                        xlEdad.Text = "0"
                        xlEFNac.Visible = True
                    End If
                End If
            End If
        End If
    End Sub



    Sub Loguea()
        Dim usu As String = tUsuario.Text.Trim.ToUpper, pass As String = tClave.Text.Trim
        If comprobar(tUsuario.Text.Trim) = False Or comprobar(tClave.Text.Trim) = False Then
            lErrorLogin.Text = "El usuario o la clave son incorrectos. Revise por favor."
            lErrorLogin.Visible = True
            Exit Sub
        End If

        Dim da1 As New SqlDataAdapter("select * from " & Session("QueEs") & " where upper(ltrim(rtrim(usuario)))='" & usu & "' and ltrim(rtrim(pass))='" & pass & "'", con)
        Dim ds1 As New DataSet
        da1.Fill(ds1, "Login")
        If ds1.Tables("Login").Rows.Count = 0 Then
            lErrorLogin.Text = "El usuario o la clave son incorrectos. Revise por favor."
            lErrorLogin.Visible = True
            Exit Sub
        End If

        Select Case Session("QueEs")
            Case "Usuarios"
                Session("idUsuario") = ds1.Tables("Login").Rows(0)("idUsuario")
                Session("Usuario") = usu
                Session("Password") = pass
                Session("TipoDocumento") = ds1.Tables("Login").Rows(0)("tDoc")
                Session("Documento") = ds1.Tables("Login").Rows(0)("Nombre").ToString.Trim & " " & ds1.Tables("Login").Rows(0)("Apellido").ToString.Trim
                Session("ApellidoYNombre") = ds1.Tables("Login").Rows(0)("Nombre").ToString.Trim & " " & ds1.Tables("Login").Rows(0)("Apellido").ToString.Trim
                Session("Email") = ds1.Tables("Login").Rows(0)("Email").ToString.Trim
                Session("idProv") = ds1.Tables("Login").Rows(0)("idProv").ToString.Trim
                Session("Localidad") = ds1.Tables("Login").Rows(0)("Localidad").ToString.Trim
                Session("Direccion") = ds1.Tables("Login").Rows(0)("Direccion").ToString.Trim
                Session("Telefonos") = ds1.Tables("Login").Rows(0)("Telefonos").ToString.Trim
                Session("estadoUsuario") = ds1.Tables("Login").Rows(0)("estado").ToString.Trim
                If (Session("estadoUsuario").Equals("Bloqueado")) Then
                    lErrorLogin.Text = "Su cuenta se encuentra bloqueada."
                    lErrorLogin.Visible = True
                    Exit Sub
                End If
                lBienvenidoAreaU.Text = "Bienvenido/a " & Session("ApellidoYNombre") & ", a tu Área de Usuario."
                LimpiarRegistroU()
                pLogin.Visible = False
                pAreaUsuario.Visible = True
            Case "Administradores"
                Session("idUsuario") = ds1.Tables("Login").Rows(0)("idAdmin")
                Session("Usuario") = usu
                Session("Password") = pass
                Session("TipoDocumento") = ds1.Tables("Login").Rows(0)("tDoc")
                Session("Documento") = ds1.Tables("Login").Rows(0)("Nombre").ToString.Trim & " " & ds1.Tables("Login").Rows(0)("Apellido").ToString.Trim
                Session("ApellidoYNombre") = ds1.Tables("Login").Rows(0)("Nombre").ToString.Trim & " " & ds1.Tables("Login").Rows(0)("Apellido").ToString.Trim
                Session("Email") = ds1.Tables("Login").Rows(0)("Email").ToString.Trim
                Session("estadoUsuario") = ds1.Tables("Login").Rows(0)("Activo").ToString.Trim
                If (Session("estadoUsuario").Equals("Deshabilitado")) Then
                    lErrorLogin.Text = "Su cuenta se encuentra deshabilitada."
                    lErrorLogin.Visible = True
                    Exit Sub
                End If
                lBienvenidoAdmin.Text = "Bienvenido/a " & Session("ApellidoYNombre") & ", al menú de Administrador."
                LimpiarRegistroU()
                pLogin.Visible = False
                pAdministrador.Visible = True
        End Select
    End Sub
    Protected Sub bEntrar_Click1(sender As Object, e As ImageClickEventArgs) Handles bEntrar.Click
        If rRol.SelectedItem.Text.Equals("Usuario") Then
            Session("QueEs") = "Usuarios"
            Loguea()
        ElseIf rRol.SelectedItem.Text.Equals("Admin") Then
            Session("QueEs") = "Administradores"
            Loguea()
        Else
            lErrorLogin.Text = "Debe seleccionar Usuario o Administrador!!"
            lErrorLogin.Visible = True
        End If
    End Sub
    Protected Sub bAlogin_Click(sender As Object, e As ImageClickEventArgs) Handles bAlogin.Click
        pLoginMenu.Visible = False
        pLogin.Visible = True
        rRol.SelectedIndex = 0
    End Sub

    Protected Sub bAhoraQueHago_Click(sender As Object, e As ImageClickEventArgs) Handles bAhoraQueHago.Click
        pAreaUsuario.Visible = False
        pAhoraQueHago.Visible = True
    End Sub

    Sub LimpiarLogin()
        lErrorLogin.Text = ""
        lErrorLogin.Visible = False
        tUsuario.Text = ""
        tClave.Text = ""
        pRegistrarse.Visible = False
    End Sub

    Protected Sub bVolverLoginU1_Click(sender As Object, e As ImageClickEventArgs) Handles bVolverLoginU1.Click
        LimpiarLogin()
        LimpiarRegistroU()
        lReenviarClave.Text = ""
        pLogin.Visible = True
        rRol.SelectedIndex = 0
        pAreaUsuario.Visible = False
        tUsuario.Text = Session("Usuario")
        tClave.Text = Session("Password")
    End Sub

    Protected Sub bVolverLoginU2_Click(sender As Object, e As ImageClickEventArgs) Handles bVolverLoginU2.Click
        pAhoraQueHago.Visible = False
        pAreaUsuario.Visible = True
    End Sub

    Protected Sub bModificarDatos_Click(sender As Object, e As ImageClickEventArgs) Handles bModificarDatos.Click
        pAreaUsuario.Visible = False
        pCambiarDatosPersonales.Visible = True

        tUsuarioUCambiar.Text = Session("Usuario")
        tEmailCambiar.Text = Session("Email")
        tLocalidadUCambiar.Text = Session("Localidad")
        tDireccionUCambiar.Text = Session("Direccion")
        tTelefonosUCambiar.Text = Session("Telefonos")

    End Sub

    Protected Sub bCancelarCambios_Click(sender As Object, e As ImageClickEventArgs) Handles bCancelarCambios.Click
        pCambiarDatosPersonales.Visible = False
        pAreaUsuario.Visible = True
    End Sub

    Protected Sub bCambiarDatos_Click(sender As Object, e As ImageClickEventArgs) Handles bCambiarDatos.Click


        Dim ok As Boolean = True
        LimpiarErroresRegistroU()

        ArreglarCampo(tEmailCambiar)
        If ValidateEmail(tEmailCambiar.Text) = False Then
            ok = False
            lEEmailUCambiar.Text = "El email no es válido."
            lEEmailUCambiar.Visible = True
        End If
        tLocalidadUCambiar.Text = tLocalidadUCambiar.Text.Trim().ToUpper
        If comprobar(tLocalidadUCambiar.Text) = False Then
            ArreglarCampo(tLocalidadUCambiar)
            ok = False
            lELocalidadUCambiar.Text = "La Localidad contenía caracteres inválidos, fueron quitados."
            lELocalidadUCambiar.Visible = True
        End If

        tDireccionUCambiar.Text = tDireccionUCambiar.Text.Trim().ToUpper
        If comprobar(tDireccionUCambiar.Text) = False Then
            ArreglarCampo(tDireccionUCambiar)
            ok = False
            lEDireccionUCambiar.Text = "La Direccion contenía caracteres inválidos, fueron quitados."
            lEDireccionUCambiar.Visible = True
        End If

        tTelefonosUCambiar.Text = tTelefonosUCambiar.Text.Trim().ToUpper
        If comprobar(tTelefonosUCambiar.Text) = False Then
            ArreglarCampo(tTelefonosUCambiar)
            ok = False
            lETelefonosUCambiar.Text = "El teléfono contenía caracteres inválidos, fueron quitados."
            lETelefonosUCambiar.Visible = True
        End If

        tUsuarioUCambiar.Text = tUsuarioUCambiar.Text.Trim().ToUpper
        If comprobar(tUsuarioUCambiar.Text) = False Or tUsuarioUCambiar.Text.IndexOf(" ") > -1 Then
            tUsuarioUCambiar.Text = tUsuarioUCambiar.Text.Replace(" ", "")
            ArreglarCampo(tUsuarioUCambiar)
            ok = False
            lEUsuarioUCambiar.Text = "El usuario contenia caracteres inválidos, fueron quitados."
            lEUsuarioUCambiar.Visible = True
        End If
        If tUsuarioUCambiar.Text.Length < 5 Then
            ok = False
            lEUsuarioUCambiar.Text = "El usuario debe tener de 5 a 10 caracteres, letras y/o números."
            lEUsuarioUCambiar.Visible = True
        End If
        tPassUCambiar.Text = tPassUCambiar.Text.Trim()
        If comprobar(tPassUCambiar.Text) = False Or tPassUCambiar.Text.IndexOf(" ") > -1 Then
            tPassUCambiar.Text = tPassUCambiar.Text.Replace(" ", "")
            ArreglarCampo(tPassUCambiar)
            ok = False
            lEPassUCambiar.Text = "La clave contenia caracteres inválidos. Pruebe con letras y números."
            lEPassUCambiar.Visible = True
        End If
        If tPassUCambiar.Text.Length < 5 Then
            ok = False
            lEPassUCambiar.Text = "La clave debe tener de 5 a 10 caracteres, letras y/o números."
            lEPassUCambiar.Visible = True
        End If

        If ok = False Then
            lErroresU.Text = "Revise los errores por favor y luego reintente."
            lErroresU.Visible = True
            Exit Sub
        End If

        If ok Then
            pCambiarDatosPersonales.Visible = False
            pDatosCambiados.Visible = True
        End If

        Session("Usuario") = tUsuarioUCambiar.Text
        Session("Password") = tPassUCambiar.Text

        If YaExisteSQL("select idusuario from usuarios where usuario='" & Session("Usuario") & "'") Then
            ok = False
            lEUsuarioUCambiar.Text = "El usuario elegido ya existe. Pruebe con otro."
            lEUsuarioUCambiar.Visible = True
        End If

        Session("Usuario") = tUsuarioUCambiar.Text.ToLower
        Session("Password") = tPassUCambiar.Text
        Session("Email") = tEmailCambiar.Text.Trim

        LimpiarErroresRegistroU()
        If SQL_Accion("update Usuarios set usuario='" & tUsuarioUCambiar.Text.Trim & "', Pass='" & tPassUCambiar.Text.Trim & "', Email='" & tEmailCambiar.Text.Trim & "', idProv='" & didProvUCambiar.SelectedIndex & "', Localidad='" & tLocalidadUCambiar.Text.Trim & "', Direccion='" & tDireccionUCambiar.Text.Trim & "', Telefonos='" & tTelefonosUCambiar.Text.Trim & "' where Usuario='" & Session("Usuario") & "'") = False Then
            lErrorCambiar.Text = "Se ha producido un error al querer guardar tus datos..."
            lErrorCambiar.Visible = True
            Exit Sub
        End If

        LimpiarRegistroU()
        pCambiarDatosPersonales.Visible = False
        pDatosCambiados.Visible = True
        bVolverAreaUsuario.Focus()
    End Sub

    Protected Sub bVolverAreaUsuario_Click(sender As Object, e As ImageClickEventArgs) Handles bVolverAreaUsuario.Click
        pDatosCambiados.Visible = False
        pAreaUsuario.Visible = True
    End Sub



    Protected Sub ImageButton4_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton4.Click
        pAreaUsuario.Visible = True
        pPedidos.Visible = False
    End Sub

    Sub CargarProductos()
        Dim x As Integer = 0, cosa As String
        Dim da2 As New SqlDataAdapter("select * from web_helados order by gusto", con)
        Dim ds2 As New DataSet
        dProductos.Items.Clear()
        da2.Fill(ds2, "web_helados")
        If ds2.Tables("web_helados").Rows.Count = 0 Then
            dProductos.Items.Add("*** No hay productos disponibles en éste momento... ***")
            Exit Sub
        End If
        For x = 0 To ds2.Tables("web_helados").Rows.Count - 1
            cosa = ds2.Tables("web_helados").Rows(x)("gusto").ToString.Trim
            dProductos.Items.Add(cosa)
        Next
        dProductos.SelectedIndex = 0
        lCosaAgregar.Text = dProductos.SelectedItem.ToString
    End Sub

    Sub CargaTemporal()
        Dim idU As Integer = VNum(Session("idUsuario"))
        Dim consulta As String = "select item, cantidad from web_pedidos_temporal where num_cli=" & Session("idUsuario") & " order by item"
        Dim da1 As New SqlDataAdapter(consulta, con)

        Dim ds1 As New DataSet
        da1.Fill(ds1, "histo")
        gListaPedido.DataSource = ds1.Tables("histo")
        gListaPedido.DataBind()
        If ds1.Tables("histo").Rows.Count = 0 Then
            lErrorHistorico.Text = ""
            gListaPedido.Visible = False
            bSolicitarPedido.Visible = False
            bQuitarTodos.Visible = False
            Label8.Visible = False
        Else
            gListaPedido.Visible = True
            bSolicitarPedido.Visible = True
            bQuitarTodos.Visible = True
            Label8.Visible = True
        End If
    End Sub

    Protected Sub ImageButton2_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton2.Click


        lInstrucciones.Visible = False
        bInstrucciones.Text = "Abrir Instrucciones"

        pPedidos.Visible = False
        lCosaAgregar.Text = ""
        CargarProductos()

        bQuitarTodos.Visible = False
        bSolicitarPedido.Visible = False
        lErrorVerUnPedido.Text = ""

        If IsNothing(Session("idUsuario")) Then
            pLogin.Visible = True
            rRol.SelectedIndex = 0
            Exit Sub
        End If
        SQL_Accion("delete web_pedidos_temporal where num_cli=" & Session("idUsuario"))
        CargaTemporal()

        pNuevoPedido.Visible = True
    End Sub

    Protected Sub bCancelarPedido_Click(sender As Object, e As ImageClickEventArgs) Handles bCancelarPedido.Click
        If SQL_Accion("delete web_pedidos_temporal where num_cli=" & VNum(Session("idUsuario"))) = False Then
        End If
        pNuevoPedido.Visible = False
        pPedidos.Visible = True
        Session("Pedido") = ""
    End Sub

    Protected Sub bInstrucciones_Click(sender As Object, e As EventArgs) Handles bInstrucciones.Click
        If bInstrucciones.Text = "Abrir Instrucciones" Then
            bInstrucciones.Text = "Cerrar Instrucciones"
            Dim en As String = "</BR>"
            lInstrucciones.Text = "INSTRUCCIONES:" & en & en & "1) Elija el producto que desee solicitar." & ", y se verá el elegido en 'Agregar:'." & en & "2) Indique la cantidad de latas de helado. " & en & "3) Oprima el botón 'Agregar a la lista'. El item elegido y la cantidad se verán e nla lista inferior. " & "sólo presione sobre el item en a lista para seleccionarlo y oprima 'Quitar'." & "Si agrega un item que ya estaba en la lista, se suman las cantidades. " & en & "4) Cuando haya terminado oprima 'Enviar el Pedido'. " & "Todos los items figurarán como 'Solicitado', y desde 'Revisar estado de los Pedidos', " & "podrá ver si cambiaron a 'Despachando' o 'Enviado'." & "Desde allí podrá anular los pedidos que aún estén en 'Solicitado'."
            lInstrucciones.Visible = True
        Else
            bInstrucciones.Text = "Abrir Instrucciones"
            lInstrucciones.Visible = False
        End If
    End Sub

    Protected Sub dProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dProductos.SelectedIndexChanged
        lCosaAgregar.Text = dProductos.SelectedItem.ToString

    End Sub

    Protected Sub bAgregarALista_Click(sender As Object, e As ImageClickEventArgs) Handles bAgregarALista.Click
        Dim Pedido As String = Session("Pedido")
        Dim en As String = Chr(13) & Chr(10)
        Dim x As Integer = 0, numero As Integer = 0
        Dim Cosa As String = lCosaAgregar.Text.Trim
        If Cosa = "--------" Then Exit Sub
        Dim Cantidad As Integer = VNum(tCantLatas.SelectedValue.ToString)
        If Cantidad <= 0 Then Exit Sub
        lErrorPedido.Text = ""
        Dim da2 As New SqlDataAdapter("select cantidad from web_pedidos_temporal where num_cli=" & Session("idUsuario") & " and ltrim(rtrim(item))='" & Cosa & "'", con)
        Dim ds2 As New DataSet
        da2.Fill(ds2, "dato")
        If ds2.Tables("dato").Rows.Count > 0 Then
            Cantidad += VNum(ds2.Tables("dato").Rows(0)("cantidad"))
            If SQL_Accion("update web_pedidos_temporal set cantidad=" & Cantidad & " where num_cli=" & Session("idUsuario") & " and ltrim(rtrim(item))='" & Cosa & "'") = False Then
                lErrorPedido.Text = "No puedo modificar el producto elegido. Intente mas tarde."
                Exit Sub
            End If
        Else
            If SQL_Accion("insert into web_pedidos_temporal (num_cli, item, cantidad) values (" & Session("idUsuario") & ", '" & Cosa & "', " & Cantidad & ")") = False Then
                lErrorPedido.Text = "No puedo agregar el producto a la lista. Intente más tarde."
                Exit Sub
            Else
                Pedido = Session("Pedido") & en & Cosa & " x" & Cantidad
                Session("Pedido") = Pedido

            End If
        End If
        tCantLatas.SelectedIndex = 0
        CargaTemporal()
    End Sub

    Protected Sub gListaPedido_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gListaPedido.RowCommand
        Dim index As Integer = Convert.ToInt32(e.CommandArgument)
        Dim row As GridViewRow = gListaPedido.Rows(index)
        Dim item As String = row.Cells(1).Text, en As String = Chr(13) & Chr(10)
        Dim consulta As String = "delete web_pedidos_temporal where ltrim(rtrim(item))='" & item & "' and num_cli=" & VNum(Session("idUsuario"))

        lErrorPedido.Text = ""
        If (e.CommandName = "Quitar") Then
            If SQL_Accion(consulta) = False Then
                lErrorPedido.Text = "No puedo quitar el item de la lista. Intente más tarde."
                Exit Sub
            End If
            CargaTemporal()
        End If
    End Sub

    Protected Sub bQuitarTodos_Click(sender As Object, e As ImageClickEventArgs) Handles bQuitarTodos.Click
        If SQL_Accion("delete web_pedidos_temporal where num_cli=" & VNum(Session("idUsuario"))) = False Then
            lErrorPedido.Text = "No puedo quitar a todos los items de la lista. Intente más tarde."
            Exit Sub
        End If
        Session("Pedido") = ""
        CargaTemporal()
    End Sub


    Sub LimpiarErroresAltaProductos()
        lErrorAlta.Text = ""
        lErrorAlta.Visible = False
        lErrorProd.Text = ""

        lErrorPrecio.Text = ""
        lErrorStock.Text = ""
        lErrorProd.Visible = False

        lErrorPrecio.Visible = False
        lErrorStock.Visible = False
    End Sub


    Protected Sub bAgregarProdAdmin_Click(sender As Object, e As EventArgs) Handles bAgregarP.Click
        lAgregado.Text = ""
        lAgregado.Visible = False
        pProductosA.Visible = False
        pAltaProd.Visible = True
    End Sub

    Protected Sub CargaModificacionProd()
        Dim x As Integer = 0, cosa As String
        Dim da2 As New SqlDataAdapter("select * from web_helados order by gusto", con)
        Dim ds2 As New DataSet
        dProductosMod.Items.Clear()
        da2.Fill(ds2, "web_helados")
        If ds2.Tables("web_helados").Rows.Count = 0 Then
            lErrorMod.Text = "*** No hay productos disponibles en éste momento... ***"
            Exit Sub
        End If
        For x = 0 To ds2.Tables("web_helados").Rows.Count - 1
            cosa = ds2.Tables("web_helados").Rows(x)("gusto").ToString.Trim
            dProductosMod.Items.Add(cosa)
        Next
        dProductosMod.SelectedIndex = 0
        lCosaModificar.Text = dProductos.SelectedItem.ToString

    End Sub
    Protected Sub CargaEliminacionProd()
        Dim x As Integer = 0, cosa As String
        Dim da2 As New SqlDataAdapter("select * from web_helados order by gusto", con)
        Dim ds2 As New DataSet
        dProductosEli.Items.Clear()
        da2.Fill(ds2, "web_helados")
        If ds2.Tables("web_helados").Rows.Count = 0 Then
            lErrorE2.Text = "*** No hay productos disponibles en éste momento... ***"
            Exit Sub
        End If
        For x = 0 To ds2.Tables("web_helados").Rows.Count - 1
            cosa = ds2.Tables("web_helados").Rows(x)("gusto").ToString.Trim
            dProductosEli.Items.Add(cosa)
        Next
        dProductosEli.SelectedIndex = 0
        lCosaModificar2.Text = dProductos.SelectedItem.ToString
    End Sub



    Protected Sub bModificarProdAdmin_Click(sender As Object, e As EventArgs) Handles bModificarP.Click
        lErrorMod.Text = ""
        Dim da As New SqlDataAdapter("select * from web_helados order by gusto", con)

        Dim ds As New DataSet
        da.Fill(ds)
        dProductosMod.DataTextField = ds.Tables(0).Columns("gusto").ToString()
        dProductosMod.DataSource = ds.Tables(0)
        dProductosMod.DataBind()
        If ds.Tables.Count = 0 Then
            lErrorMod.Text = "No hay productos o hubo un error al cargalos. Reintente más tarde."
            pModificarProd.Visible = False
        Else
            pModificarProd.Visible = True
        End If
        lCosaModificar.Text = dProductosMod.SelectedValue.ToString
        If lCosaModificar.Text.Equals("Label") Then
            lCosaModificar.Visible = False
        Else
            lCosaModificar.Visible = True
        End If


        pProductosA.Visible = False
        pModificarProd.Visible = True
    End Sub

    Protected Sub dProductosMod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dProductosMod.SelectedIndexChanged

        Dim y As Integer = dProductosMod.SelectedIndex
        Dim da1 As New SqlDataAdapter("select * from Web_Helados order by gusto", con)
        Dim ds1 As New DataSet
        da1.Fill(ds1, "datos")
        tGustoM.Text = ds1.Tables("datos").Rows(y)("Gusto").ToString.Trim
        tPrecioM.Text = ds1.Tables("datos").Rows(y)("PrecioSinIva").ToString.Trim
        tStockM.Text = ds1.Tables("datos").Rows(y)("Stock").ToString.Trim
        lCosaModificar.Text = ds1.Tables("datos").Rows(y)("Gusto").ToString.Trim
    End Sub

    Protected Sub bSolicitarPedido_Click(sender As Object, e As ImageClickEventArgs) Handles bSolicitarPedido.Click
        Dim idU As Integer = VNum(Session("idUsuario"))
        Dim npedido As Integer = 0, vItem As String = "", vTipo As String = "",
        vCantidad As Integer = 0
        Dim linea As String = "", en As String = Chr(13) & Chr(10)
        lErrorPedido.Text = ""
        If SQL_Accion("insert into web_pedidos (num_cli) values (" & Session("idUsuario") & ")") = True Then
            Dim da2 As New SqlDataAdapter("select top 1 npedido from web_pedidos where num_cli=" & Session("idUsuario") & " order by npedido desc", con)
            Dim ds2 As New DataSet
            da2.Fill(ds2, "dato")
            If ds2.Tables("dato").Rows.Count > 0 Then
                npedido = ds2.Tables("dato").Rows(0)("npedido")
                If SQL_Accion("INSERT INTO WEB_Pedidos_detalle ( item, Cantidad, NPedido ) " & "SELECT web_pedidos_temporal.Item, web_pedidos_temporal.Cantidad," & npedido & " AS Npedido FROM web_pedidos_temporal where num_cli=" & idU) = True Then
                    lPedidoCreado.Text = "El pedido N° " & npedido & ", fue creado correctamente."
                    pNuevoPedido.Visible = False
                    pPedidoCreado.Visible = True
                    Dim mensaje As String = "El usuario " & Session("Usuario") & ", N° de Cliente " & Session("idUsuario") & " realizó el siguiente pedido: " & en & en & Session("Pedido")
                    EnviarMail("antojate.ya.service@gmail.com", "Nuevo Pedido: Pedido N°" & npedido, mensaje)
                    Session("Pedido") = ""
                    If SQL_Accion("delete web_pedidos_temporal where num_cli=" & idU) = False Then

                    End If
                Else
                    lErrorPedido.Text = "Hubo un error al intentar guardar el detalle del pedido " & npedido & ", que quedó vacío o con carga parcial. Anúlelo e Intente más tarde"
                    Exit Sub
                End If
                Exit Sub
            Else
                lErrorPedido.Text = "Hubo un error al intentar guardar el detalle del pedido " & npedido & ", que quedó vacío. Anúlelo e Intente más tarde."
                Exit Sub
            End If
        Else
            lErrorPedido.Text = "Hubo un error al intentar guardar el pedido. Intente mas tarde"
        End If
    End Sub

    Protected Sub ImageButton3_Click(sender As Object, e As ImageClickEventArgs) Handles ImageButton3.Click
        CargaHistorico()
    End Sub

    Sub CargaHistorico()
        Dim idU As Integer = VNum(Session("idUsuario"))
        Dim da1 As New SqlDataAdapter("select Npedido, fecha, estado from web_pedidos where num_cli=" & idU & " and estado<>'Enviado' order by nPedido desc", con)
        Dim ds1 As New DataSet
        da1.Fill(ds1, "histo")
        gHistorico.DataSource = ds1.Tables("histo")
        gHistorico.DataBind()
        If ds1.Tables("histo").Rows.Count = 0 Then
            lErrorHistorico.Visible = True
            lErrorHistorico.Text = "No hay pedidos anteriores o hubo un error al cargalos. Reintente más tarde."
            gHistorico.Visible = False
        Else
            gHistorico.Visible = True
        End If
        pPedidos.Visible = False
        pHistorico.Visible = True
    End Sub

    Protected Sub gHistorico_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gHistorico.RowCommand
        Dim index As Integer = Convert.ToInt32(e.CommandArgument)
        Dim row As GridViewRow = gHistorico.Rows(index)
        Dim Npedido As Integer = VNum(row.Cells(2).Text), en As String = Chr(13) & Chr(10)
        Dim NCli As Integer = VNum(row.Cells(3).Text)
        Session("NCli") = NCli

        If (e.CommandName = "Ver") Then
            Label8.Text = "Detalle del Pedido N° " & Npedido

            lErrorVerUnPedido.Text = ""
            Dim da1 As New SqlDataAdapter("SELECT web_pedidos_detalle.Item, " & "web_pedidos_detalle.Cantidad FROM web_pedidos_detalle INNER JOIN WEB_Helados ON " & "web_pedidos_detalle.Item = WEB_Helados.GUSTO WHERE web_pedidos_detalle.NPedido=" & Npedido & " ORDER BY WEB_Helados.CODH", con)

            Dim ds1 As New DataSet
            da1.Fill(ds1, "histo")
            gVerUnPedido.DataSource = ds1.Tables("histo")
            gVerUnPedido.DataBind()
            If ds1.Tables("histo").Rows.Count = 0 Then
                lErrorHistorico.Text = "Hubo un error al cargar los items del pedido " & Npedido & ", porque no se leyó ninguno. Reintente más tarde."
                gVerUnPedido.Visible = False
            Else
                gVerUnPedido.Visible = True
            End If
            pHistorico.Visible = False
            pVerUnPedido.Visible = True
        End If

        If (e.CommandName = "Anular") Then
            lErrorHistorico.Text = ""
            Dim da1 As New SqlDataAdapter("select estado from web_pedidos where npedido=" & Npedido, con)
            Dim ds1 As New DataSet
            da1.Fill(ds1, "histo")
            If ds1.Tables("histo").Rows.Count = 0 Then
                lErrorHistorico.Text = "No puedo acceder al pedido N° " & Npedido & ". Reintente más tarde."
                Exit Sub
            Else
                Dim estado As String = ds1.Tables("histo")(0)("estado").ToString.Trim
                If estado <> "Solicitado" Then
                    lErrorHistorico.Text = "El pedido tiene estado='" & estado & "' y ya no puede cancelarse por web (sólo 'Solicitado'). Llame a la fábrica por favor."
                    Exit Sub
                Else
                    If estado = "Anulado" Then
                        lErrorHistorico.Text = "El pedido N° " & Npedido & ", YA estaba Anulado..."
                        Exit Sub
                    End If
                    lErrorHistorico.Text = ""
                    If SQL_Accion("update web_pedidos set estado='Anulado' where npedido=" & Npedido) = False Then
                        lErrorHistorico.Text = "No he podido cambiar el estado, hubo algún error de conexión. Por favor, reintente más tarde o llame al a fábrica para avisar de la anulación."
                        Exit Sub
                    Else
                        lErrorHistorico.Text = "El pedido N° " & Npedido & ", fue ANULADO "

                    End If
                End If

            End If
            CargaHistorico()
        End If
    End Sub

    Protected Sub bActualizar_Click(sender As Object, e As ImageClickEventArgs) Handles bActualizar.Click
        CargaHistorico()
    End Sub

    Protected Sub bTerminarHistorico_Click(sender As Object, e As ImageClickEventArgs) Handles bTerminarHistorico.Click
        pHistorico.Visible = False
        pPedidos.Visible = True
    End Sub

    Protected Sub bTerminarVerPedido_Click(sender As Object, e As ImageClickEventArgs) Handles bTerminarVerPedido.Click
        pVerUnPedido.Visible = False
        If (Session("QueEs").Equals("Administradores")) Then
            pVerPedidosAdministrador.Visible = True
        Else
            pHistorico.Visible = True
        End If

    End Sub

    Protected Sub bTerminaryVolverPedido_Click(sender As Object, e As ImageClickEventArgs) Handles bTerminaryVolverPedido.Click
        pPedidoCreado.Visible = False
        pPedidos.Visible = True
    End Sub

    Protected Sub bTerminaryVolverPedido0_Click(sender As Object, e As ImageClickEventArgs) Handles bTerminaryVolverPedido0.Click
        CargaHistorico()
        pPedidoAnulado.Visible = False
        pHistorico.Visible = True
    End Sub

    Protected Sub bTerminarAdmin_Click(sender As Object, e As EventArgs) Handles bTerminarA.Click
        LimpiarLogin()
        LimpiarRegistroU()
        lReenviarClave.Text = ""
        pAdministrador.Visible = True
        pAreaUsuario.Visible = False
        tUsuario.Text = Session("Usuario")
        tClave.Text = Session("Password")
        pAdministrador.Visible = False
        pLogin.Visible = True
        rRol.SelectedIndex = 0
    End Sub

    Protected Sub bTerminarModificado_Click(sender As Object, e As ImageClickEventArgs) Handles bTerminarModificado.Click
        pModificado.Visible = False
        pAdministrador.Visible = True

    End Sub

    Sub CargaHistoricoAdmin()
        lErrorHistorico2.Text = ""
        Dim da1 As New SqlDataAdapter("select NPedido, NUM_CLI, fecha, estado from web_pedidos order by NUM_CLI desc", con)
        Dim ds1 As New DataSet
        da1.Fill(ds1, "histo")
        gHistorico2.DataSource = ds1.Tables("histo")
        gHistorico2.DataBind()
        If ds1.Tables("histo").Rows.Count = 0 Then
            lErrorHistorico2.Text = "No hay pedidos anteriores o hubo un error al cargalos. Reintente más tarde."
            gHistorico2.Visible = False
        Else
            gHistorico2.Visible = True
        End If
        pAdministrador.Visible = False
        pVerPedidosAdministrador.Visible = True
    End Sub

    Protected Sub gHistoricoAdmin_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gHistorico2.RowCommand
        Dim index As Integer = Convert.ToInt32(e.CommandArgument)
        Dim row As GridViewRow = gHistorico2.Rows(index)
        Dim Npedido As Integer = VNum(row.Cells(3).Text), en As String = Chr(13) & Chr(10)
        Dim NCli As Integer = VNum(row.Cells(6).Text)

        Session("NCli") = NCli

        Session("Npedido") = Npedido
        If (e.CommandName = "Editar") Then
            lDetallePedidoAdmin.Text = "Detalle del Pedido N° " & Npedido
            lErrorHistorico2.Text = ""

            Dim da1 As New SqlDataAdapter("SELECT web_pedidos_detalle.Item, " & "web_pedidos_detalle.NItem, " & "web_pedidos_detalle.Cantidad FROM web_pedidos_detalle INNER JOIN web_Helados ON " & "web_pedidos_detalle.Item = web_Helados.Gusto WHERE web_pedidos_detalle.NPedido=" & Npedido & " ORDER BY web_helados.CODH", con)
            Dim ds1 As New DataSet
            da1.Fill(ds1, "histo")
            gEditarPedidoAdmin.DataSource = ds1.Tables("histo")
            gEditarPedidoAdmin.DataBind()
            If ds1.Tables("histo").Rows.Count = 0 Then
                lErrorHistorico2.Text = "Hubo un error al cargar los items del pedido " & Npedido & ", porque no se leyó ninguno. Reintente más tarde."
                gEditarPedidoAdmin.Visible = False
            Else
                gEditarPedidoAdmin.Visible = True
            End If
            pVerPedidosAdministrador.Visible = False
            pEditarPedidoAdmin.Visible = True

        End If
        If (e.CommandName = "Ver") Then


            lErrorHistorico2.Text = ""
            Dim da1 As New SqlDataAdapter("SELECT web_pedidos_detalle.Item, " & "web_pedidos_detalle.Cantidad FROM web_pedidos_detalle INNER JOIN WEB_Helados ON " & "web_pedidos_detalle.Item = WEB_Helados.GUSTO WHERE web_pedidos_detalle.NPedido=" & Npedido & " ORDER BY WEB_Helados.CODH", con)
            Dim ds1 As New DataSet
            da1.Fill(ds1, "histo")
            gVerUnPedido.DataSource = ds1.Tables("histo")
            gVerUnPedido.DataBind()
            If ds1.Tables("histo").Rows.Count = 0 Then
                lErrorHistorico2.Text = "Hubo un error al cargar los items del pedido " & Npedido & ", porque no se leyó ninguno. Reintente más tarde."
                gVerUnPedido.Visible = False
            Else
                gVerUnPedido.Visible = True
            End If
            pVerPedidosAdministrador.Visible = False
            pVerUnPedido.Visible = True
        End If

        If (e.CommandName = "Anular") Then
            lErrorHistorico2.Text = ""
            Dim da1 As New SqlDataAdapter("select estado from web_pedidos where npedido=" & Npedido, con)
            Dim ds1 As New DataSet
            da1.Fill(ds1, "histo")
            If ds1.Tables("histo").Rows.Count = 0 Then
                lErrorHistorico2.Text = "No puedo acceder al pedido N° " & Npedido & ". Reintente más tarde."
                Exit Sub
            Else
                Dim estado As String = ds1.Tables("histo")(0)("estado").ToString.Trim
                If estado <> "Solicitado" Then
                    lErrorHistorico2.Text = "El pedido tiene estado='" & estado & "' y ya no puede cancelarse por web (sólo 'Solicitado'). Llame a la fábrica por favor."
                    Exit Sub
                Else
                    If estado = "Anulado" Then
                        lErrorHistorico2.Text = "El pedido N° " & Npedido & ", YA estaba Anulado..."
                        Exit Sub
                    End If
                    lErrorHistorico.Text = ""
                    If SQL_Accion("update web_pedidos set estado='Anulado' where npedido=" & Npedido) = False Then
                        lErrorHistorico2.Text = "No he podido cambiar el estado, hubo algún error de conexión. Por favor, reintente más tarde o llame al a fábrica para avisar de la anulación."
                        Exit Sub
                    Else
                        lErrorHistorico2.Text = "El pedido N° " & Npedido & ", fue ANULADO "

                    End If
                End If

            End If
            CargaHistoricoAdmin()
        End If
    End Sub
    Protected Sub gEditarPedidoAdmin_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gEditarPedidoAdmin.RowCommand
        lErrorVerPedidoAdmin.Visible = False
        Dim Npedido As Integer = Session("Npedido")
        Dim indexitem As Integer = Convert.ToInt32(e.CommandArgument)
        Dim rowitem As GridViewRow = gEditarPedidoAdmin.Rows(indexitem)
        Dim NItem As String = VNum(rowitem.Cells(0).Text), en As String = Chr(13) & Chr(10)
        Dim Cantidad As String = VNum(rowitem.Cells(2).Text)
        Dim da2 As New SqlDataAdapter("select Email, usuario from usuarios where idusuario=" & Session("NCli"), con)
        Dim ds2 As New DataSet
        Session("Cant") = 0
        da2.Fill(ds2, "email")
        Session("Email") = ds2.Tables("email").Rows(0)("email").ToString.Trim.ToLower
        Session("Usuario") = ds2.Tables("email").Rows(0)("usuario").ToString.Trim.ToLower
        If (e.CommandName = "Quitar") Then
            lErrorVerPedidoAdmin.Text = ""
            Dim da1 As New SqlDataAdapter("select * from web_pedidos_detalle where npedido=" & Npedido, con)
            Dim ds1 As New DataSet
            da1.Fill(ds1, "histo")

            If ds1.Tables("histo").Rows.Count = 0 Then
                lErrorVerPedidoAdmin.Visible = True
                lErrorVerPedidoAdmin.Text = "No puedo acceder al pedido N° " & Npedido & ". Reintente más tarde."
                Exit Sub
            Else
                If (Cantidad.Equals("1")) Then
                    If SQL_Accion("delete from web_pedidos_detalle where npedido=" & Npedido & "AND nitem=" & NItem) = False Then
                        lErrorVerPedidoAdmin.Text = "Se elimino el producto del pedido"
                        lErrorVerPedidoAdmin.Visible = True
                    Else
                        Session("Cant") = 0
                        Dim Email As String = Session("Email")
                        Dim xusuario = Session("Usuario")
                        Dim productoeliminado As String = rowitem.Cells.Item(1).Text
                        Dim mensaje As String = "Es un placer saludarlo/a, " & xusuario & "." & en & en & "Nos comunicamos de parte de HeladeriaUNLZ, para informarte que por falta de stock debimos  remover de su pedido el producto " & productoeliminado & "." & en & en & "Un saludo, y lamentamos lo ocurrido!" & en & en & en & en & "(Por favor no respondas a éste email, es automático... gracias!)" & en & en
                        Dim ok As String = EnviarMail(Email, "Heladeria UNLZ - Modificaciones en su pedido se elimino un producto", mensaje)
                    End If
                Else
                    If SQL_Accion("update web_pedidos_detalle set Cantidad='" & Cantidad - 1 & "' from web_pedidos_detalle where npedido=" & Npedido & "AND nitem=" & NItem) = False Then
                        lErrorVerPedidoAdmin.Visible = True
                        lErrorVerPedidoAdmin.Text = "No he podido eliminar el producto del pedido, hubo algún error de conexión. Por favor, reintente más tarde o llame al a fábrica para avisar de la anulación."
                    Else
                        lErrorVerPedidoAdmin.Visible = True
                        lErrorVerPedidoAdmin.Text = "El producto fue reducido del pedido."
                        Session("Cant") += 1
                    End If
                End If
            End If
            CargarPedido()
        End If
    End Sub
    Protected Sub bVerPedidos_Click(sender As Object, e As EventArgs) Handles bVerPedidos.Click
        pAdministrador.Visible = False
        pVerPedidosAdministrador.Visible = True
        CargaHistoricoAdmin()
    End Sub

    Protected Sub bActualizarAdmin_Click(sender As Object, e As ImageClickEventArgs) Handles bActualizar2.Click
        CargaHistoricoAdmin()
    End Sub

    Protected Sub bTerminarHistoricoAdmin_Click(sender As Object, e As ImageClickEventArgs) Handles bTerminarHistorico2.Click
        pVerPedidosAdministrador.Visible = False
        pAdministrador.Visible = True
    End Sub

    Protected Sub bVerHistorico_Click(sender As Object, e As ImageClickEventArgs) Handles bVerHistorico.Click
        pAreaUsuario.Visible = False
        pPedidos.Visible = True
    End Sub



    Protected Sub bTerminarEditarPedidoAdmin_Click(sender As Object, e As ImageClickEventArgs) Handles bTerminarEditarPedidoAdmin.Click
        Dim NPedido As Integer = Session("NPedido")
        Dim da1 As New SqlDataAdapter("SELECT web_pedidos_detalle.item, " & "web_pedidos_detalle.Cantidad FROM web_pedidos_detalle INNER JOIN web_helados ON " & "web_pedidos_detalle.Item = web_helados.Item WHERE web_pedidos_detalle.NPedido=" & NPedido & " ORDER BY web_helados.CodProd", con)
        Dim ds1 As New DataSet
        Dim en As String = Chr(13) & Chr(10)
        Dim Nuevoestado As String = dEstadoEnvio.SelectedValue

        If SQL_Accion("update web_pedidos set estado='" & Nuevoestado & "' from web_pedidos where Npedido=" & NPedido & "") = False Then
        Else
            pEditarPedidoAdmin.Visible = False
            pVerPedidosAdministrador.Visible = True
        End If
        If (Session("Cant") > 0) Then
            Dim Email As String = Session("Email")
            Dim xusuario = Session("Usuario")
            Dim mensaje As String = "Es un placer saludarlo/a, " & xusuario & "." & en & en & "Nos comunicamos de parte de Heladeria UNLZ, para informarte que por falta de stock debimos reducir algunos productos de su pedido. Favor de revisar los nuevos cambios." & en & en & "Un saludo, y lamentamos lo ocurrido!" & en & en & en & en & "(Por favor no respondas a éste email, es automático... gracias!)" & en & en
            Dim ok As String = EnviarMail(Email, "Heladeria UNLZ - Modificaciones en su pedido se reducio un producto", mensaje)
            Session("Cant") = 0
        End If
        CargaHistoricoAdmin()
    End Sub

    Protected Sub bRecuperarClave_Click(sender As Object, e As ImageClickEventArgs) Handles bRecuperarClave.Click
        Dim usu As String = tUsuario.Text.Trim.ToUpper, email As String, xusuario As String, mensaje As String, pass As String
        Dim en As String = Chr(13) & Chr(10)
        If comprobar(usu) = False Then
            lReenviarClave.Text = "*** El usuario es incorrecto. Revisá por favor. ***"
            lReenviarClave.Visible = True
            Exit Sub
        End If

        Dim da2 As New SqlDataAdapter("select ltrim(rtrim(nombre)) + ' ' + ltrim(rtrim(apellido)) as usuario, pass," & " email from usuarios where upper(ltrim(rtrim(usuario)))='" & usu & "'", con)
        Dim ds2 As New DataSet
        da2.Fill(ds2, "Login")
        If ds2.Tables("Login").Rows.Count = 0 Then
            lReenviarClave.Text = "*** El usuario es incorrecto. Revisá por favor. ***"
            lReenviarClave.Visible = True
            Exit Sub
        End If
        email = ds2.Tables("Login").Rows(0)("email").ToString.Trim.ToLower
        pass = ds2.Tables("Login").Rows(0)("pass").ToString.Trim.ToLower
        xusuario = ds2.Tables("Login").Rows(0)("usuario").ToString.Trim

        mensaje = "Estimado/a: " & xusuario & "!." & en & en & " Nos comunicamos desde Heladeria UNLZ, en respuesta a su pedido " & "de recuperación de clave." & en & en & "Su usuario es " & """" & usu & """" & en & "Su clave es " & """" & pass & """" & en & en & "Ya podés volver a entrar y armar tus pedidos!" & en & "Cordiales Saludos!" & en & en & en & en & "(Por favor no respondas a éste email, es automático... gracias!)" & en & en

        Dim ok As String = EnviarMail(email, "Heladeria UNLZ - Recuperación de clave", mensaje)
        If ok = "OK" Then
            lReenviarClave.Text = "*** Ya te enviamos un mail con la clave! ***"
        Else
            lReenviarClave.Text = "*** Hubo un error al querer enviar al mail... ***"
        End If
        lReenviarClave.Visible = True
    End Sub

    Sub CargaUsuarios()

        Dim da1 As New SqlDataAdapter("select idUsuario, Usuario, estado from Usuarios order by idUsuario desc", con)
        Dim ds1 As New DataSet
        da1.Fill(ds1, "histo")
        gEditarAccesos.DataSource = ds1.Tables("histo")
        gEditarAccesos.DataBind()
        If ds1.Tables("histo").Rows.Count = 0 Then
            lEr.Text = "No hay pedidos anteriores o hubo un error al cargalos. Reintente más tarde."
            gEditarAccesos.Visible = False
        Else
            gEditarAccesos.Visible = True
        End If

    End Sub

    Sub CargarPedido()
        lDetallePedidoAdmin.Text = "Detalle del Pedido N° " & Session("NPedido")
        lErrorHistorico2.Text = ""

        Dim da1 As New SqlDataAdapter("SELECT web_pedidos_detalle.Item, " & "web_pedidos_detalle.NItem, " & "web_pedidos_detalle.Cantidad FROM web_pedidos_detalle INNER JOIN web_Helados ON " & "web_pedidos_detalle.Item = web_Helados.Gusto WHERE web_pedidos_detalle.NPedido=" & Session("NPedido") & " ORDER BY web_helados.CODH", con)
        Dim ds1 As New DataSet
        da1.Fill(ds1, "histo")
        gEditarPedidoAdmin.DataSource = ds1.Tables("histo")
        gEditarPedidoAdmin.DataBind()
        If ds1.Tables("histo").Rows.Count = 0 Then
            lErrorHistorico2.Text = "Hubo un error al cargar los items del pedido " & Session("NPedido") & ", porque no se leyó ninguno. Reintente más tarde."
            gEditarPedidoAdmin.Visible = False
        Else
            gEditarPedidoAdmin.Visible = True
        End If
    End Sub
    Protected Sub bAccesosUsuario_Click(sender As Object, e As EventArgs) Handles bModerar.Click
        pAccesosUsuario.Visible = True
        pAdministrador.Visible = False
        CargaUsuarios()
    End Sub


    Protected Sub gEditarAccesos_RowCommand(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles gEditarAccesos.RowCommand
        Dim index As Integer = Convert.ToInt32(e.CommandArgument)
        Dim row As GridViewRow = gEditarAccesos.Rows(index)
        Dim IDUsuario As String = VNum(row.Cells(0).Text)


        Dim en As String = Chr(13) & Chr(10)
        Dim da2 As New SqlDataAdapter("select Email, usuario from usuarios where idusuario=" & IDUsuario, con)
        Dim ds2 As New DataSet
        da2.Fill(ds2, "email")
        Session("Email") = ds2.Tables("email").Rows(0)("email").ToString.Trim.ToLower
        Session("Usuario") = ds2.Tables("email").Rows(0)("usuario").ToString.Trim.ToLower
        lEr.Text = ""

        Dim motivo = tMotivoAcceso.Text
        If (e.CommandName = "HabilitarCuenta") Then

            If SQL_Accion("update Usuarios set estado='Habilitado' where IDUsuario=" & IDUsuario) = False Then
                lEr.Visible = True
                lEr.Text = "No he podido habilitar la cuenta del usuario. Hubo algún error de conexión. Por favor, reintente más tarde."
                Exit Sub
            Else
                lEr.Visible = True
                lEr.Text = "La cuenta del usuario" & IDUsuario & " fue habilitada con éxito."

                Dim Email As String = Session("Email")
                Dim xusuario = Session("Usuario")

                Dim mensaje As String = "Estimado/a: " & xusuario & "." & en & en & "Nos comunicamos de parte de Heladeria UNLZ!, para informarle que su cuenta ha sido habilitada en nuestros sistemas para continuar operando." & en & en & "Un cordial saludo!" & en & en & en & en & "(Por favor no respondas a éste email, es automático... gracias!)" & en & en
                EnviarMail(Email, "Heladeria UNLZ - Cuenta Habilitada", mensaje)
            End If
        End If
        If (e.CommandName = "BloquearCuenta") Then

            If SQL_Accion("update Usuarios set estado='Bloqueado' where IDUsuario=" & IDUsuario) = False Then
                lEr.Visible = True
                lEr.Text = "No he podido suspender la cuenta del usuario. Hubo algún error de conexión. Por favor, reintente más tarde."
                Exit Sub
            Else
                lEr.Visible = True
                lEr.Text = "La cuenta del usuario" & IDUsuario & " fue bloqueada con éxito."

                Dim Email As String = Session("Email")
                Dim xusuario = Session("Usuario")

                Dim mensaje As String = "Estimado/a: " & xusuario & "." & en & en & "Nos comunicamos de parte de Heladeria UNLZ, para informarle que su cuenta ha sido bloqueada en nuestros sistemas y no podra seguir operando. Un administrador le informa sobre los motivos: " & en & en & motivo & en & en & "Cordiales saludos." & en & en & en & en & "(Por favor no respondas a éste email, es automático... gracias!)" & en & en
                EnviarMail(Email, "Heladeria UNLZ - Cuenta Bloqueada", mensaje)
            End If

        End If
        If (e.CommandName = "EliminarCuenta") Then

            Dim da1 As New SqlDataAdapter("select idusuario, usuario, estado from usuarios where estado='Bloqueado' AND idusuario=" & IDUsuario, con)
            Dim ds1 As New DataSet
            da1.Fill(ds1, "histo")

            If ds1.Tables("histo").Rows.Count = 0 Then
                lEr.Visible = True
                lEr.Text = "El usuario debe estar primero bloqueado para ser posteriormente eliminado."
                Exit Sub
            Else

                If SQL_Accion("delete usuarios where idusuario=" & IDUsuario) = False Then
                    lEr.Visible = True
                    lEr.Text = "No he podido eliminar la cuenta del usuario. Hubo algún error de conexión. Por favor, reintente más tarde."
                    Exit Sub
                Else
                    lEr.Visible = True
                    lEr.Text = "La cuenta del usuario" & IDUsuario & " fue eliminada con éxito."

                    Dim Email As String = Session("Email")
                    Dim xusuario = Session("Usuario")

                    Dim mensaje As String = "Estimado/a: " & xusuario & "." & en & en & "Nos comunicamos de parte de Heladeria UNLZ, para informarle que su cuenta ha sido eliminada de nuestros sistemas y no puede seguir operando. Un administrador le informa sobre los motivos: " & en & en & motivo & en & en & "Un cordial saludo." & en & en & en & en & "(Por favor no respondas a éste email, es automático... gracias!)" & en & en
                    EnviarMail(Email, "Heladeria UNLZ - Cuenta Eliminada", mensaje)
                End If
            End If
        End If

        CargaUsuarios()

    End Sub

    Protected Sub bTerminarAccesos_Click(sender As Object, e As ImageClickEventArgs) Handles bTerminarAccesos.Click
        pAccesosUsuario.Visible = False
        pAdministrador.Visible = True
    End Sub

    Protected Sub bValidar_Click(sender As Object, e As EventArgs) Handles bValidar.Click

        Dim sqlIngreso As String = Session("sqlIngreso") & " "
        If sqlIngreso.Length < 10 Or sqlIngreso.IndexOf("insert") < 0 Then
            lErroresU.Text = "Hubo un error con el código. Por favor, trate de generar un nuevo código."
            lErroresU.Visible = True
            Exit Sub
        End If
        If tValidar.Text.Trim.ToUpper.Equals(Session("Codigo")) = False Then
            lCodigo.Visible = True
            Exit Sub
        End If

        If SQL_Accion(sqlIngreso) = False Then
            lErroresU.Text = "Hubo un error al tratar de validar al código. Por favor, trate de generar un nuevo código."
            lErroresU.Visible = True
            Exit Sub
        End If
        Session("idUsuario") = VNum(LeeUnCampo("select top 1 idUsuario from usuarios where Usuario ='" & Session("Usuario") & "' and Pass='" & Session("Password") & "' ", "idusuario"))
        Dim mensaje As String, xusuario As String = Session("ApellidoYNombre"), en As String = Chr(13) & Chr(10)
        mensaje = "Bienvenido" & xusuario & " a Heladeria UNLZ!." & en & en & "Le damos una cordial bienvenida a la plataforma que acerca a la puerta de tu casa los mejores helados, con la calidad y gusto que merece." & en & en & "Tu usuario es " & """" & Session("Usuario") & """" & Session("Password") & """" & en & en & "Ya podés loguearte para ver tus datos y operar en nuestra aplicación." & en & en
        LimpiarRegistroU()
        pVerificarMail.Visible = False
        pRegistrarse.Visible = False
        pBienvenido.Visible = True
        bRegistrarseVolverLoginU.Focus()
    End Sub

    Protected Sub bRegresarRegistro_Click(sender As Object, e As EventArgs) Handles bRegresarRegistro.Click
        pVerificarMail.Visible = False
        tValidar.Text = ""
        pRegistrarse.Visible = True
    End Sub

    Protected Sub bCancelarValidar_Click(sender As Object, e As ImageClickEventArgs) Handles bCancelarValidar.Click
        pVerificarMail.Visible = False
        tValidar.Text = ""
        pLoginMenu.Visible = True
        rRol.SelectedIndex = 0
    End Sub

    Protected Sub bAdministrar_Click(sender As Object, e As EventArgs) Handles bAdministrar.Click
        pAdministrador.Visible = False
        pProductosA.Visible = True
    End Sub

    Protected Sub bTerminarAdmin0_Click(sender As Object, e As EventArgs) Handles bTerminarAdmin0.Click
        pProductosA.Visible = False
        pAdministrador.Visible = True
    End Sub

    Protected Sub bEliminar_Click(sender As Object, e As EventArgs) Handles bEliminar.Click
        Dim ok As Boolean = True

        If ok Then
            If SQL_Accion("delete web_helados where gusto='" & dProductosEli.SelectedValue.ToString & "'") = False Then
                lErrorMod.Text = "Se ha producido un error al querer eliminar el producto..."
                lErrorMod.Visible = True
                Exit Sub
            End If
        End If

        lModi.Text = "Producto eliminado correctamente."
        bVolver2.Focus()
    End Sub

    Protected Sub bEliminarP_Click(sender As Object, e As EventArgs) Handles bEliminarP.Click
        lErrorE.Text = ""
        Dim da As New SqlDataAdapter("select * from web_helados order by gusto", con)

        Dim ds As New DataSet
        da.Fill(ds)
        dProductosEli.DataTextField = ds.Tables(0).Columns("gusto").ToString()
        dProductosEli.DataSource = ds.Tables(0)
        dProductosEli.DataBind()
        If ds.Tables.Count = 0 Then
            lErrorE.Text = "No hay productos o hubo un error al cargalos. Reintente más tarde."
            pEliminarProd.Visible = False
        Else
            pEliminarProd.Visible = True
        End If
        lCosaModificar2.Text = dProductosEli.SelectedValue.ToString
        If lCosaModificar2.Text.Equals("Label") Then
            lCosaModificar2.Visible = False
        Else
            lCosaModificar2.Visible = True
        End If

        pProductosA.Visible = False
        pEliminarProd.Visible = True
    End Sub

    Protected Sub bModificar_Click(sender As Object, e As EventArgs) Handles bModificar.Click
        Dim ok As Boolean = True

        tGustoM.Text = tGustoM.Text.Trim.ToUpper
        If comprobar(tGustoM.Text) = False Then
            ArreglarCampo(tGustoM)
            ok = False
            lErrorProdMod.Text = "El producto contenía caracteres inválidos, fueron quitados"
            lErrorProdMod.Visible = True
        End If


        tPrecioM.Text = tPrecioM.Text.Trim
        If comprobar(tPrecioM.Text) = False Then
            ArreglarCampo(tPrecioM)
            ok = False
            lErrorPrecioMod.Text = "El precio contenía caracteres inválidos, fueron quitados"
            lErrorPrecioMod.Visible = True
        End If
        tStockM.Text = tStockM.Text.Trim
        If comprobar(tStockM.Text) = False Then
            ArreglarCampo(tStockM)
            ok = False
            lErrorStockMod.Text = "El stock contenía caracteres inválidos, fueron quitados"
            lErrorStockMod.Visible = True
        End If


        If ok Then
            If SQL_Accion("update web_helados set gusto='" & tGustoM.Text & "', PrecioSinIva='" & tPrecioM.Text & "', Stock='" & tStockM.Text & "' " & "where gusto='" & lCosaModificar.Text & "'") = False Then
                lErrorMod.Text = "Se ha producido un error al querer modificar el producto..."
                lErrorMod.Visible = True
                Exit Sub
            End If
        End If

        lModi.Text = "Producto modificado correctamente."
        bVolver1.Focus()
        tGustoM.Text = ""
        tPrecioM.Text = ""
        tStockM.Text = ""
    End Sub

    Protected Sub bAgregar_Click(sender As Object, e As EventArgs) Handles bAgregar.Click
        Dim ok As Boolean = True
        LimpiarErroresAltaProductos()
        tGusto.Text = tGusto.Text.Trim.ToUpper
        If comprobar(tGusto.Text) = False Then
            ArreglarCampo(tGusto)
            ok = False
            lErrorProd.Text = "El producto contenía caracteres inválidos, fueron quitados"
            lErrorProd.Visible = True
        End If


        tPrecio.Text = tPrecio.Text.Trim
        If comprobar(tPrecio.Text) = False Then
            ArreglarCampo(tPrecio)
            ok = False
            lErrorPrecio.Text = "El precio contenía caracteres inválidos, fueron quitados"
            lErrorPrecio.Visible = True
        End If
        tStock.Text = tStock.Text.Trim
        If comprobar(tStock.Text) = False Then
            ArreglarCampo(tStock)
            ok = False
            lErrorStock.Text = "El stock contenía caracteres inválidos, fueron quitados"
            lErrorStock.Visible = True
        End If

        LimpiarErroresAltaProductos()
        If SQL_Accion("insert into web_helados (gusto,preciosiniva,stock) values('" & tGusto.Text.Trim & "','" & tPrecio.Text.Trim & "','" & tStock.Text.Trim & "')") = False Then
            lErrorAlta.Text = "Se ha producido un error al querer dar de alta el producto..."
            lErrorAlta.Visible = True
            Exit Sub
        End If

        LimpiarErroresAltaProductos()
        lAgregado.Text = "Producto agregado correctamente"
        lAgregado.Visible = True
        bVolver0.Focus()
        tGusto.Text = ""
        tPrecio.Text = ""
        tStock.Text = ""
    End Sub

    Protected Sub bVolver0_Click(sender As Object, e As EventArgs) Handles bVolver0.Click
        pAltaProd.Visible = False
        pProductosA.Visible = True
    End Sub

    Protected Sub bVolver1_Click(sender As Object, e As EventArgs) Handles bVolver1.Click
        lModi.Text = ""
        lModi.Visible = False
        pModificarProd.Visible = False
        pProductosA.Visible = True
        tGustoM.Text = ""
        tStockM.Text = ""
        tPrecioM.Text = ""
    End Sub

    Protected Sub bVolver2_Click(sender As Object, e As EventArgs) Handles bVolver2.Click
        pEliminarProd.Visible = False
        pProductosA.Visible = True
    End Sub

    Protected Sub dProductosEli_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dProductosEli.SelectedIndexChanged
        lCosaModificar2.Text = dProductosEli.SelectedItem.ToString
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs)

    End Sub
End Class
