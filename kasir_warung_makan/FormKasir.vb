Public Class FormKasir
    Dim subtotal As Integer = 0
    Dim diskon As Integer = 0
    Dim total As Integer = 0
    Dim bayar As Integer = 0
    Dim noTransaksi As Integer = 0

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        subtotal = 0
        diskon = 0
        total = 0
        bayar = 0
        lstPesanan.Items.Clear()
        txtQty.Text = "0"
        UpdateTotalLabel()
    End Sub

    Private Sub BtnCSV_Click(sender As Object, e As EventArgs) Handles btnCSV.Click
        If lstPesanan.Items.Count = 0 Then
            MessageBox.Show(
                "Tidak ada pesanan untuk disimpan",
                "Info",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )
            Return
        End If

        Using sfd As New SaveFileDialog()
            sfd.Filter = "CSV Files (*.csv)|*.csv"
            sfd.Title = "Simpan Pesanan sebagai CSV"
            sfd.FileName = $"pesanan_{DateTime.Now:yyyyMMdd}.csv"
            If sfd.ShowDialog() = DialogResult.OK Then
                Using writer As New IO.StreamWriter(sfd.FileName)
                    writer.WriteLine("No. Transaksi,Tanggal,Menu,Jumlah,Harga Satuan,Total")
                    For Each item As CartItem In lstPesanan.Items
                        writer.WriteLine($"{noTransaksi},{DateTime.Now:yyyyMMdd_HHmmss},{item.Menu.Name},{item.Qty},{item.Menu.Price},{item.Total}")
                    Next
                    writer.WriteLine($",,Subtotal,,,{subtotal}")
                    writer.WriteLine($",,Diskon,,,{diskon}")
                    writer.WriteLine($",,Total,,,{total}")
                End Using
                MessageBox.Show(
                    "Pesanan berhasil disimpan sebagai CSV",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )
            End If
        End Using
    End Sub

    Private Sub BtnStruk_Click(sender As Object, e As EventArgs) Handles btnStruk.Click
        If bayar = 0 OrElse bayar < total Then
            MessageBox.Show(
                "Pembayaran belum dilakukan",
                "Info",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )
            Return
        End If

        Dim kembalian As Integer = bayar - total

        Dim struk As String = "===== STRUK PEMBAYARAN =====" & Environment.NewLine
        struk &= $"No. Transaksi: {noTransaksi}" & Environment.NewLine
        struk &= "----------------------------" & Environment.NewLine

        For Each item As CartItem In lstPesanan.Items
            struk &= $"{item.Menu.Name} x{item.Qty} = Rp{item.Total:N0}" & Environment.NewLine
        Next

        struk &= "----------------------------" & Environment.NewLine
        struk &= String.Format("{0,-20}Rp{1,12:N0}" & Environment.NewLine, "Subtotal", subtotal)
        struk &= String.Format("{0,-20}Rp{1,12:N0}" & Environment.NewLine, "Diskon", diskon)
        struk &= String.Format("{0,-20}Rp{1,12:N0}" & Environment.NewLine, "Total", total)
        struk &= String.Format("{0,-20}Rp{1,12:N0}" & Environment.NewLine, "Bayar", bayar)
        struk &= String.Format("{0,-20}Rp{1,12:N0}" & Environment.NewLine, "Kembalian", kembalian)
        struk &= "============================" & Environment.NewLine

        Using frm As New Form With {
            .Text = "Struk Pembayaran",
            .StartPosition = FormStartPosition.CenterScreen,
            .Size = New Size(360, 500),
            .FormBorderStyle = FormBorderStyle.FixedDialog,
            .MaximizeBox = False,
            .MinimizeBox = False
        }

            Dim txtStruk As New TextBox With {
                .Multiline = True,
                .ReadOnly = True,
                .Dock = DockStyle.Fill,
                .Font = New Font("Consolas", 10),
                .ScrollBars = ScrollBars.Vertical,
                .Text = struk
            }

            frm.Controls.Add(txtStruk)
            frm.ShowDialog()
        End Using
    End Sub

    Private Sub BtnProses_Click(sender As Object, e As EventArgs) Handles btnProses.Click
        If lstPesanan.Items.Count = 0 Then
            MessageBox.Show(
                "Tidak ada pesanan untuk diproses",
                "Info",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )
            Return
        End If

        If bayar > total Then
            MessageBox.Show(
                "Silahkan selesaikan transaksi sebelumnya",
                "Info",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )
            Return
        End If

        Dim valid As Boolean = False

        Do
            Dim inputBayar As String = InputBox("Masukkan jumlah bayar (dalam Rupiah):", "Pembayaran", "0")

            If String.IsNullOrWhiteSpace(inputBayar) Then
                MessageBox.Show(
                    "Pembayaran dibatalkan.",
                    "Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                )
                Exit Sub
            End If

            If Not Integer.TryParse(inputBayar, bayar) Then
                MessageBox.Show(
                    "Masukkan angka yang valid!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )
                Continue Do
            End If

            If bayar < 0 Then
                MessageBox.Show(
                    "Jumlah bayar tidak boleh negatif!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )
                Continue Do
            End If

            If bayar < total Then
                MessageBox.Show(
                    "Jumlah pembayaran tidak mencukupi!",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                )
                Continue Do
            End If

            valid = True
        Loop Until valid

        noTransaksi += 1

        MessageBox.Show(
            "Pembayaran berhasil diproses!",
            "Info",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If lstPesanan.SelectedItem Is Nothing Then
            MessageBox.Show(
                "Pilih item yang ingin dihapus!",
                "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            Return
        End If

        Dim item As CartItem = lstPesanan.SelectedItem

        subtotal -= item.Total
        lstPesanan.Items.Remove(item)

        diskon = CalculateDiscount(subtotal)
        total = subtotal - diskon

        UpdateTotalLabel()
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim selectedRb = menuRadios.FirstOrDefault(Function(rb) rb.Checked)
        If selectedRb Is Nothing Then
            MessageBox.Show(
                "Pilih menu terlebih dahulu!",
                "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            Return
        End If

        Dim menu As MenuItem = CType(selectedRb.Tag, MenuItem)

        Dim qty As Integer
        If Not Integer.TryParse(txtQty.Text, qty) OrElse qty <= 0 Then
            MessageBox.Show(
                "Masukkan jumlah yang valid (lebih dari 0)!",
                "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )
            txtQty.Focus()
            Return
        End If

        Dim existingItem As CartItem =
            lstPesanan.Items.Cast(Of CartItem)().
            FirstOrDefault(Function(i) i.Menu.Code = menu.Code)

        If existingItem IsNot Nothing Then
            existingItem.Qty += qty
            Dim index = lstPesanan.Items.IndexOf(existingItem)
            lstPesanan.Items(index) = existingItem
        Else
            Dim newItem As New CartItem With {
                .Menu = menu,
                .Qty = qty
            }
            lstPesanan.Items.Add(newItem)
        End If

        subtotal = lstPesanan.Items.Cast(Of CartItem)().Sum(Function(i) i.Total)
        diskon = CalculateDiscount(subtotal)
        total = subtotal - diskon

        UpdateTotalLabel()

        txtQty.Text = "0"
        txtQty.Focus()
    End Sub

    Private Sub UpdateTotalLabel()
        lblSubtotal.Text = String.Format("{0,-15}Rp{1,12:N0}", "Subtotal", subtotal)
        lblDiskon.Text = String.Format("{0,-15}Rp{1,12:N0}", "Diskon", diskon)
        lblTotal.Text = String.Format("{0,-15}Rp{1,12:N0}", "Total", total)
    End Sub

End Class
