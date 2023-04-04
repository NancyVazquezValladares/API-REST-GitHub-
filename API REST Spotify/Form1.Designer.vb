<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BtnSolicitud = New System.Windows.Forms.Button()
        Me.lbRepositorios = New System.Windows.Forms.ListBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnSolicitud
        '
        Me.BtnSolicitud.BackColor = System.Drawing.Color.Transparent
        Me.BtnSolicitud.BackgroundImage = Global.API_REST_Spotify.My.Resources.Resources.enviar_mensaje
        Me.BtnSolicitud.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSolicitud.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSolicitud.ForeColor = System.Drawing.Color.Transparent
        Me.BtnSolicitud.Location = New System.Drawing.Point(424, 60)
        Me.BtnSolicitud.Name = "BtnSolicitud"
        Me.BtnSolicitud.Size = New System.Drawing.Size(76, 56)
        Me.BtnSolicitud.TabIndex = 5
        Me.BtnSolicitud.UseVisualStyleBackColor = False
        '
        'lbRepositorios
        '
        Me.lbRepositorios.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbRepositorios.ForeColor = System.Drawing.Color.Black
        Me.lbRepositorios.FormattingEnabled = True
        Me.lbRepositorios.ItemHeight = 20
        Me.lbRepositorios.Location = New System.Drawing.Point(62, 177)
        Me.lbRepositorios.Name = "lbRepositorios"
        Me.lbRepositorios.Size = New System.Drawing.Size(534, 344)
        Me.lbRepositorios.TabIndex = 8
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUsuario.Location = New System.Drawing.Point(162, 70)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(237, 28)
        Me.txtUsuario.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Lucida Fax", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(157, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(309, 22)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Ingresa tu Nombre de Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(58, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "REPOSITORIOS"
        '
        'btnBorrar
        '
        Me.btnBorrar.BackColor = System.Drawing.Color.Transparent
        Me.btnBorrar.BackgroundImage = Global.API_REST_Spotify.My.Resources.Resources.basura
        Me.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrar.ForeColor = System.Drawing.Color.Transparent
        Me.btnBorrar.Location = New System.Drawing.Point(83, 549)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(76, 56)
        Me.btnBorrar.TabIndex = 11
        Me.btnBorrar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Transparent
        Me.btnSalir.BackgroundImage = Global.API_REST_Spotify.My.Resources.Resources.cerrar_sesion
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.ForeColor = System.Drawing.Color.Transparent
        Me.btnSalir.Location = New System.Drawing.Point(210, 549)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(68, 56)
        Me.btnSalir.TabIndex = 12
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.API_REST_Spotify.My.Resources.Resources.Fondo_Negro_3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(695, 640)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.lbRepositorios)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnSolicitud)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Lucida Fax", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "GitHub.Com"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnSolicitud As Button
    Friend WithEvents lbRepositorios As ListBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnSalir As Button
End Class
