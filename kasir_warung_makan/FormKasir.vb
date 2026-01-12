Public Class FormKasir
    Dim subtotal As New Decimal
    Dim diskon As New Decimal
    Dim total As New Decimal
    Dim bayar As New Decimal
    Dim noTransaksi As New Integer
    Dim tanggalTransaksi As New Date
    Dim struk As New System.Text.StringBuilder()

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        subtotal = 0D
        diskon = 0D
        total = 0D
        bayar = 0D
        tanggalTransaksi = Date.MinValue
        lstPesanan.Items.Clear()
        menuRadios.ForEach(Sub(rb) rb.Checked = False)
        txtQty.Text = "0"
        UpdateTotalLabel()
    End Sub

    Private Sub BtnCSV_Click(sender As Object, e As EventArgs) Handles btnCSV.Click
        If bayar = 0 OrElse bayar < total Then
            MessageBox.Show(
                "Tidak ada transaksi yang dapat disimpan.",
                "Info",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )
            Return
        End If

        Using sfd As New SaveFileDialog()
            sfd.Filter = "CSV Files (*.csv)|*.csv"
            sfd.Title = "Simpan Pesanan sebagai CSV"
            sfd.FileName = $"pesanan_{tanggalTransaksi:yyyyMMdd}.csv"
            If sfd.ShowDialog() = DialogResult.OK Then
                Using writer As New IO.StreamWriter(sfd.FileName)
                    writer.WriteLine("No. Transaksi,Tanggal,Menu,Jumlah,Harga Satuan,Total")
                    For Each item As CartItem In lstPesanan.Items
                        writer.WriteLine($"{noTransaksi},{tanggalTransaksi:yyyyMMdd_HHmmss},{item.Menu.Name},{item.Qty},{item.Menu.Price},{item.Total}")
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

        Dim kembalian As Decimal = bayar - total

        Dim strukWidth As Integer = 45

        struk.AppendLine(New String("="c, strukWidth))
        struk.AppendLine("STRUK PEMBELIAN".PadLeft((strukWidth + "STRUK PEMBELIAN".Length) \ 2))
        struk.AppendLine(New String("="c, strukWidth))
        struk.AppendLine()
        struk.AppendLine(String.Format("{0,-15}: {1}", "Tanggal", tanggalTransaksi.ToString("yyyy/MM/dd")))
        struk.AppendLine(String.Format("{0,-15}: {1}", "Waktu", tanggalTransaksi.ToString("HH:mm:ss")))
        struk.AppendLine(String.Format("{0,-15}: {1}", "No. Transaksi", noTransaksi))
        struk.AppendLine()
        struk.AppendLine(New String("-"c, strukWidth))
        For Each item As CartItem In lstPesanan.Items
            struk.AppendLine(String.Format("{0,-20} x{1,-5} Rp{2,12:N0}", item.Menu.Name, item.Qty, item.Total))
        Next
        struk.AppendLine(New String("-"c, strukWidth))
        struk.AppendLine()
        struk.AppendLine(String.Format("{0,-27} Rp{1,12:N0}", "Subtotal", subtotal))
        struk.AppendLine(String.Format("{0,-27} Rp{1,12:N0}", "Diskon", diskon))
        struk.AppendLine(String.Format("{0,-27} Rp{1,12:N0}", "Total", total))
        struk.AppendLine(String.Format("{0,-27} Rp{1,12:N0}", "Bayar", bayar))
        struk.AppendLine(String.Format("{0,-27} Rp{1,12:N0}", "Kembalian", kembalian))
        struk.AppendLine()
        struk.AppendLine(New String("="c, strukWidth))
        struk.AppendLine("Terima kasih atas kunjungan Anda!".PadLeft((strukWidth + "Terima kasih atas kunjungan Anda!".Length) \ 2))
        struk.AppendLine(New String("="c, strukWidth))

        Using frm As New Form With {
            .Text = "Struk Pembayaran",
            .StartPosition = FormStartPosition.CenterScreen,
            .Size = New Size(360, 460),
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
                .Text = struk.ToString()
            }

            frm.Controls.Add(txtStruk)
            AddHandler frm.Shown, Sub() frm.ActiveControl = Nothing
            frm.ShowDialog()
        End Using

        struk.Clear()
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

            If Not Decimal.TryParse(inputBayar, bayar) Then
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

            Exit Do
        Loop

        noTransaksi += 1
        tanggalTransaksi = Date.Now

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

        Dim menu As MenuItem = TryCast(selectedRb.Tag, MenuItem)

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

        selectedRb.Checked = False
        txtQty.Text = "0"
        txtQty.Focus()
    End Sub

    Private Sub UpdateTotalLabel()
        lblSubtotal.Text = String.Format("{0,-15}Rp{1,12:N0}", "Subtotal", subtotal)
        lblDiskon.Text = String.Format("{0,-15}Rp{1,12:N0}", "Diskon", diskon)
        lblTotal.Text = String.Format("{0,-15}Rp{1,12:N0}", "Total", total)
    End Sub

End Class
