<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKasir
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    Private grpMenu As System.Windows.Forms.GroupBox
    Private WithEvents txtQty As System.Windows.Forms.TextBox
    Private lblQty As System.Windows.Forms.Label
    Private WithEvents btnTambah As System.Windows.Forms.Button
    Private WithEvents btnHapus As System.Windows.Forms.Button
    Private grpPesanan As System.Windows.Forms.GroupBox
    Private lstPesanan As System.Windows.Forms.ListBox
    Private lblSubtotal As System.Windows.Forms.Label
    Private lblDiskon As System.Windows.Forms.Label
    Private lblTagTotal As System.Windows.Forms.Label
    Private lblTotal As System.Windows.Forms.Label
    Private WithEvents btnProses As System.Windows.Forms.Button
    Private WithEvents btnStruk As System.Windows.Forms.Button
    Private WithEvents btnCSV As System.Windows.Forms.Button
    Private WithEvents btnReset As System.Windows.Forms.Button
    Private menuRadios As New System.Collections.Generic.List(Of System.Windows.Forms.RadioButton)

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()

        Me.grpMenu = New System.Windows.Forms.GroupBox()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.btnTambah = New System.Windows.Forms.Button()

        Me.grpPesanan = New System.Windows.Forms.GroupBox()
        Me.lstPesanan = New System.Windows.Forms.ListBox()
        Me.btnHapus = New System.Windows.Forms.Button()

        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblDiskon = New System.Windows.Forms.Label()
        Me.lblTagTotal = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()

        Me.btnProses = New System.Windows.Forms.Button()
        Me.btnStruk = New System.Windows.Forms.Button()
        Me.btnCSV = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()

        Me.SuspendLayout()

        ' ===== Group Menu =====
        With Me.grpMenu
            .Text = "Menu Makanan & Minuman"   ' ← fixed && to &
            .Font = New System.Drawing.Font("Segoe UI", 10.0F, FontStyle.Bold)
            .ForeColor = System.Drawing.Color.FromArgb(0, 80, 160)
            .Location = New System.Drawing.Point(15, 20)
            .Size = New System.Drawing.Size(360, 200)
        End With

        With Me.lblQty
            .AutoSize = True
            .Text = "Jumlah :"
            .Location = New System.Drawing.Point(15, 170)
        End With

        With Me.txtQty
            .Location = New System.Drawing.Point(100, 170)
            .Size = New System.Drawing.Size(60, 25)
            .TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            .MaxLength = 4
        End With

        With Me.btnTambah
            .Text = "Tambah ke Pesanan"
            .Location = New System.Drawing.Point(180, 170)
            .Size = New System.Drawing.Size(155, 25)
            .BackColor = System.Drawing.Color.FromArgb(0, 120, 215)
            .ForeColor = System.Drawing.Color.White
            .FlatStyle = System.Windows.Forms.FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            .Cursor = System.Windows.Forms.Cursors.Hand
        End With

        Me.grpMenu.Controls.AddRange(New Control() {Me.lblQty, Me.txtQty, Me.btnTambah})

        ' ===== Group Pesanan =====
        With Me.grpPesanan
            .Text = "Daftar Pesanan"
            .Font = New System.Drawing.Font("Segoe UI", 10.0F, FontStyle.Bold)
            .ForeColor = System.Drawing.Color.FromArgb(0, 80, 160)
            .Location = New System.Drawing.Point(15, 220)
            .Size = New System.Drawing.Size(360, 200)
        End With

        With Me.lstPesanan
            .Location = New System.Drawing.Point(15, 30)
            .Size = New System.Drawing.Size(330, 130)
        End With

        With Me.btnHapus
            .Text = "Hapus Item"
            .Location = New System.Drawing.Point(15, 165)
            .Size = New System.Drawing.Size(330, 25)
            .BackColor = System.Drawing.Color.IndianRed
            .ForeColor = System.Drawing.Color.White
            .FlatStyle = System.Windows.Forms.FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            .Cursor = System.Windows.Forms.Cursors.Hand
        End With

        Me.grpPesanan.Controls.AddRange(New Control() {Me.lstPesanan, Me.btnHapus})

        ' ===== Total Section =====
        With Me.lblSubtotal
            .Size = New System.Drawing.Size(355, 30)
            .TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            .Font = New System.Drawing.Font("Consolas", 12.0F, FontStyle.Bold)
            .Location = New System.Drawing.Point(410, 40)
        End With

        With Me.lblDiskon
            .Size = New System.Drawing.Size(355, 30)
            .TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            .Font = New System.Drawing.Font("Consolas", 12.0F, FontStyle.Bold)
            .Location = New System.Drawing.Point(410, 85)
        End With

        With Me.lblTagTotal
            .Size = New System.Drawing.Size(355, 2)
            .TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            .Location = New System.Drawing.Point(410, 130)
            .BackColor = System.Drawing.Color.FromArgb(200, 200, 200)
        End With

        With Me.lblTotal
            .Size = New System.Drawing.Size(355, 30)
            .TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            .Font = New System.Drawing.Font("Consolas", 12.0F, FontStyle.Bold)
            .Location = New System.Drawing.Point(410, 175)
            .ForeColor = System.Drawing.Color.FromArgb(0, 80, 160)
        End With

        ' ===== Action Buttons =====
        With Me.btnProses
            .Text = "PROSES"
            .Location = New System.Drawing.Point(410, 255)
            .Size = New System.Drawing.Size(110, 50)
            .BackColor = System.Drawing.Color.FromArgb(40, 167, 69)
            .ForeColor = System.Drawing.Color.White
            .FlatStyle = System.Windows.Forms.FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            .Cursor = System.Windows.Forms.Cursors.Hand
        End With

        With Me.btnStruk
            .Text = "CETAK STRUK"
            .Location = New System.Drawing.Point(410, 345)
            .Size = New System.Drawing.Size(110, 50)
            .BackColor = System.Drawing.Color.FromArgb(0, 123, 255)
            .ForeColor = System.Drawing.Color.White
            .FlatStyle = System.Windows.Forms.FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            .Cursor = System.Windows.Forms.Cursors.Hand
        End With

        With Me.btnCSV
            .Text = "SIMPAN CSV"
            .Location = New System.Drawing.Point(654, 255)
            .Size = New System.Drawing.Size(110, 50)
            .BackColor = System.Drawing.Color.FromArgb(108, 117, 125)
            .ForeColor = System.Drawing.Color.White
            .FlatStyle = System.Windows.Forms.FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            .Cursor = System.Windows.Forms.Cursors.Hand
        End With

        With Me.btnReset
            .Text = "RESET"
            .Location = New System.Drawing.Point(654, 345)
            .Size = New System.Drawing.Size(110, 50)
            .BackColor = System.Drawing.Color.FromArgb(220, 53, 69)
            .ForeColor = System.Drawing.Color.White
            .FlatStyle = System.Windows.Forms.FlatStyle.Flat
            .FlatAppearance.BorderSize = 0
            .Cursor = System.Windows.Forms.Cursors.Hand
        End With

        ' ===== Form Settings =====
        With Me
            .AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            .ClientSize = New System.Drawing.Size(800, 450)
            .Text = "Warung Makan - Kasir"
            .BackColor = System.Drawing.Color.FromArgb(248, 249, 250)
            .Font = New System.Drawing.Font("Segoe UI", 9.75F)
            .FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            .MaximizeBox = False
            .MinimizeBox = False
            .StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
