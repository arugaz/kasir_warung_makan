<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
    Inherits System.Windows.Forms.Form

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
    Private components As System.ComponentModel.IContainer

    Private txtUsername As System.Windows.Forms.TextBox
    Private txtPassword As System.Windows.Forms.TextBox
    Private WithEvents btnLogin As System.Windows.Forms.Button
    Private lblTitle As System.Windows.Forms.Label
    Private lblUsername As System.Windows.Forms.Label
    Private lblPassword As System.Windows.Forms.Label

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()

        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()

        Me.SuspendLayout()

        ' ===== Title =====
        With Me.lblTitle
            .AutoSize = True
            .Font = New System.Drawing.Font("Segoe UI", 18.0F, FontStyle.Bold)
            .Text = "LOGIN KASIR"
            .Location = New System.Drawing.Point(317, 66)
            .ForeColor = System.Drawing.Color.FromArgb(0, 80, 160)
        End With

        ' ===== Username =====
        With Me.lblUsername
            .AutoSize = True
            .Font = New System.Drawing.Font("Segoe UI", 10.5F)
            .Text = "Username"
            .Location = New System.Drawing.Point(260, 133)
        End With

        With Me.txtUsername
            .Size = New System.Drawing.Size(280, 32)
            .Font = New System.Drawing.Font("Segoe UI", 10.5F)
            .Location = New System.Drawing.Point(260, 160)
            .MaxLength = 24
            .TabIndex = 0
        End With

        ' ===== Password =====
        With Me.lblPassword
            .AutoSize = True
            .Font = New System.Drawing.Font("Segoe UI", 10.5F)
            .Text = "Password"
            .Location = New System.Drawing.Point(260, 208)
        End With

        With Me.txtPassword
            .Size = New System.Drawing.Size(280, 32)
            .Font = New System.Drawing.Font("Segoe UI", 10.5F)
            .Location = New System.Drawing.Point(260, 235)
            .UseSystemPasswordChar = True
            .MaxLength = 64
            .TabIndex = 1
        End With

        ' ===== Login Button =====
        With Me.btnLogin
            .Size = New System.Drawing.Size(140, 45)
            .Font = New System.Drawing.Font("Segoe UI", 11.0F, FontStyle.Bold)
            .Text = "MASUK"
            .Location = New System.Drawing.Point(330, 296)
            .BackColor = System.Drawing.Color.FromArgb(0, 120, 215)
            .ForeColor = System.Drawing.Color.White
            .FlatStyle = System.Windows.Forms.FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            .Cursor = System.Windows.Forms.Cursors.Hand
            .UseVisualStyleBackColor = False
            .TabIndex = 2
        End With

        ' ===== Form Settings =====
        With Me
            .AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            .ClientSize = New System.Drawing.Size(800, 450)
            .Text = "Warung Makan - Login"
            .BackColor = System.Drawing.Color.FromArgb(248, 249, 250)
            .Font = New System.Drawing.Font("Segoe UI", 9.75F)
            .FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            .MaximizeBox = False
            .MinimizeBox = False
            .StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
