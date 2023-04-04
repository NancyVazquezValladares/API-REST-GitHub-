Imports System.Net.Http
Imports System.Net.Http.Headers
Imports Newtonsoft.Json.Linq

Public Class Form1
    Private Async Sub BtnSolicitud_Click(sender As Object, e As EventArgs) Handles BtnSolicitud.Click
        Try
            ' URL de la API REST de GitHub para buscar repositorios de un usuario específico
            Dim apiUrl As String = "https://api.github.com/users/{username}/repos"

            ' Solicita al usuario que ingrese el nombre de usuario de GitHub del propietario del repositorio
            Dim username As String = txtUsuario.Text.Trim() '.Trim se utiliza para eliminar todos los espacios en blanco
            'Opcion1:txtUsuario.Text.Trim() Ingresa tu username desde el textbox
            'Opcion2: InputBox("Ingresa el nombre de usuario de GitHub del propietario del repositorio:", "Nombre de usuario")

            'Token
            Dim token As String = "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"

            ' Cliente HTTP para enviar la solicitud a la API REST
            Dim httpClient As New HttpClient()
            httpClient.DefaultRequestHeaders.UserAgent.Add(New ProductInfoHeaderValue("Mozilla", "5.0"))
            httpClient.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))

            ' Agrega el token de acceso personal como un encabezado de autorización en la solicitud HTTP
            httpClient.DefaultRequestHeaders.Authorization = New AuthenticationHeaderValue("Bearer", token)

            ' Envia la solicitud HTTP GET a la API REST de GitHub y obtiene la respuesta
            Dim response As HttpResponseMessage = Await httpClient.GetAsync(apiUrl.Replace("{username}", username))

            ' Si la respuesta es satisfactoria, obtiene el contenido de la respuesta como una cadena JSON
            If response.IsSuccessStatusCode Then
                Dim responseContent As String = Await response.Content.ReadAsStringAsync()

                ' Analiza la cadena JSON para obtener un arreglo de objetos JSON que representan los repositorios
                Dim repositories As JArray = JArray.Parse(responseContent)

                ' Agrega el nombre de cada repositorio a la lista de repositorios en el formulario
                For Each repository As JObject In repositories

                    lbRepositorios.Items.Add(repository("name"))
                Next
            Else
                MessageBox.Show("Error al buscar los repositorios: " + response.ReasonPhrase)
            End If
        Catch ex As Exception
            MessageBox.Show("Error al buscar los repositorios: " + ex.Message)
        End Try
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        lbRepositorios.Items.Clear()
        txtUsuario.Clear()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class
