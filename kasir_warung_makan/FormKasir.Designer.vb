<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKasir
    Inherits Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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

    Private grpMenu As GroupBox
    Private WithEvents txtQty As TextBox
    Private lblQty As Label
    Private WithEvents btnTambah As Button
    Private WithEvents btnHapus As Button
    Private grpPesanan As GroupBox
    Private lstPesanan As ListBox
    Private lblSubtotal As Label
    Private lblDiskon As Label
    Private lblTagTotal As Label
    Private lblTotal As Label
    Private WithEvents btnProses As Button
    Private WithEvents btnStruk As Button
    Private WithEvents btnCSV As Button
    Private WithEvents btnReset As Button
    Private menuRadios As New List(Of RadioButton)

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New Container()

        Me.grpMenu = New GroupBox()
        Me.lblQty = New Label()
        Me.txtQty = New TextBox()
        Me.btnTambah = New Button()

        Me.grpPesanan = New GroupBox()
        Me.lstPesanan = New ListBox()
        Me.btnHapus = New Button()

        Me.lblSubtotal = New Label()
        Me.lblDiskon = New Label()
        Me.lblTagTotal = New Label()
        Me.lblTotal = New Label()

        Me.btnProses = New Button()
        Me.btnStruk = New Button()
        Me.btnCSV = New Button()
        Me.btnReset = New Button()

        Me.SuspendLayout()

        ' ===== Group Menu =====
        With Me.grpMenu
            .Text = "Menu Makanan & Minuman"   ' ← fixed && to &
            .Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
            .ForeColor = Color.FromArgb(0, 80, 160)
            .Location = New Point(15, 20)
            .Size = New Size(360, 200)
        End With

        With Me.lblQty
            .AutoSize = True
            .Text = "Jumlah :"
            .Location = New Point(15, 170)
        End With

        With Me.txtQty
            .Location = New Point(100, 170)
            .Size = New Size(60, 25)
            .TextAlign = HorizontalAlignment.Center
            .MaxLength = 4
        End With

        With Me.btnTambah
            .Text = "Tambah ke Pesanan"
            .Location = New Point(180, 170)
            .Size = New Size(155, 25)
            .BackColor = Color.FromArgb(0, 120, 215)
            .ForeColor = Color.White
            .FlatStyle = FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            .Cursor = Cursors.Hand
        End With

        Me.grpMenu.Controls.AddRange(New Control() {Me.lblQty, Me.txtQty, Me.btnTambah})

        ' ===== Group Pesanan =====
        With Me.grpPesanan
            .Text = "Daftar Pesanan"
            .Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
            .ForeColor = Color.FromArgb(0, 80, 160)
            .Location = New Point(15, 220)
            .Size = New Size(360, 200)
        End With

        With Me.lstPesanan
            .Location = New Point(15, 30)
            .Size = New Size(330, 130)
            .Font = New Font("Consolas", 10.0F)
        End With

        With Me.btnHapus
            .Text = "Hapus Item"
            .Location = New Point(15, 165)
            .Size = New Size(330, 25)
            .BackColor = Color.IndianRed
            .ForeColor = Color.White
            .FlatStyle = FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            .Cursor = Cursors.Hand
        End With

        Me.grpPesanan.Controls.AddRange(New Control() {Me.lstPesanan, Me.btnHapus})

        ' ===== Total Section =====
        With Me.lblSubtotal
            .Size = New Size(355, 30)
            .TextAlign = ContentAlignment.MiddleLeft
            .Font = New Font("Consolas", 12.0F, FontStyle.Bold)
            .Location = New Point(410, 40)
        End With

        With Me.lblDiskon
            .Size = New Size(355, 30)
            .TextAlign = ContentAlignment.MiddleLeft
            .Font = New Font("Consolas", 12.0F, FontStyle.Bold)
            .Location = New Point(410, 85)
        End With

        With Me.lblTagTotal
            .Size = New Size(355, 2)
            .TextAlign = ContentAlignment.MiddleLeft
            .Location = New Point(410, 130)
            .BackColor = Color.FromArgb(200, 200, 200)
        End With

        With Me.lblTotal
            .Size = New Size(355, 30)
            .TextAlign = ContentAlignment.MiddleLeft
            .Font = New Font("Consolas", 12.0F, FontStyle.Bold)
            .Location = New Point(410, 175)
            .ForeColor = Color.FromArgb(0, 80, 160)
        End With

        ' ===== Action Buttons =====
        With Me.btnProses
            .Text = "PROSES"
            .Location = New Point(410, 255)
            .Size = New Size(110, 50)
            .BackColor = Color.FromArgb(40, 167, 69)
            .ForeColor = Color.White
            .FlatStyle = FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            .Cursor = Cursors.Hand
        End With

        With Me.btnStruk
            .Text = "CETAK STRUK"
            .Location = New Point(410, 345)
            .Size = New Size(110, 50)
            .BackColor = Color.FromArgb(0, 123, 255)
            .ForeColor = Color.White
            .FlatStyle = FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            .Cursor = Cursors.Hand
        End With

        With Me.btnCSV
            .Text = "SIMPAN CSV"
            .Location = New Point(654, 255)
            .Size = New Size(110, 50)
            .BackColor = Color.FromArgb(108, 117, 125)
            .ForeColor = Color.White
            .FlatStyle = FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            .Cursor = Cursors.Hand
        End With

        With Me.btnReset
            .Text = "RESET"
            .Location = New Point(654, 345)
            .Size = New Size(110, 50)
            .BackColor = Color.FromArgb(220, 53, 69)
            .ForeColor = Color.White
            .FlatStyle = FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            .Cursor = Cursors.Hand
        End With

        ' ===== Form Settings =====
        With Me
            .AutoScaleMode = AutoScaleMode.Font
            .ClientSize = New Size(800, 450)
            .Text = "Warung Makan - Kasir"
            .BackColor = Color.FromArgb(248, 249, 250)
            .Font = New Font("Segoe UI", 9.75F)
            .FormBorderStyle = FormBorderStyle.FixedDialog
            .MaximizeBox = False
            .StartPosition = FormStartPosition.CenterScreen
        End With

        Me.Controls.AddRange(New Control() {
            Me.grpMenu, Me.grpPesanan,
            Me.lblSubtotal, Me.lblDiskon, Me.lblTagTotal, Me.lblTotal,
            Me.btnProses, Me.btnStruk, Me.btnCSV, Me.btnReset
        })

        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Private Sub FormKasir_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' ===== Initialize Totals =====
        lblSubtotal.Text = String.Format("{0,-15}Rp{1,12:N0}", "Subtotal", 0)
        lblDiskon.Text = String.Format("{0,-15}Rp{1,12:N0}", "Diskon", 0)
        lblTotal.Text = String.Format("{0,-15}Rp{1,12:N0}", "Total", 0)
        txtQty.Text = "0"

        ' ===== Initialize Menus =====
        Dim y As Integer = 34

        For Each menuItem In MenuItems
            Dim rb As New RadioButton()

            rb.AutoSize = True
            rb.Font = New Font("Consolas", 10)
            rb.Text = String.Format(
                "{0,-25}Rp{1,8:N0}",
                menuItem.Name,
                menuItem.Price
            )
            rb.Tag = menuItem
            rb.Location = New Point(15, y)

            grpMenu.Controls.Add(rb)
            menuRadios.Add(rb)

            y += 34
        Next
    End Sub

    Private Sub TxtQty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQty.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) OrElse e.KeyChar = ControlChars.Back)
    End Sub

End Class
