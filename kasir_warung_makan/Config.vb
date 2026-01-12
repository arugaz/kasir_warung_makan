Module Config
    ' ===== User Auth =====
    Friend Const DefaultUsername As String = "kasir"
    Friend Const DefaultPassword As String = "1234"

    ' ===== Menu Items =====
    Friend Class MenuItem
        Public Property Code As String
        Public Property Name As String
        Public Property Price As Decimal
    End Class

    Friend ReadOnly MenuItems As New List(Of MenuItem) From {
        New MenuItem With {.Code = "M001", .Name = "Nasi Goreng", .Price = 15_000D},
        New MenuItem With {.Code = "M002", .Name = "Mie Goreng", .Price = 12_000D},
        New MenuItem With {.Code = "M003", .Name = "Ayam Bakar", .Price = 20_000D},
        New MenuItem With {.Code = "M004", .Name = "Es Teh", .Price = 5_000D}
    }

    Friend Class CartItem
        Public Property Menu As MenuItem
        Public Property Qty As Integer
        Public ReadOnly Property Total As Decimal
            Get
                Return Menu.Price * Qty
            End Get
        End Property

        Public Overrides Function ToString() As String
            Return String.Format("{0,-17} x{1,-12} Rp{2,12:N0}", Menu.Name, Qty, Total)
        End Function
    End Class


    ' ===== Discount Rules =====
    Friend Class DiscountRule
        Public MinSubtotal As Decimal
        Public Percent As Decimal
    End Class

    Friend ReadOnly DiscountRules As New List(Of DiscountRule) From {
        New DiscountRule With {.MinSubtotal = 100_000D, .Percent = 15D},
        New DiscountRule With {.MinSubtotal = 50_000, .Percent = 10D}
    }

    Friend Function CalculateDiscount(subtotal As Decimal) As Decimal
        Dim rule =
            DiscountRules.
            Where(Function(r) subtotal >= r.MinSubtotal).
            OrderByDescending(Function(r) r.MinSubtotal).
            FirstOrDefault()

        If rule Is Nothing Then Return 0D

        Return subtotal * (rule.Percent / 100D)
    End Function


End Module
