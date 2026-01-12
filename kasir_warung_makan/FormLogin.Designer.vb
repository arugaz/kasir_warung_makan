<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
    Inherits Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As IContainer

    Private txtUsername As TextBox
    Private txtPassword As TextBox
    Private WithEvents btnLogin As Button
    Private lblTitle As Label
    Private lblUsername As Label
    Private lblPassword As Label

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New Container()

        Me.lblTitle = New Label()
        Me.lblUsername = New Label()
        Me.txtUsername = New TextBox()
        Me.lblPassword = New Label()
        Me.txtPassword = New TextBox()
        Me.btnLogin = New Button()

        Me.SuspendLayout()

        ' ===== Title =====
        With Me.lblTitle
            .AutoSize = True
            .Font = New Font("Segoe UI", 18.0F, FontStyle.Bold)
            .Text = "LOGIN KASIR"
            .Location = New Point(317, 66)
            .ForeColor = Color.FromArgb(0, 80, 160)
        End With

        ' ===== Username =====
        With Me.lblUsername
            .AutoSize = True
            .Font = New Font("Segoe UI", 10.5F)
            .Text = "Username"
            .Location = New Point(260, 133)
        End With

        With Me.txtUsername
            .Size = New Size(280, 32)
            .Font = New Font("Segoe UI", 10.5F)
            .Location = New Point(260, 160)
            .MaxLength = 24
            .TabIndex = 0
        End With

        ' ===== Password =====
        With Me.lblPassword
            .AutoSize = True
            .Font = New Font("Segoe UI", 10.5F)
            .Text = "Password"
            .Location = New Point(260, 208)
        End With

        With Me.txtPassword
            .Size = New Size(280, 32)
            .Font = New Font("Segoe UI", 10.5F)
            .Location = New Point(260, 235)
            .UseSystemPasswordChar = True
            .MaxLength = 64
            .TabIndex = 1
        End With

        ' ===== Login Button =====
        With Me.btnLogin
            .Size = New Size(140, 45)
            .Font = New Font("Segoe UI", 11.0F, FontStyle.Bold)
            .Text = "MASUK"
            .Location = New Point(330, 296)
            .BackColor = Color.FromArgb(0, 120, 215)
            .ForeColor = Color.White
            .FlatStyle = FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            .Cursor = Cursors.Hand
            .UseVisualStyleBackColor = False
            .TabIndex = 2
        End With

        ' ===== Form Settings =====
        With Me
            .AutoScaleMode = AutoScaleMode.Font
            .ClientSize = New Size(800, 450)
            .Text = "Warung Makan - Login"
            .BackColor = Color.FromArgb(248, 249, 250)
            .Font = New Font("Segoe UI", 9.75F)
            .FormBorderStyle = FormBorderStyle.FixedDialog
            .MaximizeBox = False
            .MinimizeBox = False
            .StartPosition = FormStartPosition.CenterScreen
            .AcceptButton = Me.btnLogin
        End With

        Me.Controls.AddRange(New Control() {
            Me.lblTitle,
            Me.lblUsername, Me.txtUsername,
            Me.lblPassword, Me.txtPassword,
            Me.btnLogin
        })

        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

End Class
